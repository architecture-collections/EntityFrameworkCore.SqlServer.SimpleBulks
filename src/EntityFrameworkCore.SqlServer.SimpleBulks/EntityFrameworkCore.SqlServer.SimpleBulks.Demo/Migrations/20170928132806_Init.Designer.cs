﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using EntityFrameworkCore.SqlServer.SimpleBulks.Demo;
using System;

namespace EntityFrameworkCore.SqlServer.SimpleBulks.Demo.Migrations
{
    [DbContext(typeof(DemoDbContext))]
    [Migration("20170928132806_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleBulkOperations.Demo.Row", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Column1");

                    b.Property<string>("Column2");

                    b.Property<DateTime>("Column3");

                    b.HasKey("Id");

                    b.ToTable("Rows");
                });
#pragma warning restore 612, 618
        }
    }
}