﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasData(
            //               new Employee
            //               {
            //                   Id = 1,
            //                   Name = "mohammad",
            //                   Email = "mohammad@gmail.com",
            //                   Department = Dept.HR
            //               },
            //               new Employee
            //               {
            //                   Id = 2,
            //                   Name = "ahmad",
            //                   Email = "ahmad@gmail.com",
            //                   Department = Dept.IT
            //               }
            //       );
        }
    }
}
