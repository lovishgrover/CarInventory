'Author : Lovish Grover
'Date : March 24 2020
'Description :
' This program is allowing the user to enter the car detail list like
' car make, model , year , price , new or used and then
' display the whole entered data in a list view and make 
' a list according To the enterd data.
' Some of the code is taken by the resources provided by Prof. Kyle Chapman 

' Github link :

Option Strict On
Public Class frmCarInfo

#Region "Declarations"

    ''' <summary>
    ''' 'Variable Declarations
    ''' </summary>
    Dim choosedCar As Car
    Dim carList As New List(Of Car)
    Dim isAddingToListView As Boolean = False
    Dim isCarSelected As Boolean = False

    Const DefaultYear As Integer = 1920

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' To enter a car detail entered by the user and validate that the 
    ''' entered data is appropriate and then add it to list.
    ''' </summary>

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        ' to validate input data 
        If IsValidInput() = True Then

            lblMessage.Text = "Entry has been added!"   ' displays message that the entry has been added

            If Not isCarSelected Then


                choosedCar = New Car(cmbMake.Text, txtModel.Text, CInt(nudYear.Value), Convert.ToDecimal(txtPrice.Text), chkBoxNew.Checked)
                carList.Add(choosedCar)

                ' to edit the existing car detail
            ElseIf choosedCar.Id.ToString.Trim.Length > 0 Then

                ' Update the existing car according on the entered values
                choosedCar.Make = cmbMake.Text
                choosedCar.Model = txtModel.Text
                choosedCar.Year = CInt(nudYear.Value)
                choosedCar.Price = Convert.ToDecimal(txtPrice.Text)
                choosedCar.NewStatus = chkBoxNew.Checked

            End If

        End If
        SetDefaults()
    End Sub

    ''' <summary>
    ''' To close the form 
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Call setdefault procedure 
    ''' To set all the input boxes to its default state
    ''' </summary>

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        SetDefaults()
        lblMessage.Text = String.Empty
    End Sub


    ''' <summary>
    ''' Event handler for the event that a character is selected in the ListView
    ''' </summary>

    Private Sub lvwCarList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarList.SelectedIndexChanged

        If lvwCarList.SelectedIndices.Count = 1 Then
            choosedCar = carList(lvwCarList.SelectedIndices(0))
            isCarSelected = True
            cmbMake.Text = choosedCar.Make
            txtModel.Text = choosedCar.Model
            nudYear.Value = choosedCar.Year
            txtPrice.Text = choosedCar.Price.ToString
            chkBoxNew.Checked = choosedCar.NewStatus

            lblMessage.Text = choosedCar.GetCarData()

        Else
            isCarSelected = False

        End If

    End Sub

    ''' <summary>
    '''This will stop to check or uncheck the list in listview
    ''' </summary>

    Private Sub lvwCarList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarList.ItemCheck


        If Not isAddingToListView Then


            e.NewValue = e.CurrentValue

        End If

    End Sub

#End Region


#Region "Procedures"

    ''' <summary>
    ''' Resets the forms as well as any required class-level variables to their default state
    ''' </summary>
    Private Sub SetDefaults()
        ' to reset all the input textboxes, labels, combobox to its defult state
        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        txtPrice.Text = String.Empty
        chkBoxNew.Checked = False
        nudYear.Value = DefaultYear


        'to populate the list 
        PopulateList()


        isCarSelected = False

        'set focus to the first box to enter model
        txtModel.Focus()

    End Sub

    ''' <summary>
    ''' This will validates that in all the fields the data entered is in appropriate range or accuarate 
    ''' if not display an error message which ahve unrealtable input.
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValidInput() As Boolean
        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty
        Dim price As Decimal = 0.0D

        'to check the entry has been added in the make box
        If cmbMake.SelectedIndex = -1 Then

            ' If not display a error message
            outputMessage += "Please select car's make from the given names." & vbCrLf

            'return value to false
            returnValue = False

        End If

        'to check the year is added right
        If nudYear.Value = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's year or select from the up/down list " & vbCrLf

            'return value to false
            returnValue = False

        End If

        'to check the model is added 
        If txtModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's model." & vbCrLf

            ' return value to false
            returnValue = False
        End If

        'to check the price value is appropriate
        If Not (Decimal.TryParse(txtPrice.Text, price) And price > 0) Then

            ' If number enter is not appropriate display a error message
            outputMessage = "Please enter numeric value and must be greater than 0" & vbCrLf

            'return value to false
            returnValue = False
        End If

        'to check the price value is entered
        If txtPrice.Text.Trim.Length = 0 Then

            ' If not display a error message
            outputMessage += "Please enter the car's price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If returnValue = False Then
            lblMessage.Text = "There is an error in your entered data" & vbCrLf & outputMessage
        End If


        Return returnValue

    End Function

    ''' <summary>
    ''' Clears and re-populates the ListView control
    ''' </summary>

    Sub PopulateList()

        lvwCarList.Items.Clear()

        For index As Integer = 0 To carList.Count - 1

            'to populate the list with the entered data
            Dim carItem As New ListViewItem()

            ' it assigns all the data to its selected field
            carItem.SubItems.Add(carList(index).Id.ToString)
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString)
            carItem.SubItems.Add(carList(index).Price.ToString)
            carItem.Checked = carList(index).NewStatus


            ' Indicates that we are adding cars to the ListView

            isAddingToListView = True

            ' add the new instantiated and populated ListViewItem
            ' to the listview control
            lvwCarList.Items.Add(carItem)

            ' Indicates that we are done adding characters to the ListView
            isAddingToListView = False

        Next


    End Sub
#End Region

End Class
