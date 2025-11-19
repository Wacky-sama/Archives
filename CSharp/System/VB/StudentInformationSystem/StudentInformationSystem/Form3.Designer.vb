'
' Created by SharpDevelop.
' User: tabug
' Date: 06/10/2025
' Time: 8:25 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class Form3
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		'
		'Form3
		'
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.Name = "Form3"
		Me.Text = "Form3"
	End Sub
End Class
