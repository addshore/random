VERSION 5.00
Begin VB.Form frmVirus 
   BackColor       =   &H80000007&
   BorderStyle     =   0  'None
   Caption         =   "Oops!"
   ClientHeight    =   14175
   ClientLeft      =   0
   ClientTop       =   105
   ClientWidth     =   18690
   LinkTopic       =   "Form1"
   MousePointer    =   2  'Cross
   Moveable        =   0   'False
   ScaleHeight     =   14175
   ScaleWidth      =   18690
   WindowState     =   2  'Maximized
   Begin VB.PictureBox picDraw 
      BackColor       =   &H80000007&
      BorderStyle     =   0  'None
      Height          =   11535
      Left            =   0
      ScaleHeight     =   19434.95
      ScaleMode       =   0  'User
      ScaleWidth      =   16200
      TabIndex        =   0
      Top             =   240
      Width           =   16200
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

Private Sub Form_Load()
'Form5.Show
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
