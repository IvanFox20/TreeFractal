using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace TreeFractal
{
    public partial class Graph : Form
    {
        private readonly int _aplhaAngle;
        private readonly int _betaAngle;
        private readonly double _coef;
        private readonly int _startLength;
        private readonly int _stepsCount;
        public Graph(int aplhaAngle, int betaAngle, double coef, int startLength, int stepsCount)
        {
            _aplhaAngle = aplhaAngle;
            _betaAngle = betaAngle;
            _coef = coef;
            _startLength = startLength;
            _stepsCount = stepsCount;
            InitializeComponent();
        }
        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                ClientRectangle.Height - 20);
        }
        
        private void CreateGraph(ZedGraphControl zgc)
        {
            //получим панель для рисования
            GraphPane pane = zgc.GraphPane;

            int rootX = 0;
            int rootY = 0;
            int x = rootX;
            int y = rootY + _startLength;
            /*PointPairList pointList = new PointPairList();
            pointList.Add(rootX, rootY);
            pointList.Add(x, y);
            LineItem line = pane.AddCurve("Линия", pointList, Color.Blue, SymbolType.None);*/
            LineObj line = new LineObj(Color.SaddleBrown, rootX, rootY, x, y);
            line.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            line.Line.Width = 10;
            pane.GraphObjList.Add (line);
            Tuple<int, int> point = new Tuple<int, int>(x,y);
            Branch(point,0,_stepsCount,_startLength,ref pane);
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void Branch(Tuple<int,int> point, int angle, int stepsCount,double length,ref GraphPane pane)
        {
            if (stepsCount <= 0) return;
            int leftAngle = Normalize(angle + _aplhaAngle);
            int rightAngle = Normalize(angle - _betaAngle);
            int x = point.Item1;
            int y = point.Item2;
            Tuple<int,int> leftPoint = GetBranchEnding(x, y, leftAngle, length);
            Tuple<int,int> rightPoint = GetBranchEnding(x, y, rightAngle, length);
            
            LineObj lineLeft = new LineObj(Color.Green, x, y, leftPoint.Item1, leftPoint.Item2);
            lineLeft.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lineLeft.Line.Width = stepsCount / 2;
            pane.GraphObjList.Add (lineLeft);
            LineObj lineRigth = new LineObj(Color.Green, x, y, rightPoint.Item1, rightPoint.Item2);
            lineRigth.Line.Style = System.Drawing.Drawing2D.DashStyle.Solid;
            lineRigth.Line.Width = stepsCount / 2;
            pane.GraphObjList.Add (lineRigth);
            
            stepsCount--;
            Branch(leftPoint,leftAngle,stepsCount,length * _coef,ref pane);
            Branch(rightPoint,rightAngle,stepsCount,length * _coef,ref pane);

        }

        private Tuple<int, int> GetBranchEnding(int x,int y,int angle, double length) // Вычисляем координату конечной точки с учётом поворота
        {
            int xEnd = x + (int)(Math.Sin(Math.PI / 180 * angle) * length);
            int yEnd = y + (int)(Math.Cos(Math.PI / 180 * angle) * length);
            Tuple<int, int> pointEnd = new Tuple<int, int>(xEnd, yEnd);
            return pointEnd;
        }
        
        private void Graph_Resize(object sender, EventArgs e)
        {
            SetSize();
        }
        private int Normalize(int angle) // Преобразование углов к нормальнуму виду (от 0 до 360 градусов)
        {
            while (angle < 0)
            {
                angle += 360;
            }
            while (angle >= 360)
            {
                angle -= 360;
            }
            return angle;
        }
        private void Graph_Load(object sender, EventArgs e)
        {
            CreateGraph(zedGraphControl1);
            SetSize();
        }
    }
}