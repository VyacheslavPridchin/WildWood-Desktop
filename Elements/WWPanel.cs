using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class WWPanel : Panel
{
    #region ---Свойства---
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

    private int rounding = 20;
    [DisplayName("Rounding")]
    [DefaultValue(20)]
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
    public bool ParentShadow = false;
    #endregion

    public WWPanel()
    {
        SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
        DoubleBuffered = true;
        Size = new Size(212, 332);
        BackColor = Color.FromArgb(58, 58, 58);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        Graphics graph = e.Graphics;
        Graphics parentGraph = Parent.CreateGraphics();
        graph.Clear(Parent.BackColor);
        graph.SmoothingMode = SmoothingMode.HighQuality;
        Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

        //Вычисление закругления
        float roundingValue = 0.1f;
        if (RoundingEnable && rounding > 0)
        {
            if (Height < Width)
                roundingValue = Height;
            else roundingValue = Width;
            if (roundingValue > rounding)
                roundingValue = rounding;
        }

        if (shadowEnable)
        {
            //Очищаем место под тень
            Rectangle rectFP = new Rectangle(Left, Top, Width - 1 + ShadowOX, Height - 1 + ShadowOY);
            parentGraph.FillRectangle(new SolidBrush(Parent.BackColor), rectFP);

            //Тень
            for (int i = 0; i < countIter; i++)
            {

                Rectangle rectForParent = new Rectangle(Left + i * (int)((float)shadowOX / (float)countIter), Top + i * (int)((float)shadowOY / (float)countIter), Width - 1, Height - 1);
                GraphicsPath rectPathForParent = Painter.RoundedRectangle(rectForParent, roundingValue);
                parentGraph.FillPath(new SolidBrush(Color.FromArgb((int)((float)intensity / (float)countIter), shadowColor)), rectPathForParent);

                //Рисование тени на кнопке
                Rectangle rectOffset = new Rectangle(i * (int)((float)shadowOX / (float)countIter), i * (int)((float)shadowOY / (float)countIter), Width - 1, Height - 1);
                GraphicsPath rectPathOffset = Painter.RoundedRectangle(rectOffset, roundingValue);
                graph.FillPath(new SolidBrush(Color.FromArgb((int)((float)intensity / (float)countIter), shadowColor)), rectPathOffset);
            }
        }
        //рисование самой панели
        GraphicsPath rectPath = Painter.RoundedRectangle(rect, roundingValue);
        //graph.DrawPath(new Pen(Color.FromArgb(150,BackColor)), rectPath);
        graph.FillPath(new SolidBrush(BackColor), rectPath);

    }
}
