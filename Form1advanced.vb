Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            TextBox3.Text = ("Please type a word to search into the above box. or type ""-h"" for advanced help")

        Else


            ' Under the Relevant Button click method:
            ' Note: One should add relevant referrences in order for it to work
            ' I have added most of them without the need to figure out which one specifically :) 

            Dim myProcess As Process = New Process
            Dim s As String
            myProcess.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()

            Dim sIn As System.IO.StreamWriter = myProcess.StandardInput
            Dim sOut As System.IO.StreamReader = myProcess.StandardOutput
            Dim sErr As System.IO.StreamReader = myProcess.StandardError

            sIn.AutoFlush = True

            sIn.Write("nslookup -q=txt " & TextBox1.Text & ".wp.dg.cx" & System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()




            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If
            TextBox2.Text = s
            TextBox2.Visible = False
            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()

            TextBox3.Text = (TextBox2.Lines(9) & TextBox2.Lines(10) & TextBox2.Lines(11))
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal eventargs As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(eventargs.KeyChar)
        If KeyAscii = 13 Then
            If TextBox1.Text = "" Then
                TextBox3.Text = ("Please type a word to search into the above box. or type ""-h"" for advanced help")

            Else


                ' Under the Relevant Button click method:
                ' Note: One should add relevant referrences in order for it to work
                ' I have added most of them without the need to figure out which one specifically :) 

                Dim myProcess As Process = New Process
                Dim s As String
                myProcess.StartInfo.FileName = "c:\windows\system32\cmd.exe"
                myProcess.StartInfo.UseShellExecute = False
                myProcess.StartInfo.CreateNoWindow = True
                myProcess.StartInfo.RedirectStandardInput = True
                myProcess.StartInfo.RedirectStandardOutput = True
                myProcess.StartInfo.RedirectStandardError = True
                myProcess.Start()

                Dim sIn As System.IO.StreamWriter = myProcess.StandardInput
                Dim sOut As System.IO.StreamReader = myProcess.StandardOutput
                Dim sErr As System.IO.StreamReader = myProcess.StandardError

                sIn.AutoFlush = True

                sIn.Write("nslookup -q=txt " & TextBox1.Text & ".wp.dg.cx" & System.Environment.NewLine)
                sIn.Write("exit" & System.Environment.NewLine)
                s = sOut.ReadToEnd()




                If Not myProcess.HasExited Then
                    myProcess.Kill()
                End If
                TextBox2.Text = s
                TextBox2.Visible = False
                sIn.Close()
                sOut.Close()
                sErr.Close()
                myProcess.Close()

                TextBox3.Text = (TextBox2.Lines(9) & TextBox2.Lines(10) & TextBox2.Lines(11))
            End If
        End If
        If KeyAscii = 0 Then
            eventargs.Handled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            TextBox3.Text = ("Please type a word to search into the above box. or type ""-h"" for advanced help")

        Else


            ' Under the Relevant Button click method:
            ' Note: One should add relevant referrences in order for it to work
            ' I have added most of them without the need to figure out which one specifically :) 

            Dim myProcess As Process = New Process
            Dim s As String
            myProcess.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()

            Dim sIn As System.IO.StreamWriter = myProcess.StandardInput
            Dim sOut As System.IO.StreamReader = myProcess.StandardOutput
            Dim sErr As System.IO.StreamReader = myProcess.StandardError

            sIn.AutoFlush = True

            sIn.Write("nslookup -q=txt " & TextBox1.Text & ".wp.dg.cx" & System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()




            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If
            TextBox2.Text = s
            TextBox2.Visible = False
            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()

            TextBox3.Text = (TextBox2.Lines(9) & TextBox2.Lines(10) & TextBox2.Lines(11))


            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")

            SAPI.Speak(TextBox2.Lines(9) & TextBox2.Lines(10) & TextBox2.Lines(11))
        End If


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Process.Start("https://twitter.com/HBRN8")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("http://en.wikipedia.org/wiki/" & TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Then
            TextBox3.Text = ("Please type a word to search into the above box. or type ""-h"" for advanced help")

        Else


            ' Under the Relevant Button click method:
            ' Note: One should add relevant referrences in order for it to work
            ' I have added most of them without the need to figure out which one specifically :) 

            Dim myProcess As Process = New Process
            Dim s As String
            myProcess.StartInfo.FileName = "c:\windows\system32\cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()

            Dim sIn As System.IO.StreamWriter = myProcess.StandardInput
            Dim sOut As System.IO.StreamReader = myProcess.StandardOutput
            Dim sErr As System.IO.StreamReader = myProcess.StandardError

            sIn.AutoFlush = True

            sIn.Write("nslookup -q=txt " & TextBox1.Text & ".wp.dg.cx" & System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()




            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If
            TextBox2.Text = s
            TextBox2.Visible = False
            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()

            'new sorting

            Dim somestring1 As String = TextBox2.Text.Replace("text =", "Ì")


            Dim somestring2 As String = somestring1.Replace("""	   """, "")
            Dim somestring3 As String = somestring2.Replace("http", """Ì")


            TextBox2.Text = somestring3

            Dim somestring6() As String
            somestring6 = TextBox2.Text.Split("Ì")

  
            TextBox2.Text = somestring6(1)
 

            'remove line spaces
            Dim linerem1 As String = TextBox2.Text.Replace("""a", "º")
            Dim linerem2 As String = linerem1.Replace("""b", "º")
            Dim linerem3 As String = linerem2.Replace("""c", "º")
            Dim linerem4 As String = linerem3.Replace("""d", "º")
            Dim linerem5 As String = linerem4.Replace("""e", "º")
            Dim linerem6 As String = linerem5.Replace("""f", "º")
            Dim linerem7 As String = linerem6.Replace("""g", "º")
            Dim linerem8 As String = linerem7.Replace("""h", "º")
            Dim linerem9 As String = linerem8.Replace("""i", "º")
            Dim linerem10 As String = linerem9.Replace("""j", "º")
            Dim linerem11 As String = linerem10.Replace("""k", "º")
            Dim linerem12 As String = linerem11.Replace("""l", "º")
            Dim linerem13 As String = linerem12.Replace("""m", "º")
            Dim linerem14 As String = linerem13.Replace("""n", "º")
            Dim linerem15 As String = linerem14.Replace("""o", "º")
            Dim linerem16 As String = linerem15.Replace("""p", "º")
            Dim linerem17 As String = linerem16.Replace("""q", "º")
            Dim linerem18 As String = linerem17.Replace("""r", "º")
            Dim linerem19 As String = linerem18.Replace("""s", "º")
            Dim linerem20 As String = linerem19.Replace("""t", "º")
            Dim linerem21 As String = linerem20.Replace("""u", "º")
            Dim linerem22 As String = linerem21.Replace("""v", "º")
            Dim linerem23 As String = linerem22.Replace("""w", "º")
            Dim linerem24 As String = linerem23.Replace("""x", "º")
            Dim linerem25 As String = linerem24.Replace("""y", "º")
            Dim linerem26 As String = linerem25.Replace("""z", "º")



            Dim linerem27 As String = linerem26.Replace("a""", "aº")
            Dim linerem28 As String = linerem27.Replace("b""", "bº")
            Dim linerem29 As String = linerem28.Replace("c""", "cº")
            Dim linerem30 As String = linerem29.Replace("d""", "dº")
            Dim linerem31 As String = linerem30.Replace("e""", "eº")
            Dim linerem32 As String = linerem31.Replace("f""", "fº")
            Dim linerem33 As String = linerem32.Replace("g""", "gº")
            Dim linerem34 As String = linerem33.Replace("h""", "hº")
            Dim linerem35 As String = linerem34.Replace("i""", "iº")
            Dim linerem36 As String = linerem35.Replace("j""", "jº")
            Dim linerem37 As String = linerem36.Replace("k""", "kº")
            Dim linerem38 As String = linerem37.Replace("l""", "lº")
            Dim linerem39 As String = linerem38.Replace("m""", "mº")
            Dim linerem40 As String = linerem39.Replace("n""", "nº")
            Dim linerem41 As String = linerem40.Replace("o""", "oº")
            Dim linerem42 As String = linerem41.Replace("p""", "pº")
            Dim linerem43 As String = linerem42.Replace("q""", "qº")
            Dim linerem44 As String = linerem43.Replace("r""", "rº")
            Dim linerem45 As String = linerem44.Replace("s""", "sº")
            Dim linerem46 As String = linerem45.Replace("t""", "tº")
            Dim linerem47 As String = linerem46.Replace("u""", "uº")
            Dim linerem48 As String = linerem47.Replace("v""", "vº")
            Dim linerem49 As String = linerem48.Replace("w""", "wº")
            Dim linerem50 As String = linerem49.Replace("x""", "xº")
            Dim linerem51 As String = linerem50.Replace("y""", "yº")
            Dim linerem52 As String = linerem51.Replace("z""", "zº")

            TextBox2.Text = linerem52
            TextBox3.Text = linerem52

            Dim linerem53() As String = {0, 1, 2, 3, 4}
            linerem53 = TextBox2.Text.Split("º")

         
            TextBox3.Text = linerem53(0) & linerem53(1) & linerem53(2)
        End If
    End Sub
End Class
