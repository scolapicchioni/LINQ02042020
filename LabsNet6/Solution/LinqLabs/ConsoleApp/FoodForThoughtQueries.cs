using InfoSupport.KC.FoodForThought.Shared.Core.Models;
using TestDataLibrary;

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
        public static IEnumerable<Product> GetFFTProducts() {
            IEnumerable<string> allowedProducts = ProductenTestData.GetAllowedProductIds();
            IEnumerable<Product> milliwaysProducts = ProductenTestData.GetFoodForThoughtProducts();

            return milliwaysProducts.Where(p => allowedProducts.Contains(p.Id)).ToList();
        }

        // 2.
        // write a method that returns 
        // only the Categories of
        // CategorieenTestData.GetMilliwaysCategories
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // CategorieenTestData.GetFoodForThoughtCategories
        public static IEnumerable<Categorie> GetFFTCategories() {
            IEnumerable<Categorie> original = CategorieenTestData.GetFoodForThoughtCategories();
            IEnumerable<Product> products = GetFFTProducts();
            return original.Where(c => products.Select(p => p.Categorie).Distinct().Contains(c.Id)).ToList();
        }
        // 3.
        // write a method that returns 
        // only the Extras of
        // ExtrasTestData.GetMilliwaysExtras
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // ExtrasTestData.GetFoodForThoughtExtras
        public static IEnumerable<Product> GetFFTExtras() {
            IEnumerable<Product> extrasFromMilliways = ExtrasTestData.GetMilliwaysExtras();
            IEnumerable<Categorie> allowedCategories = GetFFTCategories();
            IEnumerable<string> ids = allowedCategories.SelectMany(c => c.Extras).Distinct();

            return extrasFromMilliways.IntersectBy(ids, x => x.Id).ToList();
        }
        // 4.
        // write a method that returns 
        // only the Extras of
        // ExtrasTestData.GetMilliwaysSoortenBrood
        // whose Ids are contained in 
        // ProductenTestData.GetAllowedProductIds
        // Test that the result is equal to
        // ExtrasTestData.GetFoodForThoughtSoortenBrood

        public static IEnumerable<Product> GetFFTBreadTypes() {
            IEnumerable<Product> soortenBroodFromMilliways = ExtrasTestData.GetMilliwaysSoortenBrood();
            IEnumerable<Product> allowedProducts = GetFFTProducts();

            IEnumerable<string> ids = allowedProducts.SelectMany(p => p.SoortenBrood ?? Array.Empty<string>()).Distinct();

            return soortenBroodFromMilliways.IntersectBy(ids, p => p.Id).ToList();
        }
        //5.
        // Write a query tht returns all the ProductViewModel
        // that students are allowed to order
        public static IEnumerable<ProductViewModel> GetFFTProductViewModels() {
            IEnumerable<Product> products = GetFFTProducts();
            IEnumerable<Categorie> categories = GetFFTCategories();
            IEnumerable<Product> extras = GetFFTExtras();
            IEnumerable<Product> breadTypes = GetFFTBreadTypes();

            IEnumerable<ProductViewModel> result = from p in products
                    join c in categories
                    on p.Categorie equals c.Id
                    orderby c.Naam, p.Naam
                    select new ProductViewModel() 
                    { 
                        Id = p.Id, 
                        Name = p.Naam, 
                        IsGeschiktVoor = p.IsGeschiktVoor, 
                        IsGlutenVrij = p.IsGlutenVrij, 
                        CategoryName = c.Naam,
                        SoortenBrood = (from b in p.SoortenBrood ?? Array.Empty<string>()
                                        join bt in breadTypes
                                        on b equals bt.Id
                                        select new ProductViewModel() {
                                            Id = b,
                                            Name = bt.Naam,
                                            IsGeschiktVoor = bt.IsGeschiktVoor,
                                            IsGlutenVrij = bt.IsGlutenVrij
                                        }).ToArray(),
                        Extras = (from e in c.Extras ?? Array.Empty<string>()
                                  join ex in extras
                                  on e equals ex.Id
                                  select new ProductViewModel() {
                                      Id = e,
                                      Name = ex.Naam,
                                      IsGeschiktVoor = ex.IsGeschiktVoor,
                                      IsGlutenVrij = ex.IsGlutenVrij
                                  }).ToArray()
                    };

            return result.ToList();
        }
    }

    public class ProductViewModel {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public bool IsGlutenVrij { get; set; }
        public string IsGeschiktVoor { get; set; } = string.Empty;
        public ProductViewModel[]? SoortenBrood { get; set; }
        public ProductViewModel[]? Extras { get; set; }

        public override string ToString() {
            return $"{Id} {Name} {CategoryName} {IsGeschiktVoor} {IsGlutenVrij}";
        }
    }
}
