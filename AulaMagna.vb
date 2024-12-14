Imports MySql.Data.MySqlClient

Public Class AulaMagna
    Dim sql As String
    Dim cmd As New MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub AulaMagna_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DbConnect()
        LoadFloorOptions()
        cbAulaFloor.SelectedIndex = 0
        SetDefaultImage()
    End Sub

    Private Sub LoadFloorOptions()
        cbAulaFloor.Items.Clear()
        cbAulaFloor.Items.Add("1st")
        cbAulaFloor.Items.Add("2nd")
    End Sub

    Private Sub LoadRoomNames()
        Try
            Dim floor As String = cbAulaFloor.SelectedItem.ToString()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            If floor = "1st" Then
                sql = "SELECT aula1room_name FROM AulaMagna1"
            Else
                sql = "SELECT aula2room_name FROM AulaMagna2"
            End If

            cmd = New MySqlCommand(sql, conn)
            dr = cmd.ExecuteReader()

            cbRoom.Items.Clear()

            While dr.Read()
                If floor = "1st" Then
                    cbRoom.Items.Add(dr("aula1room_name").ToString())
                Else
                    cbRoom.Items.Add(dr("aula2room_name").ToString())
                End If
            End While

            If cbRoom.Items.Count > 0 Then
                cbRoom.SelectedIndex = -1
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If
        End Try
    End Sub


    Private Sub cbAulaFloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAulaFloor.SelectedIndexChanged
        ' Unselect the room when changing the floor
        cbRoom.SelectedIndex = -1 ' Clear the room selection

        ' Reload room names based on the selected floor
        LoadRoomNames()

        ' Set the default image for the selected floor
        SetDefaultImage()
    End Sub

    Private Sub SetDefaultImage()
        ' Default image based on selected floor
        Dim imagePath As String = "C:\Users\user\Downloads\OOP - MAP\"
        Dim defaultImagePath As String = ""

        If cbAulaFloor.SelectedItem.ToString() = "1st" Then
            defaultImagePath = imagePath & "Ground Floor.png" ' Set default image for the 1st floor
        Else
            defaultImagePath = imagePath & "2nd floor.png" ' Set default image for the 2nd floor
        End If

        Try
            Dim image As Image = Image.FromFile(defaultImagePath)

            ' Resize the image to fit the PictureBox size
            Dim resizedImage As Image = ResizeImageToFit(image, pbAula2.Width, pbAula2.Height)

            pbAula2.Image = resizedImage
            pbAula2.SizeMode = PictureBoxSizeMode.CenterImage

        Catch ex As Exception
            MessageBox.Show("Default image not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbRoom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoom.SelectedIndexChanged
        If cbRoom.SelectedIndex <> -1 Then
            Dim selectedRoom As String = cbRoom.SelectedItem.ToString()
            UpdateRoomImage(selectedRoom)
        End If
    End Sub

    Private Sub UpdateRoomImage(roomName As String)
        Dim floor As String = cbAulaFloor.SelectedItem.ToString()
        Dim imagePath As String = "C:\Users\user\Downloads\OOP - MAP\"
        Dim imageFilePath As String = imagePath & roomName & ".png" ' Assuming the same file naming convention

        If floor = "1st" Then
            ' If on the 1st floor, fetch images from AulaMagna1
            imageFilePath = imagePath & roomName & ".png"
        ElseIf floor = "2nd" Then
            ' If on the 2nd floor, fetch images from AulaMagna2
            imageFilePath = imagePath & roomName & ".png"
        End If

        Try
            Dim image As Image = Image.FromFile(imageFilePath)

            ' Resize the image to fit the PictureBox size
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



    'Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
    'Dim reportForm As New Report()

    'reportForm.Show()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
