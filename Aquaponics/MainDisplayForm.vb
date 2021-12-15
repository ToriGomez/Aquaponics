'Tori Gomez

'11/16/21

'Aquaponics Project - Team Manager: Shane Slack, Team Lead: Justine Hoffa, Team Coder: Tori Gomez


'   The Aquaponics Program is designed to be a user control and display of the states of the Aquaponics Project. The Program
'interfaces with the master PIC, PIC16F887, and receives and sends information back and forth.


'   The main tab is the display of the sensors and devices associated with the whole project. The analog signals being transmitted
'from the PIC have textboxs allong with a state button (all devices have a state button associated). Each of the analog signals
'have three state ranges which will be on the Stack light wich is the state button. The Different states are Green light, Yellow
'light, and Red light with an alarm. Thus the analog has three ranges, and digital has either green/good or red/bad. The ranges of 
'the analog can be changed to desired values in the troubleshooting tab which allows the user to select the correct analog device.
'The default ranges will appear in the designated textboxes and when valid information is inserted, the ranges will be saved. 


'   Also in the main tab the only input the user can change is the time to feed the fish. The time is taken in military format the 
'default time of feed time is at 1pm everyday. If the time is changed by the user and not in military format, the save time button
'will not appear which would not save the time. The amount of times the fish are fed can be controled by saving a new time value, 
'and or by selecting the checkbox to feed the fish again. The state button will accumulate and display the amount of times the 
'fish had been feed that day. The fish feed refreshes at 1am every day, 12hrs from the default time. The controls section has the 
'fish feeder which idicates that the feed signal to the PIC was sent, it may not be on for the same duration of time, but indicates 
'that the signal was sent.


'   In the troubleshooting tab, along with the analog range controls, it has the test control section. The Buttons control and send
'a signal to the PIC which will manually turn on that control for a duration of time. The output states on the right of the controls
'indicate to the user that the pressed control device is on or off. The way that this is done is by the Digital signals being transmitted
'to the program. The digital signals are going to the main tab to the digital signals and the unimplemented bits in the bytes transmitted
'are associated to the output states. All of the digital signals association are labeled for the user so that they can also be
'troubleshooted if need be.


'   If the state of the PIC is different than the actual, the program will send back data to state that the state should be something else.
'For example, if the pic states that the data is all in the green state indicating that there is no bad data, the program will analyze all
'the data to verify the PIC and if the data is incorrect and the state should be yellow or red, then the program will alert the PIC and
'send data back stating that the data is good.

Option Strict On
Option Explicit On
Imports System.IO.Ports
Imports System.Math
Imports System.Threading.Thread


