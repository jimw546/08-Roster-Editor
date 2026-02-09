<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDBStadium
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDBStadium))
        DataGridView1 = New DataGridView()
        Label21 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        DataGridView2 = New DataGridView()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TableLayoutPanel1.SetColumnSpan(DataGridView1, 2)
        DataGridView1.Dock = DockStyle.Fill
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.MultiSelect = False
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(797, 574)
        DataGridView1.TabIndex = 0
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(3, 580)
        Label21.Name = "Label21"
        Label21.Size = New Size(396, 60)
        Label21.TabIndex = 123
        Label21.Text = "Team Performance, 1 is High, 5 is Low." & vbCrLf & vbCrLf & "Values outside this may cause weird issues in CPU matches."
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle())
        TableLayoutPanel1.Controls.Add(DataGridView2, 1, 0)
        TableLayoutPanel1.Controls.Add(Label1, 1, 1)
        TableLayoutPanel1.Controls.Add(DataGridView1, 0, 0)
        TableLayoutPanel1.Controls.Add(Label21, 0, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 138F))
        TableLayoutPanel1.Size = New Size(1392, 718)
        TableLayoutPanel1.TabIndex = 125
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Dock = DockStyle.Fill
        DataGridView2.EditMode = DataGridViewEditMode.EditOnKeystroke
        DataGridView2.Location = New Point(806, 3)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersWidth = 51
        TableLayoutPanel1.SetRowSpan(DataGridView2, 2)
        DataGridView2.Size = New Size(830, 712)
        DataGridView2.TabIndex = 126
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(405, 580)
        Label1.Name = "Label1"
        Label1.Size = New Size(395, 60)
        Label1.TabIndex = 125
        Label1.Text = "Edit values in the left table, auto-updates the Team data." & vbCrLf & vbCrLf & "The right table cannot be edited, pulls data from be29.xml"
        ' 
        ' FormDBStadium
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1392, 718)
        Controls.Add(TableLayoutPanel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormDBStadium"
        Text = "Performance & Stadium"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
