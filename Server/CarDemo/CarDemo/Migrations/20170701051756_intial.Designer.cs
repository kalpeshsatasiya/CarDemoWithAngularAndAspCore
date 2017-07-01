using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CarDemo.Models;

namespace CarDemo.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20170701051756_intial")]
    partial class intial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarDemo.Models.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Color");

                    b.Property<double>("Cost");

                    b.Property<int>("Make");

                    b.Property<string>("Model");

                    b.Property<string>("Picture");

                    b.Property<int>("Year");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });
        }
    }
}
