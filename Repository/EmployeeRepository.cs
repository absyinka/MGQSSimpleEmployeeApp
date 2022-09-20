using System;
using System.Collections.Generic;
using SimpleEmployeeApp.Entities;
using SimpleEmployeeApp.Enums;
using SimpleEmployeeApp.Shared;

namespace SimpleEmployeeApp.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Code = Helper.GenerateCode(1),
                FirstName = "Admin",
                LastName =  "Boss",
                Email = "admin@admin.com",
                Password = "password",
                Phone = "08099889988",
                Gender = Gender.Male,
                Role = Role.Admin,
                DateJoined = DateTime.Now
            }
        };
        
        public List<Employee> GetAll()
        {
            return employees;
        }

        public Employee GetByCode(string code)
        {
            return employees.Find(i => i.Code == code);
        }

        public Employee GetById(int id)
        {
            return employees.Find(i => i.Id == id);
        }

        public Employee GetByIdOrCode(int id, string code)
        {
            return employees.Find(i => i.Id == id || i.Code == code);
        }
    }
}