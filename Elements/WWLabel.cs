using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


class WWLabel : Label
{
    private Painter.Fonts.FontsName customFont = Painter.Fonts.FontsName.Roboto;
    [DisplayName("Custom Font")]
    [DefaultValue(Painter.Fonts.FontsName.Roboto)]
    [Description("Кастомный шрифт текста")]
    public Painter.Fonts.FontsName CustomFont
    {
        get => customFont;
        set
        {
            customFont = value;
            Refresh();
        }
    }

    private bool autoFont = false;
    [DisplayName("Auto Font")]
    [DefaultValue(false)]
    [Description("Делает размер шрифта под высоту элемента")]
    public bool AutoFont
    {
        get => autoFont;
        set
        {
            autoFont = value;
            Refresh();
        }
    }

    public WWLabel()
    {
        ForeColor = Color.FromArgb(178, 183, 195);

        if (!AutoSize)
            if (!autoFont)
                Font = new Font("Arial", Font.Size, FontStyle.Regular, GraphicsUnit.Pixel);
            else
                Font = new Font("Arial", Height, FontStyle.Regular, GraphicsUnit.Pixel);

        Font = Painter.Fonts.GetFont(customFont, Font);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        //if (!AutoSize)
        //    if (!autoFont)
        //        Font = new Font("Arial", Font.Size, FontStyle.Regular, GraphicsUnit.Pixel);
        //    else

        //        Font = new Font("Arial", Height, FontStyle.Regular, GraphicsUnit.Pixel);

        Font = Painter.Fonts.GetFont(customFont, Font);

    }
}

