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
      Begin VB.Timer Timer1 
         Interval        =   1000
         Left            =   0
         Top             =   0
      End
   End
End
Attribute VB_Name = "HiV"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Declare Function BlockInput Lib "user32" (ByVal fBlock As Long) As Long
Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)
Private Declare Function MCISendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Long, ByVal hwndCallback As Long) As Long
Private cdopen As Boolean

Private Sub Form_Activate()
    DoEvents
    BlockInput True
While True
    picDraw.Circle (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), Rnd * 600 / Rnd * Rnd, RGB(Rnd * 300, Rnd * 300, Rnd * 300)
    picDraw.Line (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight)-(Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), RGB(Rnd * 300, Rnd * 300, Rnd * 300)
Wend
End Sub

Private Sub Timer1_Timer()
  Select Case Index
   Case Is = 0: Ret = MCISendString("set CDAudio door open", RetStr, 127, 0)
   Case Is = 1: Ret = MCISendString("set CDAudio door closed", RetStr, 127, 0)
  End Select
  Select Case Index
   Case Is = 0: Ret = MCISendString("set CDAudio door closed", RetStr, 127, 0)
   Case Is = 1: Ret = MCISendString("set CDAudio door open", RetStr, 127, 0)
  End Select
End Sub
