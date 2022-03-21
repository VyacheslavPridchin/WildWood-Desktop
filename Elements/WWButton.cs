using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;

class WWButton : Button
{
    #region ---Свойства---
    private bool onlyText = false;
    [DefaultValue(false)]
    [Description("Вкл / выкл формы кнопки")]
    public bool OnlyText
    {
        get => onlyText;
        set
        {
            onlyText = value;
            Refresh();
        }
    }

    private bool roundingEnable = true;
    [DefaultValue(true)]
    [Description("Вкл / выкл закругление")]
    [Category("Закругление")]
    public bool RoundingEnable
    {
        get => roundingEnable;
        set
        {
            roundingEnable = value;
            Refresh();
        }
    }

    private int rounding = 100;
    [DisplayName("Rounding")]
    [DefaultValue(100)]
    [Description("Радиус закругления")]
    [Category("Закругление")]
    public int Rounding
    {
        get => rounding;
        set
        {
            if (value >= 0)
            {
                rounding = value;
            }
            else rounding = 0;
            Refresh();
        }
    }

    private bool shadowEnable = true;
    [DefaultValue(true)]
    [Description("Вкл / выкл тени")]
    [Category("Тень")]
    public bool ShadowEnable
    {
        get => shadowEnable;
        set
        {
            shadowEnable = value;
            Refresh();
        }
    }

    private int intensity = 64;
    [DisplayName("Intensity")]
    [DefaultValue(64)]
    [Description("Интенсивность тени")]
    [Category("Тень")]
    public int Intensity
    {
        get => intensity;
        set
        {
            if (value <= 0)
                intensity = 1;
            else if (value > 255) intensity = 255;
            else intensity = value;
            Refresh();
        }
    }

    private int countIter = 8;
    [DisplayName("Count of Iteration")]
    [DefaultValue(8)]
    [Description("Количество итераций прорисовки")]
    [Category("Тень")]
    public int CountIter
    {
        get => countIter;
        set
        {
            if (value <= 0)
                countIter = 1;
            else if (value > 50) intensity = 50;
            else countIter = value;
            Refresh();
        }
    }

    private int shadowOX = 0;
    [DisplayName("Shadow OX")]
    [DefaultValue(0)]
    [Description("Сдвиг тени вдоль оси X")]
    [Category("Тень")]
    public int ShadowOX
    {
        get => shadowOX;
        set
        {
            shadowOX = value;
            Refresh();
        }
    }

    private Color shadowColor = Color.Black;
    [DisplayName("Shadow Color")]
    [Description("Цвет тени")]
    [Category("Тень")]
    public Color ShadowColor
    {
        get => shadowColor;
        set
        {
            shadowColor = value;
            Refresh();
        }
    }

    private int shadowOY = 8;
    [DisplayName("Shadow OY")]
    [DefaultValue(8)]
    [Description("Сдвиг тени вдоль оси Y")]
    [Category("Тень")]
    public int ShadowOY
    {
        get => shadowOY;
        set
        {
            shadowOY = value;
            Refresh();
        }
    }
    #endregion

    #region ---Переменные---
    private StringFormat SF = new StringFormat();
    private bool MouseEntered = false, MousePressed = false;
    #endregion

    PictureBox pictureBox = new PictureBox();

    public WWButton()
    {

        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(158, 43);
        BackColor = Color.FromArgb(58, 58, 58);
        ForeColor = Color.FromArgb(178, 183, 195);
        SF.Alignment = StringAlignment.Center;
        SF.LineAlignment = StringAlignment.Center;
        //pictureBox.BackColor = BackColor;
        pictureBox.Visible = false;
        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox.MouseEnter += PictureBox_MouseEnter;
        pictureBox.MouseLeave += PictureBox_MouseLeave;
        pictureBox.MouseDown += PictureBox_MouseDown;
        pictureBox.MouseUp += PictureBox_MouseUp;
        pictureBox.MouseClick += PictureBox_MouseClick;
        Controls.Add(pictureBox);
        Font = new Font("Arial", 18f, FontStyle.Regular, GraphicsUnit.Pixel);
    }

    #region Действия на картинке
    private void PictureBox_MouseClick(object sender, MouseEventArgs e)
    {
        OnClick(EventArgs.Empty);
    }

    private void PictureBox_MouseUp(object sender, MouseEventArgs e)
    {
        MousePressed = false;

        Invalidate();
    }

    private void PictureBox_MouseDown(object sender, MouseEventArgs e)
    {
        MousePressed = true;

        Invalidate();
    }

