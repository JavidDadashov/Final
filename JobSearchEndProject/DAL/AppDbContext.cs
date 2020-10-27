﻿using JobSearchEndProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobSearchEndProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<GeneralInformation> GeneralInformation { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Loaction> Loactions { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<EducationDetail> EducationDetails { get; set; }

    }
}