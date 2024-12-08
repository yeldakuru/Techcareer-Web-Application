﻿using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TechCareer.Service.Abstracts;
using Core.Security.Entities;
using Xunit;
using TechCareer.Service.Concretes;
using TechCareer.DataAccess.Repositories.Abstracts;
using TechCareer.Models.Dtos.Job;
using Core.Persistence.Repositories;
using Core.CrossCuttingConcerns.Serilog;
using Core.Persistence.Extensions;

namespace TechCareer.Service.Tests.UnitTests
{
    public class JobServiceTests
    {
        private readonly Mock<IJobRepository> _mockJobRepository;
        private readonly LoggerServiceBase _mockLogger;
        private readonly JobService _jobService;

        public JobServiceTests()
        {
            _mockJobRepository = new Mock<IJobRepository>();
            _mockLogger = new Mock<LoggerServiceBase>().Object; 
            _jobService = new JobService(_mockJobRepository.Object, _mockLogger);
        }
        [Fact]
        public async Task AddAsync_ShouldReturnAddedJob()
        {
          
            var jobAddRequestDto = new JobAddRequestDto
            {
                Title = "Software Developer",
                TypeOfWork = 1,
                YearsOfExperience = 3,
                WorkPlace = 2,
                StartDate = DateTime.UtcNow,
                Content = "Develop software solutions",
                Description = "Work on various projects",
                Skills = "C#, SQL, .NET",
                CompanyId = 1
            };

        
            var expectedJob = new Job
            {
                Title = jobAddRequestDto.Title,
                TypeOfWork = jobAddRequestDto.TypeOfWork,
                YearsOfExperience = jobAddRequestDto.YearsOfExperience,
                WorkPlace = jobAddRequestDto.WorkPlace,
                StartDate = jobAddRequestDto.StartDate,
                Content = jobAddRequestDto.Content,
                Description = jobAddRequestDto.Description,
                Skills = jobAddRequestDto.Skills,
                CompanyId = jobAddRequestDto.CompanyId
            };

           
            _mockJobRepository.Setup(repo => repo.AddAsync(It.IsAny<Job>())).ReturnsAsync(expectedJob);

         
            var mockLogger = new Mock<LoggerServiceBase>();

          
            var jobService = new JobService(_mockJobRepository.Object, mockLogger.Object);

           
            var result = await jobService.AddAsync(jobAddRequestDto);

          
            Assert.NotNull(result);
            Assert.Equal(expectedJob.Title, result.Title);
            Assert.Equal(expectedJob.TypeOfWork, result.TypeOfWork);
            Assert.Equal(expectedJob.YearsOfExperience, result.YearsOfExperience);

            _mockJobRepository.Verify(repo => repo.AddAsync(It.IsAny<Job>()), Times.Once);
        }



        [Fact]
        public async Task GetAsync_ShouldReturnJob()
        {
            var job = new Job
            {
                Id = 1,
                Title = "Software Developer",
                TypeOfWork = 1,
                YearsOfExperience = 3,
                WorkPlace = 2,
                StartDate = DateTime.UtcNow,
                Content = "Develop software solutions",
                Description = "Work on various projects",
                Skills = "C#, SQL, .NET",
                CompanyId = 1
            };

            _mockJobRepository.Setup(repo => repo.GetAsync(It.IsAny<Expression<Func<Job, bool>>>(),
                    true, false, true, It.IsAny<CancellationToken>()))
                .ReturnsAsync(job);

            var result = await _jobService.GetAsync(x => x.Id == 1);

            Assert.NotNull(result);
            Assert.Equal("Software Developer", result.Title);
        }

