using OfficeOpenXml;
using ConsoleApp1.Model;

public class ExcelExporter
{
    private readonly AppDbContext.ApplicationDbContext _db;

    public ExcelExporter(AppDbContext.ApplicationDbContext db)
    {
        _db = db;
    }

    public void ExportDataToExcel(string filePath)
    {
        var users = _db.Users.ToList(); 
        var products = _db.Product.ToList();
        var orders = _db.Order.ToList();
        using (var package = new ExcelPackage())
        {
            var user = package.Workbook.Worksheets.Add("Users");
            var product = package.Workbook.Worksheets.Add("Products");
            var order = package.Workbook.Worksheets.Add("Orders");
            user.Cells[1, 1].Value = "Name";
            user.Cells[1, 2].Value = "Role";
            product.Cells[1, 4].Value = "Name";
            product.Cells[1, 5].Value = "Price";
            order.Cells[1,8].Value = "UserName";
            order.Cells[1,9].Value = "ProductName";
            for (int i = 0; i < users.Count; i++)
            {
                user.Cells[i + 2, 1].Value = users[i].Name;
                user.Cells[i + 2, 2].Value = users[i].Role;
            }
            for (int i = 0; i < products.Count; i++)
            {
                product.Cells[i + 2, 1].Value = products[i].Name;
                product.Cells[i + 2, 2].Value = products[i].Price;
            }
            for (int i = 0; i < orders.Count; i++)
            {
                order.Cells[i + 2, 1].Value = orders[i].ProductName;
                order.Cells[i + 2, 2].Value = orders[i].ProductName;
            }
            var fileInfo = new FileInfo(filePath);
            package.SaveAs(fileInfo);
        }

        Console.WriteLine($"Data exported to Excel file: {filePath}");
    }
}