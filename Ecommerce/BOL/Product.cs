namespace BOL;
public class Product
{
    public int Id{get;set;}
    public string? Name{get;set;}
    public string? Description{get;set;}
    public double UnitPrice{get;set;}

    public Product(int id, string name,string desc,double unitPrice)
    {
        this.Id=id;
        this.Name=name;
        this.Description=desc;
        this.UnitPrice=unitPrice;
    }

    public override string ToString()
    {
        return "Id :: "+Id+" Name :: "+Name+" Description :: "+Description+" Price :: "+UnitPrice;
    }


}
