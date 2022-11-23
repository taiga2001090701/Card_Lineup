Public Class Game
    Dim d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13 As SByte
    Dim c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13 As SByte
    Dim h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13 As SByte
    Dim s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13 As SByte
    Dim j, jt, jp, jtf As SByte
    Dim p, p1, p2, p3, p4, p5 As SByte
    Dim t, tt, c As SByte
    Dim dts, dtl, cts, ctl, hts, htl, sts, stl As SByte
    Dim pt1, pt2, pt3, pt4, pt5 As SByte
    Dim rs, rl, r1, r2, r3, r4, r5 As SByte
    Dim jpb, ss As String
    Dim r As ULong
    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        p = Label.Text
        r = 0
        p1 = 0
        p2 = 0
        p3 = 0
        p4 = 0
        p5 = 0
        pt1 = 0
        pt2 = 0
        pt3 = 0
        pt4 = 0
        pt5 = 0
        rs = 1
        r1 = 0
        r2 = 0
        r3 = 0
        r4 = 0
        r5 = 0
        Dim rand As New System.Random()
        If p = 3 Then
            rl = 3
            Label1.Show()
            Label2.Show()
            Label3.Show()
            LabelPT1.Show()
            LabelPT2.Show()
            LabelPT3.Show()
R3:
            d1 = rand.Next(1, 4)
            d2 = rand.Next(1, 4)
            d3 = rand.Next(1, 4)
            d4 = rand.Next(1, 4)
            d5 = rand.Next(1, 4)
            d6 = rand.Next(1, 4)
            d7 = rand.Next(1, 4)
            d8 = rand.Next(1, 4)
            d9 = rand.Next(1, 4)
            d10 = rand.Next(1, 4)
            d11 = rand.Next(1, 4)
            d12 = rand.Next(1, 4)
            d13 = rand.Next(1, 4)
            c1 = rand.Next(1, 4)
            c2 = rand.Next(1, 4)
            c3 = rand.Next(1, 4)
            c4 = rand.Next(1, 4)
            c5 = rand.Next(1, 4)
            c6 = rand.Next(1, 4)
            c7 = rand.Next(1, 4)
            c8 = rand.Next(1, 4)
            c9 = rand.Next(1, 4)
            c10 = rand.Next(1, 4)
            c11 = rand.Next(1, 4)
            c12 = rand.Next(1, 4)
            c13 = rand.Next(1, 4)
            h1 = rand.Next(1, 4)
            h2 = rand.Next(1, 4)
            h3 = rand.Next(1, 4)
            h4 = rand.Next(1, 4)
            h5 = rand.Next(1, 4)
            h6 = rand.Next(1, 4)
            h7 = rand.Next(1, 4)
            h8 = rand.Next(1, 4)
            h9 = rand.Next(1, 4)
            h10 = rand.Next(1, 4)
            h11 = rand.Next(1, 4)
            h12 = rand.Next(1, 4)
            h13 = rand.Next(1, 4)
            s1 = rand.Next(1, 4)
            s2 = rand.Next(1, 4)
            s3 = rand.Next(1, 4)
            s4 = rand.Next(1, 4)
            s5 = rand.Next(1, 4)
            s6 = rand.Next(1, 4)
            s7 = rand.Next(1, 4)
            s8 = rand.Next(1, 4)
            s9 = rand.Next(1, 4)
            s10 = rand.Next(1, 4)
            s11 = rand.Next(1, 4)
            s12 = rand.Next(1, 4)
            s13 = rand.Next(1, 4)
            j = rand.Next(1, 4)
            If d1 = 1 Then
                p1 = p1 + 1
            End If
            If d1 = 2 Then
                p2 = p2 + 1
            End If
            If d1 = 3 Then
                p3 = p3 + 1
            End If
            If d2 = 1 Then
                p1 = p1 + 1
            End If
            If d2 = 2 Then
                p2 = p2 + 1
            End If
            If d2 = 3 Then
                p3 = p3 + 1
            End If
            If d3 = 1 Then
                p1 = p1 + 1
            End If
            If d3 = 2 Then
                p2 = p2 + 1
            End If
            If d3 = 3 Then
                p3 = p3 + 1
            End If
            If d4 = 1 Then
                p1 = p1 + 1
            End If
            If d4 = 2 Then
                p2 = p2 + 1
            End If
            If d4 = 3 Then
                p3 = p3 + 1
            End If
            If d5 = 1 Then
                p1 = p1 + 1
            End If
            If d5 = 2 Then
                p2 = p2 + 1
            End If
            If d5 = 3 Then
                p3 = p3 + 1
            End If
            If d6 = 1 Then
                p1 = p1 + 1
            End If
            If d6 = 2 Then
                p2 = p2 + 1
            End If
            If d6 = 3 Then
                p3 = p3 + 1
            End If
            If d7 = 1 Then
                p1 = p1 + 1
            End If
            If d7 = 2 Then
                p2 = p2 + 1
            End If
            If d7 = 3 Then
                p3 = p3 + 1
            End If
            If d8 = 1 Then
                p1 = p1 + 1
            End If
            If d8 = 2 Then
                p2 = p2 + 1
            End If
            If d8 = 3 Then
                p3 = p3 + 1
            End If
            If d9 = 1 Then
                p1 = p1 + 1
            End If
            If d9 = 2 Then
                p2 = p2 + 1
            End If
            If d9 = 3 Then
                p3 = p3 + 1
            End If
            If d10 = 1 Then
                p1 = p1 + 1
            End If
            If d10 = 2 Then
                p2 = p2 + 1
            End If
            If d10 = 3 Then
                p3 = p3 + 1
            End If
            If d11 = 1 Then
                p1 = p1 + 1
            End If
            If d11 = 2 Then
                p2 = p2 + 1
            End If
            If d11 = 3 Then
                p3 = p3 + 1
            End If
            If d12 = 1 Then
                p1 = p1 + 1
            End If
            If d12 = 2 Then
                p2 = p2 + 1
            End If
            If d12 = 3 Then
                p3 = p3 + 1
            End If
            If d13 = 1 Then
                p1 = p1 + 1
            End If
            If d13 = 2 Then
                p2 = p2 + 1
            End If
            If d13 = 3 Then
                p3 = p3 + 1
            End If
            If c1 = 1 Then
                p1 = p1 + 1
            End If
            If c1 = 2 Then
                p2 = p2 + 1
            End If
            If c1 = 3 Then
                p3 = p3 + 1
            End If
            If c2 = 1 Then
                p1 = p1 + 1
            End If
            If c2 = 2 Then
                p2 = p2 + 1
            End If
            If c2 = 3 Then
                p3 = p3 + 1
            End If
            If c3 = 1 Then
                p1 = p1 + 1
            End If
            If c3 = 2 Then
                p2 = p2 + 1
            End If
            If c3 = 3 Then
                p3 = p3 + 1
            End If
            If c4 = 1 Then
                p1 = p1 + 1
            End If
            If c4 = 2 Then
                p2 = p2 + 1
            End If
            If c4 = 3 Then
                p3 = p3 + 1
            End If
            If c5 = 1 Then
                p1 = p1 + 1
            End If
            If c5 = 2 Then
                p2 = p2 + 1
            End If
            If c5 = 3 Then
                p3 = p3 + 1
            End If
            If c6 = 1 Then
                p1 = p1 + 1
            End If
            If c6 = 2 Then
                p2 = p2 + 1
            End If
            If c6 = 3 Then
                p3 = p3 + 1
            End If
            If c7 = 1 Then
                p1 = p1 + 1
            End If
            If c7 = 2 Then
                p2 = p2 + 1
            End If
            If c7 = 3 Then
                p3 = p3 + 1
            End If
            If c8 = 1 Then
                p1 = p1 + 1
            End If
            If c8 = 2 Then
                p2 = p2 + 1
            End If
            If c8 = 3 Then
                p3 = p3 + 1
            End If
            If c9 = 1 Then
                p1 = p1 + 1
            End If
            If c9 = 2 Then
                p2 = p2 + 1
            End If
            If c9 = 3 Then
                p3 = p3 + 1
            End If
            If c10 = 1 Then
                p1 = p1 + 1
            End If
            If c10 = 2 Then
                p2 = p2 + 1
            End If
            If c10 = 3 Then
                p3 = p3 + 1
            End If
            If c11 = 1 Then
                p1 = p1 + 1
            End If
            If c11 = 2 Then
                p2 = p2 + 1
            End If
            If c11 = 3 Then
                p3 = p3 + 1
            End If
            If c12 = 1 Then
                p1 = p1 + 1
            End If
            If c12 = 2 Then
                p2 = p2 + 1
            End If
            If c12 = 3 Then
                p3 = p3 + 1
            End If
            If c13 = 1 Then
                p1 = p1 + 1
            End If
            If c13 = 2 Then
                p2 = p2 + 1
            End If
            If c13 = 3 Then
                p3 = p3 + 1
            End If
            If h1 = 1 Then
                p1 = p1 + 1
            End If
            If h1 = 2 Then
                p2 = p2 + 1
            End If
            If h1 = 3 Then
                p3 = p3 + 1
            End If
            If h2 = 1 Then
                p1 = p1 + 1
            End If
            If h2 = 2 Then
                p2 = p2 + 1
            End If
            If h2 = 3 Then
                p3 = p3 + 1
            End If
            If h3 = 1 Then
                p1 = p1 + 1
            End If
            If h3 = 2 Then
                p2 = p2 + 1
            End If
            If h3 = 3 Then
                p3 = p3 + 1
            End If
            If h4 = 1 Then
                p1 = p1 + 1
            End If
            If h4 = 2 Then
                p2 = p2 + 1
            End If
            If h4 = 3 Then
                p3 = p3 + 1
            End If
            If h5 = 1 Then
                p1 = p1 + 1
            End If
            If h5 = 2 Then
                p2 = p2 + 1
            End If
            If h5 = 3 Then
                p3 = p3 + 1
            End If
            If h6 = 1 Then
                p1 = p1 + 1
            End If
            If h6 = 2 Then
                p2 = p2 + 1
            End If
            If h6 = 3 Then
                p3 = p3 + 1
            End If
            If h7 = 1 Then
                p1 = p1 + 1
            End If
            If h7 = 2 Then
                p2 = p2 + 1
            End If
            If h7 = 3 Then
                p3 = p3 + 1
            End If
            If h8 = 1 Then
                p1 = p1 + 1
            End If
            If h8 = 2 Then
                p2 = p2 + 1
            End If
            If h8 = 3 Then
                p3 = p3 + 1
            End If
            If h9 = 1 Then
                p1 = p1 + 1
            End If
            If h9 = 2 Then
                p2 = p2 + 1
            End If
            If h9 = 3 Then
                p3 = p3 + 1
            End If
            If h10 = 1 Then
                p1 = p1 + 1
            End If
            If h10 = 2 Then
                p2 = p2 + 1
            End If
            If h10 = 3 Then
                p3 = p3 + 1
            End If
            If h11 = 1 Then
                p1 = p1 + 1
            End If
            If h11 = 2 Then
                p2 = p2 + 1
            End If
            If h11 = 3 Then
                p3 = p3 + 1
            End If
            If h12 = 1 Then
                p1 = p1 + 1
            End If
            If h12 = 2 Then
                p2 = p2 + 1
            End If
            If h12 = 3 Then
                p3 = p3 + 1
            End If
            If h13 = 1 Then
                p1 = p1 + 1
            End If
            If h13 = 2 Then
                p2 = p2 + 1
            End If
            If h13 = 3 Then
                p3 = p3 + 1
            End If
            If s1 = 1 Then
                p1 = p1 + 1
            End If
            If s1 = 2 Then
                p2 = p2 + 1
            End If
            If s1 = 3 Then
                p3 = p3 + 1
            End If
            If s2 = 1 Then
                p1 = p1 + 1
            End If
            If s2 = 2 Then
                p2 = p2 + 1
            End If
            If s2 = 3 Then
                p3 = p3 + 1
            End If
            If s3 = 1 Then
                p1 = p1 + 1
            End If
            If s3 = 2 Then
                p2 = p2 + 1
            End If
            If s3 = 3 Then
                p3 = p3 + 1
            End If
            If s4 = 1 Then
                p1 = p1 + 1
            End If
            If s4 = 2 Then
                p2 = p2 + 1
            End If
            If s4 = 3 Then
                p3 = p3 + 1
            End If
            If s5 = 1 Then
                p1 = p1 + 1
            End If
            If s5 = 2 Then
                p2 = p2 + 1
            End If
            If s5 = 3 Then
                p3 = p3 + 1
            End If
            If s6 = 1 Then
                p1 = p1 + 1
            End If
            If s6 = 2 Then
                p2 = p2 + 1
            End If
            If s6 = 3 Then
                p3 = p3 + 1
            End If
            If s7 = 1 Then
                p1 = p1 + 1
            End If
            If s7 = 2 Then
                p2 = p2 + 1
            End If
            If s7 = 3 Then
                p3 = p3 + 1
            End If
            If s8 = 1 Then
                p1 = p1 + 1
            End If
            If s8 = 2 Then
                p2 = p2 + 1
            End If
            If s8 = 3 Then
                p3 = p3 + 1
            End If
            If s9 = 1 Then
                p1 = p1 + 1
            End If
            If s9 = 2 Then
                p2 = p2 + 1
            End If
            If s9 = 3 Then
                p3 = p3 + 1
            End If
            If s10 = 1 Then
                p1 = p1 + 1
            End If
            If s10 = 2 Then
                p2 = p2 + 1
            End If
            If s10 = 3 Then
                p3 = p3 + 1
            End If
            If s11 = 1 Then
                p1 = p1 + 1
            End If
            If s11 = 2 Then
                p2 = p2 + 1
            End If
            If s11 = 3 Then
                p3 = p3 + 1
            End If
            If s12 = 1 Then
                p1 = p1 + 1
            End If
            If s12 = 2 Then
                p2 = p2 + 1
            End If
            If s12 = 3 Then
                p3 = p3 + 1
            End If
            If s13 = 1 Then
                p1 = p1 + 1
            End If
            If s13 = 2 Then
                p2 = p2 + 1
            End If
            If s13 = 3 Then
                p3 = p3 + 1
            End If
            If j = 1 Then
                p1 = p1 + 1
            End If
            If j = 2 Then
                p1 = p2 + 1
            End If
            If j = 3 Then
                p1 = p3 + 1
            End If
            If p1 = 18 Then
                If p2 = 18 Then
                    If p3 = 17 Then
                        LabelR.Text = r
                        GoTo EAN
                    End If
                End If
            End If
            p1 = 0
            p2 = 0
            p3 = 0
            r = r + 1
            GoTo R3
        End If
        If p = 4 Then
            rl = 4
            Label1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
            LabelPT1.Show()
            LabelPT2.Show()
            LabelPT3.Show()
            LabelPT4.Show()
