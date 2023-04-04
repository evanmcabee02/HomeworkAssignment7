Public Class frmKaraoke
    Private _decSong As Decimal = 2.99D
    Private _decHourlyRate As Decimal = 8.99D
    Private Sub frmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(3000)
        ClearForm()
    End Sub

    Private Function ValidateInput() As Boolean
        Dim intNumber As Integer
        Dim blnValid As Boolean = False

        Try
            intNumber = Convert.ToInt32(txtHours.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
            End If
        Catch Exception As FormatException
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            MsgBox("Please enter a reasonable number", , "Error")
        Catch Exception As SystemException
            MsgBox("Entry invalid. Please enter a valid number representing the number in your party", , "Error")

        End Try

        txtHours.Focus()
        txtHours.Clear()
        Return blnValid

    End Function

    Private Function ComputeSongCost(ByVal intPass As Integer) As Decimal
        Dim decPassCost As Decimal
        decPassCost = intPass * _decSong
        Return decPassCost
    End Function

    Private Function ComputeRoomCost(ByVal intPass As Integer) As Decimal
        Dim decTicketCost As Decimal
        decTicketCost = intPass * _decHourlyRate
        Return decTicketCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub ClearForm()
        cboKaraoke.SelectedIndex = -1
        lblDisplay.Visible = False
        txtHours.Visible = False
        btnCalculate.Visible = False
        btnClear.Visible = False
        txtHours.Clear()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim blnAmountIsValid As Boolean = False
        Dim intValue As Integer
        Dim decTotal As Decimal

        blnAmountIsValid = ValidateInput()
        If blnAmountIsValid = True Then
            intValue = Convert.ToInt32(txtHours.Text)
            If cboKaraoke.SelectedIndex = 0 Then
                decTotal = ComputeSongCost(intValue)
            Else
                decTotal = ComputeRoomCost(intValue)
            End If
            lblTotalCost.Visible = True
            lblTotalCost.Text = "Total Cost of Karaoke Night - " & decTotal.ToString("C")
        End If
    End Sub

    Private Sub cboKaraoke_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraoke.SelectedIndexChanged
        If cboKaraoke.SelectedIndex = 0 Then
            lblDisplay.Text = "Number of Karaoke Songs"
            lblDisplay.Visible = True
            txtHours.Visible = True
            btnCalculate.Visible = True
            btnClear.Visible = True
            txtHours.Focus()
        End If
        If cboKaraoke.SelectedIndex = 1 Then
            lblDisplay.Text = "Hourly Rental of Karaoke Room:"
            lblDisplay.Visible = True
            txtHours.Visible = True
            btnCalculate.Visible = True
            btnClear.Visible = True
            txtHours.Focus()

        End If
    End Sub
End Class
