using Projeto_Curso_full_stack.Domain.Aggregates.Employee.Interfaces.Services;
using System.Threading.Tasks;

namespace Projeto_Curso_full_stack.Domain.Aggregates.Employee.Services
{
    public class EmployeeService : IEmployeeService
    {
        public async Task<Entities.Employee> AddEmployee(Entities.Employee employee)
        {
            throw new System.NotImplementedException();
        }
    }
}
