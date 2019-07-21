using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication.Models
{
    public class Speciality
    {
        [HiddenInput(DisplayValue = false)] 
        public int Id { get; set; }
        [Display(Name="Наименование")]
        public string Name { get; set; }
        [Display(Name="Код специальности")]
        public string Kod { get; set; }
    }
    public class SpecialityContext:DbContext
    {
        public SpecialityContext():base("DefaultConnection")
        { }
        public DbSet<Speciality> Specialitys { get; set; }
    }
    public class SpecialityDbInitializer : DropCreateDatabaseAlways<SpecialityContext>
    {
        protected override void Seed(SpecialityContext db)
        {
            db.Specialitys.Add(new Speciality { Name = "Прикладная информатика по отраслям", Kod = "09.02.05" });
            db.Specialitys.Add(new Speciality { Name = "Многоканальные системы управления", Kod = "09.05.12" });
            db.Specialitys.Add(new Speciality { Name = "Эксплуатация сельскохозяйственных машин", Kod = "07.04.09" });
            base.Seed(db);
        }
    }
}