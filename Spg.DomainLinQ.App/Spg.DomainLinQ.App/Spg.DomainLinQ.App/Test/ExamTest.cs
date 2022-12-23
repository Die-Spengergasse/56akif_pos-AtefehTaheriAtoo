using Bogus.DataSets;
using System;
using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using static Bogus.DataSets.Name;
using Address = Spg.DomainLinQ.App.Model.Address;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
namespace Tests;
public class ExamTest
{
    private School2000Context GenerateDb()
    {
        DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
        optionsBuilder.UseSqlite("Data Source=./../../../School2000.db");
        School2000Context db = new School2000Context(optionsBuilder.Options);
        db.Database.EnsureDeleted();
        db.Database.EnsureCreated();
        return db;
    }
    [Fact]
    public void SeedDb()
    {
        School2000Context db = GenerateDb();
        db.Seed();
        Assert.True(true);
    }
    [Fact]
    public void Create_Exam_SuccessTest()
    {
        // AAA
        // 1. Arrange
        School2000Context db = GenerateDb();
        Exam exam = new Exam(1, DateTime.Now, DateTime.Now, Guid.NewGuid(), 1);
        // 2. Act
        db.Exams.Add(exam);
        db.SaveChanges();
        // 3. Assert
        Assert.Equal(1, db.Exams.Count());
    }
}