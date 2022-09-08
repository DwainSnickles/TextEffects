using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TextDesignerCSLibrary;

//Original code used from https://www.codeproject.com/articles/42529/outline-text
// Modified to make it easy for me to understand 9/7/2022

namespace TextEffects
{
    public partial class Form1 : Form
    {
        //private Bitmap bmpSrc;

        public Form1()
        {
            InitializeComponent();
        }

        public int ShadowThickness { get; set; } = 10;

        public GradientType gradientType { get; set; } = GradientType.Linear;

        public bool Reflection { get; set; } = false;
        public bool ShowShadow { get; set; } = true;

        //public String TheText { get; set; } = "Cant be null";

    public Rectangle rect { get; set; }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            SolidBrush brushBkgnd = new SolidBrush(Color.Transparent);
            e.Graphics.FillRectangle(brushBkgnd, 0, 0, this.ClientSize.Width, this.ClientSize.Width);

            PngOutlineText m_PngOutlineText = new PngOutlineText();
            m_PngOutlineText.SetPngImage(new Bitmap(ClientSize.Width, ClientSize.Height));
            m_PngOutlineText.TextGradOutline(pnlTextColor.BackColor, pnlTextOutLineColor1.BackColor, pnlTextOutLineColor2.BackColor, ShadowThickness, gradientType);
            m_PngOutlineText.EnableReflection(Reflection);

            m_PngOutlineText.EnableShadow(ShowShadow);
            //Rem to SetNullShadow() to release memory if a previous shadow has been set.
            m_PngOutlineText.SetNullShadow();
            m_PngOutlineText.Shadow(pnlShadowColor.BackColor, (int)nudShadowThickness.Value, new Point(4, 4));
                
            LOGFONT m_LogFont = new LOGFONT();
            m_LogFont.lfFaceName = "Arial Black";
            m_LogFont.lfHeight = -48;

            m_LogFont.lfOrientation = 0;
            m_LogFont.lfEscapement = 0;
            m_LogFont.lfItalic = false;
            float fStartX = 0.0f;
            float fStartY = 0.0f;
            float fDestWidth = 0.0f;
            float fDestHeight = 0.0f;
            m_PngOutlineText.GdiMeasureString( e.Graphics, m_LogFont, txtDisplayText.Text, new Point(10, 10),
                                               ref fStartX, ref fStartY,ref fDestWidth,ref fDestHeight);

            m_PngOutlineText.SetShadowBkgd(Color.White, (int)fDestWidth + 10, (int)fDestHeight + 10);

            LinearGradientBrush gradientBrush = new LinearGradientBrush(new RectangleF(fStartX, fStartY, fDestWidth - fStartX, fDestHeight - fStartY),
                   pnlTextGradient1.BackColor, pnlTextGradient2.BackColor, LinearGradientMode.Vertical);

            m_PngOutlineText.TextGradOutline(gradientBrush, pnlTextOutLineColor1.BackColor, pnlTextOutLineColor2.BackColor, ShadowThickness, gradientType);

            m_PngOutlineText.GdiDrawString( e.Graphics, m_LogFont, txtDisplayText.Text, new Point(10, 10));

            //e.Graphics.DrawImage(m_PngOutlineText.GetPngImage(), new Point(0, 0));
            this.BackColor = Color.White;

            Image bmp = new Bitmap((int)fDestWidth, (int)fDestHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                //picText.BackColor = pnlBackgroundColor.BackColor;
                // draw in bmp using g
                g.DrawImage(m_PngOutlineText.GetPngImage(), new Point(-8, -15));
            }
            //bmp.Save(filename);
            picText.Image = bmp;
            brushBkgnd.Dispose();
            e.Graphics.Dispose();
            
        }

        private void picturebox1_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

            ////Drawing the back ground color changed to use property
            ////Color m_clrBkgd = Color.FromArgb(255, 255, 255);
            //SolidBrush brushBkgnd = new SolidBrush(GradientShadowColor);
            //e.Graphics.FillRectangle(brushBkgnd, 0, 0, this.ClientSize.Width, this.ClientSize.Width);

