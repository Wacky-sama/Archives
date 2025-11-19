'
' Created by SharpDevelop.
' User: tabug
' Date: 06/10/2025
' Time: 8:21 pm
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
'Members: Tabugadir, Kenji "Brocks" I.,
	'	  Palarca, Kim Leo II C., 
	'	  Balgos, Wendel B.
	
Public Class MainForm
	WithEvents Dim BtnLogin As New Button
	WithEvents Dim Cls As New Button
	WithEvents Dim LblShow As New Label
	WithEvents Dim Tbx2 As New TextBox
	Dim GrpBx As New GroupBox
	WithEvents Dim Lbl1 As New Label
	Dim LblUN As New Label
    Dim LblPW As New Label
	WithEvents Dim Tbx1 As New TextBox
	Dim EP1 As New ErrorProvider
	Dim EP2 As New ErrorProvider
	Dim Form_01 As New Form1()
	Dim Form_02 As New Form2()
	Dim Form_03 As New Form3()
	Public Sub New()
		Me.InitializeComponent()
		
		Dim boldFont As New Font("A", 12, FontStyle.Bold)
		Dim uNFont As New Font("A", 10, FontStyle.Bold)
		Dim pWFont As New Font("A", 10, FontStyle.Bold)
		Dim sFont As New Font("A", 8, FontStyle.Bold)
		
		Me.BackColor = Color.Navy
		
		Me.Controls.Add(GrpBx)
		GrpBx.Top = 150
		GrpBx.Left = 625
		GrpBx.Width = 300
		GrpBx.Height = 300
		GrpBx.BackColor = Color.White
		
		GrpBx.Controls.Add(Lbl1)
		Lbl1.Text = "STUDENT CREDENTIALS"
		Lbl1.Font = boldFont
		Lbl1.Width = 249
		Lbl1.Top = 50
		Lbl1.Left = 45
		Lbl1.ForeColor = Color.Black
		
		GrpBx.Controls.Add(LblShow)
		LblShow.Text = "Show Password"
		LblShow.Font = sFont
		LblShow.Width = 150
		LblShow.Top = 165
		LblShow.Left = 120
		LblShow.ForeColor = Color.Navy
		
		GrpBx.Controls.Add(LblUN)
		LblUN.Text = "Username: "
		LblUN.Font = uNFont
		LblUN.Width = 86
		LblUN.Top = 105
		LblUN.Left = 25
		LblUN.ForeColor = Color.Navy
		
		GrpBx.Controls.Add(LblPW)
		LblPW.Text = "Password: "
		LblPW.Font = pWFont
		LblPW.Width = 85
		LblPW.Top = 140
		LblPW.Left = 25
		LblPW.ForeColor = Color.Navy
		
		GrpBx.Controls.Add(Tbx1)
		Tbx1.Width = 130
		Tbx1.Top = 105
		Tbx1.Left = 120
		
		GrpBx.Controls.Add(Tbx2)
		Tbx2.UseSystemPasswordChar = True
		Tbx2.Width = 130
		Tbx2.Top = 135
		Tbx2.Left = 120
		
		GrpBx.Controls.Add(BtnLogin)
		BtnLogin.Text = "Log In"
		BtnLogin.Height = 30
		BtnLogin.Width = 90
		BtnLogin.Top = 190
		BtnLogin.Left = 165
		BtnLogin.ForeColor = Color.White
		BtnLogin.BackColor = Color.Navy
		
		GrpBx.Controls.Add(Cls)
		Cls.Text = "Exit"
		Cls.Height = 30
		Cls.Width = 90
		Cls.Top = 190
		Cls.Left = 25
		Cls.ForeColor = Color.White
		Cls.BackColor = Color.Red
	End Sub
	
	Private Sub tbxs_KeyPress(ByVal Sender As Object, ByVal Kenji As System.Windows.Forms.KeyPressEventArgs) Handles Tbx1.KeyPress, Tbx2.KeyPress
    If Kenji.KeyChar = ChrW(Keys.Enter) Then
        DoLogin()
        Kenji.Handled = True
    End If
