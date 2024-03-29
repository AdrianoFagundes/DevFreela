﻿using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Application.ViewModels;
using DevFreela.Domain.Entities;
using DevFreela.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService : IProjectService
    {
        private readonly DevFreelaDbContext _dbContext;
        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateProject(NewProjectInputModel inputModel)
        {
            var project = new Project(inputModel.Title, inputModel.Description, inputModel.IdClient, inputModel.IdFreelancer, inputModel.TotalCost);
            
            _dbContext.Projects.Add(project);

            return project.Id;
        }

        public void CreateComment(CreateCommentInputModel inputModel)
        {
            var comment = new ProjectComment(inputModel.Content, inputModel.IdProject, inputModel.IdUser);

            _dbContext.ProjectComments.Add(comment);

        }

        public void DeleteProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            
            if (project != null)
            {
                project.CancelProject();
            }
        }

        public void FinishProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            if (project != null)
            {
                project.FinishProject();
            }
        }
            
        public ProjectDetailsViewModel GetById(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p=> p.Id == id);

            var projectDetailsViewModel = new ProjectDetailsViewModel(
                project.Id,
                project.Title,
                project.Description,
                project.TotalCost,
                project.StartedAt,
                project.FinishedAt
                );

            return projectDetailsViewModel;
        }

        public List<ProjectViewModel> GetAll(string query)
        {
            var projects = _dbContext.Projects;

            var projectsViewModel = projects
                .Select(p => new ProjectViewModel(p.Id, p.Title, p.CreatedAt))
                .ToList();

            return projectsViewModel;
        }

        public void StartProject(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);

            if (project != null)
            {
                project.StartProject();
            }
        }

        public void UpdateProject(UpdateProjectInputModel inputModel)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == inputModel.Id);

            if (project != null)
            {
                project.UpdateProject(inputModel.Title, inputModel.Description, inputModel.TotalCost);
            }
        }
    }
}
