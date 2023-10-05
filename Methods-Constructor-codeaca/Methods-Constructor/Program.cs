// Dersde yazilan kodlar

using Methods_Constructor;
using Methods_Constructor.Models;
using Methods_Constructor.Models;


//Employee employee1 = new()
//{
//    fullName = "Nurlan Musayev",
//    address = "Nerimanov",
//    age = 21,
//};



//Employee employee2 = new()
//{
//    fullName = "Samil Ferruxov",
//    address = "Qazax",
//    age = 18,
//};


//Employee employee3 = new()
//{
//    fullName = "Ramin Mahmudov",
//    address = "Qazax",
//    age = 2,
//};



//Employee[] employees = {employee1, employee2, employee3};   

//foreach(var item in employees)
//{
//    Console.WriteLine(item.GetFullData());
//}



//Book book = new Book();


//Console.WriteLine(book.GetFullData());







//--------------MODELS------------------------







//foreach (var person in people)
//{
//    if(person.id == 2)
//    {
//        Console.WriteLine(person.fullName);
//        break;
//    }
//}


//var result = people.Where(m => m.id > 2).ToArray();

//foreach (var item in result)
//{
//    Console.WriteLine(item.fullName);
//}


//var result = Array.FindAll(people, m => m.age > 17 && m.age < 23);

//foreach (var person in result)
//{
//    Console.WriteLine(person.fullName);
//}





//UserService service = new();


//User user = service.GetUserByİd(4);

//Console.WriteLine(user.fullName);


static void searchByName(string serachtext)
{
    Product[] products = getAllProducts();

    Product existProduct = products.FirstOrDefault(m => m.name.Trim().ToLower().Contains(serachtext));

    if (existProduct == null)
    {
        Console.WriteLine("Not Found");
        return;
    }
    
    foreach (var product in products)
    {
        if (product.name.Trim().ToLower().Contains(serachtext))
        {
            Console.WriteLine($"{product.id} - {product.name} - {product.price} - {product.count}");
        }
    }
}



Console.WriteLine("Add text :");

SearchText: string searchtext = Console.ReadLine();


if(searchtext == "")
{
    Console.WriteLine("Please add searchtext");
    goto SearchText;
}


searchByName(searchtext);

static Product[] getAllProducts()
{

    Product product1 = new Product
    {
        id = 1,
        name = "Iphone 14",
        price = 2500,
        count = 5
    };

    Product product2 = new Product
    {
        id = 2,
        name = "Samsung",
        price = 3000,
        count = 5
    };

    Product product3 = new Product
    {
        id = 3,
        name = "Nokia",
        price = 500,
        count = 7
    };

    Product[] products = {product1, product2, product3};

    return products;
}
