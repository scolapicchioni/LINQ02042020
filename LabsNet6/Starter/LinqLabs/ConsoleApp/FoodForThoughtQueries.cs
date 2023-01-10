namespace ConsoleApp {
    public class FoodForThoughtQueries {

        // 1.
        // write a method that returns 
        // only the products of
        // ProductenTestData.GetMilliwaysProducts
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // ProductenTestData.GetFoodForThoughtProducts


        // 2.
        // write a method that returns 
        // only the Categories of
        // CategorieenTestData.GetMilliwaysCategories
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // CategorieenTestData.GetFoodForThoughtCategories

        // 3.
        // write a method that returns 
        // only the Extras of
        // ExtrasTestData.GetMilliwaysExtras
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // ExtrasTestData.GetFoodForThoughtExtras

        // 4.
        // write a method that returns 
        // only the Extras of
        // ExtrasTestData.GetMilliwaysSoortenBrood
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // ExtrasTestData.GetFoodForThoughtSoortenBrood

        //5.
        // Write a query tht returns all the ProductViewModel
        // that students are allowed to order
    }

    class ProductViewModel {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public bool IsGlutenVrij { get; set; }
        public string IsGeschiktVoor { get; set; } = string.Empty;
        public ProductViewModel[]? SoortenBrood { get; set; }
        public ProductViewModel[]? Extras { get; set; }
    }
}
