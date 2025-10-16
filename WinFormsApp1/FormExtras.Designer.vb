<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormExtras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormExtras))
        Label5 = New Label()
        Label4 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        ButtonInjuriesOn = New Button()
        ButtonInjuriesOff = New Button()
        ButtonStadium = New Button()
        ButtonFileNames = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(59, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 20)
        Label5.TabIndex = 22
        Label5.Text = "Players DB"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(59, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 20)
        Label4.TabIndex = 21
        Label4.Text = "Teams DB"
        ' 
        ' Button4
        ' 
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Zoom
        Button4.Location = New Point(12, 74)
        Button4.Name = "Button4"
        Button4.Size = New Size(41, 43)
        Button4.TabIndex = 20
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Zoom
        Button3.Location = New Point(12, 25)
        Button3.Name = "Button3"
        Button3.Size = New Size(41, 43)
        Button3.TabIndex = 19
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ButtonInjuriesOn
        ' 
        ButtonInjuriesOn.Location = New Point(202, 119)
        ButtonInjuriesOn.Name = "ButtonInjuriesOn"
        ButtonInjuriesOn.Size = New Size(115, 29)
        ButtonInjuriesOn.TabIndex = 25
        ButtonInjuriesOn.Text = "Injuries On"
        ButtonInjuriesOn.UseVisualStyleBackColor = True
        ' 
        ' ButtonInjuriesOff
        ' 
        ButtonInjuriesOff.Location = New Point(202, 154)
        ButtonInjuriesOff.Name = "ButtonInjuriesOff"
        ButtonInjuriesOff.Size = New Size(115, 29)
        ButtonInjuriesOff.TabIndex = 26
        ButtonInjuriesOff.Text = "Injuries Off"
        ButtonInjuriesOff.UseVisualStyleBackColor = True
        ' 
        ' ButtonStadium
        ' 
        ButtonStadium.Location = New Point(202, 25)
        ButtonStadium.Name = "ButtonStadium"
        ButtonStadium.Size = New Size(115, 53)
        ButtonStadium.TabIndex = 27
        ButtonStadium.Text = "Stadiums and Performance"
        ButtonStadium.UseVisualStyleBackColor = True
        ' 
        ' ButtonFileNames
        ' 
        ButtonFileNames.Location = New Point(202, 84)
        ButtonFileNames.Name = "ButtonFileNames"
        ButtonFileNames.Size = New Size(115, 29)
        ButtonFileNames.TabIndex = 28
        ButtonFileNames.Text = "File Names"
        ButtonFileNames.UseVisualStyleBackColor = True
        ' 
        ' FormExtras
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(360, 208)
        Controls.Add(ButtonFileNames)
        Controls.Add(ButtonStadium)
        Controls.Add(ButtonInjuriesOff)
        Controls.Add(ButtonInjuriesOn)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "FormExtras"
        Text = "Extras"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ButtonInjuriesOn As Button
    Friend WithEvents ButtonInjuriesOff As Button
    Friend WithEvents ButtonStadium As Button
    Friend WithEvents ButtonFileNames As Button
End Class
