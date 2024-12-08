﻿using AutoMapper;
using Core.AOP.Aspects;
using Core.Persistence.Extensions;
using Core.Security.Dtos;
using Core.Security.Entities;
using Core.Security.Hashing;
using Core.Security.JWT;
using TechCareer.Models.Dtos.Users;
using TechCareer.Service.Abstracts;
using TechCareer.Service.Rules;
using TechCareer.Service.Validations.Users;

namespace TechCareer.Service.Concretes;

public sealed class AuthService : IAuthService
{


    private readonly IUserBusinessRules _rules;
    private readonly IUserWithTokenService _tokenService;
    private readonly IUserService _userService;
    private readonly IMapper _mapper;
    public AuthService(IUserBusinessRules rules, IUserWithTokenService tokenService, IUserService userService, IMapper mapper)
    {
        _rules = rules;
        _tokenService = tokenService;
        _userService = userService;
        _mapper = mapper;
    }


    [ValidationAspect(typeof(LoginValidator))]
    [LoggerAspect]
    public async Task<AccessToken> LoginAsync(UserForLoginDto dto, CancellationToken cancellationToken)
    {
        User? user = await _userService.GetAsync(
            predicate: u => u.Email == dto.Email,
            cancellationToken: cancellationToken
        );

        await _rules.UserShouldBeExistsWhenSelected(user);
        await _rules.UserPasswordShouldBeMatched(user!, dto.Password);

        AccessToken createdAccessToken = await _tokenService.CreateAccessToken(user!);

        return createdAccessToken;

    }

    [ClearCacheAspect("Users")]
    public async Task<AccessToken> RegisterAsync(UserForRegisterDto dto, CancellationToken cancellationToken)
    {
        HashingHelper.CreatePasswordHash(
            dto.Password,
            passwordHash: out byte[] passwordHash,
            passwordSalt: out byte[] passwordSalt
        );

        User newUser =
              new()
              {
                  Email = dto.Email,
                  FirstName = dto.FirstName,
                  LastName = dto.LastName,
                  PasswordHash = passwordHash,
                  PasswordSalt = passwordSalt,
                  Status = true
              };

        User createdUser = await _userService.AddAsync(newUser);
        AccessToken createdAccessToken = await _tokenService.CreateAccessToken(createdUser);

        return createdAccessToken;
    }

    [CacheAspect(cacheKeyTemplate: "Users({page},{size})", bypassCache: false, cacheGroupKey: "Users")]
    public async Task<Paginate<UserResponseDto>> GetAllPaginateAsync(int page, int size)
    {
        var users = await _userService.GetPaginateAsync(index: page, size: size, include: false);
        var response = _mapper.Map<Paginate<UserResponseDto>>(users);
        return response;
    }


}