Imports DevExpress.Mvvm.DataAnnotations
Imports System.ComponentModel.DataAnnotations

Namespace Example.ViewModel

    <POCOViewModel(ImplementIDataErrorInfo:=True)>
    Public Class MainViewModel

        <Required>
        Public Overridable Property FirstName As String

        <Required>
        Public Overridable Property LastName As String
    End Class
End Namespace
