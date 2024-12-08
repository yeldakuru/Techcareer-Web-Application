﻿using Core.CrossCuttingConcerns.Serilog;
using Core.Persistence.Extensions;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using TechCareer.DataAccess.Repositories.Abstracts;
using TechCareer.Models.Dtos.VideoEducation;
using TechCareer.Service.Abstracts;

namespace TechCareer.Service.Concretes
{
    public class VideoEducationService : IVideoEducationService
    {
        private readonly IVideoEducationRepository _videoEducationRepository;
        private readonly LoggerServiceBase _logger;

        public VideoEducationService(IVideoEducationRepository videoEducationRepository, LoggerServiceBase logger)
        {
            _videoEducationRepository = videoEducationRepository;
            _logger = logger;
        }

        public async Task<VideoEducationResponseDto?> GetAsync(
            Expression<Func<VideoEducation, bool>> predicate,
            bool include = false,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var videoEducation = await _videoEducationRepository.GetAsync(predicate, withDeleted: withDeleted);

                if (videoEducation == null)
                    return null;

                return new VideoEducationResponseDto
                {
                    Id = videoEducation.Id,
                    Title = videoEducation.Title,
                    Description = videoEducation.Description,
                    TotalHour = videoEducation.TotalHour,
                    IsCertified = videoEducation.IsCertified,
                    Level = videoEducation.Level,
                    ImageUrl = videoEducation.ImageUrl,
                    InstructorId = videoEducation.InstructorId,
                    ProgrammingLanguage = videoEducation.ProgrammingLanguage
                };
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }

        public async Task<Paginate<VideoEducationResponseDto>> GetPaginateAsync(
            Expression<Func<VideoEducation, bool>>? predicate = null,
            Func<IQueryable<VideoEducation>, IOrderedQueryable<VideoEducation>>? orderBy = null,
            bool include = false,
            int index = 0,
            int size = 10,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var paginateResult = await _videoEducationRepository.GetPaginateAsync(predicate, index: index, size: size, enableTracking: enableTracking, withDeleted: withDeleted);

                return new Paginate<VideoEducationResponseDto>
                {
                    Items = paginateResult.Items.Select(videoEducation => new VideoEducationResponseDto
                    {
                        Id = videoEducation.Id,
                        Title = videoEducation.Title,
                        Description = videoEducation.Description,
                        TotalHour = videoEducation.TotalHour,
                        IsCertified = videoEducation.IsCertified,
                        Level = videoEducation.Level,
                        ImageUrl = videoEducation.ImageUrl,
                        InstructorId = videoEducation.InstructorId,
                        ProgrammingLanguage = videoEducation.ProgrammingLanguage
                    }).ToList(),
                    Index = paginateResult.Index,
                    Size = paginateResult.Size,
                    TotalItems = paginateResult.TotalItems,
                    TotalPages = paginateResult.TotalPages
                };
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }

