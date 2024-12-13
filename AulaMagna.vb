Imports MySql.Data.MySqlClient

Public Class AulaMagna
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub AulaMagna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        LoadRoomNames()
        SetDefaultImage()
    End Sub

    Private Sub LoadRoomNames()
        Try
            sql = "SELECT room_name FROM AulaMagna2"
            cmd = New MySqlCommand(sql, conn)

            dr = cmd.ExecuteReader()

            cbRoom.Items.Clear()

            While dr.Read()
                cbRoom.Items.Add(dr("room_name").ToString())
            End While


            If cbRoom.Items.Count > 0 Then
                cbRoom.SelectedIndex = -1
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub cbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoom.SelectedIndexChanged
        If cbRoom.SelectedIndex <> -1 Then
            Dim selectedRoom As String = cbRoom.SelectedItem.ToString()
            UpdateRoomImage(selectedRoom)
        End If
    End Sub

    Private Sub UpdateRoomImage(roomName As String)
        Dim imagePath As String = "C:\Users\user\Downloads\OOP - MAP\"

        Try
            Dim imageFilePath As String = imagePath & roomName & ".png"

            Dim image As Image = Image.FromFile(imageFilePath)

            Dim resizedImage As Image = ResizeImageToFit(image, pbAula2.Width, pbAula2.Height)

            pbAula2.Image = resizedImage

            pbAula2.SizeMode = PictureBoxSizeMode.CenterImage

        Catch ex As Exception
            MessageBox.Show("Image not found for " & roomName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ResizeImageToFit(img As Image, maxWidth As Integer, maxHeight As Integer) As Image
        Dim aspectRatio As Double = img.Width / img.Height
        Dim newWidth As Integer = maxWidth
        Dim newHeight As Integer = maxHeight

        If img.Width > maxWidth Then
            newWidth = maxWidth
            newHeight = CInt(maxWidth / aspectRatio)
        End If

        If newHeight > maxHeight Then
            newHeight = maxHeight
            newWidth = CInt(maxHeight * aspectRatio)
        End If

        Return New Bitmap(img, newWidth, newHeight)
    End Function

    Private Sub SetDefaultImage()
        Dim imagePath As String = "C:\Users\user\Downloads\OOP - MAP\"
        Try

            Dim defaultImagePath As String = imagePath & "2nd floor.png"

            Dim image As Image = Image.FromFile(defaultImagePath)

            Dim resizedImage As Image = ResizeImageToFit(image, pbAula2.Width, pbAula2.Height)

            pbAula2.Image = resizedImage

            pbAula2.SizeMode = PictureBoxSizeMode.CenterImage

        Catch ex As Exception

            MessageBox.Show("Default image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim reportForm As New Report()

        reportForm.Show()
    End Sub
End Class
