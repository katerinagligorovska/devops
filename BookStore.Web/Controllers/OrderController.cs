﻿using BookStore.Service.Interface;
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

        public FileContentResult CreateInvoice(Guid id)
        {
            var result = this.orderService.GetOrderDetails(id);
            var currentDir = Directory.GetCurrentDirectory();
            var templatePath = Path.Combine(currentDir, "files", "Invoice.docx");
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
            document.Content.Replace("{{TotalPrice}}", totalPrice + "$");

            using var stream = new MemoryStream();
            document.Save(stream, new PdfSaveOptions());
            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportInvoice.pdf");
        }
    }
}