        public async Task<List<VideoEducationResponseDto>> GetListAsync(
            Expression<Func<VideoEducation, bool>>? predicate = null,
            Func<IQueryable<VideoEducation>, IOrderedQueryable<VideoEducation>>? orderBy = null,
            bool include = false,
            bool withDeleted = false,
            bool enableTracking = true,
            CancellationToken cancellationToken = default)
        {
            try
            {
                var videoEducations = await _videoEducationRepository.GetListAsync(predicate, orderBy, enableTracking, withDeleted);

                return videoEducations.Select(videoEducation => new VideoEducationResponseDto
                {
                    Id = videoEducation.Id,
                    Title = videoEducation.Title,
                    Description = videoEducation.Description,
                    TotalHour = videoEducation.TotalHour,
                    IsCertified = videoEducation.IsCertified,
                    Level = videoEducation.Level,
                    ImageUrl = videoEducation.ImageUrl,
                    InstructorId = videoEducation.InstructorId,
                    ProgrammingLanguage = videoEducation.ProgrammingLanguage
                }).ToList();
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }

        public async Task<VideoEducationResponseDto> AddAsync(VideoEducationAddRequestDto videoEducationAddRequestDto)
        {
            try
            {
                var videoEducation = new VideoEducation
                {
                    Title = videoEducationAddRequestDto.Title,
                    Description = videoEducationAddRequestDto.Description,
                    TotalHour = videoEducationAddRequestDto.TotalHour,
                    IsCertified = videoEducationAddRequestDto.IsCertified,
                    Level = videoEducationAddRequestDto.Level,
                    ImageUrl = videoEducationAddRequestDto.ImageUrl,
                    InstructorId = videoEducationAddRequestDto.InstructorId,
                    ProgrammingLanguage = videoEducationAddRequestDto.ProgrammingLanguage
                };

                var addedVideoEducation = await _videoEducationRepository.AddAsync(videoEducation);

                _logger.Info("Info log: VideoEducation added.");

                return new VideoEducationResponseDto
                {
                    Id = addedVideoEducation.Id,
                    Title = addedVideoEducation.Title,
                    Description = addedVideoEducation.Description,
                    TotalHour = addedVideoEducation.TotalHour,
                    IsCertified = addedVideoEducation.IsCertified,
                    Level = addedVideoEducation.Level,
                    ImageUrl = addedVideoEducation.ImageUrl,
                    InstructorId = addedVideoEducation.InstructorId,
                    ProgrammingLanguage = addedVideoEducation.ProgrammingLanguage
                };
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }

        public async Task<VideoEducationResponseDto> UpdateAsync(VideoEducationUpdateRequestDto videoEducationUpdateRequestDto)
        {
            try
            {
                var videoEducation = await _videoEducationRepository.GetAsync(x => x.Id == videoEducationUpdateRequestDto.Id);

                if (videoEducation == null)
                    throw new ApplicationException("Video Education not found.");

                videoEducation.Title = videoEducationUpdateRequestDto.Title;
                videoEducation.Description = videoEducationUpdateRequestDto.Description;
                videoEducation.TotalHour = videoEducationUpdateRequestDto.TotalHour;
                videoEducation.IsCertified = videoEducationUpdateRequestDto.IsCertified;
                videoEducation.Level = videoEducationUpdateRequestDto.Level;
                videoEducation.ImageUrl = videoEducationUpdateRequestDto.ImageUrl;
                videoEducation.InstructorId = videoEducationUpdateRequestDto.InstructorId;
                videoEducation.ProgrammingLanguage = videoEducationUpdateRequestDto.ProgrammingLanguage;

                var updatedVideoEducation = await _videoEducationRepository.UpdateAsync(videoEducation);

                _logger.Info("Info log: VideoEducation updated.");

                return new VideoEducationResponseDto
                {
                    Id = updatedVideoEducation.Id,
                    Title = updatedVideoEducation.Title,
                    Description = updatedVideoEducation.Description,
                    TotalHour = updatedVideoEducation.TotalHour,
                    IsCertified = updatedVideoEducation.IsCertified,
                    Level = updatedVideoEducation.Level,
                    ImageUrl = updatedVideoEducation.ImageUrl,
                    InstructorId = updatedVideoEducation.InstructorId,
                    ProgrammingLanguage = updatedVideoEducation.ProgrammingLanguage
                };
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }

        public async Task<VideoEducationResponseDto> DeleteAsync(VideoEducationRequestDto videoEducationRequestDto, bool permanent = false)
        {
            try
            {
                var videoEducation = await _videoEducationRepository.GetAsync(
                    x => x.Id == videoEducationRequestDto.Id,
                    withDeleted: true
                );

                if (videoEducation == null)
                    throw new ApplicationException("Video Education not found.");

                if (permanent)
                {
                    await _videoEducationRepository.DeleteAsync(videoEducation, true);
                }
                else
                {
                    videoEducation.IsDeleted = true;
                    await _videoEducationRepository.DeleteAsync(videoEducation);
                }

                _logger.Info("Info log: VideoEducation deleted.");

                return new VideoEducationResponseDto
                {
                    Id = videoEducation.Id,
                    Title = videoEducation.Title,
                    Description = videoEducation.Description,
                    TotalHour = videoEducation.TotalHour,
                    IsCertified = videoEducation.IsCertified,
                    Level = videoEducation.Level,
                    ImageUrl = videoEducation.ImageUrl,
                    InstructorId = videoEducation.InstructorId,
                    ProgrammingLanguage = videoEducation.ProgrammingLanguage
                };
            }
            catch (Exception ex)
            {
                _logger.Error($"Error log: {ex}");
                throw new Exception("An error occurred. Please try again later.", ex);
            }

        }
    }
}
