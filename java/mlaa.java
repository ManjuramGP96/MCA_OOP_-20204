//Manjuram gp Dessai
// roll no 24
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

class Bill {
    private String title;
    private String description;
    private boolean isPassed;

    public Bill(String title, String description) {
        this.title = title;
        this.description = description;
        this.isPassed = false;
    }

    public String getTitle() {
        return title;
    }

    public void pass() {
        this.isPassed = true;
    }

    @Override
    public String toString() {
        return "Title: " + title + "\nDescription: " + description + "\nPassed: " + (isPassed ? "Yes" : "No") + "\n";
    }
}

class Mla {
    Scanner scanner;
    private List<Bill> bills = new ArrayList<>();

    public Mla(Scanner scanner) {
        this.scanner = scanner;
    }

    public void list_mla() {


        while (true) {
            System.out.println("******Welcome to Legislature*********");
            System.out.println("1: The Speaker");
            System.out.println("2: Deputy Speaker");
            System.out.println("3: Opposition Leader");
            System.out.println("4: MLA's");
            System.out.println("5: Exit");
            System.out.print("Please Enter your choice: ");
            int lan = scanner.nextInt();
            scanner.nextLine();

            switch (lan) {
                case 1 -> {
                    System.out.println("************The Speaker************");
                    System.out.println("Name: Shri Ramesh Tawadkar");
                    System.out.println("Email: ram@#$@gmail.com");
                    System.out.println("Address: Office of speaker, Goa legislative Assembly\n");
                }
                case 2 -> {
                    System.out.println("***********The Deputy Speaker*******************");
                    System.out.println("Name: Shri. Joshua De Souza");
                    System.out.println("Email: jous@email id\n");
                    System.out.println("Address: Office of speaker, Goa legislative Assembly\n");
                }
                case 3 -> {
                    System.out.println("***********************The Opposition Leader***********************");
                    System.out.println("Name: Shri. Yuri Alemao\n");
                    System.out.println("Constituency No/Name: 34 - Cuncolim");
                }
                case 4 -> {
                    System.out.println("***********************The MLA's***********************");
                    System.out.println("Name: Digambar Kamat");
                    System.out.println("Party: BJP\n");

                    System.out.println("Name: SHRI. JIT AROLKAR");
                    System.out.println("Place: Mandrem");
                    System.out.println("Party: Maharashtrawadi Gomantak Party\n");

                    System.out.println("Name: SHRI. NILKANTH HALARNKAR");
                    System.out.println("Place: Tivim");
                    System.out.println("Party: Bharatiya Janata Party\n");

                    System.out.println("Name: SHRI. Subash SHirodkar");
                    System.out.println("Place: Shiroda");
                    System.out.println("Party: Bharatiya Janata Party\n");
                }
                case 5 -> {
                    return;
                }
                default -> System.out.println("Invalid choice");
            }
        }
    }

    public void addBill() {
        System.out.print("Enter bill title: ");
        String title = scanner.nextLine();
        System.out.print("Enter bill description: ");
        String description = scanner.nextLine();
        bills.add(new Bill(title, description));
    }

    public void removeBill() {
        System.out.print("Enter title of bill to remove: ");
        String title = scanner.nextLine();
        bills.removeIf(bill -> bill.getTitle().equalsIgnoreCase(title));
    }

    public void passBill() {
        System.out.print("Enter title of bill to pass: ");
        String title = scanner.nextLine();
        for (Bill bill : bills) {
            if (bill.getTitle().equalsIgnoreCase(title)) {
                bill.pass();
                System.out.println("Bill passed successfully.");
                return;
            }
        }
        System.out.println("Bill not found.");
    }

    public void displayBills() {
        System.out.println("***********************The Bills***********************");
        for (Bill bill : bills) {
            System.out.println(bill);
        }
    }

