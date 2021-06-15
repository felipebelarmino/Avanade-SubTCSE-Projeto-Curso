using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Curso_full_stack.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }

        public string Id { get; init; }

        public string RoleName { get; init; }
    }

}