R4:
            d1 = rand.Next(1, 5)
            d2 = rand.Next(1, 5)
            d3 = rand.Next(1, 5)
            d4 = rand.Next(1, 5)
            d5 = rand.Next(1, 5)
            d6 = rand.Next(1, 5)
            d7 = rand.Next(1, 5)
            d8 = rand.Next(1, 5)
            d9 = rand.Next(1, 5)
            d10 = rand.Next(1, 5)
            d11 = rand.Next(1, 5)
            d12 = rand.Next(1, 5)
            d13 = rand.Next(1, 5)
            c1 = rand.Next(1, 5)
            c2 = rand.Next(1, 5)
            c3 = rand.Next(1, 5)
            c4 = rand.Next(1, 5)
            c5 = rand.Next(1, 5)
            c6 = rand.Next(1, 5)
            c7 = rand.Next(1, 5)
            c8 = rand.Next(1, 5)
            c9 = rand.Next(1, 5)
            c10 = rand.Next(1, 5)
            c11 = rand.Next(1, 5)
            c12 = rand.Next(1, 5)
            c13 = rand.Next(1, 5)
            h1 = rand.Next(1, 5)
            h2 = rand.Next(1, 5)
            h3 = rand.Next(1, 5)
            h4 = rand.Next(1, 5)
            h5 = rand.Next(1, 5)
            h6 = rand.Next(1, 5)
            h7 = rand.Next(1, 5)
            h8 = rand.Next(1, 5)
            h9 = rand.Next(1, 5)
            h10 = rand.Next(1, 5)
            h11 = rand.Next(1, 5)
            h12 = rand.Next(1, 5)
            h13 = rand.Next(1, 5)
            s1 = rand.Next(1, 5)
            s2 = rand.Next(1, 5)
            s3 = rand.Next(1, 5)
            s4 = rand.Next(1, 5)
            s5 = rand.Next(1, 5)
            s6 = rand.Next(1, 5)
            s7 = rand.Next(1, 5)
            s8 = rand.Next(1, 5)
            s9 = rand.Next(1, 5)
            s10 = rand.Next(1, 5)
            s11 = rand.Next(1, 5)
            s12 = rand.Next(1, 5)
            s13 = rand.Next(1, 5)
            j = rand.Next(1, 5)
            If d1 = 1 Then
                p1 = p1 + 1
            End If
            If d1 = 2 Then
                p2 = p2 + 1
            End If
            If d1 = 3 Then
                p3 = p3 + 1
            End If
            If d1 = 4 Then
                p4 = p4 + 1
            End If
            If d2 = 1 Then
                p1 = p1 + 1
            End If
            If d2 = 2 Then
                p2 = p2 + 1
            End If
            If d2 = 3 Then
                p3 = p3 + 1
            End If
            If d2 = 4 Then
                p4 = p4 + 1
            End If
            If d3 = 1 Then
                p1 = p1 + 1
            End If
            If d3 = 2 Then
                p2 = p2 + 1
            End If
            If d3 = 3 Then
                p3 = p3 + 1
            End If
            If d3 = 4 Then
                p4 = p4 + 1
            End If
            If d4 = 1 Then
                p1 = p1 + 1
            End If
            If d4 = 2 Then
                p2 = p2 + 1
            End If
            If d4 = 3 Then
                p3 = p3 + 1
            End If
            If d4 = 4 Then
                p4 = p4 + 1
            End If
            If d5 = 1 Then
                p1 = p1 + 1
            End If
            If d5 = 2 Then
                p2 = p2 + 1
            End If
            If d5 = 3 Then
                p3 = p3 + 1
            End If
            If d5 = 4 Then
                p4 = p4 + 1
            End If
            If d6 = 1 Then
                p1 = p1 + 1
            End If
            If d6 = 2 Then
                p2 = p2 + 1
            End If
            If d6 = 3 Then
                p3 = p3 + 1
            End If
            If d6 = 4 Then
                p4 = p4 + 1
            End If
            If d7 = 1 Then
                p1 = p1 + 1
            End If
            If d7 = 2 Then
                p2 = p2 + 1
            End If
            If d7 = 3 Then
                p3 = p3 + 1
            End If
            If d7 = 4 Then
                p4 = p4 + 1
            End If
            If d8 = 1 Then
                p1 = p1 + 1
            End If
            If d8 = 2 Then
                p2 = p2 + 1
            End If
            If d8 = 3 Then
                p3 = p3 + 1
            End If
            If d8 = 4 Then
                p4 = p4 + 1
            End If
            If d9 = 1 Then
                p1 = p1 + 1
            End If
            If d9 = 2 Then
                p2 = p2 + 1
            End If
            If d9 = 3 Then
                p3 = p3 + 1
            End If
            If d9 = 4 Then
                p4 = p4 + 1
            End If
            If d10 = 1 Then
                p1 = p1 + 1
            End If
            If d10 = 2 Then
                p2 = p2 + 1
            End If
            If d10 = 3 Then
                p3 = p3 + 1
            End If
            If d10 = 4 Then
                p4 = p4 + 1
            End If
            If d11 = 1 Then
                p1 = p1 + 1
            End If
            If d11 = 2 Then
                p2 = p2 + 1
            End If
            If d11 = 3 Then
                p3 = p3 + 1
            End If
            If d11 = 4 Then
                p4 = p4 + 1
            End If
            If d12 = 1 Then
                p1 = p1 + 1
            End If
            If d12 = 2 Then
                p2 = p2 + 1
            End If
            If d12 = 3 Then
                p3 = p3 + 1
            End If
            If d12 = 4 Then
                p4 = p4 + 1
            End If
            If d13 = 1 Then
                p1 = p1 + 1
            End If
            If d13 = 2 Then
                p2 = p2 + 1
            End If
            If d13 = 3 Then
                p3 = p3 + 1
            End If
            If d13 = 4 Then
                p4 = p4 + 1
            End If
            If c1 = 1 Then
                p1 = p1 + 1
            End If
            If c1 = 2 Then
                p2 = p2 + 1
            End If
            If c1 = 3 Then
                p3 = p3 + 1
            End If
            If c1 = 4 Then
                p4 = p4 + 1
            End If
            If c2 = 1 Then
                p1 = p1 + 1
            End If
            If c2 = 2 Then
                p2 = p2 + 1
            End If
            If c2 = 3 Then
                p3 = p3 + 1
            End If
            If c2 = 4 Then
                p4 = p4 + 1
            End If
            If c3 = 1 Then
                p1 = p1 + 1
            End If
            If c3 = 2 Then
                p2 = p2 + 1
            End If
            If c3 = 3 Then
                p3 = p3 + 1
            End If
            If c3 = 4 Then
                p4 = p4 + 1
            End If
            If c4 = 1 Then
                p1 = p1 + 1
            End If
            If c4 = 2 Then
                p2 = p2 + 1
            End If
            If c4 = 3 Then
                p3 = p3 + 1
            End If
            If c4 = 4 Then
                p4 = p4 + 1
            End If
            If c5 = 1 Then
                p1 = p1 + 1
            End If
            If c5 = 2 Then
                p2 = p2 + 1
            End If
            If c5 = 3 Then
                p3 = p3 + 1
            End If
            If c5 = 4 Then
                p4 = p4 + 1
            End If
            If c6 = 1 Then
                p1 = p1 + 1
            End If
            If c6 = 2 Then
                p2 = p2 + 1
            End If
            If c6 = 3 Then
                p3 = p3 + 1
            End If
            If c6 = 4 Then
                p4 = p4 + 1
            End If
            If c7 = 1 Then
                p1 = p1 + 1
            End If
            If c7 = 2 Then
                p2 = p2 + 1
            End If
            If c7 = 3 Then
                p3 = p3 + 1
            End If
            If c7 = 4 Then
                p4 = p4 + 1
            End If
            If c8 = 1 Then
                p1 = p1 + 1
            End If
            If c8 = 2 Then
                p2 = p2 + 1
            End If
            If c8 = 3 Then
                p3 = p3 + 1
            End If
            If c8 = 4 Then
                p4 = p4 + 1
            End If
            If c9 = 1 Then
                p1 = p1 + 1
            End If
            If c9 = 2 Then
                p2 = p2 + 1
            End If
            If c9 = 3 Then
                p3 = p3 + 1
            End If
            If c9 = 4 Then
                p4 = p4 + 1
            End If
            If c10 = 1 Then
                p1 = p1 + 1
            End If
            If c10 = 2 Then
                p2 = p2 + 1
            End If
            If c10 = 3 Then
                p3 = p3 + 1
            End If
            If c10 = 4 Then
                p4 = p4 + 1
            End If
            If c11 = 1 Then
                p1 = p1 + 1
            End If
            If c11 = 2 Then
                p2 = p2 + 1
            End If
            If c11 = 3 Then
                p3 = p3 + 1
            End If
            If c11 = 4 Then
                p4 = p4 + 1
            End If
            If c12 = 1 Then
                p1 = p1 + 1
            End If
            If c12 = 2 Then
                p2 = p2 + 1
            End If
            If c12 = 3 Then
                p3 = p3 + 1
            End If
            If c12 = 4 Then
                p4 = p4 + 1
            End If
            If c13 = 1 Then
                p1 = p1 + 1
            End If
            If c13 = 2 Then
                p2 = p2 + 1
            End If
            If c13 = 3 Then
                p3 = p3 + 1
            End If
            If c13 = 4 Then
                p4 = p4 + 1
            End If
            If h1 = 1 Then
                p1 = p1 + 1
            End If
            If h1 = 2 Then
                p2 = p2 + 1
            End If
            If h1 = 3 Then
                p3 = p3 + 1
            End If
            If h1 = 4 Then
                p4 = p4 + 1
            End If
            If h2 = 1 Then
                p1 = p1 + 1
            End If
            If h2 = 2 Then
                p2 = p2 + 1
            End If
            If h2 = 3 Then
                p3 = p3 + 1
            End If
            If h2 = 4 Then
                p4 = p4 + 1
            End If
            If h3 = 1 Then
                p1 = p1 + 1
            End If
            If h3 = 2 Then
                p2 = p2 + 1
            End If
            If h3 = 3 Then
                p3 = p3 + 1
            End If
            If h3 = 4 Then
                p4 = p4 + 1
            End If
            If h4 = 1 Then
                p1 = p1 + 1
            End If
            If h4 = 2 Then
                p2 = p2 + 1
            End If
            If h4 = 3 Then
                p3 = p3 + 1
            End If
            If h4 = 4 Then
                p4 = p4 + 1
            End If
            If h5 = 1 Then
                p1 = p1 + 1
            End If
            If h5 = 2 Then
                p2 = p2 + 1
            End If
            If h5 = 3 Then
                p3 = p3 + 1
            End If
            If h5 = 4 Then
                p4 = p4 + 1
            End If
            If h6 = 1 Then
                p1 = p1 + 1
            End If
            If h6 = 2 Then
                p2 = p2 + 1
            End If
            If h6 = 3 Then
                p3 = p3 + 1
            End If
            If h6 = 4 Then
                p4 = p4 + 1
            End If
            If h7 = 1 Then
                p1 = p1 + 1
            End If
            If h7 = 2 Then
                p2 = p2 + 1
            End If
            If h7 = 3 Then
                p3 = p3 + 1
            End If
            If h7 = 4 Then
                p4 = p4 + 1
            End If
            If h8 = 1 Then
                p1 = p1 + 1
            End If
            If h8 = 2 Then
                p2 = p2 + 1
            End If
            If h8 = 3 Then
                p3 = p3 + 1
            End If
            If h8 = 4 Then
                p4 = p4 + 1
            End If
            If h9 = 1 Then
                p1 = p1 + 1
            End If
            If h9 = 2 Then
                p2 = p2 + 1
            End If
            If h9 = 3 Then
                p3 = p3 + 1
            End If
            If h9 = 4 Then
                p4 = p4 + 1
            End If
            If h10 = 1 Then
                p1 = p1 + 1
            End If
            If h10 = 2 Then
                p2 = p2 + 1
            End If
            If h10 = 3 Then
                p3 = p3 + 1
            End If
            If h10 = 4 Then
                p4 = p4 + 1
            End If
            If h11 = 1 Then
                p1 = p1 + 1
            End If
            If h11 = 2 Then
                p2 = p2 + 1
            End If
            If h11 = 3 Then
                p3 = p3 + 1
            End If
            If h11 = 4 Then
                p4 = p4 + 1
            End If
            If h12 = 1 Then
                p1 = p1 + 1
            End If
            If h12 = 2 Then
                p2 = p2 + 1
            End If
            If h12 = 3 Then
                p3 = p3 + 1
            End If
            If h12 = 4 Then
                p4 = p4 + 1
            End If
            If h13 = 1 Then
                p1 = p1 + 1
            End If
            If h13 = 2 Then
                p2 = p2 + 1
            End If
            If h13 = 3 Then
                p3 = p3 + 1
            End If
            If h13 = 4 Then
                p4 = p4 + 1
            End If
            If s1 = 1 Then
                p1 = p1 + 1
            End If
            If s1 = 2 Then
                p2 = p2 + 1
            End If
            If s1 = 3 Then
                p3 = p3 + 1
            End If
            If s1 = 4 Then
                p4 = p4 + 1
            End If
            If s2 = 1 Then
                p1 = p1 + 1
            End If
            If s2 = 2 Then
                p2 = p2 + 1
            End If
            If s2 = 3 Then
                p3 = p3 + 1
            End If
            If s2 = 4 Then
                p4 = p4 + 1
            End If
            If s3 = 1 Then
                p1 = p1 + 1
            End If
            If s3 = 2 Then
                p2 = p2 + 1
            End If
            If s3 = 3 Then
                p3 = p3 + 1
            End If
            If s3 = 4 Then
                p4 = p4 + 1
            End If
            If s4 = 1 Then
                p1 = p1 + 1
            End If
            If s4 = 2 Then
                p2 = p2 + 1
            End If
            If s4 = 3 Then
                p3 = p3 + 1
            End If
            If s4 = 4 Then
                p4 = p4 + 1
            End If
            If s5 = 1 Then
                p1 = p1 + 1
            End If
            If s5 = 2 Then
                p2 = p2 + 1
            End If
            If s5 = 3 Then
                p3 = p3 + 1
            End If
            If s5 = 4 Then
                p4 = p4 + 1
            End If
            If s6 = 1 Then
                p1 = p1 + 1
            End If
            If s6 = 2 Then
                p2 = p2 + 1
            End If
            If s6 = 3 Then
                p3 = p3 + 1
            End If
            If s6 = 4 Then
                p4 = p4 + 1
            End If
            If s7 = 1 Then
                p1 = p1 + 1
            End If
            If s7 = 2 Then
                p2 = p2 + 1
            End If
            If s7 = 3 Then
                p3 = p3 + 1
            End If
            If s7 = 4 Then
                p4 = p4 + 1
            End If
            If s8 = 1 Then
                p1 = p1 + 1
            End If
            If s8 = 2 Then
                p2 = p2 + 1
            End If
            If s8 = 3 Then
                p3 = p3 + 1
            End If
            If s8 = 4 Then
                p4 = p4 + 1
            End If
            If s9 = 1 Then
                p1 = p1 + 1
            End If
            If s9 = 2 Then
                p2 = p2 + 1
            End If
            If s9 = 3 Then
                p3 = p3 + 1
            End If
            If s9 = 4 Then
                p4 = p4 + 1
            End If
            If s10 = 1 Then
                p1 = p1 + 1
            End If
            If s10 = 2 Then
                p2 = p2 + 1
            End If
            If s10 = 3 Then
                p3 = p3 + 1
            End If
            If s10 = 4 Then
                p4 = p4 + 1
            End If
            If s11 = 1 Then
                p1 = p1 + 1
            End If
            If s11 = 2 Then
                p2 = p2 + 1
            End If
            If s11 = 3 Then
                p3 = p3 + 1
            End If
            If s11 = 4 Then
                p4 = p4 + 1
            End If
            If s12 = 1 Then
                p1 = p1 + 1
            End If
            If s12 = 2 Then
                p2 = p2 + 1
            End If
            If s12 = 3 Then
                p3 = p3 + 1
            End If
            If s12 = 4 Then
                p4 = p4 + 1
            End If
            If s13 = 1 Then
                p1 = p1 + 1
            End If
            If s13 = 2 Then
                p2 = p2 + 1
            End If
            If s13 = 3 Then
                p3 = p3 + 1
            End If
            If s13 = 4 Then
                p4 = p4 + 1
            End If
            If j = 1 Then
                p1 = p1 + 1
            End If
            If j = 2 Then
                p1 = p2 + 1
            End If
            If j = 3 Then
                p1 = p3 + 1
            End If
            If j = 4 Then
                p4 = p4 + 1
            End If
            If p1 = 14 Then
                If p2 = 13 Then
                    If p3 = 13 Then
                        If p4 = 13 Then
                            LabelR.Text = r
                            GoTo EAN
                        End If
                    End If
                End If
            End If
            p1 = 0
            p2 = 0
            p3 = 0
            p4 = 0
            r = r + 1
            GoTo R4
        End If
        If p = 5 Then
            rl = 5
            Label1.Show()
            Label2.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()
            LabelPT1.Show()
            LabelPT2.Show()
            LabelPT3.Show()
            LabelPT4.Show()
            LabelPT5.Show()
R5:
            d1 = rand.Next(1, 6)
            d2 = rand.Next(1, 6)
            d3 = rand.Next(1, 6)
            d4 = rand.Next(1, 6)
            d5 = rand.Next(1, 6)
            d6 = rand.Next(1, 6)
            d7 = rand.Next(1, 6)
            d8 = rand.Next(1, 6)
            d9 = rand.Next(1, 6)
            d10 = rand.Next(1, 6)
            d11 = rand.Next(1, 6)
            d12 = rand.Next(1, 6)
            d13 = rand.Next(1, 6)
            c1 = rand.Next(1, 6)
            c2 = rand.Next(1, 6)
            c3 = rand.Next(1, 6)
            c4 = rand.Next(1, 6)
            c5 = rand.Next(1, 6)
            c6 = rand.Next(1, 6)
            c7 = rand.Next(1, 6)
            c8 = rand.Next(1, 6)
            c9 = rand.Next(1, 6)
            c10 = rand.Next(1, 6)
            c11 = rand.Next(1, 6)
            c12 = rand.Next(1, 6)
            c13 = rand.Next(1, 6)
            h1 = rand.Next(1, 6)
            h2 = rand.Next(1, 6)
            h3 = rand.Next(1, 6)
            h4 = rand.Next(1, 6)
            h5 = rand.Next(1, 6)
            h6 = rand.Next(1, 6)
            h7 = rand.Next(1, 6)
            h8 = rand.Next(1, 6)
            h9 = rand.Next(1, 6)
            h10 = rand.Next(1, 6)
            h11 = rand.Next(1, 6)
            h12 = rand.Next(1, 6)
            h13 = rand.Next(1, 6)
            s1 = rand.Next(1, 6)
            s2 = rand.Next(1, 6)
            s3 = rand.Next(1, 6)
            s4 = rand.Next(1, 6)
            s5 = rand.Next(1, 6)
            s6 = rand.Next(1, 6)
            s7 = rand.Next(1, 6)
            s8 = rand.Next(1, 6)
            s9 = rand.Next(1, 6)
            s10 = rand.Next(1, 6)
            s11 = rand.Next(1, 6)
            s12 = rand.Next(1, 6)
            s13 = rand.Next(1, 6)
            j = rand.Next(1, 6)
            If d1 = 1 Then
                p1 = p1 + 1
            End If
            If d1 = 2 Then
                p2 = p2 + 1
            End If
            If d1 = 3 Then
                p3 = p3 + 1
            End If
            If d1 = 4 Then
                p4 = p4 + 1
            End If
            If d1 = 5 Then
                p5 = p5 + 1
            End If
            If d2 = 1 Then
                p1 = p1 + 1
            End If
            If d2 = 2 Then
                p2 = p2 + 1
            End If
            If d2 = 3 Then
                p3 = p3 + 1
            End If
            If d2 = 4 Then
                p4 = p4 + 1
            End If
            If d2 = 5 Then
                p5 = p5 + 1
            End If
            If d3 = 1 Then
                p1 = p1 + 1
            End If
            If d3 = 2 Then
                p2 = p2 + 1
            End If
            If d3 = 3 Then
                p3 = p3 + 1
            End If
            If d3 = 4 Then
                p4 = p4 + 1
            End If
            If d3 = 5 Then
                p5 = p5 + 1
            End If
            If d4 = 1 Then
                p1 = p1 + 1
            End If
            If d4 = 2 Then
                p2 = p2 + 1
            End If
            If d4 = 3 Then
                p3 = p3 + 1
            End If
            If d4 = 4 Then
                p4 = p4 + 1
            End If
            If d4 = 5 Then
                p5 = p5 + 1
            End If
            If d5 = 1 Then
                p1 = p1 + 1
            End If
            If d5 = 2 Then
                p2 = p2 + 1
            End If
            If d5 = 3 Then
                p3 = p3 + 1
            End If
            If d5 = 4 Then
                p4 = p4 + 1
            End If
            If d5 = 5 Then
                p5 = p5 + 1
            End If
            If d6 = 1 Then
                p1 = p1 + 1
            End If
            If d6 = 2 Then
                p2 = p2 + 1
            End If
            If d6 = 3 Then
                p3 = p3 + 1
            End If
            If d6 = 4 Then
                p4 = p4 + 1
            End If
            If d6 = 5 Then
                p5 = p5 + 1
            End If
            If d7 = 1 Then
                p1 = p1 + 1
            End If
            If d7 = 2 Then
                p2 = p2 + 1
            End If
            If d7 = 3 Then
                p3 = p3 + 1
            End If
            If d7 = 4 Then
                p4 = p4 + 1
            End If
            If d7 = 5 Then
                p5 = p5 + 1
            End If
            If d8 = 1 Then
                p1 = p1 + 1
            End If
            If d8 = 2 Then
                p2 = p2 + 1
            End If
            If d8 = 3 Then
                p3 = p3 + 1
            End If
            If d8 = 4 Then
                p4 = p4 + 1
            End If
            If d8 = 5 Then
                p5 = p5 + 1
            End If
            If d9 = 1 Then
                p1 = p1 + 1
            End If
            If d9 = 2 Then
                p2 = p2 + 1
            End If
            If d9 = 3 Then
                p3 = p3 + 1
            End If
            If d9 = 4 Then
                p4 = p4 + 1
            End If
            If d9 = 5 Then
                p5 = p5 + 1
            End If
            If d10 = 1 Then
                p1 = p1 + 1
            End If
            If d10 = 2 Then
                p2 = p2 + 1
            End If
            If d10 = 3 Then
                p3 = p3 + 1
            End If
            If d10 = 4 Then
                p4 = p4 + 1
            End If
            If d10 = 5 Then
                p5 = p5 + 1
            End If
            If d11 = 1 Then
                p1 = p1 + 1
            End If
            If d11 = 2 Then
                p2 = p2 + 1
            End If
            If d11 = 3 Then
                p3 = p3 + 1
            End If
            If d11 = 4 Then
                p4 = p4 + 1
            End If
            If d11 = 5 Then
                p5 = p5 + 1
            End If
            If d12 = 1 Then
                p1 = p1 + 1
            End If
            If d12 = 2 Then
                p2 = p2 + 1
            End If
            If d12 = 3 Then
                p3 = p3 + 1
            End If
            If d12 = 4 Then
                p4 = p4 + 1
            End If
            If d12 = 5 Then
                p5 = p5 + 1
            End If
            If d13 = 1 Then
                p1 = p1 + 1
            End If
            If d13 = 2 Then
                p2 = p2 + 1
            End If
            If d13 = 3 Then
                p3 = p3 + 1
            End If
            If d13 = 4 Then
                p4 = p4 + 1
            End If
            If d13 = 5 Then
                p5 = p5 + 1
            End If
            If c1 = 1 Then
                p1 = p1 + 1
            End If
            If c1 = 2 Then
                p2 = p2 + 1
            End If
            If c1 = 3 Then
                p3 = p3 + 1
            End If
            If c1 = 4 Then
                p4 = p4 + 1
            End If
            If c1 = 5 Then
                p5 = p5 + 1
            End If
            If c2 = 1 Then
                p1 = p1 + 1
            End If
            If c2 = 2 Then
                p2 = p2 + 1
            End If
            If c2 = 3 Then
                p3 = p3 + 1
            End If
            If c2 = 4 Then
                p4 = p4 + 1
            End If
            If c2 = 5 Then
                p5 = p5 + 1
            End If
            If c3 = 1 Then
                p1 = p1 + 1
            End If
            If c3 = 2 Then
                p2 = p2 + 1
            End If
            If c3 = 3 Then
                p3 = p3 + 1
            End If
            If c3 = 4 Then
                p4 = p4 + 1
            End If
            If c3 = 5 Then
                p5 = p5 + 1
            End If
            If c4 = 1 Then
                p1 = p1 + 1
            End If
            If c4 = 2 Then
                p2 = p2 + 1
            End If
            If c4 = 3 Then
                p3 = p3 + 1
            End If
            If c4 = 4 Then
                p4 = p4 + 1
            End If
            If c4 = 5 Then
                p5 = p5 + 1
            End If
            If c5 = 1 Then
                p1 = p1 + 1
            End If
            If c5 = 2 Then
                p2 = p2 + 1
            End If
            If c5 = 3 Then
                p3 = p3 + 1
            End If
            If c5 = 4 Then
                p4 = p4 + 1
            End If
            If c5 = 5 Then
                p5 = p5 + 1
            End If
            If c6 = 1 Then
                p1 = p1 + 1
            End If
            If c6 = 2 Then
                p2 = p2 + 1
            End If
            If c6 = 3 Then
                p3 = p3 + 1
            End If
            If c6 = 4 Then
                p4 = p4 + 1
            End If
            If c6 = 5 Then
                p5 = p5 + 1
            End If
            If c7 = 1 Then
                p1 = p1 + 1
            End If
            If c7 = 2 Then
                p2 = p2 + 1
            End If
            If c7 = 3 Then
                p3 = p3 + 1
            End If
            If c7 = 4 Then
                p4 = p4 + 1
            End If
            If c7 = 5 Then
                p5 = p5 + 1
            End If
            If c8 = 1 Then
                p1 = p1 + 1
            End If
            If c8 = 2 Then
                p2 = p2 + 1
            End If
            If c8 = 3 Then
                p3 = p3 + 1
            End If
            If c8 = 4 Then
                p4 = p4 + 1
            End If
            If c8 = 5 Then
                p5 = p5 + 1
            End If
            If c9 = 1 Then
                p1 = p1 + 1
            End If
            If c9 = 2 Then
                p2 = p2 + 1
            End If
            If c9 = 3 Then
                p3 = p3 + 1
            End If
            If c9 = 4 Then
                p4 = p4 + 1
            End If
            If c9 = 5 Then
                p5 = p5 + 1
            End If
            If c10 = 1 Then
                p1 = p1 + 1
            End If
            If c10 = 2 Then
                p2 = p2 + 1
            End If
            If c10 = 3 Then
                p3 = p3 + 1
            End If
            If c10 = 4 Then
                p4 = p4 + 1
            End If
            If c10 = 5 Then
                p5 = p5 + 1
            End If
            If c11 = 1 Then
                p1 = p1 + 1
            End If
            If c11 = 2 Then
                p2 = p2 + 1
            End If
            If c11 = 3 Then
                p3 = p3 + 1
            End If
            If c11 = 4 Then
                p4 = p4 + 1
            End If
            If c11 = 5 Then
                p5 = p5 + 1
            End If
            If c12 = 1 Then
                p1 = p1 + 1
            End If
            If c12 = 2 Then
                p2 = p2 + 1
            End If
            If c12 = 3 Then
                p3 = p3 + 1
            End If
            If c12 = 4 Then
                p4 = p4 + 1
            End If
            If c12 = 5 Then
                p5 = p5 + 1
            End If
            If c13 = 1 Then
                p1 = p1 + 1
            End If
            If c13 = 2 Then
                p2 = p2 + 1
            End If
            If c13 = 3 Then
                p3 = p3 + 1
            End If
            If c13 = 4 Then
                p4 = p4 + 1
            End If
            If c13 = 5 Then
                p5 = p5 + 1
            End If
            If h1 = 1 Then
                p1 = p1 + 1
            End If
            If h1 = 2 Then
                p2 = p2 + 1
            End If
            If h1 = 3 Then
                p3 = p3 + 1
            End If
            If h1 = 4 Then
                p4 = p4 + 1
            End If
            If h1 = 5 Then
                p5 = p5 + 1
            End If
            If h2 = 1 Then
                p1 = p1 + 1
            End If
            If h2 = 2 Then
                p2 = p2 + 1
            End If
            If h2 = 3 Then
                p3 = p3 + 1
            End If
            If h2 = 4 Then
                p4 = p4 + 1
            End If
            If h2 = 5 Then
                p5 = p5 + 1
            End If
            If h3 = 1 Then
                p1 = p1 + 1
            End If
            If h3 = 2 Then
                p2 = p2 + 1
            End If
            If h3 = 3 Then
                p3 = p3 + 1
            End If
            If h3 = 4 Then
                p4 = p4 + 1
            End If
            If h3 = 5 Then
                p5 = p5 + 1
            End If
            If h4 = 1 Then
                p1 = p1 + 1
            End If
            If h4 = 2 Then
                p2 = p2 + 1
            End If
            If h4 = 3 Then
                p3 = p3 + 1
            End If
            If h4 = 4 Then
                p4 = p4 + 1
            End If
            If h4 = 5 Then
                p5 = p5 + 1
            End If
            If h5 = 1 Then
                p1 = p1 + 1
            End If
            If h5 = 2 Then
                p2 = p2 + 1
            End If
            If h5 = 3 Then
                p3 = p3 + 1
            End If
            If h5 = 4 Then
                p4 = p4 + 1
            End If
            If h5 = 5 Then
                p5 = p5 + 1
            End If
            If h6 = 1 Then
                p1 = p1 + 1
            End If
            If h6 = 2 Then
                p2 = p2 + 1
            End If
            If h6 = 3 Then
                p3 = p3 + 1
            End If
            If h6 = 4 Then
                p4 = p4 + 1
            End If
            If h6 = 5 Then
                p5 = p5 + 1
            End If
            If h7 = 1 Then
                p1 = p1 + 1
            End If
            If h7 = 2 Then
                p2 = p2 + 1
            End If
            If h7 = 3 Then
                p3 = p3 + 1
            End If
            If h7 = 4 Then
                p4 = p4 + 1
            End If
            If h7 = 5 Then
                p5 = p5 + 1
            End If
            If h8 = 1 Then
                p1 = p1 + 1
            End If
            If h8 = 2 Then
                p2 = p2 + 1
            End If
            If h8 = 3 Then
                p3 = p3 + 1
            End If
            If h8 = 4 Then
                p4 = p4 + 1
            End If
            If h8 = 5 Then
                p5 = p5 + 1
            End If
            If h9 = 1 Then
                p1 = p1 + 1
            End If
            If h9 = 2 Then
                p2 = p2 + 1
            End If
            If h9 = 3 Then
                p3 = p3 + 1
            End If
            If h9 = 4 Then
                p4 = p4 + 1
            End If
            If h9 = 5 Then
                p5 = p5 + 1
            End If
            If h10 = 1 Then
                p1 = p1 + 1
            End If
            If h10 = 2 Then
                p2 = p2 + 1
            End If
            If h10 = 3 Then
                p3 = p3 + 1
            End If
            If h10 = 4 Then
                p4 = p4 + 1
            End If
            If h10 = 5 Then
                p5 = p5 + 1
            End If
            If h11 = 1 Then
                p1 = p1 + 1
            End If
            If h11 = 2 Then
                p2 = p2 + 1
            End If
            If h11 = 3 Then
                p3 = p3 + 1
            End If
            If h11 = 4 Then
                p4 = p4 + 1
            End If
            If h11 = 5 Then
                p5 = p5 + 1
            End If
            If h12 = 1 Then
                p1 = p1 + 1
            End If
            If h12 = 2 Then
                p2 = p2 + 1
            End If
            If h12 = 3 Then
                p3 = p3 + 1
            End If
            If h12 = 4 Then
                p4 = p4 + 1
            End If
            If h12 = 5 Then
                p5 = p5 + 1
            End If
            If h13 = 1 Then
                p1 = p1 + 1
            End If
            If h13 = 2 Then
                p2 = p2 + 1
            End If
            If h13 = 3 Then
                p3 = p3 + 1
            End If
            If h13 = 4 Then
                p4 = p4 + 1
            End If
            If h13 = 5 Then
                p5 = p5 + 1
            End If
            If s1 = 1 Then
                p1 = p1 + 1
            End If
            If s1 = 2 Then
                p2 = p2 + 1
            End If
            If s1 = 3 Then
                p3 = p3 + 1
            End If
            If s1 = 4 Then
                p4 = p4 + 1
            End If
            If s1 = 5 Then
                p5 = p5 + 1
            End If
            If s2 = 1 Then
                p1 = p1 + 1
            End If
            If s2 = 2 Then
                p2 = p2 + 1
            End If
            If s2 = 3 Then
                p3 = p3 + 1
            End If
            If s2 = 4 Then
                p4 = p4 + 1
            End If
            If s2 = 5 Then
                p5 = p5 + 1
            End If
            If s3 = 1 Then
                p1 = p1 + 1
            End If
            If s3 = 2 Then
                p2 = p2 + 1
            End If
            If s3 = 3 Then
                p3 = p3 + 1
            End If
            If s3 = 4 Then
                p4 = p4 + 1
            End If
            If s3 = 5 Then
                p5 = p5 + 1
            End If
            If s4 = 1 Then
                p1 = p1 + 1
            End If
            If s4 = 2 Then
                p2 = p2 + 1
            End If
            If s4 = 3 Then
                p3 = p3 + 1
            End If
            If s4 = 4 Then
                p4 = p4 + 1
            End If
            If s4 = 5 Then
                p5 = p5 + 1
            End If
            If s5 = 1 Then
                p1 = p1 + 1
            End If
            If s5 = 2 Then
                p2 = p2 + 1
            End If
            If s5 = 3 Then
                p3 = p3 + 1
            End If
            If s5 = 4 Then
                p4 = p4 + 1
            End If
            If s5 = 5 Then
                p5 = p5 + 1
            End If
            If s6 = 1 Then
                p1 = p1 + 1
            End If
            If s6 = 2 Then
                p2 = p2 + 1
            End If
            If s6 = 3 Then
                p3 = p3 + 1
            End If
            If s6 = 4 Then
                p4 = p4 + 1
            End If
            If s6 = 5 Then
                p5 = p5 + 1
            End If
            If s7 = 1 Then
                p1 = p1 + 1
            End If
            If s7 = 2 Then
                p2 = p2 + 1
            End If
            If s7 = 3 Then
                p3 = p3 + 1
            End If
            If s7 = 4 Then
                p4 = p4 + 1
            End If
            If s7 = 5 Then
                p5 = p5 + 1
            End If
            If s8 = 1 Then
                p1 = p1 + 1
            End If
            If s8 = 2 Then
                p2 = p2 + 1
            End If
            If s8 = 3 Then
                p3 = p3 + 1
            End If
            If s8 = 4 Then
                p4 = p4 + 1
            End If
            If s8 = 5 Then
                p5 = p5 + 1
            End If
            If s9 = 1 Then
                p1 = p1 + 1
            End If
            If s9 = 2 Then
                p2 = p2 + 1
            End If
            If s9 = 3 Then
                p3 = p3 + 1
            End If
            If s9 = 4 Then
                p4 = p4 + 1
            End If
            If s9 = 5 Then
                p5 = p5 + 1
            End If
            If s10 = 1 Then
                p1 = p1 + 1
            End If
            If s10 = 2 Then
                p2 = p2 + 1
            End If
            If s10 = 3 Then
                p3 = p3 + 1
            End If
            If s10 = 4 Then
                p4 = p4 + 1
            End If
            If s10 = 5 Then
                p5 = p5 + 1
            End If
            If s11 = 1 Then
                p1 = p1 + 1
            End If
            If s11 = 2 Then
                p2 = p2 + 1
            End If
            If s11 = 3 Then
                p3 = p3 + 1
            End If
            If s11 = 4 Then
                p4 = p4 + 1
            End If
            If s11 = 5 Then
                p5 = p5 + 1
            End If
            If s12 = 1 Then
                p1 = p1 + 1
            End If
            If s12 = 2 Then
                p2 = p2 + 1
            End If
            If s12 = 3 Then
                p3 = p3 + 1
            End If
            If s12 = 4 Then
                p4 = p4 + 1
            End If
            If s12 = 5 Then
                p5 = p5 + 1
            End If
            If s13 = 1 Then
                p1 = p1 + 1
            End If
            If s13 = 2 Then
                p2 = p2 + 1
            End If
            If s13 = 3 Then
                p3 = p3 + 1
            End If
            If s13 = 4 Then
                p4 = p4 + 1
            End If
            If s13 = 5 Then
                p5 = p5 + 1
            End If
            If j = 1 Then
                p1 = p1 + 1
            End If
            If j = 2 Then
                p1 = p2 + 1
            End If
            If j = 3 Then
                p1 = p3 + 1
            End If
            If j = 4 Then
                p4 = p4 + 1
            End If
            If j = 5 Then
                p5 = p5 + 1
            End If
            If p1 = 11 Then
                If p2 = 11 Then
                    If p3 = 11 Then
                        If p4 = 10 Then
                            If p5 = 10 Then
                                LabelR.Text = r
                                GoTo EAN
                            End If
                        End If
                    End If
                End If
            End If
            p1 = 0
            p2 = 0
            p3 = 0
            p4 = 0
            p5 = 0
            r = r + 1
            GoTo R5
        End If
