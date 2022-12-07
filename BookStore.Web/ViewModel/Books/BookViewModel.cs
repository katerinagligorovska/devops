using System.ComponentModel.DataAnnotations;

namespace BookStore.Web.ViewModel;

public class CreateBookViewModel
{
    [Required]
    [Display(Name = "Book Name")]
    public string BookName { get; set; }

    [Required]
    [Display(Name = "Book Image")]
    public string BookImage { get; set; }

    [Required]
    [Display(Name = "Book Description")]
    public string BookDescription { get; set; }

    [Required]
    [Display(Name = "Book Genre")]
    public string Genre { get; set; }

    [Required]
    [Display(Name = "Book Price")]
    public int Price { get; set; }

    public CreateBookViewModel()
    {
        // empty values
        BookName = "";
        BookImage = "https://picsum.photos/200/300";
        BookDescription = "";
        Genre = "";
        Price = 0;
    }

    public CreateBookViewModel(string bookName, string bookImage, string bookDescription, string genre, int price)
    {
        BookName = bookName;
        BookImage = bookImage;
        BookDescription = bookDescription;
        Genre = genre;
        Price = price;
    }
}

public class BookViewModel : CreateBookViewModel
{
    [Display(Name = "Book ID")]
    public Guid Id { get; set; }

    public BookViewModel(Guid id, string bookName, string bookImage, string bookDescription, string genre, int price) : base(bookName, bookImage, bookDescription, genre, price)
    {
        Id = id;
    }
}
