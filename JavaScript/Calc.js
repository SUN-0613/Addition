function Calc()
{

    var iNum1;
    var iNum2;
    var cOpe;
    var iOpe;
    var bOK;
    var fAnswer;

    //Initialize
    iNum1 = 0;
    iNum2 = 0;
    cOpe = ' ';
    iOpe = -1;
    bOK = false;
    fAnswer = 0.0;

    //Number 1
    iNum1 = parseInt(document.getElementById("iNum1").value);

    //Operator
    cOpe = document.getElementById("cOpe").value;

    //wihle処理とすると、該当記号以外を入力すると無限ループとなるので、ここではbOK=falseならreturnとする
    switch (cOpe)
    {
        case "+":
            iOpe = 0;
            bOK = true;
            break;

        case "-":
            iOpe = 1;
            bOK = true;
            break;

        case "*":
            iOpe = 2;
            bOK = true;
            break;

        case "/":
            iOpe = 3;
            bOK = true;
            break;

        default:
            bOK = false;
            break;

    }

    if (bOK == false)
    {
        document.getElementById("fAnswer").textContent = "Input error";
    }
    else
    {

        //Number 2
        iNum2 = parseInt(document.getElementById("iNum2").value);

        switch (iOpe)
        {
            case 0:
                fAnswer = parseFloat(iNum1) + parseFloat(iNum2);
                break;

            case 1:
                fAnswer = parseFloat(iNum1) - parseFloat(iNum2);
            break;

            case 2:
                fAnswer = parseFloat(iNum1) * parseFloat(iNum2);
                break;

            case 3:
                
                if (iNum2 != 0)
                {
                    fAnswer = parseFloat(iNum1) / parseFloat(iNum2);
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

        document.getElementById("fAnswer").textContent = "Answer : " + fAnswer;

    }

    return;

}