    public void manageBills() {
        while (true) {
            System.out.print("*********wELCOME TO THE BILL SESSION**********: ");
            System.out.println("Choose an option:");
            System.out.println("1. Add Bill");
            System.out.println("2. Remove Bill");
            System.out.println("3. Pass Bill");
            System.out.println("4. Display Bills");
            System.out.println("5. Exit");

            int choice = scanner.nextInt();
            scanner.nextLine();

            switch (choice) {
                case 1 -> addBill();
                case 2 -> removeBill();
                case 3 -> passBill();
                case 4 -> displayBills();
                case 5 -> {
                    return;
                }
                default -> System.out.println("Invalid option. Please try again.");
            }
        }
    }

    public void council() {
        System.out.println("Welcome to the Council of Mininters");

        while (true) {

            System.out.println("1: Home Minister");
            System.out.println("2: Health Minister");
            System.out.println("3: PWD Minister");
            System.out.println("4: Finance Minister");
            System.out.println("5: IT Minister");
            System.out.print(" PLEASE Enter your choice: ");
            int men = scanner.nextInt();
            scanner.nextLine();

            switch (men) {
                case 1 -> {
                    System.out.println("************Home Minister************");
                    System.out.println("Name: Dr Pramod Sawant\n");
                }
                case 2 -> {
                    System.out.println("***********Health Minister******************");
                    System.out.println("Name: Shri Vishwajit Rane\n");
                }
                case 3 -> {
                    System.out.println("***********PWD Minister******************");
                    System.out.println("Name: Shri Sudhin Dhavlikar\n");
                }
                case 4 -> {
                    System.out.println("***********Finance Minister******************");
                    System.out.println("Name: Pramod Sawant\n");
                }
                case 5 -> {
                    return;
                }
                default -> System.out.println("Invalid choice");
            }
        }
    }

    public void the_government() {


        while (true) {
            System.out.println("Know your government");
            System.out.println("1: The Governor");
            System.out.println("2: Chief Minister");
            System.out.println("3: Council Of Ministers");
            System.out.println("4: Exit");
            System.out.print("Enter your choice: ");
            int mla = scanner.nextInt();
            scanner.nextLine();

            switch (mla) {
                case 1 -> {
                    System.out.println("************The Governor************");
                    System.out.println("Name: Shri. P. S. Sreedharan Pillai");
                    System.out.println("Email: ram@#$@gmail.com");
                    System.out.println("Address: Office of speaker, Goa legislative Assembly\n");
                }
                case 2 -> {
                    System.out.println("***********The Chief Minister*******************");
                    System.out.println("Name: Shri. Pramod Sawant");
                    System.out.println("Email: jous@email id\n");
                    System.out.println("Address: Office of speaker, Goa legislative Assembly\n");
                }
                case 3 -> council();
                case 4 -> {
                    return;
                }
                default -> System.out.println("Invalid choice");
            }
        }
    }
}

class Assembly extends Mla {
    public Assembly(Scanner scanner) {
        super(scanner);
    }

    public void my_Assemble() {


        while (true) {
            System.out.println("1: The Legislature");
            System.out.println("2: The Government");
            System.out.println("3: The House");
            System.out.println("4: Contact Us");
            System.out.println("5: Exit");
            System.out.print("Enter your choice: ");
            if (scanner.hasNextInt()) {
                int menu = scanner.nextInt();
                scanner.nextLine();

                switch (menu) {
                    case 1 -> {
                        System.out.println("The Legislature:");
                        list_mla();
                    }
                    case 2 -> {
                        System.out.println("The Government:");
                        the_government();
                    }
                    case 3 -> {
                        System.out.println("The House:");
                        manageBills();
                    }
                    case 4 -> {
                        System.out.println("Contact Us:");
                        System.out.println("Email: info@goa.gov.in\n");
                    }
                    case 5 -> {
                        System.out.println("Exiting...");
                        return;
                    }
                    default -> System.out.println("Invalid choice");
                }
            } else {
                System.out.println("Invalid input. Please enter a number.");
                scanner.next();
            }
        }
    }
}

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Assembly assembly = new Assembly(scanner);
        assembly.my_Assemble();
        scanner.close();
    }
}
