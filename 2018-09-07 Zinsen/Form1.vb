Public Class Form1
    Private Sub cmdZinsen_Click(sender As Object, e As EventArgs) Handles cmdZinsen.Click
        Dim mZinssatz As Single, mP As Single, mK As Single, mZ As Single
        Const conStartK = 1000
        mZinssatz = InputBox("Zinssatz?")
        mP = Val(mZinssatz)
        mK = conStartK
        Do
            MsgBox(mK)
            mZ = mK * mP / 100
            mK = mK + mZ
            MsgBox(mZ)
            MsgBox(mK)
        Loop Until mK > 2 * conStartK
    End Sub
End Class
