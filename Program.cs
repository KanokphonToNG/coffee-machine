#include <iostream>
#include <string>

using namespace std;

// Initial ingredients (grams)
int water = 1000;
int coffee = 100;
int milk = 50;
int chocolate = 50;

void refill()
{
    cout << "\nNot enough ingredients. Refilling...\n";
    water += 1000;
    coffee += 100;
    milk += 50;
    chocolate += 50;
    cout << "Refill completed.\n\n";
}

void makeDrink(int w, int c, int m, int ch, string name)
{
    if (water < w || coffee < c || milk < m || chocolate < ch)
    {
        refill();
    }

    water -= w;
    coffee -= c;
    milk -= m;
    chocolate -= ch;

    cout << "Preparing " << name << " ... Done ☕\n\n";
}

int main()
{
    int choice;

    do
    {
        cout << "===== Automatic Coffee Machine =====\n";
        cout << "1. Black Coffee\n";
        cout << "2. Mocha\n";
        cout << "3. Latte\n";
        cout << "4. Chocolate\n";
        cout << "0. Exit\n";
        cout << "Select menu: ";
        cin >> choice;

        switch (choice)
        {
            case 1:
                makeDrink(300, 20, 0, 0, "Black Coffee");
                break;
            case 2:
                makeDrink(300, 20, 0, 10, "Mocha");
                break;
            case 3:
                makeDrink(300, 20, 10, 0, "Latte");
                break;
            case 4:
                makeDrink(300, 0, 0, 20, "Chocolate");
                break;
            case 0:
                cout << "Thank you for using the machine 🙏\n";
                break;
            default:
                cout << "Invalid selection\n\n";
        }

    } while (choice != 0);

    return 0;
}
