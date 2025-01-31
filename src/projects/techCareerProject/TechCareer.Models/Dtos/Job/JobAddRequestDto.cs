﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCareer.Models.Dtos.Job
{
    public class JobAddRequestDto
    {
        public string Title { get; set; }
        public int TypeOfWork { get; set; }
        public int YearsOfExperience { get; set; }
        public int WorkPlace { get; set; }
        public DateTime StartDate { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Skills { get; set; }
        public int CompanyId { get; set; }
    }
}
