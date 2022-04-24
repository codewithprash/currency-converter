Public Class Form1
    Dim us As Double = 0.01314
    Dim eur As Double = 0.01198
    Dim gbp As Double = 0.01002
    Dim rub As Double = 1.291
    Dim cad As Double = 0.01642
    Dim aud As Double = 0.01749
    Dim cny As Double = 0.08369
    Dim jpy As Double = 1.63
    Dim chf As Double = 0.0123
    Dim sgd As Double = 0.01787

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Nothing
        ComboBox1.Text = Nothing
        TextBox2.Text = Nothing
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ind As Double
        ind = Val(TextBox1.Text)

        Label6.Text = ComboBox1.Text

        If ComboBox1.Text = "USD" Then
            TextBox2.Text = ind * us
        End If
        If ComboBox1.Text = "EUR" Then
            TextBox2.Text = ind * eur
        End If
        If ComboBox1.Text = "GBP" Then
            TextBox2.Text = ind * gbp
        End If
        If ComboBox1.Text = "RUB" Then
            TextBox2.Text = ind * rub
        End If
        If ComboBox1.Text = "CAD" Then
            TextBox2.Text = ind * cad
        End If
        If ComboBox1.Text = "AUD" Then
            TextBox2.Text = ind * aud
        End If
        If ComboBox1.Text = "CNY" Then
            TextBox2.Text = ind * cny
        End If
        If ComboBox1.Text = "JPY" Then
            TextBox2.Text = ind * jpy
        End If
        If ComboBox1.Text = "CHF" Then
            TextBox2.Text = ind * chf
        End If
        If ComboBox1.Text = "SGD" Then
            TextBox2.Text = ind * sgd
        End If

    End Sub
End Class
