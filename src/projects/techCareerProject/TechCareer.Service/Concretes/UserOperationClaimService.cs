﻿using Core.Persistence.Extensions;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechCareer.DataAccess.Repositories.Abstracts;
using TechCareer.Service.Abstracts;

namespace TechCareer.Service.Concretes
{
    public class UserOperationClaimService : IUserOperationClaimService
    {
        private readonly IUserOperationClaimRepository _userOperationClaimRepository;

        public UserOperationClaimService(IUserOperationClaimRepository userOperationClaimRepository)
        {
            _userOperationClaimRepository = userOperationClaimRepository;
        }

        public async Task<UserOperationClaim> AddAsync(UserOperationClaim userOperationClaim)
        {
            UserOperationClaim addedUserOperationClaim = await _userOperationClaimRepository.AddAsync(userOperationClaim);

            return addedUserOperationClaim;
        }

        public async Task<UserOperationClaim> DeleteAsync(UserOperationClaim userOperationClaim, bool permanent = false)
        {
            var deletedUserOperationClaim = (await GetListAsync(x => x.Id == userOperationClaim.Id)).FirstOrDefault();

            deletedUserOperationClaim.IsDeleted = true;

            return deletedUserOperationClaim;
        }

        public async Task<UserOperationClaim?> GetAsync(Expression<Func<UserOperationClaim, bool>> predicate, bool include = false, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            var userOperationClaim = await _userOperationClaimRepository.GetAsync(predicate);

            return userOperationClaim;
        }

        public async Task<List<UserOperationClaim>> GetListAsync(Expression<Func<UserOperationClaim, bool>>? predicate = null, Func<IQueryable<UserOperationClaim>, IOrderedQueryable<UserOperationClaim>>? orderBy = null, bool include = false, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            var userOperationClaims = await _userOperationClaimRepository.GetListAsync();
            return userOperationClaims;
        }

        public async Task<Paginate<UserOperationClaim>> GetPaginateAsync(Expression<Func<UserOperationClaim, bool>>? predicate = null, Func<IQueryable<UserOperationClaim>, IOrderedQueryable<UserOperationClaim>>? orderBy = null, bool include = false, int index = 0, int size = 10, bool withDeleted = false, bool enableTracking = true, CancellationToken cancellationToken = default)
        {
            IQueryable<UserOperationClaim> userOperationClaims = (IQueryable<UserOperationClaim>)_userOperationClaimRepository.GetListAsync();

            if (!withDeleted)
               userOperationClaims = userOperationClaims.Where(c => !c.IsDeleted);
            if (predicate != null)          
               userOperationClaims = userOperationClaims.Where(predicate);
            if (!enableTracking)
               userOperationClaims = userOperationClaims.AsNoTracking();
            

            int totalItems = await userOperationClaims.CountAsync(cancellationToken);

            List<UserOperationClaim> items = await userOperationClaims
                .Skip(index * size)
                .Take(size)
                .ToListAsync(cancellationToken);

            return new Paginate<UserOperationClaim>
            {
                Items = items,
                Index = index,
                Size = size,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(totalItems / (double)size)
            };
        }

        public async Task<UserOperationClaim> UpdateAsync(UserOperationClaim userOperationClaim)
        {
            var updatedUserOperationClaim = (await GetListAsync(x => x.Id == userOperationClaim.Id)).FirstOrDefault();
            if (updatedUserOperationClaim != null)
            {
                updatedUserOperationClaim = userOperationClaim;
                return updatedUserOperationClaim;
            }
            else
            {
                throw new InvalidOperationException("Aradığınız kategori bulunamamıştır."); // Doğru hata fırlatma
            }
        }

        private UserOperationClaim NullReferenceException(string v)
        {
            throw new NotImplementedException();
        }
    }
}
