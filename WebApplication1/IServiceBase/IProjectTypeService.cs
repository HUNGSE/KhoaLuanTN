using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;
using IServiceBase;
namespace IServices
{
    public interface IProjectTypeService : IBaseService<ProjectTypes>
    {
        IEnumerable<Projects> GetProjectByIDProjectType(int id);
    }
}
