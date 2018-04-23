Imports Microsoft.VisualBasic
Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports System.ComponentModel.DataAnnotations

Namespace Example.ViewModel
	<POCOViewModel(ImplementIDataErrorInfo:=True)> _
	Public Class MainViewModel
		Private privateFirstName As String
		<Required> _
		Public Overridable Property FirstName() As String
			Get
				Return privateFirstName
			End Get
			Set(ByVal value As String)
				privateFirstName = value
			End Set
		End Property
		Private privateLastName As String
		<Required> _
		Public Overridable Property LastName() As String
			Get
				Return privateLastName
			End Get
			Set(ByVal value As String)
				privateLastName = value
			End Set
		End Property
	End Class
End Namespace
