Option Strict On
'Author: Ryan Clayson
'Date: March 15th 2020
'Description:
'   This form allows you to create a list of car's which are added to an inventory. 
Public Class frmCarInventory

#Region "Variable Declarations"

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False
    Private price As Decimal
#End Region

#Region "Event Handlers"

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Car                      ' declares a Car class
        Dim carItem As ListViewItem         ' declares a ListViewItem class

        'Validates the data in the form
        If IsValidInput() = True Then

            'sets the edit flag to true
            editMode = True

            'Indicate to user that the entry was successful
            lblResult.Text = "Entry Successful!"

            'if the current car identification number has no value
            'the this is not an existing item from the listview
            If currentCarIdentificationNumber.Trim.Length = 0 Then

                'creates a new car object using the parameterized constructor
                car = New Car(cmbMake.Text, txtModel.Text, Convert.ToInt32(cmbYear.Text), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)

                'adds the car to the carList collection
                'uses the identification number as the key which will make the car object easier to 
                'find in the carList collection
                carList.Add(car.IdentificationNumber.ToString(), car)

            Else
                'if the current car identification number has a value, then user has selected an option from the list view
                'so the data in the car object in the carList collection will be updated

                car = CType(carList.Item(currentCarIdentificationNumber), Car)

                'update the data in the specific object from the controls
                car.Make = cmbMake.Text
                car.Model = txtModel.Text
                car.Year = Convert.ToInt32(cmbYear.Text)
                car.Price = Convert.ToDecimal(txtPrice.Text)
                car.IsNew = chkNew.Checked

            End If

            'clear the items from the listview control
            lvwCarInventory.Items.Clear()

            'loop through the carList collection and populate list view
            For Each carEntry As DictionaryEntry In carList

                'instantiates a new ListViewItem
                carItem = New ListViewItem()

                'gets the car from the list
                car = CType(carEntry.Value, Car)

                'assigns the values to the checked control/subitems
                carItem.Checked = car.IsNew
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add(car.Year.ToString)
                carItem.SubItems.Add(car.Price.ToString)

                'add the new instantiated and populated ListViewItem to the listview control
                lvwCarInventory.Items.Add(carItem)


            Next carEntry

            'clear the controls
            Reset()

            'set the edit flag to false
            editMode = False

        End If
    End Sub

    ''' <summary>
    ''' The code in the btnReset_Click EventHandler will clear the form and set
    ''' focus back to the input text box.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' calls the reset sub routine
        Reset()
    End Sub

    ''' <summary>
    ''' Exits the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' This will close the form
        Me.Close()

    End Sub

    Private Sub lvwCarInventory_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCarInventory.ItemCheck

        'if it is not in edit mode
        If editMode = False Then

            'new value to the current value
            'cannot be set in the listview by the user
            e.NewValue = e.CurrentValue
        End If
    End Sub

    Private Sub lvwCarInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCarInventory.SelectedIndexChanged

        'constant that represents the index of the sub item in the list which 
        'holds the car identification number
        Const identificationSubItemIndex As Integer = 1

        'gets the car identification number
        currentCarIdentificationNumber = lvwCarInventory.Items(lvwCarInventory.FocusedItem.Index).SubItems(identificationSubItemIndex).Text

        'use the car identification number to get the car from the collection object
        Dim car As Car = CType(carList.Item(currentCarIdentificationNumber), Car)

        'set the controls on the form
        cmbMake.Text = car.Make
        txtModel.Text = car.Model
        cmbYear.Text = car.Year.ToString()
        txtPrice.Text = car.Price.ToString()
        chkNew.Checked = car.IsNew

        lblResult.Text = car.GetCarData()
    End Sub

#End Region

#Region "Procedures"
    ''' <summary>
    ''' Reset- sets the controls back to their default states
    ''' </summary>
    Private Sub Reset()

        cmbMake.SelectedIndex = -1
        txtModel.Text = String.Empty
        cmbYear.SelectedIndex = -1
        txtPrice.Text = String.Empty
        chkNew.Checked = False

        currentCarIdentificationNumber = String.Empty
    End Sub

#End Region
#Region "Function"

    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty

        'checks to see if Make has been selected
        If cmbMake.SelectedIndex = -1 Then

            'If not set the error message
            outputMessage += "Please select a car make." & vbCrLf

            'Set the return value to false
            returnValue = False

        End If

        'check if a model name has been entered
        If txtModel.Text.Trim.Length = 0 Then

            'If not set the error message
            outputMessage += "Please enter the model name of the car." & vbCrLf

            'Set the return value to false
            returnValue = False
        End If

        'checks to see if a Year has been selected
        If cmbYear.SelectedIndex = -1 Then

            'If not set the error message
            outputMessage += "Please select a Year." & vbCrLf

            'Set the return value to false
            returnValue = False

        End If

        'check if a price has been entered
        If txtPrice.Text.Trim.Length = 0 Then

            'If not set the error message
            outputMessage += "Please enter the price of the car." & vbCrLf

            'Set the return value to false
            returnValue = False
        End If

        'Checks for numeric input
        If Decimal.TryParse(txtPrice.Text, price) = False Then

            'Sets the error message
            outputMessage += "The price must be a decimal number." & vbCrLf
            txtPrice.Focus()
            txtPrice.SelectAll()

            'Set the return value to false
            returnValue = False

        End If

        'Checks for price Range
        If price <= 0.0D Then
            'Sets error message
            outputMessage += "The price must be a positvie number." & vbCrLf
            txtPrice.Focus()
            txtPrice.SelectAll()
        End If

        'End If

        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function
#End Region

End Class
