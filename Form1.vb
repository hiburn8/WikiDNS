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

                'new sorting

                Dim somestring1 As String = TextBox2.Text.Replace("text =", "Ì")

                Dim somestring2 As String = somestring1.Replace("http", """Ì")


                TextBox2.Text = somestring2

                Dim somestring3() As String
                somestring3 = TextBox2.Text.Split("Ì")


                TextBox3.Text = somestring3(1)

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

            'new sorting

            Dim somestring1 As String = TextBox2.Text.Replace("text =", "Ì")

            Dim somestring2 As String = somestring1.Replace("http", """Ì")


            TextBox2.Text = somestring2

            Dim somestring3() As String
            somestring3 = TextBox2.Text.Split("Ì")


            TextBox3.Text = somestring3(1)


            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")

            SAPI.Speak(somestring3(1))
        End If


    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False
        Button1.Visible = False
        Button4.Visible = False
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
            Dim linerem1 As String = TextBox2.Text.Replace("""a", "a")
            Dim linerem2 As String = linerem1.Replace("""b", "b")
            Dim linerem3 As String = linerem2.Replace("""c", "c")
            Dim linerem4 As String = linerem3.Replace("""d", "d")
            Dim linerem5 As String = linerem4.Replace("""e", "e")
            Dim linerem6 As String = linerem5.Replace("""f", "f")
            Dim linerem7 As String = linerem6.Replace("""g", "g")
            Dim linerem8 As String = linerem7.Replace("""h", "h")
            Dim linerem9 As String = linerem8.Replace("""i", "i")
            Dim linerem10 As String = linerem9.Replace("""j", "j")
            Dim linerem11 As String = linerem10.Replace("""k", "k")
            Dim linerem12 As String = linerem11.Replace("""l", "l")
            Dim linerem13 As String = linerem12.Replace("""m", "m")
            Dim linerem14 As String = linerem13.Replace("""n", "n")
            Dim linerem15 As String = linerem14.Replace("""o", "o")
            Dim linerem16 As String = linerem15.Replace("""p", "p")
            Dim linerem17 As String = linerem16.Replace("""q", "q")
            Dim linerem18 As String = linerem17.Replace("""r", "r")
            Dim linerem19 As String = linerem18.Replace("""s", "s")
            Dim linerem20 As String = linerem19.Replace("""t", "t")
            Dim linerem21 As String = linerem20.Replace("""u", "u")
            Dim linerem22 As String = linerem21.Replace("""v", "v")
            Dim linerem23 As String = linerem22.Replace("""w", "w")
            Dim linerem24 As String = linerem23.Replace("""x", "x")
            Dim linerem25 As String = linerem24.Replace("""y", "y")
            Dim linerem26 As String = linerem25.Replace("""z", "z")



            Dim linerem27 As String = linerem26.Replace("a""", "a-")
            Dim linerem28 As String = linerem27.Replace("b""", "b-")
            Dim linerem29 As String = linerem28.Replace("c""", "c-")
            Dim linerem30 As String = linerem29.Replace("d""", "d-")
            Dim linerem31 As String = linerem30.Replace("e""", "e-")
            Dim linerem32 As String = linerem31.Replace("f""", "f-")
            Dim linerem33 As String = linerem32.Replace("g""", "g-")
            Dim linerem34 As String = linerem33.Replace("h""", "h-")
            Dim linerem35 As String = linerem34.Replace("i""", "i-")
            Dim linerem36 As String = linerem35.Replace("j""", "j-")
            Dim linerem37 As String = linerem36.Replace("k""", "k-")
            Dim linerem38 As String = linerem37.Replace("l""", "l-")
            Dim linerem39 As String = linerem38.Replace("m""", "m-")
            Dim linerem40 As String = linerem39.Replace("n""", "n-")
            Dim linerem41 As String = linerem40.Replace("o""", "o-")
            Dim linerem42 As String = linerem41.Replace("p""", "p-")
            Dim linerem43 As String = linerem42.Replace("q""", "q-")
            Dim linerem44 As String = linerem43.Replace("r""", "r-")
            Dim linerem45 As String = linerem44.Replace("s""", "s-")
            Dim linerem46 As String = linerem45.Replace("t""", "t-")
            Dim linerem47 As String = linerem46.Replace("u""", "u-")
            Dim linerem48 As String = linerem47.Replace("v""", "v-")
            Dim linerem49 As String = linerem48.Replace("w""", "w-")
            Dim linerem50 As String = linerem49.Replace("x""", "x-")
            Dim linerem51 As String = linerem50.Replace("y""", "y-")
            Dim linerem52 As String = linerem51.Replace("z""", "z-")


            TextBox3.Text = linerem52
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

            Dim somestring2 As String = somestring1.Replace("http", """Ì")


            TextBox2.Text = somestring2

            Dim somestring3() As String
            somestring3 = TextBox2.Text.Split("Ì")


            TextBox3.Text = somestring3(1)

        End If
    End Sub
End Class