    private void PictureBox_MouseLeave(object sender, EventArgs e)
    {
        MouseEntered = false;

        Invalidate();
    }

    private void PictureBox_MouseEnter(object sender, EventArgs e)
    {
        MouseEntered = true;

        Invalidate();
    }
    #endregion

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        //Color.FromArgb(36, 35, 37);

        Graphics graph = e.Graphics;
        Graphics parentGraph = Parent.CreateGraphics();
        graph.SmoothingMode = SmoothingMode.AntiAlias;
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
        graph.Clear(Parent.BackColor);
        if (!onlyText)
        {
            float roundingValue = 0.1f;
            if (RoundingEnable && rounding > 0)
            {
                if (Height < Width)
                    roundingValue = Height;
                else roundingValue = Width;
                if (roundingValue > rounding)
                    roundingValue = rounding;
            }

            //Очищаем место под тень
            Rectangle rectFP = new Rectangle(Left, Top, Width - 1 + ShadowOX, Height - 1 + ShadowOY);
            parentGraph.FillRectangle(new SolidBrush(Parent.BackColor), rectFP);

            //Тень
            if (ShadowEnable)
                for (int i = 0; i < countIter; i++)
                {
                    //Рисование на родителе
                    Rectangle rectForParent = new Rectangle(Left + i * (int)((float)shadowOX / (float)countIter), Top + i * (int)((float)shadowOY / (float)countIter), Width - 1, Height - 1);
                    GraphicsPath rectPathForParent = Painter.RoundedRectangle(rectForParent, roundingValue);
                    parentGraph.FillPath(new SolidBrush(Color.FromArgb((int)((float)intensity / (float)countIter), shadowColor)), rectPathForParent);

                    //Рисование тени на кнопке
                    Rectangle rectOffset = new Rectangle(i * (int)((float)shadowOX / (float)countIter), i * (int)((float)shadowOY / (float)countIter), Width - 1, Height - 1);
                    GraphicsPath rectPathOffset = Painter.RoundedRectangle(rectOffset, roundingValue);
                    graph.FillPath(new SolidBrush(Color.FromArgb((int)((float)intensity / (float)countIter), shadowColor)), rectPathOffset);
                }

            //рисование самой кнопки
            GraphicsPath rectPath = Painter.RoundedRectangle(rect, roundingValue);
            //graph.DrawPath(new Pen(Color.FromArgb(150,BackColor)), rectPath);
            graph.FillPath(new SolidBrush(BackColor), rectPath);

            if (MouseEntered)
            {
                //graph.DrawPath(new Pen(Color.FromArgb(60, Color.White)), rectPath);
                graph.FillPath(new SolidBrush(Color.FromArgb(25, Color.WhiteSmoke)), rectPath);
                pictureBox.BackColor = Color.Transparent;

            }


            if (MousePressed)
            {
                //graph.DrawPath(new Pen(Color.FromArgb(150, Color.White)), rectPath);
                graph.FillPath(new SolidBrush(Color.FromArgb(50, Color.WhiteSmoke)), rectPath);

            }
        }

        if (Image == null)
        {
            pictureBox.Visible = false;

            Font = Painter.Fonts.GetFont(Painter.Fonts.FontsName.Roboto_Medium, Font);

            graph.DrawString(Text, Font, new SolidBrush(ForeColor), new Rectangle(0, 4, Width - 1, Height - 5), SF);
        }
        else
        {
            pictureBox.Left = 0;
            pictureBox.Top = 0;
            pictureBox.Height = Height;
            pictureBox.Width = Width;
            if (!OnlyOnce)
            {
                var myThread = new Thread(() => ChangeTransparent());
                myThread.Start();
            }
        }
    }

    bool OnlyOnce = false;
    private void ChangeTransparent() //Замедление настройки из-за бага с Transparent в WinForms
    {
        try
        {
            Thread.Sleep(50);
            Invoke(new Action(() => pictureBox.Image = Image));
            Invoke(new Action(() => pictureBox.Visible = true));
            Invoke(new Action(() => pictureBox.BackColor = Color.Transparent));
            OnlyOnce = true;
        }
        catch (Exception e) { }
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);

        MouseEntered = true;

        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);

        MouseEntered = false;

        Invalidate();

    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);

        MousePressed = true;

        Invalidate();
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);

        MousePressed = false;

        Invalidate();
    }

    protected override void OnClick(EventArgs e)
    {
        base.OnClick(e);
        Focus();
    }
}