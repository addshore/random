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
Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Long) As Long
Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
Private Sub picDraw_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
While True
picDraw.Circle (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), Rnd * 600 / Rnd * Rnd, RGB(Rnd * 300, Rnd * 300, Rnd * 300)
picDraw.Line (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight)-(Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
Wend
End Sub
Private Sub Form_Activate()
    DoEvents
    BlockInput True
End Sub

