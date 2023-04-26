﻿using DevFreela.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
    public class Project : BaseEntity
    {
        public Project(string title, string description, int idClient, int idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            IdClient = idClient;
            IdFreelancer = idFreelancer;
            TotalCost = totalCost;
            CreatedAt = DateTime.Now;
            ProjectComments = new List<ProjectComment>();
            Status = ProjectStatusEnum.Created;
        }

        public string Title { get; private set; }
        public string Description { get; private set; } 
        public int IdClient { get; private set; }
        public int IdFreelancer { get; private set; }
        public decimal TotalCost { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime StartedAt { get; private set; }
        public DateTime FinishedAt { get; private set; }
        public ProjectStatusEnum Status { get; private set; }
        public List<ProjectComment> ProjectComments { get; private set; }
    }
}