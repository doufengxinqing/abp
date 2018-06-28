﻿using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore
{
    public class BookStoreDbContext : AbpDbContext<BookStoreDbContext>
    {
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureIdentity();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();

            //builder.Entity<MyEntity>(b =>
            //{
            //    b.ToTable(BookStoreConsts.DbTablePrefix + "PermissionGrants", BookStoreConsts.DbSchema);

            //    ...
            //});
        }
    }
}