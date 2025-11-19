'
' Created by SharpDevelop.
' User: tabug
' Date: 06/10/2025
' Time: 8:25 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
'Wendel's Credentials
Public Class Form3
	Private WithEvents Dim btnExit As New Button	
	Dim grpCredentials As New GroupBox	
	Dim lblTitle As New Label	 
	Dim lblFullName As New Label
	Dim lblEmail As New Label 
	Dim lblContact As New Label
	Dim lblAddress As New Label 
	Public Sub New()
		Me.InitializeComponent()
			
		Me.Text = "Balgos, Wendel B."
			
		Dim boldFont As New Font("Arial", 12, FontStyle.Bold)
        Dim lblFont As New Font("Arial", 8, FontStyle.Bold)
        Dim btnFont As New Font("Arial", 8, FontStyle.Bold)
			
		Me.BackColor = Color.Navy
			
		' === GroupBox ===
        Me.Controls.Add(grpCredentials)
        grpCredentials.Width = 300
        grpCredentials.Height = 300
        grpCredentials.BackColor = Color.White
			
		' === Title ===
        grpCredentials.Controls.Add(lblTitle)
        lblTitle.Font = boldFont
        lblTitle.Text = "YOUR CREDENTIALS"
        lblTitle.Width = 300
        lblTitle.Top = 25
        lblTitle.Left = 50
			
		 ' === Fullname ===
        grpCredentials.Controls.Add(lblFullName)
        lblFullName.Font = lblFont
        lblFullName.Text = "Fullname: Palarca, Kim Leo II C."
        lblFullName.Width = 300
        lblFullName.Top = 75
			
		' === Address ===
        grpCredentials.Controls.Add(lblAddress)
        lblAddress.Font = lblFont
        lblAddress.Text = "Address: Centro, Sta. Ana, Cagayan"
        lblAddress.Width = 300
        lblAddress.Top = 100
			
		' === Email ===
        grpCredentials.Controls.Add(lblEmail)
        lblEmail.Font = lblFont
        lblEmail.Text = "Email Address: kimleo@gmail.com"
        lblEmail.Width = 300
        lblEmail.Top = 125
			
		' === Contact ===
        grpCredentials.Controls.Add(lblContact)
        lblContact.Font = lblFont
        lblContact.Text = "Contact Info: 09156168915"
        lblContact.Width = 300
        lblContact.Top = 150
		
		' === Exit Button ===
        grpCredentials.Controls.Add(btnExit)
        btnExit.Font = btnFont
        btnExit.Text = "Exit"
        btnExit.Width = 50
        btnExit.Top = 180
        btnExit.Left = 125
	End Sub
	
	Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
	
	Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Dim MF As New MainForm()
        MF.Show()
    End Sub
End Class

