using System.Windows.Forms;

/// <summary>
/// Stub class to replace missing cGeoIp.dll functionality.
/// Provides basic GeoIP placeholder until proper implementation is added.
/// </summary>
public class cGeoMain
{
    public ImageList cImageList { get; set; }

    public cGeoMain()
    {
        cImageList = new ImageList();
    }

    /// <summary>
    /// Gets IP information - returns placeholder data since original library is unavailable.
    /// </summary>
    /// <param name="ip">IP address to lookup</param>
    /// <returns>Country code and country name separated by colon</returns>
    public string GetIpInf(string ip)
    {
        // Return placeholder data - format: "CountryCode:CountryName"
        return "XX:Unknown";
    }
}
