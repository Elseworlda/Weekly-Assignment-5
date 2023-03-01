<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pctSuperheroes = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblGroupSize = New System.Windows.Forms.Label()
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.grpBadgeType = New System.Windows.Forms.GroupBox()
        Me.rdoConvention = New System.Windows.Forms.RadioButton()
        Me.rdoAutograph = New System.Windows.Forms.RadioButton()
        Me.rdoSuperhero = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblClear = New System.Windows.Forms.Button()
        Me.lblRegistrationCost = New System.Windows.Forms.Label()
        Me.lblFinalCost = New System.Windows.Forms.Label()
        Me.ErrorDisplay = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pctSuperheroes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBadgeType.SuspendLayout()
        CType(Me.ErrorDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctSuperheroes
        '
        Me.pctSuperheroes.Image = CType(resources.GetObject("pctSuperheroes.Image"), System.Drawing.Image)
        Me.pctSuperheroes.Location = New System.Drawing.Point(0, -1)
        Me.pctSuperheroes.Name = "pctSuperheroes"
        Me.pctSuperheroes.Size = New System.Drawing.Size(665, 144)
        Me.pctSuperheroes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctSuperheroes.TabIndex = 0
        Me.pctSuperheroes.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Comic Sans MS", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblHeader.Location = New System.Drawing.Point(51, 181)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(585, 56)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Comic Convention Registration"
        '
        'lblGroupSize
        '
        Me.lblGroupSize.AutoSize = True
        Me.lblGroupSize.Font = New System.Drawing.Font("Comic Sans MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroupSize.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroupSize.Location = New System.Drawing.Point(198, 254)
        Me.lblGroupSize.Name = "lblGroupSize"
        Me.lblGroupSize.Size = New System.Drawing.Size(171, 39)
        Me.lblGroupSize.TabIndex = 2
        Me.lblGroupSize.Text = "Group size: "
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Location = New System.Drawing.Point(403, 268)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(62, 22)
        Me.txtGroupSize.TabIndex = 3
        '
        'grpBadgeType
        '
        Me.grpBadgeType.BackColor = System.Drawing.Color.DarkTurquoise
        Me.grpBadgeType.Controls.Add(Me.rdoConvention)
        Me.grpBadgeType.Controls.Add(Me.rdoAutograph)
        Me.grpBadgeType.Controls.Add(Me.rdoSuperhero)
        Me.grpBadgeType.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBadgeType.ForeColor = System.Drawing.Color.OrangeRed
        Me.grpBadgeType.Location = New System.Drawing.Point(126, 313)
        Me.grpBadgeType.Name = "grpBadgeType"
        Me.grpBadgeType.Size = New System.Drawing.Size(388, 155)
        Me.grpBadgeType.TabIndex = 4
        Me.grpBadgeType.TabStop = False
        Me.grpBadgeType.Text = "Select Badge Type:"
        '
        'rdoConvention
        '
        Me.rdoConvention.AutoSize = True
        Me.rdoConvention.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoConvention.Location = New System.Drawing.Point(6, 113)
        Me.rdoConvention.Name = "rdoConvention"
        Me.rdoConvention.Size = New System.Drawing.Size(120, 29)
        Me.rdoConvention.TabIndex = 2
        Me.rdoConvention.TabStop = True
        Me.rdoConvention.Text = "Convention"
        Me.rdoConvention.UseVisualStyleBackColor = True
        '
        'rdoAutograph
        '
        Me.rdoAutograph.AutoSize = True
        Me.rdoAutograph.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoAutograph.Location = New System.Drawing.Point(6, 78)
        Me.rdoAutograph.Name = "rdoAutograph"
        Me.rdoAutograph.Size = New System.Drawing.Size(227, 29)
        Me.rdoAutograph.TabIndex = 1
        Me.rdoAutograph.TabStop = True
        Me.rdoAutograph.Text = "Convention + Autograph"
        Me.rdoAutograph.UseVisualStyleBackColor = True
        '
        'rdoSuperhero
        '
        Me.rdoSuperhero.AutoSize = True
        Me.rdoSuperhero.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoSuperhero.Location = New System.Drawing.Point(6, 43)
        Me.rdoSuperhero.Name = "rdoSuperhero"
        Me.rdoSuperhero.Size = New System.Drawing.Size(327, 29)
        Me.rdoSuperhero.TabIndex = 0
        Me.rdoSuperhero.TabStop = True
        Me.rdoSuperhero.Text = "Convention + Superhero Experience"
        Me.rdoSuperhero.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.OrangeRed
        Me.btnCalculate.Location = New System.Drawing.Point(61, 556)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(220, 47)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblClear
        '
        Me.lblClear.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClear.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblClear.Location = New System.Drawing.Point(403, 556)
        Me.lblClear.Name = "lblClear"
        Me.lblClear.Size = New System.Drawing.Size(219, 47)
        Me.lblClear.TabIndex = 6
        Me.lblClear.Text = "Clear"
        Me.lblClear.UseVisualStyleBackColor = True
        '
        'lblRegistrationCost
        '
        Me.lblRegistrationCost.AutoSize = True
        Me.lblRegistrationCost.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistrationCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegistrationCost.Location = New System.Drawing.Point(129, 489)
        Me.lblRegistrationCost.Name = "lblRegistrationCost"
        Me.lblRegistrationCost.Size = New System.Drawing.Size(161, 25)
        Me.lblRegistrationCost.TabIndex = 7
        Me.lblRegistrationCost.Text = "Registration Cost:"
        '
        'lblFinalCost
        '
        Me.lblFinalCost.AutoSize = True
        Me.lblFinalCost.Font = New System.Drawing.Font("Comic Sans MS", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalCost.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblFinalCost.Location = New System.Drawing.Point(406, 486)
        Me.lblFinalCost.Name = "lblFinalCost"
        Me.lblFinalCost.Size = New System.Drawing.Size(65, 25)
        Me.lblFinalCost.TabIndex = 8
        Me.lblFinalCost.Text = "Label4"
        '
        'ErrorDisplay
        '
        Me.ErrorDisplay.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 612)
        Me.Controls.Add(Me.lblFinalCost)
        Me.Controls.Add(Me.lblRegistrationCost)
        Me.Controls.Add(Me.lblClear)
        Me.Controls.Add(Me.pctSuperheroes)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBadgeType)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Controls.Add(Me.lblGroupSize)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctSuperheroes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBadgeType.ResumeLayout(False)
        Me.grpBadgeType.PerformLayout()
        CType(Me.ErrorDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctSuperheroes As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblGroupSize As Label
    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents grpBadgeType As GroupBox
    Friend WithEvents rdoConvention As RadioButton
    Friend WithEvents rdoAutograph As RadioButton
    Friend WithEvents rdoSuperhero As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblClear As Button
    Friend WithEvents lblRegistrationCost As Label
    Friend WithEvents lblFinalCost As Label
    Friend WithEvents ErrorDisplay As ErrorProvider
End Class
