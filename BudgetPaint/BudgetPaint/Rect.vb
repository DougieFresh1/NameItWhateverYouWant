Public Class Rect
    Public Property Pen As Pen
    Public Property fill As Boolean

    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Public Property H
    Public Property W
    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            If fill Then
                g.FillRectangle(New SolidBrush(Pen.Color), m_a.X, m_a.Y, W, H)
            Else
                g.DrawRectangle(Pen, m_a.X, m_a.Y, W, H)
            End If
        End Using

    End Sub
End Class
