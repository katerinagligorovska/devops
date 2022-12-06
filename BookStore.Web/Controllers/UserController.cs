﻿using BookStore.Domain.DTO;
using BookStore.Domain.Identity;
using ExcelDataReader;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<EShopAppUser> userManager;

        public UserController(UserManager<EShopAppUser> userManager)
        {

            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public bool ImportAllUsers(List<UserRegistrationDto> model)
        {
            bool status = true;

            foreach (var item in model)
            {
                var userCheck = userManager.FindByEmailAsync(item.Email).Result;

                if (userCheck == null)
                {
                    var user = new EShopAppUser
                    {
                        FirstName = item.Name,
                        LastName = item.LastName,
                        Email = item.Email
                    };
                    var result = userManager.CreateAsync(user, item.Password).Result;

                    status = status && result.Succeeded;
                }
                else
                {
                    continue;
                }
            }

            return status;
        }
        public IActionResult ImportUsers(IFormFile file)
        {

            //make a copy
            string pathToUpload = $"{Directory.GetCurrentDirectory()}\\files\\{file.FileName}";

            using (FileStream fileStream = System.IO.File.Create(pathToUpload))
            {
                file.CopyTo(fileStream);

                fileStream.Flush();
            }

            //read data from copy file

            List<UserRegistrationDto> users = getAllUsersFromFile(file.FileName);

            var result = ImportAllUsers(users);


            return RedirectToAction("Index", "Order");
        }

        private List<UserRegistrationDto> getAllUsersFromFile(string fileName)
        {

            List<UserRegistrationDto> users = new List<UserRegistrationDto>();

            string filePath = $"{Directory.GetCurrentDirectory()}\\files\\{fileName}";

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);


            using (var stream = System.IO.File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    while (reader.Read())
                    {
                        users.Add(new BookStore.Domain.DTO.UserRegistrationDto
                        {
                            Email = reader.GetValue(0).ToString(),
                            Password = reader.GetValue(1).ToString(),
                            ConfirmPassword = reader.GetValue(2).ToString()
                        });
                    }
                }
            }


            return users;
        }

    }
}
