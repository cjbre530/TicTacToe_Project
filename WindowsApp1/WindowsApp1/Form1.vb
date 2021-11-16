Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Form1
    'Name Function
    Public ply1, ply2 As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Welcome to Tic Tac Toe!")
        ply1 = InputBox("Enter Name For X's", "Name of Player 1")
        ply2 = InputBox("Enter Name For O's", "Name of Player 2")
        If ply1 = "" Then
            ply1 = "Player 1"
            ply2 = "Player 2"
        End If
        Label1.Text = ply1 + Label1.Text
        Label2.Text = ply2 + Label2.Text
        Label3.Text = ply1 + Label3.Text
        Label4.Text = ply2 + Label4.Text
        Label2.Visible = False
    End Sub

    'Clears Form
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If True Then
            Dim frm = New Form1
            frm.Show()
        End If
    End Sub

    'Buttons After Win
    Private Sub aft_win()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    'Label Reset Show
    Private Sub lbl_resSH()
        LabelReset.Visible = True
    End Sub

    'Label Arrow Show
    Private Sub arrw_resDS()
        LabelArrow.Visible = False
    End Sub

    'Label Reset Doesn't Show 
    Private Sub lbl_resDS()
        LabelReset.Visible = False
    End Sub

    'Label Arrow Show
    Private Sub arrw_resSH()
        LabelArrow.Visible = True
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Label1.Visible = True Then
            Button1.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 1
        End If

        If Label2.Visible = True Then
            Button1.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 1
        End If

1:      Button1.Enabled = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Label1.Visible = True Then
            Button3.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 3
        End If

        If Label2.Visible = True Then
            Button3.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 3
        End If

3:      Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Visible = True Then
            Button2.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button2.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button2.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Label1.Visible = True Then
            Button4.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button4.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If Label1.Visible = True Then
            Button5.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button5.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button5.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If Label1.Visible = True Then
            Button6.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button6.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button6.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Label1.Visible = True Then
            Button7.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button7.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button7.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Label1.Visible = True Then
            Button8.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button8.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button8.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Label1.Visible = True Then
            Button9.Text = "X"
            win_chk1()
            Label1.Visible = False
            Label2.Visible = True
            GoTo 2
        End If

        If Label2.Visible = True Then
            Button9.Text = "O"
            win_chk2()
            Label1.Visible = True
            Label2.Visible = False
            GoTo 2
        End If

2:      Button9.Enabled = False
    End Sub
    'Resets Buttons
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If True Then
            Button1.Text = ""
            Button1.Enabled = True
            Button2.Text = ""
            Button2.Enabled = True
            Button3.Text = ""
            Button3.Enabled = True
            Button4.Text = ""
            Button4.Enabled = True
            Button5.Text = ""
            Button5.Enabled = True
            Button6.Text = ""
            Button6.Enabled = True
            Button7.Text = ""
            Button7.Enabled = True
            Button8.Text = ""
            Button8.Enabled = True
            Button9.Text = ""
            Button9.Enabled = True
            lbl_resDS()
            arrw_resDS()
        End If
    End Sub

    'Player 1's Win
    Private Sub win_chk1()
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            MsgBox("Congradulations! " & ply1 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label5.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.Close()
    End Sub

    'Player 2's Win
    Private Sub win_chk2()
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        ElseIf Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            MsgBox("Congradulations! " & ply2 & ", You Won This Round!", MsgBoxStyle.Information, "Win")
            Label6.Text += 1
            aft_win()
            lbl_resSH()
            arrw_resSH()
        End If
    End Sub



End Class
