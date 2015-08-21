namespace PracticePerfect.Migrations
{
    using PracticePerfect.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PracticePerfect.DAL.PracticeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PracticePerfect.DAL.PracticeContext context)
        {
            //  This method will be called after migrating to the latest version.

            var patients = new List<Patient>
            {
                new Patient{FileNumber="BEKW0001", Title=Title.Mr, FirstName="Wayne", Surname="Bekker", IdNumber="7005225214081", BirthDate=DateTime.Parse("1970-05-22"), CellNumber="0846123754"},
                new Patient{FileNumber="ARNJ0001", Title=Title.Miss, FirstName="Jennifer", Surname="Arlold", IdNumber="7812150000000", BirthDate=DateTime.Parse("1978-12-15")},
                new Patient{FileNumber="", Title=Title.Miss, FirstName="Meredith", Surname="Alonso", IdNumber="", BirthDate=DateTime.Parse("1999-09-01")},
                new Patient{FileNumber="", Title=Title.Dr, FirstName="Arturo", Surname="Anand", IdNumber="", BirthDate=DateTime.Parse("1958-09-01")},
                new Patient{FileNumber="", Title=Title.Prof, FirstName="Gytis", Surname="Barzdukas", IdNumber="", BirthDate=DateTime.Parse("1968-10-21")},
                new Patient{FileNumber="", Title=Title.Mrs, FirstName="Yan", Surname="Li", IdNumber="", BirthDate=DateTime.Parse("1975-08-01")},
                new Patient{FileNumber="", Title=Title.Mrs, FirstName="Peggy", Surname="Justice", IdNumber="", BirthDate=DateTime.Parse("1974-06-15")},
                new Patient{FileNumber="", Title=Title.Miss, FirstName="Laura", Surname="Norman", IdNumber="", BirthDate=DateTime.Parse("1989-01-28")},
                new Patient{FileNumber="", Title=Title.Hon, FirstName="Nino", Surname="Olivetto", IdNumber="", BirthDate=DateTime.Parse("1993-06-01")}
            };

            patients.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            var consultations = new List<Consultation>
            {
                new Consultation{PatientID=1, ConsultationDate=DateTime.Parse("2015-07-01"), Paid=false,Fees=300},
                new Consultation{PatientID=1, ConsultationDate=DateTime.Parse("2015-07-01"), Paid=false, Fees=300},
                new Consultation{PatientID=2, ConsultationDate=DateTime.Parse("2015-07-01"), Paid=true, Fees=100}
            };

            consultations.ForEach(c => context.Consultations.Add(c));
            context.SaveChanges();

        }
    }
}