            //PngOutlineText m_PngOutlineText = new PngOutlineText();
            //m_PngOutlineText.SetPngImage(new Bitmap(ClientSize.Width, ClientSize.Height));
            //m_PngOutlineText.TextGradOutline(TextColor, OutLineColor1, OutLineColor2, ShadowThickness, gradientType);
            ////Replaced by code above
            ////m_PngOutlineText.TextGradOutline(
            ////    Color.FromArgb(255, 128, 64),
            ////    Color.FromArgb(255, 64, 0, 64),
            ////    Color.FromArgb(255, 255, 128, 255),
            ////    10, GradientType.Linear);
            //m_PngOutlineText.EnableReflection(false);

            //m_PngOutlineText.EnableShadow(true);
            ////Rem to SetNullShadow() to release memory if a previous shadow has been set.
            //m_PngOutlineText.SetNullShadow();
            //m_PngOutlineText.Shadow(
            //    Color.FromArgb(128, 0, 0, 0), 8,
            //    new Point(4, 4));
            //LOGFONT m_LogFont = new LOGFONT();
            //m_LogFont.lfFaceName = "Arial Black";
            //m_LogFont.lfHeight = -48;

            //m_LogFont.lfOrientation = 0;
            //m_LogFont.lfEscapement = 0;
            //m_LogFont.lfItalic = false;
            //float fStartX = 0.0f;
            //float fStartY = 0.0f;
            //float fDestWidth = 0.0f;
            //float fDestHeight = 0.0f;
            //m_PngOutlineText.GdiMeasureString(
            //    e.Graphics,
            //    m_LogFont,
            //    TheText,
            //    new Point(10, 10),
            //    ref fStartX,
            //    ref fStartY,
            //    ref fDestWidth,
            //    ref fDestHeight);
            //m_PngOutlineText.SetShadowBkgd(GradientShadowColor, (int)fDestWidth + 10, (int)fDestHeight + 10);
            //LinearGradientBrush gradientBrush = new LinearGradientBrush(new RectangleF(fStartX, fStartY, fDestWidth - fStartX, fDestHeight - fStartY),
            //        Color.FromArgb(255, 128, 64), Color.FromArgb(255, 0, 0), LinearGradientMode.Vertical);
            ////m_PngOutlineText.TextGradOutline(
            ////    gradientBrush,
            ////    Color.FromArgb(255, 64, 0, 64),
            ////    Color.FromArgb(255, 255, 128, 255),
            ////    10, GradientType.Linear);

            //m_PngOutlineText.TextGradOutline(gradientBrush, OutLineColor1, OutLineColor2, ShadowThickness, gradientType);

            //m_PngOutlineText.GdiDrawString(
            //    e.Graphics,
            //    m_LogFont,
            //    TheText,
            //    new Point(10, 10));

            //e.Graphics.DrawImage(m_PngOutlineText.GetPngImage(), new Point(0, 0));

            ////Image bmp = new Bitmap((int)fDestWidth, (int)fDestHeight);
            ////using (Graphics g = Graphics.FromImage(bmp))
            ////{
            ////    // draw in bmp using g
            ////    e.Graphics.DrawImage(m_PngOutlineText.GetPngImage(), new Point(0, 0));
            ////}
            ////bmp.Save(filename);
            ////pictureBox1.Image = bmp;
            //brushBkgnd.Dispose();
            //e.Graphics.Dispose();
        }

        private void nudShadowThickness_ValueChanged(object sender, EventArgs e)
        {
            ShadowThickness = (int)nudShadowThickness.Value;
            this.Invalidate();
        }

        private void cmbReflection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reflection = false;

            if (cmbReflection.SelectedIndex == 1)
            {
                Reflection = true;
            }

            this.Invalidate();
        }

        //private void cmbShowShadow_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ShowShadow = true;

        //    if (cmbShowShadow.SelectedIndex == 1)
        //    {
        //        ShowShadow = false;
        //    }

        //    this.Invalidate();
        //}

        private void btnDrawText_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void btnTextOutLineColor1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextOutLineColor1.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextOutLineColor2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextOutLineColor2.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextGradient2_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextGradient2.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnTextGradient1_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlTextGradient1.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void btnShawdowColor_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            pnlShadowColor.BackColor = colorDialog1.Color;
            this.Invalidate();
        }

        private void rbShowShadow_CheckedChanged(object sender, EventArgs e)
        {
            ShowShadow = true;
            this.Invalidate();
        }

        private void rbHideShadow_CheckedChanged(object sender, EventArgs e)
        {
            ShowShadow = false;
            this.Invalidate();
        }
    }
}
