﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PonyEditorForm2
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
        Me.EditingArea = New System.Windows.Forms.SplitContainer()
        Me.Documents = New System.Windows.Forms.TabControl()
        Me.DocumentsView = New System.Windows.Forms.TreeView()
        Me.EditorToolStrip = New System.Windows.Forms.ToolStrip()
        Me.SaveItemButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseTabButton = New System.Windows.Forms.ToolStripButton()
        Me.CloseAllTabsButton = New System.Windows.Forms.ToolStripButton()
        Me.EditorStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.EditorStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EditorProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Output = New System.Windows.Forms.TabControl()
        Me.IssuesPage = New System.Windows.Forms.TabPage()
        Me.IssuesGrid = New System.Windows.Forms.DataGridView()
        Me.colFatal = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colIndex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFallback = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EditingArea.Panel1.SuspendLayout()
        Me.EditingArea.Panel2.SuspendLayout()
        Me.EditingArea.SuspendLayout()
        Me.EditorToolStrip.SuspendLayout()
        Me.EditorStatusStrip.SuspendLayout()
        Me.Output.SuspendLayout()
        Me.IssuesPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'EditingArea
        '
        Me.EditingArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditingArea.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.EditingArea.Location = New System.Drawing.Point(0, 28)
        Me.EditingArea.Name = "EditingArea"
        '
        'EditingArea.Panel1
        '
        Me.EditingArea.Panel1.Controls.Add(Me.Documents)
        Me.EditingArea.Panel1.UseWaitCursor = True
        Me.EditingArea.Panel1MinSize = 400
        '
        'EditingArea.Panel2
        '
        Me.EditingArea.Panel2.Controls.Add(Me.DocumentsView)
        Me.EditingArea.Panel2.UseWaitCursor = True
        Me.EditingArea.Panel2MinSize = 100
        Me.EditingArea.Size = New System.Drawing.Size(784, 253)
        Me.EditingArea.SplitterDistance = 550
        Me.EditingArea.TabIndex = 0
        Me.EditingArea.UseWaitCursor = True
        '
        'Documents
        '
        Me.Documents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Documents.Location = New System.Drawing.Point(0, 0)
        Me.Documents.Name = "Documents"
        Me.Documents.SelectedIndex = 0
        Me.Documents.Size = New System.Drawing.Size(550, 253)
        Me.Documents.TabIndex = 0
        Me.Documents.UseWaitCursor = True
        '
        'DocumentsView
        '
        Me.DocumentsView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentsView.FullRowSelect = True
        Me.DocumentsView.HotTracking = True
        Me.DocumentsView.Location = New System.Drawing.Point(0, 0)
        Me.DocumentsView.Name = "DocumentsView"
        Me.DocumentsView.Size = New System.Drawing.Size(230, 253)
        Me.DocumentsView.TabIndex = 0
        Me.DocumentsView.UseWaitCursor = True
        '
        'EditorToolStrip
        '
        Me.EditorToolStrip.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.EditorToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveItemButton, Me.CloseTabButton, Me.CloseAllTabsButton})
        Me.EditorToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.EditorToolStrip.Name = "EditorToolStrip"
        Me.EditorToolStrip.Size = New System.Drawing.Size(784, 25)
        Me.EditorToolStrip.TabIndex = 0
        Me.EditorToolStrip.Text = "Item Operations"
        Me.EditorToolStrip.UseWaitCursor = True
        '
        'SaveItemButton
        '
        Me.SaveItemButton.Enabled = False
        Me.SaveItemButton.Name = "SaveItemButton"
        Me.SaveItemButton.Size = New System.Drawing.Size(62, 22)
        Me.SaveItemButton.Text = "Save Item"
        '
        'CloseTabButton
        '
        Me.CloseTabButton.Enabled = False
        Me.CloseTabButton.Name = "CloseTabButton"
        Me.CloseTabButton.Size = New System.Drawing.Size(63, 22)
        Me.CloseTabButton.Text = "Close Tab"
        Me.CloseTabButton.ToolTipText = "Close the currently visible tab."
        '
        'CloseAllTabsButton
        '
        Me.CloseAllTabsButton.Enabled = False
        Me.CloseAllTabsButton.Name = "CloseAllTabsButton"
        Me.CloseAllTabsButton.Size = New System.Drawing.Size(85, 22)
        Me.CloseAllTabsButton.Text = "Close All Tabs"
        Me.CloseAllTabsButton.ToolTipText = "Close all open tabs."
        '
        'EditorStatusStrip
        '
        Me.EditorStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditorStatus, Me.EditorProgressBar})
        Me.EditorStatusStrip.Location = New System.Drawing.Point(0, 490)
        Me.EditorStatusStrip.Name = "EditorStatusStrip"
        Me.EditorStatusStrip.Size = New System.Drawing.Size(784, 22)
        Me.EditorStatusStrip.TabIndex = 2
        Me.EditorStatusStrip.Text = "StatusStrip1"
        Me.EditorStatusStrip.UseWaitCursor = True
        '
        'EditorStatus
        '
        Me.EditorStatus.AutoSize = False
        Me.EditorStatus.Name = "EditorStatus"
        Me.EditorStatus.Size = New System.Drawing.Size(80, 17)
        Me.EditorStatus.Text = "Loading..."
        Me.EditorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EditorStatus.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'EditorProgressBar
        '
        Me.EditorProgressBar.MarqueeAnimationSpeed = 33
        Me.EditorProgressBar.Name = "EditorProgressBar"
        Me.EditorProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.EditorProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'Output
        '
        Me.Output.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Output.Controls.Add(Me.IssuesPage)
        Me.Output.Location = New System.Drawing.Point(0, 287)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.SelectedIndex = 0
        Me.Output.Size = New System.Drawing.Size(784, 200)
        Me.Output.TabIndex = 3
        Me.Output.UseWaitCursor = True
        '
        'IssuesPage
        '
        Me.IssuesPage.Controls.Add(Me.IssuesGrid)
        Me.IssuesPage.Location = New System.Drawing.Point(4, 22)
        Me.IssuesPage.Name = "IssuesPage"
        Me.IssuesPage.Padding = New System.Windows.Forms.Padding(3)
        Me.IssuesPage.Size = New System.Drawing.Size(776, 174)
        Me.IssuesPage.TabIndex = 1
        Me.IssuesPage.Text = "Errors"
        Me.IssuesPage.UseVisualStyleBackColor = True
        Me.IssuesPage.UseWaitCursor = True
        '
        'IssuesGrid
        '
        Me.IssuesGrid.AllowUserToAddRows = False
        Me.IssuesGrid.AllowUserToDeleteRows = False
        Me.IssuesGrid.AllowUserToOrderColumns = True
        Me.IssuesGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.IssuesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.IssuesGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFatal, Me.colIndex, Me.colDescription, Me.colFallback, Me.colSource})
        Me.IssuesGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.IssuesGrid.Location = New System.Drawing.Point(3, 3)
        Me.IssuesGrid.Name = "IssuesGrid"
        Me.IssuesGrid.ReadOnly = True
        Me.IssuesGrid.ShowEditingIcon = False
        Me.IssuesGrid.Size = New System.Drawing.Size(770, 168)
        Me.IssuesGrid.TabIndex = 0
        Me.IssuesGrid.UseWaitCursor = True
        '
        'colFatal
        '
        Me.colFatal.HeaderText = "Fatal"
        Me.colFatal.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.colFatal.Name = "colFatal"
        Me.colFatal.ReadOnly = True
        Me.colFatal.ToolTipText = "Does this issue prevent the item being used?"
        Me.colFatal.Width = 35
        '
        'colIndex
        '
        Me.colIndex.HeaderText = "Property"
        Me.colIndex.Name = "colIndex"
        Me.colIndex.ReadOnly = True
        Me.colIndex.ToolTipText = "What setting is causing the issue?"
        Me.colIndex.Width = 80
        '
        'colDescription
        '
        Me.colDescription.HeaderText = "Description"
        Me.colDescription.Name = "colDescription"
        Me.colDescription.ReadOnly = True
        Me.colDescription.ToolTipText = "A description of the issue."
        Me.colDescription.Width = 300
        '
        'colFallback
        '
        Me.colFallback.HeaderText = "Fallback"
        Me.colFallback.Name = "colFallback"
        Me.colFallback.ReadOnly = True
        Me.colFallback.ToolTipText = "For non-fatal issues: the fallback value used."
        Me.colFallback.Width = 80
        '
        'colSource
        '
        Me.colSource.HeaderText = "Source"
        Me.colSource.Name = "colSource"
        Me.colSource.ReadOnly = True
        Me.colSource.ToolTipText = "The source text that has an issue."
        Me.colSource.Width = 300
        '
        'PonyEditorForm2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 512)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.EditorStatusStrip)
        Me.Controls.Add(Me.EditingArea)
        Me.Controls.Add(Me.EditorToolStrip)
        Me.KeyPreview = True
        Me.Name = "PonyEditorForm2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pony Editor - Desktop Ponies"
        Me.UseWaitCursor = True
        Me.EditingArea.Panel1.ResumeLayout(False)
        Me.EditingArea.Panel2.ResumeLayout(False)
        Me.EditingArea.ResumeLayout(False)
        Me.EditorToolStrip.ResumeLayout(False)
        Me.EditorToolStrip.PerformLayout()
        Me.EditorStatusStrip.ResumeLayout(False)
        Me.EditorStatusStrip.PerformLayout()
        Me.Output.ResumeLayout(False)
        Me.IssuesPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EditingArea As System.Windows.Forms.SplitContainer
    Friend WithEvents Documents As System.Windows.Forms.TabControl
    Friend WithEvents DocumentsView As System.Windows.Forms.TreeView
    Friend WithEvents EditorToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents EditorStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents EditorStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents EditorProgressBar As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents SaveItemButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Output As System.Windows.Forms.TabControl
    Friend WithEvents IssuesPage As System.Windows.Forms.TabPage
    Private WithEvents CloseTabButton As System.Windows.Forms.ToolStripButton
    Private WithEvents CloseAllTabsButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents IssuesGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colFatal As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colIndex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescription As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFallback As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSource As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
