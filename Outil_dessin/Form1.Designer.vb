<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonInitialiser = New System.Windows.Forms.Button()
        Me.ButtonNord = New System.Windows.Forms.Button()
        Me.ButtonSud = New System.Windows.Forms.Button()
        Me.ButtonEst = New System.Windows.Forms.Button()
        Me.ButtonOuest = New System.Windows.Forms.Button()
        Me.ButtonAvancer = New System.Windows.Forms.Button()
        Me.ButtonLever = New System.Windows.Forms.Button()
        Me.ButtonBaisser = New System.Windows.Forms.Button()
        Me.ButtonCentrer = New System.Windows.Forms.Button()
        Me.TextBoxCoordx = New System.Windows.Forms.TextBox()
        Me.TextBoxCoordy = New System.Windows.Forms.TextBox()
        Me.TextBoxOrientation = New System.Windows.Forms.TextBox()
        Me.TextBoxEtatLevée = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ButtonTracer = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.ButtonCarré = New System.Windows.Forms.Button()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.ButtonTraitInterrompu = New System.Windows.Forms.Button()
        Me.ButtonCarréInterrompu = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(70, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 500)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ButtonInitialiser
        '
        Me.ButtonInitialiser.Location = New System.Drawing.Point(633, 48)
        Me.ButtonInitialiser.Name = "ButtonInitialiser"
        Me.ButtonInitialiser.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInitialiser.TabIndex = 1
        Me.ButtonInitialiser.Text = "Initialiser"
        Me.ButtonInitialiser.UseVisualStyleBackColor = True
        '
        'ButtonNord
        '
        Me.ButtonNord.BackgroundImage = CType(resources.GetObject("ButtonNord.BackgroundImage"), System.Drawing.Image)
        Me.ButtonNord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonNord.Cursor = System.Windows.Forms.Cursors.PanNorth
        Me.ButtonNord.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonNord.Location = New System.Drawing.Point(712, 120)
        Me.ButtonNord.Name = "ButtonNord"
        Me.ButtonNord.Size = New System.Drawing.Size(75, 23)
        Me.ButtonNord.TabIndex = 2
        Me.ButtonNord.Text = "Nord"
        Me.ButtonNord.UseVisualStyleBackColor = True
        '
        'ButtonSud
        '
        Me.ButtonSud.BackgroundImage = CType(resources.GetObject("ButtonSud.BackgroundImage"), System.Drawing.Image)
        Me.ButtonSud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSud.Cursor = System.Windows.Forms.Cursors.PanSouth
        Me.ButtonSud.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonSud.Location = New System.Drawing.Point(712, 212)
        Me.ButtonSud.Name = "ButtonSud"
        Me.ButtonSud.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSud.TabIndex = 3
        Me.ButtonSud.Text = "Sud"
        Me.ButtonSud.UseVisualStyleBackColor = True
        '
        'ButtonEst
        '
        Me.ButtonEst.BackgroundImage = CType(resources.GetObject("ButtonEst.BackgroundImage"), System.Drawing.Image)
        Me.ButtonEst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonEst.Cursor = System.Windows.Forms.Cursors.PanEast
        Me.ButtonEst.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonEst.Location = New System.Drawing.Point(786, 168)
        Me.ButtonEst.Name = "ButtonEst"
        Me.ButtonEst.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEst.TabIndex = 4
        Me.ButtonEst.Text = "Est"
        Me.ButtonEst.UseVisualStyleBackColor = True
        '
        'ButtonOuest
        '
        Me.ButtonOuest.BackgroundImage = CType(resources.GetObject("ButtonOuest.BackgroundImage"), System.Drawing.Image)
        Me.ButtonOuest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonOuest.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.ButtonOuest.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ButtonOuest.Location = New System.Drawing.Point(644, 168)
        Me.ButtonOuest.Name = "ButtonOuest"
        Me.ButtonOuest.Size = New System.Drawing.Size(75, 23)
        Me.ButtonOuest.TabIndex = 5
        Me.ButtonOuest.Text = "Ouest"
        Me.ButtonOuest.UseVisualStyleBackColor = True
        '
        'ButtonAvancer
        '
        Me.ButtonAvancer.Cursor = System.Windows.Forms.Cursors.UpArrow
        Me.ButtonAvancer.Location = New System.Drawing.Point(786, 274)
        Me.ButtonAvancer.Name = "ButtonAvancer"
        Me.ButtonAvancer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAvancer.TabIndex = 6
        Me.ButtonAvancer.Text = "Avancer"
        Me.ButtonAvancer.UseVisualStyleBackColor = True
        '
        'ButtonLever
        '
        Me.ButtonLever.Location = New System.Drawing.Point(644, 274)
        Me.ButtonLever.Name = "ButtonLever"
        Me.ButtonLever.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLever.TabIndex = 7
        Me.ButtonLever.Text = "Lever"
        Me.ButtonLever.UseVisualStyleBackColor = True
        '
        'ButtonBaisser
        '
        Me.ButtonBaisser.Location = New System.Drawing.Point(644, 328)
        Me.ButtonBaisser.Name = "ButtonBaisser"
        Me.ButtonBaisser.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBaisser.TabIndex = 8
        Me.ButtonBaisser.Text = "Baisser"
        Me.ButtonBaisser.UseVisualStyleBackColor = True
        '
        'ButtonCentrer
        '
        Me.ButtonCentrer.Cursor = System.Windows.Forms.Cursors.Cross
        Me.ButtonCentrer.Location = New System.Drawing.Point(786, 328)
        Me.ButtonCentrer.Name = "ButtonCentrer"
        Me.ButtonCentrer.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCentrer.TabIndex = 9
        Me.ButtonCentrer.Text = "Centrer"
        Me.ButtonCentrer.UseVisualStyleBackColor = True
        '
        'TextBoxCoordx
        '
        Me.TextBoxCoordx.Location = New System.Drawing.Point(826, 376)
        Me.TextBoxCoordx.Name = "TextBoxCoordx"
        Me.TextBoxCoordx.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCoordx.TabIndex = 10
        '
        'TextBoxCoordy
        '
        Me.TextBoxCoordy.Location = New System.Drawing.Point(826, 418)
        Me.TextBoxCoordy.Name = "TextBoxCoordy"
        Me.TextBoxCoordy.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxCoordy.TabIndex = 11
        '
        'TextBoxOrientation
        '
        Me.TextBoxOrientation.Location = New System.Drawing.Point(826, 462)
        Me.TextBoxOrientation.Name = "TextBoxOrientation"
        Me.TextBoxOrientation.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxOrientation.TabIndex = 12
        '
        'TextBoxEtatLevée
        '
        Me.TextBoxEtatLevée.Location = New System.Drawing.Point(826, 505)
        Me.TextBoxEtatLevée.Name = "TextBoxEtatLevée"
        Me.TextBoxEtatLevée.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxEtatLevée.TabIndex = 13
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(644, 376)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(148, 23)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "Coordonnés x de la plume"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(644, 418)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(148, 23)
        Me.TextBox2.TabIndex = 15
        Me.TextBox2.Text = "Coordonnés y de la plume"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(644, 462)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(143, 23)
        Me.TextBox3.TabIndex = 16
        Me.TextBox3.Text = "Orientation de la plume"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(644, 505)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(143, 23)
        Me.TextBox4.TabIndex = 17
        Me.TextBox4.Text = "La plume est levée"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(644, 557)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(143, 23)
        Me.TextBox5.TabIndex = 18
        Me.TextBox5.Text = "Longueur du trait voulu :"
        '
        'ButtonTracer
        '
        Me.ButtonTracer.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTracer.Location = New System.Drawing.Point(520, 557)
        Me.ButtonTracer.Name = "ButtonTracer"
        Me.ButtonTracer.Size = New System.Drawing.Size(91, 23)
        Me.ButtonTracer.TabIndex = 19
        Me.ButtonTracer.Text = "Tracer un trait"
        Me.ButtonTracer.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(826, 556)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 23)
        Me.TextBox6.TabIndex = 20
        '
        'ButtonCarré
        '
        Me.ButtonCarré.Location = New System.Drawing.Point(12, 557)
        Me.ButtonCarré.Name = "ButtonCarré"
        Me.ButtonCarré.Size = New System.Drawing.Size(97, 23)
        Me.ButtonCarré.TabIndex = 21
        Me.ButtonCarré.Text = "Tracer un carré"
        Me.ButtonCarré.UseVisualStyleBackColor = True
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(146, 556)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(217, 23)
        Me.TextBox7.TabIndex = 22
        Me.TextBox7.Text = "Coordonné x du centre du carré voulu :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(394, 557)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 23)
        Me.TextBox8.TabIndex = 23
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(146, 599)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(217, 23)
        Me.TextBox9.TabIndex = 24
        Me.TextBox9.Text = "Coordonné y du centre du carré voulu :"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(394, 599)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 23)
        Me.TextBox10.TabIndex = 25
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(146, 639)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(217, 23)
        Me.TextBox11.TabIndex = 26
        Me.TextBox11.Text = "Longueur des cotés du carré voulu :"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(394, 639)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 23)
        Me.TextBox12.TabIndex = 27
        '
        'ButtonTraitInterrompu
        '
        Me.ButtonTraitInterrompu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ButtonTraitInterrompu.Location = New System.Drawing.Point(520, 599)
        Me.ButtonTraitInterrompu.Name = "ButtonTraitInterrompu"
        Me.ButtonTraitInterrompu.Size = New System.Drawing.Size(91, 38)
        Me.ButtonTraitInterrompu.TabIndex = 28
        Me.ButtonTraitInterrompu.Text = "Tracer un trait interrompu"
        Me.ButtonTraitInterrompu.UseVisualStyleBackColor = True
        '
        'ButtonCarréInterrompu
        '
        Me.ButtonCarréInterrompu.Location = New System.Drawing.Point(12, 599)
        Me.ButtonCarréInterrompu.Name = "ButtonCarréInterrompu"
        Me.ButtonCarréInterrompu.Size = New System.Drawing.Size(97, 38)
        Me.ButtonCarréInterrompu.TabIndex = 29
        Me.ButtonCarréInterrompu.Text = "Tracer un carré Interrompu"
        Me.ButtonCarréInterrompu.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(948, 674)
        Me.Controls.Add(Me.ButtonCarréInterrompu)
        Me.Controls.Add(Me.ButtonTraitInterrompu)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.ButtonCarré)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.ButtonTracer)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxEtatLevée)
        Me.Controls.Add(Me.TextBoxOrientation)
        Me.Controls.Add(Me.TextBoxCoordy)
        Me.Controls.Add(Me.TextBoxCoordx)
        Me.Controls.Add(Me.ButtonCentrer)
        Me.Controls.Add(Me.ButtonBaisser)
        Me.Controls.Add(Me.ButtonLever)
        Me.Controls.Add(Me.ButtonAvancer)
        Me.Controls.Add(Me.ButtonOuest)
        Me.Controls.Add(Me.ButtonEst)
        Me.Controls.Add(Me.ButtonSud)
        Me.Controls.Add(Me.ButtonNord)
        Me.Controls.Add(Me.ButtonInitialiser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonInitialiser As Button
    Friend WithEvents ButtonNord As Button
    Friend WithEvents ButtonSud As Button
    Friend WithEvents ButtonEst As Button
    Friend WithEvents ButtonOuest As Button
    Friend WithEvents ButtonAvancer As Button
    Friend WithEvents ButtonLever As Button
    Friend WithEvents ButtonBaisser As Button
    Friend WithEvents ButtonCentrer As Button
    Friend WithEvents TextBoxCoordx As TextBox
    Friend WithEvents TextBoxCoordy As TextBox
    Friend WithEvents TextBoxOrientation As TextBox
    Friend WithEvents TextBoxEtatLevée As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ButtonTracer As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ButtonCarré As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents ButtonTraitInterrompu As Button
    Friend WithEvents ButtonCarréInterrompu As Button
End Class