EAN:
        LabelD7.Text = d7
        LabelC7.Text = c7
        LabelH7.Text = h7
        LabelS7.Text = s7
        ButtonD7.Show()
        ButtonC7.Show()
        ButtonH7.Show()
        ButtonS7.Show()
        t = d7
        If d1 = t Then
            ButtonMD1.Show()
        End If
        If d2 = t Then
            ButtonMD2.Show()
        End If
        If d3 = t Then
            ButtonMD3.Show()
        End If
        If d4 = t Then
            ButtonMD4.Show()
        End If
        If d5 = t Then
            ButtonMD5.Show()
        End If
        If d6 = t Then
            ButtonMD6.Show()
        End If
        If d8 = t Then
            ButtonMD8.Show()
        End If
        If d9 = t Then
            ButtonMD9.Show()
        End If
        If d10 = t Then
            ButtonMD10.Show()
        End If
        If d11 = t Then
            ButtonMD11.Show()
        End If
        If d12 = t Then
            ButtonMD12.Show()
        End If
        If d13 = t Then
            ButtonMD13.Show()
        End If
        If c1 = t Then
            ButtonMC1.Show()
        End If
        If c2 = t Then
            ButtonMC2.Show()
        End If
        If c3 = t Then
            ButtonMC3.Show()
        End If
        If c4 = t Then
            ButtonMC4.Show()
        End If
        If c5 = t Then
            ButtonMC5.Show()
        End If
        If c6 = t Then
            ButtonMC6.Show()
        End If
        If c8 = t Then
            ButtonMC8.Show()
        End If
        If c9 = t Then
            ButtonMC9.Show()
        End If
        If c10 = t Then
            ButtonMC10.Show()
        End If
        If c11 = t Then
            ButtonMC11.Show()
        End If
        If c12 = t Then
            ButtonMC12.Show()
        End If
        If c13 = t Then
            ButtonMC13.Show()
        End If
        If h1 = t Then
            ButtonMH1.Show()
        End If
        If h2 = t Then
            ButtonMH2.Show()
        End If
        If h3 = t Then
            ButtonMH3.Show()
        End If
        If h4 = t Then
            ButtonMH4.Show()
        End If
        If h5 = t Then
            ButtonMH5.Show()
        End If
        If h6 = t Then
            ButtonMH6.Show()
        End If
        If h8 = t Then
            ButtonMH8.Show()
        End If
        If h9 = t Then
            ButtonMH9.Show()
        End If
        If h10 = t Then
            ButtonMH10.Show()
        End If
        If h11 = t Then
            ButtonMH11.Show()
        End If
        If h12 = t Then
            ButtonMH12.Show()
        End If
        If h13 = t Then
            ButtonMH13.Show()
        End If
        If s1 = t Then
            ButtonMS1.Show()
        End If
        If s2 = t Then
            ButtonMS2.Show()
        End If
        If s3 = t Then
            ButtonMS3.Show()
        End If
        If s4 = t Then
            ButtonMS4.Show()
        End If
        If s5 = t Then
            ButtonMS5.Show()
        End If
        If s6 = t Then
            ButtonMS6.Show()
        End If
        If s8 = t Then
            ButtonMS8.Show()
        End If
        If s9 = t Then
            ButtonMS9.Show()
        End If
        If s10 = t Then
            ButtonMS10.Show()
        End If
        If s11 = t Then
            ButtonMS11.Show()
        End If
        If s12 = t Then
            ButtonMS12.Show()
        End If
        If s13 = t Then
            ButtonMS13.Show()
        End If
        If j = t Then
            ButtonJ.Show()
        End If
        LabelPN.Text = t
        dts = 6
        dtl = 8
        cts = 6
        ctl = 8
        hts = 6
        htl = 8
        sts = 6
        stl = 8
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        ButtonP.Show()
    End Sub

    Private Sub ButtonD1_Click(sender As Object, e As EventArgs) Handles ButtonD1.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d1
        jpb = "d1"
        dts = 0
        ButtonD1.Show()
        ButtonD1.Text = "J"
        LabelD1.Text = t
    End Sub

    Private Sub ButtonD2_Click(sender As Object, e As EventArgs) Handles ButtonD2.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d2
        jpb = "d2"
        dts = 1
        ButtonD2.Show()
        ButtonD2.Text = "J"
        LabelD2.Text = t
    End Sub

    Private Sub ButtonD3_Click(sender As Object, e As EventArgs) Handles ButtonD3.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d3
        jpb = "d3"
        dts = 2
        ButtonD3.Show()
        ButtonD3.Text = "J"
        LabelD3.Text = t
    End Sub

    Private Sub ButtonD4_Click(sender As Object, e As EventArgs) Handles ButtonD4.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d4
        jpb = "d4"
        dts = 3
        ButtonD4.Show()
        ButtonD4.Text = "J"
        LabelD4.Text = t
    End Sub

    Private Sub ButtonD5_Click(sender As Object, e As EventArgs) Handles ButtonD5.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d5
        jpb = "d5"
        dts = 4
        ButtonD5.Show()
        ButtonD5.Text = "J"
        LabelD5.Text = t
    End Sub

    Private Sub ButtonD6_Click(sender As Object, e As EventArgs) Handles ButtonD6.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d6
        jpb = "d6"
        dts = 5
        ButtonD6.Show()
        ButtonD6.Text = "J"
        LabelD6.Text = t
    End Sub

    Private Sub ButtonD7_Click(sender As Object, e As EventArgs) Handles ButtonD7.Click

    End Sub

    Private Sub ButtonD8_Click(sender As Object, e As EventArgs) Handles ButtonD8.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d8
        jpb = "d8"
        dtl = 9
        ButtonD8.Show()
        ButtonD8.Text = "J"
        LabelD8.Text = t
    End Sub

    Private Sub ButtonD9_Click(sender As Object, e As EventArgs) Handles ButtonD9.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d9
        jpb = "d9"
        dtl = 10
        ButtonD9.Show()
        ButtonD9.Text = "J"
        LabelD9.Text = t
    End Sub

    Private Sub ButtonD10_Click(sender As Object, e As EventArgs) Handles ButtonD10.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d10
        jpb = "d10"
        dtl = 11
        ButtonD10.Show()
        ButtonD10.Text = "J"
        LabelD10.Text = t
    End Sub

    Private Sub ButtonD11_Click(sender As Object, e As EventArgs) Handles ButtonD11.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d11
        jpb = "d11"
        dtl = 12
        ButtonD11.Show()
        ButtonD11.Text = "J"
        LabelD11.Text = t
    End Sub

    Private Sub ButtonD12_Click(sender As Object, e As EventArgs) Handles ButtonD12.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d12
        jpb = "d12"
        dtl = 13
        ButtonD12.Show()
        ButtonD12.Text = "J"
        LabelD12.Text = t
    End Sub

    Private Sub ButtonD13_Click(sender As Object, e As EventArgs) Handles ButtonD13.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = d13
        jpb = "d13"
        dtl = 14
        ButtonD13.Show()
        ButtonD13.Text = "J"
        LabelD13.Text = t
    End Sub

    Private Sub ButtonC1_Click(sender As Object, e As EventArgs) Handles ButtonC1.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c1
        jpb = "c1"
        cts = 0
        ButtonC1.Show()
        ButtonC1.Text = "J"
        LabelC1.Text = t
    End Sub

    Private Sub ButtonC2_Click(sender As Object, e As EventArgs) Handles ButtonC2.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c2
        jpb = "c2"
        cts = 1
        ButtonC2.Show()
        ButtonC2.Text = "J"
        LabelC2.Text = t
    End Sub

    Private Sub ButtonC3_Click(sender As Object, e As EventArgs) Handles ButtonC3.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c3
        jpb = "c3"
        cts = 2
        ButtonC3.Show()
        ButtonC3.Text = "J"
        LabelC3.Text = t
    End Sub

    Private Sub ButtonC4_Click(sender As Object, e As EventArgs) Handles ButtonC4.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c4
        jpb = "c4"
        cts = 3
        ButtonC4.Show()
        ButtonC4.Text = "J"
        LabelC4.Text = t
    End Sub

    Private Sub ButtonC5_Click(sender As Object, e As EventArgs) Handles ButtonC5.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c5
        jpb = "c5"
        cts = 4
        ButtonC5.Show()
        ButtonC5.Text = "J"
        LabelC5.Text = t
    End Sub

    Private Sub ButtonC6_Click(sender As Object, e As EventArgs) Handles ButtonC6.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c6
        jpb = "c6"
        cts = 5
        ButtonC6.Show()
        ButtonC6.Text = "J"
        LabelC6.Text = t
    End Sub

    Private Sub ButtonC7_Click(sender As Object, e As EventArgs) Handles ButtonC7.Click

    End Sub

    Private Sub ButtonC8_Click(sender As Object, e As EventArgs) Handles ButtonC8.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c8
        jpb = "c8"
        ctl = 9
        ButtonC8.Show()
        ButtonC8.Text = "J"
        LabelC8.Text = t
    End Sub

    Private Sub ButtonC9_Click(sender As Object, e As EventArgs) Handles ButtonC9.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c9
        jpb = "c9"
        ctl = 10
        ButtonC9.Show()
        ButtonC9.Text = "J"
        LabelC9.Text = t
    End Sub

    Private Sub ButtonC10_Click(sender As Object, e As EventArgs) Handles ButtonC10.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c10
        jpb = "c10"
        ctl = 11
        ButtonC10.Show()
        ButtonC10.Text = "J"
        LabelC10.Text = t
    End Sub

    Private Sub ButtonC11_Click(sender As Object, e As EventArgs) Handles ButtonC11.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c11
        jpb = "c11"
        ctl = 12
        ButtonC11.Show()
        ButtonC11.Text = "J"
        LabelC11.Text = t
    End Sub

    Private Sub ButtonC12_Click(sender As Object, e As EventArgs) Handles ButtonC12.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c12
        jpb = "c12"
        ctl = 13
        ButtonC12.Show()
        ButtonC12.Text = "J"
        LabelC12.Text = t
    End Sub

    Private Sub ButtonC13_Click(sender As Object, e As EventArgs) Handles ButtonC13.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = c13
        jpb = "c13"
        ctl = 14
        ButtonC13.Show()
        ButtonC13.Text = "J"
        LabelC13.Text = t
    End Sub

    Private Sub ButtonH1_Click(sender As Object, e As EventArgs) Handles ButtonH1.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h1
        jpb = "h1"
        hts = 0
        ButtonH1.Show()
        ButtonH1.Text = "J"
        LabelH1.Text = t
    End Sub

    Private Sub ButtonH2_Click(sender As Object, e As EventArgs) Handles ButtonH2.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h2
        jpb = "h2"
        hts = 1
        ButtonH2.Show()
        ButtonH2.Text = "J"
        LabelH2.Text = t
    End Sub

    Private Sub ButtonH3_Click(sender As Object, e As EventArgs) Handles ButtonH3.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h3
        jpb = "h3"
        hts = 2
        ButtonH3.Show()
        ButtonH3.Text = "J"
        LabelH3.Text = t
    End Sub

    Private Sub ButtonH4_Click(sender As Object, e As EventArgs) Handles ButtonH4.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h4
        jpb = "h4"
        hts = 3
        ButtonH4.Show()
        ButtonH4.Text = "J"
        LabelH4.Text = t
    End Sub

    Private Sub ButtonH5_Click(sender As Object, e As EventArgs) Handles ButtonH5.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h5
        jpb = "h5"
        hts = 4
        ButtonH5.Show()
        ButtonH5.Text = "J"
        LabelH5.Text = t
    End Sub

    Private Sub ButtonH6_Click(sender As Object, e As EventArgs) Handles ButtonH6.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h6
        jpb = "h6"
        hts = 5
        ButtonH6.Show()
        ButtonH6.Text = "J"
        LabelH6.Text = t
    End Sub

    Private Sub ButtonH7_Click(sender As Object, e As EventArgs) Handles ButtonH7.Click

    End Sub

    Private Sub ButtonH8_Click(sender As Object, e As EventArgs) Handles ButtonH8.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h8
        jpb = "h8"
        htl = 9
        ButtonH8.Show()
        ButtonH8.Text = "J"
        LabelH8.Text = t
    End Sub

    Private Sub ButtonH9_Click(sender As Object, e As EventArgs) Handles ButtonH9.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h9
        jpb = "h9"
        htl = 10
        ButtonH9.Show()
        ButtonH9.Text = "J"
        LabelH9.Text = t
    End Sub

    Private Sub ButtonH10_Click(sender As Object, e As EventArgs) Handles ButtonH10.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h10
        jpb = "h10"
        htl = 11
        ButtonH10.Show()
        ButtonH10.Text = "J"
        LabelH10.Text = t
    End Sub

    Private Sub ButtonH11_Click(sender As Object, e As EventArgs) Handles ButtonH11.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h11
        jpb = "h11"
        htl = 12
        ButtonH11.Show()
        ButtonH11.Text = "J"
        LabelH11.Text = t
    End Sub

    Private Sub ButtonH12_Click(sender As Object, e As EventArgs) Handles ButtonH12.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h12
        jpb = "h12"
        htl = 13
        ButtonH12.Show()
        ButtonH12.Text = "J"
        LabelH12.Text = t
    End Sub

    Private Sub ButtonH13_Click(sender As Object, e As EventArgs) Handles ButtonH13.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = h13
        jpb = "h13"
        htl = 14
        ButtonH13.Show()
        ButtonH13.Text = "J"
        LabelH13.Text = t
    End Sub

    Private Sub ButtonS1_Click(sender As Object, e As EventArgs) Handles ButtonS1.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s1
        jpb = "s1"
        sts = 0
        ButtonS1.Show()
        ButtonS1.Text = "J"
        LabelS1.Text = t
    End Sub

    Private Sub ButtonS2_Click(sender As Object, e As EventArgs) Handles ButtonS2.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s2
        jpb = "s2"
        sts = 1
        ButtonS2.Show()
        ButtonS2.Text = "J"
        LabelS2.Text = t
    End Sub

    Private Sub ButtonS3_Click(sender As Object, e As EventArgs) Handles ButtonS3.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s3
        jpb = "s3"
        sts = 2
        ButtonS3.Show()
        ButtonS3.Text = "J"
        LabelS3.Text = t
    End Sub

    Private Sub ButtonS4_Click(sender As Object, e As EventArgs) Handles ButtonS4.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s4
        jpb = "s4"
        sts = 3
        ButtonS4.Show()
        ButtonS4.Text = "J"
        LabelS4.Text = t
    End Sub

    Private Sub ButtonS5_Click(sender As Object, e As EventArgs) Handles ButtonS5.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s5
        jpb = "s5"
        sts = 4
        ButtonS5.Show()
        ButtonS5.Text = "J"
        LabelS5.Text = t
    End Sub

    Private Sub ButtonS6_Click(sender As Object, e As EventArgs) Handles ButtonS6.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s6
        jpb = "s6"
        sts = 5
        ButtonS6.Show()
        ButtonS6.Text = "J"
        LabelS6.Text = t
    End Sub

    Private Sub ButtonS7_Click(sender As Object, e As EventArgs) Handles ButtonS7.Click

    End Sub

    Private Sub ButtonS8_Click(sender As Object, e As EventArgs) Handles ButtonS8.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s8
        jpb = "s8"
        stl = 9
        ButtonS8.Show()
        ButtonS8.Text = "J"
        LabelS8.Text = t
    End Sub

    Private Sub ButtonS9_Click(sender As Object, e As EventArgs) Handles ButtonS9.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s9
        jpb = "s9"
        stl = 10
        ButtonS9.Show()
        ButtonS9.Text = "J"
        LabelS9.Text = t
    End Sub

    Private Sub ButtonS10_Click(sender As Object, e As EventArgs) Handles ButtonS10.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s10
        jpb = "s10"
        stl = 11
        ButtonS10.Show()
        ButtonS10.Text = "J"
        LabelS10.Text = t
    End Sub

    Private Sub ButtonS11_Click(sender As Object, e As EventArgs) Handles ButtonS11.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s11
        jpb = "s11"
        stl = 12
        ButtonS11.Show()
        ButtonS11.Text = "J"
        LabelS11.Text = t
    End Sub

    Private Sub ButtonS12_Click(sender As Object, e As EventArgs) Handles ButtonS12.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s12
        jpb = "s12"
        stl = 13
        ButtonS12.Show()
        ButtonS12.Text = "J"
        LabelS12.Text = t
    End Sub

    Private Sub ButtonS13_Click(sender As Object, e As EventArgs) Handles ButtonS13.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        jt = LabelJT.Text
        jt = jt - 1
        LabelJT.Text = jt
        ButtonN.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
        j = 0
        jtf = 1
        jp = s13
        jpb = "s13"
        stl = 14
        ButtonS13.Show()
        ButtonS13.Text = "J"
        LabelS13.Text = t
    End Sub

    Private Sub ButtonJ_Click(sender As Object, e As EventArgs) Handles ButtonJ.Click
        If dts = 1 Then
            ButtonMD1.Enabled = False
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = False
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = False
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = False
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = False
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = False
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = False
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = False
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = False
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = False
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = False
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = False
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = False
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = False
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = False
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = False
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = False
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = False
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = False
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = False
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = False
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = False
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = False
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = False
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = False
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = False
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = False
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = False
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = False
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = False
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = False
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = False
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = False
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = False
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = False
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = False
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = False
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = False
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = False
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = False
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = False
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = False
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = False
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = False
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = False
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = False
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = False
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = False
        End If
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonJC.Show()
        If dts = 1 Then
            ButtonD1.Enabled = True
            ButtonD1.Show()
        End If
        If dts = 2 Then
            ButtonD2.Enabled = True
            ButtonD2.Show()
        End If
        If dts = 3 Then
            ButtonD3.Enabled = True
            ButtonD3.Show()
        End If
        If dts = 4 Then
            ButtonD4.Enabled = True
            ButtonD4.Show()
        End If
        If dts = 5 Then
            ButtonD5.Enabled = True
            ButtonD5.Show()
        End If
        If dts = 6 Then
            ButtonD6.Enabled = True
            ButtonD6.Show()
        End If
        If dtl = 8 Then
            ButtonD8.Enabled = True
            ButtonD8.Show()
        End If
        If dtl = 9 Then
            ButtonD9.Enabled = True
            ButtonD9.Show()
        End If
        If dtl = 10 Then
            ButtonD10.Enabled = True
            ButtonD10.Show()
        End If
        If dtl = 11 Then
            ButtonD11.Enabled = True
            ButtonD11.Show()
        End If
        If dtl = 12 Then
            ButtonD12.Enabled = True
            ButtonD12.Show()
        End If
        If dtl = 13 Then
            ButtonD13.Enabled = True
            ButtonD13.Show()
        End If
        If cts = 1 Then
            ButtonC1.Enabled = True
            ButtonC1.Show()
        End If
        If cts = 2 Then
            ButtonC2.Enabled = True
            ButtonC2.Show()
        End If
        If cts = 3 Then
            ButtonC3.Enabled = True
            ButtonC3.Show()
        End If
        If cts = 4 Then
            ButtonC4.Enabled = True
            ButtonC4.Show()
        End If
        If cts = 5 Then
            ButtonC5.Enabled = True
            ButtonC5.Show()
        End If
        If cts = 6 Then
            ButtonC6.Enabled = True
            ButtonC6.Show()
        End If
        If ctl = 8 Then
            ButtonC8.Enabled = True
            ButtonC8.Show()
        End If
        If ctl = 9 Then
            ButtonC9.Enabled = True
            ButtonC9.Show()
        End If
        If ctl = 10 Then
            ButtonC10.Enabled = True
            ButtonC10.Show()
        End If
        If ctl = 11 Then
            ButtonC11.Enabled = True
            ButtonC11.Show()
        End If
        If ctl = 12 Then
            ButtonC12.Enabled = True
            ButtonC12.Show()
        End If
        If ctl = 13 Then
            ButtonC13.Enabled = True
            ButtonC13.Show()
        End If
        If hts = 1 Then
            ButtonH1.Enabled = True
            ButtonH1.Show()
        End If
        If hts = 2 Then
            ButtonH2.Enabled = True
            ButtonH2.Show()
        End If
        If hts = 3 Then
            ButtonH3.Enabled = True
            ButtonH3.Show()
        End If
        If hts = 4 Then
            ButtonH4.Enabled = True
            ButtonH4.Show()
        End If
        If hts = 5 Then
            ButtonH5.Enabled = True
            ButtonH5.Show()
        End If
        If hts = 6 Then
            ButtonH6.Enabled = True
            ButtonH6.Show()
        End If
        If htl = 8 Then
            ButtonH8.Enabled = True
            ButtonH8.Show()
        End If
        If htl = 9 Then
            ButtonH9.Enabled = True
            ButtonH9.Show()
        End If
        If htl = 10 Then
            ButtonH10.Enabled = True
            ButtonH10.Show()
        End If
        If htl = 11 Then
            ButtonH11.Enabled = True
            ButtonH11.Show()
        End If
        If htl = 12 Then
            ButtonH12.Enabled = True
            ButtonH12.Show()
        End If
        If htl = 13 Then
            ButtonH13.Enabled = True
            ButtonH13.Show()
        End If
        If sts = 1 Then
            ButtonS1.Enabled = True
            ButtonS1.Show()
        End If
        If sts = 2 Then
            ButtonS2.Enabled = True
            ButtonS2.Show()
        End If
        If sts = 3 Then
            ButtonS3.Enabled = True
            ButtonS3.Show()
        End If
        If sts = 4 Then
            ButtonS4.Enabled = True
            ButtonS4.Show()
        End If
        If sts = 5 Then
            ButtonS5.Enabled = True
            ButtonS5.Show()
        End If
        If sts = 6 Then
            ButtonS6.Enabled = True
            ButtonS6.Show()
        End If
        If stl = 8 Then
            ButtonS8.Enabled = True
            ButtonS8.Show()
        End If
        If stl = 9 Then
            ButtonS9.Enabled = True
            ButtonS9.Show()
        End If
        If stl = 10 Then
            ButtonS10.Enabled = True
            ButtonS10.Show()
        End If
        If stl = 11 Then
            ButtonS11.Enabled = True
            ButtonS11.Show()
        End If
        If stl = 12 Then
            ButtonS12.Enabled = True
            ButtonS12.Show()
        End If
        If stl = 13 Then
            ButtonS13.Enabled = True
            ButtonS13.Show()
        End If
    End Sub

    Private Sub ButtonJC_Click(sender As Object, e As EventArgs) Handles ButtonJC.Click
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
        If j = t Then
            ButtonJ.Show()
        End If
        ButtonP.Show()
        ButtonJC.Hide()
        If dts = 1 Then
            ButtonD1.Hide()
        End If
        If dts = 2 Then
            ButtonD2.Hide()
        End If
        If dts = 3 Then
            ButtonD3.Hide()
        End If
        If dts = 4 Then
            ButtonD4.Hide()
        End If
        If dts = 5 Then
            ButtonD5.Hide()
        End If
        If dts = 6 Then
            ButtonD6.Hide()
        End If
        If dtl = 8 Then
            ButtonD8.Hide()
        End If
        If dtl = 9 Then
            ButtonD9.Hide()
        End If
        If dtl = 10 Then
            ButtonD10.Hide()
        End If
        If dtl = 11 Then
            ButtonD11.Hide()
        End If
        If dtl = 12 Then
            ButtonD12.Hide()
        End If
        If dtl = 13 Then
            ButtonD13.Hide()
        End If
        If cts = 1 Then
            ButtonC1.Hide()
        End If
        If cts = 2 Then
            ButtonC2.Hide()
        End If
        If cts = 3 Then
            ButtonC3.Hide()
        End If
        If cts = 4 Then
            ButtonC4.Hide()
        End If
        If cts = 5 Then
            ButtonC5.Hide()
        End If
        If cts = 6 Then
            ButtonC6.Hide()
        End If
        If ctl = 8 Then
            ButtonC8.Hide()
        End If
        If ctl = 9 Then
            ButtonC9.Hide()
        End If
        If ctl = 10 Then
            ButtonC10.Hide()
        End If
        If ctl = 11 Then
            ButtonC11.Hide()
        End If
        If ctl = 12 Then
            ButtonC12.Hide()
        End If
        If ctl = 13 Then
            ButtonC13.Hide()
        End If
        If hts = 1 Then
            ButtonH1.Hide()
        End If
        If hts = 2 Then
            ButtonH2.Hide()
        End If
        If hts = 3 Then
            ButtonH3.Hide()
        End If
        If hts = 4 Then
            ButtonH4.Hide()
        End If
        If hts = 5 Then
            ButtonH5.Hide()
        End If
        If hts = 6 Then
            ButtonH6.Hide()
        End If
        If htl = 8 Then
            ButtonH8.Hide()
        End If
        If htl = 9 Then
            ButtonH9.Hide()
        End If
        If htl = 10 Then
            ButtonH10.Hide()
        End If
        If htl = 11 Then
            ButtonH11.Hide()
        End If
        If htl = 12 Then
            ButtonH12.Hide()
        End If
        If htl = 13 Then
            ButtonH13.Hide()
        End If
        If sts = 1 Then
            ButtonS1.Hide()
        End If
        If sts = 2 Then
            ButtonS2.Hide()
        End If
        If sts = 3 Then
            ButtonS3.Hide()
        End If
        If sts = 4 Then
            ButtonS4.Hide()
        End If
        If sts = 5 Then
            ButtonS5.Hide()
        End If
        If sts = 6 Then
            ButtonS6.Hide()
        End If
        If stl = 8 Then
            ButtonS8.Hide()
        End If
        If stl = 9 Then
            ButtonS9.Hide()
        End If
        If stl = 10 Then
            ButtonS10.Hide()
        End If
        If stl = 11 Then
            ButtonS11.Hide()
        End If
        If stl = 12 Then
            ButtonS12.Hide()
        End If
        If stl = 13 Then
            ButtonS13.Hide()
        End If
        ButtonD1.Enabled = False
        ButtonD2.Enabled = False
        ButtonD3.Enabled = False
        ButtonD4.Enabled = False
        ButtonD5.Enabled = False
        ButtonD6.Enabled = False
        ButtonD7.Enabled = False
        ButtonD8.Enabled = False
        ButtonD9.Enabled = False
        ButtonD10.Enabled = False
        ButtonD11.Enabled = False
        ButtonD12.Enabled = False
        ButtonD13.Enabled = False
        ButtonC1.Enabled = False
        ButtonC2.Enabled = False
        ButtonC3.Enabled = False
        ButtonC4.Enabled = False
        ButtonC5.Enabled = False
        ButtonC6.Enabled = False
        ButtonC7.Enabled = False
        ButtonC8.Enabled = False
        ButtonC9.Enabled = False
        ButtonC10.Enabled = False
        ButtonC11.Enabled = False
        ButtonC12.Enabled = False
        ButtonC13.Enabled = False
        ButtonH1.Enabled = False
        ButtonH2.Enabled = False
        ButtonH3.Enabled = False
        ButtonH4.Enabled = False
        ButtonH5.Enabled = False
        ButtonH6.Enabled = False
        ButtonH7.Enabled = False
        ButtonH8.Enabled = False
        ButtonH9.Enabled = False
        ButtonH10.Enabled = False
        ButtonH11.Enabled = False
        ButtonH12.Enabled = False
        ButtonH13.Enabled = False
        ButtonS1.Enabled = False
        ButtonS2.Enabled = False
        ButtonS3.Enabled = False
        ButtonS4.Enabled = False
        ButtonS5.Enabled = False
        ButtonS6.Enabled = False
        ButtonS7.Enabled = False
        ButtonS8.Enabled = False
        ButtonS9.Enabled = False
        ButtonS10.Enabled = False
        ButtonS11.Enabled = False
        ButtonS12.Enabled = False
        ButtonS13.Enabled = False
    End Sub

    Private Sub ButtonMD1_Click(sender As Object, e As EventArgs) Handles ButtonMD1.Click
        ButtonD1.Show()
        d1 = 0
        dts = dts - 1
        LabelD1.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d1" Then
                ButtonD1.Text = "♦1"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD2_Click(sender As Object, e As EventArgs) Handles ButtonMD2.Click
        ButtonD2.Show()
        d2 = 0
        dts = dts - 1
        LabelD2.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d2" Then
                ButtonD2.Text = "♦2"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD3_Click(sender As Object, e As EventArgs) Handles ButtonMD3.Click
        ButtonD3.Show()
        d3 = 0
        dts = dts - 1
        LabelD3.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d3" Then
                ButtonD3.Text = "♦3"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD4_Click(sender As Object, e As EventArgs) Handles ButtonMD4.Click
        ButtonD4.Show()
        d4 = 0
        dts = dts - 1
        LabelD4.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d4" Then
                ButtonD4.Text = "♦4"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD5_Click(sender As Object, e As EventArgs) Handles ButtonMD5.Click
        ButtonD5.Show()
        d5 = 0
        dts = dts - 1
        LabelD5.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d5" Then
                ButtonD5.Text = "♦5"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD6_Click(sender As Object, e As EventArgs) Handles ButtonMD6.Click
        ButtonD6.Show()
        d6 = 0
        dts = dts - 1
        LabelD6.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d6" Then
                ButtonD6.Text = "♦6"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD8_Click(sender As Object, e As EventArgs) Handles ButtonMD8.Click
        ButtonD8.Show()
        d8 = 0
        dtl = dtl + 1
        LabelD8.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d8" Then
                ButtonD8.Text = "♦8"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD9_Click(sender As Object, e As EventArgs) Handles ButtonMD9.Click
        ButtonD9.Show()
        d9 = 0
        dtl = dtl + 1
        LabelD9.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d9" Then
                ButtonD9.Text = "♦9"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD10_Click(sender As Object, e As EventArgs) Handles ButtonMD10.Click
        ButtonD10.Show()
        d10 = 0
        dtl = dtl + 1
        LabelD10.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d10" Then
                ButtonD10.Text = "♦10"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD11_Click(sender As Object, e As EventArgs) Handles ButtonMD11.Click
        ButtonD11.Show()
        d11 = 0
        dtl = dtl + 1
        LabelD11.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d11" Then
                ButtonD11.Text = "♦11"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD12_Click(sender As Object, e As EventArgs) Handles ButtonMD12.Click
        ButtonD12.Show()
        d12 = 0
        dtl = dtl + 1
        LabelD12.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d12" Then
                ButtonD12.Text = "♦12"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMD13_Click(sender As Object, e As EventArgs) Handles ButtonMD13.Click
        ButtonD13.Show()
        d13 = 0
        dtl = dtl + 1
        LabelD13.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "d13" Then
                ButtonD13.Text = "♦13"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC1_Click(sender As Object, e As EventArgs) Handles ButtonMC1.Click
        ButtonC1.Show()
        c1 = 0
        cts = cts - 1
        LabelC1.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c1" Then
                ButtonC1.Text = "♧1"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC2_Click(sender As Object, e As EventArgs) Handles ButtonMC2.Click
        ButtonC2.Show()
        c2 = 0
        cts = cts - 1
        LabelC2.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c2" Then
                ButtonC2.Text = "♧2"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC3_Click(sender As Object, e As EventArgs) Handles ButtonMC3.Click
        ButtonC3.Show()
        c3 = 0
        cts = cts - 1
        LabelC3.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c3" Then
                ButtonC3.Text = "♧3"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC4_Click(sender As Object, e As EventArgs) Handles ButtonMC4.Click
        ButtonC4.Show()
        c4 = 0
        cts = cts - 1
        LabelC4.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c4" Then
                ButtonC4.Text = "♧4"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC5_Click(sender As Object, e As EventArgs) Handles ButtonMC5.Click
        ButtonC5.Show()
        c5 = 0
        cts = cts - 1
        LabelC5.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c5" Then
                ButtonC5.Text = "♧5"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC6_Click(sender As Object, e As EventArgs) Handles ButtonMC6.Click
        ButtonC6.Show()
        c6 = 0
        cts = cts - 1
        LabelC6.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c6" Then
                ButtonC6.Text = "♧6"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC8_Click(sender As Object, e As EventArgs) Handles ButtonMC8.Click
        ButtonC8.Show()
        c8 = 0
        ctl = ctl + 1
        LabelC8.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c8" Then
                ButtonC8.Text = "♧8"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC9_Click(sender As Object, e As EventArgs) Handles ButtonMC9.Click
        ButtonC9.Show()
        c9 = 0
        ctl = ctl + 1
        LabelC9.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c9" Then
                ButtonC9.Text = "♧9"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC10_Click(sender As Object, e As EventArgs) Handles ButtonMC10.Click
        ButtonC10.Show()
        c10 = 0
        ctl = ctl + 1
        LabelC10.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c10" Then
                ButtonC10.Text = "♧10"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC11_Click(sender As Object, e As EventArgs) Handles ButtonMC11.Click
        ButtonC11.Show()
        c11 = 0
        ctl = ctl + 1
        LabelC11.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c11" Then
                ButtonC11.Text = "♧11"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC12_Click(sender As Object, e As EventArgs) Handles ButtonMC12.Click
        ButtonC12.Show()
        c12 = 0
        ctl = ctl + 1
        LabelC12.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c12" Then
                ButtonC12.Text = "♧12"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMC13_Click(sender As Object, e As EventArgs) Handles ButtonMC13.Click
        ButtonC13.Show()
        c13 = 0
        ctl = ctl + 1
        LabelC13.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "c13" Then
                ButtonC13.Text = "♧13"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH1_Click(sender As Object, e As EventArgs) Handles ButtonMH1.Click
        ButtonH1.Show()
        h1 = 0
        hts = hts - 1
        LabelH1.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h1" Then
                ButtonH1.Text = "♥1"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH2_Click(sender As Object, e As EventArgs) Handles ButtonMH2.Click
        ButtonH2.Show()
        h2 = 0
        hts = hts - 1
        LabelH2.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h2" Then
                ButtonH2.Text = "♥2"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH3_Click(sender As Object, e As EventArgs) Handles ButtonMH3.Click
        ButtonH3.Show()
        h3 = 0
        hts = hts - 1
        LabelH3.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h3" Then
                ButtonH3.Text = "♥3"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH4_Click(sender As Object, e As EventArgs) Handles ButtonMH4.Click
        ButtonH4.Show()
        h4 = 0
        hts = hts - 1
        LabelH4.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h4" Then
                ButtonH4.Text = "♥4"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH5_Click(sender As Object, e As EventArgs) Handles ButtonMH5.Click
        ButtonH5.Show()
        h5 = 0
        hts = hts - 1
        LabelH5.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h5" Then
                ButtonH5.Text = "♥5"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH6_Click(sender As Object, e As EventArgs) Handles ButtonMH6.Click
        ButtonH6.Show()
        h6 = 0
        hts = hts - 1
        LabelH6.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h6" Then
                ButtonH6.Text = "♥6"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH8_Click(sender As Object, e As EventArgs) Handles ButtonMH8.Click
        ButtonH8.Show()
        h8 = 0
        htl = htl + 1
        LabelH8.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h8" Then
                ButtonH8.Text = "♥8"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH9_Click(sender As Object, e As EventArgs) Handles ButtonMH9.Click
        ButtonH9.Show()
        h9 = 0
        htl = htl + 1
        LabelH9.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h9" Then
                ButtonH9.Text = "♥9"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH10_Click(sender As Object, e As EventArgs) Handles ButtonMH10.Click
        ButtonH10.Show()
        h10 = 0
        htl = htl + 1
        LabelH10.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h10" Then
                ButtonH10.Text = "♥10"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH11_Click(sender As Object, e As EventArgs) Handles ButtonMH11.Click
        ButtonH11.Show()
        h11 = 0
        htl = htl + 1
        LabelH11.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h11" Then
                ButtonH11.Text = "♥11"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH12_Click(sender As Object, e As EventArgs) Handles ButtonMH12.Click
        ButtonH12.Show()
        h12 = 0
        htl = htl + 1
        LabelH12.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h12" Then
                ButtonH12.Text = "♥12"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMH13_Click(sender As Object, e As EventArgs) Handles ButtonMH13.Click
        ButtonH13.Show()
        h13 = 0
        htl = htl + 1
        LabelH13.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "h13" Then
                ButtonH13.Text = "♥13"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS1_Click(sender As Object, e As EventArgs) Handles ButtonMS1.Click
        ButtonS1.Show()
        s1 = 0
        sts = sts - 1
        LabelS1.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s1" Then
                ButtonS1.Text = "♤1"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS2_Click(sender As Object, e As EventArgs) Handles ButtonMS2.Click
        ButtonS2.Show()
        s2 = 0
        sts = sts - 1
        LabelS2.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s2" Then
                ButtonS2.Text = "♤2"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS3_Click(sender As Object, e As EventArgs) Handles ButtonMS3.Click
        ButtonS3.Show()
        s3 = 0
        sts = sts - 1
        LabelS3.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s3" Then
                ButtonS3.Text = "♤3"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS4_Click(sender As Object, e As EventArgs) Handles ButtonMS4.Click
        ButtonS4.Show()
        s4 = 0
        sts = sts - 1
        LabelS4.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s4" Then
                ButtonS4.Text = "♤4"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS5_Click(sender As Object, e As EventArgs) Handles ButtonMS5.Click
        ButtonS5.Show()
        s5 = 0
        sts = sts - 1
        LabelS5.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s5" Then
                ButtonS5.Text = "♤5"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS6_Click(sender As Object, e As EventArgs) Handles ButtonMS6.Click
        ButtonS6.Show()
        s6 = 0
        sts = sts - 1
        LabelS6.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s6" Then
                ButtonS6.Text = "♤6"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS8_Click(sender As Object, e As EventArgs) Handles ButtonMS8.Click
        ButtonS8.Show()
        s8 = 0
        stl = stl + 1
        LabelS8.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s8" Then
                ButtonS8.Text = "♤8"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS9_Click(sender As Object, e As EventArgs) Handles ButtonMS9.Click
        ButtonS9.Show()
        s9 = 0
        stl = stl + 1
        LabelS9.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s9" Then
                ButtonS9.Text = "♤9"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS10_Click(sender As Object, e As EventArgs) Handles ButtonMS10.Click
        ButtonS10.Show()
        s10 = 0
        stl = stl + 1
        LabelS10.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s10" Then
                ButtonS10.Text = "♤10"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS11_Click(sender As Object, e As EventArgs) Handles ButtonMS11.Click
        ButtonS11.Show()
        s11 = 0
        stl = stl + 1
        LabelS11.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s11" Then
                ButtonS11.Text = "♤11"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS12_Click(sender As Object, e As EventArgs) Handles ButtonMS12.Click
        ButtonS12.Show()
        s12 = 0
        stl = stl + 1
        LabelS12.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s12" Then
                ButtonS12.Text = "♤12"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonMS13_Click(sender As Object, e As EventArgs) Handles ButtonMS13.Click
        ButtonS13.Show()
        s13 = 0
        stl = stl + 1
        LabelS13.Text = t
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If jtf = 1 Then
            If jpb = "s13" Then
                ButtonS13.Text = "♤13"
                jtf = 0
                If dts = 1 Then
                    ButtonMD1.Enabled = True
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = True
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = True
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = True
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = True
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = True
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = True
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = True
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = True
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = True
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = True
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = True
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = True
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = True
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = True
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = True
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = True
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = True
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = True
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = True
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = True
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = True
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = True
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = True
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = True
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = True
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = True
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = True
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = True
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = True
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = True
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = True
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = True
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = True
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = True
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = True
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = True
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = True
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = True
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = True
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = True
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = True
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = True
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = True
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = True
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = True
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = True
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = True
                End If
                If jt > 0 Then
                    j = t
                End If
            End If
        End If
    End Sub

    Private Sub ButtonP_Click(sender As Object, e As EventArgs) Handles ButtonP.Click
        ButtonMD1.Hide()
        ButtonMD2.Hide()
        ButtonMD3.Hide()
        ButtonMD4.Hide()
        ButtonMD5.Hide()
        ButtonMD6.Hide()
        ButtonMD8.Hide()
        ButtonMD9.Hide()
        ButtonMD10.Hide()
        ButtonMD11.Hide()
        ButtonMD12.Hide()
        ButtonMD13.Hide()
        ButtonMC1.Hide()
        ButtonMC2.Hide()
        ButtonMC3.Hide()
        ButtonMC4.Hide()
        ButtonMC5.Hide()
        ButtonMC6.Hide()
        ButtonMC8.Hide()
        ButtonMC9.Hide()
        ButtonMC10.Hide()
        ButtonMC11.Hide()
        ButtonMC12.Hide()
        ButtonMC13.Hide()
        ButtonMH1.Hide()
        ButtonMH2.Hide()
        ButtonMH3.Hide()
        ButtonMH4.Hide()
        ButtonMH5.Hide()
        ButtonMH6.Hide()
        ButtonMH8.Hide()
        ButtonMH9.Hide()
        ButtonMH10.Hide()
        ButtonMH11.Hide()
        ButtonMH12.Hide()
        ButtonMH13.Hide()
        ButtonMS1.Hide()
        ButtonMS2.Hide()
        ButtonMS3.Hide()
        ButtonMS4.Hide()
        ButtonMS5.Hide()
        ButtonMS6.Hide()
        ButtonMS8.Hide()
        ButtonMS9.Hide()
        ButtonMS10.Hide()
        ButtonMS11.Hide()
        ButtonMS12.Hide()
        ButtonMS13.Hide()
        ButtonJ.Hide()
        ButtonP.Hide()
        ButtonN.Show()
        If t = 1 Then
            pt1 = pt1 + 1
            LabelPT1.Text = pt1
            If pt1 = 4 Then
                LabelPT1.Text = "X"
                r1 = rl
                rl = rl - 1
                If d6 = t Then
                    d6 = 0
                    ButtonD6.Show()
                    LabelD6.Text = t
                    If dts = 6 Then
                        dts = dts - 1
                    End If
                End If
                If d5 = t Then
                    d5 = 0
                    ButtonD5.Show()
                    LabelD5.Text = t
                    If dts = 5 Then
                        dts = dts - 1
                    End If
                End If
                If d4 = t Then
                    d4 = 0
                    ButtonD4.Show()
                    LabelD4.Text = t
                    If dts = 4 Then
                        dts = dts - 1
                    End If
                End If
                If d3 = t Then
                    d3 = 0
                    ButtonD3.Show()
                    LabelD3.Text = t
                    If dts = 3 Then
                        dts = dts - 1
                    End If
                End If
                If d2 = t Then
                    d2 = 0
                    ButtonD2.Show()
                    LabelD2.Text = t
                    If dts = 2 Then
                        dts = dts - 1
                    End If
                End If
                If d1 = t Then
                    d1 = 0
                    ButtonD1.Show()
                    LabelD1.Text = t
                    If dts = 1 Then
                        dts = dts - 1
                    End If
                End If
                If d8 = t Then
                    d8 = 0
                    ButtonD8.Show()
                    LabelD8.Text = t
                    If dtl = 8 Then
                        dtl = dtl + 1
                    End If
                End If
                If d9 = t Then
                    d9 = 0
                    ButtonD9.Show()
                    LabelD9.Text = t
                    If dtl = 9 Then
                        dtl = dtl + 1
                    End If
                End If
                If d10 = t Then
                    d10 = 0
                    ButtonD10.Show()
                    LabelD10.Text = t
                    If dtl = 10 Then
                        dtl = dtl + 1
                    End If
                End If
                If d11 = t Then
                    d11 = 0
                    ButtonD11.Show()
                    LabelD11.Text = t
                    If dtl = 11 Then
                        dtl = dtl + 1
                    End If
                End If
                If d12 = t Then
                    d12 = 0
                    ButtonD12.Show()
                    LabelD12.Text = t
                    If dtl = 12 Then
                        dtl = dtl + 1
                    End If
                End If
                If d13 = t Then
                    d13 = 0
                    ButtonD13.Show()
                    LabelD13.Text = t
                    If dtl = 13 Then
                        dtl = dtl + 1
                    End If
                End If
                If c6 = t Then
                    c6 = 0
                    ButtonC6.Show()
                    LabelC6.Text = t
                    If cts = 6 Then
                        cts = cts - 1
                    End If
                End If
                If c5 = t Then
                    c5 = 0
                    ButtonC5.Show()
                    LabelC5.Text = t
                    If cts = 5 Then
                        cts = cts - 1
                    End If
                End If
                If c4 = t Then
                    c4 = 0
                    ButtonC4.Show()
                    LabelC4.Text = t
                    If cts = 4 Then
                        cts = cts - 1
                    End If
                End If
                If c3 = t Then
                    c3 = 0
                    ButtonC3.Show()
                    LabelC3.Text = t
                    If cts = 3 Then
                        cts = cts - 1
                    End If
                End If
                If c2 = t Then
                    c2 = 0
                    ButtonC2.Show()
                    LabelC2.Text = t
                    If cts = 2 Then
                        cts = cts - 1
                    End If
                End If
                If c1 = t Then
                    c1 = 0
                    ButtonC1.Show()
                    LabelC1.Text = t
                    If cts = 1 Then
                        cts = cts - 1
                    End If
                End If
                If c8 = t Then
                    c8 = 0
                    ButtonC8.Show()
                    LabelC8.Text = t
                    If ctl = 8 Then
                        ctl = ctl + 1
                    End If
                End If
                If c9 = t Then
                    c9 = 0
                    ButtonC9.Show()
                    LabelC9.Text = t
                    If ctl = 9 Then
                        ctl = ctl + 1
                    End If
                End If
                If c10 = t Then
                    c10 = 0
                    ButtonC10.Show()
                    LabelC10.Text = t
                    If ctl = 10 Then
                        ctl = ctl + 1
                    End If
                End If
                If c11 = t Then
                    c11 = 0
                    ButtonC11.Show()
                    LabelC11.Text = t
                    If ctl = 11 Then
                        ctl = ctl + 1
                    End If
                End If
                If c12 = t Then
                    c12 = 0
                    ButtonC12.Show()
                    LabelC12.Text = t
                    If ctl = 12 Then
                        ctl = ctl + 1
                    End If
                End If
                If c13 = t Then
                    c13 = 0
                    ButtonC13.Show()
                    LabelC13.Text = t
                    If ctl = 13 Then
                        ctl = ctl + 1
                    End If
                End If
                If h6 = t Then
                    h6 = 0
                    ButtonH6.Show()
                    LabelH6.Text = t
                    If hts = 6 Then
                        hts = hts - 1
                    End If
                End If
                If h5 = t Then
                    h5 = 0
                    ButtonH5.Show()
                    LabelH5.Text = t
                    If hts = 5 Then
                        hts = hts - 1
                    End If
                End If
                If h4 = t Then
                    h4 = 0
                    ButtonH4.Show()
                    LabelH4.Text = t
                    If hts = 4 Then
                        hts = hts - 1
                    End If
                End If
                If h3 = t Then
                    h3 = 0
                    ButtonH3.Show()
                    LabelH3.Text = t
                    If hts = 3 Then
                        hts = hts - 1
                    End If
                End If
                If h2 = t Then
                    h2 = 0
                    ButtonH2.Show()
                    LabelH2.Text = t
                    If hts = 2 Then
                        hts = hts - 1
                    End If
                End If
                If h1 = t Then
                    h1 = 0
                    ButtonH1.Show()
                    LabelH1.Text = t
                    If hts = 1 Then
                        hts = hts - 1
                    End If
                End If
                If h8 = t Then
                    h8 = 0
                    ButtonH8.Show()
                    LabelH8.Text = t
                    If htl = 8 Then
                        htl = htl + 1
                    End If
                End If
                If h9 = t Then
                    h9 = 0
                    ButtonH9.Show()
                    LabelH9.Text = t
                    If htl = 9 Then
                        htl = htl + 1
                    End If
                End If
                If h10 = t Then
                    h10 = 0
                    ButtonH10.Show()
                    LabelH10.Text = t
                    If htl = 10 Then
                        htl = htl + 1
                    End If
                End If
                If h11 = t Then
                    h11 = 0
                    ButtonH11.Show()
                    LabelH11.Text = t
                    If htl = 11 Then
                        htl = htl + 1
                    End If
                End If
                If h12 = t Then
                    h12 = 0
                    ButtonH12.Show()
                    LabelH12.Text = t
                    If htl = 12 Then
                        htl = htl + 1
                    End If
                End If
                If h13 = t Then
                    h13 = 0
                    ButtonH13.Show()
                    LabelH13.Text = t
                    If htl = 13 Then
                        htl = htl + 1
                    End If
                End If
                If s6 = t Then
                    s6 = 0
                    ButtonS6.Show()
                    LabelS6.Text = t
                    If sts = 6 Then
                        sts = sts - 1
                    End If
                End If
                If s5 = t Then
                    s5 = 0
                    ButtonS5.Show()
                    LabelS5.Text = t
                    If sts = 5 Then
                        sts = sts - 1
                    End If
                End If
                If s4 = t Then
                    s4 = 0
                    ButtonS4.Show()
                    LabelS4.Text = t
                    If sts = 4 Then
                        sts = sts - 1
                    End If
                End If
                If s3 = t Then
                    s3 = 0
                    ButtonS3.Show()
                    LabelS3.Text = t
                    If sts = 3 Then
                        sts = sts - 1
                    End If
                End If
                If s2 = t Then
                    s2 = 0
                    ButtonS2.Show()
                    LabelS2.Text = t
                    If sts = 2 Then
                        sts = sts - 1
                    End If
                End If
                If s1 = t Then
                    s1 = 0
                    ButtonS1.Show()
                    LabelS1.Text = t
                    If sts = 1 Then
                        sts = sts - 1
                    End If
                End If
                If s8 = t Then
                    s8 = 0
                    ButtonS8.Show()
                    LabelS8.Text = t
                    If stl = 8 Then
                        stl = stl + 1
                    End If
                End If
                If s9 = t Then
                    s9 = 0
                    ButtonS9.Show()
                    LabelS9.Text = t
                    If stl = 9 Then
                        stl = stl + 1
                    End If
                End If
                If s10 = t Then
                    s10 = 0
                    ButtonS10.Show()
                    LabelS10.Text = t
                    If stl = 10 Then
                        stl = stl + 1
                    End If
                End If
                If s11 = t Then
                    s11 = 0
                    ButtonS11.Show()
                    LabelS11.Text = t
                    If stl = 11 Then
                        stl = stl + 1
                    End If
                End If
                If s12 = t Then
                    s12 = 0
                    ButtonS12.Show()
                    LabelS12.Text = t
                    If stl = 12 Then
                        stl = stl + 1
                    End If
                End If
                If s13 = t Then
                    s13 = 0
                    ButtonS13.Show()
                    LabelS13.Text = t
                    If stl = 13 Then
                        stl = stl + 1
                    End If
                End If
            End If
        ElseIf t = 2 Then
            pt2 = pt2 + 1
            LabelPT2.Text = pt2
            If pt2 = 4 Then
                LabelPT2.Text = "X"
                r2 = rl
                rl = rl - 1
                If d6 = t Then
                    d6 = 0
                    ButtonD6.Show()
                    LabelD6.Text = t
                    If dts = 6 Then
                        dts = dts - 1
                    End If
                End If
                If d5 = t Then
                    d5 = 0
                    ButtonD5.Show()
                    LabelD5.Text = t
                    If dts = 5 Then
                        dts = dts - 1
                    End If
                End If
                If d4 = t Then
                    d4 = 0
                    ButtonD4.Show()
                    LabelD4.Text = t
                    If dts = 4 Then
                        dts = dts - 1
                    End If
                End If
                If d3 = t Then
                    d3 = 0
                    ButtonD3.Show()
                    LabelD3.Text = t
                    If dts = 3 Then
                        dts = dts - 1
                    End If
                End If
                If d2 = t Then
                    d2 = 0
                    ButtonD2.Show()
                    LabelD2.Text = t
                    If dts = 2 Then
                        dts = dts - 1
                    End If
                End If
                If d1 = t Then
                    d1 = 0
                    ButtonD1.Show()
                    LabelD1.Text = t
                    If dts = 1 Then
                        dts = dts - 1
                    End If
                End If
                If d8 = t Then
                    d8 = 0
                    ButtonD8.Show()
                    LabelD8.Text = t
                    If dtl = 8 Then
                        dtl = dtl + 1
                    End If
                End If
                If d9 = t Then
                    d9 = 0
                    ButtonD9.Show()
                    LabelD9.Text = t
                    If dtl = 9 Then
                        dtl = dtl + 1
                    End If
                End If
                If d10 = t Then
                    d10 = 0
                    ButtonD10.Show()
                    LabelD10.Text = t
                    If dtl = 10 Then
                        dtl = dtl + 1
                    End If
                End If
                If d11 = t Then
                    d11 = 0
                    ButtonD11.Show()
                    LabelD11.Text = t
                    If dtl = 11 Then
                        dtl = dtl + 1
                    End If
                End If
                If d12 = t Then
                    d12 = 0
                    ButtonD12.Show()
                    LabelD12.Text = t
                    If dtl = 12 Then
                        dtl = dtl + 1
                    End If
                End If
                If d13 = t Then
                    d13 = 0
                    ButtonD13.Show()
                    LabelD13.Text = t
                    If dtl = 13 Then
                        dtl = dtl + 1
                    End If
                End If
                If c6 = t Then
                    c6 = 0
                    ButtonC6.Show()
                    LabelC6.Text = t
                    If cts = 6 Then
                        cts = cts - 1
                    End If
                End If
                If c5 = t Then
                    c5 = 0
                    ButtonC5.Show()
                    LabelC5.Text = t
                    If cts = 5 Then
                        cts = cts - 1
                    End If
                End If
                If c4 = t Then
                    c4 = 0
                    ButtonC4.Show()
                    LabelC4.Text = t
                    If cts = 4 Then
                        cts = cts - 1
                    End If
                End If
                If c3 = t Then
                    c3 = 0
                    ButtonC3.Show()
                    LabelC3.Text = t
                    If cts = 3 Then
                        cts = cts - 1
                    End If
                End If
                If c2 = t Then
                    c2 = 0
                    ButtonC2.Show()
                    LabelC2.Text = t
                    If cts = 2 Then
                        cts = cts - 1
                    End If
                End If
                If c1 = t Then
                    c1 = 0
                    ButtonC1.Show()
                    LabelC1.Text = t
                    If cts = 1 Then
                        cts = cts - 1
                    End If
                End If
                If c8 = t Then
                    c8 = 0
                    ButtonC8.Show()
                    LabelC8.Text = t
                    If ctl = 8 Then
                        ctl = ctl + 1
                    End If
                End If
                If c9 = t Then
                    c9 = 0
                    ButtonC9.Show()
                    LabelC9.Text = t
                    If ctl = 9 Then
                        ctl = ctl + 1
                    End If
                End If
                If c10 = t Then
                    c10 = 0
                    ButtonC10.Show()
                    LabelC10.Text = t
                    If ctl = 10 Then
                        ctl = ctl + 1
                    End If
                End If
                If c11 = t Then
                    c11 = 0
                    ButtonC11.Show()
                    LabelC11.Text = t
                    If ctl = 11 Then
                        ctl = ctl + 1
                    End If
                End If
                If c12 = t Then
                    c12 = 0
                    ButtonC12.Show()
                    LabelC12.Text = t
                    If ctl = 12 Then
                        ctl = ctl + 1
                    End If
                End If
                If c13 = t Then
                    c13 = 0
                    ButtonC13.Show()
                    LabelC13.Text = t
                    If ctl = 13 Then
                        ctl = ctl + 1
                    End If
                End If
                If h6 = t Then
                    h6 = 0
                    ButtonH6.Show()
                    LabelH6.Text = t
                    If hts = 6 Then
                        hts = hts - 1
                    End If
                End If
                If h5 = t Then
                    h5 = 0
                    ButtonH5.Show()
                    LabelH5.Text = t
                    If hts = 5 Then
                        hts = hts - 1
                    End If
                End If
                If h4 = t Then
                    h4 = 0
                    ButtonH4.Show()
                    LabelH4.Text = t
                    If hts = 4 Then
                        hts = hts - 1
                    End If
                End If
                If h3 = t Then
                    h3 = 0
                    ButtonH3.Show()
                    LabelH3.Text = t
                    If hts = 3 Then
                        hts = hts - 1
                    End If
                End If
                If h2 = t Then
                    h2 = 0
                    ButtonH2.Show()
                    LabelH2.Text = t
                    If hts = 2 Then
                        hts = hts - 1
                    End If
                End If
                If h1 = t Then
                    h1 = 0
                    ButtonH1.Show()
                    LabelH1.Text = t
                    If hts = 1 Then
                        hts = hts - 1
                    End If
                End If
                If h8 = t Then
                    h8 = 0
                    ButtonH8.Show()
                    LabelH8.Text = t
                    If htl = 8 Then
                        htl = htl + 1
                    End If
                End If
                If h9 = t Then
                    h9 = 0
                    ButtonH9.Show()
                    LabelH9.Text = t
                    If htl = 9 Then
                        htl = htl + 1
                    End If
                End If
                If h10 = t Then
                    h10 = 0
                    ButtonH10.Show()
                    LabelH10.Text = t
                    If htl = 10 Then
                        htl = htl + 1
                    End If
                End If
                If h11 = t Then
                    h11 = 0
                    ButtonH11.Show()
                    LabelH11.Text = t
                    If htl = 11 Then
                        htl = htl + 1
                    End If
                End If
                If h12 = t Then
                    h12 = 0
                    ButtonH12.Show()
                    LabelH12.Text = t
                    If htl = 12 Then
                        htl = htl + 1
                    End If
                End If
                If h13 = t Then
                    h13 = 0
                    ButtonH13.Show()
                    LabelH13.Text = t
                    If htl = 13 Then
                        htl = htl + 1
                    End If
                End If
                If s6 = t Then
                    s6 = 0
                    ButtonS6.Show()
                    LabelS6.Text = t
                    If sts = 6 Then
                        sts = sts - 1
                    End If
                End If
                If s5 = t Then
                    s5 = 0
                    ButtonS5.Show()
                    LabelS5.Text = t
                    If sts = 5 Then
                        sts = sts - 1
                    End If
                End If
                If s4 = t Then
                    s4 = 0
                    ButtonS4.Show()
                    LabelS4.Text = t
                    If sts = 4 Then
                        sts = sts - 1
                    End If
                End If
                If s3 = t Then
                    s3 = 0
                    ButtonS3.Show()
                    LabelS3.Text = t
                    If sts = 3 Then
                        sts = sts - 1
                    End If
                End If
                If s2 = t Then
                    s2 = 0
                    ButtonS2.Show()
                    LabelS2.Text = t
                    If sts = 2 Then
                        sts = sts - 1
                    End If
                End If
                If s1 = t Then
                    s1 = 0
                    ButtonS1.Show()
                    LabelS1.Text = t
                    If sts = 1 Then
                        sts = sts - 1
                    End If
                End If
                If s8 = t Then
                    s8 = 0
                    ButtonS8.Show()
                    LabelS8.Text = t
                    If stl = 8 Then
                        stl = stl + 1
                    End If
                End If
                If s9 = t Then
                    s9 = 0
                    ButtonS9.Show()
                    LabelS9.Text = t
                    If stl = 9 Then
                        stl = stl + 1
                    End If
                End If
                If s10 = t Then
                    s10 = 0
                    ButtonS10.Show()
                    LabelS10.Text = t
                    If stl = 10 Then
                        stl = stl + 1
                    End If
                End If
                If s11 = t Then
                    s11 = 0
                    ButtonS11.Show()
                    LabelS11.Text = t
                    If stl = 11 Then
                        stl = stl + 1
                    End If
                End If
                If s12 = t Then
                    s12 = 0
                    ButtonS12.Show()
                    LabelS12.Text = t
                    If stl = 12 Then
                        stl = stl + 1
                    End If
                End If
                If s13 = t Then
                    s13 = 0
                    ButtonS13.Show()
                    LabelS13.Text = t
                    If stl = 13 Then
                        stl = stl + 1
                    End If
                End If
            End If
        ElseIf t = 3 Then
            pt3 = pt3 + 1
            LabelPT3.Text = pt3
            If pt3 = 4 Then
                LabelPT3.Text = "X"
                r3 = rl
                rl = rl - 1
                If d6 = t Then
                    d6 = 0
                    ButtonD6.Show()
                    LabelD6.Text = t
                    If dts = 6 Then
                        dts = dts - 1
                    End If
                End If
                If d5 = t Then
                    d5 = 0
                    ButtonD5.Show()
                    LabelD5.Text = t
                    If dts = 5 Then
                        dts = dts - 1
                    End If
                End If
                If d4 = t Then
                    d4 = 0
                    ButtonD4.Show()
                    LabelD4.Text = t
                    If dts = 4 Then
                        dts = dts - 1
                    End If
                End If
                If d3 = t Then
                    d3 = 0
                    ButtonD3.Show()
                    LabelD3.Text = t
                    If dts = 3 Then
                        dts = dts - 1
                    End If
                End If
                If d2 = t Then
                    d2 = 0
                    ButtonD2.Show()
                    LabelD2.Text = t
                    If dts = 2 Then
                        dts = dts - 1
                    End If
                End If
                If d1 = t Then
                    d1 = 0
                    ButtonD1.Show()
                    LabelD1.Text = t
                    If dts = 1 Then
                        dts = dts - 1
                    End If
                End If
                If d8 = t Then
                    d8 = 0
                    ButtonD8.Show()
                    LabelD8.Text = t
                    If dtl = 8 Then
                        dtl = dtl + 1
                    End If
                End If
                If d9 = t Then
                    d9 = 0
                    ButtonD9.Show()
                    LabelD9.Text = t
                    If dtl = 9 Then
                        dtl = dtl + 1
                    End If
                End If
                If d10 = t Then
                    d10 = 0
                    ButtonD10.Show()
                    LabelD10.Text = t
                    If dtl = 10 Then
                        dtl = dtl + 1
                    End If
                End If
                If d11 = t Then
                    d11 = 0
                    ButtonD11.Show()
                    LabelD11.Text = t
                    If dtl = 11 Then
                        dtl = dtl + 1
                    End If
                End If
                If d12 = t Then
                    d12 = 0
                    ButtonD12.Show()
                    LabelD12.Text = t
                    If dtl = 12 Then
                        dtl = dtl + 1
                    End If
                End If
                If d13 = t Then
                    d13 = 0
                    ButtonD13.Show()
                    LabelD13.Text = t
                    If dtl = 13 Then
                        dtl = dtl + 1
                    End If
                End If
                If c6 = t Then
                    c6 = 0
                    ButtonC6.Show()
                    LabelC6.Text = t
                    If cts = 6 Then
                        cts = cts - 1
                    End If
                End If
                If c5 = t Then
                    c5 = 0
                    ButtonC5.Show()
                    LabelC5.Text = t
                    If cts = 5 Then
                        cts = cts - 1
                    End If
                End If
                If c4 = t Then
                    c4 = 0
                    ButtonC4.Show()
                    LabelC4.Text = t
                    If cts = 4 Then
                        cts = cts - 1
                    End If
                End If
                If c3 = t Then
                    c3 = 0
                    ButtonC3.Show()
                    LabelC3.Text = t
                    If cts = 3 Then
                        cts = cts - 1
                    End If
                End If
                If c2 = t Then
                    c2 = 0
                    ButtonC2.Show()
                    LabelC2.Text = t
                    If cts = 2 Then
                        cts = cts - 1
                    End If
                End If
                If c1 = t Then
                    c1 = 0
                    ButtonC1.Show()
                    LabelC1.Text = t
                    If cts = 1 Then
                        cts = cts - 1
                    End If
                End If
                If c8 = t Then
                    c8 = 0
                    ButtonC8.Show()
                    LabelC8.Text = t
                    If ctl = 8 Then
                        ctl = ctl + 1
                    End If
                End If
                If c9 = t Then
                    c9 = 0
                    ButtonC9.Show()
                    LabelC9.Text = t
                    If ctl = 9 Then
                        ctl = ctl + 1
                    End If
                End If
                If c10 = t Then
                    c10 = 0
                    ButtonC10.Show()
                    LabelC10.Text = t
                    If ctl = 10 Then
                        ctl = ctl + 1
                    End If
                End If
                If c11 = t Then
                    c11 = 0
                    ButtonC11.Show()
                    LabelC11.Text = t
                    If ctl = 11 Then
                        ctl = ctl + 1
                    End If
                End If
                If c12 = t Then
                    c12 = 0
                    ButtonC12.Show()
                    LabelC12.Text = t
                    If ctl = 12 Then
                        ctl = ctl + 1
                    End If
                End If
                If c13 = t Then
                    c13 = 0
                    ButtonC13.Show()
                    LabelC13.Text = t
                    If ctl = 13 Then
                        ctl = ctl + 1
                    End If
                End If
                If h6 = t Then
                    h6 = 0
                    ButtonH6.Show()
                    LabelH6.Text = t
                    If hts = 6 Then
                        hts = hts - 1
                    End If
                End If
                If h5 = t Then
                    h5 = 0
                    ButtonH5.Show()
                    LabelH5.Text = t
                    If hts = 5 Then
                        hts = hts - 1
                    End If
                End If
                If h4 = t Then
                    h4 = 0
                    ButtonH4.Show()
                    LabelH4.Text = t
                    If hts = 4 Then
                        hts = hts - 1
                    End If
                End If
                If h3 = t Then
                    h3 = 0
                    ButtonH3.Show()
                    LabelH3.Text = t
                    If hts = 3 Then
                        hts = hts - 1
                    End If
                End If
                If h2 = t Then
                    h2 = 0
                    ButtonH2.Show()
                    LabelH2.Text = t
                    If hts = 2 Then
                        hts = hts - 1
                    End If
                End If
                If h1 = t Then
                    h1 = 0
                    ButtonH1.Show()
                    LabelH1.Text = t
                    If hts = 1 Then
                        hts = hts - 1
                    End If
                End If
                If h8 = t Then
                    h8 = 0
                    ButtonH8.Show()
                    LabelH8.Text = t
                    If htl = 8 Then
                        htl = htl + 1
                    End If
                End If
                If h9 = t Then
                    h9 = 0
                    ButtonH9.Show()
                    LabelH9.Text = t
                    If htl = 9 Then
                        htl = htl + 1
                    End If
                End If
                If h10 = t Then
                    h10 = 0
                    ButtonH10.Show()
                    LabelH10.Text = t
                    If htl = 10 Then
                        htl = htl + 1
                    End If
                End If
                If h11 = t Then
                    h11 = 0
                    ButtonH11.Show()
                    LabelH11.Text = t
                    If htl = 11 Then
                        htl = htl + 1
                    End If
                End If
                If h12 = t Then
                    h12 = 0
                    ButtonH12.Show()
                    LabelH12.Text = t
                    If htl = 12 Then
                        htl = htl + 1
                    End If
                End If
                If h13 = t Then
                    h13 = 0
                    ButtonH13.Show()
                    LabelH13.Text = t
                    If htl = 13 Then
                        htl = htl + 1
                    End If
                End If
                If s6 = t Then
                    s6 = 0
                    ButtonS6.Show()
                    LabelS6.Text = t
                    If sts = 6 Then
                        sts = sts - 1
                    End If
                End If
                If s5 = t Then
                    s5 = 0
                    ButtonS5.Show()
                    LabelS5.Text = t
                    If sts = 5 Then
                        sts = sts - 1
                    End If
                End If
                If s4 = t Then
                    s4 = 0
                    ButtonS4.Show()
                    LabelS4.Text = t
                    If sts = 4 Then
                        sts = sts - 1
                    End If
                End If
                If s3 = t Then
                    s3 = 0
                    ButtonS3.Show()
                    LabelS3.Text = t
                    If sts = 3 Then
                        sts = sts - 1
                    End If
                End If
                If s2 = t Then
                    s2 = 0
                    ButtonS2.Show()
                    LabelS2.Text = t
                    If sts = 2 Then
                        sts = sts - 1
                    End If
                End If
                If s1 = t Then
                    s1 = 0
                    ButtonS1.Show()
                    LabelS1.Text = t
                    If sts = 1 Then
                        sts = sts - 1
                    End If
                End If
                If s8 = t Then
                    s8 = 0
                    ButtonS8.Show()
                    LabelS8.Text = t
                    If stl = 8 Then
                        stl = stl + 1
                    End If
                End If
                If s9 = t Then
                    s9 = 0
                    ButtonS9.Show()
                    LabelS9.Text = t
                    If stl = 9 Then
                        stl = stl + 1
                    End If
                End If
                If s10 = t Then
                    s10 = 0
                    ButtonS10.Show()
                    LabelS10.Text = t
                    If stl = 10 Then
                        stl = stl + 1
                    End If
                End If
                If s11 = t Then
                    s11 = 0
                    ButtonS11.Show()
                    LabelS11.Text = t
                    If stl = 11 Then
                        stl = stl + 1
                    End If
                End If
                If s12 = t Then
                    s12 = 0
                    ButtonS12.Show()
                    LabelS12.Text = t
                    If stl = 12 Then
                        stl = stl + 1
                    End If
                End If
                If s13 = t Then
                    s13 = 0
                    ButtonS13.Show()
                    LabelS13.Text = t
                    If stl = 13 Then
                        stl = stl + 1
                    End If
                End If
            End If
        ElseIf t = 4 Then
            pt4 = pt4 + 1
            LabelPT4.Text = pt4
            If pt4 = 4 Then
                LabelPT4.Text = "X"
                r4 = rl
                rl = rl - 1
                If d6 = t Then
                    d6 = 0
                    ButtonD6.Show()
                    LabelD6.Text = t
                    If dts = 6 Then
                        dts = dts - 1
                    End If
                End If
                If d5 = t Then
                    d5 = 0
                    ButtonD5.Show()
                    LabelD5.Text = t
                    If dts = 5 Then
                        dts = dts - 1
                    End If
                End If
                If d4 = t Then
                    d4 = 0
                    ButtonD4.Show()
                    LabelD4.Text = t
                    If dts = 4 Then
                        dts = dts - 1
                    End If
                End If
                If d3 = t Then
                    d3 = 0
                    ButtonD3.Show()
                    LabelD3.Text = t
                    If dts = 3 Then
                        dts = dts - 1
                    End If
                End If
                If d2 = t Then
                    d2 = 0
                    ButtonD2.Show()
                    LabelD2.Text = t
                    If dts = 2 Then
                        dts = dts - 1
                    End If
                End If
                If d1 = t Then
                    d1 = 0
                    ButtonD1.Show()
                    LabelD1.Text = t
                    If dts = 1 Then
                        dts = dts - 1
                    End If
                End If
                If d8 = t Then
                    d8 = 0
                    ButtonD8.Show()
                    LabelD8.Text = t
                    If dtl = 8 Then
                        dtl = dtl + 1
                    End If
                End If
                If d9 = t Then
                    d9 = 0
                    ButtonD9.Show()
                    LabelD9.Text = t
                    If dtl = 9 Then
                        dtl = dtl + 1
                    End If
                End If
                If d10 = t Then
                    d10 = 0
                    ButtonD10.Show()
                    LabelD10.Text = t
                    If dtl = 10 Then
                        dtl = dtl + 1
                    End If
                End If
                If d11 = t Then
                    d11 = 0
                    ButtonD11.Show()
                    LabelD11.Text = t
                    If dtl = 11 Then
                        dtl = dtl + 1
                    End If
                End If
                If d12 = t Then
                    d12 = 0
                    ButtonD12.Show()
                    LabelD12.Text = t
                    If dtl = 12 Then
                        dtl = dtl + 1
                    End If
                End If
                If d13 = t Then
                    d13 = 0
                    ButtonD13.Show()
                    LabelD13.Text = t
                    If dtl = 13 Then
                        dtl = dtl + 1
                    End If
                End If
                If c6 = t Then
                    c6 = 0
                    ButtonC6.Show()
                    LabelC6.Text = t
                    If cts = 6 Then
                        cts = cts - 1
                    End If
                End If
                If c5 = t Then
                    c5 = 0
                    ButtonC5.Show()
                    LabelC5.Text = t
                    If cts = 5 Then
                        cts = cts - 1
                    End If
                End If
                If c4 = t Then
                    c4 = 0
                    ButtonC4.Show()
                    LabelC4.Text = t
                    If cts = 4 Then
                        cts = cts - 1
                    End If
                End If
                If c3 = t Then
                    c3 = 0
                    ButtonC3.Show()
                    LabelC3.Text = t
                    If cts = 3 Then
                        cts = cts - 1
                    End If
                End If
                If c2 = t Then
                    c2 = 0
                    ButtonC2.Show()
                    LabelC2.Text = t
                    If cts = 2 Then
                        cts = cts - 1
                    End If
                End If
                If c1 = t Then
                    c1 = 0
                    ButtonC1.Show()
                    LabelC1.Text = t
                    If cts = 1 Then
                        cts = cts - 1
                    End If
                End If
                If c8 = t Then
                    c8 = 0
                    ButtonC8.Show()
                    LabelC8.Text = t
                    If ctl = 8 Then
                        ctl = ctl + 1
                    End If
                End If
                If c9 = t Then
                    c9 = 0
                    ButtonC9.Show()
                    LabelC9.Text = t
                    If ctl = 9 Then
                        ctl = ctl + 1
                    End If
                End If
                If c10 = t Then
                    c10 = 0
                    ButtonC10.Show()
                    LabelC10.Text = t
                    If ctl = 10 Then
                        ctl = ctl + 1
                    End If
                End If
                If c11 = t Then
                    c11 = 0
                    ButtonC11.Show()
                    LabelC11.Text = t
                    If ctl = 11 Then
                        ctl = ctl + 1
                    End If
                End If
                If c12 = t Then
                    c12 = 0
                    ButtonC12.Show()
                    LabelC12.Text = t
                    If ctl = 12 Then
                        ctl = ctl + 1
                    End If
                End If
                If c13 = t Then
                    c13 = 0
                    ButtonC13.Show()
                    LabelC13.Text = t
                    If ctl = 13 Then
                        ctl = ctl + 1
                    End If
                End If
                If h6 = t Then
                    h6 = 0
                    ButtonH6.Show()
                    LabelH6.Text = t
                    If hts = 6 Then
                        hts = hts - 1
                    End If
                End If
                If h5 = t Then
                    h5 = 0
                    ButtonH5.Show()
                    LabelH5.Text = t
                    If hts = 5 Then
                        hts = hts - 1
                    End If
                End If
                If h4 = t Then
                    h4 = 0
                    ButtonH4.Show()
                    LabelH4.Text = t
                    If hts = 4 Then
                        hts = hts - 1
                    End If
                End If
                If h3 = t Then
                    h3 = 0
                    ButtonH3.Show()
                    LabelH3.Text = t
                    If hts = 3 Then
                        hts = hts - 1
                    End If
                End If
                If h2 = t Then
                    h2 = 0
                    ButtonH2.Show()
                    LabelH2.Text = t
                    If hts = 2 Then
                        hts = hts - 1
                    End If
                End If
                If h1 = t Then
                    h1 = 0
                    ButtonH1.Show()
                    LabelH1.Text = t
                    If hts = 1 Then
                        hts = hts - 1
                    End If
                End If
                If h8 = t Then
                    h8 = 0
                    ButtonH8.Show()
                    LabelH8.Text = t
                    If htl = 8 Then
                        htl = htl + 1
                    End If
                End If
                If h9 = t Then
                    h9 = 0
                    ButtonH9.Show()
                    LabelH9.Text = t
                    If htl = 9 Then
                        htl = htl + 1
                    End If
                End If
                If h10 = t Then
                    h10 = 0
                    ButtonH10.Show()
                    LabelH10.Text = t
                    If htl = 10 Then
                        htl = htl + 1
                    End If
                End If
                If h11 = t Then
                    h11 = 0
                    ButtonH11.Show()
                    LabelH11.Text = t
                    If htl = 11 Then
                        htl = htl + 1
                    End If
                End If
                If h12 = t Then
                    h12 = 0
                    ButtonH12.Show()
                    LabelH12.Text = t
                    If htl = 12 Then
                        htl = htl + 1
                    End If
                End If
                If h13 = t Then
                    h13 = 0
                    ButtonH13.Show()
                    LabelH13.Text = t
                    If htl = 13 Then
                        htl = htl + 1
                    End If
                End If
                If s6 = t Then
                    s6 = 0
                    ButtonS6.Show()
                    LabelS6.Text = t
                    If sts = 6 Then
                        sts = sts - 1
                    End If
                End If
                If s5 = t Then
                    s5 = 0
                    ButtonS5.Show()
                    LabelS5.Text = t
                    If sts = 5 Then
                        sts = sts - 1
                    End If
                End If
                If s4 = t Then
                    s4 = 0
                    ButtonS4.Show()
                    LabelS4.Text = t
                    If sts = 4 Then
                        sts = sts - 1
                    End If
                End If
                If s3 = t Then
                    s3 = 0
                    ButtonS3.Show()
                    LabelS3.Text = t
                    If sts = 3 Then
                        sts = sts - 1
                    End If
                End If
                If s2 = t Then
                    s2 = 0
                    ButtonS2.Show()
                    LabelS2.Text = t
                    If sts = 2 Then
                        sts = sts - 1
                    End If
                End If
                If s1 = t Then
                    s1 = 0
                    ButtonS1.Show()
                    LabelS1.Text = t
                    If sts = 1 Then
                        sts = sts - 1
                    End If
                End If
                If s8 = t Then
                    s8 = 0
                    ButtonS8.Show()
                    LabelS8.Text = t
                    If stl = 8 Then
                        stl = stl + 1
                    End If
                End If
                If s9 = t Then
                    s9 = 0
                    ButtonS9.Show()
                    LabelS9.Text = t
                    If stl = 9 Then
                        stl = stl + 1
                    End If
                End If
                If s10 = t Then
                    s10 = 0
                    ButtonS10.Show()
                    LabelS10.Text = t
                    If stl = 10 Then
                        stl = stl + 1
                    End If
                End If
                If s11 = t Then
                    s11 = 0
                    ButtonS11.Show()
                    LabelS11.Text = t
                    If stl = 11 Then
                        stl = stl + 1
                    End If
                End If
                If s12 = t Then
                    s12 = 0
                    ButtonS12.Show()
                    LabelS12.Text = t
                    If stl = 12 Then
                        stl = stl + 1
                    End If
                End If
                If s13 = t Then
                    s13 = 0
                    ButtonS13.Show()
                    LabelS13.Text = t
                    If stl = 13 Then
                        stl = stl + 1
                    End If
                End If
            End If
        ElseIf t = 5 Then
            pt5 = pt5 + 1
            LabelPT5.Text = pt5
            If pt5 = 4 Then
                LabelPT5.Text = "X"
                r5 = rl
                rl = rl - 1
                If d6 = t Then
                    d6 = 0
                    ButtonD6.Show()
                    LabelD6.Text = t
                    If dts = 6 Then
                        dts = dts - 1
                    End If
                End If
                If d5 = t Then
                    d5 = 0
                    ButtonD5.Show()
                    LabelD5.Text = t
                    If dts = 5 Then
                        dts = dts - 1
                    End If
                End If
                If d4 = t Then
                    d4 = 0
                    ButtonD4.Show()
                    LabelD4.Text = t
                    If dts = 4 Then
                        dts = dts - 1
                    End If
                End If
                If d3 = t Then
                    d3 = 0
                    ButtonD3.Show()
                    LabelD3.Text = t
                    If dts = 3 Then
                        dts = dts - 1
                    End If
                End If
                If d2 = t Then
                    d2 = 0
                    ButtonD2.Show()
                    LabelD2.Text = t
                    If dts = 2 Then
                        dts = dts - 1
                    End If
                End If
                If d1 = t Then
                    d1 = 0
                    ButtonD1.Show()
                    LabelD1.Text = t
                    If dts = 1 Then
                        dts = dts - 1
                    End If
                End If
                If d8 = t Then
                    d8 = 0
                    ButtonD8.Show()
                    LabelD8.Text = t
                    If dtl = 8 Then
                        dtl = dtl + 1
                    End If
                End If
                If d9 = t Then
                    d9 = 0
                    ButtonD9.Show()
                    LabelD9.Text = t
                    If dtl = 9 Then
                        dtl = dtl + 1
                    End If
                End If
                If d10 = t Then
                    d10 = 0
                    ButtonD10.Show()
                    LabelD10.Text = t
                    If dtl = 10 Then
                        dtl = dtl + 1
                    End If
                End If
                If d11 = t Then
                    d11 = 0
                    ButtonD11.Show()
                    LabelD11.Text = t
                    If dtl = 11 Then
                        dtl = dtl + 1
                    End If
                End If
                If d12 = t Then
                    d12 = 0
                    ButtonD12.Show()
                    LabelD12.Text = t
                    If dtl = 12 Then
                        dtl = dtl + 1
                    End If
                End If
                If d13 = t Then
                    d13 = 0
                    ButtonD13.Show()
                    LabelD13.Text = t
                    If dtl = 13 Then
                        dtl = dtl + 1
                    End If
                End If
                If c6 = t Then
                    c6 = 0
                    ButtonC6.Show()
                    LabelC6.Text = t
                    If cts = 6 Then
                        cts = cts - 1
                    End If
                End If
                If c5 = t Then
                    c5 = 0
                    ButtonC5.Show()
                    LabelC5.Text = t
                    If cts = 5 Then
                        cts = cts - 1
                    End If
                End If
                If c4 = t Then
                    c4 = 0
                    ButtonC4.Show()
                    LabelC4.Text = t
                    If cts = 4 Then
                        cts = cts - 1
                    End If
                End If
                If c3 = t Then
                    c3 = 0
                    ButtonC3.Show()
                    LabelC3.Text = t
                    If cts = 3 Then
                        cts = cts - 1
                    End If
                End If
                If c2 = t Then
                    c2 = 0
                    ButtonC2.Show()
                    LabelC2.Text = t
                    If cts = 2 Then
                        cts = cts - 1
                    End If
                End If
                If c1 = t Then
                    c1 = 0
                    ButtonC1.Show()
                    LabelC1.Text = t
                    If cts = 1 Then
                        cts = cts - 1
                    End If
                End If
                If c8 = t Then
                    c8 = 0
                    ButtonC8.Show()
                    LabelC8.Text = t
                    If ctl = 8 Then
                        ctl = ctl + 1
                    End If
                End If
                If c9 = t Then
                    c9 = 0
                    ButtonC9.Show()
                    LabelC9.Text = t
                    If ctl = 9 Then
                        ctl = ctl + 1
                    End If
                End If
                If c10 = t Then
                    c10 = 0
                    ButtonC10.Show()
                    LabelC10.Text = t
                    If ctl = 10 Then
                        ctl = ctl + 1
                    End If
                End If
                If c11 = t Then
                    c11 = 0
                    ButtonC11.Show()
                    LabelC11.Text = t
                    If ctl = 11 Then
                        ctl = ctl + 1
                    End If
                End If
                If c12 = t Then
                    c12 = 0
                    ButtonC12.Show()
                    LabelC12.Text = t
                    If ctl = 12 Then
                        ctl = ctl + 1
                    End If
                End If
                If c13 = t Then
                    c13 = 0
                    ButtonC13.Show()
                    LabelC13.Text = t
                    If ctl = 13 Then
                        ctl = ctl + 1
                    End If
                End If
                If h6 = t Then
                    h6 = 0
                    ButtonH6.Show()
                    LabelH6.Text = t
                    If hts = 6 Then
                        hts = hts - 1
                    End If
                End If
                If h5 = t Then
                    h5 = 0
                    ButtonH5.Show()
                    LabelH5.Text = t
                    If hts = 5 Then
                        hts = hts - 1
                    End If
                End If
                If h4 = t Then
                    h4 = 0
                    ButtonH4.Show()
                    LabelH4.Text = t
                    If hts = 4 Then
                        hts = hts - 1
                    End If
                End If
                If h3 = t Then
                    h3 = 0
                    ButtonH3.Show()
                    LabelH3.Text = t
                    If hts = 3 Then
                        hts = hts - 1
                    End If
                End If
                If h2 = t Then
                    h2 = 0
                    ButtonH2.Show()
                    LabelH2.Text = t
                    If hts = 2 Then
                        hts = hts - 1
                    End If
                End If
                If h1 = t Then
                    h1 = 0
                    ButtonH1.Show()
                    LabelH1.Text = t
                    If hts = 1 Then
                        hts = hts - 1
                    End If
                End If
                If h8 = t Then
                    h8 = 0
                    ButtonH8.Show()
                    LabelH8.Text = t
                    If htl = 8 Then
                        htl = htl + 1
                    End If
                End If
                If h9 = t Then
                    h9 = 0
                    ButtonH9.Show()
                    LabelH9.Text = t
                    If htl = 9 Then
                        htl = htl + 1
                    End If
                End If
                If h10 = t Then
                    h10 = 0
                    ButtonH10.Show()
                    LabelH10.Text = t
                    If htl = 10 Then
                        htl = htl + 1
                    End If
                End If
                If h11 = t Then
                    h11 = 0
                    ButtonH11.Show()
                    LabelH11.Text = t
                    If htl = 11 Then
                        htl = htl + 1
                    End If
                End If
                If h12 = t Then
                    h12 = 0
                    ButtonH12.Show()
                    LabelH12.Text = t
                    If htl = 12 Then
                        htl = htl + 1
                    End If
                End If
                If h13 = t Then
                    h13 = 0
                    ButtonH13.Show()
                    LabelH13.Text = t
                    If htl = 13 Then
                        htl = htl + 1
                    End If
                End If
                If s6 = t Then
                    s6 = 0
                    ButtonS6.Show()
                    LabelS6.Text = t
                    If sts = 6 Then
                        sts = sts - 1
                    End If
                End If
                If s5 = t Then
                    s5 = 0
                    ButtonS5.Show()
                    LabelS5.Text = t
                    If sts = 5 Then
                        sts = sts - 1
                    End If
                End If
                If s4 = t Then
                    s4 = 0
                    ButtonS4.Show()
                    LabelS4.Text = t
                    If sts = 4 Then
                        sts = sts - 1
                    End If
                End If
                If s3 = t Then
                    s3 = 0
                    ButtonS3.Show()
                    LabelS3.Text = t
                    If sts = 3 Then
                        sts = sts - 1
                    End If
                End If
                If s2 = t Then
                    s2 = 0
                    ButtonS2.Show()
                    LabelS2.Text = t
                    If sts = 2 Then
                        sts = sts - 1
                    End If
                End If
                If s1 = t Then
                    s1 = 0
                    ButtonS1.Show()
                    LabelS1.Text = t
                    If sts = 1 Then
                        sts = sts - 1
                    End If
                End If
                If s8 = t Then
                    s8 = 0
                    ButtonS8.Show()
                    LabelS8.Text = t
                    If stl = 8 Then
                        stl = stl + 1
                    End If
                End If
                If s9 = t Then
                    s9 = 0
                    ButtonS9.Show()
                    LabelS9.Text = t
                    If stl = 9 Then
                        stl = stl + 1
                    End If
                End If
                If s10 = t Then
                    s10 = 0
                    ButtonS10.Show()
                    LabelS10.Text = t
                    If stl = 10 Then
                        stl = stl + 1
                    End If
                End If
                If s11 = t Then
                    s11 = 0
                    ButtonS11.Show()
                    LabelS11.Text = t
                    If stl = 11 Then
                        stl = stl + 1
                    End If
                End If
                If s12 = t Then
                    s12 = 0
                    ButtonS12.Show()
                    LabelS12.Text = t
                    If stl = 12 Then
                        stl = stl + 1
                    End If
                End If
                If s13 = t Then
                    s13 = 0
                    ButtonS13.Show()
                    LabelS13.Text = t
                    If stl = 13 Then
                        stl = stl + 1
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ButtonN_Click(sender As Object, e As EventArgs) Handles ButtonN.Click
        tt = 0
        If d6 = 0 Then
            If d5 = 0 Then
                If d4 = 0 Then
                    If d3 = 0 Then
                        If d2 = 0 Then
                            If d1 = 0 Then
                            Else
                                dts = 1
                            End If
                        Else
                            dts = 2
                        End If
                    Else
                        dts = 3
                    End If
                Else
                    dts = 4
                End If
            Else
                dts = 5
            End If
        End If
        If d8 = 0 Then
            If d9 = 0 Then
                If d10 = 0 Then
                    If d11 = 0 Then
                        If d12 = 0 Then
                            If d13 = 0 Then
                            Else
                                dtl = 13
                            End If
                        Else
                            dtl = 12
                        End If
                    Else
                        dtl = 11
                    End If
                Else
                    dtl = 10
                End If
            Else
                dtl = 9
            End If
        End If
        If c6 = 0 Then
            If c5 = 0 Then
                If c4 = 0 Then
                    If c3 = 0 Then
                        If c2 = 0 Then
                            If c1 = 0 Then
                            Else
                                cts = 1
                            End If
                        Else
                            cts = 2
                        End If
                    Else
                        cts = 3
                    End If
                Else
                    cts = 4
                End If
            Else
                cts = 5
            End If
        End If
        If c8 = 0 Then
            If c9 = 0 Then
                If c10 = 0 Then
                    If c11 = 0 Then
                        If c12 = 0 Then
                            If c13 = 0 Then
                            Else
                                ctl = 13
                            End If
                        Else
                            ctl = 12
                        End If
                    Else
                        ctl = 11
                    End If
                Else
                    ctl = 10
                End If
            Else
                ctl = 9
            End If
        End If
        If h6 = 0 Then
            If h5 = 0 Then
                If h4 = 0 Then
                    If h3 = 0 Then
                        If h2 = 0 Then
                            If h1 = 0 Then
                            Else
                                hts = 1
                            End If
                        Else
                            hts = 2
                        End If
                    Else
                        hts = 3
                    End If
                Else
                    hts = 4
                End If
            Else
                hts = 5
            End If
        End If
        If h8 = 0 Then
            If h9 = 0 Then
                If h10 = 0 Then
                    If h11 = 0 Then
                        If h12 = 0 Then
                            If h13 = 0 Then
                            Else
                                htl = 13
                            End If
                        Else
                            htl = 12
                        End If
                    Else
                        htl = 11
                    End If
                Else
                    htl = 10
                End If
            Else
                htl = 9
            End If
        End If
        If s6 = 0 Then
            If s5 = 0 Then
                If s4 = 0 Then
                    If s3 = 0 Then
                        If s2 = 0 Then
                            If s1 = 0 Then
                            Else
                                sts = 1
                            End If
                        Else
                            sts = 2
                        End If
                    Else
                        sts = 3
                    End If
                Else
                    sts = 4
                End If
            Else
                sts = 5
            End If
        End If
        If s8 = 0 Then
            If s9 = 0 Then
                If s10 = 0 Then
                    If s11 = 0 Then
                        If s12 = 0 Then
                            If s13 = 0 Then
                            Else
                                stl = 13
                            End If
                        Else
                            stl = 12
                        End If
                    Else
                        stl = 11
                    End If
                Else
                    stl = 10
                End If
            Else
                stl = 9
            End If
        End If
