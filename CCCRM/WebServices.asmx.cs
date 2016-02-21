using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CCCRM
{
    /// <summary>
    /// Summary description for WebServices
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServices : System.Web.Services.WebService
    {
        [WebMethod]
        public string ReceiveSMS(string mobile, string response)
        {
            if (!mobile.StartsWith("+"))
            {
                mobile = "+" + mobile;
            }

            var ws = new net.azurewebsites.codistri.WebServices();
            var wsParams = new object[]{
                false,
                null,
                mobile,
                null,
                response
            };

            var returnMessage = ws.RunActionByName("WebServiceUser",
                "CCCRM!@#",
                net.azurewebsites.codistri.ExportStyle.CsvWithoutHeader,
                @"DrChatSite/Application.axl",
                "SMSMessagesReceived.dxl",
                "Receive SMS",
                wsParams);

            if (string.IsNullOrEmpty(returnMessage))
                returnMessage = "Your message from " + mobile + " has been received: " + response;
            else
                returnMessage = "Error found: " + returnMessage;

            return returnMessage;
        }

        [WebMethod]
        public string RegisterPatient(
            string FIdentityNo, string MIdentityNo,
            string FSurname, string MSurname,
            string FFirstNames, string MFirstNames,
            string FBirthDate, string MBirthDate,
            string FBloodGroup, string MBloodGroup,
            string FHomeAddressLine1, string MHomeAddressLine1,
            string FHomeAddressLine2, string MHomeAddressLine2,
            string FHomeAddressLine3, string MHomeAddressLine3,
            string FHomeCountryCode, string MHomeCountryCode,
            string FHomePostCode, string MHomePostCode,
            string FTelephone, string MTelephone,
            string FMobile, string MMobile,
            string FEmail, string MEmail,
            string FRace, string MRace,
            string FNationality, string MNationality,
            string FOccupation, string MOccupation,
            string FWorkAddressLine1, string MWorkAddressLine1,
            string FWorkAddressLine2, string MWorkAddressLine2,
            string FWorkAddressLine3, string MWorkAddressLine3,
            string FWorkCountryCode, string MWorkCountryCode,
            string FWorkPostCode, string MWorkPostCode
            )
        {
            var FPatientID = "";
            var MPatientID = "";
            var FSpousePatientID = MPatientID;
            var MSpousePatientID = FPatientID;

            var ws = new net.azurewebsites.codistri.WebServices();
            var wsParams = new object[]{
                FSurname,
                FFirstNames,
                MSurname,
                MFirstNames,
                FIdentityNo,
                MIdentityNo,
                FBirthDate,
                MBirthDate,
                FBloodGroup,
                MBloodGroup,
                FHomeAddressLine1,
                MHomeAddressLine1,
                FHomeAddressLine2,
                MHomeAddressLine2,
                FHomeAddressLine3,
                MHomeAddressLine3,
                FHomeCountryCode,
                FHomePostCode,
                MHomeCountryCode,
                MHomePostCode,
                FTelephone,
                MTelephone,
                FMobile,
                MMobile,
                FEmail,
                MEmail,
                FRace,
                MRace,
                FNationality,
                MNationality,
                FOccupation,
                MOccupation,
                FWorkAddressLine1,
                MWorkAddressLine1,
                FWorkAddressLine2,
                MWorkAddressLine2,
                FWorkAddressLine3,
                MWorkAddressLine3,
                FWorkCountryCode,
                MWorkCountryCode,
                FWorkPostCode,
                MWorkPostCode,
                FPatientID,
                MPatientID,
                FSpousePatientID,
                MSpousePatientID
            };

            var returnMessage = ws.RunActionByName("WebServiceUser",
                "CCCRM!@#",
                net.azurewebsites.codistri.ExportStyle.CsvWithoutHeader,
                @"DrChatSite/Application.axl",
                "PatientRegistration.dxl",
                "Submit",
                wsParams
                );

            if (!returnMessage.StartsWith("Error"))
                returnMessage = "Patient(s) registered ok";

            return returnMessage;
        }

        [WebMethod]
        public string GetFreeTimeSlots(DateTime appointmentStartDate,DateTime appointmentEndDate, int doctorNo,string clinicCode)
        {
            var ws = new net.azurewebsites.codistri.WebServices();
            var wsParams = new object[]{
                doctorNo,
                clinicCode,
                appointmentStartDate,
                appointmentEndDate
            };

            return ws.GetComboListByName("WebServiceUser",
                "CCCRM!@#",
                net.azurewebsites.codistri.ExportStyle.Json,
                @"DrChatSite/Application.axl",
                "ApptDetail.dxl",
                "AppointmentTime",
                wsParams);
        }

        [WebMethod]
        public string BookAppointment(
            string Officer,
            string Doctor,
            DateTime AppointmentStartDate,
            DateTime AppointmentEndDate,
            string AppointmentTime,
            string NRIC,
            string Surname,
            string Firstname)
        {
            var AppointmentNo = "";
            var ws = new net.azurewebsites.codistri.WebServices();
            var wsParams = new object[] { 
                AppointmentNo,
                Officer,
                Doctor,
                AppointmentStartDate,
                AppointmentEndDate,
                AppointmentTime,
                NRIC,
                Surname,
                Firstname};

            var returnMessage = ws.RunActionByName("WebServiceUser",
                "CCCRM!@#",
                net.azurewebsites.codistri.ExportStyle.CsvWithoutHeader,
                @"DrChatSite/Application.axl",
                "ApptDetail.dxl",
                "OK",
                wsParams
                );

            if (!returnMessage.StartsWith("Error"))
                returnMessage = "Appointment registered ok";

            return returnMessage;

        }
    }
}
