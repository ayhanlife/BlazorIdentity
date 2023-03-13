using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorIdentity.Data
{
    public class CourseContext : IdentityDbContext
    {

        public CourseContext(DbContextOptions<CourseContext> options)
        : base(options)
        {
        }
        public DbSet<Course> Course { get; set; }
    }
}
