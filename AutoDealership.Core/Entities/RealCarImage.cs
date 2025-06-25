using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

public class RealCarImage : ICarImage
{
    private string _imagePath;

    public RealCarImage(string imagePath)
    {
        _imagePath = imagePath;
    }

    public System.Drawing.Image GetImage()
    {
        return System.Drawing.Image.FromFile(_imagePath);
    }

}
