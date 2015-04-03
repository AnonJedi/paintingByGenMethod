
using System;
using System.Drawing;
using System.Windows.Forms;

namespace paintingByGenMethod
{
    class Triangle
    {
        public int[] A = new int[2];
        public int[] B = new int[2];
        public int[] C = new int[2];
        public int[] X = new int[2];
        public Color color;

        public Triangle(PictureBox p, Bitmap b)
        {
            Random random = new Random();

            X[0] = random.Next(p.Size.Width);
            X[1] = random.Next(p.Size.Height);

            if (random.Next(10) % 2 == 0)
            {
                A[0] = Math.Abs(random.Next(50) - X[0]);
                A[1] = Math.Abs(random.Next(50) - X[1]);

                B[0] = Math.Abs(random.Next(50) + X[0]);
                B[1] = Math.Abs(random.Next(50) + X[1]);

                C[0] = Math.Abs(random.Next(50) - X[0]);
                C[1] = Math.Abs(random.Next(50) + X[1]);
            }
            else
            {
                A[0] = Math.Abs(random.Next(50) - X[0]);
                A[1] = Math.Abs(random.Next(50) + X[1]);

                B[0] = Math.Abs(random.Next(50) + X[0]);
                B[1] = Math.Abs(random.Next(50) - X[1]);

                C[0] = Math.Abs(random.Next(50) + X[0]);
                C[1] = Math.Abs(random.Next(50) - X[1]);
            }

            color = b.GetPixel(X[0], X[1]);
        }

        public PointF[] InitPoligon()
        {
            PointF[] points = new PointF[3];

            points[0] = new PointF(A[0], A[1]);
            points[1] = new PointF(B[0], B[1]);
            points[2] = new PointF(C[0], C[1]);

            return points;
        }
    }
}
