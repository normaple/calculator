#include <iostream>

using namespace std;

int main()
{
    cout << "Enter a number\n";
    double calc;
    cin >> calc;
    bool loop = true;
    while (loop) {
        cout << "Enter an operator\n";
        char mathOperator;
        cin >> mathOperator;
        if (mathOperator == '*') {
            cout << "Enter a number\n";
            double number;
            cin >> number;
            calc *= number;
        }
        else if (mathOperator == '/') {
            cout << "Enter a number\n";
            double number;
            cin >> number;
            calc /= number;
        }
        else if (mathOperator == '-') {
            cout << "Enter a number\n";
            double number;
            cin >> number;
            calc -= number;
        }
        else if (mathOperator == '+') {
            cout << "Enter a number\n";
            double number;
            cin >> number;
            calc += number;
        }
        else if (mathOperator == '=') {
            cout << calc << endl;
        }
        else if (mathOperator == 'c') {
            calc = 0;
            cout << "Enter a number\n";
            cin >> calc;
        }
        else if (mathOperator == '0') {
            loop = false;
        }
        else {
            cout << "Error\n";
            cout << "Enter a number\n";
            cin >> calc;
        }
    }
}
