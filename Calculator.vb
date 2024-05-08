Public Class Calculator

    Public Function buttons(z As String)
        txtResult.Text = txtResult.Text + z
        Return z
    End Function

    Public Function operators(y As String)
        Label2.Text = txtResult.Text
        Label3.Text = y
        txtResult.Text = ""
        Return y
    End Function

    Public Function clear()
        txtResult.Text = ""
        Label3.Text = ""
        Return ""
    End Function

    Public Function operation(add As String, diff As String, prod As String, div As String)
        If Label3.Text = add Then
            txtResult.Text = Val(Label2.Text) + Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        ElseIf Label3.Text = diff Then
            txtResult.Text = Val(Label2.Text) - Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        ElseIf Label3.Text = prod Then
            txtResult.Text = Val(Label2.Text) * Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        ElseIf Label3.Text = div Then
            txtResult.Text = Val(Label2.Text) / Val(txtResult.Text)
            Label2.Text = ""
            Label3.Text = ""
        End If
    End Function

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        Dim one As String
        one = "1"
        buttons(one)
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        Dim two As String
        two = "2"
        buttons(two)
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        Dim three As String
        three = "3"
        buttons(three)
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        Dim four As String
        four = "4"
        buttons(four)
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        Dim five As String
        five = "5"
        buttons(five)
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        Dim six As String
        six = "6"
        buttons(six)
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        Dim seven As String
        seven = "7"
        buttons(seven)
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        Dim eight As String
        eight = "8"
        buttons(eight)
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        Dim nine As String
        nine = "9"
        buttons(nine)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim zero As String
        zero = "0"
        buttons(zero)
    End Sub

    Private Sub btnTwozero_Click(sender As Object, e As EventArgs) Handles btnTwozero.Click
        Dim doubleZero As String
        doubleZero = "00"
        buttons(doubleZero)
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        Dim period As String
        period = "."
        buttons(period)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As String
        add = "+"
        operators(add)
    End Sub

    Private Sub btnDiff_Click(sender As Object, e As EventArgs) Handles btnDiff.Click
        Dim diff As String
        diff = "-"
        operators(diff)
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim division As String
        division = "/"
        operators(division)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        Dim product As String
        product = "x"
        operators(product)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
        Label2.Text = ""
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim add, diff, div, prod As String
        add = "+"
        diff = "-"
        prod = "*"
        div = "/"

        operation(add, diff, prod, div)


    End Sub


    Private Sub BMIToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles BMIToolStripMenuItem.Click
        BMIForm.Show()

        Me.Hide()
    End Sub

    Private Sub txtResult_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtResult.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) Then
            e.Handled = True
        End If
    End Sub

End Class
