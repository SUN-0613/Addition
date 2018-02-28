Imports System.Globalization

''' <summary>
''' Visibility ⇔ Boolean
''' </summary>
Public Class BoolToVisibleConverter

    Implements IValueConverter

    ''' <summary>
    ''' Boolean -> Visibility
    ''' </summary>
    Public Function Convert(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.Convert
        Return If(DirectCast(value, Boolean), Visibility.Visible, Visibility.Collapsed)
    End Function

    ''' <summary>
    ''' Visibility -> Boolean
    ''' </summary>
    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, language As String) As Object Implements IValueConverter.ConvertBack
        Return If(DirectCast(value, Integer).Equals(0), True, False)
    End Function

End Class