Imports System.IO
Imports System.Drawing

Public Class BuildingAnadB

    Dim roomNames As New List(Of String)
    Dim roomImagePath As String = "C:\Users\user\oop map bulding a and b"


    Private Sub RoomSearchApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRoomNames()
        SetupAutocomplete()
    End Sub


    Private Sub LoadRoomNames()
        roomNames.AddRange({"Finance Office", "Supreme Student Council", "Office of Student Affairs", "NTSP Paraya Office",
                           "Purchasing Office", "Graduate School Office", "General Service Office", "Lecture 101", "Registrar Office",
                           "Accounting Office", "Management System Office", "Human Resource Office", "Room 102", "Room 103", "Room 104",
                           "Room 105", "Room 201", "Room 202", "Room 203", "Room 204", "Room 205"})

        If cbRooms IsNot Nothing Then
            cbRooms.Items.AddRange(roomNames.ToArray())
        End If
    End Sub


    Private Sub SetupAutocomplete()
        If txtSearchBar IsNot Nothing Then
            Dim autoComplete As New AutoCompleteStringCollection()
            autoComplete.AddRange(roomNames.ToArray())

            txtSearchBar.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txtSearchBar.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchBar.AutoCompleteCustomSource = autoComplete
        End If
    End Sub


    Private Sub txtSearchBar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchBar.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim roomName As String = txtSearchBar.Text.Trim()
            If roomNames.Contains(roomName) Then
                DisplayRoomImage(roomName)
            Else
                MessageBox.Show("Room not found. Please check the name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub cbRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRooms.SelectedIndexChanged
        If cbRooms.SelectedItem IsNot Nothing Then
            Dim selectedRoom As String = cbRooms.SelectedItem.ToString()
            DisplayRoomImage(selectedRoom)
        End If
    End Sub


    Private Sub DisplayRoomImage(roomName As String)
        Try

            If Not Directory.Exists(roomImagePath) Then
                MessageBox.Show("The image directory does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim imageFilePath As String = Path.Combine(roomImagePath, roomName & ".png")


            If File.Exists(imageFilePath) Then
                Dim image As Image = Image.FromFile(imageFilePath)
                pbRoomMap.Image = image
                pbRoomMap.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MessageBox.Show("Image not found for " & roomName, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
