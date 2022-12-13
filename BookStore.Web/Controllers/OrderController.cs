using BookStore.Service.Interface;
using ClosedXML.Excel;
using GemBox.Document;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;

namespace BookStore.Web.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            this.orderService = orderService;
        }

        public IActionResult Index()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = this.orderService.GetAllUserOrders(userId);
            return View(result);
        }

        public IActionResult Details(Guid id)
        {
            var result = this.orderService.GetOrderDetails(id);
            return View(result);
        }

        [HttpGet]
        public FileContentResult ExportAllOrders()
        {
            string fileName = "Orders.xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

            using var workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("All Orders");
            worksheet.ColumnWidth = 50;
            worksheet.Cell(1, 1).Value = "Order Id";
            worksheet.Cell(1, 2).Value = "Costumer Email";

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var orders = this.orderService.GetAllUserOrders(userId);

            for (int i = 0; i <= orders.Count(); i++)
            {
                var order = orders.ElementAt(i);
                worksheet.Cell(i + 1, 1).Value = order.Id.ToString();
                worksheet.Cell(i + 1, 2).Value = order.User.Email;
                if (order.BooksInOrder == null)
                {
                    continue;
                }

                for (int j = 0; j < order.BooksInOrder.Count; j++)
                {
                    var book = order.BooksInOrder.ElementAt(j);
                    worksheet.Cell(1, j + 3).Value = "Book - " + (j + 1);
                    worksheet.Cell(i + 1, j + 3).Value = book.Book.BookName;
                }
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            var content = stream.ToArray();
            return File(content, contentType, fileName);
        }

        public FileContentResult CreateInvoice(Guid id)
        {
            var result = this.orderService.GetOrderDetails(id);
            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "files\\Invoice.docx");
            var document = DocumentModel.Load(templatePath);

            document.Content.Replace("{{OrderNumber}}", result.Id.ToString());
            document.Content.Replace("{{UserName}}", result.User.UserName);

            var sb = new StringBuilder();
            var totalPrice = 0.0;
            if (result.BooksInOrder != null)
            {
                foreach (var item in result.BooksInOrder)
                {
                    sb.Append($"{item.Book.BookName} - {item.Quantity} - {item.Book.Price}$");
                    sb.Append(Environment.NewLine);
                    totalPrice += item.Book.Price * item.Quantity;
                }
            }
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "$");

            using var stream = new MemoryStream();
            document.Save(stream, new PdfSaveOptions());
            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportInvoice.pdf");
        }
    }
}
