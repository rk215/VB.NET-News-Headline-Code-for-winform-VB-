Public Class Form1
    Dim t As Integer = 1 'declare globle variable t type of integer.

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()  'start timer at form load.

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Label1.Left + Label1.Width > 0 Then 'to check wether left and width propertie of label control is greater than 0 or not
            Label1.Left -= t
            t += 1
        Else
            Label1.Left = Me.Width
        End If


    End Sub
End Class
