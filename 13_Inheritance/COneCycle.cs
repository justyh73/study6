using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Inheritance
{
    class COneCycle : CBase
    {
        public Rectangle _rtCircle1;
        public Rectangle _rtSquare1;


        public COneCycle(string sName)
        {
            strName = sName;
            _Pen = new Pen(Color.WhiteSmoke, 3);

            _rtCircle1 = new Rectangle(120, 150, 120, 120);
            _rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return _Pen;
        }

        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fSquare1Move(iMove);
        }

        private void fSquare1Move(int iMove)
        {
            Point oPoint = _rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtSquare1.Location = oPoint;
        }

        private void fCircle1Move(int iMove)
        {
            Point oPoint = _rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            _rtCircle1.Location = oPoint;
        }
    }
}
