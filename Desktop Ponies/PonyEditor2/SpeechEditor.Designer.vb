﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SpeechEditor
    Inherits ItemEditorBase

    'UserControl overrides dispose to clean up the component list.
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
        Me.PropertiesTable = New System.Windows.Forms.TableLayoutPanel()
        Me.LineLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.LineTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SoundFileLabel = New System.Windows.Forms.Label()
        Me.RandomLabel = New System.Windows.Forms.Label()
        Me.GroupLabel = New System.Windows.Forms.Label()
        Me.RandomCheckBox = New System.Windows.Forms.CheckBox()
        Me.SoundFileSelector = New DesktopPonies.FileSelector()
        Me.GroupNumber = New System.Windows.Forms.NumericUpDown()
        Me.SoundPreviewPanel = New System.Windows.Forms.Panel()
        Me.SoundPreviewLabel = New System.Windows.Forms.Label()
        Me.SoundPreviewButton = New System.Windows.Forms.Button()
        Me.SoundTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PropertiesPanel.SuspendLayout()
        Me.PropertiesTable.SuspendLayout()
        Me.SoundPreviewPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PropertiesPanel
        '
        Me.PropertiesPanel.Controls.Add(Me.PropertiesTable)
        '
        'PropertiesTable
        '
        Me.PropertiesTable.AutoSize = True
        Me.PropertiesTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PropertiesTable.ColumnCount = 2
        Me.PropertiesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PropertiesTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.PropertiesTable.Controls.Add(Me.LineLabel, 0, 1)
        Me.PropertiesTable.Controls.Add(Me.NameTextBox, 1, 0)
        Me.PropertiesTable.Controls.Add(Me.LineTextBox, 1, 1)
        Me.PropertiesTable.Controls.Add(Me.NameLabel, 0, 0)
        Me.PropertiesTable.Controls.Add(Me.SoundFileLabel, 0, 2)
        Me.PropertiesTable.Controls.Add(Me.RandomLabel, 0, 4)
        Me.PropertiesTable.Controls.Add(Me.GroupLabel, 0, 5)
        Me.PropertiesTable.Controls.Add(Me.RandomCheckBox, 1, 4)
        Me.PropertiesTable.Controls.Add(Me.SoundFileSelector, 1, 2)
        Me.PropertiesTable.Controls.Add(Me.GroupNumber, 1, 5)
        Me.PropertiesTable.Controls.Add(Me.SoundPreviewPanel, 1, 3)
        Me.PropertiesTable.Location = New System.Drawing.Point(0, 0)
        Me.PropertiesTable.Name = "PropertiesTable"
        Me.PropertiesTable.RowCount = 6
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PropertiesTable.Size = New System.Drawing.Size(615, 201)
        Me.PropertiesTable.TabIndex = 0
        '
        'LineLabel
        '
        Me.LineLabel.AutoSize = True
        Me.LineLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.LineLabel.Location = New System.Drawing.Point(3, 32)
        Me.LineLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.LineLabel.Name = "LineLabel"
        Me.LineLabel.Size = New System.Drawing.Size(79, 13)
        Me.LineLabel.TabIndex = 2
        Me.LineLabel.Text = "Line:"
        Me.LineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.Location = New System.Drawing.Point(88, 3)
        Me.NameTextBox.MaxLength = 50
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(524, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'LineTextBox
        '
        Me.LineTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineTextBox.Location = New System.Drawing.Point(88, 29)
        Me.LineTextBox.MaxLength = 300
        Me.LineTextBox.Multiline = True
        Me.LineTextBox.Name = "LineTextBox"
        Me.LineTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.LineTextBox.Size = New System.Drawing.Size(524, 60)
        Me.LineTextBox.TabIndex = 3
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NameLabel.Location = New System.Drawing.Point(3, 6)
        Me.NameLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(79, 13)
        Me.NameLabel.TabIndex = 0
        Me.NameLabel.Text = "Name:"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SoundFileLabel
        '
        Me.SoundFileLabel.AutoSize = True
        Me.SoundFileLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.SoundFileLabel.Location = New System.Drawing.Point(3, 98)
        Me.SoundFileLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.SoundFileLabel.Name = "SoundFileLabel"
        Me.SoundFileLabel.Size = New System.Drawing.Size(79, 13)
        Me.SoundFileLabel.TabIndex = 4
        Me.SoundFileLabel.Text = "Sound File:"
        Me.SoundFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RandomLabel
        '
        Me.RandomLabel.AutoSize = True
        Me.RandomLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.RandomLabel.Location = New System.Drawing.Point(3, 156)
        Me.RandomLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.RandomLabel.Name = "RandomLabel"
        Me.RandomLabel.Size = New System.Drawing.Size(79, 13)
        Me.RandomLabel.TabIndex = 7
        Me.RandomLabel.Text = "Use Randomly:"
        Me.RandomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupLabel
        '
        Me.GroupLabel.AutoSize = True
        Me.GroupLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupLabel.Location = New System.Drawing.Point(3, 181)
        Me.GroupLabel.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.GroupLabel.Name = "GroupLabel"
        Me.GroupLabel.Size = New System.Drawing.Size(79, 13)
        Me.GroupLabel.TabIndex = 9
        Me.GroupLabel.Text = "Group:"
        Me.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RandomCheckBox
        '
        Me.RandomCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RandomCheckBox.AutoSize = True
        Me.RandomCheckBox.Location = New System.Drawing.Point(88, 153)
        Me.RandomCheckBox.Name = "RandomCheckBox"
        Me.RandomCheckBox.Size = New System.Drawing.Size(15, 19)
        Me.RandomCheckBox.TabIndex = 8
        Me.RandomCheckBox.UseVisualStyleBackColor = True
        '
        'SoundFileSelector
        '
        Me.SoundFileSelector.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SoundFileSelector.AutoSize = True
        Me.SoundFileSelector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SoundFileSelector.Location = New System.Drawing.Point(88, 95)
        Me.SoundFileSelector.Name = "SoundFileSelector"
        Me.SoundFileSelector.Size = New System.Drawing.Size(524, 23)
        Me.SoundFileSelector.TabIndex = 5
        '
        'GroupNumber
        '
        Me.GroupNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupNumber.Location = New System.Drawing.Point(88, 178)
        Me.GroupNumber.Name = "GroupNumber"
        Me.GroupNumber.Size = New System.Drawing.Size(524, 20)
        Me.GroupNumber.TabIndex = 10
        '
        'SoundPreviewPanel
        '
        Me.SoundPreviewPanel.AutoSize = True
        Me.SoundPreviewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.SoundPreviewPanel.Controls.Add(Me.SoundPreviewLabel)
        Me.SoundPreviewPanel.Controls.Add(Me.SoundPreviewButton)
        Me.SoundPreviewPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SoundPreviewPanel.Enabled = False
        Me.SoundPreviewPanel.Location = New System.Drawing.Point(85, 121)
        Me.SoundPreviewPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.SoundPreviewPanel.Name = "SoundPreviewPanel"
        Me.SoundPreviewPanel.Size = New System.Drawing.Size(530, 29)
        Me.SoundPreviewPanel.TabIndex = 6
        '
        'SoundPreviewLabel
        '
        Me.SoundPreviewLabel.AutoSize = True
        Me.SoundPreviewLabel.Location = New System.Drawing.Point(84, 8)
        Me.SoundPreviewLabel.Name = "SoundPreviewLabel"
        Me.SoundPreviewLabel.Size = New System.Drawing.Size(0, 13)
        Me.SoundPreviewLabel.TabIndex = 1
        '
        'SoundPreviewButton
        '
        Me.SoundPreviewButton.Location = New System.Drawing.Point(3, 3)
        Me.SoundPreviewButton.Name = "SoundPreviewButton"
        Me.SoundPreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundPreviewButton.TabIndex = 0
        Me.SoundPreviewButton.Text = "Play"
        Me.SoundPreviewButton.UseVisualStyleBackColor = True
        '
        'SoundTimer
        '
        Me.SoundTimer.Interval = 50
        '
        'SpeechEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "SpeechEditor"
        Me.PropertiesPanel.ResumeLayout(False)
        Me.PropertiesPanel.PerformLayout()
        Me.PropertiesTable.ResumeLayout(False)
        Me.PropertiesTable.PerformLayout()
        Me.SoundPreviewPanel.ResumeLayout(False)
        Me.SoundPreviewPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PropertiesTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NameLabel As System.Windows.Forms.Label
    Friend WithEvents LineLabel As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LineTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SoundFileLabel As System.Windows.Forms.Label
    Friend WithEvents RandomLabel As System.Windows.Forms.Label
    Friend WithEvents GroupLabel As System.Windows.Forms.Label
    Friend WithEvents RandomCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents SoundFileSelector As DesktopPonies.FileSelector
    Friend WithEvents GroupNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents SoundPreviewPanel As System.Windows.Forms.Panel
    Friend WithEvents SoundPreviewLabel As System.Windows.Forms.Label
    Friend WithEvents SoundPreviewButton As System.Windows.Forms.Button
    Friend WithEvents SoundTimer As System.Windows.Forms.Timer

End Class
