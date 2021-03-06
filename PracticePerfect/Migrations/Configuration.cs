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
                new Patient{FileNumber="ARNJ0001", Title=Title.Miss, FirstName="Jennifer", Surname="Arlold", IdNumber="7812150000000", BirthDate=DateTime.Parse("1978-12-15"), CellNumber="0614924903"},
                new Patient{FileNumber="ALOM0001", Title=Title.Miss, FirstName="Meredith", Surname="Alonso", IdNumber="", BirthDate=DateTime.Parse("1999-09-01")},
                new Patient{FileNumber="ANA0001", Title=Title.Dr, FirstName="Arturo", Surname="Anand", IdNumber="", BirthDate=DateTime.Parse("1958-09-01")},
                new Patient{FileNumber="BARG0001", Title=Title.Prof, FirstName="Gytis", Surname="Barzdukas", IdNumber="", BirthDate=DateTime.Parse("1968-10-21")},
                new Patient{FileNumber="LIY0001", Title=Title.Mrs, FirstName="Yan", Surname="Li", IdNumber="", BirthDate=DateTime.Parse("1975-08-01")},
                new Patient{FileNumber="JUSP0001", Title=Title.Mrs, FirstName="Peggy", Surname="Justice", IdNumber="", BirthDate=DateTime.Parse("1974-06-15")},
                new Patient{FileNumber="NORL0001", Title=Title.Miss, FirstName="Laura", Surname="Norman", IdNumber="", BirthDate=DateTime.Parse("1989-01-28")},
                new Patient{FileNumber="OLIN0001", Title=Title.Hon, FirstName="Nino", Surname="Olivetto", IdNumber="", BirthDate=DateTime.Parse("1993-06-01")}
            };
            patients.ForEach(p => context.Patients.Add(p));
            context.SaveChanges();

            var employers = new List<PatientEmployer>
            {
                new PatientEmployer{PatientID=1, Companyname="Cellsure", EmploymentDate=DateTime.Parse("2000-06-01"), ContactNumber="0118442810", JobTitle="IT Manager"},
                new PatientEmployer{PatientID=1, Companyname="Ibis Tech", EmploymentDate=DateTime.Parse("2011-02-01"), ContactNumber="011393492", JobTitle="Business Relationship Manager"}
            };
            employers.ForEach(e => context.PatientEmployers.Add(e));
            context.SaveChanges();

            var patientrelations = new List<PatientRelation>
            {
                new PatientRelation{PatientID=1, Relationship=Relationship.Spouse, Name="Jenny Bekker", Address="49 Byron rd, lombardy", ContactNumber="0614924903"},
                new PatientRelation{PatientID=1, Relationship=Relationship.Family, Name="Emma van no church", Address="49 Byron rd, lombardy", ContactNumber="0820834998"},
                new PatientRelation{PatientID=2, Relationship=Relationship.Friend, Name="Oupa", Address="iz me", ContactNumber="084....."},
                new PatientRelation{PatientID=2, Relationship=Relationship.Family, Name="Mommy dearest", Address="yeah i drove there", ContactNumber="00000000"}
            };
            patientrelations.ForEach(pr => context.PatientRelations.Add(pr));
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
