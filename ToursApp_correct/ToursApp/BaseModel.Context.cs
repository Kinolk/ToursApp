﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToursApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class toursEntities : DbContext
    {
        private static toursEntities _con;

        public toursEntities()
            : base("name=toursEntities")
        {
        }

        public static toursEntities GetContext()
        {
            if(_con==null)
                _con = new toursEntities();
            return _con;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<HotelComment> HotelComment { get; set; }
        public virtual DbSet<HotelImage> HotelImage { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tours> Tours { get; set; }
        public virtual DbSet<Type> Type { get; set; }
        public virtual DbSet<TypeUsers> TypeUsers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}