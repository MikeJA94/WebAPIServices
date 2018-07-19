using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using SampleService.Helpers;
using SampleService.Models;
using FluentAssert;
namespace UnitTesting
{
    [TestClass]
    public class GetDataTest
    {
        [TestMethod]
        public void GetCities_Test()
        {
            List<City> cities = new List<City>(); // Simply create sample records in memory for testing
            cities.Add(new City() { Id = 1, Name = "New York", Image = "https://i.ytimg.com/vi/MtCMtC50gwY/maxresdefault.jpg", Population = "8,405,837", Location = new float[] { 40.7127837F, -74.0059413F } });
            cities.Add(new City() { Id = 2, Name = "Los Angeles", Image = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/North%20America/USA/California/los%20angeles/Los%20Angeles%20lead-xlarge.jpg", Population = "3,884,307", Location = new float[] { 34.0522342F, -118.2436849F } });

            Mock<IGetData> getData = new Mock<IGetData>();
            getData.Setup(x => x.GetSampleCities()).Returns(cities);

            List<City> finalCities = getData.Object.GetSampleCities();
            Assert.IsNotNull(finalCities);
            Assert.AreEqual(2, finalCities.Count);
                
        }

        [TestMethod]
        public void GetWildlife_Test()
        {

            List<Animal> animals = new List<Animal>();
            // Simply create sample records in memory for demo
            animals.Add(new Animal() { Id = 1, Name = "Bengal Tiger", Alias = "Panthera tigris tigris", Image = "https://switchzoo.com/assets/profiles/bengaltiger_switchzoo.jpg", Description = "Mammal. There are 36 species of cat in the world, and tigers are the largest. Hearing is their sharpest sense, five times better than humans, and their night vision is six times stronger than humans. Bengal tigers have white spots, called “flashes” on the back of their ears. These may be used to signal aggression, when the tiger swivels and flattens his ears in a confrontation. The mighty roar of a Bengal can be heard up to two miles away. The farther north tigers live, the larger they are. Siberian tigers are the largest, and Sumatrans tigers are the smallest.", Habitat = "Rainforests and dense grasslands; most Bengal tigers live in India, but some range through Nepal, Bangladesh, Bhutan, and Myanmar." });
            animals.Add(new Animal() { Id = 2, Name = "Dolphin", Alias = "Delphinus delphis", Image = "https://switchzoo.com/assets/profiles/dolphin_switchzoo.jpg", Description = "Mammal. Common dolphins are very social, traveling in groups called pods of up to 1,000 animals. Playful and boisterous, they do flips and somersaults, leaping completely out of the water, sometimes as a group. They love to ride on the waves created by their fellow swimmers, ships, or very large whales. They sleep with one eye always open, closing one for 5 to 10 minutes, then the other. Dolphins are intelligent animals and use vocalization to communicate with each other. They are affectionate and form lasting friendships with one another.", Habitat = "Widely distributed in tropical and temperate waters." });
            animals.Add(new Animal() { Id = 3, Name = "Gray Wolf", Alias = "Canis lupus", Image = "https://switchzoo.com/assets/profiles/graywolf_switchzoo.jpg", Description = "Mammal. Gray wolves are the largest wild canids. They are born deaf and blind but can hear within a few days and see in eleven days. Wolves live in caves, cavities and between rocks. Male wolves can run 56 kilometers (35 miles) per hour and jump 3.6 meters (12 feet). Gray wolves communicate to each other through howling, body language, and scent, and can be heard from as far as 10 kilometers (6 miles) away. Wolves are social animals and have a specific hierarchy within their packs. The dominant male and female pair, called the alpha wolves, rule the pack.", Habitat = "Very adaptable, they live in forests, deserts, and Arctic areas; a large geographic range in Asia, Middle East, Europe, Canada, central northern United States and Alaska." });

            Mock<IGetData> getData = new Mock<IGetData>();
            getData.Setup(x => x.GetSampleWildlife()).Returns(animals);

            List<Animal> finalAnimals = getData.Object.GetSampleWildlife();
            Assert.IsNotNull(finalAnimals);
            Assert.AreEqual(3, finalAnimals.Count);
            finalAnimals.ShouldNotBeNull();

        }
    }
}
