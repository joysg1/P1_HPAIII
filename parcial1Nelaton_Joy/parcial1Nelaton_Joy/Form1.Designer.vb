<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPredecir = New System.Windows.Forms.Button()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.tbDia = New System.Windows.Forms.TextBox()
        Me.lbPredic = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gBoxDatos = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(202, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUE LE DEPARA EL DESTINO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mes de nacimiento: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dia de nacimiento: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Prediccion: "
        '
        'btnPredecir
        '
        Me.btnPredecir.Location = New System.Drawing.Point(343, 252)
        Me.btnPredecir.Name = "btnPredecir"
        Me.btnPredecir.Size = New System.Drawing.Size(152, 39)
        Me.btnPredecir.TabIndex = 4
        Me.btnPredecir.Text = "Predecir el futuro"
        Me.btnPredecir.UseVisualStyleBackColor = True
        '
        'cbMes
        '
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMes.Location = New System.Drawing.Point(184, 18)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(145, 24)
        Me.cbMes.TabIndex = 5
        Me.cbMes.Text = "Seleccione el mes"
        '
        'tbDia
        '
        Me.tbDia.Location = New System.Drawing.Point(184, 63)
        Me.tbDia.Name = "tbDia"
        Me.tbDia.Size = New System.Drawing.Size(36, 22)
        Me.tbDia.TabIndex = 6
        '
        'lbPredic
        '
        Me.lbPredic.AutoSize = True
        Me.lbPredic.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPredic.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbPredic.Location = New System.Drawing.Point(184, 111)
        Me.lbPredic.Name = "lbPredic"
        Me.lbPredic.Size = New System.Drawing.Size(0, 17)
        Me.lbPredic.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(607, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(165, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'gBoxDatos
        '
        Me.gBoxDatos.Controls.Add(Me.Label2)
        Me.gBoxDatos.Controls.Add(Me.Label3)
        Me.gBoxDatos.Controls.Add(Me.lbPredic)
        Me.gBoxDatos.Controls.Add(Me.Label4)
        Me.gBoxDatos.Controls.Add(Me.tbDia)
        Me.gBoxDatos.Controls.Add(Me.cbMes)
        Me.gBoxDatos.Location = New System.Drawing.Point(21, 68)
        Me.gBoxDatos.Name = "gBoxDatos"
        Me.gBoxDatos.Size = New System.Drawing.Size(567, 162)
        Me.gBoxDatos.TabIndex = 9
        Me.gBoxDatos.TabStop = False
        Me.gBoxDatos.Text = "Datos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(810, 331)
        Me.Controls.Add(Me.gBoxDatos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPredecir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MAKUMBERO APP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxDatos.ResumeLayout(False)
        Me.gBoxDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnPredecir As System.Windows.Forms.Button
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents tbDia As System.Windows.Forms.TextBox
    Friend WithEvents lbPredic As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gBoxDatos As System.Windows.Forms.GroupBox

End Class