TR:
        If p = 3 Then
            If t = 1 Then
                t = t + 1
            ElseIf t = 2 Then
                t = t + 1
            ElseIf t = 3 Then
                t = 1
            End If
        ElseIf p = 4 Then
            If t = 1 Then
                t = t + 1
            ElseIf t = 2 Then
                t = t + 1
            ElseIf t = 3 Then
                t = t + 1
            ElseIf t = 4 Then
                t = 1
            End If
        ElseIf p = 5 Then
            If t = 1 Then
                t = t + 1
            ElseIf t = 2 Then
                t = t + 1
            ElseIf t = 3 Then
                t = t + 1
            ElseIf t = 4 Then
                t = t + 1
            ElseIf t = 5 Then
                t = 1
            End If
        End If
        tt = tt + 1
        If p = 3 Then
            If tt = 3 Then
                Dim f1 As New Result()
                If t = 1 Then
                    r1 = rs
                End If
                If t = 2 Then
                    r2 = rs
                End If
                If t = 3 Then
                    r3 = rs
                End If
                If r1 = 1 Then
                    f1.LabelR1.Text = 1
                End If
                If r2 = 1 Then
                    f1.LabelR1.Text = 2
                End If
                If r3 = 1 Then
                    f1.LabelR1.Text = 3
                End If
                If r1 = 2 Then
                    f1.LabelR2.Text = 1
                End If
                If r2 = 2 Then
                    f1.LabelR2.Text = 2
                End If
                If r3 = 2 Then
                    f1.LabelR2.Text = 3
                End If
                If r1 = 3 Then
                    f1.LabelR3.Text = 1
                End If
                If r2 = 3 Then
                    f1.LabelR3.Text = 2
                End If
                If r3 = 3 Then
                    f1.LabelR3.Text = 3
                End If
                If r1 = 4 Then
                    f1.LabelR4.Text = 1
                End If
                If r2 = 4 Then
                    f1.LabelR4.Text = 2
                End If
                If r3 = 4 Then
                    f1.LabelR4.Text = 3
                End If
                If r1 = 5 Then
                    f1.LabelR5.Text = 1
                End If
                If r2 = 5 Then
                    f1.LabelR5.Text = 2
                End If
                If r3 = 5 Then
                    f1.LabelR5.Text = 3
                End If
                f1.Label11.Text = p
                f1.Show()
                Close()
                GoTo RE
            End If
        ElseIf p = 4 Then
            If tt = 4 Then
                Dim f2 As New Result()
                If t = 1 Then
                    r1 = rs
                End If
                If t = 2 Then
                    r2 = rs
                End If
                If t = 3 Then
                    r3 = rs
                End If
                If t = 4 Then
                    r4 = rs
                End If
                If r1 = 1 Then
                    f2.LabelR1.Text = 1
                End If
                If r2 = 1 Then
                    f2.LabelR1.Text = 2
                End If
                If r3 = 1 Then
                    f2.LabelR1.Text = 3
                End If
                If r4 = 1 Then
                    f2.LabelR1.Text = 4
                End If
                If r1 = 2 Then
                    f2.LabelR2.Text = 1
                End If
                If r2 = 2 Then
                    f2.LabelR2.Text = 2
                End If
                If r3 = 2 Then
                    f2.LabelR2.Text = 3
                End If
                If r4 = 2 Then
                    f2.LabelR2.Text = 4
                End If
                If r1 = 3 Then
                    f2.LabelR3.Text = 1
                End If
                If r2 = 3 Then
                    f2.LabelR3.Text = 2
                End If
                If r3 = 3 Then
                    f2.LabelR3.Text = 3
                End If
                If r4 = 3 Then
                    f2.LabelR3.Text = 4
                End If
                If r1 = 4 Then
                    f2.LabelR4.Text = 1
                End If
                If r2 = 4 Then
                    f2.LabelR4.Text = 2
                End If
                If r3 = 4 Then
                    f2.LabelR4.Text = 3
                End If
                If r4 = 4 Then
                    f2.LabelR4.Text = 4
                End If
                If r1 = 5 Then
                    f2.LabelR5.Text = 1
                End If
                If r2 = 5 Then
                    f2.LabelR5.Text = 2
                End If
                If r3 = 5 Then
                    f2.LabelR5.Text = 3
                End If
                If r4 = 5 Then
                    f2.LabelR5.Text = 4
                End If
                f2.Label11.Text = p
                f2.Show()
                Close()
                GoTo RE
            End If
        ElseIf p = 5 Then
            If tt = 5 Then
                Dim f3 As New Result()
                If t = 1 Then
                    r1 = rs
                End If
                If t = 2 Then
                    r2 = rs
                End If
                If t = 3 Then
                    r3 = rs
                End If
                If t = 4 Then
                    r4 = rs
                End If
                If t = 5 Then
                    r5 = rs
                End If
                If r1 = 1 Then
                    f3.LabelR1.Text = 1
                End If
                If r2 = 1 Then
                    f3.LabelR1.Text = 2
                End If
                If r3 = 1 Then
                    f3.LabelR1.Text = 3
                End If
                If r4 = 1 Then
                    f3.LabelR1.Text = 4
                End If
                If r5 = 1 Then
                    f3.LabelR1.Text = 5
                End If
                If r1 = 2 Then
                    f3.LabelR2.Text = 1
                End If
                If r2 = 2 Then
                    f3.LabelR2.Text = 2
                End If
                If r3 = 2 Then
                    f3.LabelR2.Text = 3
                End If
                If r4 = 2 Then
                    f3.LabelR2.Text = 4
                End If
                If r5 = 2 Then
                    f3.LabelR2.Text = 5
                End If
                If r1 = 3 Then
                    f3.LabelR3.Text = 1
                End If
                If r2 = 3 Then
                    f3.LabelR3.Text = 2
                End If
                If r3 = 3 Then
                    f3.LabelR3.Text = 3
                End If
                If r4 = 3 Then
                    f3.LabelR3.Text = 4
                End If
                If r5 = 3 Then
                    f3.LabelR3.Text = 5
                End If
                If r1 = 4 Then
                    f3.LabelR4.Text = 1
                End If
                If r2 = 4 Then
                    f3.LabelR4.Text = 2
                End If
                If r3 = 4 Then
                    f3.LabelR4.Text = 3
                End If
                If r4 = 4 Then
                    f3.LabelR4.Text = 4
                End If
                If r5 = 4 Then
                    f3.LabelR4.Text = 5
                End If
                If r1 = 5 Then
                    f3.LabelR5.Text = 1
                End If
                If r2 = 5 Then
                    f3.LabelR5.Text = 2
                End If
                If r3 = 5 Then
                    f3.LabelR5.Text = 3
                End If
                If r4 = 5 Then
                    f3.LabelR5.Text = 4
                End If
                If r5 = 5 Then
                    f3.LabelR5.Text = 5
                End If
                f3.Label11.Text = p
                f3.Show()
                Close()
                GoTo RE
            End If
        End If
        If t = 1 Then
            If r1 >= 1 Then
                GoTo TR
            End If
        ElseIf t = 2 Then
            If r2 >= 1 Then
                GoTo TR
            End If
        ElseIf t = 3 Then
            If r3 >= 1 Then
                GoTo TR
            End If
        ElseIf t = 4 Then
            If r4 >= 1 Then
                GoTo TR
            End If
        ElseIf t = 5 Then
            If r5 >= 1 Then
                GoTo TR
            End If
        End If
        If jtf = 1 Then
            If t = jp Then
                If dts = 1 Then
                    ButtonMD1.Enabled = False
                End If
                If dts = 2 Then
                    ButtonMD2.Enabled = False
                End If
                If dts = 3 Then
                    ButtonMD3.Enabled = False
                End If
                If dts = 4 Then
                    ButtonMD4.Enabled = False
                End If
                If dts = 5 Then
                    ButtonMD5.Enabled = False
                End If
                If dts = 6 Then
                    ButtonMD6.Enabled = False
                End If
                If dtl = 8 Then
                    ButtonMD8.Enabled = False
                End If
                If dtl = 9 Then
                    ButtonMD9.Enabled = False
                End If
                If dtl = 10 Then
                    ButtonMD10.Enabled = False
                End If
                If dtl = 11 Then
                    ButtonMD11.Enabled = False
                End If
                If dtl = 12 Then
                    ButtonMD12.Enabled = False
                End If
                If dtl = 13 Then
                    ButtonMD13.Enabled = False
                End If
                If cts = 1 Then
                    ButtonMC1.Enabled = False
                End If
                If cts = 2 Then
                    ButtonMC2.Enabled = False
                End If
                If cts = 3 Then
                    ButtonMC3.Enabled = False
                End If
                If cts = 4 Then
                    ButtonMC4.Enabled = False
                End If
                If cts = 5 Then
                    ButtonMC5.Enabled = False
                End If
                If cts = 6 Then
                    ButtonMC6.Enabled = False
                End If
                If ctl = 8 Then
                    ButtonMC8.Enabled = False
                End If
                If ctl = 9 Then
                    ButtonMC9.Enabled = False
                End If
                If ctl = 10 Then
                    ButtonMC10.Enabled = False
                End If
                If ctl = 11 Then
                    ButtonMC11.Enabled = False
                End If
                If ctl = 12 Then
                    ButtonMC12.Enabled = False
                End If
                If ctl = 13 Then
                    ButtonMC13.Enabled = False
                End If
                If hts = 1 Then
                    ButtonMH1.Enabled = False
                End If
                If hts = 2 Then
                    ButtonMH2.Enabled = False
                End If
                If hts = 3 Then
                    ButtonMH3.Enabled = False
                End If
                If hts = 4 Then
                    ButtonMH4.Enabled = False
                End If
                If hts = 5 Then
                    ButtonMH5.Enabled = False
                End If
                If hts = 6 Then
                    ButtonMH6.Enabled = False
                End If
                If htl = 8 Then
                    ButtonMH8.Enabled = False
                End If
                If htl = 9 Then
                    ButtonMH9.Enabled = False
                End If
                If htl = 10 Then
                    ButtonMH10.Enabled = False
                End If
                If htl = 11 Then
                    ButtonMH11.Enabled = False
                End If
                If htl = 12 Then
                    ButtonMH12.Enabled = False
                End If
                If htl = 13 Then
                    ButtonMH13.Enabled = False
                End If
                If sts = 1 Then
                    ButtonMS1.Enabled = False
                End If
                If sts = 2 Then
                    ButtonMS2.Enabled = False
                End If
                If sts = 3 Then
                    ButtonMS3.Enabled = False
                End If
                If sts = 4 Then
                    ButtonMS4.Enabled = False
                End If
                If sts = 5 Then
                    ButtonMS5.Enabled = False
                End If
                If sts = 6 Then
                    ButtonMS6.Enabled = False
                End If
                If stl = 8 Then
                    ButtonMS8.Enabled = False
                End If
                If stl = 9 Then
                    ButtonMS9.Enabled = False
                End If
                If stl = 10 Then
                    ButtonMS10.Enabled = False
                End If
                If stl = 11 Then
                    ButtonMS11.Enabled = False
                End If
                If stl = 12 Then
                    ButtonMS12.Enabled = False
                End If
                If stl = 13 Then
                    ButtonMS13.Enabled = False
                End If
                If jpb = "d1" Then
                    ButtonMD1.Enabled = True
                End If
                If jpb = "d2" Then
                    ButtonMD2.Enabled = True
                End If
                If jpb = "d3" Then
                    ButtonMD3.Enabled = True
                End If
                If jpb = "d4" Then
                    ButtonMD4.Enabled = True
                End If
                If jpb = "d5" Then
                    ButtonMD5.Enabled = True
                End If
                If jpb = "d6" Then
                    ButtonMD6.Enabled = True
                End If
                If jpb = "d8" Then
                    ButtonMD8.Enabled = True
                End If
                If jpb = "d9" Then
                    ButtonMD9.Enabled = True
                End If
                If jpb = "d10" Then
                    ButtonMD10.Enabled = True
                End If
                If jpb = "d11" Then
                    ButtonMD11.Enabled = True
                End If
                If jpb = "d12" Then
                    ButtonMD12.Enabled = True
                End If
                If jpb = "d13" Then
                    ButtonMD13.Enabled = True
                End If
                If jpb = "c1" Then
                    ButtonMC1.Enabled = True
                End If
                If jpb = "c2" Then
                    ButtonMC2.Enabled = True
                End If
                If jpb = "c3" Then
                    ButtonMC3.Enabled = True
                End If
                If jpb = "c4" Then
                    ButtonMC4.Enabled = True
                End If
                If jpb = "c5" Then
                    ButtonMC5.Enabled = True
                End If
                If jpb = "c6" Then
                    ButtonMC6.Enabled = True
                End If
                If jpb = "c8" Then
                    ButtonMC8.Enabled = True
                End If
                If jpb = "c9" Then
                    ButtonMC9.Enabled = True
                End If
                If jpb = "c10" Then
                    ButtonMC10.Enabled = True
                End If
                If jpb = "c11" Then
                    ButtonMC11.Enabled = True
                End If
                If jpb = "c12" Then
                    ButtonMC12.Enabled = True
                End If
                If jpb = "c13" Then
                    ButtonMC13.Enabled = True
                End If
                If jpb = "h1" Then
                    ButtonMH1.Enabled = True
                End If
                If jpb = "h2" Then
                    ButtonMH2.Enabled = True
                End If
                If jpb = "h3" Then
                    ButtonMH3.Enabled = True
                End If
                If jpb = "h4" Then
                    ButtonMH4.Enabled = True
                End If
                If jpb = "h5" Then
                    ButtonMH5.Enabled = True
                End If
                If jpb = "h6" Then
                    ButtonMH6.Enabled = True
                End If
                If jpb = "h8" Then
                    ButtonMH8.Enabled = True
                End If
                If jpb = "h9" Then
                    ButtonMH9.Enabled = True
                End If
                If jpb = "h10" Then
                    ButtonMH10.Enabled = True
                End If
                If jpb = "h11" Then
                    ButtonMH11.Enabled = True
                End If
                If jpb = "h12" Then
                    ButtonMH12.Enabled = True
                End If
                If jpb = "h13" Then
                    ButtonMH13.Enabled = True
                End If
                If jpb = "s1" Then
                    ButtonMS1.Enabled = True
                End If
                If jpb = "s2" Then
                    ButtonMS2.Enabled = True
                End If
                If jpb = "s3" Then
                    ButtonMS3.Enabled = True
                End If
                If jpb = "s4" Then
                    ButtonMS4.Enabled = True
                End If
                If jpb = "s5" Then
                    ButtonMS5.Enabled = True
                End If
                If jpb = "s6" Then
                    ButtonMS6.Enabled = True
                End If
                If jpb = "s8" Then
                    ButtonMS8.Enabled = True
                End If
                If jpb = "s9" Then
                    ButtonMS9.Enabled = True
                End If
                If jpb = "s10" Then
                    ButtonMS10.Enabled = True
                End If
                If jpb = "s11" Then
                    ButtonMS11.Enabled = True
                End If
                If jpb = "s12" Then
                    ButtonMS12.Enabled = True
                End If
                If jpb = "s13" Then
                    ButtonMS13.Enabled = True
                End If
                If d1 = t Then
                    ButtonMD1.Show()
                End If
                If d2 = t Then
                    ButtonMD2.Show()
                End If
                If d3 = t Then
                    ButtonMD3.Show()
                End If
                If d4 = t Then
                    ButtonMD4.Show()
                End If
                If d5 = t Then
                    ButtonMD5.Show()
                End If
                If d6 = t Then
                    ButtonMD6.Show()
                End If
                If d8 = t Then
                    ButtonMD8.Show()
                End If
                If d9 = t Then
                    ButtonMD9.Show()
                End If
                If d10 = t Then
                    ButtonMD10.Show()
                End If
                If d11 = t Then
                    ButtonMD11.Show()
                End If
                If d12 = t Then
                    ButtonMD12.Show()
                End If
                If d13 = t Then
                    ButtonMD13.Show()
                End If
                If c1 = t Then
                    ButtonMC1.Show()
                End If
                If c2 = t Then
                    ButtonMC2.Show()
                End If
                If c3 = t Then
                    ButtonMC3.Show()
                End If
                If c4 = t Then
                    ButtonMC4.Show()
                End If
                If c5 = t Then
                    ButtonMC5.Show()
                End If
                If c6 = t Then
                    ButtonMC6.Show()
                End If
                If c8 = t Then
                    ButtonMC8.Show()
                End If
                If c9 = t Then
                    ButtonMC9.Show()
                End If
                If c10 = t Then
                    ButtonMC10.Show()
                End If
                If c11 = t Then
                    ButtonMC11.Show()
                End If
                If c12 = t Then
                    ButtonMC12.Show()
                End If
                If c13 = t Then
                    ButtonMC13.Show()
                End If
                If h1 = t Then
                    ButtonMH1.Show()
                End If
                If h2 = t Then
                    ButtonMH2.Show()
                End If
                If h3 = t Then
                    ButtonMH3.Show()
                End If
                If h4 = t Then
                    ButtonMH4.Show()
                End If
                If h5 = t Then
                    ButtonMH5.Show()
                End If
                If h6 = t Then
                    ButtonMH6.Show()
                End If
                If h8 = t Then
                    ButtonMH8.Show()
                End If
                If h9 = t Then
                    ButtonMH9.Show()
                End If
                If h10 = t Then
                    ButtonMH10.Show()
                End If
                If h11 = t Then
                    ButtonMH11.Show()
                End If
                If h12 = t Then
                    ButtonMH12.Show()
                End If
                If h13 = t Then
                    ButtonMH13.Show()
                End If
                If s1 = t Then
                    ButtonMS1.Show()
                End If
                If s2 = t Then
                    ButtonMS2.Show()
                End If
                If s3 = t Then
                    ButtonMS3.Show()
                End If
                If s4 = t Then
                    ButtonMS4.Show()
                End If
                If s5 = t Then
                    ButtonMS5.Show()
                End If
                If s6 = t Then
                    ButtonMS6.Show()
                End If
                If s8 = t Then
                    ButtonMS8.Show()
                End If
                If s9 = t Then
                    ButtonMS9.Show()
                End If
                If s10 = t Then
                    ButtonMS10.Show()
                End If
                If s11 = t Then
                    ButtonMS11.Show()
                End If
                If s12 = t Then
                    ButtonMS12.Show()
                End If
                If s13 = t Then
                    ButtonMS13.Show()
                End If
                GoTo RE
            End If
        End If
        c = 0
        If d1 = t Then
            ButtonMD1.Show()
            c = c + 1
        End If
        If d2 = t Then
            ButtonMD2.Show()
            c = c + 1
        End If
        If d3 = t Then
            ButtonMD3.Show()
            c = c + 1
        End If
        If d4 = t Then
            ButtonMD4.Show()
            c = c + 1
        End If
        If d5 = t Then
            ButtonMD5.Show()
            c = c + 1
        End If
        If d6 = t Then
            ButtonMD6.Show()
            c = c + 1
        End If
        If d8 = t Then
            ButtonMD8.Show()
            c = c + 1
        End If
        If d9 = t Then
            ButtonMD9.Show()
            c = c + 1
        End If
        If d10 = t Then
            ButtonMD10.Show()
            c = c + 1
        End If
        If d11 = t Then
            ButtonMD11.Show()
            c = c + 1
        End If
        If d12 = t Then
            ButtonMD12.Show()
            c = c + 1
        End If
        If d13 = t Then
            ButtonMD13.Show()
            c = c + 1
        End If
        If c1 = t Then
            ButtonMC1.Show()
            c = c + 1
        End If
        If c2 = t Then
            ButtonMC2.Show()
            c = c + 1
        End If
        If c3 = t Then
            ButtonMC3.Show()
            c = c + 1
        End If
        If c4 = t Then
            ButtonMC4.Show()
            c = c + 1
        End If
        If c5 = t Then
            ButtonMC5.Show()
            c = c + 1
        End If
        If c6 = t Then
            ButtonMC6.Show()
            c = c + 1
        End If
        If c8 = t Then
            ButtonMC8.Show()
            c = c + 1
        End If
        If c9 = t Then
            ButtonMC9.Show()
            c = c + 1
        End If
        If c10 = t Then
            ButtonMC10.Show()
            c = c + 1
        End If
        If c11 = t Then
            ButtonMC11.Show()
            c = c + 1
        End If
        If c12 = t Then
            ButtonMC12.Show()
            c = c + 1
        End If
        If c13 = t Then
            ButtonMC13.Show()
            c = c + 1
        End If
        If h1 = t Then
            ButtonMH1.Show()
            c = c + 1
        End If
        If h2 = t Then
            ButtonMH2.Show()
            c = c + 1
        End If
        If h3 = t Then
            ButtonMH3.Show()
            c = c + 1
        End If
        If h4 = t Then
            ButtonMH4.Show()
            c = c + 1
        End If
        If h5 = t Then
            ButtonMH5.Show()
            c = c + 1
        End If
        If h6 = t Then
            ButtonMH6.Show()
            c = c + 1
        End If
        If h8 = t Then
            ButtonMH8.Show()
            c = c + 1
        End If
        If h9 = t Then
            ButtonMH9.Show()
            c = c + 1
        End If
        If h10 = t Then
            ButtonMH10.Show()
            c = c + 1
        End If
        If h11 = t Then
            ButtonMH11.Show()
            c = c + 1
        End If
        If h12 = t Then
            ButtonMH12.Show()
            c = c + 1
        End If
        If h13 = t Then
            ButtonMH13.Show()
            c = c + 1
        End If
        If s1 = t Then
            ButtonMS1.Show()
            c = c + 1
        End If
        If s2 = t Then
            ButtonMS2.Show()
            c = c + 1
        End If
        If s3 = t Then
            ButtonMS3.Show()
            c = c + 1
        End If
        If s4 = t Then
            ButtonMS4.Show()
            c = c + 1
        End If
        If s5 = t Then
            ButtonMS5.Show()
            c = c + 1
        End If
        If s6 = t Then
            ButtonMS6.Show()
            c = c + 1
        End If
        If s8 = t Then
            ButtonMS8.Show()
            c = c + 1
        End If
        If s9 = t Then
            ButtonMS9.Show()
            c = c + 1
        End If
        If s10 = t Then
            ButtonMS10.Show()
            c = c + 1
        End If
        If s11 = t Then
            ButtonMS11.Show()
            c = c + 1
        End If
        If s12 = t Then
            ButtonMS12.Show()
            c = c + 1
        End If
        If s13 = t Then
            ButtonMS13.Show()
            c = c + 1
        End If
        If j = t Then
            ButtonJ.Show()
            If c = 0 Then
                If t = 1 Then
                    r1 = rl
                    rl = rl - 1
                    GoTo TR
                End If
                If t = 2 Then
                    r2 = rl
                    rl = rl - 1
                    GoTo TR
                End If
                If t = 3 Then
                    r3 = rl
                    rl = rl - 1
                    GoTo TR
                End If
                If t = 4 Then
                    r4 = rl
                    rl = rl - 1
                    GoTo TR
                End If
                If t = 5 Then
                    r5 = rl
                    rl = rl - 1
                    GoTo TR
                End If
            End If
        End If
        If c = 0 Then
            If t = 1 Then
                r1 = rs
                rs = rs + 1
                GoTo TR
            End If
            If t = 2 Then
                r2 = rs
                rs = rs + 1
                GoTo TR
            End If
            If t = 3 Then
                r3 = rs
                rs = rs + 1
                GoTo TR
            End If
            If t = 4 Then
                r4 = rs
                rs = rs + 1
                GoTo TR
            End If
            If t = 5 Then
                r5 = rs
                rs = rs + 1
                GoTo TR
            End If
        End If
        ButtonP.Show()
        ButtonMD1.Enabled = False
        ButtonMD2.Enabled = False
        ButtonMD3.Enabled = False
        ButtonMD4.Enabled = False
        ButtonMD5.Enabled = False
        ButtonMD6.Enabled = False
        ButtonMD8.Enabled = False
        ButtonMD9.Enabled = False
        ButtonMD10.Enabled = False
        ButtonMD11.Enabled = False
        ButtonMD12.Enabled = False
        ButtonMD13.Enabled = False
        ButtonMC1.Enabled = False
        ButtonMC2.Enabled = False
        ButtonMC3.Enabled = False
        ButtonMC4.Enabled = False
        ButtonMC5.Enabled = False
        ButtonMC6.Enabled = False
        ButtonMC8.Enabled = False
        ButtonMC9.Enabled = False
        ButtonMC10.Enabled = False
        ButtonMC11.Enabled = False
        ButtonMC12.Enabled = False
        ButtonMC13.Enabled = False
        ButtonMH1.Enabled = False
        ButtonMH2.Enabled = False
        ButtonMH3.Enabled = False
        ButtonMH4.Enabled = False
        ButtonMH5.Enabled = False
        ButtonMH6.Enabled = False
        ButtonMH8.Enabled = False
        ButtonMH9.Enabled = False
        ButtonMH10.Enabled = False
        ButtonMH11.Enabled = False
        ButtonMH12.Enabled = False
        ButtonMH13.Enabled = False
        ButtonMS1.Enabled = False
        ButtonMS2.Enabled = False
        ButtonMS3.Enabled = False
        ButtonMS4.Enabled = False
        ButtonMS5.Enabled = False
        ButtonMS6.Enabled = False
        ButtonMS8.Enabled = False
        ButtonMS9.Enabled = False
        ButtonMS10.Enabled = False
        ButtonMS11.Enabled = False
        ButtonMS12.Enabled = False
        ButtonMS13.Enabled = False
        If dts = 1 Then
            ButtonMD1.Enabled = True
        End If
        If dts = 2 Then
            ButtonMD2.Enabled = True
        End If
        If dts = 3 Then
            ButtonMD3.Enabled = True
        End If
        If dts = 4 Then
            ButtonMD4.Enabled = True
        End If
        If dts = 5 Then
            ButtonMD5.Enabled = True
        End If
        If dts = 6 Then
            ButtonMD6.Enabled = True
        End If
        If dtl = 8 Then
            ButtonMD8.Enabled = True
        End If
        If dtl = 9 Then
            ButtonMD9.Enabled = True
        End If
        If dtl = 10 Then
            ButtonMD10.Enabled = True
        End If
        If dtl = 11 Then
            ButtonMD11.Enabled = True
        End If
        If dtl = 12 Then
            ButtonMD12.Enabled = True
        End If
        If dtl = 13 Then
            ButtonMD13.Enabled = True
        End If
        If cts = 1 Then
            ButtonMC1.Enabled = True
        End If
        If cts = 2 Then
            ButtonMC2.Enabled = True
        End If
        If cts = 3 Then
            ButtonMC3.Enabled = True
        End If
        If cts = 4 Then
            ButtonMC4.Enabled = True
        End If
        If cts = 5 Then
            ButtonMC5.Enabled = True
        End If
        If cts = 6 Then
            ButtonMC6.Enabled = True
        End If
        If ctl = 8 Then
            ButtonMC8.Enabled = True
        End If
        If ctl = 9 Then
            ButtonMC9.Enabled = True
        End If
        If ctl = 10 Then
            ButtonMC10.Enabled = True
        End If
        If ctl = 11 Then
            ButtonMC11.Enabled = True
        End If
        If ctl = 12 Then
            ButtonMC12.Enabled = True
        End If
        If ctl = 13 Then
            ButtonMC13.Enabled = True
        End If
        If hts = 1 Then
            ButtonMH1.Enabled = True
        End If
        If hts = 2 Then
            ButtonMH2.Enabled = True
        End If
        If hts = 3 Then
            ButtonMH3.Enabled = True
        End If
        If hts = 4 Then
            ButtonMH4.Enabled = True
        End If
        If hts = 5 Then
            ButtonMH5.Enabled = True
        End If
        If hts = 6 Then
            ButtonMH6.Enabled = True
        End If
        If htl = 8 Then
            ButtonMH8.Enabled = True
        End If
        If htl = 9 Then
            ButtonMH9.Enabled = True
        End If
        If htl = 10 Then
            ButtonMH10.Enabled = True
        End If
        If htl = 11 Then
            ButtonMH11.Enabled = True
        End If
        If htl = 12 Then
            ButtonMH12.Enabled = True
        End If
        If htl = 13 Then
            ButtonMH13.Enabled = True
        End If
        If sts = 1 Then
            ButtonMS1.Enabled = True
        End If
        If sts = 2 Then
            ButtonMS2.Enabled = True
        End If
        If sts = 3 Then
            ButtonMS3.Enabled = True
        End If
        If sts = 4 Then
            ButtonMS4.Enabled = True
        End If
        If sts = 5 Then
            ButtonMS5.Enabled = True
        End If
        If sts = 6 Then
            ButtonMS6.Enabled = True
        End If
        If stl = 8 Then
            ButtonMS8.Enabled = True
        End If
        If stl = 9 Then
            ButtonMS9.Enabled = True
        End If
        If stl = 10 Then
            ButtonMS10.Enabled = True
        End If
        If stl = 11 Then
            ButtonMS11.Enabled = True
        End If
        If stl = 12 Then
            ButtonMS12.Enabled = True
        End If
        If stl = 13 Then
            ButtonMS13.Enabled = True
        End If
RE:
        LabelPN.Text = t
        ButtonN.Hide()
    End Sub
End Class