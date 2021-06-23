using System.Threading.Tasks;

namespace Projeto_Curso_full_stack.Domain.Aggregates.Employee.Interfaces.Services
{
    public interface IEmployeeService
    {
        Task<Entities.Employee> AddEmployee(Entities.Employee employee);
    }
}
