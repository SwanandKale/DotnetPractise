namespace DAL;
using BOL;
using System.Collections.Generic;
using MySql.Data.MySqlClient; 

public class DBManager
{
    //HardCore value 
    public static List<Product> GetAllProducts()
    {
        List<Product> list=new List<Product>();

        list.Add(new Product(10,"Biscuit","FunTime",50));
        list.Add(new Product(11,"Wine","Party",250));
        list.Add(new Product(12,"Books","Register",40));
        list.Add(new Product(13,"Shoes","Asthetic",1000));
        list.Add(new Product(14,"Bed","Comfort",750));
        list.Add(new Product(15,"Watch","Luxiary",25000));

        return list;
    }

    public static Product GetProductById(int id)
    {
        List<Product> prod=DBManager.GetAllProducts();

        foreach(Product prodId in prod)
        {
            if(prodId.Id==id)
            {
                return prodId;
            }
        }
        return null;
    }

    public static List<Product> GetAllProductsDatabase()
    {
        List<Product>allProducts=new List<Product>();

        string conString=@"server=localhost;port=3306;user=root;password=swanand@123;database=ecommerce";

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;

        try{
            con.Open();

            MySqlCommand cmd= new MySqlCommand();
            cmd.Connection=con;

            string querry=@"select * from product";

            cmd.CommandText=querry;

            MySqlDataReader reader=cmd.ExecuteReader();

            while(reader.Read())
            {
                int id=int.Parse(reader["pid"].ToString());
                string name=reader["pname"].ToString();
                string description=reader["pdesc"].ToString();
                double unitPrice=double.Parse(reader["unitprice"].ToString());

                Product product=new Product(id,name,description,unitPrice);

                allProducts.Add(product);

                
            }
            return allProducts;
            

        }
        catch(Exception e)
        {

        }
        return null;
    }

public static Product GetProductsByIdDatabase(int id)
    {
        Product product;

        string conString=@"server=localhost;port=3306;user=root;password=swanand@123;database=ecommerce";

        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=conString;

        try{
            con.Open();

            MySqlCommand cmd= new MySqlCommand();
            cmd.Connection=con;

            string querry=@"select * from product where pid="+id;

            cmd.CommandText=querry;

            MySqlDataReader reader=cmd.ExecuteReader();

            if(reader.Read())
            {
                int pid=int.Parse(reader["pid"].ToString());
                string name=reader["pname"].ToString();
                string description=reader["pdesc"].ToString();
                double unitPrice=double.Parse(reader["unitprice"].ToString());

                product=new Product(pid,name,description,unitPrice);
                return product;
                

                
            }
            
            

        }
        catch(Exception e)
        {

        }
        return null;
    }




}
