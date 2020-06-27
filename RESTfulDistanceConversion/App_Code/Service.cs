/*  Author: Phillip Pham
 *  Course: CSE445, Instructor: Dr. Yinong Chen
 *  Date: 06/21/20
 *  
 *  Description: This service creates a RESTful API to convert distances (miles, kilometers).
 */

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public double convertKmToMiles(double x)
    {
        return (x / 1.609344);
    }

    public double convertMilesToKm(double x)
    {
        return (x * 1.609344);
    }
}