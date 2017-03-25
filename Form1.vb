Public Class Form1
    'declare 7 globle integer variale which will be use in timer control.
    Dim i, a, a1, b, b1, c1, c As Integer
    'FOR APPLYING RANDOM NUMBER FOR DECIDING FAIR   WINNER 
    Dim r As New Random

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Enable all timer .
        TimerBlue.Start()
        TimerRed.Start()
        TimerGreen.Start()

    End Sub

    'FOR RED CIRCLE CODE.

    Private Sub TimerRed_Tick(sender As Object, e As EventArgs) Handles TimerRed.Tick

        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "a" AND "a1"

        a = OvalShape1.Location.X
        a1 = OvalShape1.Location.Y

        'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
        'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".


        'CHECK THE LINESHAPE(HORIZONTAL LINE) OF WIDTH  END POINT (X2) IS LESST THAN TO GLOBLE VARIABLE "a" OR NOT .

        If a <= LineShape1.X2 Then

            'HERE "r" IS RANDOM INTEGER NUMBER. WE DEFINE RANGE BETWEEN 1 AND 15.
            'SYNTAX TO MOVE CIRCLE FROM OLD POSITION TO NEW  POSITION

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))


            OvalShape1.Location = New Point(a + (r.Next(1, 15)), a1)

        Else

            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.
            TimerRed.Enabled = False
            TimerBlue.Enabled = False
            TimerGreen.Enabled = False
            MsgBox("red is winner")

        End If

    End Sub

    'FOR BLUE CIRCLE CODE.


    Private Sub TimerBlue_Tick(sender As Object, e As EventArgs) Handles TimerBlue.Tick
        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "b" AND "b1"

        b = OvalShape2.Location.X
        b1 = OvalShape2.Location.Y

        If b < LineShape2.X2 Then

            'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
            'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))

            OvalShape2.Location = New Point(b + (r.Next(1, 15)), b1)

        Else

            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.
            TimerBlue.Enabled = False
            TimerRed.Enabled = False
            TimerGreen.Enabled = False

            MsgBox("Blue is Winner")
        End If



    End Sub

    'CODE FOR GREEN CIRCLE.
    Private Sub TimerGreen_Tick(sender As Object, e As EventArgs) Handles TimerGreen.Tick
        'GET THE VALUE OF OVAL OR CIRCLE  AND STOER THEM TO GLOBLE VARIABLE "c" AND "c1"


        c = OvalShape3.Location.X
        c1 = OvalShape3.Location.Y

        If c <= LineShape3.X2 Then
            'START OF LINESHAPE WIDTH IS "x1" AND END POINT IS "x2".
            'SIMILIAR TO START OF LINESHAPE HEIGHT IS "Y1" AND END POINT IS "Y2".

            ' CONTROLNAME.Location=
            'New Point(X-axix(IN INTEGER),Y-axis(IN INTEGER))
            OvalShape3.Location = New Point(c + (r.Next(1, 15)), c1)

        Else
            'IT MEANS CIRCLE REACH END POINT SO STOP  ALL TIMER AND DECLARE A WINNER.
            TimerBlue.Enabled = False
            TimerRed.Enabled = False
            TimerGreen.Enabled = False
            MsgBox("Green is Winner")

        End If


    End Sub

End Class
