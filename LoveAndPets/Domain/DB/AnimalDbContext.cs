using LoveAndPets.Domain.Model.Common;
using LoveAndPets.Model.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
<<<<<<< HEAD
=======
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
 

namespace LoveAndPets.Domain.DB
{
    public class AnimalDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AnimalDbContext(DbContextOptions<AnimalDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        ///пользователи
        public override DbSet<User> Users { get; set; }

        ///сотрудники
        public DbSet<Employee> Employee { get; set; }

        public DbSet<Animals> Animals { get;  set; }

        public DbSet<Services> Services { get; set; }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Breeds> Breeds { get; set; }

<<<<<<< HEAD
        public DbSet<Pets> Pets { get; set; }

=======
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(x =>
            {
                x.HasOne(y => y.Employee)
                .WithOne()
<<<<<<< HEAD
                .IsRequired(true);
=======
                //.HasForeignKey<User>("EmployeeId")
                .IsRequired(true);
               // x.HasIndex("EmployeeId").IsUnique(true);
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
            });
            #region Pets
            modelBuilder.Entity<Pets>(b =>
            {
                b.ToTable("Pet");
                EntityId(b);
                b.Property(x => x.PetName)
                .HasColumnName("PetName").IsRequired();
                b.Property(x => x.AnimalsEntitys)
               .HasColumnName("AnimalId").IsRequired();
                b.Property(x => x.BreedsEntitys)
               .HasColumnName("BreedId").IsRequired();
                b.Property(x => x.EmployeeEntitys)
               .HasColumnName("UserId").IsRequired();
            });
            #endregion

            #region Breeds
            modelBuilder.Entity<Breeds>(b =>
            {
                b.ToTable("Breed");
                EntityId(b);
                b.Property(x => x.AnimalsEntitys)
                .HasColumnName("AnimalId").IsRequired();
                b.Property(x => x.BreedName)
                .HasColumnName("BreedName").IsRequired();                
            });
            #endregion

            #region Animals
            modelBuilder.Entity<Animals>(b =>
            {
                b.ToTable("Animal");
                EntityId(b);
                b.Property(x => x.TypeName)
                .HasColumnName("TypeName").IsRequired();
            });
            #endregion

            #region Services
            modelBuilder.Entity<Services>(b =>
            {
                b.ToTable("Service");
                EntityId(b);
                b.Property(x => x.ServiceName)
                .HasColumnName("ServiceName").IsRequired();
            });
            #endregion

            #region Employee
            modelBuilder.Entity<Employee>(b =>
            {
                b.ToTable("Employees");
                EntityId(b);
                b.Property(x => x.Surname)
                .HasColumnName("Surname").IsRequired();
                b.Ignore(x => x.FullName);

            });
            #endregion

            #region Doctors
            modelBuilder.Entity<Doctors>(b =>
            {
                b.ToTable("Doctor");
                EntityId(b);
                b.Property(x => x.Surname)
                .HasColumnName("Surname").IsRequired();
                b.Property(x => x.ServicesEntitys)
               .HasColumnName("ServiceId").IsRequired();
                
            });
            #endregion

            #region Notes
            modelBuilder.Entity<Notes>(b =>
            {
                b.ToTable("Note");
                EntityId(b);
                b.Property(x => x.ServicesEntitys)
                .HasColumnName("ServiceId").IsRequired();
                b.Property(x => x.DoctorsEntitys)
                .HasColumnName("DoctorId").IsRequired();
                b.Property(x => x.EmployeeEntitys)
               .HasColumnName("UserId").IsRequired();
                b.Property(x => x.PetsEntitys)
               .HasColumnName("PetId").IsRequired();
                b.Property(x => x.DateAppointment)
               .HasColumnName("DateAppointment").IsRequired();
            });
            #endregion

<<<<<<< HEAD
            }
=======
            /*
            #region BlogPost
            modelBuilder.Entity<BlogPost>(b =>
            {
                b.ToTable("BlogPosts");
                EntityId(b);
                b.Property(x => x.Created).HasColumnName("Created")
                .IsRequired();
                b.Property(x => x.Title).HasColumnName("Date")
                .IsRequired();
                b.HasOne(x => x.Owner).WithMany().IsRequired();
            });
            #endregion
            */
        }
>>>>>>> a67234ef46a3b6ee2f739398c8a60f24099773bc
        
        private static void EntityId<TEntity>(EntityTypeBuilder<TEntity> builder)
            where TEntity : Entity
        {
            builder.Property(x => x.Entitys)
                .HasColumnName("Id")
                .IsRequired();
            builder.HasKey(x => x.Entitys).HasAnnotation("Npgsql:Serial", true);
        }
    }
}

