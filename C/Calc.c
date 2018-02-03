#include <stdio.h>
#include <stdbool.h>

int main()
{

    int iNum1;
    int iNum2;
    float fAnswer;
    int iOpe;   //0:+, 1:-, 2:*, 3:/
    bool bOK;
    char cOpe;

    //Initialize
    iNum1 = 0;
    iNum2 = 0;
    fAnswer = 0.0;
    iOpe = -1;
    bOK = false;
    cOpe = ' ';

    printf("Calculation for Addition\n");
    
    //Number:1
    printf("Input first number: ");
    scanf("%d", &iNum1);

    //Operator
    printf("Input arithmetic operator: ");
    
    while (bOK == false)
    {

        scanf("%c", &cOpe);

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
    printf("Input second number: ");
    scanf("%d", &iNum2);

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

            if (iNum2 == 0)
            {
                fAnswer = -1.0;
            }
            else
            {
            fAnswer = (float)(iNum1) / (float)(iNum2);
            }

            break;

        default:
            fAnswer = -1.0;
            break;

    }

    printf("Answer: %f\n", fAnswer);

    return 0;

}