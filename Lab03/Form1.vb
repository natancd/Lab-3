' **************************************************************************************************************************************************/
' * Lab 3: Average Units Shipped By Employee
' * Program: Lab03                                   
' * Course: NET DEVELOPMENT I (NETD-2202)                                                                 
' * Author:      Natan Colavite Dellagiustina  - 100722419                                    
' * Date:        February 22nd, 2019 
' *                                                                                
' * Description:                                                                    
' *              This program will prompt the user a form where they must insert a unity shipped between 0 and 1000, only whole numbers
' *              and will store it in another text box, where the user can see which units were entered. There will be 3 employees and the user will 
' *              have to enter one unit for every day for every employee. Everytime a number is entered, the label showing the day will update and, 
' *              at the end of all seven days, a label will prompt the user the average of units that were shipped. 
' *              In total there will be 21 input informations: seven units by employee. Every employee will have its own average through theirs seven
' *              days. Also, there will be a final average by day. Then the user will have the  option to reset the program by clicking in the reset 
' *              button or exit, clicking exit button or the "X" in the top right corner. 
' *              If the user enter a non-numeric character or any number that is not an integer and that isn't in the range of 0 to 1000, the bottom 
' *              label will prompt an error message and move the focus back to the wrong value entered and select it, making it possible just to retype
' *              the correct information. At any time, the user can reset the form by clicking the reset button or pressing "Esc". By doing that, the 
' *              program will reset to its default form, starting from Day 1. All averages will be displayed in two decimal places.

' **************************************************************************************************************************************************/

