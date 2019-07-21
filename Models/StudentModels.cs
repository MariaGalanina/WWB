using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "СНИЛС")]
        public string Snils { get; set; }
        [Display(Name = "Имя")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        public string Surname { get; set; }
        [Display(Name = "Отчество")]
        public string Otch { get; set; }
        [Display(Name = "Рейтинг")]
        public string Rating { get; set; }
        [Display(Name = "Диплом")]
        public string Diplom { get; set; }
    }

    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }

    public class StudentDbInitializer : DropCreateDatabaseAlways<StudentContext>
    {
        protected override void Seed(StudentContext db)
        {
            db.Students.Add(new Student { Name = "Сергей", Surname = "Юрин", Otch = "Владимирович", Rating = "10.3", Snils = "12345678912", Diplom = "2JHF/34634" });
            db.Students.Add(new Student { Name = "Андрей", Surname = "Юрин", Otch = "Владимирович", Rating = "7.8", Snils = "12345678912", Diplom = "2JHF/34634" });
            db.Students.Add(new Student { Name = "Егор", Surname = "Юрин", Otch = "Владимирович", Rating = "12.3", Snils = "12345678912", Diplom = "2JHF/34634" });
            db.Students.Add(new Student { Name = "Игорь", Surname = "Юрин", Otch = "Владимирович", Rating = "9.0", Snils = "12345678912", Diplom = "2JHF/34634" });
            db.Students.Add(new Student { Name = "Алексей", Surname = "Юрин", Otch = "Владимирович", Rating = "13.5", Snils = "12345678912", Diplom = "2JHF/34634" });

            base.Seed(db);
        }
    }
}