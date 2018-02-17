import java.util.Scanner;
import javax.lang.model.util.ElementScanner6;

public class Calc
{

    public static void main(String[] args)
    {

        Scanner scan = new Scanner(System.in);
        int iNum1;
        boolean bOK;
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
        fAnswer = (float)(0.0);

        //Number:1
        System.out.print("Input number 1: ");   //Output
        iNum1 = scan.nextInt();                 //Input

        //Operator
        System.out.print("Input arithmetic operator: ");

        while(bOK == false)
        {

            cOpe = scan.next().charAt(0);

            switch (cOpe)
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
        System.out.print("Input number 2: ");
        iNum2 = scan.nextInt();

        switch (iOpe)
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
                    fAnswer = (float)(-1.0);
                }
                break;

            default:
                fAnswer = (float)(-1.0);
        }

        System.out.println("Answer: " + String.valueOf(fAnswer));

        return;

    }

}