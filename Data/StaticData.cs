using WebApplication051024_Books.Models;

namespace WebApplication051024_Books.Data
{
    public static class StaticData
    {
        public static List<Book> Books = new List<Book>
    {
        new Book
        {
            Id = 1,
            Title = "Пока ты спал",
            Author = "София Любимова",
            Genre = "Романтика",
            Price = 10.99m,
            Comments = new List<Comment>
            {
                new Comment { Id = 5, Text = "Трогательная история.", BookId = 4 },
                new Comment { Id = 6, Text = "Прекрасно написано!", BookId = 4 }
            }
        },
        new Book
        {
            Id = 2,
            Title = "Секреты его глаз",
            Author = "Анна Смит",
            Genre = "Романтика",
            Price = 11.99m,
            Comments = new List<Comment>
            {
                new Comment { Id = 7, Text = "Очень романтично.", BookId = 5 }
            }
        },
        new Book
        {
            Id = 3,
            Title = "Каждое мгновение",
            Author = "Дженнифер Арментроут",
            Genre = "Романтика",
            Price = 13.99m,
            Comments = new List<Comment>
            {
                new Comment { Id = 8, Text = "Захватывающая история любви.", BookId = 6 }
            }
        },
        new Book
        {
            Id = 4,
            Title = "Здесь и сейчас",
            Author = "Сара Портман",
            Genre = "Романтика",
            Price = 12.49m,
            Comments = new List<Comment>
            {
                new Comment { Id = 9, Text = "Трогательно и красиво.", BookId = 7 }
            }
        }
    };
    }
}
