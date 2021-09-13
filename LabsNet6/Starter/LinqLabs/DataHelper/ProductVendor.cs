namespace DataHelper;

public class ProductVendor {
    public int ProductID { get; set; }
    public int VendorID { get; set; }
    public decimal Price { get; set; }

    public override string ToString() => $"PID: {ProductID} - VID: {VendorID} - Price: {Price}";
}