        [Fact]
        public async Task GetListAsync_ShouldReturnJobList()
        {
            var jobs = new List<Job>
            {
                new Job { Id = 1, Title = "Software Developer" },
                new Job { Id = 2, Title = "Product Manager" }
            };

            _mockJobRepository.Setup(repo => repo.GetListAsync(It.IsAny<Expression<Func<Job, bool>>>(),
                    null, true, false, true, It.IsAny<CancellationToken>()))
                .ReturnsAsync(jobs);

            var result = await _jobService.GetListAsync(x => x.TypeOfWork == 1);

            Assert.NotNull(result);
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task GetPaginateAsync_ShouldReturnPaginatedResults()
        {
            var jobs = new List<Job>
            {
                new Job { Id = 1, Title = "Software Developer" },
                new Job { Id = 2, Title = "Product Manager" },
                new Job { Id = 3, Title = "Data Analyst" }
            };

            _mockJobRepository.Setup(repo => repo.GetPaginateAsync(It.IsAny<Expression<Func<Job, bool>>>(),
                    It.IsAny<Func<IQueryable<Job>, IOrderedQueryable<Job>>>(), true, 0, 2, false, true, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new Paginate<Job> { TotalItems = 3, Items = jobs.Take(2).ToList() });

            var result = await _jobService.GetPaginateAsync(index: 0, size: 2);

            Assert.NotNull(result);
            Assert.Equal(3, result.TotalItems);
            Assert.Equal(2, result.Items.Count);
        }

        [Fact]
        public async Task DeleteAsync_ShouldMarkAsDeleted_WhenJobIsFound()
        {
            var job = new Job
            {
                Id = 2,
                Title = "Software Developer",
                IsDeleted = false,
                TypeOfWork = 1,
                YearsOfExperience = 3,
                WorkPlace = 2,
                StartDate = DateTime.UtcNow,
                Content = "Develop software solutions",
                Description = "Work on various projects",
                Skills = "C#, SQL, .NET",
                CompanyId = 1
            };

            var jobRequestDto = new JobRequestDto
            {
                Id = job.Id,
                CompanyId = job.CompanyId
            };

            _mockJobRepository.Setup(repo => repo.GetListAsync(It.IsAny<Expression<Func<Job, bool>>>(),
                    null, true, false, true, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<Job> { job });

            _mockJobRepository.Setup(repo => repo.UpdateAsync(It.Is<Job>(j => j.Id == job.Id && j.IsDeleted == true)))
                .ReturnsAsync(job);

            var result = await _jobService.DeleteAsync(jobRequestDto);

            Assert.True(job.IsDeleted);

            _mockJobRepository.Verify(repo => repo.UpdateAsync(It.Is<Job>(j => j.Id == job.Id && j.IsDeleted == true)), Times.Once);
        }

        [Fact]
        public async Task UpdateAsync_ShouldReturnUpdatedJob()
        {
            var jobUpdateRequestDto = new JobUpdateRequestDto
            {
                Id = 1,
                Title = "Senior Software Developer",
                Description = "Lead development projects",
                TypeOfWork = 2,
                YearsOfExperience = 5,
                WorkPlace = 3,
                StartDate = DateTime.UtcNow,
                Content = "Lead the development team",
                Skills = "C#, .NET, Leadership",
                CompanyId = 1
            };

            var existingJob = new Job
            {
                Id = 1,
                Title = "Software Developer",
                Description = "Develop software solutions",
                TypeOfWork = 1,
                YearsOfExperience = 3,
                WorkPlace = 2,
                StartDate = DateTime.UtcNow,
                Content = "Develop software solutions",
                Skills = "C#, SQL, .NET",
                CompanyId = 1
            };

            _mockJobRepository.Setup(repo => repo.GetAsync(It.IsAny<Expression<Func<Job, bool>>>(),
                    true, false, true, It.IsAny<CancellationToken>()))
                .ReturnsAsync(existingJob);

            _mockJobRepository.Setup(repo => repo.UpdateAsync(It.IsAny<Job>()))
                .ReturnsAsync(existingJob);

            var result = await _jobService.UpdateAsync(jobUpdateRequestDto);

            Assert.NotNull(result);
            Assert.Equal(jobUpdateRequestDto.Title, result.Title);
            Assert.Equal(jobUpdateRequestDto.Description, result.Description);
            Assert.Equal(jobUpdateRequestDto.TypeOfWork, result.TypeOfWork);
            Assert.Equal(jobUpdateRequestDto.YearsOfExperience, result.YearsOfExperience);
            Assert.Equal(jobUpdateRequestDto.WorkPlace, result.WorkPlace);
            Assert.Equal(jobUpdateRequestDto.StartDate, result.StartDate);
            Assert.Equal(jobUpdateRequestDto.Content, result.Content);
            Assert.Equal(jobUpdateRequestDto.Skills, result.Skills);
            Assert.Equal(jobUpdateRequestDto.CompanyId, result.CompanyId);

            _mockJobRepository.Verify(repo => repo.GetAsync(It.IsAny<Expression<Func<Job, bool>>>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<bool>(), It.IsAny<CancellationToken>()), Times.Once);
            _mockJobRepository.Verify(repo => repo.UpdateAsync(It.IsAny<Job>()), Times.Once);
        }
    }
}