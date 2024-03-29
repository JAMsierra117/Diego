﻿// <auto-generated />
using Diego.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Diego.Migrations
{
    [DbContext(typeof(CatalogosContext))]
    [Migration("20190322063234_ForeiKeyClasificaciones")]
    partial class ForeiKeyClasificaciones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Diego.Models.Catalogos.Clasificacion", b =>
                {
                    b.Property<int>("ID_Clasificacion")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion");

                    b.HasKey("ID_Clasificacion");

                    b.ToTable("Clasificaciones");
                });

            modelBuilder.Entity("Diego.Models.Catalogos.Producto", b =>
                {
                    b.Property<int>("ID_Producto")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoProducto");

                    b.Property<int>("ID_Clasificacion");

                    b.Property<string>("NombreProducto");

                    b.HasKey("ID_Producto");

                    b.HasIndex("ID_Clasificacion");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Diego.Models.Catalogos.Producto", b =>
                {
                    b.HasOne("Diego.Models.Catalogos.Clasificacion", "Clasificacion")
                        .WithMany("Productos")
                        .HasForeignKey("ID_Clasificacion")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
