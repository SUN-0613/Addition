' 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

''' <summary>
''' それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' View Model
    ''' </summary>
    Public Property Calc As New CCalc

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New()

        InitializeComponent()

    End Sub

    ''' <summary>
    ''' 計算開始
    ''' </summary>
    Private Sub Calc_Click(sender As Object, e As RoutedEventArgs)

        Dim iNum1 As Integer
        Dim iNum2 As Integer
        Dim cOpe As New Text.StringBuilder
        Dim iOpe As Integer
        Dim bOK As Boolean
        Dim fAnswer As Double

        'Initialize
        iNum1 = 0
        iNum2 = 0
        cOpe.Clear()
        iOpe = -1
        bOK = False
        fAnswer = -1.0

        Calc.Message = ""
        Calc.Visible = False

        'number 1
        iNum1 = Convert.ToInt32(Calc.Num1)

        'operater
        cOpe.Append(Calc.Operate)

        Select Case cOpe.ToString
            Case "+"
                iOpe = 0
                bOK = True
            Case "-"
                iOpe = 1
                bOK = True
            Case "*"
                iOpe = 2
                bOK = True
            Case "/"
                iOpe = 3
                bOK = True
            Case Else
                bOK = False
        End Select

        If bOK Then

            'number 2
            iNum2 = Convert.ToInt32(Calc.Num2)

            Select Case iOpe
                Case 0
                    fAnswer = Convert.ToDouble(iNum1) + Convert.ToDouble(iNum2)

                Case 1
                    fAnswer = Convert.ToDouble(iNum1) - Convert.ToDouble(iNum2)

                Case 2
                    fAnswer = Convert.ToDouble(iNum1) * Convert.ToDouble(iNum2)

                Case 3
                    If Not iNum2.Equals(0) Then
                        fAnswer = Convert.ToDouble(iNum1) / Convert.ToDouble(iNum2)
                    Else
                        Calc.Message = "Input Error"
                        Calc.Visible = True
                    End If

                Case Else
                    Calc.Message = "Input Error"
                    Calc.Visible = True

            End Select

            If Not Calc.Visible Then

                Calc.Message = "Answer: " & fAnswer.ToString("0.000")
                Calc.Visible = True

            End If

        Else

            Calc.Message = "Input Error"
            Calc.Visible = True

        End If

        'Release
        cOpe.Clear()
        cOpe = Nothing

    End Sub

End Class
