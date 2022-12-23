using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;

sing Bogus.DataSets;
using System;
using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Model;
using static Bogus.DataSets.Name;
using Address = Spg.DomainLinQ.App.Model.Address;
namespace Tests;
public class TeacherTest
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
    public void Teacher_Add_OneEntity_SuccessTest()
    {
        // AAA
        // 1. Arrange
        Address address = new Address("Street", "Zip", "City");
        PhoneNumber phone = new PhoneNumber("123");
        School2000Context db = GenerateDb();
        Teacher teacher = new Teacher("Atefe", "Atefe", "atefe.gmx.at", address, Genders.FEMALe, Guid.NewGuid());
        // 2. Act
        db.Teachers.Add(teacher);
        db.SaveChanges();
        // 3. Assert
        Assert.Equal(1, db.Teachers.Count());
    }
}