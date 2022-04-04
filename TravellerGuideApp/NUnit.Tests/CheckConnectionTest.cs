using Domain;
using Infrastructure;
using NUnit.Framework;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace NUnit.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ImportData importData = new ImportData();
            importData.open();
            Assert.AreEqual(importData.state(), ConnectionState.Open);
            importData.close();
        }

        [Test]
        [TestCase(1, "Museum", 2)]
        [TestCase(2, "Park", 2)]
        [TestCase(3, "Famous Building", 2)]
        public void ImportDataTest(int cityID, string type, int expected)
        {

            List<Location> locations = new List<Location>();
            ImportData importData = new ImportData();
            importData.open();
            locations = importData.readLocations();
            importData.close();
            var list = locations.Where(x => x.City_ID == cityID && x.Location_Type == type).Select(x => x);
            int result = list.Count();
            Assert.AreEqual(expected, result);
        }
    }
}