End Sub

Private Sub DoLogin()
        Dim Username As String = Tbx1.Text.Trim() 
        Dim Password As String = Tbx2.Text.Trim()
		EP1.SetError(Tbx1, String.Empty)
	 	EP2.SetError(Tbx2, String.Empty)
     
     If String.IsNullOrEmpty (Username) AndAlso String.IsNullOrEmpty (Password) Then
     	EP1.SetError(Tbx1, "Username Required!")
     	EP2.SetError(Tbx2, "Password Required!")
     	MsgBox("Please enter a username and password.")
     Else If String.IsNullOrEmpty (Username) Then
     	EP1.SetError(Tbx1, "Username Required!")
     	MsgBox("Please enter a username.")
     Else If String.IsNullOrEmpty (Password) Then
     	EP2.SetError(Tbx2, "Password Required!")
     	MsgBox("Please enter a password.")
     Else
     	'Kenji	
          If Username = "22-30463" AndAlso Password = "22-30463" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	
          	Form_01.Show()
          Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
           	'Kim Leo II.
          Else If Username = "22-30734" AndAlso Password = "22-30734" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	Form_02.Show()
       	Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
           	'Wendel
          Else If Username = "22-30450" AndAlso Password = "22-30450" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	Form_03.Show()
          	 	Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
          End If
       End If
	End Sub

	Private Sub Btn1(Sender As Object, Kenji As EventArgs) Handles BtnLogin.Click
        Dim Username As String = Tbx1.Text.Trim() 
        Dim Password As String = Tbx2.Text.Trim()
		EP1.SetError(Tbx1, String.Empty)
	 	EP2.SetError(Tbx2, String.Empty)
     
     If String.IsNullOrEmpty (Username) AndAlso String.IsNullOrEmpty (Password) Then
     	EP1.SetError(Tbx1, "Username Required!")
     	EP2.SetError(Tbx2, "Password Required!")
     	MsgBox("Please enter a username and password.")
     Else If String.IsNullOrEmpty (Username) Then
     	EP1.SetError(Tbx1, "Username Required!")
     	MsgBox("Please enter a username.")
     Else If String.IsNullOrEmpty (Password) Then
     	EP2.SetError(Tbx2, "Password Required!")
     	MsgBox("Please enter a password.")
     Else
     	'Kenji	
          If Username = "22-30463" AndAlso Password = "22-30463" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	Form_01.Show()
          Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
           	'Kim Leo II.
          Else If Username = "22-30734" AndAlso Password = "22-30734" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	
          	Form_02.Show()
       	Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
           	'Wendel
          Else If Username = "22-30450" AndAlso Password = "22-30450" Then
          	MsgBox("Login Successful!", vbInformation)
          	Me.Hide()
          	Dim Form_03 As New Form3()
          	Form_03.Show()
          	 	Else If Username <> Tbx1.Text AndAlso Password <> Tbx2.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Invalid login credentials.", vbInformation)
			Tbx1.Clear()
      	 	Tbx2.Clear()
          Else If Username <> Tbx1.Text Then
           	EP1.SetError(Tbx1, "Username Invalid!")
           	MsgBox("Entered username is invalid.", vbInformation)
           	Tbx1.Clear()
          Else If Password <> Tbx2.Text Then
           	EP2.SetError(Tbx2, "Password Invalid!")
           	MsgBox("Entered password is invalid.", vbInformation)
           	Tbx2.Clear()
          End If
       End If
	End Sub
	
	Private Sub LblClick(Sender As Object, Kenji As EventArgs) Handles LblShow.Click
        If Tbx2.UseSystemPasswordChar = True Then
            Tbx2.UseSystemPasswordChar = False
            LblShow.Text = "Hide Password"
        Else
            Tbx2.UseSystemPasswordChar = True
            LblShow.Text = "Show Password"
        End If
    End Sub
	
	Private Sub BtnCls(Sender As Object, Kenji As EventArgs) Handles Cls.Click
		Me.Close()
	End Sub
End Class