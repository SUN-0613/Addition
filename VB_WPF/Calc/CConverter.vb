Imports System.Globalization

Public Class BoolToVisibleConverter

    Implements IValueConverter

    ''' <summary>
    ''' Boolean -> Visibility
    ''' </summary>
    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        Return If(DirectCast(value, Boolean), Visibility.Visible, Visibility.Hidden)
    End Function

    ''' <summary>
    ''' Visibility -> Boolean
    ''' </summary>
    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Return If(DirectCast(value, Integer).Equals(0), True, False)
    End Function

End Class