Option Strict On
Public Class frmAverageUnitsShippedByEmployee
    ' DECLARATIONS
    ' CONSTANTS
    Const MININUM_INPUT = 0
    Const MAXIMUM_INPUT = 1000
    Const MAXIMUM_DAYS As Integer = 7
    Const ARRAY_LAST_ROW As Integer = 2 ' The last row of the array
    Const NUMBER_OF_EMPLOYEES As Integer = 3 ' Number of employees, for average calculation purpose

    ' VARIABLES
    Dim userInput As String ' The user input number
    Dim userNumber As Integer ' The user input after validation
    Dim userUnits(ARRAY_LAST_ROW, MAXIMUM_DAYS - 1) As Integer ' Array with all user inputs. Same as array(2,6), in this program
    Dim currentRow As Integer = 0 ' The first row of the array
    Dim currentColumn As Integer ' The actual column of where the array is
    Dim dayCounter As Integer = 1 ' Counter of the day
    Dim unitsAverageByDay As Double = 0.0 ' The final average
    Dim averageOne As Double = 0.0 ' Average for employee one
    Dim averageTwo As Double = 0.0 ' Average for the employee two
    Dim averageThree As Double = 0.0 ' Average fot the employee three

    Private Sub lblEmployeeOne_Click(sender As Object, e As EventArgs) Handles lblEmployeeOne.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the program
        Me.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' This button will reset everything to the default value
        txtUserInput.ResetText()
        txtUserInput.ReadOnly = False
        txtUserInput.Focus()

        lblAverageOne.Text = ""
        lblAverageTwo.Text = ""
        lblAverageThree.Text = ""
        lblDayAverage.Text = ""
        lblDays.Text = "Day 1"

        txtEmployeeOne.ResetText()
        txtEmployeeTwo.ResetText()
        txtEmployeeThree.ResetText()

        btnEnter.Enabled = True
        ReDim userUnits(ARRAY_LAST_ROW, MAXIMUM_DAYS - 1)

        dayCounter = 1

        currentColumn = 0
        currentRow = 0

        averageOne = 0.0
        averageTwo = 0.0
        averageThree = 0.0
        unitsAverageByDay = 0.0

    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        userInput = txtUserInput.Text ' Whatever the user type in the text box will be verified below

        ' Validate using the function. If the entered information is not valid (defined in the function), it will prompt the user 
        ' an error message and move the focus back to the textbox
        If ValidationNumber(userInput, userNumber) = False Then
            MessageBox.Show("Please ensure the units shipped are between " & MININUM_INPUT & " and " & MAXIMUM_INPUT & "!")
            txtUserInput.SelectAll()
            txtUserInput.Focus()
        Else
            ' In case the entered information is valid, the program will store the output defined in the If statement above in the array
            userUnits(currentRow, currentColumn) = userNumber
            ' This If statement will check which table is the array in
            If currentRow = 0 Then ' Employee one
                txtEmployeeOne.Text += userUnits(currentRow, currentColumn) & vbCrLf
            ElseIf currentRow = 1 Then ' Employee Two
                txtEmployeeTwo.Text += userUnits(currentRow, currentColumn) & vbCrLf
            ElseIf currentRow = 2 Then ' Employee Three
                txtEmployeeThree.Text += userUnits(currentRow, currentColumn) & vbCrLf

            End If
            ' After checking which row is being used, the program will check in which day it is. There is up to 7 seven days, defined in the constants
            If (dayCounter < MAXIMUM_DAYS) Then
                ' For every day, the counter will add one more day to it and display the new day in the "Day label"
                dayCounter += 1
                lblDays.Text = "Day " + dayCounter.ToString()
                ' Clear the text box and move the focus to it after every day is changed, so the user do not have to click on it
                txtUserInput.Clear()
                txtUserInput.Focus()

            End If
            ' When the counter for the days reaches 7 days, it will change the column for the following one
            currentColumn += 1
            ' While the program is in the first row (zero, actually) and until the 6th column (the last column defined), it will calculate the average
            If currentRow = 0 And currentColumn > (MAXIMUM_DAYS - 1) Then
                For averageCounter As Integer = 0 To (MAXIMUM_DAYS - 1) ' (0,0), (0,1), (0,2)... (0,6)
                    averageOne += userUnits(currentRow, averageCounter) ' This code will add all valid values entered in the array (0,0) to (0,6)
                Next
                averageOne = averageOne / (MAXIMUM_DAYS) ' Math formula to calculate the average for array (0,0) to (0,6)
                lblAverageOne.Text = "Average: " & FormatNumber(averageOne, 2) ' Display the calculated average the label below the first employee units with 2 decimal places
                ' This will remove the Bold font style from the first employee and make the second one Bold
                lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Regular)
                lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Bold)
                ' After ending this "If", it will loop back to the first "If" and move to the next Row

            End If
            ' While the program is in the second row (one, actually) and until the 6th column (the last column defined), it will calculate the average
            If currentRow = 1 And currentColumn > (MAXIMUM_DAYS - 1) Then
                For averageCounter As Integer = 0 To (MAXIMUM_DAYS - 1) ' (1,0), (1,1), (1,2)... (1,6)
                    averageTwo += userUnits(currentRow, averageCounter) ' This code will add all valid values entered in the array (1,0) to (1,6)
                Next
                averageTwo = averageTwo / (MAXIMUM_DAYS) ' Math formula to calculate the average for array (1,0) to (1,6)
                lblAverageTwo.Text = "Average: " & FormatNumber(averageTwo, 2) ' Display the calculated average the label below the second employee units with 2 decimal places
                ' This will remove the Bold font style from the second employee and make the third one Bold
                lblEmployeeTwo.Font = New Font(lblEmployeeTwo.Font, FontStyle.Regular)
                lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Bold)
                ' After ending this "If", it will loop back to the first "If" and move to the next Row

            End If
            ' While the program is in the third row (two, actually) and until the 6th column (the last column defined), it will calculate the average
            If currentRow = 2 And currentColumn > (MAXIMUM_DAYS - 1) Then
                For averageCounter As Integer = 0 To (MAXIMUM_DAYS - 1) ' (2,0), (2,1), (2,2)... (2,6)
                    averageThree += userUnits(currentRow, averageCounter) ' This code will add all valid values entered in the array (2,0) to (2,6)
                Next
                averageThree = averageThree / (MAXIMUM_DAYS) ' Math formula to calculate the average for array (2,0) to (2,6)
                lblAverageThree.Text = "Average: " & FormatNumber(averageThree, 2) ' Display the calculated average the label below the third employee units with 2 decimal places

                ' Since this was the last employee in this program, the program will calculate the average by day for all employees
                ' I could have added another formula, storing all units entered one by one In a variable I would Call "sumOfAll", 
                ' then divide it by 21 (NUMBER_OF_EMPLOYEES * MAXIMUM_DAYS)
                unitsAverageByDay = (averageOne + averageTwo + averageThree) / NUMBER_OF_EMPLOYEES
                lblDayAverage.Text = "Average per day: " & FormatNumber(unitsAverageByDay, 2)  ' Display the final average in the label below all others average labels with 2 decimal places
                lblDays.Text = "Done" ' Change the "Day label" to a final message
                ' This will remove the Bold font style from the third employee and make the first one Bold again
                lblEmployeeOne.Font = New Font(lblEmployeeOne.Font, FontStyle.Bold)
                lblEmployeeThree.Font = New Font(lblEmployeeThree.Font, FontStyle.Regular)

            End If

        End If
        ' This loop, whenever the column reaches 7 (maximum defined is 6), will move to the next row and resets the column back to zero, for example:
        ' (0,6) is the final column... it will move to row 1 and column 0 = (1,0) until (1,6), then will do the same to (2,0), until (2,6), which will be
        ' explained after this If ends
        If currentColumn = MAXIMUM_DAYS Then

            currentRow += 1

            currentColumn = 0

        End If
        ' When it reaches (2,6), the previous loop will try to go to (3,0), but the array was defined to (2,6), so if the row is about to be higher than 2, it will
        ' stop the program as it follows:
        If currentRow > ARRAY_LAST_ROW Then
            btnEnter.Enabled = False ' Turn off the button Enter (or disable it)
            txtUserInput.ReadOnly = True ' Make the text box as read only, so the user cannot enter any more information

        End If
        ' If the dayCounter reaches 7 or more, it will resets the counter to 0, so the next "If" for the counter can start again
        ' If I defined it as dayCounter = 1, I'd have to redefine the label days to "Day " and call the dayCounter again and would conflit with the "dayCounter =+ 1" formula
        If dayCounter >= MAXIMUM_DAYS Then dayCounter = 0

    End Sub

    'This if the function to validate the number into a whole number
    Private Function ValidationNumber(ByVal inputNumber As String, ByRef userÌnputValidated As Integer) As Boolean

        'Function declarations
        Dim userValidNumber As Integer
        Dim returnValue As Boolean = True
        ' Loops in the to check if the number it is in the minimun and maximum range
        If (Integer.TryParse(inputNumber, userValidNumber)) Then
            If userValidNumber >= MININUM_INPUT AndAlso userValidNumber <= MAXIMUM_INPUT Then
                ' If it is a whole number and is between the range, it will store in the function as a variable
                userÌnputValidated = userValidNumber
                returnValue = True ' In case the stored variable is a valid one, the function will have the boolean true

            Else
                ' In case not (not in the range of not a whole number), it will return the boolean false
                returnValue = False
            End If
        Else
            returnValue = False

        End If

        Return returnValue ' This is the returned value of this function (whether true or false)

    End Function
End Class
