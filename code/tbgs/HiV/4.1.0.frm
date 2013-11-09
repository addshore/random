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
   ScaleHeight     =   19800
   ScaleMode       =   0  'User
   ScaleWidth      =   19800
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
Private Declare Function MCISendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Long) As Long
Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

Private Sub picDraw_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
While True
'picDraw.Circle (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), Rnd * 600 / Rnd * Rnd, RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(0, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
'Ret = MCISendString("set CDAudio door open", RetStr, 127, 0)
'Ret = MCISendString("set CDAudio door closed", RetStr, 127, 0)
'Rnd * picDraw.ScaleWidth Rnd * picDraw.ScaleHeight Rnd * picDraw.ScaleWidth
picDraw.Line (0, 0)-(0, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(150, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(300, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(450, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(600, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(750, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(900, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1050, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1200, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1350, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1500, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1650, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1800, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(1950, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(2100, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(2250, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(2400, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (0, 0)-(2550, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
Wend
End Sub
