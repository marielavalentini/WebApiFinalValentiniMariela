// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiFinalValentiniMariela.Conection;

namespace WebApiFinalValentiniMariela.Migrations
{
    [DbContext(typeof(DbHospitalContext))]
    [Migration("20221118180118_CrearBase")]
    partial class CrearBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiFinalValentiniMariela.Models.Hospital", b =>
                {
                    b.Property<int>("Hospital_Cod")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nombre")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Num_Camas")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("varchar(50)");

                    b.HasKey("Hospital_Cod");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("WebApiFinalValentiniMariela.Models.Medico", b =>
                {
                    b.Property<int>("Doctor_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Especialidad")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Hospital_Cod")
                        .HasColumnType("int");

                    b.HasKey("Doctor_No");

                    b.ToTable("Doctor");
                });
#pragma warning restore 612, 618
        }
    }
}
