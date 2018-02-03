#include <stdio.h>

int main()
{

    int iNum1;
    int iNum2;
    int iAnswer;

    //Initialize
    iNum1 = 0;
    iNum2 = 0;
    iAnswer = 0;

    printf("Calculation for Addition\n");
    
    printf("Input first number: ");
    scanf("%d", &iNum1);

    printf("Input second number: ");
    scanf("%d", &iNum2);

    iAnswer = iNum1 + iNum2;
    printf("Answer: %d\n", iAnswer);

    return 0;

}