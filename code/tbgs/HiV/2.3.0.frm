VERSION 5.00
Begin VB.Form frmVirus 
   BackColor       =   &H80000008&
   BorderStyle     =   0  'None
   Caption         =   "Oops!"
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
      Top             =   0
      Width           =   19125
   End
End
Attribute VB_Name = "frmVirus"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False

Private Sub picDraw_MouseMove(Button As Integer, Shift As Integer, X As Single, Y As Single)
While True
picDraw.Circle (Rnd * picDraw.ScaleWidth, Rnd * picDraw.ScaleHeight), Rnd * 600 / Rnd * Rnd, RGB(Rnd * 300, Rnd * 300, Rnd * 300)
Wend
End Sub
