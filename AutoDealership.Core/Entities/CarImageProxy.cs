using System.Drawing;

public class CarImageProxy : ICarImage
{
    private string _imagePath;
    private RealCarImage _realImage;

    public CarImageProxy(string imagePath)
    {
        _imagePath = imagePath;
    }

    public Image GetImage()
    {
        if (_realImage == null)
        {
            _realImage = new RealCarImage(_imagePath);
        }

        return _realImage.GetImage();
    }
}
