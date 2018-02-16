#include <iostream>

int main()
{

    int iNum1;
    bool bOK;
    char cOpe;
    int iOpe;
    int iNum2;
    float fAnswer;

    //Initialize
    iNum1 = 0;
    bOK = false;
    cOpe = ' ';
    iOpe = -1;
    iNum2 = 0;
    fAnswer = 0;

    //Number:1
    std::cout << "Input number 1: ";    //Output
    std::cin >> iNum1;                  //Input

    //Operator
    std::cout << "Input arithmetic operator: ";

    while (bOK == false)
    {

        std::cin >> cOpe;

        switch(cOpe)
        {
            case '+':
                iOpe = 0;
                bOK = true;
                break;

            case '-':
                iOpe = 1;
                bOK = true;
                break;

            case '*':
                iOpe = 2;
                bOK = true;
                break;

            case '/':
                iOpe = 3;
                bOK = true;
                break;

            default:
                break;

        }

    }

    //Number:2
    std::cout << "Input number 2: ";
    std::cin >> iNum2;

    //Calculation
    switch(iOpe)
    {

        case 0:
            fAnswer = (float)(iNum1) + (float)(iNum2);
            break;

        case 1:
            fAnswer = (float)(iNum1) - (float)(iNum2);
            break;

        case 2:
            fAnswer = (float)(iNum1) * (float)(iNum2);
            break;

        case 3:
            
            if (iNum2 != 0)
            {
                fAnswer = (float)(iNum1) / (float)(iNum2);
            }
            else
            {
                fAnswer = -1.0;
            }

            break;

        default:
            fAnswer = -1.0;
            break;

    }

    std::cout << "Answer: " << fAnswer << "\n";

    return 0;

}