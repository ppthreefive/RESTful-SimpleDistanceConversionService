/*  Author: Phillip Pham
 *  Course: CSE445, Instructor: Dr. Yinong Chen
 *  Date: 06/21/20
 *  
 *  Description: This service creates a RESTful API to convert distances (miles, kilometers).
 */

using System.ServiceModel;
using System.ServiceModel.Web;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    [OperationContract]
    [WebGet(UriTemplate = "KmToMiles?x={x}")]
    double convertKmToMiles(double x);

    [OperationContract]
    [WebGet(UriTemplate = "MilesToKm?x={x}")]
    double convertMilesToKm(double x);
}