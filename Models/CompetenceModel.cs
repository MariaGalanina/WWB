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
        public int Id { get; set; }
        [Display(Name = "Наименование компетенции")]
        public string Name { get; set; }
        public int? SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
    public class CompetenceContext : DbContext
    {
        public DbSet<Competence> Competences { get; set; }

        public System.Data.Entity.DbSet<WebApplication.Models.Speciality> Specialities { get; set; }
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
            db.Competences.Add(new Competence { Name = "Обрабатывать статический информационный контент"});
            db.Competences.Add(new Competence { Name = "Обрабатывать динамический информационный контент"});
            db.Competences.Add(new Competence { Name = "Осуществлять подготовку оборудования к работе"});
            db.Competences.Add(new Competence { Name = "Разрабатывать и вести проектную ии техническую документацию"});
            db.Competences.Add(new Competence { Name = "Участвовать в измерении и контроле качества продуктов"});
            db.Competences.Add(new Competence { Name = "Обеспечивать содержание проектных операций"});


            base.Seed(db);
        }
    }
}