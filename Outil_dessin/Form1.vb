Public Class Form1

    Private Sub ButtonInitialiser_Click(sender As Object, e As EventArgs) Handles ButtonInitialiser.Click
        PictureBox1.Image = feuille
        lecentre.x = 250
        lecentre.y = 250
        laplume.Coord.x = 250
        laplume.Coord.y = 250
        laplume.OrientationPlume = Orientation.Nord
        laplume.EtatLevée = True
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        TextBoxEtatLevée.Text = laplume.EtatLevée
        TextBox1.Text = "Coordonnés x de la plume"
        TextBox2.Text = "Coordonnés y de la plume"
        TextBox3.Text = "Orientation de la plume"
        TextBox4.Text = "La plume est levée"
        TextBox5.Text = "Longueur du trait voulu :"
        TextBox7.Text = "Coordonné x du centre du carré voulu :"
        TextBox9.Text = "Coordonné y du centre du carré voulu :"
        TextBox11.Text = "Longueur des cotés du carré voulu :"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonNord.Click
        Tourner(0, laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSud.Click
        Tourner(1, laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonEst.Click
        Tourner(2, laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonOuest.Click
        Tourner(3, laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonAvancer.Click
        Avancer(laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles ButtonLever.Click
        Lever(laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonBaisser.Click
        Baisser(laplume)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub ButtonCentrer_Click(sender As Object, e As EventArgs) Handles ButtonCentrer.Click
        Centrer(laplume, lecentre)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub ButtonTracer_Click(sender As Object, e As EventArgs) Handles ButtonTracer.Click
        Trait(laplume, TextBox6.Text)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub ButtonCarré_Click(sender As Object, e As EventArgs) Handles ButtonCarré.Click
        Dim centrecarré As Point
        centrecarré.x = TextBox8.Text
        centrecarré.y = TextBox10.Text
        Carré(laplume, centrecarré, TextBox12.Text)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub
    Private Sub ButtonTraitInterrompu_Click(sender As Object, e As EventArgs) Handles ButtonTraitInterrompu.Click
        TraitInterrompu(laplume, TextBox6.Text)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub

    Private Sub ButtonCarréInterrompu_Click(sender As Object, e As EventArgs) Handles ButtonCarréInterrompu.Click
        Dim centrecarré As Point
        centrecarré.x = TextBox8.Text
        centrecarré.y = TextBox10.Text
        CarréInterrompu(laplume, centrecarré, TextBox12.Text)

        'actualisation de l'affichage
        PictureBox1.Image = feuille
        TextBoxCoordx.Text = laplume.Coord.x
        TextBoxCoordy.Text = laplume.Coord.y
        TextBoxOrientation.Text = laplume.OrientationPlume
        Select Case TextBoxOrientation.Text
            Case 0
                TextBoxOrientation.Text = "Nord"
            Case 1
                TextBoxOrientation.Text = "Sud"
            Case 2
                TextBoxOrientation.Text = "Est"
            Case 3
                TextBoxOrientation.Text = "Ouest"
        End Select
        TextBoxEtatLevée.Text = laplume.EtatLevée
    End Sub


End Class
