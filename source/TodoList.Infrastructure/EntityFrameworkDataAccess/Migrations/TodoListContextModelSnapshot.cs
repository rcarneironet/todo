// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TodoList.Infrastructure.EntityFrameworkDataAccess;

namespace TodoList.Infrastructure.EntityFrameworkDataAccess.Migrations
{
    [DbContext(typeof(TodoListContext))]
    partial class TodoListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TodoList.Core.Entities.TodoItem", b =>
            {
                b.Property<Guid>("Id")
                    .ValueGeneratedOnAdd();

                b.Property<bool>("IsCompleted");

                b.Property<string>("Title");

                b.HasKey("Id");

                b.ToTable("TodoItem");

                b.HasData(
                    new
                    {
                        Id = new Guid("3b35f11e-7080-45e2-a152-afff5a325508"),
                            IsCompleted = false,
                            Title = "Create Repository"
                    },
                    new
                    {
                        Id = new Guid("4b2f8170-c618-4cd6-91b9-25e3b2bfa53e"),
                            IsCompleted = false,
                            Title = "Create solution"
                    },
                    new
                    {
                        Id = new Guid("360644f3-abb5-410b-939d-78a6d07bd075"),
                            IsCompleted = false,
                            Title = "Add projects"
                    },
                    new
                    {
                        Id = new Guid("f1f0adf8-255f-45ef-9528-d6c2c326240b"),
                            IsCompleted = false,
                            Title = "Commit code"
                    },
                    new
                    {
                        Id = new Guid("72af359b-48d7-41cd-978b-38c82e1206d4"),
                            IsCompleted = false,
                            Title = "Push"
                    });
            });
#pragma warning restore 612, 618
        }
    }
}