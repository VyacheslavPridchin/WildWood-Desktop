using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

public class Painter
{
    public class Fonts
    {

        private static PrivateFontCollection fontCollection = new PrivateFontCollection();
        public static PrivateFontCollection FontsCollection
        {
            get => fontCollection;
            set
            {
                fontCollection = value;
            }
        }

        public enum FontsName
        {
            Roboto,
            Roboto_Light,
            Roboto_Black,
            Roboto_Medium,
            Roboto_Thin,
            none
        }

        public static Font GetFont(FontsName name, Font prefabFont)
        {
            try
            {
                switch (name)
                {
                    case FontsName.Roboto:
                        return new Font(FontsCollection.Families[0], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.Roboto_Black:
                        return new Font(FontsCollection.Families[1], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);


                    case FontsName.Roboto_Light:
                        return new Font(FontsCollection.Families[2], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);


                    case FontsName.Roboto_Medium:
                        return new Font(FontsCollection.Families[3], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);


                    case FontsName.Roboto_Thin:
                        return new Font(FontsCollection.Families[4], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.none:
                        return prefabFont;

                    default:
                        return new Font(FontsCollection.Families[0], prefabFont.Size, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);
                }
            }
            catch (Exception e)
            {
                return prefabFont;
            }
        }

        public static Font GetFont(FontsName name, Font prefabFont, float customSize)
        {
            try
            {
                switch (name)
                {
                    case FontsName.Roboto:
                        return new Font(FontsCollection.Families[0], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.Roboto_Black:
                        return new Font(FontsCollection.Families[1], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.Roboto_Light:
                        return new Font(FontsCollection.Families[2], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.Roboto_Medium:
                        return new Font(FontsCollection.Families[3], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.Roboto_Thin:
                        return new Font(FontsCollection.Families[4], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);

                    case FontsName.none:
                        return prefabFont;

                    default:
                        return new Font(FontsCollection.Families[0], customSize, prefabFont.Style, prefabFont.Unit, prefabFont.GdiCharSet, prefabFont.GdiVerticalFont);
                }
            }
            catch (Exception e)
            {
                return prefabFont;
            }
        }

        public static void LoadFonts()
        {
            try
            {
                FontsCollection.AddFontFile("Fonts/Roboto-Black.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-BlackItalic.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Bold.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-BoldItalic.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Italic.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Light.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-LightItalic.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Medium.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-MediumItalic.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Regular.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-Thin.ttf");
                FontsCollection.AddFontFile("Fonts/Roboto-ThinItalic.ttf");

                //Roboto - 0
                //Roboto Black - 1
                //Roboto Light - 2
                //Roboto Medium - 3
                //Roboto Thin - 4
                //MessageBox.Show(FontsCollection.Families[0].Name);

                Roboto = new Font(FontsCollection.Families[0], 18, FontStyle.Regular, GraphicsUnit.Pixel);
                Roboto_Light = new Font(FontsCollection.Families[2], 18, FontStyle.Regular, GraphicsUnit.Pixel);
                Roboto_Black = new Font(FontsCollection.Families[1], 18, FontStyle.Regular, GraphicsUnit.Pixel);
                Roboto_Medium = new Font(FontsCollection.Families[3], 18, FontStyle.Regular, GraphicsUnit.Pixel);
                Roboto_Thin = new Font(FontsCollection.Families[4], 18, FontStyle.Regular, GraphicsUnit.Pixel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static Font Roboto = new Font("Arial", 15);
        public static Font Roboto_Light = new Font("Arial", 15);
        public static Font Roboto_Black = new Font("Arial", 15);
        public static Font Roboto_Medium = new Font("Arial", 15);
        public static Font Roboto_Thin = new Font("Arial", 15);

    }

    public static Image GetImage(string url)
    {
        using (WebResponse wrFileResponse = WebRequest.Create(url).GetResponse())
        using (Stream objWebStream = wrFileResponse.GetResponseStream())
        {
            MemoryStream ms = new MemoryStream();
            objWebStream.CopyTo(ms, 8192);
            return Image.FromStream(ms);
        }

    }

    public static GraphicsPath RoundedRectangle(Rectangle rect, float RoundSize)
    {
        GraphicsPath gp = new GraphicsPath();
        gp.AddArc(rect.X, rect.Y, RoundSize, RoundSize, 180, 90);
        gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y, RoundSize, RoundSize, 270, 90);
        gp.AddArc(rect.X + rect.Width - RoundSize, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 0, 90);
        gp.AddArc(rect.X, rect.Y + rect.Height - RoundSize, RoundSize, RoundSize, 90, 90);

        gp.CloseFigure();

        return gp;
    }

}