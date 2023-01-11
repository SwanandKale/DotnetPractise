namespace BLL;
using DAL;
using BOL;
using System.Collections.Generic;


public class ProductManager
{
    public static List<Product> GetAllProducts()
    {
        
        List<Product>list=new List<Product>();
        list=DBManager.GetAllProducts();
        
        return list;
    }

    public static Product GetProductById(int id)
    {
        return DBManager.GetProductById(id);
    }

    public static List<Product> GetAllProductsDatabase()
    {
        return DBManager.GetAllProductsDatabase();
    }

    public static Product GetProductsByIdDatabase(int id)
    {
        return DBManager.GetProductsByIdDatabase(id);
    }

    
}
