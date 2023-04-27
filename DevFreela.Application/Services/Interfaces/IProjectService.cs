using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {
        List<ProjectViewModel> GetAll (string query);
        ProjectDetailsViewModel GetById(int id);
        int CreateProject(NewProjectInputModel inputModel);
        void UpdateProject(UpdateProjectInputModel inputModel);
        void CreateComment (CreateCommentInputModel inputModel);
        void DeleteProject(int id);
        void StartProject(int id);
        void FinishProject(int id);
    }
}
