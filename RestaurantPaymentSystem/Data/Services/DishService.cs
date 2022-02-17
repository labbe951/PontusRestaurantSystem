using RestaurantPaymentSystem.Data.Models;
using RestaurantPaymentSystem.Data.Repositories;

namespace RestaurantPaymentSystem.Data.Services
{
    public class DishService : IDishService
    {
        private readonly IAsyncRepository<DishModel> _asyncRepository;

        public DishService(IAsyncRepository<DishModel> asyncRepository)
        {
            _asyncRepository = asyncRepository;
        }

        public void CreateDishes()
        {
            var listOfDishes = new List<DishModel>();

            DishModel dish1 = new DishModel
            {
                DishId = 1,
                DishName = "Spagetti Carbonara",
                DishPrice = 99
            };

            listOfDishes.Add(dish1);

            DishModel dish2 = new DishModel
            {
                DishId = 2,
                DishName = "Penne Catciatore",
                DishPrice = 119
            };

            listOfDishes.Add(dish2);

            DishModel dish3 = new DishModel
            {
                DishId = 3,
                DishName = "Spagetti Bolognese",
                DishPrice = 109
            };

            listOfDishes.Add(dish3);

            DishModel dish4 = new DishModel
            {
                DishId = 4,
                DishName = "Pizza Margarita",
                DishPrice = 89
            };

            listOfDishes.Add(dish4);

            DishModel dish5 = new DishModel
            {
                DishId = 5,
                DishName = "Calzone",
                DishPrice = 89
            };

            listOfDishes.Add(dish5);

            _asyncRepository.AddRangeAsync(listOfDishes);

        }
    }
}
