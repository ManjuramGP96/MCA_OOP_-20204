#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

class Bill {
private:
    string title;
    string description;
    bool isPassed;

public:
    Bill(string title, string description) : title(title), description(description), isPassed(false) {}

    string getTitle() const {
        return title;
    }

    void pass() {
        isPassed = true;
    }

    string toString() const {
        return "Title: " + title + "\nDescription: " + description + "\nPassed: " + (isPassed ? "Yes" : "No") + "\n";
    }
};

class Mla {
protected:
    vector<Bill> bills;

public:
    void list_mla() {
        while (true) {
            cout << "******Welcome to Legislature*********\n";
            cout << "1: The Speaker\n";
            cout << "2: Deputy Speaker\n";
            cout << "3: Opposition Leader\n";
            cout << "4: MLA's\n";
            cout << "5: Exit\n";
            cout << "Please Enter your choice: ";
            int lan;
            cin >> lan;

            switch (lan) {
                case 1:
                    cout << "************The Speaker************\n";
                    cout << "Name: Shri Ramesh Tawadkar\n";
                    cout << "Email: ram@#$@gmail.com\n";
                    cout << "Address: Office of speaker, Goa legislative Assembly\n\n";
                    break;
                case 2:
                    cout << "***********The Deputy Speaker*******************\n";
                    cout << "Name: Shri. Joshua De Souza\n";
                    cout << "Email: jous@email id\n";
                    cout << "Address: Office of speaker, Goa legislative Assembly\n\n";
                    break;
                case 3:
                    cout << "***********************The Opposition Leader***********************\n";
                    cout << "Name: Shri. Yuri Alemao\n";
                    cout << "Constituency No/Name: 34 - Cuncolim\n";
                    break;
                case 4:
                    cout << "***********************The MLA's***********************\n";
                    cout << "Name: Digambar Kamat\n";
                    cout << "Party: BJP\n\n";
                    cout << "Name: SHRI. JIT AROLKAR\n";
                    cout << "Place: Mandrem\n";
                    cout << "Party: Maharashtrawadi Gomantak Party\n\n";
                    cout << "Name: SHRI. NILKANTH HALARNKAR\n";
                    cout << "Place: Tivim\n";
                    cout << "Party: Bharatiya Janata Party\n\n";
                    cout << "Name: SHRI. Subash SHirodkar\n";
                    cout << "Place: Shiroda\n";
                    cout << "Party: Bharatiya Janata Party\n\n";
                    break;
                case 5:
                    return;
                default:
                    cout << "Invalid choice\n";
            }
        }
    }

    void addBill() {
        cout << "Enter bill title: ";
        string title;
        cin.ignore();
        getline(cin, title);
        cout << "Enter bill description: ";
        string description;
        getline(cin, description);
        bills.push_back(Bill(title, description));
    }

    void removeBill() {
        cout << "Enter title of bill to remove: ";
        string title;
        cin.ignore();
        getline(cin, title);
        bills.erase(remove_if(bills.begin(), bills.end(), [&](const Bill &bill) {
            return bill.getTitle() == title;
        }), bills.end());
    }

    void passBill() {
        cout << "Enter title of bill to pass: ";
        string title;
        cin.ignore();
        getline(cin, title);
        for (Bill &bill : bills) {
            if (bill.getTitle() == title) {
                bill.pass();
                cout << "Bill passed successfully.\n";
                return;
            }
        }
        cout << "Bill not found.\n";
    }

    void displayBills() {
        cout << "***********************The Bills***********************\n";
        for (const Bill &bill : bills) {
            cout << bill.toString();
        }
    }

    void manageBills() {
        while (true) {
            cout << "*********WELCOME TO THE BILL SESSION**********\n";
            cout << "Choose an option:\n";
            cout << "1. Add Bill\n";
            cout << "2. Remove Bill\n";
            cout << "3. Pass Bill\n";
            cout << "4. Display Bills\n";
            cout << "5. Exit\n";
            int choice;
            cin >> choice;

            switch (choice) {
                case 1:
                    addBill();
                    break;
                case 2:
                    removeBill();
                    break;
                case 3:
                    passBill();
                    break;
                case 4:
                    displayBills();
                    break;
                case 5:
                    return;
                default:
                    cout << "Invalid option. Please try again.\n";
            }
        }
    }

    void council() {
        cout << "Welcome to the Council of Ministers\n";
        while (true) {
            cout << "1: Home Minister\n";
            cout << "2: Health Minister\n";
            cout << "3: PWD Minister\n";
            cout << "4: Finance Minister\n";
            cout << "5: IT Minister\n";
            cout << "PLEASE Enter your choice: ";
            int men;
            cin >> men;

            switch (men) {
                case 1:
                    cout << "************Home Minister************\n";
                    cout << "Name: Dr Pramod Sawant\n\n";
                    break;
                case 2:
                    cout << "***********Health Minister******************\n";
                    cout << "Name: Shri Vishwajit Rane\n\n";
                    break;
                case 3:
                    cout << "***********PWD Minister******************\n";
                    cout << "Name: Shri Sudhin Dhavlikar\n\n";
                    break;
                case 4:
                    cout << "***********Finance Minister******************\n";
                    cout << "Name: Pramod Sawant\n\n";
                    break;
                case 5:
                    return;
                default:
                    cout << "Invalid choice\n";
            }
        }
    }

    void the_government() {
        while (true) {
            cout << "Know your government\n";
            cout << "1: The Governor\n";
            cout << "2: Chief Minister\n";
            cout << "3: Council Of Ministers\n";
            cout << "4: Exit\n";
            cout << "Enter your choice: ";
            int mla;
            cin >> mla;

            switch (mla) {
                case 1:
                    cout << "************The Governor************\n";
                    cout << "Name: Shri. P. S. Sreedharan Pillai\n";
                    cout << "Email: ram@#$@gmail.com\n";
                    cout << "Address: Office of speaker, Goa legislative Assembly\n\n";
                    break;
                case 2:
                    cout << "***********The Chief Minister*******************\n";
                    cout << "Name: Shri. Pramod Sawant\n";
                    cout << "Email: jous@email id\n";
                    cout << "Address: Office of speaker, Goa legislative Assembly\n\n";
                    break;
                case 3:
                    council();
                    break;
                case 4:
                    return;
                default:
                    cout << "Invalid choice\n";
            }
        }
    }
};

class Assembly : public Mla {
public:
    void my_Assemble() {
        while (true) {
            cout << "1: The Legislature\n";
            cout << "2: The Government\n";
            cout << "3: The House\n";
            cout << "4: Contact Us\n";
            cout << "5: Exit\n";
            cout << "Enter your choice: ";
            int menu;
            cin >> menu;

            switch (menu) {
                case 1:
                    cout << "The Legislature:\n";
                    list_mla();
                    break;
                case 2:
                    cout << "The Government:\n";
                    the_government();
                    break;
                case 3:
                    cout << "The House:\n";
                    manageBills();
                    break;
                case 4:
                    cout << "Contact Us:\n";
                    cout << "Email: info@goa.gov.in\n\n";
                    break;
                case 5:
                    cout << "Exiting...\n";
                    return;
                default:
                    cout << "Invalid choice\n";
            }
        }
    }
};

int main() {
    Assembly assembly;
    assembly.my_Assemble();
    return 0;
}
