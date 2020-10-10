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
        /// <param name="sipProfile">SIP profile to receive configuration details</param>
        /// <returns></returns>
        public static SipProfile ObtainSipProfileDetailsFromXmlFile(string filePath, SipProfile sipProfile)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(filePath);


            sipProfile.SipListeningPort = int.Parse(xmlDoc.GetElementsByTagName("SipListeningPort")[0].InnerText);
            sipProfile.SipsListeningPort = int.Parse(xmlDoc.GetElementsByTagName("SipsListeningPort")[0].InnerText);
            sipProfile.AudioStartPort = int.Parse(xmlDoc.GetElementsByTagName("AudioStartPort")[0].InnerText);
            sipProfile.AudioEndPort = int.Parse(xmlDoc.GetElementsByTagName("AudioEndPort")[0].InnerText);
            sipProfile.SipUserAgent = xmlDoc.GetElementsByTagName("SipUserAgent")[0].InnerText;
            sipProfile.SipUserAgent = xmlDoc.GetElementsByTagName("SipUserAgent")[0].InnerText;

            sipProfile.SipUser.Name = xmlDoc.GetElementsByTagName("Name")[0].InnerText;
            sipProfile.SipUser.Username = xmlDoc.GetElementsByTagName("Username")[0].InnerText;
            sipProfile.SipUser.Password = xmlDoc.GetElementsByTagName("Password")[0].InnerText;

            sipProfile.SipServer.SipServerAddress = xmlDoc.GetElementsByTagName("SipServerAddress")[0].InnerText;
            sipProfile.SipServer.SipRegisterAddress = xmlDoc.GetElementsByTagName("SipRegisterAddress")[0].InnerText;
            sipProfile.SipServer.Domain = xmlDoc.GetElementsByTagName("Domain")[0].InnerText;
            sipProfile.SipServer.SipServerPort = int.Parse(xmlDoc.GetElementsByTagName("SipServerPort")[0].InnerText);
            sipProfile.SipServer.Expiry = int.Parse(xmlDoc.GetElementsByTagName("Expiry")[0].InnerText);

            return sipProfile;
        }
    }
}
