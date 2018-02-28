Imports System.ComponentModel

''' <summary>
''' View Model
''' </summary>
Public Class CCalc

    Implements INotifyPropertyChanged
    Implements IDisposable

    ''' <summary>
    ''' プロパティ変更イベント
    ''' </summary>
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    ''' <summary>
    ''' Input number 1
    ''' </summary>
    Private _Num1 As Integer

    ''' <summary>
    ''' Input number 2
    ''' </summary>
    Private _Num2 As Integer

    ''' <summary>
    ''' Input arithmetic operation
    ''' </summary>
    Private _Ope As String

    ''' <summary>
    ''' Calculation answer Message
    ''' </summary>
    Private _Message As String

    ''' <summary>
    ''' Message Visibility
    ''' </summary>
    Private _Visible As Boolean

    ''' <summary>
    ''' 重複呼出FLG
    ''' </summary>
    Private disposedValue As Boolean ' 重複する呼び出しを検出するには

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    Public Sub New()

        Num1 = "0"
        Num2 = "0"
        Operate = "+"
        Message = ""
        Visible = False

    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    ''' <param name="disposing">マネージ破棄FLG</param>
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: マネージ状態を破棄します (マネージ オブジェクト)。
            End If
        End If
        disposedValue = True
    End Sub

    ''' <summary>
    ''' 終了処理
    ''' </summary>
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub

    ''' <summary>
    ''' 数値1の取得・更新
    ''' </summary>
    ''' <returns></returns>
    Public Property Num1() As String
        Get
            Return Me._Num1.ToString
        End Get
        Set(value As String)

            Dim iNum As Integer

            If Integer.TryParse(value, iNum) Then
                If Not iNum.Equals(Me._Num1) Then
                    Me._Num1 = iNum
                    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Num1"))
                End If
            End If

        End Set
    End Property

    ''' <summary>
    ''' 数値2の取得・更新
    ''' </summary>
    ''' <returns></returns>
    Public Property Num2() As String
        Get
            Return Me._Num2.ToString
        End Get
        Set(value As String)

            Dim iNum As Integer

            If Integer.TryParse(value, iNum) Then
                If Not iNum.Equals(Me._Num2) Then
                    Me._Num2 = iNum
                    RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Num2"))
                End If
            End If

        End Set
    End Property

    ''' <summary>
    ''' 符号の取得・更新
    ''' </summary>
    ''' <returns></returns>
    Public Property Operate() As String
        Get
            Return Me._Ope
        End Get
        Set(value As String)
            If Not value.Equals(Me._Ope) Then
                Me._Ope = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Operate"))
            End If
        End Set
    End Property

    ''' <summary>
    ''' 回答メッセージの取得・更新
    ''' </summary>
    ''' <returns></returns>
    Public Property Message() As String
        Get
            Return Me._Message
        End Get
        Set(value As String)
            If Not value.Equals(Me._Message) Then
                Me._Message = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Message"))
            End If
        End Set
    End Property

    ''' <summary>
    ''' 回答メッセージの表示FLGを取得・更新
    ''' </summary>
    Public Property Visible() As Boolean
        Get
            Return Me._Visible
        End Get
        Set(value As Boolean)
            If Not value.Equals(Me._Visible) Then
                Me._Visible = value
                RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs("Visible"))
            End If
        End Set
    End Property

End Class
