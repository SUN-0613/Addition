Calc <- function()
{

    iNum1 <- 0
    bOK <- FALSE
    cOpe <- " "
    iOpe <- -1
    iNum2 <- 0
    fAnswer <- 0.0

    #number 1
    iNum1 <- as.numeric(readline("Input number 1: "))

    #operator
    cat("input arithmetic operator: ")

    while (bOK == FALSE)
    {

        cOpe <- readline("")

        iOpe <- switch (cOpe
            ,"+" = 0
            ,"-" = 1
            ,"*" = 2
            ,"/" = 3
            ,-1
        )

        if (iOpe != -1)
        {
            bOK = TRUE
        }
        else 
        {
            bOK = FALSE
        }

    }

    #number 2
    iNum2 <- as.numeric(readline("Input number 2: "))

    #Calculation
    if (iOpe == 0)
    {
        fAnswer <- iNum1 + iNum2
    }
    else if (iOpe == 1)
    {
        fAnswer <- iNum1 - iNum2
    }
    else if (iOpe == 2)
    {
        fAnswer <- iNum1 * iNum2
    }
    else if (iOpe == 3)
    {
        fAnswer <- ifelse(iNum2 != 0, iNum1 / iNum2, -1)
    }

    print(sprintf("Answer: %.3f", fAnswer))

}

#execute program
Calc()