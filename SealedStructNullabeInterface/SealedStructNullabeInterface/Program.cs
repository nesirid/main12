using SealedStructNullabeInterface;

//book.Name = "dwadwadwa";

//Console.WriteLine(book.Name);

//int num = 5;
//TestStruct class1 = new TestStruct();


//string name = null;
//int? name = null;
//Book book = new Book();
//Console.WriteLine(Book.);

Book book1 = new()
{
    Id = 1,
    Name = "Isgendername" 
};

Book book2 = new()
{
    Id = 1,
    Name = "Xosrov ve Sirin"
};

Book[] books = { book1 , book2 };
void GetBookById(Book[] books, int? id = null)
{ 
    if(id == null)
{
    Console.WriteLine("Your id is null");
        return;
}
    var result = books.FirstOrDefault(m => m.Id == id);
}

GetBookById(books);