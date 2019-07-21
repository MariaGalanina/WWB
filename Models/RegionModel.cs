using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication.Models
{
    public class Region
    {
        [HiddenInput(DisplayValue = false)] 
        public int Id { get; set; }
        [Display(Name = "Наименование региона")]
        public string Name { get; set; }
        
    }
    public class RegionContext:DbContext
    {
        public RegionContext()
            : base("DefaultConnection")
        { }
        public DbSet<Region> Regions { get; set; }
    }
    public class RegionDbInitializer : DropCreateDatabaseAlways<RegionContext>
    {
        protected override void Seed(RegionContext db)
        {
            db.Regions.Add(new Region { Name = "Нижний Новгород" });
            
            
            base.Seed(db);
        }
    }
}