using EFSamurai.Data;
using EFSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.ComponentModel.DataAnnotations.Schema;
using

namespace UnitTesting_of_Samurais
{
    public class Tests
    {

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            using SamuraiDbContext db = new();
            db.Database.EnsureDeleted();
            db.Database.Migrate();
        }

        [Test]
        public void Test_AddOneSamuraiTwice()
        {
            EfMethods.AddOneSamurai("Zelda");
            EfMethods.AddOneSamurai("Link");
            string[] result = EfMethods.GetAllSamuraiNames();
            CollectionAssert.AreEqual(new[] { "Zelda", "Link" }, result);
        }

        [Test]
        public void Test_AddOneSamuraiWithSecretIdentity()
        {
            Samurai samurai = new()
            {
                Name = "Ganondorf Dragmire",
                HairStyle = HairStyle.Western,
            };
            int samuraiId = EfMethods.AddOneSamurai(samurai);
            EfMethods.UpdateSamuraiSetSecretIdentity(samuraiId, "Ganon");

            Samurai actualSamurai = EfMethods.GetSamurai(samuraiId);
            Assert.AreEqual("Ganondorf Dragmire", actualSamurai.Name);
            Assert.AreEqual(HairStyle.Western, actualSamurai.HairStyle);
            Assert.AreEqual("Ganon", actualSamurai.SecretIdentity.RealName);
        }
    }
} 