VERSION 5.00
Begin VB.Form HiV 
   BackColor       =   &H80000008&
   BorderStyle     =   0  'None
   Caption         =   "Hi V"
   ClientHeight    =   15360
   ClientLeft      =   0
   ClientTop       =   105
   ClientWidth     =   19200
   LinkTopic       =   "Form1"
   MousePointer    =   2  'Cross
   Moveable        =   0   'False
   ScaleHeight     =   15360
   ScaleWidth      =   19200
   WindowState     =   2  'Maximized
   Begin VB.PictureBox picDraw 
      BackColor       =   &H80000007&
      BorderStyle     =   0  'None
      Height          =   15285
      Left            =   0
      ScaleHeight     =   25753.21
      ScaleMode       =   0  'User
      ScaleWidth      =   19125
      TabIndex        =   0
      Top             =   -120
      Width           =   19125
   End
End
Attribute VB_Name = "HiV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub picDraw_MouseMove(Button As Integer, Shift As Integer, x As Single, y As Single)

Dim r, g, b, xx, yy As Long
Dim sx, sy As Integer

sx = Screen.Width \ Screen.TwipsPerPixelX
sy = Screen.Height \ Screen.TwipsPerPixelY

cc = 0.01

xx = 1
yy = 1

While True

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
r = r + cc
Loop Until r > 255

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
g = g + cc
Loop Until g > 255

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
r = r - cc
Loop Until r < 0

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
p = p + cc
Loop Until p > 255

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
g = g - cc
Loop Until g < 0

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
r = r + cc
Loop Until r > 255

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
g = g + cc
Loop Until g > 255

Do
picDraw.Line (picDraw.ScaleWidth / 2, picDraw.ScaleHeight / 2)-(picDraw.ScaleWidth / xx, picDraw.ScaleHeight / yy), RGB(r, g, p)
r = r - cc
p = p - cc
g = g - cc
Loop Until r < 0

Wend

End Sub

