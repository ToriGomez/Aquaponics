<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainDisplayForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FishFoodGroupBox = New System.Windows.Forms.GroupBox()
        Me.FeedAgainCheckBox = New System.Windows.Forms.CheckBox()
        Me.SaveTimeButton = New System.Windows.Forms.Button()
        Me.FishFoodButton = New System.Windows.Forms.Button()
        Me.FishFoodLabel = New System.Windows.Forms.Label()
        Me.FoodTimeTextBox = New System.Windows.Forms.TextBox()
        Me.ControlsGroupBox = New System.Windows.Forms.GroupBox()
        Me.FishFeederControlLabel = New System.Windows.Forms.Label()
        Me.FishFeederMainButton = New System.Windows.Forms.Button()
        Me.FishDisplayLightButton = New System.Windows.Forms.Button()
        Me.GrowLightLabel = New System.Windows.Forms.Label()
        Me.FishDisplayLightLabel = New System.Windows.Forms.Label()
        Me.GrowLightButton = New System.Windows.Forms.Button()
        Me.OtherGroupBox = New System.Windows.Forms.GroupBox()
        Me.FlowMeter5Button = New System.Windows.Forms.Button()
        Me.Flowmeter5Label = New System.Windows.Forms.Label()
        Me.AnalogEX2TextBox = New System.Windows.Forms.TextBox()
        Me.DigitalEX3Button = New System.Windows.Forms.Button()
        Me.AnalogEX1TextBox = New System.Windows.Forms.TextBox()
        Me.AnalogEX2Button = New System.Windows.Forms.Button()
        Me.AnalogEX1Button = New System.Windows.Forms.Button()
        Me.DigitalEx3Label = New System.Windows.Forms.Label()
        Me.AnalogEx2Label = New System.Windows.Forms.Label()
        Me.AnalogEx1Label = New System.Windows.Forms.Label()
        Me.DigitalEX2Button = New System.Windows.Forms.Button()
        Me.CommButton = New System.Windows.Forms.Button()
        Me.DigitalEx2Label = New System.Windows.Forms.Label()
        Me.MotionButton = New System.Windows.Forms.Button()
        Me.CommLabel = New System.Windows.Forms.Label()
        Me.DigitalEX1Button = New System.Windows.Forms.Button()
        Me.DigitalExLabel = New System.Windows.Forms.Label()
        Me.MotionLabel = New System.Windows.Forms.Label()
        Me.ChemicalsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConductTextBox = New System.Windows.Forms.TextBox()
        Me.ConductButton = New System.Windows.Forms.Button()
        Me.ConductLabel = New System.Windows.Forms.Label()
        Me.DisposeTextBox = New System.Windows.Forms.TextBox()
        Me.FishPHTextBox = New System.Windows.Forms.TextBox()
        Me.PlantPHTextBox = New System.Windows.Forms.TextBox()
        Me.DisposeButton = New System.Windows.Forms.Button()
        Me.FishPHButton = New System.Windows.Forms.Button()
        Me.PlantPHButton = New System.Windows.Forms.Button()
        Me.DisposeLabel = New System.Windows.Forms.Label()
        Me.FishPHLabel = New System.Windows.Forms.Label()
        Me.PlantPHLabel = New System.Windows.Forms.Label()
        Me.TemperatureGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResTempTextBox = New System.Windows.Forms.TextBox()
        Me.FishTempTextBox = New System.Windows.Forms.TextBox()
        Me.ResTempButton = New System.Windows.Forms.Button()
        Me.FishTempButton = New System.Windows.Forms.Button()
        Me.ResTempLabel = New System.Windows.Forms.Label()
        Me.FishTempLabel = New System.Windows.Forms.Label()
        Me.LightSensorsGroupBox = New System.Windows.Forms.GroupBox()
        Me.GrowLightSensorButton = New System.Windows.Forms.Button()
        Me.OutsideLightSensorButton = New System.Windows.Forms.Button()
        Me.GrowLightSensorLabel = New System.Windows.Forms.Label()
        Me.OutsideLightSensorLabel = New System.Windows.Forms.Label()
        Me.FlowMetersGroupBox = New System.Windows.Forms.GroupBox()
        Me.FlowMeter4Button = New System.Windows.Forms.Button()
        Me.Flowmeter4Label = New System.Windows.Forms.Label()
        Me.FlowMeter3Button = New System.Windows.Forms.Button()
        Me.FlowMeter2Button = New System.Windows.Forms.Button()
        Me.FlowMeter1Button = New System.Windows.Forms.Button()
        Me.Flowmeter3Label = New System.Windows.Forms.Label()
        Me.Flowmeter2Label = New System.Windows.Forms.Label()
        Me.Flowmeter1Label = New System.Windows.Forms.Label()
        Me.WaterLevelsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ResWLLButton = New System.Windows.Forms.Button()
        Me.FishWLLButton = New System.Windows.Forms.Button()
        Me.PlantWLHButton2 = New System.Windows.Forms.Button()
        Me.WLLowLabel = New System.Windows.Forms.Label()
        Me.WLHighLabel = New System.Windows.Forms.Label()
        Me.ResWLHButton = New System.Windows.Forms.Button()
        Me.PlantWLHButton1 = New System.Windows.Forms.Button()
        Me.FishWLHButton = New System.Windows.Forms.Button()
        Me.ResWLLabel = New System.Windows.Forms.Label()
        Me.PlantWLLabel = New System.Windows.Forms.Label()
        Me.FishWLLabel = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OutputStatesGroupBox = New System.Windows.Forms.GroupBox()
        Me.FishFeederOutputButton = New System.Windows.Forms.Button()
        Me.FishFeedLabel = New System.Windows.Forms.Label()
        Me.ResHeaterOutputButton = New System.Windows.Forms.Button()
        Me.ResHeaterLabel = New System.Windows.Forms.Label()
        Me.FishHeaterOutputButton = New System.Windows.Forms.Button()
        Me.FishHeaterLabel = New System.Windows.Forms.Label()
        Me.Pump3OutputButton = New System.Windows.Forms.Button()
        Me.Pump3Label = New System.Windows.Forms.Label()
        Me.Pump2OutputButton = New System.Windows.Forms.Button()
        Me.Pump2Label = New System.Windows.Forms.Label()
        Me.Pump1OutputButton = New System.Windows.Forms.Button()
        Me.Pump1Label = New System.Windows.Forms.Label()
        Me.TestGroupBox = New System.Windows.Forms.GroupBox()
        Me.FishFeederButton = New System.Windows.Forms.Button()
        Me.StackLightRButton = New System.Windows.Forms.Button()
        Me.StackLightYButton = New System.Windows.Forms.Button()
        Me.StackLightGButton = New System.Windows.Forms.Button()
        Me.FishLightButton = New System.Windows.Forms.Button()
        Me.GrowLightControlButton = New System.Windows.Forms.Button()
        Me.ResHeaterButton = New System.Windows.Forms.Button()
        Me.FishHeaterButton = New System.Windows.Forms.Button()
        Me.Pump3Button = New System.Windows.Forms.Button()
        Me.Pump2Button = New System.Windows.Forms.Button()
        Me.Pump1Button = New System.Windows.Forms.Button()
        Me.AnalogRangesGroupBox = New System.Windows.Forms.GroupBox()
        Me.SaveLabel = New System.Windows.Forms.Label()
        Me.SaverRangeButton = New System.Windows.Forms.Button()
        Me.AnalogRangeComboBox = New System.Windows.Forms.ComboBox()
        Me.RedLLabel = New System.Windows.Forms.Label()
        Me.RedLTextBox = New System.Windows.Forms.TextBox()
        Me.RedHLabel = New System.Windows.Forms.Label()
        Me.RedHTextBox = New System.Windows.Forms.TextBox()
        Me.YellowLLabel = New System.Windows.Forms.Label()
        Me.YellowLTextBox = New System.Windows.Forms.TextBox()
        Me.YellowHLabel = New System.Windows.Forms.Label()
        Me.YellowHTextBox = New System.Windows.Forms.TextBox()
        Me.RecDigitalGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExtraWL2CheckBox = New System.Windows.Forms.CheckBox()
        Me.FishFeederCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResWLLCheckBox = New System.Windows.Forms.CheckBox()
        Me.ResWLHCheckBox = New System.Windows.Forms.CheckBox()
        Me.PlantWLHCheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PlantWLHCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FishWLLCheckBox = New System.Windows.Forms.CheckBox()
        Me.FishWLHCheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte7CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte6CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte5CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte4CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte3CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte2CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte1CheckBox = New System.Windows.Forms.CheckBox()
        Me.ExtraByte0CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte7CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte6CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte5CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte4CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte3CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte2CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte1CheckBox = New System.Windows.Forms.CheckBox()
        Me.DigByte0CheckBox = New System.Windows.Forms.CheckBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.FishFoodAlertLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.FishFoodGroupBox.SuspendLayout()
        Me.ControlsGroupBox.SuspendLayout()
        Me.OtherGroupBox.SuspendLayout()
        Me.ChemicalsGroupBox.SuspendLayout()
        Me.TemperatureGroupBox.SuspendLayout()
        Me.LightSensorsGroupBox.SuspendLayout()
        Me.FlowMetersGroupBox.SuspendLayout()
        Me.WaterLevelsGroupBox.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.OutputStatesGroupBox.SuspendLayout()
        Me.TestGroupBox.SuspendLayout()
        Me.AnalogRangesGroupBox.SuspendLayout()
        Me.RecDigitalGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'SerialPort1
        '
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(2323, 1441)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FishFoodGroupBox)
        Me.TabPage1.Controls.Add(Me.ControlsGroupBox)
        Me.TabPage1.Controls.Add(Me.OtherGroupBox)
        Me.TabPage1.Controls.Add(Me.ChemicalsGroupBox)
        Me.TabPage1.Controls.Add(Me.TemperatureGroupBox)
        Me.TabPage1.Controls.Add(Me.LightSensorsGroupBox)
        Me.TabPage1.Controls.Add(Me.FlowMetersGroupBox)
        Me.TabPage1.Controls.Add(Me.WaterLevelsGroupBox)
        Me.TabPage1.Location = New System.Drawing.Point(10, 48)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(2303, 1383)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MAIN"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FishFoodGroupBox
        '
        Me.FishFoodGroupBox.Controls.Add(Me.FishFoodAlertLabel)
        Me.FishFoodGroupBox.Controls.Add(Me.FeedAgainCheckBox)
        Me.FishFoodGroupBox.Controls.Add(Me.SaveTimeButton)
        Me.FishFoodGroupBox.Controls.Add(Me.FishFoodButton)
        Me.FishFoodGroupBox.Controls.Add(Me.FishFoodLabel)
        Me.FishFoodGroupBox.Controls.Add(Me.FoodTimeTextBox)
        Me.FishFoodGroupBox.Location = New System.Drawing.Point(1272, 788)
        Me.FishFoodGroupBox.Name = "FishFoodGroupBox"
        Me.FishFoodGroupBox.Size = New System.Drawing.Size(605, 319)
        Me.FishFoodGroupBox.TabIndex = 36
        Me.FishFoodGroupBox.TabStop = False
        Me.FishFoodGroupBox.Text = "FISH FOOD"
        '
        'FeedAgainCheckBox
        '
        Me.FeedAgainCheckBox.AutoSize = True
        Me.FeedAgainCheckBox.Location = New System.Drawing.Point(34, 161)
        Me.FeedAgainCheckBox.Name = "FeedAgainCheckBox"
        Me.FeedAgainCheckBox.Size = New System.Drawing.Size(222, 36)
        Me.FeedAgainCheckBox.TabIndex = 36
        Me.FeedAgainCheckBox.Text = "FEED AGAIN"
        Me.FeedAgainCheckBox.UseVisualStyleBackColor = True
        '
        'SaveTimeButton
        '
        Me.SaveTimeButton.BackColor = System.Drawing.Color.Transparent
        Me.SaveTimeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SaveTimeButton.Location = New System.Drawing.Point(366, 117)
        Me.SaveTimeButton.Name = "SaveTimeButton"
        Me.SaveTimeButton.Size = New System.Drawing.Size(219, 54)
        Me.SaveTimeButton.TabIndex = 2
        Me.SaveTimeButton.TabStop = False
        Me.SaveTimeButton.Text = "SAVE TIME"
        Me.SaveTimeButton.UseVisualStyleBackColor = False
        '
        'FishFoodButton
        '
        Me.FishFoodButton.BackColor = System.Drawing.Color.Gray
        Me.FishFoodButton.Enabled = False
        Me.FishFoodButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.9!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishFoodButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishFoodButton.Location = New System.Drawing.Point(58, 222)
        Me.FishFoodButton.Name = "FishFoodButton"
        Me.FishFoodButton.Size = New System.Drawing.Size(462, 64)
        Me.FishFoodButton.TabIndex = 35
        Me.FishFoodButton.TabStop = False
        Me.FishFoodButton.Text = "NOT FED TODAY"
        Me.FishFoodButton.UseVisualStyleBackColor = False
        '
        'FishFoodLabel
        '
        Me.FishFoodLabel.AutoSize = True
        Me.FishFoodLabel.Location = New System.Drawing.Point(14, 49)
        Me.FishFoodLabel.Name = "FishFoodLabel"
        Me.FishFoodLabel.Size = New System.Drawing.Size(382, 32)
        Me.FishFoodLabel.TabIndex = 34
        Me.FishFoodLabel.Text = "FISH FOOD MILITARY TIME:"
        '
        'FoodTimeTextBox
        '
        Me.FoodTimeTextBox.Location = New System.Drawing.Point(414, 49)
        Me.FoodTimeTextBox.Name = "FoodTimeTextBox"
        Me.FoodTimeTextBox.Size = New System.Drawing.Size(171, 38)
        Me.FoodTimeTextBox.TabIndex = 1
        Me.FoodTimeTextBox.TabStop = False
        Me.FoodTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ControlsGroupBox
        '
        Me.ControlsGroupBox.Controls.Add(Me.FishFeederControlLabel)
        Me.ControlsGroupBox.Controls.Add(Me.FishFeederMainButton)
        Me.ControlsGroupBox.Controls.Add(Me.FishDisplayLightButton)
        Me.ControlsGroupBox.Controls.Add(Me.GrowLightLabel)
        Me.ControlsGroupBox.Controls.Add(Me.FishDisplayLightLabel)
        Me.ControlsGroupBox.Controls.Add(Me.GrowLightButton)
        Me.ControlsGroupBox.Location = New System.Drawing.Point(760, 720)
        Me.ControlsGroupBox.Name = "ControlsGroupBox"
        Me.ControlsGroupBox.Size = New System.Drawing.Size(468, 287)
        Me.ControlsGroupBox.TabIndex = 32
        Me.ControlsGroupBox.TabStop = False
        Me.ControlsGroupBox.Text = "CONTROLS"
        '
        'FishFeederControlLabel
        '
        Me.FishFeederControlLabel.AutoSize = True
        Me.FishFeederControlLabel.Location = New System.Drawing.Point(117, 219)
        Me.FishFeederControlLabel.Name = "FishFeederControlLabel"
        Me.FishFeederControlLabel.Size = New System.Drawing.Size(207, 32)
        Me.FishFeederControlLabel.TabIndex = 32
        Me.FishFeederControlLabel.Text = "FISH FEEDER:"
        '
        'FishFeederMainButton
        '
        Me.FishFeederMainButton.BackColor = System.Drawing.Color.Green
        Me.FishFeederMainButton.Location = New System.Drawing.Point(358, 205)
        Me.FishFeederMainButton.Name = "FishFeederMainButton"
        Me.FishFeederMainButton.Size = New System.Drawing.Size(96, 60)
        Me.FishFeederMainButton.TabIndex = 33
        Me.FishFeederMainButton.TabStop = False
        Me.FishFeederMainButton.Text = "ON"
        Me.FishFeederMainButton.UseVisualStyleBackColor = False
        '
        'FishDisplayLightButton
        '
        Me.FishDisplayLightButton.BackColor = System.Drawing.Color.Green
        Me.FishDisplayLightButton.Location = New System.Drawing.Point(358, 44)
        Me.FishDisplayLightButton.Name = "FishDisplayLightButton"
        Me.FishDisplayLightButton.Size = New System.Drawing.Size(96, 60)
        Me.FishDisplayLightButton.TabIndex = 29
        Me.FishDisplayLightButton.TabStop = False
        Me.FishDisplayLightButton.Text = "ON"
        Me.FishDisplayLightButton.UseVisualStyleBackColor = False
        '
        'GrowLightLabel
        '
        Me.GrowLightLabel.AutoSize = True
        Me.GrowLightLabel.Location = New System.Drawing.Point(117, 135)
        Me.GrowLightLabel.Name = "GrowLightLabel"
        Me.GrowLightLabel.Size = New System.Drawing.Size(221, 32)
        Me.GrowLightLabel.TabIndex = 30
        Me.GrowLightLabel.Text = "GROW LIGHTS:"
        '
        'FishDisplayLightLabel
        '
        Me.FishDisplayLightLabel.AutoSize = True
        Me.FishDisplayLightLabel.Location = New System.Drawing.Point(17, 59)
        Me.FishDisplayLightLabel.Name = "FishDisplayLightLabel"
        Me.FishDisplayLightLabel.Size = New System.Drawing.Size(321, 32)
        Me.FishDisplayLightLabel.TabIndex = 6
        Me.FishDisplayLightLabel.Text = "FISH/DISPLAY LIGHTS:"
        '
        'GrowLightButton
        '
        Me.GrowLightButton.BackColor = System.Drawing.Color.Green
        Me.GrowLightButton.Location = New System.Drawing.Point(358, 121)
        Me.GrowLightButton.Name = "GrowLightButton"
        Me.GrowLightButton.Size = New System.Drawing.Size(96, 60)
        Me.GrowLightButton.TabIndex = 31
        Me.GrowLightButton.TabStop = False
        Me.GrowLightButton.Text = "ON"
        Me.GrowLightButton.UseVisualStyleBackColor = False
        '
        'OtherGroupBox
        '
        Me.OtherGroupBox.Controls.Add(Me.FlowMeter5Button)
        Me.OtherGroupBox.Controls.Add(Me.Flowmeter5Label)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEX2TextBox)
        Me.OtherGroupBox.Controls.Add(Me.DigitalEX3Button)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEX1TextBox)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEX2Button)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEX1Button)
        Me.OtherGroupBox.Controls.Add(Me.DigitalEx3Label)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEx2Label)
        Me.OtherGroupBox.Controls.Add(Me.AnalogEx1Label)
        Me.OtherGroupBox.Controls.Add(Me.DigitalEX2Button)
        Me.OtherGroupBox.Controls.Add(Me.CommButton)
        Me.OtherGroupBox.Controls.Add(Me.DigitalEx2Label)
        Me.OtherGroupBox.Controls.Add(Me.MotionButton)
        Me.OtherGroupBox.Controls.Add(Me.CommLabel)
        Me.OtherGroupBox.Controls.Add(Me.DigitalEX1Button)
        Me.OtherGroupBox.Controls.Add(Me.DigitalExLabel)
        Me.OtherGroupBox.Controls.Add(Me.MotionLabel)
        Me.OtherGroupBox.Location = New System.Drawing.Point(1272, 55)
        Me.OtherGroupBox.Name = "OtherGroupBox"
        Me.OtherGroupBox.Size = New System.Drawing.Size(659, 727)
        Me.OtherGroupBox.TabIndex = 0
        Me.OtherGroupBox.TabStop = False
        Me.OtherGroupBox.Text = "OTHER:"
        '
        'FlowMeter5Button
        '
        Me.FlowMeter5Button.BackColor = System.Drawing.Color.Green
        Me.FlowMeter5Button.Enabled = False
        Me.FlowMeter5Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowMeter5Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowMeter5Button.Location = New System.Drawing.Point(456, 480)
        Me.FlowMeter5Button.Name = "FlowMeter5Button"
        Me.FlowMeter5Button.Size = New System.Drawing.Size(186, 64)
        Me.FlowMeter5Button.TabIndex = 18
        Me.FlowMeter5Button.TabStop = False
        Me.FlowMeter5Button.Text = "GOOD"
        Me.FlowMeter5Button.UseVisualStyleBackColor = False
        '
        'Flowmeter5Label
        '
        Me.Flowmeter5Label.AutoSize = True
        Me.Flowmeter5Label.Location = New System.Drawing.Point(104, 495)
        Me.Flowmeter5Label.Name = "Flowmeter5Label"
        Me.Flowmeter5Label.Size = New System.Drawing.Size(333, 32)
        Me.Flowmeter5Label.TabIndex = 17
        Me.Flowmeter5Label.Text = "FLOW METER 5 EXTRA:"
        '
        'AnalogEX2TextBox
        '
        Me.AnalogEX2TextBox.Location = New System.Drawing.Point(283, 656)
        Me.AnalogEX2TextBox.Name = "AnalogEX2TextBox"
        Me.AnalogEX2TextBox.Size = New System.Drawing.Size(148, 38)
        Me.AnalogEX2TextBox.TabIndex = 14
        Me.AnalogEX2TextBox.TabStop = False
        Me.AnalogEX2TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DigitalEX3Button
        '
        Me.DigitalEX3Button.BackColor = System.Drawing.Color.Green
        Me.DigitalEX3Button.Enabled = False
        Me.DigitalEX3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalEX3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DigitalEX3Button.Location = New System.Drawing.Point(456, 400)
        Me.DigitalEX3Button.Name = "DigitalEX3Button"
        Me.DigitalEX3Button.Size = New System.Drawing.Size(186, 64)
        Me.DigitalEX3Button.TabIndex = 16
        Me.DigitalEX3Button.TabStop = False
        Me.DigitalEX3Button.Text = "GOOD"
        Me.DigitalEX3Button.UseVisualStyleBackColor = False
        '
        'AnalogEX1TextBox
        '
        Me.AnalogEX1TextBox.Location = New System.Drawing.Point(283, 575)
        Me.AnalogEX1TextBox.Name = "AnalogEX1TextBox"
        Me.AnalogEX1TextBox.Size = New System.Drawing.Size(148, 38)
        Me.AnalogEX1TextBox.TabIndex = 13
        Me.AnalogEX1TextBox.TabStop = False
        Me.AnalogEX1TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AnalogEX2Button
        '
        Me.AnalogEX2Button.BackColor = System.Drawing.Color.Green
        Me.AnalogEX2Button.Enabled = False
        Me.AnalogEX2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogEX2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AnalogEX2Button.Location = New System.Drawing.Point(456, 637)
        Me.AnalogEX2Button.Name = "AnalogEX2Button"
        Me.AnalogEX2Button.Size = New System.Drawing.Size(186, 64)
        Me.AnalogEX2Button.TabIndex = 11
        Me.AnalogEX2Button.TabStop = False
        Me.AnalogEX2Button.Text = "GOOD"
        Me.AnalogEX2Button.UseVisualStyleBackColor = False
        '
        'AnalogEX1Button
        '
        Me.AnalogEX1Button.BackColor = System.Drawing.Color.Green
        Me.AnalogEX1Button.Enabled = False
        Me.AnalogEX1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnalogEX1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AnalogEX1Button.Location = New System.Drawing.Point(456, 560)
        Me.AnalogEX1Button.Name = "AnalogEX1Button"
        Me.AnalogEX1Button.Size = New System.Drawing.Size(186, 64)
        Me.AnalogEX1Button.TabIndex = 10
        Me.AnalogEX1Button.TabStop = False
        Me.AnalogEX1Button.Text = "GOOD"
        Me.AnalogEX1Button.UseVisualStyleBackColor = False
        '
        'DigitalEx3Label
        '
        Me.DigitalEx3Label.AutoSize = True
        Me.DigitalEx3Label.Location = New System.Drawing.Point(182, 418)
        Me.DigitalEx3Label.Name = "DigitalEx3Label"
        Me.DigitalEx3Label.Size = New System.Drawing.Size(255, 32)
        Me.DigitalEx3Label.TabIndex = 15
        Me.DigitalEx3Label.Text = "DIGITAL EXTRA 3:"
        '
        'AnalogEx2Label
        '
        Me.AnalogEx2Label.AutoSize = True
        Me.AnalogEx2Label.Location = New System.Drawing.Point(12, 659)
        Me.AnalogEx2Label.Name = "AnalogEx2Label"
        Me.AnalogEx2Label.Size = New System.Drawing.Size(265, 32)
        Me.AnalogEx2Label.TabIndex = 8
        Me.AnalogEx2Label.Text = "ANALOG EXTRA 2:"
        '
        'AnalogEx1Label
        '
        Me.AnalogEx1Label.AutoSize = True
        Me.AnalogEx1Label.Location = New System.Drawing.Point(12, 578)
        Me.AnalogEx1Label.Name = "AnalogEx1Label"
        Me.AnalogEx1Label.Size = New System.Drawing.Size(265, 32)
        Me.AnalogEx1Label.TabIndex = 7
        Me.AnalogEx1Label.Text = "ANALOG EXTRA 1:"
        '
        'DigitalEX2Button
        '
        Me.DigitalEX2Button.BackColor = System.Drawing.Color.Green
        Me.DigitalEX2Button.Enabled = False
        Me.DigitalEX2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalEX2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DigitalEX2Button.Location = New System.Drawing.Point(456, 317)
        Me.DigitalEX2Button.Name = "DigitalEX2Button"
        Me.DigitalEX2Button.Size = New System.Drawing.Size(186, 64)
        Me.DigitalEX2Button.TabIndex = 14
        Me.DigitalEX2Button.TabStop = False
        Me.DigitalEX2Button.Text = "GOOD"
        Me.DigitalEX2Button.UseVisualStyleBackColor = False
        '
        'CommButton
        '
        Me.CommButton.BackColor = System.Drawing.Color.Green
        Me.CommButton.Enabled = False
        Me.CommButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CommButton.Location = New System.Drawing.Point(456, 154)
        Me.CommButton.Name = "CommButton"
        Me.CommButton.Size = New System.Drawing.Size(186, 64)
        Me.CommButton.TabIndex = 6
        Me.CommButton.TabStop = False
        Me.CommButton.Text = "GOOD"
        Me.CommButton.UseVisualStyleBackColor = False
        '
        'DigitalEx2Label
        '
        Me.DigitalEx2Label.AutoSize = True
        Me.DigitalEx2Label.Location = New System.Drawing.Point(182, 335)
        Me.DigitalEx2Label.Name = "DigitalEx2Label"
        Me.DigitalEx2Label.Size = New System.Drawing.Size(255, 32)
        Me.DigitalEx2Label.TabIndex = 13
        Me.DigitalEx2Label.Text = "DIGITAL EXTRA 2:"
        '
        'MotionButton
        '
        Me.MotionButton.BackColor = System.Drawing.Color.Gray
        Me.MotionButton.Enabled = False
        Me.MotionButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MotionButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MotionButton.Location = New System.Drawing.Point(348, 71)
        Me.MotionButton.Name = "MotionButton"
        Me.MotionButton.Size = New System.Drawing.Size(294, 64)
        Me.MotionButton.TabIndex = 4
        Me.MotionButton.TabStop = False
        Me.MotionButton.Text = "NO MOTION"
        Me.MotionButton.UseVisualStyleBackColor = False
        '
        'CommLabel
        '
        Me.CommLabel.AutoSize = True
        Me.CommLabel.Location = New System.Drawing.Point(174, 172)
        Me.CommLabel.Name = "CommLabel"
        Me.CommLabel.Size = New System.Drawing.Size(263, 32)
        Me.CommLabel.TabIndex = 3
        Me.CommLabel.Text = "COMMUNICATION:"
        '
        'DigitalEX1Button
        '
        Me.DigitalEX1Button.BackColor = System.Drawing.Color.Green
        Me.DigitalEX1Button.Enabled = False
        Me.DigitalEX1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DigitalEX1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DigitalEX1Button.Location = New System.Drawing.Point(456, 230)
        Me.DigitalEX1Button.Name = "DigitalEX1Button"
        Me.DigitalEX1Button.Size = New System.Drawing.Size(186, 64)
        Me.DigitalEX1Button.TabIndex = 12
        Me.DigitalEX1Button.TabStop = False
        Me.DigitalEX1Button.Text = "GOOD"
        Me.DigitalEX1Button.UseVisualStyleBackColor = False
        '
        'DigitalExLabel
        '
        Me.DigitalExLabel.AutoSize = True
        Me.DigitalExLabel.Location = New System.Drawing.Point(182, 248)
        Me.DigitalExLabel.Name = "DigitalExLabel"
        Me.DigitalExLabel.Size = New System.Drawing.Size(255, 32)
        Me.DigitalExLabel.TabIndex = 9
        Me.DigitalExLabel.Text = "DIGITAL EXTRA 1:"
        '
        'MotionLabel
        '
        Me.MotionLabel.AutoSize = True
        Me.MotionLabel.Location = New System.Drawing.Point(189, 89)
        Me.MotionLabel.Name = "MotionLabel"
        Me.MotionLabel.Size = New System.Drawing.Size(134, 32)
        Me.MotionLabel.TabIndex = 1
        Me.MotionLabel.Text = "MOTION:"
        '
        'ChemicalsGroupBox
        '
        Me.ChemicalsGroupBox.Controls.Add(Me.ConductTextBox)
        Me.ChemicalsGroupBox.Controls.Add(Me.ConductButton)
        Me.ChemicalsGroupBox.Controls.Add(Me.ConductLabel)
        Me.ChemicalsGroupBox.Controls.Add(Me.DisposeTextBox)
        Me.ChemicalsGroupBox.Controls.Add(Me.FishPHTextBox)
        Me.ChemicalsGroupBox.Controls.Add(Me.PlantPHTextBox)
        Me.ChemicalsGroupBox.Controls.Add(Me.DisposeButton)
        Me.ChemicalsGroupBox.Controls.Add(Me.FishPHButton)
        Me.ChemicalsGroupBox.Controls.Add(Me.PlantPHButton)
        Me.ChemicalsGroupBox.Controls.Add(Me.DisposeLabel)
        Me.ChemicalsGroupBox.Controls.Add(Me.FishPHLabel)
        Me.ChemicalsGroupBox.Controls.Add(Me.PlantPHLabel)
        Me.ChemicalsGroupBox.Location = New System.Drawing.Point(16, 495)
        Me.ChemicalsGroupBox.Name = "ChemicalsGroupBox"
        Me.ChemicalsGroupBox.Size = New System.Drawing.Size(727, 409)
        Me.ChemicalsGroupBox.TabIndex = 27
        Me.ChemicalsGroupBox.TabStop = False
        Me.ChemicalsGroupBox.Text = "CHEMICALS:"
        '
        'ConductTextBox
        '
        Me.ConductTextBox.Location = New System.Drawing.Point(342, 321)
        Me.ConductTextBox.Name = "ConductTextBox"
        Me.ConductTextBox.Size = New System.Drawing.Size(148, 38)
        Me.ConductTextBox.TabIndex = 12
        Me.ConductTextBox.TabStop = False
        Me.ConductTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ConductButton
        '
        Me.ConductButton.BackColor = System.Drawing.Color.Green
        Me.ConductButton.Enabled = False
        Me.ConductButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConductButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ConductButton.Location = New System.Drawing.Point(513, 309)
        Me.ConductButton.Name = "ConductButton"
        Me.ConductButton.Size = New System.Drawing.Size(186, 64)
        Me.ConductButton.TabIndex = 11
        Me.ConductButton.TabStop = False
        Me.ConductButton.Text = "GOOD"
        Me.ConductButton.UseVisualStyleBackColor = False
        '
        'ConductLabel
        '
        Me.ConductLabel.AutoSize = True
        Me.ConductLabel.Location = New System.Drawing.Point(105, 327)
        Me.ConductLabel.Name = "ConductLabel"
        Me.ConductLabel.Size = New System.Drawing.Size(231, 32)
        Me.ConductLabel.TabIndex = 10
        Me.ConductLabel.Text = "CONDUCTIVITY:"
        '
        'DisposeTextBox
        '
        Me.DisposeTextBox.Location = New System.Drawing.Point(342, 237)
        Me.DisposeTextBox.Name = "DisposeTextBox"
        Me.DisposeTextBox.Size = New System.Drawing.Size(148, 38)
        Me.DisposeTextBox.TabIndex = 9
        Me.DisposeTextBox.TabStop = False
        Me.DisposeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FishPHTextBox
        '
        Me.FishPHTextBox.Location = New System.Drawing.Point(342, 150)
        Me.FishPHTextBox.Name = "FishPHTextBox"
        Me.FishPHTextBox.Size = New System.Drawing.Size(148, 38)
        Me.FishPHTextBox.TabIndex = 8
        Me.FishPHTextBox.TabStop = False
        Me.FishPHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PlantPHTextBox
        '
        Me.PlantPHTextBox.Location = New System.Drawing.Point(342, 67)
        Me.PlantPHTextBox.Name = "PlantPHTextBox"
        Me.PlantPHTextBox.Size = New System.Drawing.Size(148, 38)
        Me.PlantPHTextBox.TabIndex = 7
        Me.PlantPHTextBox.TabStop = False
        Me.PlantPHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DisposeButton
        '
        Me.DisposeButton.BackColor = System.Drawing.Color.Green
        Me.DisposeButton.Enabled = False
        Me.DisposeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisposeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DisposeButton.Location = New System.Drawing.Point(513, 225)
        Me.DisposeButton.Name = "DisposeButton"
        Me.DisposeButton.Size = New System.Drawing.Size(186, 64)
        Me.DisposeButton.TabIndex = 6
        Me.DisposeButton.TabStop = False
        Me.DisposeButton.Text = "GOOD"
        Me.DisposeButton.UseVisualStyleBackColor = False
        '
        'FishPHButton
        '
        Me.FishPHButton.BackColor = System.Drawing.Color.Green
        Me.FishPHButton.Enabled = False
        Me.FishPHButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishPHButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishPHButton.Location = New System.Drawing.Point(513, 138)
        Me.FishPHButton.Name = "FishPHButton"
        Me.FishPHButton.Size = New System.Drawing.Size(186, 64)
        Me.FishPHButton.TabIndex = 5
        Me.FishPHButton.TabStop = False
        Me.FishPHButton.Text = "GOOD"
        Me.FishPHButton.UseVisualStyleBackColor = False
        '
        'PlantPHButton
        '
        Me.PlantPHButton.BackColor = System.Drawing.Color.Green
        Me.PlantPHButton.Enabled = False
        Me.PlantPHButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlantPHButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlantPHButton.Location = New System.Drawing.Point(513, 55)
        Me.PlantPHButton.Name = "PlantPHButton"
        Me.PlantPHButton.Size = New System.Drawing.Size(186, 64)
        Me.PlantPHButton.TabIndex = 4
        Me.PlantPHButton.TabStop = False
        Me.PlantPHButton.Text = "GOOD"
        Me.PlantPHButton.UseVisualStyleBackColor = False
        '
        'DisposeLabel
        '
        Me.DisposeLabel.AutoSize = True
        Me.DisposeLabel.Location = New System.Drawing.Point(24, 243)
        Me.DisposeLabel.Name = "DisposeLabel"
        Me.DisposeLabel.Size = New System.Drawing.Size(312, 32)
        Me.DisposeLabel.TabIndex = 3
        Me.DisposeLabel.Text = "DISPOSABLE SOLIDS:"
        '
        'FishPHLabel
        '
        Me.FishPHLabel.AutoSize = True
        Me.FishPHLabel.Location = New System.Drawing.Point(122, 156)
        Me.FishPHLabel.Name = "FishPHLabel"
        Me.FishPHLabel.Size = New System.Drawing.Size(214, 32)
        Me.FishPHLabel.TabIndex = 2
        Me.FishPHLabel.Text = "FISH TANK PH:"
        '
        'PlantPHLabel
        '
        Me.PlantPHLabel.AutoSize = True
        Me.PlantPHLabel.Location = New System.Drawing.Point(111, 73)
        Me.PlantPHLabel.Name = "PlantPHLabel"
        Me.PlantPHLabel.Size = New System.Drawing.Size(225, 32)
        Me.PlantPHLabel.TabIndex = 1
        Me.PlantPHLabel.Text = "PLANT BED PH:"
        '
        'TemperatureGroupBox
        '
        Me.TemperatureGroupBox.Controls.Add(Me.ResTempTextBox)
        Me.TemperatureGroupBox.Controls.Add(Me.FishTempTextBox)
        Me.TemperatureGroupBox.Controls.Add(Me.ResTempButton)
        Me.TemperatureGroupBox.Controls.Add(Me.FishTempButton)
        Me.TemperatureGroupBox.Controls.Add(Me.ResTempLabel)
        Me.TemperatureGroupBox.Controls.Add(Me.FishTempLabel)
        Me.TemperatureGroupBox.Location = New System.Drawing.Point(16, 910)
        Me.TemperatureGroupBox.Name = "TemperatureGroupBox"
        Me.TemperatureGroupBox.Size = New System.Drawing.Size(598, 235)
        Me.TemperatureGroupBox.TabIndex = 28
        Me.TemperatureGroupBox.TabStop = False
        Me.TemperatureGroupBox.Text = "TEMPERATURE:"
        '
        'ResTempTextBox
        '
        Me.ResTempTextBox.Location = New System.Drawing.Point(210, 145)
        Me.ResTempTextBox.Name = "ResTempTextBox"
        Me.ResTempTextBox.Size = New System.Drawing.Size(148, 38)
        Me.ResTempTextBox.TabIndex = 8
        Me.ResTempTextBox.TabStop = False
        Me.ResTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'FishTempTextBox
        '
        Me.FishTempTextBox.Location = New System.Drawing.Point(210, 58)
        Me.FishTempTextBox.Name = "FishTempTextBox"
        Me.FishTempTextBox.Size = New System.Drawing.Size(148, 38)
        Me.FishTempTextBox.TabIndex = 7
        Me.FishTempTextBox.TabStop = False
        Me.FishTempTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ResTempButton
        '
        Me.ResTempButton.BackColor = System.Drawing.Color.Green
        Me.ResTempButton.Enabled = False
        Me.ResTempButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResTempButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResTempButton.Location = New System.Drawing.Point(381, 133)
        Me.ResTempButton.Name = "ResTempButton"
        Me.ResTempButton.Size = New System.Drawing.Size(186, 64)
        Me.ResTempButton.TabIndex = 5
        Me.ResTempButton.TabStop = False
        Me.ResTempButton.Text = "GOOD"
        Me.ResTempButton.UseVisualStyleBackColor = False
        '
        'FishTempButton
        '
        Me.FishTempButton.BackColor = System.Drawing.Color.Green
        Me.FishTempButton.Enabled = False
        Me.FishTempButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishTempButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishTempButton.Location = New System.Drawing.Point(381, 43)
        Me.FishTempButton.Name = "FishTempButton"
        Me.FishTempButton.Size = New System.Drawing.Size(186, 64)
        Me.FishTempButton.TabIndex = 4
        Me.FishTempButton.TabStop = False
        Me.FishTempButton.Text = "GOOD"
        Me.FishTempButton.UseVisualStyleBackColor = False
        '
        'ResTempLabel
        '
        Me.ResTempLabel.AutoSize = True
        Me.ResTempLabel.Location = New System.Drawing.Point(16, 151)
        Me.ResTempLabel.Name = "ResTempLabel"
        Me.ResTempLabel.Size = New System.Drawing.Size(188, 32)
        Me.ResTempLabel.TabIndex = 2
        Me.ResTempLabel.Text = "RESERVOIR:"
        '
        'FishTempLabel
        '
        Me.FishTempLabel.AutoSize = True
        Me.FishTempLabel.Location = New System.Drawing.Point(36, 64)
        Me.FishTempLabel.Name = "FishTempLabel"
        Me.FishTempLabel.Size = New System.Drawing.Size(168, 32)
        Me.FishTempLabel.TabIndex = 1
        Me.FishTempLabel.Text = "FISH TANK:"
        '
        'LightSensorsGroupBox
        '
        Me.LightSensorsGroupBox.Controls.Add(Me.GrowLightSensorButton)
        Me.LightSensorsGroupBox.Controls.Add(Me.OutsideLightSensorButton)
        Me.LightSensorsGroupBox.Controls.Add(Me.GrowLightSensorLabel)
        Me.LightSensorsGroupBox.Controls.Add(Me.OutsideLightSensorLabel)
        Me.LightSensorsGroupBox.Location = New System.Drawing.Point(760, 495)
        Me.LightSensorsGroupBox.Name = "LightSensorsGroupBox"
        Me.LightSensorsGroupBox.Size = New System.Drawing.Size(495, 219)
        Me.LightSensorsGroupBox.TabIndex = 25
        Me.LightSensorsGroupBox.TabStop = False
        Me.LightSensorsGroupBox.Text = "LIGHT SENSORS:"
        '
        'GrowLightSensorButton
        '
        Me.GrowLightSensorButton.BackColor = System.Drawing.Color.Gray
        Me.GrowLightSensorButton.Enabled = False
        Me.GrowLightSensorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrowLightSensorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrowLightSensorButton.Location = New System.Drawing.Point(293, 132)
        Me.GrowLightSensorButton.Name = "GrowLightSensorButton"
        Me.GrowLightSensorButton.Size = New System.Drawing.Size(186, 64)
        Me.GrowLightSensorButton.TabIndex = 5
        Me.GrowLightSensorButton.TabStop = False
        Me.GrowLightSensorButton.Text = "DARK"
        Me.GrowLightSensorButton.UseVisualStyleBackColor = False
        '
        'OutsideLightSensorButton
        '
        Me.OutsideLightSensorButton.BackColor = System.Drawing.Color.Gray
        Me.OutsideLightSensorButton.Enabled = False
        Me.OutsideLightSensorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutsideLightSensorButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.OutsideLightSensorButton.Location = New System.Drawing.Point(293, 41)
        Me.OutsideLightSensorButton.Name = "OutsideLightSensorButton"
        Me.OutsideLightSensorButton.Size = New System.Drawing.Size(186, 64)
        Me.OutsideLightSensorButton.TabIndex = 4
        Me.OutsideLightSensorButton.TabStop = False
        Me.OutsideLightSensorButton.Text = "DARK"
        Me.OutsideLightSensorButton.UseVisualStyleBackColor = False
        '
        'GrowLightSensorLabel
        '
        Me.GrowLightSensorLabel.AutoSize = True
        Me.GrowLightSensorLabel.Location = New System.Drawing.Point(75, 150)
        Me.GrowLightSensorLabel.Name = "GrowLightSensorLabel"
        Me.GrowLightSensorLabel.Size = New System.Drawing.Size(195, 32)
        Me.GrowLightSensorLabel.TabIndex = 2
        Me.GrowLightSensorLabel.Text = "GROWLIGHT:"
        '
        'OutsideLightSensorLabel
        '
        Me.OutsideLightSensorLabel.AutoSize = True
        Me.OutsideLightSensorLabel.Location = New System.Drawing.Point(34, 59)
        Me.OutsideLightSensorLabel.Name = "OutsideLightSensorLabel"
        Me.OutsideLightSensorLabel.Size = New System.Drawing.Size(236, 32)
        Me.OutsideLightSensorLabel.TabIndex = 1
        Me.OutsideLightSensorLabel.Text = "OUTSIDE LIGHT:"
        '
        'FlowMetersGroupBox
        '
        Me.FlowMetersGroupBox.Controls.Add(Me.FlowMeter4Button)
        Me.FlowMetersGroupBox.Controls.Add(Me.Flowmeter4Label)
        Me.FlowMetersGroupBox.Controls.Add(Me.FlowMeter3Button)
        Me.FlowMetersGroupBox.Controls.Add(Me.FlowMeter2Button)
        Me.FlowMetersGroupBox.Controls.Add(Me.FlowMeter1Button)
        Me.FlowMetersGroupBox.Controls.Add(Me.Flowmeter3Label)
        Me.FlowMetersGroupBox.Controls.Add(Me.Flowmeter2Label)
        Me.FlowMetersGroupBox.Controls.Add(Me.Flowmeter1Label)
        Me.FlowMetersGroupBox.Location = New System.Drawing.Point(760, 55)
        Me.FlowMetersGroupBox.Name = "FlowMetersGroupBox"
        Me.FlowMetersGroupBox.Size = New System.Drawing.Size(495, 434)
        Me.FlowMetersGroupBox.TabIndex = 26
        Me.FlowMetersGroupBox.TabStop = False
        Me.FlowMetersGroupBox.Text = "FLOW METERS:"
        '
        'FlowMeter4Button
        '
        Me.FlowMeter4Button.BackColor = System.Drawing.Color.Green
        Me.FlowMeter4Button.Enabled = False
        Me.FlowMeter4Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowMeter4Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowMeter4Button.Location = New System.Drawing.Point(285, 337)
        Me.FlowMeter4Button.Name = "FlowMeter4Button"
        Me.FlowMeter4Button.Size = New System.Drawing.Size(186, 64)
        Me.FlowMeter4Button.TabIndex = 11
        Me.FlowMeter4Button.TabStop = False
        Me.FlowMeter4Button.Text = "GOOD"
        Me.FlowMeter4Button.UseVisualStyleBackColor = False
        '
        'Flowmeter4Label
        '
        Me.Flowmeter4Label.AutoSize = True
        Me.Flowmeter4Label.Location = New System.Drawing.Point(8, 355)
        Me.Flowmeter4Label.Name = "Flowmeter4Label"
        Me.Flowmeter4Label.Size = New System.Drawing.Size(254, 32)
        Me.Flowmeter4Label.TabIndex = 10
        Me.Flowmeter4Label.Text = "RESERVOIR OUT:"
        '
        'FlowMeter3Button
        '
        Me.FlowMeter3Button.BackColor = System.Drawing.Color.Green
        Me.FlowMeter3Button.Enabled = False
        Me.FlowMeter3Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowMeter3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowMeter3Button.Location = New System.Drawing.Point(285, 253)
        Me.FlowMeter3Button.Name = "FlowMeter3Button"
        Me.FlowMeter3Button.Size = New System.Drawing.Size(186, 64)
        Me.FlowMeter3Button.TabIndex = 6
        Me.FlowMeter3Button.TabStop = False
        Me.FlowMeter3Button.Text = "GOOD"
        Me.FlowMeter3Button.UseVisualStyleBackColor = False
        '
        'FlowMeter2Button
        '
        Me.FlowMeter2Button.BackColor = System.Drawing.Color.Green
        Me.FlowMeter2Button.Enabled = False
        Me.FlowMeter2Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowMeter2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowMeter2Button.Location = New System.Drawing.Point(285, 166)
        Me.FlowMeter2Button.Name = "FlowMeter2Button"
        Me.FlowMeter2Button.Size = New System.Drawing.Size(186, 64)
        Me.FlowMeter2Button.TabIndex = 5
        Me.FlowMeter2Button.TabStop = False
        Me.FlowMeter2Button.Text = "GOOD"
        Me.FlowMeter2Button.UseVisualStyleBackColor = False
        '
        'FlowMeter1Button
        '
        Me.FlowMeter1Button.BackColor = System.Drawing.Color.Green
        Me.FlowMeter1Button.Enabled = False
        Me.FlowMeter1Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowMeter1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FlowMeter1Button.Location = New System.Drawing.Point(285, 83)
        Me.FlowMeter1Button.Name = "FlowMeter1Button"
        Me.FlowMeter1Button.Size = New System.Drawing.Size(186, 64)
        Me.FlowMeter1Button.TabIndex = 4
        Me.FlowMeter1Button.TabStop = False
        Me.FlowMeter1Button.Text = "GOOD"
        Me.FlowMeter1Button.UseVisualStyleBackColor = False
        '
        'Flowmeter3Label
        '
        Me.Flowmeter3Label.AutoSize = True
        Me.Flowmeter3Label.Location = New System.Drawing.Point(8, 271)
        Me.Flowmeter3Label.Name = "Flowmeter3Label"
        Me.Flowmeter3Label.Size = New System.Drawing.Size(254, 32)
        Me.Flowmeter3Label.TabIndex = 3
        Me.Flowmeter3Label.Text = "RESERVOIR OUT:"
        '
        'Flowmeter2Label
        '
        Me.Flowmeter2Label.AutoSize = True
        Me.Flowmeter2Label.Location = New System.Drawing.Point(40, 184)
        Me.Flowmeter2Label.Name = "Flowmeter2Label"
        Me.Flowmeter2Label.Size = New System.Drawing.Size(222, 32)
        Me.Flowmeter2Label.TabIndex = 2
        Me.Flowmeter2Label.Text = "RESERVOIR IN:"
        '
        'Flowmeter1Label
        '
        Me.Flowmeter1Label.AutoSize = True
        Me.Flowmeter1Label.Location = New System.Drawing.Point(28, 101)
        Me.Flowmeter1Label.Name = "Flowmeter1Label"
        Me.Flowmeter1Label.Size = New System.Drawing.Size(234, 32)
        Me.Flowmeter1Label.TabIndex = 1
        Me.Flowmeter1Label.Text = "FISH TANK OUT:"
        '
        'WaterLevelsGroupBox
        '
        Me.WaterLevelsGroupBox.Controls.Add(Me.ResWLLButton)
        Me.WaterLevelsGroupBox.Controls.Add(Me.FishWLLButton)
        Me.WaterLevelsGroupBox.Controls.Add(Me.PlantWLHButton2)
        Me.WaterLevelsGroupBox.Controls.Add(Me.WLLowLabel)
        Me.WaterLevelsGroupBox.Controls.Add(Me.WLHighLabel)
        Me.WaterLevelsGroupBox.Controls.Add(Me.ResWLHButton)
        Me.WaterLevelsGroupBox.Controls.Add(Me.PlantWLHButton1)
        Me.WaterLevelsGroupBox.Controls.Add(Me.FishWLHButton)
        Me.WaterLevelsGroupBox.Controls.Add(Me.ResWLLabel)
        Me.WaterLevelsGroupBox.Controls.Add(Me.PlantWLLabel)
        Me.WaterLevelsGroupBox.Controls.Add(Me.FishWLLabel)
        Me.WaterLevelsGroupBox.Location = New System.Drawing.Point(16, 55)
        Me.WaterLevelsGroupBox.Name = "WaterLevelsGroupBox"
        Me.WaterLevelsGroupBox.Size = New System.Drawing.Size(727, 434)
        Me.WaterLevelsGroupBox.TabIndex = 23
        Me.WaterLevelsGroupBox.TabStop = False
        Me.WaterLevelsGroupBox.Text = "WATER LEVELS:"
        '
        'ResWLLButton
        '
        Me.ResWLLButton.BackColor = System.Drawing.Color.Green
        Me.ResWLLButton.Enabled = False
        Me.ResWLLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResWLLButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResWLLButton.Location = New System.Drawing.Point(506, 341)
        Me.ResWLLButton.Name = "ResWLLButton"
        Me.ResWLLButton.Size = New System.Drawing.Size(186, 64)
        Me.ResWLLButton.TabIndex = 11
        Me.ResWLLButton.TabStop = False
        Me.ResWLLButton.Text = "GOOD"
        Me.ResWLLButton.UseVisualStyleBackColor = False
        '
        'FishWLLButton
        '
        Me.FishWLLButton.BackColor = System.Drawing.Color.Green
        Me.FishWLLButton.Enabled = False
        Me.FishWLLButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishWLLButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishWLLButton.Location = New System.Drawing.Point(506, 83)
        Me.FishWLLButton.Name = "FishWLLButton"
        Me.FishWLLButton.Size = New System.Drawing.Size(186, 64)
        Me.FishWLLButton.TabIndex = 10
        Me.FishWLLButton.TabStop = False
        Me.FishWLLButton.Text = "GOOD"
        Me.FishWLLButton.UseVisualStyleBackColor = False
        '
        'PlantWLHButton2
        '
        Me.PlantWLHButton2.BackColor = System.Drawing.Color.Green
        Me.PlantWLHButton2.Enabled = False
        Me.PlantWLHButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlantWLHButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlantWLHButton2.Location = New System.Drawing.Point(294, 257)
        Me.PlantWLHButton2.Name = "PlantWLHButton2"
        Me.PlantWLHButton2.Size = New System.Drawing.Size(186, 64)
        Me.PlantWLHButton2.TabIndex = 9
        Me.PlantWLHButton2.TabStop = False
        Me.PlantWLHButton2.Text = "GOOD"
        Me.PlantWLHButton2.UseVisualStyleBackColor = False
        '
        'WLLowLabel
        '
        Me.WLLowLabel.AutoSize = True
        Me.WLLowLabel.Location = New System.Drawing.Point(528, 34)
        Me.WLLowLabel.Name = "WLLowLabel"
        Me.WLLowLabel.Size = New System.Drawing.Size(128, 32)
        Me.WLLowLabel.TabIndex = 8
        Me.WLLowLabel.Text = "WL LOW"
        '
        'WLHighLabel
        '
        Me.WLHighLabel.AutoSize = True
        Me.WLHighLabel.Location = New System.Drawing.Point(320, 34)
        Me.WLHighLabel.Name = "WLHighLabel"
        Me.WLHighLabel.Size = New System.Drawing.Size(133, 32)
        Me.WLHighLabel.TabIndex = 7
        Me.WLHighLabel.Text = "WL HIGH"
        '
        'ResWLHButton
        '
        Me.ResWLHButton.BackColor = System.Drawing.Color.Green
        Me.ResWLHButton.Enabled = False
        Me.ResWLHButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResWLHButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResWLHButton.Location = New System.Drawing.Point(294, 341)
        Me.ResWLHButton.Name = "ResWLHButton"
        Me.ResWLHButton.Size = New System.Drawing.Size(186, 64)
        Me.ResWLHButton.TabIndex = 6
        Me.ResWLHButton.TabStop = False
        Me.ResWLHButton.Text = "GOOD"
        Me.ResWLHButton.UseVisualStyleBackColor = False
        '
        'PlantWLHButton1
        '
        Me.PlantWLHButton1.BackColor = System.Drawing.Color.Green
        Me.PlantWLHButton1.Enabled = False
        Me.PlantWLHButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlantWLHButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PlantWLHButton1.Location = New System.Drawing.Point(294, 166)
        Me.PlantWLHButton1.Name = "PlantWLHButton1"
        Me.PlantWLHButton1.Size = New System.Drawing.Size(186, 64)
        Me.PlantWLHButton1.TabIndex = 5
        Me.PlantWLHButton1.TabStop = False
        Me.PlantWLHButton1.Text = "GOOD"
        Me.PlantWLHButton1.UseVisualStyleBackColor = False
        '
        'FishWLHButton
        '
        Me.FishWLHButton.BackColor = System.Drawing.Color.Green
        Me.FishWLHButton.Enabled = False
        Me.FishWLHButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishWLHButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishWLHButton.Location = New System.Drawing.Point(294, 83)
        Me.FishWLHButton.Name = "FishWLHButton"
        Me.FishWLHButton.Size = New System.Drawing.Size(186, 64)
        Me.FishWLHButton.TabIndex = 4
        Me.FishWLHButton.TabStop = False
        Me.FishWLHButton.Text = "GOOD"
        Me.FishWLHButton.UseVisualStyleBackColor = False
        '
        'ResWLLabel
        '
        Me.ResWLLabel.AutoSize = True
        Me.ResWLLabel.Location = New System.Drawing.Point(92, 359)
        Me.ResWLLabel.Name = "ResWLLabel"
        Me.ResWLLabel.Size = New System.Drawing.Size(188, 32)
        Me.ResWLLabel.TabIndex = 3
        Me.ResWLLabel.Text = "RESERVOIR:"
        '
        'PlantWLLabel
        '
        Me.PlantWLLabel.AutoSize = True
        Me.PlantWLLabel.Location = New System.Drawing.Point(101, 184)
        Me.PlantWLLabel.Name = "PlantWLLabel"
        Me.PlantWLLabel.Size = New System.Drawing.Size(179, 32)
        Me.PlantWLLabel.TabIndex = 2
        Me.PlantWLLabel.Text = "PLANT BED:"
        '
        'FishWLLabel
        '
        Me.FishWLLabel.AutoSize = True
        Me.FishWLLabel.Location = New System.Drawing.Point(112, 101)
        Me.FishWLLabel.Name = "FishWLLabel"
        Me.FishWLLabel.Size = New System.Drawing.Size(168, 32)
        Me.FishWLLabel.TabIndex = 1
        Me.FishWLLabel.Text = "FISH TANK:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.OutputStatesGroupBox)
        Me.TabPage2.Controls.Add(Me.TestGroupBox)
        Me.TabPage2.Controls.Add(Me.AnalogRangesGroupBox)
        Me.TabPage2.Controls.Add(Me.RecDigitalGroupBox)
        Me.TabPage2.Location = New System.Drawing.Point(10, 48)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(2303, 1383)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TROUBLESHOOT"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OutputStatesGroupBox
        '
        Me.OutputStatesGroupBox.Controls.Add(Me.FishFeederOutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.FishFeedLabel)
        Me.OutputStatesGroupBox.Controls.Add(Me.ResHeaterOutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.ResHeaterLabel)
        Me.OutputStatesGroupBox.Controls.Add(Me.FishHeaterOutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.FishHeaterLabel)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump3OutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump3Label)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump2OutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump2Label)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump1OutputButton)
        Me.OutputStatesGroupBox.Controls.Add(Me.Pump1Label)
        Me.OutputStatesGroupBox.Location = New System.Drawing.Point(58, 386)
        Me.OutputStatesGroupBox.Name = "OutputStatesGroupBox"
        Me.OutputStatesGroupBox.Size = New System.Drawing.Size(548, 727)
        Me.OutputStatesGroupBox.TabIndex = 48
        Me.OutputStatesGroupBox.TabStop = False
        Me.OutputStatesGroupBox.Text = "Output State of Test Controls"
        '
        'FishFeederOutputButton
        '
        Me.FishFeederOutputButton.BackColor = System.Drawing.Color.Green
        Me.FishFeederOutputButton.Enabled = False
        Me.FishFeederOutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishFeederOutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishFeederOutputButton.Location = New System.Drawing.Point(361, 289)
        Me.FishFeederOutputButton.Name = "FishFeederOutputButton"
        Me.FishFeederOutputButton.Size = New System.Drawing.Size(126, 64)
        Me.FishFeederOutputButton.TabIndex = 47
        Me.FishFeederOutputButton.TabStop = False
        Me.FishFeederOutputButton.Text = "ON"
        Me.FishFeederOutputButton.UseVisualStyleBackColor = False
        '
        'FishFeedLabel
        '
        Me.FishFeedLabel.AutoSize = True
        Me.FishFeedLabel.Location = New System.Drawing.Point(130, 307)
        Me.FishFeedLabel.Name = "FishFeedLabel"
        Me.FishFeedLabel.Size = New System.Drawing.Size(207, 32)
        Me.FishFeedLabel.TabIndex = 46
        Me.FishFeedLabel.Text = "FISH FEEDER:"
        '
        'ResHeaterOutputButton
        '
        Me.ResHeaterOutputButton.BackColor = System.Drawing.Color.Green
        Me.ResHeaterOutputButton.Enabled = False
        Me.ResHeaterOutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResHeaterOutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResHeaterOutputButton.Location = New System.Drawing.Point(361, 455)
        Me.ResHeaterOutputButton.Name = "ResHeaterOutputButton"
        Me.ResHeaterOutputButton.Size = New System.Drawing.Size(126, 64)
        Me.ResHeaterOutputButton.TabIndex = 45
        Me.ResHeaterOutputButton.TabStop = False
        Me.ResHeaterOutputButton.Text = "ON"
        Me.ResHeaterOutputButton.UseVisualStyleBackColor = False
        '
        'ResHeaterLabel
        '
        Me.ResHeaterLabel.AutoSize = True
        Me.ResHeaterLabel.Location = New System.Drawing.Point(28, 473)
        Me.ResHeaterLabel.Name = "ResHeaterLabel"
        Me.ResHeaterLabel.Size = New System.Drawing.Size(309, 32)
        Me.ResHeaterLabel.TabIndex = 44
        Me.ResHeaterLabel.Text = "RESERVOIR HEATER:"
        '
        'FishHeaterOutputButton
        '
        Me.FishHeaterOutputButton.BackColor = System.Drawing.Color.Green
        Me.FishHeaterOutputButton.Enabled = False
        Me.FishHeaterOutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishHeaterOutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishHeaterOutputButton.Location = New System.Drawing.Point(361, 375)
        Me.FishHeaterOutputButton.Name = "FishHeaterOutputButton"
        Me.FishHeaterOutputButton.Size = New System.Drawing.Size(126, 64)
        Me.FishHeaterOutputButton.TabIndex = 43
        Me.FishHeaterOutputButton.TabStop = False
        Me.FishHeaterOutputButton.Text = "ON"
        Me.FishHeaterOutputButton.UseVisualStyleBackColor = False
        '
        'FishHeaterLabel
        '
        Me.FishHeaterLabel.AutoSize = True
        Me.FishHeaterLabel.Location = New System.Drawing.Point(48, 393)
        Me.FishHeaterLabel.Name = "FishHeaterLabel"
        Me.FishHeaterLabel.Size = New System.Drawing.Size(289, 32)
        Me.FishHeaterLabel.TabIndex = 42
        Me.FishHeaterLabel.Text = "FISH TANK HEATER:"
        '
        'Pump3OutputButton
        '
        Me.Pump3OutputButton.BackColor = System.Drawing.Color.Green
        Me.Pump3OutputButton.Enabled = False
        Me.Pump3OutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pump3OutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump3OutputButton.Location = New System.Drawing.Point(361, 199)
        Me.Pump3OutputButton.Name = "Pump3OutputButton"
        Me.Pump3OutputButton.Size = New System.Drawing.Size(126, 64)
        Me.Pump3OutputButton.TabIndex = 41
        Me.Pump3OutputButton.TabStop = False
        Me.Pump3OutputButton.Text = "ON"
        Me.Pump3OutputButton.UseVisualStyleBackColor = False
        '
        'Pump3Label
        '
        Me.Pump3Label.AutoSize = True
        Me.Pump3Label.Location = New System.Drawing.Point(210, 217)
        Me.Pump3Label.Name = "Pump3Label"
        Me.Pump3Label.Size = New System.Drawing.Size(127, 32)
        Me.Pump3Label.TabIndex = 40
        Me.Pump3Label.Text = "PUMP 3:"
        '
        'Pump2OutputButton
        '
        Me.Pump2OutputButton.BackColor = System.Drawing.Color.Green
        Me.Pump2OutputButton.Enabled = False
        Me.Pump2OutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pump2OutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump2OutputButton.Location = New System.Drawing.Point(361, 119)
        Me.Pump2OutputButton.Name = "Pump2OutputButton"
        Me.Pump2OutputButton.Size = New System.Drawing.Size(126, 64)
        Me.Pump2OutputButton.TabIndex = 39
        Me.Pump2OutputButton.TabStop = False
        Me.Pump2OutputButton.Text = "ON"
        Me.Pump2OutputButton.UseVisualStyleBackColor = False
        '
        'Pump2Label
        '
        Me.Pump2Label.AutoSize = True
        Me.Pump2Label.Location = New System.Drawing.Point(210, 137)
        Me.Pump2Label.Name = "Pump2Label"
        Me.Pump2Label.Size = New System.Drawing.Size(127, 32)
        Me.Pump2Label.TabIndex = 38
        Me.Pump2Label.Text = "PUMP 2:"
        '
        'Pump1OutputButton
        '
        Me.Pump1OutputButton.BackColor = System.Drawing.Color.Green
        Me.Pump1OutputButton.Enabled = False
        Me.Pump1OutputButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pump1OutputButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump1OutputButton.Location = New System.Drawing.Point(361, 40)
        Me.Pump1OutputButton.Name = "Pump1OutputButton"
        Me.Pump1OutputButton.Size = New System.Drawing.Size(126, 64)
        Me.Pump1OutputButton.TabIndex = 37
        Me.Pump1OutputButton.TabStop = False
        Me.Pump1OutputButton.Text = "ON"
        Me.Pump1OutputButton.UseVisualStyleBackColor = False
        '
        'Pump1Label
        '
        Me.Pump1Label.AutoSize = True
        Me.Pump1Label.Location = New System.Drawing.Point(210, 58)
        Me.Pump1Label.Name = "Pump1Label"
        Me.Pump1Label.Size = New System.Drawing.Size(127, 32)
        Me.Pump1Label.TabIndex = 36
        Me.Pump1Label.Text = "PUMP 1:"
        '
        'TestGroupBox
        '
        Me.TestGroupBox.Controls.Add(Me.FishFeederButton)
        Me.TestGroupBox.Controls.Add(Me.StackLightRButton)
        Me.TestGroupBox.Controls.Add(Me.StackLightYButton)
        Me.TestGroupBox.Controls.Add(Me.StackLightGButton)
        Me.TestGroupBox.Controls.Add(Me.FishLightButton)
        Me.TestGroupBox.Controls.Add(Me.GrowLightControlButton)
        Me.TestGroupBox.Controls.Add(Me.ResHeaterButton)
        Me.TestGroupBox.Controls.Add(Me.FishHeaterButton)
        Me.TestGroupBox.Controls.Add(Me.Pump3Button)
        Me.TestGroupBox.Controls.Add(Me.Pump2Button)
        Me.TestGroupBox.Controls.Add(Me.Pump1Button)
        Me.TestGroupBox.Location = New System.Drawing.Point(643, 386)
        Me.TestGroupBox.Name = "TestGroupBox"
        Me.TestGroupBox.Size = New System.Drawing.Size(633, 727)
        Me.TestGroupBox.TabIndex = 7
        Me.TestGroupBox.TabStop = False
        Me.TestGroupBox.Text = "Test Controls"
        '
        'FishFeederButton
        '
        Me.FishFeederButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FishFeederButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishFeederButton.Location = New System.Drawing.Point(48, 282)
        Me.FishFeederButton.Name = "FishFeederButton"
        Me.FishFeederButton.Size = New System.Drawing.Size(248, 54)
        Me.FishFeederButton.TabIndex = 11
        Me.FishFeederButton.Text = "FISH FEEDER"
        Me.FishFeederButton.UseVisualStyleBackColor = False
        '
        'StackLightRButton
        '
        Me.StackLightRButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StackLightRButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StackLightRButton.Location = New System.Drawing.Point(48, 647)
        Me.StackLightRButton.Name = "StackLightRButton"
        Me.StackLightRButton.Size = New System.Drawing.Size(372, 54)
        Me.StackLightRButton.TabIndex = 16
        Me.StackLightRButton.Text = "STACK LIGHT - RED"
        Me.StackLightRButton.UseVisualStyleBackColor = False
        '
        'StackLightYButton
        '
        Me.StackLightYButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StackLightYButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StackLightYButton.Location = New System.Drawing.Point(48, 587)
        Me.StackLightYButton.Name = "StackLightYButton"
        Me.StackLightYButton.Size = New System.Drawing.Size(372, 54)
        Me.StackLightYButton.TabIndex = 15
        Me.StackLightYButton.Text = "STACK LIGHT - YELLOW"
        Me.StackLightYButton.UseVisualStyleBackColor = False
        '
        'StackLightGButton
        '
        Me.StackLightGButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.StackLightGButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.StackLightGButton.Location = New System.Drawing.Point(48, 527)
        Me.StackLightGButton.Name = "StackLightGButton"
        Me.StackLightGButton.Size = New System.Drawing.Size(372, 54)
        Me.StackLightGButton.TabIndex = 14
        Me.StackLightGButton.Text = "STACK LIGHT - GREEN"
        Me.StackLightGButton.UseVisualStyleBackColor = False
        '
        'FishLightButton
        '
        Me.FishLightButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FishLightButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishLightButton.Location = New System.Drawing.Point(336, 125)
        Me.FishLightButton.Name = "FishLightButton"
        Me.FishLightButton.Size = New System.Drawing.Size(248, 54)
        Me.FishLightButton.TabIndex = 18
        Me.FishLightButton.Text = "FISH LIGHT"
        Me.FishLightButton.UseVisualStyleBackColor = False
        '
        'GrowLightControlButton
        '
        Me.GrowLightControlButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.GrowLightControlButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrowLightControlButton.Location = New System.Drawing.Point(336, 65)
        Me.GrowLightControlButton.Name = "GrowLightControlButton"
        Me.GrowLightControlButton.Size = New System.Drawing.Size(248, 54)
        Me.GrowLightControlButton.TabIndex = 17
        Me.GrowLightControlButton.Text = "GROW LIGHT"
        Me.GrowLightControlButton.UseVisualStyleBackColor = False
        '
        'ResHeaterButton
        '
        Me.ResHeaterButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ResHeaterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResHeaterButton.Location = New System.Drawing.Point(48, 434)
        Me.ResHeaterButton.Name = "ResHeaterButton"
        Me.ResHeaterButton.Size = New System.Drawing.Size(372, 54)
        Me.ResHeaterButton.TabIndex = 13
        Me.ResHeaterButton.Text = "RESERVOIR HEATER"
        Me.ResHeaterButton.UseVisualStyleBackColor = False
        '
        'FishHeaterButton
        '
        Me.FishHeaterButton.BackColor = System.Drawing.SystemColors.ControlDark
        Me.FishHeaterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FishHeaterButton.Location = New System.Drawing.Point(48, 374)
        Me.FishHeaterButton.Name = "FishHeaterButton"
        Me.FishHeaterButton.Size = New System.Drawing.Size(372, 54)
        Me.FishHeaterButton.TabIndex = 12
        Me.FishHeaterButton.Text = "FISH TANK HEATER"
        Me.FishHeaterButton.UseVisualStyleBackColor = False
        '
        'Pump3Button
        '
        Me.Pump3Button.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Pump3Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump3Button.Location = New System.Drawing.Point(48, 185)
        Me.Pump3Button.Name = "Pump3Button"
        Me.Pump3Button.Size = New System.Drawing.Size(248, 54)
        Me.Pump3Button.TabIndex = 10
        Me.Pump3Button.Text = "PUMP 3"
        Me.Pump3Button.UseVisualStyleBackColor = False
        '
        'Pump2Button
        '
        Me.Pump2Button.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Pump2Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump2Button.Location = New System.Drawing.Point(48, 125)
        Me.Pump2Button.Name = "Pump2Button"
        Me.Pump2Button.Size = New System.Drawing.Size(248, 54)
        Me.Pump2Button.TabIndex = 9
        Me.Pump2Button.Text = "PUMP 2"
        Me.Pump2Button.UseVisualStyleBackColor = False
        '
        'Pump1Button
        '
        Me.Pump1Button.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Pump1Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Pump1Button.Location = New System.Drawing.Point(48, 65)
        Me.Pump1Button.Name = "Pump1Button"
        Me.Pump1Button.Size = New System.Drawing.Size(248, 54)
        Me.Pump1Button.TabIndex = 8
        Me.Pump1Button.Text = "PUMP 1"
        Me.Pump1Button.UseVisualStyleBackColor = False
        '
        'AnalogRangesGroupBox
        '
        Me.AnalogRangesGroupBox.Controls.Add(Me.SaveLabel)
        Me.AnalogRangesGroupBox.Controls.Add(Me.SaverRangeButton)
        Me.AnalogRangesGroupBox.Controls.Add(Me.AnalogRangeComboBox)
        Me.AnalogRangesGroupBox.Controls.Add(Me.RedLLabel)
        Me.AnalogRangesGroupBox.Controls.Add(Me.RedLTextBox)
        Me.AnalogRangesGroupBox.Controls.Add(Me.RedHLabel)
        Me.AnalogRangesGroupBox.Controls.Add(Me.RedHTextBox)
        Me.AnalogRangesGroupBox.Controls.Add(Me.YellowLLabel)
        Me.AnalogRangesGroupBox.Controls.Add(Me.YellowLTextBox)
        Me.AnalogRangesGroupBox.Controls.Add(Me.YellowHLabel)
        Me.AnalogRangesGroupBox.Controls.Add(Me.YellowHTextBox)
        Me.AnalogRangesGroupBox.Location = New System.Drawing.Point(456, 46)
        Me.AnalogRangesGroupBox.Name = "AnalogRangesGroupBox"
        Me.AnalogRangesGroupBox.Size = New System.Drawing.Size(820, 325)
        Me.AnalogRangesGroupBox.TabIndex = 0
        Me.AnalogRangesGroupBox.TabStop = False
        Me.AnalogRangesGroupBox.Text = "Analog Data Ranges Stack-Light States"
        '
        'SaveLabel
        '
        Me.SaveLabel.AutoSize = True
        Me.SaveLabel.Location = New System.Drawing.Point(19, 201)
        Me.SaveLabel.Name = "SaveLabel"
        Me.SaveLabel.Size = New System.Drawing.Size(191, 32)
        Me.SaveLabel.TabIndex = 36
        Me.SaveLabel.Text = "Values Saved"
        '
        'SaverRangeButton
        '
        Me.SaverRangeButton.BackColor = System.Drawing.Color.Transparent
        Me.SaverRangeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.SaverRangeButton.Location = New System.Drawing.Point(25, 126)
        Me.SaverRangeButton.Name = "SaverRangeButton"
        Me.SaverRangeButton.Size = New System.Drawing.Size(251, 54)
        Me.SaverRangeButton.TabIndex = 6
        Me.SaverRangeButton.Text = "SAVE RANGE"
        Me.SaverRangeButton.UseVisualStyleBackColor = False
        '
        'AnalogRangeComboBox
        '
        Me.AnalogRangeComboBox.FormattingEnabled = True
        Me.AnalogRangeComboBox.Location = New System.Drawing.Point(25, 54)
        Me.AnalogRangeComboBox.Name = "AnalogRangeComboBox"
        Me.AnalogRangeComboBox.Size = New System.Drawing.Size(340, 39)
        Me.AnalogRangeComboBox.TabIndex = 1
        '
        'RedLLabel
        '
        Me.RedLLabel.AutoSize = True
        Me.RedLLabel.Location = New System.Drawing.Point(426, 221)
        Me.RedLLabel.Name = "RedLLabel"
        Me.RedLLabel.Size = New System.Drawing.Size(134, 32)
        Me.RedLLabel.TabIndex = 32
        Me.RedLLabel.Text = "Red Low:"
        '
        'RedLTextBox
        '
        Me.RedLTextBox.Location = New System.Drawing.Point(582, 218)
        Me.RedLTextBox.Name = "RedLTextBox"
        Me.RedLTextBox.Size = New System.Drawing.Size(214, 38)
        Me.RedLTextBox.TabIndex = 5
        Me.RedLTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RedHLabel
        '
        Me.RedHLabel.AutoSize = True
        Me.RedHLabel.Location = New System.Drawing.Point(419, 169)
        Me.RedHLabel.Name = "RedHLabel"
        Me.RedHLabel.Size = New System.Drawing.Size(141, 32)
        Me.RedHLabel.TabIndex = 30
        Me.RedHLabel.Text = "Red High:"
        '
        'RedHTextBox
        '
        Me.RedHTextBox.Location = New System.Drawing.Point(582, 163)
        Me.RedHTextBox.Name = "RedHTextBox"
        Me.RedHTextBox.Size = New System.Drawing.Size(214, 38)
        Me.RedHTextBox.TabIndex = 4
        Me.RedHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'YellowLLabel
        '
        Me.YellowLLabel.AutoSize = True
        Me.YellowLLabel.Location = New System.Drawing.Point(393, 116)
        Me.YellowLLabel.Name = "YellowLLabel"
        Me.YellowLLabel.Size = New System.Drawing.Size(167, 32)
        Me.YellowLLabel.TabIndex = 28
        Me.YellowLLabel.Text = "Yellow Low:"
        '
        'YellowLTextBox
        '
        Me.YellowLTextBox.Location = New System.Drawing.Point(582, 110)
        Me.YellowLTextBox.Name = "YellowLTextBox"
        Me.YellowLTextBox.Size = New System.Drawing.Size(214, 38)
        Me.YellowLTextBox.TabIndex = 3
        Me.YellowLTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'YellowHLabel
        '
        Me.YellowHLabel.AutoSize = True
        Me.YellowHLabel.Location = New System.Drawing.Point(386, 63)
        Me.YellowHLabel.Name = "YellowHLabel"
        Me.YellowHLabel.Size = New System.Drawing.Size(174, 32)
        Me.YellowHLabel.TabIndex = 26
        Me.YellowHLabel.Text = "Yellow High:"
        '
        'YellowHTextBox
        '
        Me.YellowHTextBox.Location = New System.Drawing.Point(582, 57)
        Me.YellowHTextBox.Name = "YellowHTextBox"
        Me.YellowHTextBox.Size = New System.Drawing.Size(214, 38)
        Me.YellowHTextBox.TabIndex = 2
        Me.YellowHTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RecDigitalGroupBox
        '
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraWL2CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.FishFeederCheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ResWLLCheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ResWLHCheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.PlantWLHCheckBox2)
        Me.RecDigitalGroupBox.Controls.Add(Me.PlantWLHCheckBox1)
        Me.RecDigitalGroupBox.Controls.Add(Me.FishWLLCheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.FishWLHCheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte7CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte6CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte5CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte4CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte3CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte2CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte1CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.ExtraByte0CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte7CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte6CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte5CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte4CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte3CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte2CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte1CheckBox)
        Me.RecDigitalGroupBox.Controls.Add(Me.DigByte0CheckBox)
        Me.RecDigitalGroupBox.Location = New System.Drawing.Point(1295, 46)
        Me.RecDigitalGroupBox.Name = "RecDigitalGroupBox"
        Me.RecDigitalGroupBox.Size = New System.Drawing.Size(525, 1166)
        Me.RecDigitalGroupBox.TabIndex = 24
        Me.RecDigitalGroupBox.TabStop = False
        Me.RecDigitalGroupBox.Text = "Digital Data Received"
        '
        'ExtraWL2CheckBox
        '
        Me.ExtraWL2CheckBox.AutoSize = True
        Me.ExtraWL2CheckBox.Enabled = False
        Me.ExtraWL2CheckBox.Location = New System.Drawing.Point(39, 1115)
        Me.ExtraWL2CheckBox.Name = "ExtraWL2CheckBox"
        Me.ExtraWL2CheckBox.Size = New System.Drawing.Size(431, 36)
        Me.ExtraWL2CheckBox.TabIndex = 23
        Me.ExtraWL2CheckBox.TabStop = False
        Me.ExtraWL2CheckBox.Text = "WLByte: Bit 7 Unimplemented"
        Me.ExtraWL2CheckBox.UseVisualStyleBackColor = True
        '
        'FishFeederCheckBox
        '
        Me.FishFeederCheckBox.AutoSize = True
        Me.FishFeederCheckBox.Enabled = False
        Me.FishFeederCheckBox.Location = New System.Drawing.Point(39, 1073)
        Me.FishFeederCheckBox.Name = "FishFeederCheckBox"
        Me.FishFeederCheckBox.Size = New System.Drawing.Size(382, 36)
        Me.FishFeederCheckBox.TabIndex = 22
        Me.FishFeederCheckBox.TabStop = False
        Me.FishFeederCheckBox.Text = "WLByte: Bit 6 Fish Feeder"
        Me.FishFeederCheckBox.UseVisualStyleBackColor = True
        '
        'ResWLLCheckBox
        '
        Me.ResWLLCheckBox.AutoSize = True
        Me.ResWLLCheckBox.Enabled = False
        Me.ResWLLCheckBox.Location = New System.Drawing.Point(39, 1031)
        Me.ResWLLCheckBox.Name = "ResWLLCheckBox"
        Me.ResWLLCheckBox.Size = New System.Drawing.Size(411, 36)
        Me.ResWLLCheckBox.TabIndex = 21
        Me.ResWLLCheckBox.TabStop = False
        Me.ResWLLCheckBox.Text = "WLByte: Bit 5 Reservoir Low"
        Me.ResWLLCheckBox.UseVisualStyleBackColor = True
        '
        'ResWLHCheckBox
        '
        Me.ResWLHCheckBox.AutoSize = True
        Me.ResWLHCheckBox.Enabled = False
        Me.ResWLHCheckBox.Location = New System.Drawing.Point(39, 989)
        Me.ResWLHCheckBox.Name = "ResWLHCheckBox"
        Me.ResWLHCheckBox.Size = New System.Drawing.Size(418, 36)
        Me.ResWLHCheckBox.TabIndex = 20
        Me.ResWLHCheckBox.TabStop = False
        Me.ResWLHCheckBox.Text = "WLByte: Bit 4 Reservoir High"
        Me.ResWLHCheckBox.UseVisualStyleBackColor = True
        '
        'PlantWLHCheckBox2
        '
        Me.PlantWLHCheckBox2.AutoSize = True
        Me.PlantWLHCheckBox2.Enabled = False
        Me.PlantWLHCheckBox2.Location = New System.Drawing.Point(39, 947)
        Me.PlantWLHCheckBox2.Name = "PlantWLHCheckBox2"
        Me.PlantWLHCheckBox2.Size = New System.Drawing.Size(444, 36)
        Me.PlantWLHCheckBox2.TabIndex = 19
        Me.PlantWLHCheckBox2.TabStop = False
        Me.PlantWLHCheckBox2.Text = "WLByte: Bit 3 Plant Bed High 2"
        Me.PlantWLHCheckBox2.UseVisualStyleBackColor = True
        '
        'PlantWLHCheckBox1
        '
        Me.PlantWLHCheckBox1.AutoSize = True
        Me.PlantWLHCheckBox1.Enabled = False
        Me.PlantWLHCheckBox1.Location = New System.Drawing.Point(39, 905)
        Me.PlantWLHCheckBox1.Name = "PlantWLHCheckBox1"
        Me.PlantWLHCheckBox1.Size = New System.Drawing.Size(444, 36)
        Me.PlantWLHCheckBox1.TabIndex = 18
        Me.PlantWLHCheckBox1.TabStop = False
        Me.PlantWLHCheckBox1.Text = "WLByte: Bit 2 Plant Bed High 1"
        Me.PlantWLHCheckBox1.UseVisualStyleBackColor = True
        '
        'FishWLLCheckBox
        '
        Me.FishWLLCheckBox.AutoSize = True
        Me.FishWLLCheckBox.Enabled = False
        Me.FishWLLCheckBox.Location = New System.Drawing.Point(39, 863)
        Me.FishWLLCheckBox.Name = "FishWLLCheckBox"
        Me.FishWLLCheckBox.Size = New System.Drawing.Size(414, 36)
        Me.FishWLLCheckBox.TabIndex = 17
        Me.FishWLLCheckBox.TabStop = False
        Me.FishWLLCheckBox.Text = "WLByte: Bit 1 Fish Tank Low"
        Me.FishWLLCheckBox.UseVisualStyleBackColor = True
        '
        'FishWLHCheckBox
        '
        Me.FishWLHCheckBox.AutoSize = True
        Me.FishWLHCheckBox.Enabled = False
        Me.FishWLHCheckBox.Location = New System.Drawing.Point(39, 821)
        Me.FishWLHCheckBox.Name = "FishWLHCheckBox"
        Me.FishWLHCheckBox.Size = New System.Drawing.Size(421, 36)
        Me.FishWLHCheckBox.TabIndex = 16
        Me.FishWLHCheckBox.TabStop = False
        Me.FishWLHCheckBox.Text = "WLByte: Bit 0 Fish Tank High"
        Me.FishWLHCheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte7CheckBox
        '
        Me.ExtraByte7CheckBox.AutoSize = True
        Me.ExtraByte7CheckBox.Enabled = False
        Me.ExtraByte7CheckBox.Location = New System.Drawing.Point(39, 724)
        Me.ExtraByte7CheckBox.Name = "ExtraByte7CheckBox"
        Me.ExtraByte7CheckBox.Size = New System.Drawing.Size(459, 36)
        Me.ExtraByte7CheckBox.TabIndex = 15
        Me.ExtraByte7CheckBox.TabStop = False
        Me.ExtraByte7CheckBox.Text = "ExtaByte: Bit 7 Reservoir Heater"
        Me.ExtraByte7CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte6CheckBox
        '
        Me.ExtraByte6CheckBox.AutoSize = True
        Me.ExtraByte6CheckBox.Enabled = False
        Me.ExtraByte6CheckBox.Location = New System.Drawing.Point(39, 682)
        Me.ExtraByte6CheckBox.Name = "ExtraByte6CheckBox"
        Me.ExtraByte6CheckBox.Size = New System.Drawing.Size(462, 36)
        Me.ExtraByte6CheckBox.TabIndex = 14
        Me.ExtraByte6CheckBox.TabStop = False
        Me.ExtraByte6CheckBox.Text = "ExtaByte: Bit 6 Fish Tank Heater"
        Me.ExtraByte6CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte5CheckBox
        '
        Me.ExtraByte5CheckBox.AutoSize = True
        Me.ExtraByte5CheckBox.Enabled = False
        Me.ExtraByte5CheckBox.Location = New System.Drawing.Point(39, 640)
        Me.ExtraByte5CheckBox.Name = "ExtraByte5CheckBox"
        Me.ExtraByte5CheckBox.Size = New System.Drawing.Size(343, 36)
        Me.ExtraByte5CheckBox.TabIndex = 13
        Me.ExtraByte5CheckBox.TabStop = False
        Me.ExtraByte5CheckBox.Text = "ExtaByte: Bit 5 Pump 3"
        Me.ExtraByte5CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte4CheckBox
        '
        Me.ExtraByte4CheckBox.AutoSize = True
        Me.ExtraByte4CheckBox.Enabled = False
        Me.ExtraByte4CheckBox.Location = New System.Drawing.Point(39, 598)
        Me.ExtraByte4CheckBox.Name = "ExtraByte4CheckBox"
        Me.ExtraByte4CheckBox.Size = New System.Drawing.Size(343, 36)
        Me.ExtraByte4CheckBox.TabIndex = 12
        Me.ExtraByte4CheckBox.TabStop = False
        Me.ExtraByte4CheckBox.Text = "ExtaByte: Bit 4 Pump 2"
        Me.ExtraByte4CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte3CheckBox
        '
        Me.ExtraByte3CheckBox.AutoSize = True
        Me.ExtraByte3CheckBox.Enabled = False
        Me.ExtraByte3CheckBox.Location = New System.Drawing.Point(39, 556)
        Me.ExtraByte3CheckBox.Name = "ExtraByte3CheckBox"
        Me.ExtraByte3CheckBox.Size = New System.Drawing.Size(343, 36)
        Me.ExtraByte3CheckBox.TabIndex = 11
        Me.ExtraByte3CheckBox.TabStop = False
        Me.ExtraByte3CheckBox.Text = "ExtaByte: Bit 3 Pump 1"
        Me.ExtraByte3CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte2CheckBox
        '
        Me.ExtraByte2CheckBox.AutoSize = True
        Me.ExtraByte2CheckBox.Enabled = False
        Me.ExtraByte2CheckBox.Location = New System.Drawing.Point(39, 514)
        Me.ExtraByte2CheckBox.Name = "ExtraByte2CheckBox"
        Me.ExtraByte2CheckBox.Size = New System.Drawing.Size(335, 36)
        Me.ExtraByte2CheckBox.TabIndex = 10
        Me.ExtraByte2CheckBox.TabStop = False
        Me.ExtraByte2CheckBox.Text = "ExtaByte: Bit 2 Extra 3"
        Me.ExtraByte2CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte1CheckBox
        '
        Me.ExtraByte1CheckBox.AutoSize = True
        Me.ExtraByte1CheckBox.Enabled = False
        Me.ExtraByte1CheckBox.Location = New System.Drawing.Point(39, 472)
        Me.ExtraByte1CheckBox.Name = "ExtraByte1CheckBox"
        Me.ExtraByte1CheckBox.Size = New System.Drawing.Size(335, 36)
        Me.ExtraByte1CheckBox.TabIndex = 9
        Me.ExtraByte1CheckBox.TabStop = False
        Me.ExtraByte1CheckBox.Text = "ExtaByte: Bit 1 Extra 2"
        Me.ExtraByte1CheckBox.UseVisualStyleBackColor = True
        '
        'ExtraByte0CheckBox
        '
        Me.ExtraByte0CheckBox.AutoSize = True
        Me.ExtraByte0CheckBox.Enabled = False
        Me.ExtraByte0CheckBox.Location = New System.Drawing.Point(39, 430)
        Me.ExtraByte0CheckBox.Name = "ExtraByte0CheckBox"
        Me.ExtraByte0CheckBox.Size = New System.Drawing.Size(335, 36)
        Me.ExtraByte0CheckBox.TabIndex = 8
        Me.ExtraByte0CheckBox.TabStop = False
        Me.ExtraByte0CheckBox.Text = "ExtaByte: Bit 0 Extra 1"
        Me.ExtraByte0CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte7CheckBox
        '
        Me.DigByte7CheckBox.AutoSize = True
        Me.DigByte7CheckBox.Enabled = False
        Me.DigByte7CheckBox.Location = New System.Drawing.Point(39, 354)
        Me.DigByte7CheckBox.Name = "DigByte7CheckBox"
        Me.DigByte7CheckBox.Size = New System.Drawing.Size(394, 36)
        Me.DigByte7CheckBox.TabIndex = 7
        Me.DigByte7CheckBox.TabStop = False
        Me.DigByte7CheckBox.Text = "DigByte: Bit 7 Flow Meter 5"
        Me.DigByte7CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte6CheckBox
        '
        Me.DigByte6CheckBox.AutoSize = True
        Me.DigByte6CheckBox.Enabled = False
        Me.DigByte6CheckBox.Location = New System.Drawing.Point(39, 312)
        Me.DigByte6CheckBox.Name = "DigByte6CheckBox"
        Me.DigByte6CheckBox.Size = New System.Drawing.Size(394, 36)
        Me.DigByte6CheckBox.TabIndex = 6
        Me.DigByte6CheckBox.TabStop = False
        Me.DigByte6CheckBox.Text = "DigByte: Bit 6 Flow Meter 4"
        Me.DigByte6CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte5CheckBox
        '
        Me.DigByte5CheckBox.AutoSize = True
        Me.DigByte5CheckBox.Enabled = False
        Me.DigByte5CheckBox.Location = New System.Drawing.Point(39, 270)
        Me.DigByte5CheckBox.Name = "DigByte5CheckBox"
        Me.DigByte5CheckBox.Size = New System.Drawing.Size(403, 36)
        Me.DigByte5CheckBox.TabIndex = 5
        Me.DigByte5CheckBox.TabStop = False
        Me.DigByte5CheckBox.Text = "DigByte: Bit 5 FLow Meter 3"
        Me.DigByte5CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte4CheckBox
        '
        Me.DigByte4CheckBox.AutoSize = True
        Me.DigByte4CheckBox.Enabled = False
        Me.DigByte4CheckBox.Location = New System.Drawing.Point(39, 228)
        Me.DigByte4CheckBox.Name = "DigByte4CheckBox"
        Me.DigByte4CheckBox.Size = New System.Drawing.Size(394, 36)
        Me.DigByte4CheckBox.TabIndex = 4
        Me.DigByte4CheckBox.TabStop = False
        Me.DigByte4CheckBox.Text = "DigByte: Bit 4 Flow Meter 2"
        Me.DigByte4CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte3CheckBox
        '
        Me.DigByte3CheckBox.AutoSize = True
        Me.DigByte3CheckBox.Enabled = False
        Me.DigByte3CheckBox.Location = New System.Drawing.Point(39, 186)
        Me.DigByte3CheckBox.Name = "DigByte3CheckBox"
        Me.DigByte3CheckBox.Size = New System.Drawing.Size(394, 36)
        Me.DigByte3CheckBox.TabIndex = 3
        Me.DigByte3CheckBox.TabStop = False
        Me.DigByte3CheckBox.Text = "DigByte: Bit 3 Flow Meter 1"
        Me.DigByte3CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte2CheckBox
        '
        Me.DigByte2CheckBox.AutoSize = True
        Me.DigByte2CheckBox.Enabled = False
        Me.DigByte2CheckBox.Location = New System.Drawing.Point(39, 144)
        Me.DigByte2CheckBox.Name = "DigByte2CheckBox"
        Me.DigByte2CheckBox.Size = New System.Drawing.Size(318, 36)
        Me.DigByte2CheckBox.TabIndex = 2
        Me.DigByte2CheckBox.TabStop = False
        Me.DigByte2CheckBox.Text = "DigByte: Bit 2 Motion"
        Me.DigByte2CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte1CheckBox
        '
        Me.DigByte1CheckBox.AutoSize = True
        Me.DigByte1CheckBox.Enabled = False
        Me.DigByte1CheckBox.Location = New System.Drawing.Point(39, 102)
        Me.DigByte1CheckBox.Name = "DigByte1CheckBox"
        Me.DigByte1CheckBox.Size = New System.Drawing.Size(369, 36)
        Me.DigByte1CheckBox.TabIndex = 1
        Me.DigByte1CheckBox.TabStop = False
        Me.DigByte1CheckBox.Text = "DigByte: Bit 1 Grow Light"
        Me.DigByte1CheckBox.UseVisualStyleBackColor = True
        '
        'DigByte0CheckBox
        '
        Me.DigByte0CheckBox.AutoSize = True
        Me.DigByte0CheckBox.Enabled = False
        Me.DigByte0CheckBox.Location = New System.Drawing.Point(39, 60)
        Me.DigByte0CheckBox.Name = "DigByte0CheckBox"
        Me.DigByte0CheckBox.Size = New System.Drawing.Size(401, 36)
        Me.DigByte0CheckBox.TabIndex = 0
        Me.DigByte0CheckBox.TabStop = False
        Me.DigByte0CheckBox.Text = "DigByte: Bit 0 Oustide Light"
        Me.DigByte0CheckBox.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 300000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'FishFoodAlertLabel
        '
        Me.FishFoodAlertLabel.AutoSize = True
        Me.FishFoodAlertLabel.Location = New System.Drawing.Point(28, 103)
        Me.FishFoodAlertLabel.Name = "FishFoodAlertLabel"
        Me.FishFoodAlertLabel.Size = New System.Drawing.Size(258, 32)
        Me.FishFoodAlertLabel.TabIndex = 37
        Me.FishFoodAlertLabel.Text = "Insert VALID time..."
        '
        'MainDisplayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(2317, 1438)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "MainDisplayForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AQUAPONICS"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.FishFoodGroupBox.ResumeLayout(False)
        Me.FishFoodGroupBox.PerformLayout()
        Me.ControlsGroupBox.ResumeLayout(False)
        Me.ControlsGroupBox.PerformLayout()
        Me.OtherGroupBox.ResumeLayout(False)
        Me.OtherGroupBox.PerformLayout()
        Me.ChemicalsGroupBox.ResumeLayout(False)
        Me.ChemicalsGroupBox.PerformLayout()
        Me.TemperatureGroupBox.ResumeLayout(False)
        Me.TemperatureGroupBox.PerformLayout()
        Me.LightSensorsGroupBox.ResumeLayout(False)
        Me.LightSensorsGroupBox.PerformLayout()
        Me.FlowMetersGroupBox.ResumeLayout(False)
        Me.FlowMetersGroupBox.PerformLayout()
        Me.WaterLevelsGroupBox.ResumeLayout(False)
        Me.WaterLevelsGroupBox.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.OutputStatesGroupBox.ResumeLayout(False)
        Me.OutputStatesGroupBox.PerformLayout()
        Me.TestGroupBox.ResumeLayout(False)
        Me.AnalogRangesGroupBox.ResumeLayout(False)
        Me.AnalogRangesGroupBox.PerformLayout()
        Me.RecDigitalGroupBox.ResumeLayout(False)
        Me.RecDigitalGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents OtherGroupBox As GroupBox
    Friend WithEvents CommButton As Button
    Friend WithEvents MotionButton As Button
    Friend WithEvents CommLabel As Label
    Friend WithEvents MotionLabel As Label
    Friend WithEvents ChemicalsGroupBox As GroupBox
    Friend WithEvents ConductTextBox As TextBox
    Friend WithEvents ConductButton As Button
    Friend WithEvents ConductLabel As Label
    Friend WithEvents DisposeTextBox As TextBox
    Friend WithEvents FishPHTextBox As TextBox
    Friend WithEvents PlantPHTextBox As TextBox
    Friend WithEvents DisposeButton As Button
    Friend WithEvents FishPHButton As Button
    Friend WithEvents PlantPHButton As Button
    Friend WithEvents DisposeLabel As Label
    Friend WithEvents FishPHLabel As Label
    Friend WithEvents PlantPHLabel As Label
    Friend WithEvents TemperatureGroupBox As GroupBox
    Friend WithEvents ResTempTextBox As TextBox
    Friend WithEvents FishTempTextBox As TextBox
    Friend WithEvents ResTempButton As Button
    Friend WithEvents FishTempButton As Button
    Friend WithEvents ResTempLabel As Label
    Friend WithEvents FishTempLabel As Label
    Friend WithEvents LightSensorsGroupBox As GroupBox
    Friend WithEvents GrowLightSensorButton As Button
    Friend WithEvents OutsideLightSensorButton As Button
    Friend WithEvents GrowLightSensorLabel As Label
    Friend WithEvents OutsideLightSensorLabel As Label
    Friend WithEvents FlowMetersGroupBox As GroupBox
    Friend WithEvents FlowMeter4Button As Button
    Friend WithEvents Flowmeter4Label As Label
    Friend WithEvents FlowMeter3Button As Button
    Friend WithEvents FlowMeter2Button As Button
    Friend WithEvents FlowMeter1Button As Button
    Friend WithEvents Flowmeter3Label As Label
    Friend WithEvents Flowmeter2Label As Label
    Friend WithEvents Flowmeter1Label As Label
    Friend WithEvents WaterLevelsGroupBox As GroupBox
    Friend WithEvents ResWLHButton As Button
    Friend WithEvents PlantWLHButton1 As Button
    Friend WithEvents FishWLHButton As Button
    Friend WithEvents ResWLLabel As Label
    Friend WithEvents PlantWLLabel As Label
    Friend WithEvents FishWLLabel As Label
    Friend WithEvents DigitalEX2Button As Button
    Friend WithEvents DigitalEx2Label As Label
    Friend WithEvents DigitalEX1Button As Button
    Friend WithEvents AnalogEX2Button As Button
    Friend WithEvents AnalogEX1Button As Button
    Friend WithEvents DigitalExLabel As Label
    Friend WithEvents AnalogEx2Label As Label
    Friend WithEvents AnalogEx1Label As Label
    Friend WithEvents DigitalEX3Button As Button
    Friend WithEvents DigitalEx3Label As Label
    Friend WithEvents AnalogEX2TextBox As TextBox
    Friend WithEvents AnalogEX1TextBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ExtraWL2CheckBox As CheckBox
    Friend WithEvents FishFeederCheckBox As CheckBox
    Friend WithEvents ResWLLCheckBox As CheckBox
    Friend WithEvents ResWLHCheckBox As CheckBox
    Friend WithEvents PlantWLHCheckBox2 As CheckBox
    Friend WithEvents PlantWLHCheckBox1 As CheckBox
    Friend WithEvents FishWLLCheckBox As CheckBox
    Friend WithEvents FishWLHCheckBox As CheckBox
    Friend WithEvents ExtraByte7CheckBox As CheckBox
    Friend WithEvents ExtraByte6CheckBox As CheckBox
    Friend WithEvents ExtraByte5CheckBox As CheckBox
    Friend WithEvents ExtraByte4CheckBox As CheckBox
    Friend WithEvents ExtraByte3CheckBox As CheckBox
    Friend WithEvents ExtraByte2CheckBox As CheckBox
    Friend WithEvents ExtraByte1CheckBox As CheckBox
    Friend WithEvents ExtraByte0CheckBox As CheckBox
    Friend WithEvents DigByte7CheckBox As CheckBox
    Friend WithEvents DigByte6CheckBox As CheckBox
    Friend WithEvents DigByte5CheckBox As CheckBox
    Friend WithEvents DigByte4CheckBox As CheckBox
    Friend WithEvents DigByte3CheckBox As CheckBox
    Friend WithEvents DigByte2CheckBox As CheckBox
    Friend WithEvents DigByte1CheckBox As CheckBox
    Friend WithEvents DigByte0CheckBox As CheckBox
    Friend WithEvents FlowMeter5Button As Button
    Friend WithEvents Flowmeter5Label As Label
    Friend WithEvents YellowHLabel As Label
    Friend WithEvents YellowHTextBox As TextBox
    Friend WithEvents RecDigitalGroupBox As GroupBox
    Friend WithEvents RedLLabel As Label
    Friend WithEvents RedLTextBox As TextBox
    Friend WithEvents RedHLabel As Label
    Friend WithEvents RedHTextBox As TextBox
    Friend WithEvents YellowLLabel As Label
    Friend WithEvents YellowLTextBox As TextBox
    Friend WithEvents AnalogRangeComboBox As ComboBox
    Friend WithEvents AnalogRangesGroupBox As GroupBox
    Friend WithEvents ResWLLButton As Button
    Friend WithEvents FishWLLButton As Button
    Friend WithEvents PlantWLHButton2 As Button
    Friend WithEvents WLLowLabel As Label
    Friend WithEvents WLHighLabel As Label
    Friend WithEvents Pump3Button As Button
    Friend WithEvents Pump2Button As Button
    Friend WithEvents Pump1Button As Button
    Friend WithEvents GrowLightControlButton As Button
    Friend WithEvents ResHeaterButton As Button
    Friend WithEvents FishHeaterButton As Button
    Friend WithEvents FishLightButton As Button
    Friend WithEvents TestGroupBox As GroupBox
    Friend WithEvents StackLightRButton As Button
    Friend WithEvents StackLightYButton As Button
    Friend WithEvents StackLightGButton As Button
    Friend WithEvents Pump1OutputButton As Button
    Friend WithEvents Pump1Label As Label
    Friend WithEvents ResHeaterOutputButton As Button
    Friend WithEvents ResHeaterLabel As Label
    Friend WithEvents FishHeaterOutputButton As Button
    Friend WithEvents FishHeaterLabel As Label
    Friend WithEvents Pump3OutputButton As Button
    Friend WithEvents Pump3Label As Label
    Friend WithEvents Pump2OutputButton As Button
    Friend WithEvents Pump2Label As Label
    Friend WithEvents SaveLabel As Label
    Friend WithEvents SaverRangeButton As Button
    Friend WithEvents FishDisplayLightButton As Button
    Friend WithEvents FishDisplayLightLabel As Label
    Friend WithEvents GrowLightLabel As Label
    Friend WithEvents GrowLightButton As Button
    Friend WithEvents ControlsGroupBox As GroupBox
    Friend WithEvents FoodTimeTextBox As TextBox
    Friend WithEvents FishFoodButton As Button
    Friend WithEvents FishFoodLabel As Label
    Friend WithEvents FishFoodGroupBox As GroupBox
    Friend WithEvents SaveTimeButton As Button
    Friend WithEvents FishFeederOutputButton As Button
    Friend WithEvents FishFeedLabel As Label
    Friend WithEvents FishFeederButton As Button
    Friend WithEvents FeedAgainCheckBox As CheckBox
    Friend WithEvents FishFeederControlLabel As Label
    Friend WithEvents FishFeederMainButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents OutputStatesGroupBox As GroupBox
    Friend WithEvents FishFoodAlertLabel As Label
End Class
