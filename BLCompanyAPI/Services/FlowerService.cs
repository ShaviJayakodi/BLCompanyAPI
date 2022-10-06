using BLCompanyAPI.Model;

namespace BLCompanyAPI.Services
{
    public class FlowerService
    {
        public List<Flower> AllFlowers()
        {
            var flowers = new List<Flower>();
            var flower1 = new Flower
            {
                flowerId = 1,
                flowerDescription = "Flower1",
                flowerName = "flower11",
                status = StatusValue.Active
            };
            flowers.Add(flower1);
            var flower2 = new Flower
            {
                flowerId = 2,
                flowerDescription = "Flower2",
                flowerName = "flower22",
                status = StatusValue.Deactive
            };
            flowers.Add(flower2);
            var flower3 = new Flower
            {
                flowerId = 3,
                flowerDescription = "Flower3",
                flowerName = "flower33",
                status = StatusValue.Active
            };
            flowers.Add(flower3);
            return flowers;

        }
    }
}
