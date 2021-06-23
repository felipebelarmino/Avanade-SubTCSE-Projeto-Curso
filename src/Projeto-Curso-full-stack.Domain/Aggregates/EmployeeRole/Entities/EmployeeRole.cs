using System;
using System.Collections.Generic;
namespace Projeto_Curso_full_stack.Domain.Aggregates.EmployeeRole.Entities
{
    public class EmployeeRole : BaseEntity<string>
    {
        public EmployeeRole(string id, string roleName)
        {
            Id = id;
            RoleName = roleName;
        }
        public EmployeeRole(string roleName)
        {
            RoleName = roleName;
        }
        public string Id { get; init; }

        public string RoleName { get; init; }
    }
}
