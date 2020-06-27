/*  Author: Phillip Pham
 *  Course: CSE445, Instructor: Dr. Yinong Chen
 *  Date: 06/21/20
 *  
 *  Description: This TryIt page utilizes the RESTful API that I developed to convert distances (miles, kilometers).
 */

using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

public partial class TryIt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Converts the input kilometers into miles.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnConMiles_Click(object sender, EventArgs e)
    {
        // Build the URI that can access the API
        Uri baseUri = new Uri("http://webstrar58.fulton.asu.edu/page3/Service.svc/");
        UriTemplate myTemplate = new UriTemplate("KmToMiles?x={1}");
        Uri completeUri = myTemplate.BindByPosition(baseUri, txtKilo.Text);

        // Create the channel
        WebClient channel = new WebClient();

        // Downloads the data to a byte array
        byte[] abc = channel.DownloadData(completeUri);

        // Converts to a memory stream
        Stream strm = new MemoryStream(abc);

        // Serializes the content into a double, then converts to string
        DataContractSerializer obj = new DataContractSerializer(typeof(double));
        string result = obj.ReadObject(strm).ToString();

        // Set the label
        lblMiles.Text = result + " Miles";
    }

    /// <summary>
    /// Converts the input miles into kilometers.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnConKilo_Click(object sender, EventArgs e)
    {
        // Build the URI that can access the API
        Uri baseUri = new Uri("http://webstrar58.fulton.asu.edu/page3/Service.svc/");
        UriTemplate myTemplate = new UriTemplate("MilesToKm?x={1}");
        Uri completeUri = myTemplate.BindByPosition(baseUri, txtMiles.Text);

        // Create the channel
        WebClient channel = new WebClient();

        // Downloads the data to a byte array
        byte[] abc = channel.DownloadData(completeUri);

        // Converts to a memory stream
        Stream strm = new MemoryStream(abc);

        // Serializes the content into a double, then converts to string
        DataContractSerializer obj = new DataContractSerializer(typeof(double));
        string result = obj.ReadObject(strm).ToString();

        // Set the label
        lblKilo.Text = result + " Kilometers";
    }
}