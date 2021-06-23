using System.Threading.Tasks;

namespace Projeto_Curso_full_stack.Domain.Aggregates.EmployeeRole.Interfaces.Services
{
    interface IEmployeeRoleService
    {
        Task<Entities.EmployeeRole> AddEmployeeRole(Entities.EmployeeRole employeeRole);
    }
}
