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
           
            cities.Add(new City() { Id = 1, Name = "New York", Image = "https://i.ytimg.com/vi/MtCMtC50gwY/maxresdefault.jpg", Population = "8,405,837", Location = "40.7127837F, -74.0059413F" });
            cities.Add(new City() { Id = 2, Name = "Los Angeles", Image = "https://www.telegraph.co.uk/content/dam/Travel/Destinations/North%20America/USA/California/los%20angeles/Los%20Angeles%20lead-xlarge.jpg", Population = "3,884,307", Location = "34.0522342F, -118.2436849F" });

            Mock<IGetData> getData = new Mock<IGetData>();
            getData.Setup(x => x.GetSampleCities()).Returns(cities);

            List<City> finalCities = getData.Object.GetSampleCities();
            Assert.IsNotNull(finalCities);
            Assert.AreEqual(2, finalCities.Count);
        }

        [TestMethod]
        public void GetWildlife_Test()
        {
            List<Animal> animals = new List<Animal>(); // Simply create sample records in memory for testing

            animals.Add(new Animal() { Id = 1, Name = "Bengal Tiger", Alias = "Panthera tigris tigris", Image = "https://switchzoo.com/assets/profiles/bengaltiger_switchzoo.jpg", Description = "Mammal. There are 36 species of cat in the world, and tigers are the largest. Hearing is their sharpest sense, five times better than humans, and their night vision is six times stronger than humans. Bengal tigers have white spots, called “flashes” on the back of their ears. These may be used to signal aggression, when the tiger swivels and flattens his ears in a confrontation. The mighty roar of a Bengal can be heard up to two miles away. The farther north tigers live, the larger they are. Siberian tigers are the largest, and Sumatrans tigers are the smallest.", Habitat = "Rainforests and dense grasslands; most Bengal tigers live in India, but some range through Nepal, Bangladesh, Bhutan, and Myanmar." });
            animals.Add(new Animal() { Id = 2, Name = "Dolphin", Alias = "Delphinus delphis", Image = "https://switchzoo.com/assets/profiles/dolphin_switchzoo.jpg", Description = "Mammal. Common dolphins are very social, traveling in groups called pods of up to 1,000 animals. Playful and boisterous, they do flips and somersaults, leaping completely out of the water, sometimes as a group. They love to ride on the waves created by their fellow swimmers, ships, or very large whales. They sleep with one eye always open, closing one for 5 to 10 minutes, then the other. Dolphins are intelligent animals and use vocalization to communicate with each other. They are affectionate and form lasting friendships with one another.", Habitat = "Widely distributed in tropical and temperate waters." });
            animals.Add(new Animal() { Id = 3, Name = "Gray Wolf", Alias = "Canis lupus", Image = "https://switchzoo.com/assets/profiles/graywolf_switchzoo.jpg", Description = "Mammal. Gray wolves are the largest wild canids. They are born deaf and blind but can hear within a few days and see in eleven days. Wolves live in caves, cavities and between rocks. Male wolves can run 56 kilometers (35 miles) per hour and jump 3.6 meters (12 feet). Gray wolves communicate to each other through howling, body language, and scent, and can be heard from as far as 10 kilometers (6 miles) away. Wolves are social animals and have a specific hierarchy within their packs. The dominant male and female pair, called the alpha wolves, rule the pack.", Habitat = "Very adaptable, they live in forests, deserts, and Arctic areas; a large geographic range in Asia, Middle East, Europe, Canada, central northern United States and Alaska." });
            animals.Add(new Animal() { Id = 4, Name = "Green Treefrog", Alias = "Hyla cinerea", Image = "https://switchzoo.com/assets/profiles/greentreefrog_switchzoo.jpg", Description = "Amphibian. The tiny green treefrog is considered one of the most beautiful frogs in North America. Alert and skittish, a green treefrog will jump at the slightest sign of danger. They use their green color as an effective camouflage against predators. Depending on temperature and lighting, they can change colors between dark and light green. Their call sounds like a series of metallic honks or a barking dog. Green treefrogs are active at night, and prefer to climb rather than jump. They grow to only about 6.5 cm (2.5 in) in length.", Habitat = "Swampy edges of watercourses; southeast and central United States." });
            animals.Add(new Animal() { Id = 5, Name = "Cheetah", Alias = "Acinonyx jubatus", Image = "https://switchzoo.com/assets/profiles/cheetah_switchzoo.jpg", Description = "Mammal. The world's fastest land animal, the cheetah can go from 0 to 65 km (40 mi) per hour in three strides, with a single stride covering 7-8 meters (23-26 feet). Cheetahs can reach full speed 110 km (70 mi) per hour in seconds. They are the only cats who have nonretractile claws. This gives them better traction, and helps maintain their footing while they run. Cheetahs are one of the few big cats who can purr. They also make other unusual sounds such as chirping, yelping, and bleating. Females live alone except when they are raising cubs. Males live in coalitions of two to five members.", Habitat = "Open woodland; plains with small thickets, medium and long grass, steppe; sub-Saharan Africa, Iran, Turkey and Turkmenistan" });
            animals.Add(new Animal() { Id = 6, Name = "Cougar", Alias = "Felis concolo", Image = "https://switchzoo.com/assets/profiles/cougar_switchzoo.jpg", Description = "Mammal. Cougars, also known as mountain lions or pumas, can jump 5.5 meters (18 feet) straight up the side of a cliff, and broad jump up to 9 meters (30 feet). They run swiftly, and can even swim. They have excellent eyesight and good hearing, and are solitary, skilled night hunters. Cougars are secretive in nature and prefer to stalk their prey at close range, to utilize the element of surprise. After they finish eating, they may cover the leftovers with leaves to save them for another meal.", Habitat = "Mountains, hilly woodlands, and southern swamps; southwestern Canada, the United States west of the Rocky Mountains and in southern Florida, Mexico, Central America and South America." });
            animals.Add(new Animal() { Id = 7, Name = "Red Squirrel", Alias = "Tamiasciurus hudsonicus", Image = "https://switchzoo.com/assets/profiles/redsquirrel_switchzoo.jpg", Description = "Mammal. Solitary animals, red squirrels scold intruders in their territory. They growl, screech, chirp, rattle, and buzz. Active during the day, they spend the warmer months preparing for winter by finding and hiding food. They do not hibernate, but if the weather is very cold, a squirrel will stay in his nest until it is warmer. A red squirrel usually has several nests in tree hollows or underground tunnels, and any number of food caches. Using their keen sense of smell, red squirrels can easily locate stored food even under a meter (3 ft) of snow! Adults weigh about .2 -.34 kg (7-12 oz).", Habitat = "Forest dwellers, they can be found in deciduous, coniferous, and mixed forests in much of Canada and northern parts of the United States." });
            animals.Add(new Animal() { Id = 8, Name = "Wahlberg's Eagle", Alias = "Aquila wahlberg", Image = "https://switchzoo.com/assets/profiles/wahlbergseagle_switchzoo.jpg", Description = "Bird. Wahlberg's eagle is one of the smallest of the eagles, only growing to 52 cm (20 in) and 770 grams (1.7 lb). Usually solitary, these eagles like to perch in leafy trees. They nest in the rainy season, building a small platform lined with leaves under the canopy of a tree. Usually only one egg is laid, and it hatches in 24 to 45 days. Only the mother feeds the baby bird, for about 75 days. Wahlberg's eagles are one species of “booted” eagles, so named because their legs are feathered down to their ankles. They have been seen waiting at the edges of bush fires waiting for prey to escape.", Habitat = "Savanna and woodland of Sub-Sahara Africa." });

            Mock<IGetData> getData = new Mock<IGetData>();
            getData.Setup(x => x.GetSampleWildlife()).Returns(animals);

            List<Animal> finalAnimals = getData.Object.GetSampleWildlife();
            Assert.IsNotNull(finalAnimals);
            Assert.AreEqual(8, finalAnimals.Count);
            finalAnimals.ShouldNotBeNull();
        }
    }
}
