"""Author:Manjuram G Prabhudessai
//Roll No :24
//Start date:08/07/2024
//Modified date:15/07/2024
/*Description:This program performs all the opration which happens in Goa legislative assembly.
It shows list of mla,cabinet ministers and also gives the information about them.
It also has the House session in which the user can add,remove,pas and display the bill """


class Bill:
    def __init__(self, title, description):
        self.title = title
        self.description = description
        self.is_passed = False

    def get_title(self):
        return self.title

    def pass_bill(self):
        self.is_passed = True

    def __str__(self):
        return f"Title: {self.title}\nDescription: {self.description}\nPassed: {'Yes' if self.is_passed else 'No'}\n"


class Mla:
    def __init__(self):
        self.bills = []

    def list_mla(self):
        while True:
            print("******Welcome to Legislature*********")
            print("1: The Speaker")
            print("2: Deputy Speaker")
            print("3: Opposition Leader")
            print("4: MLA's")
            print("5: Exit")
            lan = input("Please Enter your choice: ")

            if lan == "1":
                print("************The Speaker************")
                print("Name: Shri Ramesh Tawadkar")
                print("Email: ram@#$@gmail.com")
                print("Address: Office of speaker, Goa legislative Assembly\n")
            elif lan == "2":
                print("***********The Deputy Speaker*******************")
                print("Name: Shri. Joshua De Souza")
                print("Email: jous@email id")
                print("Address: Office of speaker, Goa legislative Assembly\n")
            elif lan == "3":
                print(
                    "***********************The Opposition Leader***********************"
                )
                print("Name: Shri. Yuri Alemao")
                print("Constituency No/Name: 34 - Cuncolim")
            elif lan == "4":
                print("***********************The MLA's***********************")
                print("Name: Digambar Kamat")
                print("Party: BJP\n")
                print("Name: SHRI. JIT AROLKAR")
                print("Place: Mandrem")
                print("Party: Maharashtrawadi Gomantak Party\n")
                print("Name: SHRI. NILKANTH HALARNKAR")
                print("Place: Tivim")
                print("Party: Bharatiya Janata Party\n")
                print("Name: SHRI. Subash SHirodkar")
                print("Place: Shiroda")
                print("Party: Bharatiya Janata Party\n")
            elif lan == "5":
                return
            else:
                print("Invalid choice")

    def add_bill(self):
        title = input("Enter bill title: ")
        description = input("Enter bill description: ")
        self.bills.append(Bill(title, description))

    def remove_bill(self):
        title = input("Enter title of bill to remove: ")
        self.bills = [
            bill for bill in self.bills if bill.get_title().lower() != title.lower()
        ]

    def pass_bill(self):
        title = input("Enter title of bill to pass: ")
        for bill in self.bills:
            if bill.get_title().lower() == title.lower():
                bill.pass_bill()
                print("Bill passed successfully.")
                return
        print("Bill not found.")

    def display_bills(self):
        print("***********************The Bills***********************")
        for bill in self.bills:
            print(bill)

    def manage_bills(self):
        while True:
            print("*********WELCOME TO THE BILL SESSION**********")
            print("Choose an option:")
            print("1. Add Bill")
            print("2. Remove Bill")
            print("3. Pass Bill")
            print("4. Display Bills")
            print("5. Exit")

            choice = input()
            if choice == "1":
                self.add_bill()
            elif choice == "2":
                self.remove_bill()
            elif choice == "3":
                self.pass_bill()
            elif choice == "4":
                self.display_bills()
            elif choice == "5":
                return
            else:
                print("Invalid option. Please try again.")

    def council(self):
        print("Welcome to the Council of Ministers")
        while True:
            print("1: Home Minister")
            print("2: Health Minister")
            print("3: PWD Minister")
            print("4: Finance Minister")
            print("5: IT Minister")
            men = input("PLEASE Enter your choice: ")

            if men == "1":
                print("************Home Minister************")
                print("Name: Dr Pramod Sawant\n")
            elif men == "2":
                print("***********Health Minister******************")
                print("Name: Shri Vishwajit Rane\n")
            elif men == "3":
                print("***********PWD Minister******************")
                print("Name: Shri Sudhin Dhavlikar\n")
            elif men == "4":
                print("***********Finance Minister******************")
                print("Name: Pramod Sawant\n")
            elif men == "5":
                return
            else:
                print("Invalid choice")

    def the_government(self):
        while True:
            print("Know your government")
            print("1: The Governor")
            print("2: Chief Minister")
            print("3: Council Of Ministers")
            print("4: Exit")
            mla = input("Enter your choice: ")

            if mla == "1":
                print("************The Governor************")
                print("Name: Shri. P. S. Sreedharan Pillai")
                print("Email: ram@#$@gmail.com")
                print("Address: Office of speaker, Goa legislative Assembly\n")
            elif mla == "2":
                print("***********The Chief Minister*******************")
                print("Name: Shri. Pramod Sawant")
                print("Email: jous@email id")
                print("Address: Office of speaker, Goa legislative Assembly\n")
            elif mla == "3":
                self.council()
            elif mla == "4":
                return
            else:
                print("Invalid choice")


class Assembly(Mla):
    def my_assemble(self):
        while True:
            print("1: The Legislature")
            print("2: The Government")
            print("3: The House")
            print("4: Contact Us")
            print("5: Exit")
            menu = input("Enter your choice: ")

            if menu == "1":
                print("The Legislature:")
                self.list_mla()
            elif menu == "2":
                print("The Government:")
                self.the_government()
            elif menu == "3":
                print("The House:")
                self.manage_bills()
            elif menu == "4":
                print("Contact Us:")
                print("Email: info@goa.gov.in\n")
            elif menu == "5":
                print("Exiting...")
                return
            else:
                print("Invalid choice")


if __name__ == "__main__":
    assembly = Assembly()
    assembly.my_assemble()
