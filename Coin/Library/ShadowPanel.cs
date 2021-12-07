using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Coin.Library
{
    public static class ShadowPanel
    {
        /// <summary>
        /// 컨테이너(패널) 안의 모든 패널 컨트롤에 일괄적으로 그림자를 생성합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void Draw(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            Color[] shadow = new Color[4];

            shadow[0] = Color.FromArgb(181, 181, 181);
            shadow[1] = Color.FromArgb(200, 200, 200);
            shadow[2] = Color.FromArgb(215, 215, 215);
            shadow[3] = Color.FromArgb(150, 150, 150);

            Pen pen = new Pen(shadow[0]);

            using (pen)
            {
                foreach (Panel p in panel.Controls.OfType<Panel>())
                {
                    int index;

                    Point pt = p.Location;
                    pt.Y += p.Height;

                    for (int i = 1; i <= shadow.Length; i++)
                    {
                        index = i - 1;
                        pen.Color = shadow[index];

                        // 패널 테두리
                        if (index == 3)
                        {
                            // 위쪽 선
                            e.Graphics.DrawLine(pen, p.Left - 1, p.Top - 1, p.Right, p.Top - 1);
                            // 아래쪽 선
                            e.Graphics.DrawLine(pen, p.Left, p.Bottom, p.Right, p.Bottom);
                            // 왼쪽 선
                            e.Graphics.DrawLine(pen, p.Left - 1, p.Top, p.Left - 1, p.Bottom);
                            // 오른쪽 선
                            e.Graphics.DrawLine(pen, p.Right, p.Top, p.Right, p.Bottom);
                        }
                        // 그림자
                        else
                        {
                            e.Graphics.DrawLine(pen, pt.X, pt.Y + 1, pt.X + p.Width + 2, pt.Y + 1);
                            e.Graphics.DrawLine(pen, p.Right + i, p.Top + i, p.Right + i, p.Bottom + i);
                        }

                        pt.Y++;
                    }

                }
            }
        }
    }
}
