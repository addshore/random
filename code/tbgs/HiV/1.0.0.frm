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
Private Sub Picture1_Load()
Randomize
i = Int(16 * Rnd)
FillStyle = 0
FillColour = QBColour(i)
End Sub


Private Sub picDraw_Click()
While 1 = 1
picDraw.Circle (2000, 2000), 1000
Dim Pink As Integer
For Counter = 1 To 32299 Step 1
X = Rnd * picDraw.ScaleWidth
Y = Rnd * picDraw.ScaleHeight
radius = Rnd * 500
Pink = Int(Rnd * 16)
FillStyle = 0
FillColor = QBColor(Pink)
picDraw.Circle (X, Y), radius, RGB(Rnd * 255, Rnd * 255, Rnd * 255)
Next Counter
Wend
End Sub
