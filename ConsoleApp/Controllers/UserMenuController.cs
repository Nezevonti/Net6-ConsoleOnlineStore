using ConsoleMenu;
using ConsoleMenu.Builder;
using StoreBLL.Models;
using StoreBLL.Services;
using StoreDAL.Data;
using StoreDAL.Data.InitDataFactory;
using StoreDAL.Entities;

namespace ConsoleApp1;

public enum UserRoles
{
    Guest,
    Administrator,
    RegistredCustomer
}

public static class UserMenuController
{
    private static readonly Dictionary<UserRoles, Menu> rolesToMenu;
    private static int userId;
    private static UserRoles userRole;
    private static StoreDbContext context;

    static UserMenuController()
    {
        userId = 0;
        userRole = UserRoles.Guest;
        rolesToMenu = new Dictionary<UserRoles, Menu>();
        var factory = new StoreDbFactory(new TestDataFactory());
        context = factory.CreateContext();
        rolesToMenu.Add(UserRoles.Guest, new GuestMainMenu().Create(context));
        rolesToMenu.Add(UserRoles.RegistredCustomer, new UserMainMenu().Create(context));
        rolesToMenu.Add(UserRoles.Administrator, new AdminMainMenu().Create(context));
    }

    public static StoreDbContext Context
    { 
        get { return context; } 
    }
    public static void Login() //Fix!
    {
        Console.WriteLine("Login: ");
        var login =Console.ReadLine();
        Console.WriteLine("Password: ");
        var password = Console.ReadLine();

        switch(login)
        {
            case "admin":
                userId = 1;
                userRole = UserRoles.Administrator;
            break;
            case "guest":
                userId = 2;
                userRole = UserRoles.Guest;
            break;
            default:
                userRole = UserRoles.RegistredCustomer;

                UserService service = new(context);

                var enumerable = service.GetAll();

                enumerable = enumerable.OrderByDescending(u => u.Id);

                List<UserModel> users = enumerable.Select(g => (UserModel)g).ToList();

                userId = users.Where(u => u.Login == login).Select(u => u.Id).FirstOrDefault();
            break;
        }

    }

    public static void Register()
    {
        Console.WriteLine("Login: ");
        var login = Console.ReadLine();
        Console.WriteLine("Password: ");
        var password = Console.ReadLine();
        Console.WriteLine("first name: ");
        var first_name = Console.ReadLine();
        Console.WriteLine("last name: ");
        var last_name = Console.ReadLine();


        UserService service = new(context);

        var enumerable = service.GetAll();
        
        enumerable = enumerable.OrderByDescending(u => u.Id);

        List<UserModel> users = enumerable.Select(g => (UserModel)g).ToList();
        
        if(users.Any(u => u.Login == login))
        {
            Console.WriteLine("user with this login already exists");

            return;
        }

        int newId = users.FirstOrDefault().Id;

        

        UserModel newUser = new(newId+1, first_name, last_name, login, password, 2);

        service.Add(newUser);

        //Login();
    }

    public static void Logout()
    {
        userId = 0;
        userRole = UserRoles.Guest;
    }
    
    public static void Start()
    {
        ConsoleKey resKey;
        bool updateItems = true;
        do
        {
            //rolesToMenu[userRole].Run();
            resKey = rolesToMenu[userRole].RunOnce(ref updateItems);
        } while (resKey != ConsoleKey.Escape);


    }
}

