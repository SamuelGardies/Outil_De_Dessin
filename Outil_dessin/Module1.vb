Module Module1
    Public feuille As Bitmap = New Bitmap(500, 500)
    Public dessin As Graphics = Graphics.FromImage(feuille)
    Public laplume As Plume
    Public lecentre As Point

    Public Structure Point
        Dim x As Integer
        Dim y As Integer
    End Structure

    Public Enum Orientation
        Nord  '0
        Sud   '1
        Est   '2
        Ouest '3
    End Enum

    Public Structure Plume
        Dim Coord As Point
        Dim OrientationPlume As Orientation
        Dim EtatLevée As Boolean
    End Structure

    Sub Tourner(ByVal Rotation As Orientation, ByRef plume As Plume)
        plume.OrientationPlume = Rotation
    End Sub

    Sub Lever(ByRef plume As Plume)
        If plume.EtatLevée = False Then
            plume.EtatLevée = True
        Else
            MsgBox("la plume est déjà levée")
        End If
    End Sub

    Sub Baisser(ByRef plume As Plume)
        If plume.EtatLevée = True Then
            plume.EtatLevée = False
        Else
            MsgBox("la plume est déjà baissée")
        End If
    End Sub

    Sub Avancer(ByRef plume As Plume)
        Dim point1 As Point
        Dim point2 As Point
        point1.x = laplume.Coord.x
        point1.y = laplume.Coord.y
        Select Case plume.OrientationPlume
            Case Orientation.Nord
                'plume.Coord.x = plume.Coord.x
                If plume.Coord.y > 0 Then
                    plume.Coord.y = plume.Coord.y - 1
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Sud
                If plume.Coord.y < 500 Then
                    'plume.Coord.x = plume.Coord.x
                    plume.Coord.y = plume.Coord.y + 1
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Est
                If plume.Coord.x < 500 Then
                    plume.Coord.x = plume.Coord.x + 1
                    'plume.Coord.y = plume.Coord.y
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Ouest
                If plume.Coord.x > 0 Then
                    plume.Coord.x = plume.Coord.x - 1
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
                'plume.Coord.y = plume.Coord.y
        End Select
        point2.x = laplume.Coord.x
        point2.y = laplume.Coord.y
        If laplume.EtatLevée = False Then
            dessin.DrawLine(Pens.Black, point1.x, point1.y, point2.x, point2.y)
        End If
    End Sub

    Sub Centrer(ByRef plume As Plume, ByVal Centre As Point)

        If plume.EtatLevée = False Then
            plume.EtatLevée = True
        End If
        If plume.Coord.x <> Centre.x Or plume.Coord.y <> Centre.y Then
            plume.Coord.x = Centre.x
            plume.Coord.y = Centre.y
        Else
            MsgBox("la plume est déjà centrée")
        End If
    End Sub

    Sub Trait(ByRef plume As Plume, ByVal distance As Integer)
        Dim point1 As Point
        Dim point2 As Point
        point1.x = laplume.Coord.x
        point1.y = laplume.Coord.y
        Select Case plume.OrientationPlume
            Case Orientation.Nord
                If plume.Coord.y - distance > 0 Then
                    'plume.Coord.x = plume.Coord.x
                    plume.Coord.y = plume.Coord.y - distance
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Sud
                If plume.Coord.y + distance < 500 Then
                    'plume.Coord.x = plume.Coord.x
                    plume.Coord.y = plume.Coord.y + distance
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Est
                If plume.Coord.x + distance < 500 Then
                    'plume.Coord.y = plume.Coord.y
                    plume.Coord.x = plume.Coord.x + distance
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Ouest
                If plume.Coord.x - distance > 0 Then
                    'plume.Coord.y = plume.Coord.y
                    plume.Coord.x = plume.Coord.x - distance
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
        End Select
        point2.x = laplume.Coord.x
        point2.y = laplume.Coord.y
        If laplume.EtatLevée = False Then
            dessin.DrawLine(Pens.Black, point1.x, point1.y, point2.x, point2.y)
        End If
    End Sub

    Sub Carré(ByRef plume As Plume, ByVal centre As Point, ByVal longueur As Integer)
        plume.Coord.x = ((centre.x) + (longueur / 2))
        plume.Coord.y = centre.y
        plume.OrientationPlume = Orientation.Nord
        If plume.EtatLevée = True Then
            plume.EtatLevée = False
        End If
        Trait(plume, longueur / 2)
        Tourner(Orientation.Ouest, plume)
        Trait(plume, longueur)
        Tourner(Orientation.Sud, plume)
        Trait(plume, longueur)
        Tourner(Orientation.Est, plume)
        Trait(plume, longueur)
        Tourner(Orientation.Nord, plume)
        Trait(plume, longueur / 2)
    End Sub
    Sub TraitInterrompu(ByRef plume As Plume, ByVal distance As Integer)
        Dim point1 As Point
        Dim point2 As Point
        Dim i As Integer
        point1.x = laplume.Coord.x
        point1.y = laplume.Coord.y
        Select Case plume.OrientationPlume
            Case Orientation.Nord
                If plume.Coord.y - distance > 0 Then
                    'plume.Coord.x = plume.Coord.x
                    plume.Coord.y = plume.Coord.y - distance
                    point2.x = laplume.Coord.x
                    point2.y = laplume.Coord.y
                    If plume.EtatLevée = False Then
                        For i = point1.y To point2.y + 5 Step -1
                            dessin.DrawLine(Pens.Black, point1.x, i, point1.x, i - 5)
                            i = i - 10
                        Next
                    End If
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Sud
                If plume.Coord.y + distance < 500 Then
                    'plume.Coord.x = plume.Coord.x
                    plume.Coord.y = plume.Coord.y + distance
                    point2.x = laplume.Coord.x
                    point2.y = laplume.Coord.y
                    If plume.EtatLevée = False Then
                        For i = point1.y To point2.y - 5
                            dessin.DrawLine(Pens.Black, point1.x, i, point1.x, i + 5)
                            i = i + 10
                        Next
                    End If
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Est
                If plume.Coord.x + distance < 500 Then
                    'plume.Coord.y = plume.Coord.y
                    plume.Coord.x = plume.Coord.x + distance
                    point2.x = laplume.Coord.x
                    point2.y = laplume.Coord.y
                    If plume.EtatLevée = False Then
                        For i = point1.x To point2.x - 5
                            dessin.DrawLine(Pens.Black, i, point1.y, i + 5, point1.y)
                            i = i + 10
                        Next
                    End If
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
            Case Orientation.Ouest
                If plume.Coord.x - distance > 0 Then
                    'plume.Coord.y = plume.Coord.y
                    plume.Coord.x = plume.Coord.x - distance
                    point2.x = laplume.Coord.x
                    point2.y = laplume.Coord.y
                    If plume.EtatLevée = False Then
                        For i = point1.x To point2.x + 5 Step -1
                            dessin.DrawLine(Pens.Black, i, point1.y, i - 5, point1.y)
                            i = i - 10
                        Next
                    End If
                Else
                    MsgBox("la plume ne peut pas sortir du dessin")
                End If
        End Select
    End Sub
    Sub CarréInterrompu(ByRef plume As Plume, ByVal centre As Point, ByVal longueur As Integer)
        plume.Coord.x = ((centre.x) + (longueur / 2))
        plume.Coord.y = centre.y
        plume.OrientationPlume = Orientation.Nord
        If plume.EtatLevée = True Then
            plume.EtatLevée = False
        End If
        TraitInterrompu(plume, longueur / 2)
        Tourner(Orientation.Ouest, plume)
        TraitInterrompu(plume, longueur)
        Tourner(Orientation.Sud, plume)
        TraitInterrompu(plume, longueur)
        Tourner(Orientation.Est, plume)
        TraitInterrompu(plume, longueur)
        Tourner(Orientation.Nord, plume)
        TraitInterrompu(plume, longueur / 2)
    End Sub

End Module