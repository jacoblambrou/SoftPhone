using SoftPhone.Common.SipClientModels.UserAgents;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace SoftPhone.Data.Xml
{
    public static class XmlReader
    {
        /// <summary>
        /// Obtains the SIP profile information from an XML file
        /// </summary>
        /// <param name="filePath">File path of XML document</param>
        /// <param name="sipUAC">SIP profile to receive configuration details</param>
        /// <returns></returns>
        public static SipUserAgentClient ObtainSipProfileDetailsFromXmlFile(string filePath, SipUserAgentClient sipUAC)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);


            sipUAC.LocalSipUas.SipPort = int.Parse(xmlDoc.GetElementsByTagName("SipListeningPort")[0].InnerText);
            sipUAC.LocalSipUas.AudioStartPort = int.Parse(xmlDoc.GetElementsByTagName("AudioStartPort")[0].InnerText);
            sipUAC.LocalSipUas.AudioEndPort = int.Parse(xmlDoc.GetElementsByTagName("AudioEndPort")[0].InnerText);
            //sipUAC.SipUserAgent = xmlDoc.GetElementsByTagName("SipUserAgent")[0].InnerText;

            sipUAC.SipUser.Name = xmlDoc.GetElementsByTagName("Name")[0].InnerText;
            sipUAC.SipUser.Username = xmlDoc.GetElementsByTagName("Username")[0].InnerText;
            sipUAC.SipUser.Password = xmlDoc.GetElementsByTagName("Password")[0].InnerText;

            sipUAC.RemoteSipUas.SipServerAddress = xmlDoc.GetElementsByTagName("SipServerAddress")[0].InnerText;
            sipUAC.RemoteSipUas.RegisterAddress = xmlDoc.GetElementsByTagName("SipRegisterAddress")[0].InnerText;
            sipUAC.RemoteSipUas.Domain = xmlDoc.GetElementsByTagName("Domain")[0].InnerText;
            sipUAC.RemoteSipUas.SipPort = int.Parse(xmlDoc.GetElementsByTagName("SipServerPort")[0].InnerText);
            sipUAC.RemoteSipUas.Expiry = int.Parse(xmlDoc.GetElementsByTagName("Expiry")[0].InnerText);

            return sipUAC;
        }
    }
}
