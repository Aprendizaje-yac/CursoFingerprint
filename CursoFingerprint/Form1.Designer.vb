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
        Me.pb_ImagenHuella = New System.Windows.Forms.PictureBox()
        CType(Me.pb_ImagenHuella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_ImagenHuella
        '
        Me.pb_ImagenHuella.Location = New System.Drawing.Point(69, 31)
        Me.pb_ImagenHuella.Name = "pb_ImagenHuella"
        Me.pb_ImagenHuella.Size = New System.Drawing.Size(449, 300)
        Me.pb_ImagenHuella.TabIndex = 0
        Me.pb_ImagenHuella.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 343)
        Me.Controls.Add(Me.pb_ImagenHuella)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pb_ImagenHuella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pb_ImagenHuella As PictureBox
End Class
