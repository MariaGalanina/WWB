using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace WebApplication.Models
{
    public class Contragent
    { 
        public int Id { get; set; }
        [Display(Name = "Регион")]
        public int RegionId { get; set; }
        

        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "ОГРН")]
        public string OGRN { get; set; }
        [Display(Name = "ИНН")]
        public string INN { get; set; }
        [Display(Name = "КПП")]
        public string KPP { get; set; }
        [Display(Name = "ОКПО")]
        public string OKPO { get; set; }
        [Display(Name = "Дата регистрации")]
        public string DateRegistr { get; set; }
        [Display(Name = "Руководитель")]
        public string Head { get; set; }
        [Display(Name = "Телефон")]
        public string Telephon { get; set; }
        [Display(Name = "Почта")]
        public string Email { get; set; }
        [Display(Name = "Сайт")]
        public string Site { get; set; }
    }
    public class ContragentContext:DbContext
    {
        public DbSet<Contragent> Contragents { get; set; }
    }
    public class ContragentDbInitializer : DropCreateDatabaseAlways<ContragentContext>
    {
        protected override void Seed(ContragentContext db)
        {
            db.Contragents.Add(new Contragent { Name = "ННГУ им Н. И. Лобачевского"});
            
            base.Seed(db);
        }
    }
}
