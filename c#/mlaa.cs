using System;
using System.Collections.Generic;
using System.Linq;

class Bill {
    public string Title { get; }
    public string Description { get; }
    public bool IsPassed { get; private set; }

    public Bill(string title, string description) {
        Title = title;
        Description = description;
        IsPassed = false;
    }

    public void Pass() {
        IsPassed = true;
    }

    public override string ToString() {
        return $"Title: {Title}\nDescription: {Description}\nPassed: {(IsPassed ? "Yes" : "No")}\n";
    }
}

class Mla {
    protected List<Bill> bills = new List<Bill>();

    public void ListMla() {
        while (true) {
            Console.WriteLine("******Welcome to Legislature*********");
            Console.WriteLine("1: The Speaker");
            Console.WriteLine("2: Deputy Speaker");
            Console.WriteLine("3: Opposition Leader");
            Console.WriteLine("4: MLA's");
            Console.WriteLine("5: Exit");
            Console.Write("Please Enter your choice: ");
            int lan = int.Parse(Console.ReadLine());

            switch (lan) {
                case 1:
                    Console.WriteLine("************The Speaker************");
                    Console.WriteLine("Name: Shri Ramesh Tawadkar");
                    Console.WriteLine("Email: ram@#$@gmail.com");
                    Console.WriteLine("Address: Office of speaker, Goa legislative Assembly\n");
                    break;
                case 2:
                    Console.WriteLine("***********The Deputy Speaker*******************");
                    Console.WriteLine("Name: Shri. Joshua De Souza");
                    Console.WriteLine("Email: jous@email id");
                    Console.WriteLine("Address: Office of speaker, Goa legislative Assembly\n");
                    break;
                case 3:
                    Console.WriteLine("***********************The Opposition Leader***********************");
                    Console.WriteLine("Name: Shri. Yuri Alemao");
                    Console.WriteLine("Constituency No/Name: 34 - Cuncolim");
                    break;
                case 4:
                    Console.WriteLine("***********************The MLA's***********************");
                    Console.WriteLine("Name: Digambar Kamat");
                    Console.WriteLine("Party: BJP\n");
                    Console.WriteLine("Name: SHRI. JIT AROLKAR");
                    Console.WriteLine("Place: Mandrem");
                    Console.WriteLine("Party: Maharashtrawadi Gomantak Party\n");
                    Console.WriteLine("Name: SHRI. NILKANTH HALARNKAR");
                    Console.WriteLine("Place: Tivim");
                    Console.WriteLine("Party: Bharatiya Janata Party\n");
                    Console.WriteLine("Name: SHRI. Subash SHirodkar");
                    Console.WriteLine("Place: Shiroda");
                    Console.WriteLine("Party: Bharatiya Janata Party\n");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public void AddBill() {
        Console.Write("Enter bill title: ");
        string title = Console.ReadLine();
        Console.Write("Enter bill description: ");
        string description = Console.ReadLine();
        bills.Add(new Bill(title, description));
    }

    public void RemoveBill() {
        Console.Write("Enter title of bill to remove: ");
        string title = Console.ReadLine();
        bills = bills.Where(bill => !bill.Title.Equals(title, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    public void PassBill() {
        Console.Write("Enter title of bill to pass: ");
        string title = Console.ReadLine();
        Bill bill = bills.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        if (bill != null) {
            bill.Pass();
            Console.WriteLine("Bill passed successfully.");
        } else {
            Console.WriteLine("Bill not found.");
        }
    }

    public void DisplayBills() {
        Console.WriteLine("***********************The Bills***********************");
        foreach (Bill bill in bills) {
            Console.WriteLine(bill);
        }
    }

    public void ManageBills() {
        while (true) {
            Console.WriteLine("*********WELCOME TO THE BILL SESSION**********");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Bill");
            Console.WriteLine("2. Remove Bill");
            Console.WriteLine("3. Pass Bill");
            Console.WriteLine("4. Display Bills");
            Console.WriteLine("5. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    AddBill();
                    break;
                case 2:
                    RemoveBill();
                    break;
                case 3:
                    PassBill();
                    break;
                case 4:
                    DisplayBills();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    public void Council() {
        Console.WriteLine("Welcome to the Council of Ministers");
        while (true) {
            Console.WriteLine("1: Home Minister");
            Console.WriteLine("2: Health Minister");
            Console.WriteLine("3: PWD Minister");
            Console.WriteLine("4: Finance Minister");
            Console.WriteLine("5: IT Minister");
            Console.Write("PLEASE Enter your choice: ");
            int men = int.Parse(Console.ReadLine());

            switch (men) {
                case 1:
                    Console.WriteLine("************Home Minister************");
                    Console.WriteLine("Name: Dr Pramod Sawant\n");
                    break;
                case 2:
                    Console.WriteLine("***********Health Minister******************");
                    Console.WriteLine("Name: Shri Vishwajit Rane\n");
                    break;
                case 3:
                    Console.WriteLine("***********PWD Minister******************");
                    Console.WriteLine("Name: Shri Sudhin Dhavlikar\n");
                    break;
                case 4:
                    Console.WriteLine("***********Finance Minister******************");
                    Console.WriteLine("Name: Pramod Sawant\n");
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }

    public void TheGovernment() {
        while (true) {
            Console.WriteLine("Know your government");
            Console.WriteLine("1: The Governor");
            Console.WriteLine("2: Chief Minister");
            Console.WriteLine("3: Council Of Ministers");
            Console.WriteLine("4: Exit");
            int mla = int.Parse(Console.ReadLine());

            switch (mla) {
                case 1:
                    Console.WriteLine("************The Governor************");
                    Console.WriteLine("Name: Shri. P. S. Sreedharan Pillai");
                    Console.WriteLine("Email: ram@#$@gmail.com");
                    Console.WriteLine("Address: Office of speaker, Goa legislative Assembly\n");
                    break;
                case 2:
                    Console.WriteLine("***********The Chief Minister*******************");
                    Console.WriteLine("Name: Shri. Pramod Sawant");
                    Console.WriteLine("Email: jous@email id");
                    Console.WriteLine("Address: Office of speaker, Goa legislative Assembly\n");
                    break;
                case 3:
                    Council();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

class Assembly : Mla {
    public void MyAssemble() {
        while (true) {
            Console.WriteLine("1: The Legislature");
            Console.WriteLine("2: The Government");
            Console.WriteLine("3: The House");
            Console.WriteLine("4: Contact Us");
            Console.WriteLine("5: Exit");
            int menu = int.Parse(Console.ReadLine());

            switch (menu) {
                case 1:
                    Console.WriteLine("The Legislature:");
                    ListMla();
                    break;
                case 2:
                    Console.WriteLine("The Government:");
                    TheGovernment();
                    break;
                case 3:
                    Console.WriteLine("The House:");
                    ManageBills();
                    break;
                case 4:
                    Console.WriteLine("Contact Us:");
                    Console.WriteLine("Email: info@goa.gov.in\n");
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}

class Program {
    static void Main(string[] args) {
        Assembly assembly = new Assembly();
        assembly.MyAssemble();
    }
}