Public Class MainDisplayForm
    Public serialPortNameString As String = "COM4"                                          'Global Dimension for the serial port connected.
    Public serialPortBaudRateInteger As Integer = 57600                                     'Global Dimension for the baud rate of the serial comm.
    Public serialPortDataBitsInteger As Integer = 8                                         'Global Dimension for the number of data bits for serical comm.
    Public receiveByte(21) As Byte                                                          'Global Dimension for the received data from serial comm.
    Public sendByte(5) As Byte                                                              'Global Dimension for the transmitting data to serial comm.
    Public analogRecHInteger As Integer                                                     'Global Dimension for the analog received data high byte from serial comm.
    Public analogRecLInteger As Integer                                                     'Global Dimension for the analog received data low byte from serial comm.
    Public analogRecInteger As Integer                                                      'Global Dimension for the analog received number value from the serial comm.
    Public colorStateColor As Color                                                         'Global Dimension for the analog state color from the state range. Colors are Green, Yellow, or Red.
    Public timeOfDayString As String                                                        'Global Dimension for the military time format of the actual time of the day.
    Public motionBoolean As Boolean = False                                                 'Global Dimension for the motion to have logic with the lighting on the project.
    Public lightBoolean(10) As Boolean                                                      'Global Dimension for the states of the outside, growlights states for the logic with motion.
    Public yellowHighSingle As Single                                                       'Global Dimension for the yellow range high value for the analog signals.
    Public yellowLowSingle As Single                                                        'Global Dimension for the yellow range low value for the analog signals.
    Public redHighSingle As Single                                                          'Global Dimension for the red range high value for the analog signals.
    Public redLowSingle As Single                                                           'Global Dimension for the red range low value for the analog signals.
    Public rangeSaveSingle(31) As Single                                                    'Global Dimension for the all the ranges for each of the analog signals.
    Public rangeSaveBoolean As Boolean                                                      'Global Dimension for the state if the range needs to be over written to a new value.
    Public fishFoodTimeBoolean As Boolean                                                   'Global Dimension for the VALID time for the fish to be fed, determines if the Fish will be fed.
    Public fishFedTimesInteger As Integer = 0                                               'Global Dimension for the amount of times the fish have been fed in that day.




    'Sub for when the Form is Closed, Properly disconnects the serial port so that no signals will be accidentaly sent to the
    'PIC and Turns off the Timers which stops the program outputs.
    Private Sub MainDisplayForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SerialPort1.Close()                                                                 'Shut off port when form closed.
        Timer1.Enabled = False                                                              'Shut off timer 1.
        Timer2.Enabled = False                                                              'Shut off timer 2.
        Timer3.Enabled = False                                                              'Shut off timer 3.
        Timer4.Enabled = False                                                              'Shut off timer 4.
    End Sub




    'Sub for when the form is loaded, Opens and sets up the port for serial communication. Sets the Communication state
    'to Yellow until the serial port is done. Sets the size of the form and centers the from to the screen of the program.
    'Sets up the analog range section in the troubleshooting tab. Hides the saving data label and disables the timer 2 which
    'controls how long the saving data label is seen for. Sets up the Fish food section to have the default time and 
    'view of the state button with the fish not being fed yet that day. The Fish Food time is set at military time equivalent
    'of 1pm which is 13:00:00. Finally the Timer 1 is enabled to start analzing the data coming into the program.
    Private Sub MainDisplayForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SerialPort1.PortName = serialPortNameString                                         'Serial port that the program is connected to.
        SerialPort1.BaudRate = serialPortBaudRateInteger                                    'Baudrate the program is set to of bits/sec.
        SerialPort1.DataBits = serialPortDataBitsInteger                                    'Number of Data bits the program is set to of the QBoard.
        SerialPort1.StopBits = IO.Ports.StopBits.One                                        '1 Stop bit of the QBoard.
        SerialPort1.Parity = IO.Ports.Parity.None                                           'No parity bits of the QBoard.
        SerialPort1.Open()                                                                  'Initializes the QBoard and Opens Serial Communication.



        CommButton.BackColor = Color.Yellow                                                 'Indicates that the Communication is Booting up which is yellow state.
        CommButton.Text = "OK"                                                              '/



        Me.Height = 600                                                                     'Sets the default size of the form.
        Me.Width = 750                                                                      '/
        CenterToScreen()                                                                    'Centers the form to look nice.



        DefaultRangeComboBox()                                                              'Adds the analog devices and sets the default ranges.
        SaveLabel.Visible = False                                                           'Hides the saving values label, to only show when save button is pressed.
        SaveRangeButton.Visible = False                                                     'Hides the saverange button so that blank ranges cannot be saved by accident.
        Timer2.Enabled = False                                                              'Disables the Timers 2, 3, and 4 so that they only tick when in need of operation.
        Timer3.Enabled = False                                                              '-/
        Timer4.Enabled = False                                                              '/



        FoodTimeTextBox.Text = "13:00:00"                                                   'Sets the default fish feed time of 1pm.
        fishFoodTimeBoolean = True                                                          'Sets the Time boolean so that if the text box of fish feed time is not changed, it will feed the fish.
        FishFoodAlertLabel.Visible = False                                                  'Hides the INVALID military time label.
        SaveTimeButton.Visible = False                                                      'Hides the Save time button when if the text box of fish feed time is not changed.
        FeedAgainCheckBox.Visible = False                                                   'Hides the feed again checkbox until the fish have been fed.



        Timer1.Enabled = True                                                               'Enables the program to start recieving the data.
    End Sub




    'Sub for when the Timer 1 interval has been received. The default interval is set to every 100 miliseconds. The Header byte sent 
    'from the PIC is set to a variable to be analyzed. Based on the header, it will call the associated state subroutine. The byte value
    '0x11 indicates that the devices are all in the green state range. A 0x21 indicates that the analog devices have fallen out of the 
    'green state and are in the yellow range. Digital devices are never in this state. A 0x31 indicates that one at least of all the values
    'has either passed the yellow range and in the danger zone, or the digital device went from green to red state. The subroutines will check 
    'the range values and the actual state and verify if the device is actually in that state.
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim receivedHeaderInteger As Integer                                                'Dimension for the numberical value of the header byte sent from the PIC.



        Timer1.Enabled = False                                                              'Disables the timer1 for when a timer tick has occured.
        receivedHeaderInteger = receiveByte(0)                                              'Sets the first byte of PIC information to the header value.


        Select Case receivedHeaderInteger                                                   'Select case to analyzed all the possible state headers.
            Case = CInt(&H11)                                                               'Header value for when the PIC is in the green state.
                GreenAlert()                                                                'Calls the Green alert sub to display/update the values of all devices.
            Case = CInt(&H21)                                                               'Header value for when the PIC is in the yellow state.
                YellowAlert()                                                               'Calls the Yellow alert sub to anaylze/display which of the analog devices have passed the yellow range.
            Case = CInt(&H31)                                                               'Header value from when the PIC is in the red state.
                RedAlert()                                                                  'Calls the Red alert sub to analyze/display which of the devices have passed the red range or in digital bad state.
        End Select
        GreenAlert()                                                                        'Continues to analyze all the data being received.
        Timer1.Enabled = True                                                               'Re-Enables the Timer1 to continue analyzing.
    End Sub




    'Sub for when the Timer 2 is enabled. Used to wait for 5 minutues after the Motion Occured. This is so that the Lights of the growlight
    'and the display are not going on and off repeadly and for the lights to remain on for a while then shut off at night.
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        sendByte(0) = &H97                                                                  'motion time end to enable on the grow lights.
        PortWrite()                                                                         '/



        If lightBoolean(0) = True Then                                                      'Displays to the user the state of the Fish/Display lights based
            FishDisplayLightButton.BackColor = Color.Gray                                   'on the current outside light and start and end active time.
            FishDisplayLightButton.Text = "OFF"                                             '------/
        ElseIf lightBoolean(0) = False And lightBoolean(2) = True Then                      '-----/                                                    
            FishDisplayLightButton.BackColor = Color.Green                                  '----/
            FishDisplayLightButton.Text = "ON"                                              '---/
        ElseIf lightBoolean(0) = False And lightBoolean(2) = False Then                     '--/
            FishDisplayLightButton.BackColor = Color.Gray                                   '-/
            FishDisplayLightButton.Text = "OFF"                                             '/
        End If



        If lightBoolean(1) = True Then                                                      'Displays to the user the state of the Grow lights based
            GrowLightButton.BackColor = Color.Gray                                          'on the current outside light and start and end active time.
            GrowLightButton.Text = "OFF"                                                    '------/
        ElseIf lightBoolean(1) = False And lightBoolean(2) = True Then                      '-----/
            GrowLightButton.BackColor = Color.Green                                         '----/
            GrowLightButton.Text = "ON"                                                     '---/
        ElseIf lightBoolean(1) = False And lightBoolean(2) = False Then                     '--/
            FishDisplayLightButton.BackColor = Color.Gray                                   '-/
            FishDisplayLightButton.Text = "OFF"                                             '/
        End If
        Timer2.Enabled = False                                                              'Disables the timer until the next time motion occurs.
    End Sub




    'Sub for intervals of 7 seconds. Used for the user to have the control hold for 7 seconds then turn back off again. 
    'Controls used are the Fish Feeder control so that it will be "ON" for five seconds the control will return to default of being
    'off. The second is the save label for the save ranges section. Turns off the label so that the user knows that it was saved to the program.
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If FishFeederMainButton.BackColor = Color.Green Then                                'If the fish feed state is on, turn off the control.
            FishFeederMainButton.BackColor = Color.Gray                                     '--/
            FishFeederMainButton.Text = "OFF"                                               '-/
            Timer3.Enabled = False                                                          '/
        End If



        If SaveLabel.Visible = True Then                                                    'If the save label is visible, turn off visibity.
            SaveLabel.Visible = False                                                       '-/
            Timer3.Enabled = False                                                          '/
        End If
    End Sub




    'Sub for when one of the maunal controls was pressed. Triggers after three seconds, turns off the designated control.
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Select Case sendByte(0)
            Case &HD1
                Pump1OutputButton.BackColor = Color.Gray                                    'Turns off the test controls so that the user knows
                Pump1OutputButton.Text = "OFF"                                              'that the pump 1 was on for 3 seconds
                Timer4.Enabled = False                                                      'Disables Timer 4.



            Case &HD3
                Pump2OutputButton.BackColor = Color.Gray                                    'Turns off the test controls so that the user knows
                Pump2OutputButton.Text = "OFF"                                              'that the pump 2 was on for 3 seconds
                Timer4.Enabled = False                                                      'Disables Timer 4.



            Case &HD5
                Pump3OutputButton.BackColor = Color.Gray                                    'Turns off the test controls so that the user knows
                Pump3OutputButton.Text = "OFF"                                              'that the pump 3 was on for 3 seconds
                Timer4.Enabled = False                                                      'Disables Timer 4.



            Case &HD7
                FishHeaterOutputButton.BackColor = Color.Gray                               'Turns off the test controls so that the user knows
                FishHeaterOutputButton.Text = "OFF"                                         'that the Fish Heater was on for 3 seconds
                Timer4.Enabled = False                                                      'Disables Timer 4.



            Case &HD9
                ResHeaterOutputButton.BackColor = Color.Gray                                'Turns off the test controls so that the user knows
                ResHeaterOutputButton.Text = "OFF"                                          'that the Reservoir Heater was on for 3 seconds
                Timer4.Enabled = False                                                      'Disables Timer 4.
        End Select
    End Sub




    'Sub for when the serial port has received serial communication. Reads the information and sets it to the receive byte array so that
    'the information can be analyzed. Sets the Comm button to a good state so that the user knows that communictation from the program to
    'and from the PIC is being received.
    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        SerialPort1.Read(receiveByte, 0, 21)                                                'Reads the serial communication and sets it to the receive byte array to store data.
        CheckForIllegalCrossThreadCalls = False                                             'Stops from catch calls on the wrong thread.
        CommButton.BackColor = Color.Green                                                  'Displays to the user that communication of the program is good.
        CommButton.Text = "GOOD"                                                            '/
    End Sub




    'Sub for when the default fish feed time is changed by the user. Tests to see if the update is a VALID military time to feed the fish.
    'If the time has no errors, then the alert label for the user disappears then the save time button will become visible to the user.
    Private Sub FoodTimeTextBox_TextChanged(sender As Object, e As EventArgs) Handles FoodTimeTextBox.TextChanged
        Dim foodTimeDate As Date                                                            'Dimension for the Test to see if the input is not letters, invalid date values.
        Dim foodTimeString As String                                                        'Dimension to test the format of the inserted time. 
        fishFoodTimeBoolean = False                                                         'Disables for the time to be sent to the PIC until its verified to be a good number.
        'Try function to test if the food date was manipulated. 
        'EXAMPLE If time is 12:0:00 the date function will compile the date to be 12:00:00, testing the string of the text to the 
        'date, this will test if this was done which will pop up as an error.
        Try                                                                                 'Try function to test the possible inputs of the user, to catch all errors.
            foodTimeDate = CDate(FoodTimeTextBox.Text)                                      'Tests if the input is a VALID date time. If not goes to catch.
            foodTimeString = FoodTimeTextBox.Text                                           'Sets the inserted date time to a string to be tested.
            If foodTimeString <> CStr(foodTimeDate.ToString("HH:mm:ss")) Then               'Tests to see if the inserted date time matches the date complied. That all digits are present.
                SaveTimeButton.Visible = False                                              'The date function complied the fixed version of the date with not enough digits. Alerts user of INVALID time.
                FishFoodAlertLabel.Visible = True                                           '/
            Else                                                                            'The inserted date time matches the date complied, enables the user to save the time to feed fish.
                FishFoodAlertLabel.Visible = False                                          'Hides the alert label if it was present previously.
                SaveTimeButton.Visible = True                                               'Enables user to save the time inserted.
                SaveTimeButton.Select()                                                     '/
            End If
        Catch ex As Exception                                                               'Catch if the inserted time is INVALID due to wrong time inserted. EXAMPLE letters, symbols inappropriate to military time.
            SaveTimeButton.Visible = False                                                  'Hides the visiblity of the save button if was present previously, and alerts user of INVALID time.
            FishFoodAlertLabel.Visible = True                                               '/
        End Try
    End Sub




    'Sub for when the Save time button for the Fish Feed section in the main tab is pressed. Sets the fish boolean so that when that time 
    'entered occurs, the fish will be fed. Delay of 500 miliseconds so that after it is pressed, it will hold for that cetain amount of 
    'time then the visiblity of the save time button will disappear. This is so that the user knows that the time inserted was saved to 
    'the program.
    Private Sub SaveTimeButton_Click(sender As Object, e As EventArgs) Handles SaveTimeButton.Click
        fishFoodTimeBoolean = True                                                          'Enables for when the time of day is the set inserted time, it will feed the fish.
        Sleep(500)                                                                          'Delay to have good visiblity of the save button after it was pressed.
        SaveTimeButton.Visible = False                                                      'Hides view of the save button so that the user knows that the time was saved.
    End Sub




    'Sub for when the save range button on the troubleshooting tab is selected. The range save boolean controls on whether the 
    'inputs inserted by the user is saved to the program or not. By enabling this the ranges will be saved, Then by calling
    'the display ranges, the range just set will be displayed for the user. The save label indicates to the user that the range
    'is being saved and the timer 3 will hold that visibility for 5 seconds.
    Private Sub SaveRangeButton_Click(sender As Object, e As EventArgs) Handles SaveRangeButton.Click
        rangeSaveBoolean = True                                                             'Sets the Save range boolean so that the range will be saved.
        DisplayRanges()                                                                     'Displays the range that is inserted.
        SaveLabel.Visible = True                                                            'Displays to the user that the range is being saved.
        Timer3.Enabled = True                                                               'Timer that will hold the label indicating that the range is saved then hides visibity.
    End Sub




    'Sub for when the index of the analog range combobox is changed, The selected analog range will show whats currently saved to that device.
    'If the user has not changed the range, then the default range will be displayed.
    Private Sub AnalogRangeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AnalogRangeComboBox.SelectedIndexChanged
        Select Case AnalogRangeComboBox.Text                                                'Select Case to analyze which range was selected.
            Case "Fish Tank Temperature"                                                    'For when the Fish Tank Temperature range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(8))                          '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(9))                          '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(10))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(11))                            '--/
                Catch ex As Exception                                                       '-/
                    FishTankTemp("", "", "", "")                                            '/
                End Try


            Case "Reservoir Temperature"                                                    'For when the Reservoir Temperature range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(12))                         '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(13))                         '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(14))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(15))                            '--/
                Catch ex As Exception                                                       '-/
                    ReservoirTemp("", "", "", "")                                           '/
                End Try



            Case "Plant Bed PH"                                                             'For when the Plant Bed PH range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(28))                         '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(29))                         '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(30))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(31))                            '--/
                Catch ex As Exception                                                       '-/
                    PlantBedPH("", "", "", "")                                              '/
                End Try



            Case "Fish Tank PH"                                                             'For when the Fish Tank PH range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(24))                         '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(25))                         '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(26))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(27))                            '--/
                Catch ex As Exception                                                       '-/
                    FishTankPH("", "", "", "")                                              '/
                End Try



            Case "Disposable Solids"                                                        'For when the Fish Tank PH range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(20))                         '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(21))                         '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(22))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(23))                            '--/
                Catch ex As Exception                                                       '-/
                    DisposableSolids("", "", "", "")                                        '/
                End Try



            Case "Conductivity"                                                             'For when the Conductivity range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(16))                         '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(17))                         '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(18))                            '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(19))                            '--/
                Catch ex As Exception                                                       '-/
                    Conductivity("", "", "", "")                                            '/
                End Try



            Case "Analog Extra 1"                                                           'For when the Analog Extra 1 range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(0))                          '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(1))                          '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(2))                             '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(3))                             '--/
                Catch ex As Exception                                                       '-/
                    AnalogExtra1("", "", "", "")                                            '/
                End Try



            Case "Analog Extra 2"                                                           'For when the Analog Extra 2 range is selected.
                Try                                                                         'If the range is not changed yet, Displays the default range or the last saved range.
                    YellowHTextBox.Text = CStr(rangeSaveSingle(4))                          '-----/
                    YellowLTextBox.Text = CStr(rangeSaveSingle(5))                          '----/
                    RedHTextBox.Text = CStr(rangeSaveSingle(6))                             '---/
                    RedLTextBox.Text = CStr(rangeSaveSingle(7))                             '--/
                Catch ex As Exception                                                       '-/
                    AnalogExtra2("", "", "", "")                                            '/
                End Try
        End Select
    End Sub




    'Sub for when the text in the Analog Range Combobox is changed. The user cannot type in the analog device, the drop 
    'down needs to be done to change the analog range device.
    Private Sub AnalogRangeComboBox_TextChanged(sender As Object, e As EventArgs) Handles AnalogRangeComboBox.TextChanged
        If AnalogRangeComboBox.Text <> "Fish Tank Temperature" Then                         'Clears any text inserted if typed by user.
            AnalogRangeComboBox.Text = ""                                                   '--------------/



        ElseIf AnalogRangeComboBox.Text <> "Reservoir Temperature" Then                     '-------------/
            AnalogRangeComboBox.Text = ""                                                   '------------/



        ElseIf AnalogRangeComboBox.Text <> "Plant Bed PH" Then                              '-----------/
            AnalogRangeComboBox.Text = ""                                                   '----------/



        ElseIf AnalogRangeComboBox.Text <> "Fish Tank PH" Then                              '---------/
            AnalogRangeComboBox.Text = ""                                                   '--------/



        ElseIf AnalogRangeComboBox.Text <> "Disposable Solids" Then                         '-------/
            AnalogRangeComboBox.Text = ""                                                   '------/



        ElseIf AnalogRangeComboBox.Text <> "Conductivity" Then                              '-----/
            AnalogRangeComboBox.Text = ""                                                   '----/



        ElseIf AnalogRangeComboBox.Text <> "Analog Extra 1" Then                            '---/
            AnalogRangeComboBox.Text = ""                                                   '--/



        ElseIf AnalogRangeComboBox.Text <> "Analog Extra 2" Then                            '-/
            AnalogRangeComboBox.Text = ""                                                   '/
        End If
    End Sub




    'Sub for when the Pump 1 button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Pump1.
    Private Sub Pump1Button_Click(sender As Object, e As EventArgs) Handles Pump1Button.Click
        sendByte(0) = &HD1                                                                  'Transmit to PIC to turn on Pump1.
        PortWrite()                                                                         '/
        Pump1OutputButton.BackColor = Color.Green                                           'Turns on the test controls so that the user knows
        Pump1OutputButton.Text = "ON"                                                       'that the pump 1 is on for 3 seconds
        Timer4.Enabled = True                                                               'Enables Timer 4 to display for 5 seconds
    End Sub




    'Sub for when the Pump 2 button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Pump2.
    Private Sub Pump2Button_Click(sender As Object, e As EventArgs) Handles Pump2Button.Click
        sendByte(0) = &HD3                                                                  'Transmit to PIC to turn on Pump2.
        PortWrite()                                                                         '/
        Pump2OutputButton.BackColor = Color.Green                                           'Turns on the test controls so that the user knows
        Pump2OutputButton.Text = "ON"                                                       'that the pump 2 is on for 3 seconds
        Timer4.Enabled = True                                                               'Enables Timer 4 to display for 5 seconds
    End Sub




    'Sub for when the Pump 3 button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Pump3.
    Private Sub Pump3Button_Click(sender As Object, e As EventArgs) Handles Pump3Button.Click
        sendByte(0) = &HD5                                                                  'Transmit to PIC to turn on Pump3.
        PortWrite()                                                                         '/
        Pump3OutputButton.BackColor = Color.Green                                           'Turns on the test controls so that the user knows
        Pump3OutputButton.Text = "ON"                                                       'that the pump 3 is on for 3 seconds
        Timer4.Enabled = True                                                               'Enables Timer 4 to display for 5 seconds
    End Sub




    'Sub for when the Fish Heater button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Fish Tank Heater.
    Private Sub FishHeaterButton_Click(sender As Object, e As EventArgs) Handles FishHeaterButton.Click
        sendByte(0) = &HD7                                                                  'Transmit to PIC to turn on Fish Tank Heater.
        PortWrite()                                                                         '/
        FishHeaterOutputButton.BackColor = Color.Green                                      'Turns on the test controls so that the user knows
        FishHeaterOutputButton.Text = "ON"                                                  'that the Fish Feeder is ON 
        Timer4.Enabled = True                                                               'Enables Timer 4 to display for 3 seconds
    End Sub




    'Sub for when the Res Heater button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Reservoir Heater.
    Private Sub ResHeaterButton_Click(sender As Object, e As EventArgs) Handles ResHeaterButton.Click
        sendByte(0) = &HD9                                                                  'Transmit to PIC to turn on Reservoir Heater.
        PortWrite()                                                                         '/
        ResHeaterOutputButton.BackColor = Color.Green                                      'Turns on the test controls so that the user knows
        ResHeaterOutputButton.Text = "ON"                                                  'that the reservoir Heater is ON 
        Timer4.Enabled = True                                                               'Enables Timer 4 to display for 3 seconds
    End Sub




    'Sub for when the Fish Feeder button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Fish Feeder.
    Private Sub FishFeederButton_Click(sender As Object, e As EventArgs) Handles FishFeederButton.Click
        sendByte(0) = &HFF                                                                  'Transmit to PIC to turn on Fish Feeder.
        PortWrite()                                                                         '/
        FishFeederOutputButton.BackColor = Color.Green                                      'Turns on the test controls so that the user knows
        FishFeederOutputButton.Text = "ON"                                                  'that the Fish Feeder is ON 
        Timer3.Enabled = True                                                               'Enables Timer 4 to display for 7 seconds
    End Sub




    'Sub for when the Grow Light button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Grow Light.
    Private Sub GrowLightControlButton_Click(sender As Object, e As EventArgs) Handles GrowLightControlButton.Click
        sendByte(0) = &HDD                                                                  'Transmit to PIC to turn on Grow Light.
        PortWrite()                                                                         '/
    End Sub




    'Sub for when the Fish Light button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Fish Light.
    Private Sub FishLightButton_Click(sender As Object, e As EventArgs) Handles FishLightButton.Click
        sendByte(0) = &HDF                                                                  'Transmit to PIC to turn on Fish Light.
        PortWrite()                                                                         '/
    End Sub




    'Sub for when the Stack Light Green button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Stack Light Green Light.
    Private Sub StackLightGButton_Click(sender As Object, e As EventArgs) Handles StackLightGButton.Click
        sendByte(0) = &HD2                                                                  'Transmit to PIC to turn on Stack Light Green Light.
        PortWrite()                                                                         '/
    End Sub




    'Sub for when the Stack Light Yellow button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Stack Light Yellow Light.
    Private Sub StackLightYButton_Click(sender As Object, e As EventArgs) Handles StackLightYButton.Click
        sendByte(0) = &HD4                                                                  'Transmit to PIC to turn on Stack Light Yellow Light.
        PortWrite()                                                                         '/
    End Sub




    'Sub for when the Stack Light Red button is pressed on the troubleshooting tab, transmitts to the PIC to manually turn on the Stack Light Red Light.
    Private Sub StackLightRButton_Click(sender As Object, e As EventArgs) Handles StackLightRButton.Click
        sendByte(0) = &HD6                                                                  'Transmit to PIC to turn on Stack Light Red Light.
        PortWrite()                                                                         '/
    End Sub




    'Sub for when the program is transmitting data, tests if the serial communication has become bad, and will keep testing the port until it is fixed.
    Sub PortWrite()
        Try                                                                                 'Try/Catch statement to test if communication has become bad.
            SerialPort1.Write(sendByte, 0, 2)                                               '------------/
        Catch ex As Exception                                                               '-----------/
            CommButton.BackColor = Color.Red                                                '----------/
            CommButton.Text = "BAD"                                                         '---------/
            MsgBox("OFFLINE!" & vbNewLine & "Check Communication Port.")                    '--------/
            Try                                                                             '-------/
                SerialPort1.PortName = serialPortNameString                                 '------/
                SerialPort1.BaudRate = serialPortBaudRateInteger                            '-----/
                SerialPort1.DataBits = serialPortDataBitsInteger                            '----/
                SerialPort1.StopBits = IO.Ports.StopBits.One                                '---/
                SerialPort1.Parity = IO.Ports.Parity.None                                   '--/
                SerialPort1.Open()                                                          '-/
            Catch                                                                           '/
            End Try
        End Try
    End Sub




    'Sub to insert the indexs to the Analog ranges section in the troubleshooting tab. Inserts the default ranges for all of the 
    'possible analog ranges.
    Sub DefaultRangeComboBox()
        AnalogRangeComboBox.Items.Add("Fish Tank Temperature")                              'Insert all the analog devices to the combobox.
        AnalogRangeComboBox.Items.Add("Reservoir Temperature")                              '------/
        AnalogRangeComboBox.Items.Add("Plant Bed PH")                                       '-----/
        AnalogRangeComboBox.Items.Add("Fish Tank PH")                                       '----/
        AnalogRangeComboBox.Items.Add("Disposable Solids")                                  '---/
        AnalogRangeComboBox.Items.Add("Conductivity")                                       '--/
        AnalogRangeComboBox.Items.Add("Analog Extra 1")                                     '-/
        AnalogRangeComboBox.Items.Add("Analog Extra 2")                                     '/



        rangeSaveSingle(0) = 10                                                             'Default ranges for Analog Extra 1. Yellow high.
        rangeSaveSingle(1) = -10                                                            'Yellow low.
        rangeSaveSingle(2) = 100                                                            'Red high.
        rangeSaveSingle(3) = -100                                                           'Red low.



        rangeSaveSingle(4) = 10                                                             'Default ranges for Analog Extra 2. Yellow high.
        rangeSaveSingle(5) = -10                                                            'Yellow low. 
        rangeSaveSingle(6) = 100                                                            'Red high.
        rangeSaveSingle(7) = -100                                                           'Red low.



        rangeSaveSingle(8) = 80                                                             'Default ranges for Fish Tank Temperature. Yellow high.
        rangeSaveSingle(9) = 65                                                             'Yellow low. 
        rangeSaveSingle(10) = 85                                                            'Red high.
        rangeSaveSingle(11) = 60                                                            'Red low.



        rangeSaveSingle(12) = 80                                                            'Default ranges for Reservoir Temperature. Yellow high.
        rangeSaveSingle(13) = 65                                                            'Yellow low. 
        rangeSaveSingle(14) = 85                                                            'Red high.
        rangeSaveSingle(15) = 60                                                            'Red low.



        rangeSaveSingle(16) = 1.8                                                           'Default ranges for Conductivity. Yellow high.
        rangeSaveSingle(17) = 1.4                                                           'Yellow low. 
        rangeSaveSingle(18) = 2                                                             'Red high.
        rangeSaveSingle(19) = 1.2                                                           'Red low.



        rangeSaveSingle(20) = 100                                                           'Default ranges for Disposable solids. Yellow high.
        rangeSaveSingle(21) = 50                                                            'Yellow low. 
        rangeSaveSingle(22) = 300                                                           'Red high.
        rangeSaveSingle(23) = 10                                                            'Red low.



        rangeSaveSingle(24) = 7                                                             'Default ranges for Fish Tank PH. Yellow high.
        rangeSaveSingle(25) = 6.8                                                           'Yellow low. 
        rangeSaveSingle(26) = 7.2                                                           'Red high.
        rangeSaveSingle(27) = 6.6                                                           'Red low.



        rangeSaveSingle(28) = 7                                                             'Default ranges for Plant Bed PH. Yellow high.
        rangeSaveSingle(29) = 6.8                                                           'Yellow low. 
        rangeSaveSingle(30) = 7.2                                                           'Red high.
        rangeSaveSingle(31) = 6.6                                                           'Red low.
    End Sub




    'Sub to display the ranges of the selected analog device. When the save range button is pressed the save arrange array is updated to 
    'the inserted. If the save range button was not saved, then the current range that was made previously will be displayed.
    Sub DisplayRanges()
        Select Case AnalogRangeComboBox.Text                                                'Select case to determine which analog ranges of the device should be displayed.
            Case "Fish Tank Temperature"                                                    'Displays the current Fish tank temperature ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    FishTankTemp(YellowHTextBox.Text, YellowLTextBox.Text,                  '-----/
                                 RedHTextBox.Text, RedLTextBox.Text)                        '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(8))                              '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(9))                              '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(10))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(11))                                '/



            Case "Reservoir Temperature"                                                    'Displays the current Reservoir temperature ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    ReservoirTemp(YellowHTextBox.Text, YellowLTextBox.Text,                 '-----/
                                  RedHTextBox.Text, RedLTextBox.Text)                       '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(12))                             '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(13))                             '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(14))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(15))                                '/



            Case "Plant Bed PH"                                                             'Displays the current Plant Bed PH ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    PlantBedPH(YellowHTextBox.Text, YellowLTextBox.Text,                    '-----/
                               RedHTextBox.Text, RedLTextBox.Text)                          '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(28))                             '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(29))                             '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(30))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(31))                                '/



            Case "Fish Tank PH"                                                             'Displays the current Fish tank PH ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    FishTankPH(YellowHTextBox.Text, YellowLTextBox.Text,                    '-----/
                               RedHTextBox.Text, RedLTextBox.Text)                          '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(24))                             '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(25))                             '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(26))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(27))                                '/



            Case "Disposable Solids"                                                        'Displays the current Disposable solids ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    DisposableSolids(YellowHTextBox.Text, YellowLTextBox.Text,              '-----/
                                     RedHTextBox.Text, RedLTextBox.Text)                    '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(20))                             '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(21))                             '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(22))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(23))                                '/



            Case "Conductivity"                                                             'Displays the current Conductivity ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    Conductivity(YellowHTextBox.Text, YellowLTextBox.Text,                  '-----/
                                 RedHTextBox.Text, RedLTextBox.Text)                        '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(16))                             '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(17))                             '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(18))                                '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(19))                                '/



            Case "Analog Extra 1"                                                           'Displays the current Analog Extra 1 ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    AnalogExtra1(YellowHTextBox.Text, YellowLTextBox.Text,                  '-----/
                                 RedHTextBox.Text, RedLTextBox.Text)                        '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(0))                              '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(1))                              '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(2))                                 '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(3))                                 '/



            Case "Analog Extra 2"                                                           'Displays the current Analog Extra 2 ranges, If save then it is updated.
                If rangeSaveBoolean Then                                                    '------/
                    AnalogExtra2(YellowHTextBox.Text, YellowLTextBox.Text,                  '-----/
                                 RedHTextBox.Text, RedLTextBox.Text)                        '----/
                End If
                YellowHTextBox.Text = CStr(rangeSaveSingle(4))                              '---/
                YellowLTextBox.Text = CStr(rangeSaveSingle(5))                              '--/
                RedHTextBox.Text = CStr(rangeSaveSingle(6))                                 '-/
                RedLTextBox.Text = CStr(rangeSaveSingle(7))                                 '/
        End Select
        Timer1.Enabled = True                                                               'Re-enables the Timer1 to keep testing the data.
        rangeSaveBoolean = False                                                            'Disables the save range until the save range button is clicked again.
    End Sub




    'Sub to test all the devices for when the PIC sends the Green light header. The program will test if the ranges 
    'have been changed and if not the defaults will be the range. Purpose is to test if the data is out of range or not to test all the devices and verify.
    Sub GreenAlert()
        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            AnalogExtra1(CStr(rangeSaveSingle(0)), CStr(rangeSaveSingle(1)),                'If not the default range is analyzed.
                             CStr(rangeSaveSingle(2)), CStr(rangeSaveSingle(3)))            '---/
        Catch ex As Exception                                                               '--/
            AnalogExtra1("", "", "", "")                                                    '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            AnalogExtra2(CStr(rangeSaveSingle(4)), CStr(rangeSaveSingle(5)),                'If not the default range is analyzed.
                             CStr(rangeSaveSingle(6)), CStr(rangeSaveSingle(7)))            '---/
        Catch ex As Exception                                                               '--/
            AnalogExtra2("", "", "", "")                                                    '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            FishTankTemp(CStr(rangeSaveSingle(8)), CStr(rangeSaveSingle(9)),                'If not the default range is analyzed.
                             CStr(rangeSaveSingle(10)), CStr(rangeSaveSingle(11)))          '---/
        Catch ex As Exception                                                               '--/
            FishTankTemp("", "", "", "")                                                    '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            ReservoirTemp(CStr(rangeSaveSingle(12)), CStr(rangeSaveSingle(13)),             'If not the default range is analyzed.
                              CStr(rangeSaveSingle(14)), CStr(rangeSaveSingle(15)))         '---/
        Catch ex As Exception                                                               '--/
            ReservoirTemp("", "", "", "")                                                   '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            Conductivity(CStr(rangeSaveSingle(16)), CStr(rangeSaveSingle(17)),              'If not the default range is analyzed.
                             CStr(rangeSaveSingle(18)), CStr(rangeSaveSingle(19)))          '---/
        Catch ex As Exception                                                               '--/
            Conductivity("", "", "", "")                                                    '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            DisposableSolids(CStr(rangeSaveSingle(20)), CStr(rangeSaveSingle(21)),          'If not the default range is analyzed.
                                 CStr(rangeSaveSingle(22)), CStr(rangeSaveSingle(23)))      '---/
        Catch ex As Exception                                                               '--/
            DisposableSolids("", "", "", "")                                                '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            FishTankPH(CStr(rangeSaveSingle(24)), CStr(rangeSaveSingle(25)),                'If not the default range is analyzed.
                           CStr(rangeSaveSingle(26)), CStr(rangeSaveSingle(27)))            '---/
        Catch ex As Exception                                                               '--/
            FishTankPH("", "", "", "")                                                      '-/
        End Try                                                                             '/



        Try                                                                                 'Try/Catch to test if the save range array has the set ranges. 
            PlantBedPH(CStr(rangeSaveSingle(28)), CStr(rangeSaveSingle(29)),                'If not the default range is analyzed.
                           CStr(rangeSaveSingle(30)), CStr(rangeSaveSingle(31)))            '---/
        Catch ex As Exception                                                               '--/
            PlantBedPH("", "", "", "")                                                      '-/
        End Try                                                                             '/



        DigitalByte()                                                                       'Test all digital devices.
        DigitalExtraByte()                                                                  '-/
        DigitalWaterLevelByte()                                                             '/
        TimeOfLights()                                                                      'Time of day test for the lights and also the fish feed time.
        TimeofFeed()                                                                        '/
    End Sub




    'Sub to test all the analog devices for when the PIC sends the Yellow light header. The PIC data after the header indicates which device 
    'is in the yelllow range. The program will test if the ranges have been changed and if not the defaults will be the range to verify the PIC data.
    Sub YellowAlert()
        If receiveByte(1) = &H22 Then                                                       'Yellow light header that indicates Analog Extra 1 at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                AnalogExtra1(CStr(rangeSaveSingle(0)), CStr(rangeSaveSingle(1)),            '----/
                             CStr(rangeSaveSingle(2)), CStr(rangeSaveSingle(3)))            '---/
            Catch ex As Exception                                                           '--/
                AnalogExtra1("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H23 Then                                                   'Yellow light header that indicates Analog Extra 2 at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                AnalogExtra2(CStr(rangeSaveSingle(4)), CStr(rangeSaveSingle(5)),            '----/
                             CStr(rangeSaveSingle(6)), CStr(rangeSaveSingle(7)))            '---/
            Catch ex As Exception                                                           '--/
                AnalogExtra2("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H24 Then                                                   'Yellow light header that indicates Fish Tank Temperature at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                FishTankTemp(CStr(rangeSaveSingle(8)), CStr(rangeSaveSingle(9)),            '----/
                             CStr(rangeSaveSingle(10)), CStr(rangeSaveSingle(11)))          '---/
            Catch ex As Exception                                                           '--/
                FishTankTemp("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H25 Then                                                   'Yellow light header that indicates Reservoir Temperature at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                ReservoirTemp(CStr(rangeSaveSingle(12)), CStr(rangeSaveSingle(13)),         '----/
                              CStr(rangeSaveSingle(14)), CStr(rangeSaveSingle(15)))         '---/
            Catch ex As Exception                                                           '--/
                ReservoirTemp("", "", "", "")                                               '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H26 Then                                                   'Yellow light header that indicates Conductivity at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                Conductivity(CStr(rangeSaveSingle(16)), CStr(rangeSaveSingle(17)),          '----/
                             CStr(rangeSaveSingle(18)), CStr(rangeSaveSingle(19)))          '---/
            Catch ex As Exception                                                           '--/
                Conductivity("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H27 Then                                                   'Yellow light header that indicates Dispoable Solids at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                DisposableSolids(CStr(rangeSaveSingle(20)), CStr(rangeSaveSingle(21)),      '----/
                                 CStr(rangeSaveSingle(22)), CStr(rangeSaveSingle(23)))      '---/
            Catch ex As Exception                                                           '--/
                DisposableSolids("", "", "", "")                                            '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H28 Then                                                   'Yellow light header that indicates Fish Tank PH at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                FishTankPH(CStr(rangeSaveSingle(24)), CStr(rangeSaveSingle(25)),            '----/
                           CStr(rangeSaveSingle(26)), CStr(rangeSaveSingle(27)))            '---/
            Catch ex As Exception                                                           '--/
                FishTankPH("", "", "", "")                                                  '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H29 Then                                                   'Yellow light header that indicates Plant Bed PH at ok State.
            Try                                                                             'The program tests with the current ranges and verifies.
                PlantBedPH(CStr(rangeSaveSingle(28)), CStr(rangeSaveSingle(29)),            '----/
                           CStr(rangeSaveSingle(30)), CStr(rangeSaveSingle(31)))            '---/
            Catch ex As Exception                                                           '--/
                PlantBedPH("", "", "", "")                                                  '-/
            End Try                                                                         '/
        End If
    End Sub




    'Sub to test all the devices for when the PIC sends the Red light header. The PIC data after the header indicates which device 
    'is in the red range. The program will test if the ranges have been changed and if not the defaults will be the range to verify the PIC data.
    Sub RedAlert()
        If receiveByte(1) = &H32 Then                                                       'Red light header that indicates Analog Extra 1 at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                AnalogExtra1(CStr(rangeSaveSingle(0)), CStr(rangeSaveSingle(1)),            '----/
                             CStr(rangeSaveSingle(2)), CStr(rangeSaveSingle(3)))            '---/
            Catch ex As Exception                                                           '--/
                AnalogExtra1("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H33 Then                                                   'Red light header that indicates Analog Extra 2 at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                AnalogExtra2(CStr(rangeSaveSingle(4)), CStr(rangeSaveSingle(5)),            '----/
                             CStr(rangeSaveSingle(6)), CStr(rangeSaveSingle(7)))            '---/
            Catch ex As Exception                                                           '--/
                AnalogExtra2("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H34 Then                                                   'Red light header that indicates Fish Tank Temperature at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                FishTankTemp(CStr(rangeSaveSingle(8)), CStr(rangeSaveSingle(9)),            '----/
                             CStr(rangeSaveSingle(10)), CStr(rangeSaveSingle(11)))          '---/
            Catch ex As Exception                                                           '--/
                FishTankTemp("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H35 Then                                                   'Red light header that indicates Reservoir Temperature at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                ReservoirTemp(CStr(rangeSaveSingle(12)), CStr(rangeSaveSingle(13)),         '----/
                              CStr(rangeSaveSingle(14)), CStr(rangeSaveSingle(15)))         '---/
            Catch ex As Exception                                                           '--/
                ReservoirTemp("", "", "", "")                                               '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H36 Then                                                   'Red light header that indicates Conductivity at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                Conductivity(CStr(rangeSaveSingle(16)), CStr(rangeSaveSingle(17)),          '----/
                             CStr(rangeSaveSingle(18)), CStr(rangeSaveSingle(19)))          '---/
            Catch ex As Exception                                                           '--/
                Conductivity("", "", "", "")                                                '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H37 Then                                                   'Red light header that indicates Disposable Solids at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                DisposableSolids(CStr(rangeSaveSingle(20)), CStr(rangeSaveSingle(21)),      '----/
                                 CStr(rangeSaveSingle(22)), CStr(rangeSaveSingle(23)))      '---/
            Catch ex As Exception                                                           '--/
                DisposableSolids("", "", "", "")                                            '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H38 Then                                                   'Red light header that indicates Fish Tank PH at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                FishTankPH(CStr(rangeSaveSingle(24)), CStr(rangeSaveSingle(25)),            '----/
                           CStr(rangeSaveSingle(26)), CStr(rangeSaveSingle(27)))            '---/
            Catch ex As Exception                                                           '--/
                FishTankPH("", "", "", "")                                                  '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H39 Then                                                   'Red light header that indicates Plant Bed PH at bad State.
            Try                                                                             'The program tests with the current ranges and verifies.
                PlantBedPH(CStr(rangeSaveSingle(28)), CStr(rangeSaveSingle(29)),            '----/
                           CStr(rangeSaveSingle(30)), CStr(rangeSaveSingle(31)))            '---/
            Catch ex As Exception                                                           '--/
                PlantBedPH("", "", "", "")                                                  '-/
            End Try                                                                         '/



        ElseIf receiveByte(1) = &H3A Then                                                   'Red light header that indicates one of the signals in digitl byte at bad State.
            DigitalByte()                                                                   'The program tests with the current ranges and verifies.



        ElseIf receiveByte(1) = &H3B Then                                                   'Red light header that indicates one of the signals in digitl extra byte at bad State.
            DigitalExtraByte()                                                              'The program tests with the current ranges and verifies.



        ElseIf receiveByte(1) = &H3C Then                                                   'Red light header that indicates one of the signals in digitl WL byte at bad State.
            DigitalWaterLevelByte()                                                         'The program tests with the current ranges and verifies.
        End If
    End Sub




    'Sub for the Analog Extra 1. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub AnalogExtra1(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 10                                                           '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = -10                                                           '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 100                                                             '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 10                                                       '----------/
                yellowLowSingle = -10                                                       '---------/
                redHighSingle = 100                                                         '--------/
                redLowSingle = -100                                                         '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = -100                                                             '-----/
        End Try                                                                             '----/
        rangeSaveSingle(0) = yellowHighSingle                                               '---/
        rangeSaveSingle(1) = yellowLowSingle                                                '--/
        rangeSaveSingle(2) = redHighSingle                                                  '-/
        rangeSaveSingle(3) = redLowSingle                                                   '/



        analogRecHInteger = receiveByte(2)                                                  'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(3)                                                  'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        AnalogEX1Button.BackColor = colorStateColor                                         '/



        If AnalogEX1Button.BackColor = Color.Green Then                                     'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            AnalogEX1Button.Text = "GOOD"                                                   'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H11                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf AnalogEX1Button.BackColor = Color.Yellow Then                                '--------/
            AnalogEX1Button.Text = "OK"                                                     '-------/
            sendByte(0) = &H13                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            AnalogEX1Button.Text = "BAD"                                                    '---/
            sendByte(0) = &H15                                                              '--/
            PortWrite()                                                                     '-/
        End If
        AnalogEX1TextBox.Text = (CInt(analogRecInteger).ToString)                           '/
    End Sub




    'Sub for the Analog Extra 2. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub AnalogExtra2(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '----------------------------/
            yellowHighSingle = 10                                                           '---------------------------/
        End Try                                                                             '--------------------------/
        Try                                                                                 '-------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '------------------------/
        Catch ex As Exception                                                               '-----------------------/
            yellowLowSingle = -10                                                           '----------------------/
        End Try                                                                             '---------------------/
        Try                                                                                 '--------------------/
            redHighSingle = CSng(redHTextString)                                            '-------------------/
        Catch ex As Exception                                                               '------------------/
            redHighSingle = 100                                                             '-----------------/
        End Try                                                                             '----------------/
        Try                                                                                 '---------------/
            redLowSingle = CSng(redLTextString)                                             '--------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '-------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '------------/
                yellowHighSingle = 10                                                       '-----------/
                yellowLowSingle = -10                                                       '----------/
                redHighSingle = 100                                                         '---------/
                redLowSingle = -100                                                         '--------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = -100                                                             '-----/
        End Try                                                                             '----/
        rangeSaveSingle(4) = yellowHighSingle                                               '---/
        rangeSaveSingle(5) = yellowLowSingle                                                '--/
        rangeSaveSingle(6) = redHighSingle                                                  '-/
        rangeSaveSingle(7) = redLowSingle                                                   '/



        analogRecHInteger = receiveByte(4)                                                  'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(5)                                                  'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        AnalogEX2Button.BackColor = colorStateColor                                         '/



        If AnalogEX2Button.BackColor = Color.Green Then                                     'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            AnalogEX2Button.Text = "GOOD"                                                   'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H17                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf AnalogEX2Button.BackColor = Color.Yellow Then                                '--------/
            AnalogEX2Button.Text = "OK"                                                     '-------/
            sendByte(0) = &H19                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            AnalogEX2Button.Text = "BAD"                                                    '---/
            sendByte(0) = &H1B                                                              '--/
            PortWrite()                                                                     '-/
        End If
        AnalogEX2TextBox.Text = (CInt(analogRecInteger).ToString)                           '/
    End Sub




    'Sub for the Fish Tank Temperature. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub FishTankTemp(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 80                                                           '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 65                                                            '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 85                                                              '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 80                                                       '----------/
                yellowLowSingle = 65                                                        '---------/
                redHighSingle = 85                                                          '--------/
                redLowSingle = 60                                                           '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 60                                                               '-----/
        End Try                                                                             '----/
        rangeSaveSingle(8) = yellowHighSingle                                               '---/
        rangeSaveSingle(9) = yellowLowSingle                                                '--/
        rangeSaveSingle(10) = redHighSingle                                                 '-/
        rangeSaveSingle(11) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(6)                                                  'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(7)                                                  'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        FishTempButton.BackColor = colorStateColor                                          '/



        If FishTempButton.BackColor = Color.Green Then                                      'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            FishTempButton.Text = "GOOD"                                                    'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H21                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf FishTempButton.BackColor = Color.Yellow Then                                 '--------/
            FishTempButton.Text = "OK"                                                      '-------/
            sendByte(0) = &H23                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FishTempButton.Text = "BAD"                                                     '---/
            sendByte(0) = &H25                                                              '--/
            PortWrite()                                                                     '-/
        End If
        FishTempTextBox.Text = (CInt(analogRecInteger).ToString)                            '/
    End Sub




    'Sub for the Reservoir Temperature. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub ReservoirTemp(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 80                                                           '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 65                                                            '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 85                                                              '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 80                                                       '----------/
                yellowLowSingle = 65                                                        '---------/
                redHighSingle = 85                                                          '--------/
                redLowSingle = 60                                                           '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 60                                                               '-----/
        End Try                                                                             '----/
        rangeSaveSingle(12) = yellowHighSingle                                              '---/   
        rangeSaveSingle(13) = yellowLowSingle                                               '--/
        rangeSaveSingle(14) = redHighSingle                                                 '-/
        rangeSaveSingle(15) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(8)                                                  'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(9)                                                  'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        ResTempButton.BackColor = colorStateColor                                           '/



        If ResTempButton.BackColor = Color.Green Then                                       'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            ResTempButton.Text = "GOOD"                                                     'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H27                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf ResTempButton.BackColor = Color.Yellow Then                                  '--------/
            ResTempButton.Text = "OK"                                                       '-------/
            sendByte(0) = &H29                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            ResTempButton.Text = "BAD"                                                      '---/
            sendByte(0) = &H2B                                                              '--/
            PortWrite()                                                                     '-/
        End If
        ResTempTextBox.Text = (CInt(analogRecInteger).ToString)                             '/
    End Sub




    'Sub for the Conductivity. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub Conductivity(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 1.8                                                          '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 1.4                                                           '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 2                                                               '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 1.8                                                      '----------/
                yellowLowSingle = 1.4                                                       '---------/
                redHighSingle = 2                                                           '--------/
                redLowSingle = 1.2                                                          '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 1.2                                                              '-----/
        End Try                                                                             '----/
        rangeSaveSingle(16) = yellowHighSingle                                              '---/
        rangeSaveSingle(17) = yellowLowSingle                                               '--/
        rangeSaveSingle(18) = redHighSingle                                                 '-/
        rangeSaveSingle(19) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(10)                                                 'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(11)                                                 'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        ConductButton.BackColor = colorStateColor                                           '/



        If ConductButton.BackColor = Color.Green Then                                       'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            ConductButton.Text = "GOOD"                                                     'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H31                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf ConductButton.BackColor = Color.Yellow Then                                  '--------/
            ConductButton.Text = "OK"                                                       '-------/
            sendByte(0) = &H33                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            ConductButton.Text = "BAD"                                                      '---/
            sendByte(0) = &H35                                                              '--/
            PortWrite()                                                                     '-/
        End If
        ConductTextBox.Text = (CInt(analogRecInteger).ToString)                             '/
    End Sub




    'Sub for the Disposable Solids. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub DisposableSolids(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 100                                                          '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 50                                                            '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 300                                                             '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 100                                                      '----------/
                yellowLowSingle = 50                                                        '---------/
                redHighSingle = 300                                                         '--------/
                redLowSingle = 10                                                           '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 10                                                               '-----/
        End Try                                                                             '----/
        rangeSaveSingle(20) = yellowHighSingle                                              '---/
        rangeSaveSingle(21) = yellowLowSingle                                               '--/
        rangeSaveSingle(22) = redHighSingle                                                 '-/
        rangeSaveSingle(23) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(12)                                                 'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(13)                                                 'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        DisposeButton.BackColor = colorStateColor                                           '/



        If DisposeButton.BackColor = Color.Green Then                                       'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            DisposeButton.Text = "GOOD"                                                     'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H37                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf DisposeButton.BackColor = Color.Yellow Then                                  '--------/
            DisposeButton.Text = "OK"                                                       '-------/
            sendByte(0) = &H39                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            DisposeButton.Text = "BAD"                                                      '---/
            sendByte(0) = &H3B                                                              '--/
            PortWrite()                                                                     '-/
        End If
        DisposeTextBox.Text = (CInt(analogRecInteger).ToString)                             '/
    End Sub




    'Sub for the Fish Tank PH. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub FishTankPH(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 7                                                            '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 6.8                                                           '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 7.2                                                             '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 7                                                        '----------/
                yellowLowSingle = 6.8                                                       '---------/
                redHighSingle = 7.2                                                         '--------/
                redLowSingle = 6.6                                                          '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 6.6                                                              '-----/
        End Try                                                                             '----/
        rangeSaveSingle(24) = yellowHighSingle                                              '---/
        rangeSaveSingle(25) = yellowLowSingle                                               '--/
        rangeSaveSingle(26) = redHighSingle                                                 '-/
        rangeSaveSingle(27) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(14)                                                 'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(15)                                                 'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        FishPHButton.BackColor = colorStateColor                                            '/



        If FishPHButton.BackColor = Color.Green Then                                        'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            FishPHButton.Text = "GOOD"                                                      'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H41                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf FishPHButton.BackColor = Color.Yellow Then                                   '--------/
            FishPHButton.Text = "OK"                                                        '-------/
            sendByte(0) = &H43                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FishPHButton.Text = "BAD"                                                       '---/
            sendByte(0) = &H45                                                              '--/
            PortWrite()                                                                     '-/
        End If
        FishPHTextBox.Text = (CInt(analogRecInteger).ToString)                              '/
    End Sub




    'Sub for the Plant Bed PH. Sets or gets the range. If the ranges are INVALID then the range will automatically be set to the default range which
    'will displayed so the user knows that the range is the default. The save range array is updated to the new range. The PIC sends the two bytes of data
    'which is the numberical value of the Analog device. That number is inserted into the Test analog data which returns the color of the analog data. 
    'Based by the color returned, the program will display that state. The displayed state is set back to the PIC verifying the state.
    Sub PlantBedPH(ByVal yellowHTextString As String, ByVal yellowLTextString As String, ByVal redHTextString As String, ByVal redLTextString As String)
        Try                                                                                 'Tests if the Ranges inserted are INVALID if so the ranges are set to the defaults.
            yellowHighSingle = CSng(yellowHTextString)                                      'If they are VALID then the ranges are set to the new values.
        Catch ex As Exception                                                               '---------------------------/
            yellowHighSingle = 7                                                            '--------------------------/
        End Try                                                                             '-------------------------/
        Try                                                                                 '------------------------/
            yellowLowSingle = CSng(yellowLTextString)                                       '-----------------------/
        Catch ex As Exception                                                               '----------------------/
            yellowLowSingle = 6.8                                                           '---------------------/
        End Try                                                                             '--------------------/
        Try                                                                                 '-------------------/
            redHighSingle = CSng(redHTextString)                                            '------------------/
        Catch ex As Exception                                                               '-----------------/
            redHighSingle = 7.2                                                             '----------------/
        End Try                                                                             '---------------/
        Try                                                                                 '--------------/
            redLowSingle = CSng(redLTextString)                                             '-------------/
            If redHighSingle < yellowHighSingle Or redLowSingle > yellowLowSingle Or        '------------/
                yellowLowSingle > yellowHighSingle Or redLowSingle > redHighSingle Then     '-----------/
                yellowHighSingle = 7                                                        '----------/
                yellowLowSingle = 6.8                                                       '---------/
                redHighSingle = 7.2                                                         '--------/
                redLowSingle = 6.6                                                          '-------/
            End If
        Catch ex As Exception                                                               '------/
            redLowSingle = 6.6                                                              '-----/
        End Try                                                                             '----/
        rangeSaveSingle(28) = yellowHighSingle                                              '---/
        rangeSaveSingle(29) = yellowLowSingle                                               '--/
        rangeSaveSingle(30) = redHighSingle                                                 '-/
        rangeSaveSingle(31) = redLowSingle                                                  '/



        analogRecHInteger = receiveByte(16)                                                 'Gets the analog value and with that value, the test analog data will
        analogRecLInteger = receiveByte(17)                                                 'get the state the analog device is in.
        analogRecHInteger = analogRecHInteger * 4                                           '-----/
        analogRecLInteger = analogRecLInteger \ 64                                          '----/
        analogRecInteger = analogRecHInteger + analogRecLInteger                            '---/
        colorStateColor = TestAnalogData(analogRecInteger, yellowHighSingle,                '--/
                                         yellowLowSingle, redHighSingle, redLowSingle)      '-/
        PlantPHButton.BackColor = colorStateColor                                           '/



        If PlantPHButton.BackColor = Color.Green Then                                       'Based of the state color returned, the appropriate display of GOOD, Ok, and BAD is shown.
            PlantPHButton.Text = "GOOD"                                                     'The state then is set back to the PIC. The analog numberical value is shown to the user.
            sendByte(0) = &H47                                                              '----------/
            PortWrite()                                                                     '---------/
        ElseIf PlantPHButton.BackColor = Color.Yellow Then                                  '--------/
            PlantPHButton.Text = "OK"                                                       '-------/
            sendByte(0) = &H49                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            PlantPHButton.Text = "BAD"                                                      '---/
            sendByte(0) = &H4B                                                              '--/
            PortWrite()                                                                     '-/
        End If
        PlantPHTextBox.Text = (CInt(analogRecInteger).ToString)                             '/
    End Sub



    'Sub for the Digital Byte. Sets each bit to the designated digital device. Based on if it is true or false the
    'program will determine whether if it is at a good or bad state. The result is sent back to the PIC.
    Sub DigitalByte()
        Dim digByteRecInteger As Integer                                                    'Dimension of the Numerical Value of the Transmitted data from the PIC.



        digByteRecInteger = receiveByte(18)                                                 'Sets the data from the PIC to a numerical value to be manipulated to indicate
        DigByte0CheckBox.Checked = GetBit(digByteRecInteger, 0)                             'a true or false per each digital device.
        DigByte1CheckBox.Checked = GetBit(digByteRecInteger, 1)                             '------/
        DigByte2CheckBox.Checked = GetBit(digByteRecInteger, 2)                             '-----/
        DigByte3CheckBox.Checked = GetBit(digByteRecInteger, 3)                             '----/
        DigByte4CheckBox.Checked = GetBit(digByteRecInteger, 4)                             '---/
        DigByte5CheckBox.Checked = GetBit(digByteRecInteger, 5)                             '--/
        DigByte6CheckBox.Checked = GetBit(digByteRecInteger, 6)                             '-/
        DigByte7CheckBox.Checked = GetBit(digByteRecInteger, 7)                             '/



        If DigByte0CheckBox.Checked Then                                                    'Tests the First Bit indicating for the outside light sensor. Displays to the user
            OutsideLightSensorButton.BackColor = Color.Ivory                                'the state. Light boolean is set/clear for logic with the Motion sensor.
            OutsideLightSensorButton.Text = "LIGHT"                                         '---------/
            lightBoolean(0) = True                                                          '--------/                                                                              
            FishDisplayLightButton.BackColor = Color.Gray                                   '-------/
            FishDisplayLightButton.Text = "OFF"                                             '------/
        Else                                                                                '-----/
            OutsideLightSensorButton.BackColor = Color.Gray                                 '----/
            OutsideLightSensorButton.Text = "DARK"                                          '---/
            lightBoolean(0) = False                                                         '--/
            FishDisplayLightButton.BackColor = Color.Green                                  '-/
            FishDisplayLightButton.Text = "ON"                                              '/
        End If



        If DigByte1CheckBox.Checked Then                                                    'Tests the Second Bit indicating for the grow light sensor. Displays to the user
            GrowLightSensorButton.BackColor = Color.Ivory                                   'the state. Light boolean is set/clear for logic with the Motion sensor.
            GrowLightSensorButton.Text = "LIGHT"                                            '---------/
            lightBoolean(1) = True                                                          '--------/
            GrowLightButton.BackColor = Color.Gray                                          '-------/
            GrowLightButton.Text = "OFF"                                                    '------/
        Else                                                                                '-----/
            GrowLightSensorButton.BackColor = Color.Gray                                    '----/
            GrowLightSensorButton.Text = "DARK"                                             '---/
            lightBoolean(1) = False                                                         '--/
            GrowLightButton.BackColor = Color.Green                                         '-/
            GrowLightButton.Text = "ON"                                                     '/
        End If



        If DigByte2CheckBox.Checked Then                                                    'Tests the Third Bit indicating for the motion sensor. Displays to the user
            MotionButton.BackColor = Color.Green                                            'the state. Based on light boolean, the program will transmit to the PIC on 
            MotionButton.Text = "MOTION"                                                    'what do do for the lights. If no motion it transmits a different package.
            motionBoolean = True                                                            '------------/
            If lightBoolean(0) = True Then                                                  '-----------/
                sendByte(0) = &H91                                                          '----------/
                PortWrite()                                                                 '---------/
            ElseIf lightBoolean(0) = False Then                                             '--------/
                sendByte(0) = &H93                                                          '-------/
                PortWrite()                                                                 '------/
            End If
        Else                                                                                '-----/
            MotionButton.BackColor = Color.Gray                                             '----/
            MotionButton.Text = "NO MOTION"                                                 '---/
            motionBoolean = False                                                           '--/
            sendByte(0) = &H95                                                              '-/
            PortWrite()                                                                     '/
        End If



        If DigByte3CheckBox.Checked Then                                                    'Tests the Fourth Bit indicating for the flow meter 1. Displays to the user
            FlowMeter1Button.BackColor = Color.Green                                        'the state. Transmits back to the PIC verifying it was received correctly.
            FlowMeter1Button.Text = "GOOD"                                                  '-------/
            sendByte(0) = &HA1                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FlowMeter1Button.BackColor = Color.Red                                          '---/
            FlowMeter1Button.Text = "BAD"                                                   '--/
            sendByte(0) = &HA3                                                              '-/
            PortWrite()                                                                     '/
        End If



        If DigByte4CheckBox.Checked Then                                                    'Tests the Fifth Bit indicating for the flow meter 2. Displays to the user
            FlowMeter2Button.BackColor = Color.Green                                        'the state. Transmits back to the PIC verifying it was received correctly.
            FlowMeter2Button.Text = "GOOD"                                                  '-------/
            sendByte(0) = &HA5                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FlowMeter2Button.BackColor = Color.Red                                          '---/
            FlowMeter2Button.Text = "BAD"                                                   '--/
            sendByte(0) = &HA7                                                              '-/
            PortWrite()                                                                     '/
        End If



        If DigByte5CheckBox.Checked Then                                                    'Tests the Sixth Bit indicating for the flow meter 3. Displays to the user
            FlowMeter3Button.BackColor = Color.Green                                        'the state. Transmits back to the PIC verifying it was received correctly.
            FlowMeter3Button.Text = "GOOD"                                                  '-------/
            sendByte(0) = &HA9                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FlowMeter3Button.BackColor = Color.Red                                          '---/
            FlowMeter3Button.Text = "BAD"                                                   '--/
            sendByte(0) = &HAB                                                              '-/
            PortWrite()                                                                     '/
        End If



        If DigByte6CheckBox.Checked Then                                                    'Tests the Seventh Bit indicating for the flow meter 4. Displays to the user
            FlowMeter4Button.BackColor = Color.Green                                        'the state. Transmits back to the PIC verifying it was received correctly.
            FlowMeter4Button.Text = "GOOD"                                                  '-------/
            sendByte(0) = &HAD                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FlowMeter4Button.BackColor = Color.Red                                          '---/
            FlowMeter4Button.Text = "BAD"                                                   '--/
            sendByte(0) = &HAF                                                              '-/
            PortWrite()                                                                     '/
        End If



        If DigByte7CheckBox.Checked Then                                                    'Tests the Eighth Bit indicating for the flow meter 5. Displays to the user
            FlowMeter5Button.BackColor = Color.Green                                        'the state. Transmits back to the PIC verifying it was received correctly.
            FlowMeter5Button.Text = "GOOD"                                                  '-------/
            sendByte(0) = &HA2                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FlowMeter5Button.BackColor = Color.Red                                          '---/
            FlowMeter5Button.Text = "BAD"                                                   '--/
            sendByte(0) = &HA4                                                              '-/
            PortWrite()                                                                     '/
        End If
    End Sub




    'Sub for the Digital Extra Byte. Sets each bit to the designated digital device. Based on if it is true or false the
    'program will determine whether if it is at a good or bad state. The result is sent back to the PIC.
    Sub DigitalExtraByte()
        Dim extraByteRecInteger As Integer                                                  'Dimension of the Numerical Value of the Transmitted data from the PIC.



        extraByteRecInteger = receiveByte(19)                                               'Sets the data from the PIC to a numerical value to be manipulated to indicate
        ExtraByte0CheckBox.Checked = GetBit(extraByteRecInteger, 0)                         'a true or false per each digital device.
        ExtraByte1CheckBox.Checked = GetBit(extraByteRecInteger, 1)                         '------/
        ExtraByte2CheckBox.Checked = GetBit(extraByteRecInteger, 2)                         '-----/
        ExtraByte3CheckBox.Checked = GetBit(extraByteRecInteger, 3)                         '----/
        ExtraByte4CheckBox.Checked = GetBit(extraByteRecInteger, 4)                         '---/
        ExtraByte5CheckBox.Checked = GetBit(extraByteRecInteger, 5)                         '--/
        ExtraByte6CheckBox.Checked = GetBit(extraByteRecInteger, 6)                         '-/
        ExtraByte7CheckBox.Checked = GetBit(extraByteRecInteger, 7)                         '/



        If ExtraByte0CheckBox.Checked Then                                                  'Tests the First Bit indicating for the Digital Extra 1. Displays to the user
            DigitalEX1Button.BackColor = Color.Red                                          'the state. Transmits back to the PIC verifying it was received correctly.
            DigitalEX1Button.Text = "BAD"                                                   '-------/
            sendByte(0) = &HB1                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            DigitalEX1Button.BackColor = Color.Green                                        '---/
            DigitalEX1Button.Text = "GOOD"                                                  '--/
            sendByte(0) = &HB3                                                              '-/
            PortWrite()                                                                     '/
        End If



        If ExtraByte1CheckBox.Checked Then                                                  'Tests the Second Bit indicating for the Digital Extra 2. Displays to the user
            DigitalEX2Button.BackColor = Color.Red                                          'the state. Transmits back to the PIC verifying it was received correctly.
            DigitalEX2Button.Text = "BAD"                                                   '-------/
            sendByte(0) = &HB5                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            DigitalEX2Button.BackColor = Color.Green                                        '---/
            DigitalEX2Button.Text = "GOOD"                                                  '--/
            sendByte(0) = &HB7                                                              '-/
            PortWrite()                                                                     '/
        End If



        If ExtraByte2CheckBox.Checked Then                                                  'Tests the Third Bit indicating for the Digital Extra 3. Displays to the user
            DigitalEX3Button.BackColor = Color.Red                                          'the state. Transmits back to the PIC verifying it was received correctly.
            DigitalEX3Button.Text = "BAD"                                                   '-------/
            sendByte(0) = &HB9                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            DigitalEX3Button.BackColor = Color.Green                                        '---/
            DigitalEX3Button.Text = "GOOD"                                                  '--/
            sendByte(0) = &HBB                                                              '-/
            PortWrite()                                                                     '/
        End If



        If ExtraByte3CheckBox.Checked Then                                                  'Tests the Fourth Bit indicating for the Pump 1. Displays to the user
            Pump1OutputButton.BackColor = Color.Green                                       'the state. This is controled by the Test controls to manually turn on the device.
            Pump1OutputButton.Text = "ON"                                                   '---/
        Else                                                                                '--/
            Pump1OutputButton.BackColor = Color.Red                                         '-/
            Pump1OutputButton.Text = "OFF"                                                  '/
        End If



        If ExtraByte4CheckBox.Checked Then                                                  'Tests the Fifth Bit indicating for the Pump 2. Displays to the user
            Pump2OutputButton.BackColor = Color.Green                                       'the state. This is controled by the Test controls to manually turn on the device.
            Pump2OutputButton.Text = "ON"                                                   '---/
        Else                                                                                '--/
            Pump2OutputButton.BackColor = Color.Red                                         '-/
            Pump2OutputButton.Text = "OFF"                                                  '/
        End If



        If ExtraByte5CheckBox.Checked Then                                                  'Tests the Sixth Bit indicating for the Pump 3. Displays to the user
            Pump3OutputButton.BackColor = Color.Green                                       'the state. This is controled by the Test controls to manually turn on the device.
            Pump3OutputButton.Text = "ON"                                                   '---/
        Else                                                                                '--/
            Pump3OutputButton.BackColor = Color.Red                                         '-/
            Pump3OutputButton.Text = "OFF"                                                  '/
        End If



        If ExtraByte6CheckBox.Checked Then                                                  'Tests the Seventh Bit indicating for the Fish Heater. Displays to the user
            FishHeaterOutputButton.BackColor = Color.Green                                  'the state. This is controled by the Test controls to manually turn on the device.
            FishHeaterOutputButton.Text = "ON"                                              '---/
        Else                                                                                '--/
            FishHeaterOutputButton.BackColor = Color.Red                                    '-/
            FishHeaterOutputButton.Text = "OFF"                                             '/
        End If



        If ExtraByte7CheckBox.Checked Then                                                  'Tests the Eighth Bit indicating for the Reservoir Heater. Displays to the user
            ResHeaterOutputButton.BackColor = Color.Green                                   'the state. This is controled by the Test controls to manually turn on the device.
            ResHeaterOutputButton.Text = "ON"                                               '---/
        Else                                                                                '--/
            ResHeaterOutputButton.BackColor = Color.Red                                     '-/
            ResHeaterOutputButton.Text = "OFF"                                              '/
        End If
    End Sub




    'Sub for the Digital Water Level Byte. Sets each bit to the designated digital device. Based on if it is true or false the
    'program will determine whether if it is at a good or bad state. The result is sent back to the PIC.
    Sub DigitalWaterLevelByte()
        Dim wlByteRecInteger As Integer                                                     'Dimension of the Numerical Value of the Transmitted data from the PIC.



        wlByteRecInteger = receiveByte(20)                                                  'Sets the data from the PIC to a numerical value to be manipulated to indicate
        FishWLHCheckBox.Checked = GetBit(wlByteRecInteger, 0)                               'a true or false per each digital device.
        FishWLLCheckBox.Checked = GetBit(wlByteRecInteger, 1)                               '------/
        PlantWLHCheckBox1.Checked = GetBit(wlByteRecInteger, 2)                             '-----/
        PlantWLHCheckBox2.Checked = GetBit(wlByteRecInteger, 3)                             '----/
        ResWLHCheckBox.Checked = GetBit(wlByteRecInteger, 4)                                '---/
        ResWLLCheckBox.Checked = GetBit(wlByteRecInteger, 5)                                '--/
        FishFeederCheckBox.Checked = GetBit(wlByteRecInteger, 6)                            '-/
        ExtraWL2CheckBox.Checked = GetBit(wlByteRecInteger, 7)                              '/



        If FishWLHCheckBox.Checked Then                                                     'Tests the First Bit indicating for the Fish Tank Water Level High. Displays to the user
            FishWLHButton.BackColor = Color.Red                                             'the state. Transmits back to the PIC verifying it was received correctly.
            FishWLHButton.Text = "BAD"                                                      '-------/
            sendByte(0) = &HC1                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FishWLHButton.BackColor = Color.Green                                           '---/
            FishWLHButton.Text = "GOOD"                                                     '--/
            sendByte(0) = &HC3                                                              '-/
            PortWrite()                                                                     '/
        End If



        If FishWLLCheckBox.Checked Then                                                     'Tests the Second Bit indicating for the Fish Tank Water Level Low. Displays to the user
            FishWLLButton.BackColor = Color.Red                                             'the state. Transmits back to the PIC verifying it was received correctly.
            FishWLLButton.Text = "BAD"                                                      '-------/
            sendByte(0) = &HC5                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            FishWLLButton.BackColor = Color.Green                                           '---/
            FishWLLButton.Text = "GOOD"                                                     '--/
            sendByte(0) = &HC7                                                              '-/
            PortWrite()                                                                     '/
        End If



        If PlantWLHCheckBox1.Checked Then                                                   'Tests the Third Bit indicating for the Plant Bed Water Level High 1. Displays to the user
            PlantWLHButton1.BackColor = Color.Red                                           'the state. Transmits back to the PIC verifying it was received correctly.
            PlantWLHButton1.Text = "BAD"                                                    '-------/
            sendByte(0) = &HC9                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            PlantWLHButton1.BackColor = Color.Green                                         '---/
            PlantWLHButton1.Text = "GOOD"                                                   '--/
            sendByte(0) = &HCB                                                              '-/
            PortWrite()                                                                     '/
        End If



        If PlantWLHCheckBox2.Checked Then                                                   'Tests the Fourth Bit indicating for the Plant Bed Water Level High 2. Displays to the user
            PlantWLHButton2.BackColor = Color.Red                                           'the state. Transmits back to the PIC verifying it was received correctly.
            PlantWLHButton2.Text = "BAD"                                                    '-------/
            sendByte(0) = &HCD                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            PlantWLHButton2.BackColor = Color.Green                                         '---/
            PlantWLHButton2.Text = "GOOD"                                                   '--/
            sendByte(0) = &HCF                                                              '-/
            PortWrite()                                                                     '/
        End If



        If ResWLHCheckBox.Checked Then                                                      'Tests the Fifth Bit indicating for the Reservoir Water Level High. Displays to the user
            ResWLHButton.BackColor = Color.Red                                              'the state. Transmits back to the PIC verifying it was received correctly.
            ResWLHButton.Text = "BAD"                                                       '-------/
            sendByte(0) = &HC2                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            ResWLHButton.BackColor = Color.Green                                            '---/
            ResWLHButton.Text = "GOOD"                                                      '--/
            sendByte(0) = &HC4                                                              '-/
            PortWrite()                                                                     '/
        End If



        If ResWLLCheckBox.Checked Then                                                      'Tests the Sixth Bit indicating for the Reservoir Water Level Low. Displays to the user
            ResWLLButton.BackColor = Color.Red                                              'the state. Transmits back to the PIC verifying it was received correctly.
            ResWLLButton.Text = "BAD"                                                       '-------/
            sendByte(0) = &HC6                                                              '------/
            PortWrite()                                                                     '-----/
        Else                                                                                '----/
            ResWLLButton.BackColor = Color.Green                                            '---/
            ResWLLButton.Text = "GOOD"                                                      '--/
            sendByte(0) = &HC8                                                              '-/
            PortWrite()                                                                     '/
        End If


        If FishFeederCheckBox.Checked Then                                                  'Tests the Seventh Bit indicating for the Fish Tank Water Level High. Displays to the user
            FishFeederOutputButton.BackColor = Color.Green                                  'the state. Transmits back to the PIC verifying it was received correctly.
            FishFeederOutputButton.Text = "ON"                                              '---/
        Else                                                                                '--/
            FishFeederOutputButton.BackColor = Color.Red                                    '-/
            FishFeederOutputButton.Text = "OFF"                                             '/  
        End If
    End Sub



    'Sub to determine the State of the Analog device of whether it is in the Green/Good, Yellow/ok, or Red/Bad state. Returns the Color based
    'off the current setting on the range for that device
    Function TestAnalogData(ByVal analogRecInteger As Integer, ByVal analogHYellowSingle As Single,
                 ByVal analogLYellowSingle As Single, ByVal analogHRedSingle As Single, ByVal analogLRedSingle As Single) As Color
        Select Case analogRecInteger                                                        'Based off the analog value gets the state for the range.
            Case CInt(analogLYellowSingle) To CInt(analogHYellowSingle)                     '-------/
                Return Color.Green                                                          '------/
            Case CInt(analogLRedSingle) To CInt(analogHRedSingle)                           '-----/
                Return Color.Yellow                                                         '----/
            Case < CInt(analogLRedSingle)                                                   '---/
                Return Color.Red                                                            '--/
            Case > CInt(analogHRedSingle)                                                   '-/
                Return Color.Red                                                            '/
        End Select
    End Function




    'Sub to determine which bits or the Digital Byte is Set and Clear. Used to know the states of all of the Digital devices.
    Function GetBit(ByVal int As Integer, ByVal bitInteger As Integer) As Boolean
        Dim i As Integer                                                                    'Dimension for the exponent for the binary testing to always have i as integer value.
        Dim bitValBoolean As Boolean                                                        'Dimension for the return value set or clear.



        'subtact the int integer from binary multiples 1,2,4,8,16,32,64,128 and checks if the answer was negative
        'if positive and the bit sent is equal to the multiple than set the checkbox to true and return.
        For i = 7 To 0 Step -1                                                              'Loop to test all the bits of digital byte.
            bitValBoolean = False                                                           'Resets the set and clear boolean.
            If int - (2 ^ i) > -1 Then                                                      'subtract int from binary multiples and checks for positive number.
                int = Convert.ToInt32(int - (2 ^ i))                                        'if positive replace int with subtracted value.
                bitValBoolean = True                                                        'set value to true.
            End If
            If bitInteger = i Then                                                          'if value sent = bit tested return true to false      
                Return bitValBoolean                                                        '/
            End If
        Next i                                                                              'Goes to the binary location.
        Return bitValBoolean                                                                'Returns the bit value called for.
    End Function




    'Sub to determine the time of day for the Lights for the fish/Display lights and the growlights.
    'The default time of "Active" day is from 6am to 9pm. When there is no interrupt being the motion, the fish/display
    'lights and the grow lights are on. But also Depending on current outside light will depend on the state of the lights.
    Sub TimeOfLights()
        Dim lightTimeDate As New Date(2021, 11, 16, 0, 0, 0)                                'Dimension for the time of the day. Used to update the time for everysecond to be analyzed.



        lightTimeDate = TimeOfDay                                                           'Sets the current time to a String in military format.
        timeOfDayString = CStr(lightTimeDate.ToString("HH:mm:ss"))                          '/



        Select Case timeOfDayString                                                         'Select Case for the Current time transmits data if the time
            Case "06:00:00"                                                                 'Indicates the Start of the Day, Transmitts to the PIC and Sets light Boolean for motion logic.
                sendByte(0) = &H75                                                          '--/
                PortWrite()                                                                 '-/
                lightBoolean(2) = True                                                      '/



            Case "21:00:00"                                                                 'Indicates the End of the Day, Transmitts to the PIC and Sets light Boolean for motion logic.
                sendByte(0) = &H85                                                          '--/
                PortWrite()                                                                 '-/
                lightBoolean(2) = False                                                     '/


            Case Else                                                                       'For all other times of the day the program tests to see if there was any motion, and displays
                If motionBoolean Then                                                       'to the user and transmits to the PIC.
                    sendByte(0) = &H97                                                      '--------------/
                    PortWrite()                                                             '-------------/



                    FishDisplayLightButton.BackColor = Color.Green                          '-----------/
                    FishDisplayLightButton.Text = "ON"                                      '----------/
                    GrowLightButton.BackColor = Color.Gray                                  '---------/
                    GrowLightButton.Text = "OFF"                                            '--------/
                    Timer2.Enabled = True                                                   '-------/
                End If



                If OutsideLightSensorButton.Text = "LIGHT" Or                               '-----/
                    GrowLightSensorButton.Text = "LIGHT" Then                               '----/
                    FishDisplayLightButton.BackColor = Color.Gray                           '---/
                    FishDisplayLightButton.Text = "OFF"                                     '--/
                    GrowLightButton.BackColor = Color.Gray                                  '-/
                    GrowLightButton.Text = "OFF"                                            '/
                End If
        End Select
    End Sub




    'Sub to determine when the Fish are Fed. If the fish feed boolean is true means that the fish feed time has not been changed by the user,
    'or the time inserted by the user was saved. Once the time of day matches the fish feed time, the program Transmitts to the PIC to feed the
    'fish. Once the fish are fed the program will allow user to feed again, but ideally the fish should be fed once a day. The amount of times
    'they fed are acculumated. Once it's 1am the amount of times the fish are fed are refreshed and set back to the defaults.
    Sub TimeofFeed()
        Dim stateSingle As Single                                                           'StateSingle is a vbYes or vbNo Dimension.



        If FishFoodButton.BackColor = Color.Gray Then                                       'If the Fish are not fed yet that day that is continued to be displayed to the user.
            FishFeederMainButton.BackColor = Color.Gray                                     '-/
            FishFeederMainButton.Text = "OFF"                                               '/
            If fishFoodTimeBoolean = True Then                                              'If the Fish feed time boolean is set true then the time of day is anaylzed.
                Select Case timeOfDayString                                                 '/
                    Case FoodTimeTextBox.Text                                               'Tests if the Fish Food time text matches the time of day, transmits to the PIC 
                        sendByte(0) = &HFF                                                  'to feed, and displays to the user that they have been fed. 
                        PortWrite()                                                         '----/



                        FishFoodButton.BackColor = Color.Green                              '---/
                        FishFoodButton.Text = "FISH FED TODAY"                              '--/
                        FeedAgainCheckBox.Visible = True                                    '-/
                        fishFedTimesInteger += 1                                            '/



                        FishFeederMainButton.BackColor = Color.Green                        'Display of the Fish Feeder Control, Timer so that it is set green/on for 7 seconds
                        FishFeederMainButton.Text = "ON"                                    'then timer interval sets it to gray/off. Turns off the boolean indicating that the 
                        Timer3.Enabled = True                                               'fish have been fed.
                        fishFoodTimeBoolean = False                                         '/
                End Select
            End If



        ElseIf FeedAgainCheckBox.Checked = True And fishFoodTimeBoolean = True Then         'Function of when the Fish have already been fed but the user selects the feed again
            Select Case timeOfDayString                                                     'checkbox and the feed time has been verified. Transmits to the PIC to feed, adds one
                Case FoodTimeTextBox.Text                                                   'to the amount of times the fish have been feed that day.
                    sendByte(0) = &HFF                                                      '----/
                    PortWrite()                                                             '---/



                    fishFedTimesInteger += 1                                                '--/
                    FishFoodButton.BackColor = Color.Green                                  '-/
                    FishFoodButton.Text = $"FISH FED {fishFedTimesInteger} TIMES TODAY"     '/



                    FishFeederMainButton.BackColor = Color.Green                            'Display of the Fish Feeder Control, Timer so that it is set green/on for 7 seconds
                    FishFeederMainButton.Text = "ON"                                        'then timer interval sets it to gray/off. Turns off the boolean indicating that the
                    Timer3.Enabled = True                                                   'fish have been fed.
                    fishFoodTimeBoolean = False                                             '/
            End Select



        ElseIf FishFoodButton.BackColor = Color.Green And fishFoodTimeBoolean = True Then   'Function of when the User verified another fish feed time, once they've already been fed but checkbox is NOT checked.
            stateSingle = MsgBox("ALERT Fish have been fed today!" +                        'Alert Message box with message and a Yes and No buttons. Writes Select to stateSingle.                      
                "Would you like to feed again?", CType(vbYesNo + vbCritical +               'Tells user the fish have been feed and if selected yes then the program will check the checkbox and 
                vbDefaultButton2, MsgBoxStyle), "Exit")                                     'feed again at that verifed time, if not the fish won't be fed again.



            If stateSingle = vbYes Then                                                     'If/Then Function tests if Yes was selected.
                FeedAgainCheckBox.Checked = True                                            'If selected Yes, feed fish again.
                Select Case timeOfDayString                                                 '------/
                    Case FoodTimeTextBox.Text                                               '-----/
                        sendByte(0) = &HFF                                                  '----/
                        PortWrite()                                                         '---/



                        fishFedTimesInteger += 1                                            '--/
                        FishFoodButton.BackColor = Color.Green                              '-/
                        FishFoodButton.Text = $"FISH FED {fishFedTimesInteger} TIMES TODAY" '/  



                        FishFeederMainButton.BackColor = Color.Green                        'Display of the Fish Feeder Control, Timer so that it is set green/on for 7 seconds
                        FishFeederMainButton.Text = "ON"                                    'then timer interval sets it to gray/off. Turns off the boolean indicating that the
                        Timer3.Enabled = True                                               'fish have been fed.
                        fishFoodTimeBoolean = False                                         '/
                End Select



            ElseIf stateSingle = vbNo Then                                                  'If selected No, then return without setting a second feed.
                FeedAgainCheckBox.Checked = False                                           'Selects the Binary Count button. To Continue/Try Again.
                fishFoodTimeBoolean = False                                                 '/
            End If
        End If



        Select Case timeOfDayString                                                         'Once the time of day is 1am, resets the fish feed the default time.
            Case "01:00:00"                                                                 '---------/
                FishFoodButton.BackColor = Color.Gray                                       '--------/
                FishFoodButton.Text = "NOT FED TODAY"                                       '-------/
                fishFedTimesInteger = 0                                                     '------/
                FoodTimeTextBox.Text = "13:00:00"                                           '-----/
                fishFoodTimeBoolean = True                                                  '----/
                FishFoodAlertLabel.Visible = False                                          '---/
                SaveTimeButton.Visible = False                                              '--/
                FeedAgainCheckBox.Visible = False                                           '-/
                Timer3.Enabled = False                                                      '/
        End Select
    End Sub
End Class
