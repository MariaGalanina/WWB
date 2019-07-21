using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication.Models
{
    public class Competence
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        [Display(Name = "Наименование компетенции")]
        public string Name { get; set; }
        public int? SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
    public class CompetenceContext : DbContext
    {
        public CompetenceContext()
            : base("DefaultConnection")
        { }
        public DbSet<Competence> Competences { get; set; }
    }

    public class AcceptComp : DbContext
    {
        public DbSet<Competence> Competences { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
    }

    public class CompetenceDbInitializer : DropCreateDatabaseAlways<CompetenceContext>
    {
        protected override void Seed(CompetenceContext db)
        {
            db.Competences.Add(new Competence { Name = "Компетенция 1" });
            db.Competences.Add(new Competence { Name = "Компетенция 2" });
            db.Competences.Add(new Competence { Name = "Компетенция 3" });
            db.Competences.Add(new Competence { Name = "Компетенция 4" });
            db.Competences.Add(new Competence { Name = "Компетенция 5" });
            db.Competences.Add(new Competence { Name = "Компетенция 6" });


            base.Seed(db);
        }
    }
}