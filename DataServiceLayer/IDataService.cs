﻿namespace DataServiceLayer;
public interface IDataService
{
    IList<Category> GetCategories();
    Category? GetCategory(int id);
    IList<Product> GetProducts();
    Product? GetProduct(int id);
    void CreateCategory(Category category);
    bool UpdateCategory(Category category);
    bool DeleteCategory(int id);

    IList<ProductSearchModel> GetProductByName(string search);
    IList<Category> GetCategoriesByName(string name);
}
