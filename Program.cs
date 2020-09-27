using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace GetBase64StringForImage


{
    [XmlRoot(ElementName = "Protocol", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Protocol
    {
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
        [XmlAttribute(AttributeName = "Version", Namespace = "")]
        public String Version;
    }
    [XmlRoot(ElementName = "Software", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Software
    {
        [XmlAttribute(AttributeName = "GUID", Namespace = "")]
        public String GUID;
        [XmlAttribute(AttributeName = "SoftwareDeveloper", Namespace = "")]
        public String SoftwareDeveloper;
        [XmlAttribute(AttributeName = "Version", Namespace = "")]
        public String Version;
    }

    [XmlRoot(ElementName = "Sender", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Sender
    {
        [XmlAttribute(AttributeName = "Code", Namespace = "")]
        public String Code;
        [XmlAttribute(AttributeName = "Department", Namespace = "")]
        public String Department;
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
        [XmlAttribute(AttributeName = "Organization", Namespace = "")]
        public String Organization;
        [XmlAttribute(AttributeName = "Position", Namespace = "")]
        public String Position;
    }
    public class Receiver
    {
        [XmlAttribute(AttributeName = "Code", Namespace = "")]
        public String Code;
        [XmlAttribute(AttributeName = "Department", Namespace = "")]
        public String Department;
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
        [XmlAttribute(AttributeName = "Organization", Namespace = "")]
        public String Organization;
        [XmlAttribute(AttributeName = "Position", Namespace = "")]
        public String Position;
        [XmlAttribute(AttributeName = "ReceiveType", Namespace = "")]
        public String ReceiveType;
    }

    [XmlRoot(ElementName = "OtherReceiver", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class OtherReceiver
    {
        [XmlAttribute(AttributeName = "Code", Namespace = "")]
        public String Code;
        [XmlAttribute(AttributeName = "Department", Namespace = "")]
        public String Department;
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
        [XmlAttribute(AttributeName = "Organization", Namespace = "")]
        public String Organization;
        [XmlAttribute(AttributeName = "Position", Namespace = "")]
        public String Position;
        [XmlAttribute(AttributeName = "ReceiveType", Namespace = "")]
        public String ReceiveType;
    }

    [XmlRoot(ElementName = "OtherReceivers", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class OtherReceivers
    {
        [XmlElement(ElementName = "OtherReceiver", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public OtherReceiver OtherReceiver;
    }

    [XmlRoot(ElementName = "LetterDateTime", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class LetterDateTime
    {
        [XmlAttribute(AttributeName = "ShowAs", Namespace = "")]
        public String ShowAs;
    }

    [XmlRoot(ElementName = "Priority", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Priority
    {
        [XmlAttribute(AttributeName = "Code", Namespace = "")]
        public String Code;
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
    }

    [XmlRoot(ElementName = "Classification", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Classification
    {
        [XmlAttribute(AttributeName = "Code", Namespace = "")]
        public String Code;
        [XmlAttribute(AttributeName = "Name", Namespace = "")]
        public String Name;
    }

    [XmlRoot(ElementName = "Keywords", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Keywords
    {
        [XmlElement(ElementName = "Keyword", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public String Keyword;
    }

    [XmlRoot(ElementName = "Letter", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
    public class Letter
    {
        [XmlElement(ElementName = "Protocol", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Protocol Protocol;
        [XmlElement(ElementName = "Software", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Software Software;
        [XmlElement(ElementName = "Sender", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Sender Sender;
        [XmlElement(ElementName = "Receiver", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Receiver Receiver;
        [XmlElement(ElementName = "OtherReceivers", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public OtherReceivers OtherReceivers;
        [XmlElement(ElementName = "LetterNo", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public String LetterNo;
        [XmlElement(ElementName = "LetterDateTime", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public LetterDateTime LetterDateTime;
        [XmlElement(ElementName = "RelatedLetters", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public String RelatedLetters;
        [XmlElement(ElementName = "Subject", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public String Subject;
        [XmlElement(ElementName = "Priority", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Priority Priority;
        [XmlElement(ElementName = "Classification", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Classification Classification;
        [XmlElement(ElementName = "Keywords", Namespace = "http://www.irica.com/ECE/1383-12/SendSchema")]
        public Keywords Keywords;
        [XmlAttribute(AttributeName = "xmlns", Namespace = "")]
        public String xmlns;
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public String xsd;
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public String xsi;
    }

































    class Program
    {
        static void Main(string[] args)
        {

            XmlDocument doc = new XmlDocument();
            XmlElement root = doc.CreateElement("Letter");
            XmlElement id = doc.CreateElement("Protocol");
            string val;
            Console.Write("Enter ECE VALUE: ");
            val = Console.ReadLine();
            id.SetAttribute("NAME", val);
            id.SetAttribute("version", "1.0.1");
            //XmlElement name = doc.CreateElement("Name");
            //name.InnerText = "Tushar";
            //XmlElement age = doc.CreateElement("Age");
            //age.InnerText = "24";
            XmlElement id2 = doc.CreateElement("Software");
            id2.SetAttribute("GUID", "{0200414A-0500-6F46-726D-73000053568B}");
            id2.SetAttribute("SoftwareDeveloper", "MiiroFiler");
            id2.SetAttribute("Version", "1");
            XmlElement id3 = doc.CreateElement("Sender");
            id3.SetAttribute("Code", "15560000");
            id3.SetAttribute("Department", "شرکت سهامی خدمات  مهندسی مشانیر");
            id3.SetAttribute("Name", "مدیر سیستم System Manager");
            id3.SetAttribute("Organization", "شرکت سهامی خدمات  مهندسی مشانیر");
            id3.SetAttribute("Position", "مدیر  سیستم");
            XmlElement id4 = doc.CreateElement("Receiver");
            id4.SetAttribute("Code", "0");
            id4.SetAttribute("Department", "انجام خدمات نظارت کارگاهی، فنی و مهندسی سایت کردان");
            id4.SetAttribute("Name", "");
            id4.SetAttribute("Organization", "معاونت طرحهای  حمل و نقل و ساختمان");
            id4.SetAttribute("Position", "بیوسان فارمد");
            id4.SetAttribute("ReceiveType", "Origin");
            XmlElement id5 = doc.CreateElement("OtherReceivers");
            XmlElement otrs = doc.CreateElement("OtherReceiver");
            otrs.SetAttribute("Code", "");
            otrs.SetAttribute("Department", "");
            otrs.SetAttribute("Name", "");
            otrs.SetAttribute("Organization", "");
            otrs.SetAttribute("Position", "");
            otrs.SetAttribute("ReceiveType", "");
            XmlElement id6 = doc.CreateElement("LetterNo");
            id6.InnerText = "7636";
            XmlElement id7 = doc.CreateElement("LetterDateTime");
            id7.SetAttribute("ShowAs", "gregorian");
            id7.InnerText = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
            XmlElement id8 = doc.CreateElement("RelatedLetters");
            XmlElement id9 = doc.CreateElement("Subject");
            id9.InnerText = "صورت وضعیت شماره 9- دیوار پیرامونی";
            XmlElement id10 = doc.CreateElement("Priority");
            id10.SetAttribute("Code", "1");
            id10.SetAttribute("Name", "عادی");
            XmlElement id11 = doc.CreateElement("Classification");
            id11.SetAttribute("Code", "1");
            id11.SetAttribute("Name", "");
            string imagePath = @"E:\sample.jpg";
            string imgBase64String = Convert.ToBase64String(File.ReadAllBytes(imagePath));
            Console.WriteLine(imgBase64String);
            XmlElement id12 = doc.CreateElement("Origin");
            id12.SetAttribute("Any", imgBase64String);

            // id.AppendChild(name);
            // id.AppendChild(age);
            root.AppendChild(id);
            doc.AppendChild(root);
            root.AppendChild(id2);
            root.AppendChild(id3);
            root.AppendChild(id4);
            root.AppendChild(id5);
            id5.AppendChild(otrs);
            root.AppendChild(id6);
            root.AppendChild(id7);
            root.AppendChild(id8);
            root.AppendChild(id9);
            root.AppendChild(id10);
            root.AppendChild(id11);
            root.AppendChild(id12);

            doc.Save("test.xml");

            //////base 64 convertion
            ///

          




























































            // private static string GetBase64StringForImage(string imagePath) => throw new NotImplementedException();






            //    XmlWriter xmlWriter = XmlWriter.Create("test.xml");
            //    Letter report = new Letter();
            //    string rep = report.Protocol.Name;
            //    xmlWriter.WriteStartDocument();

            //    xmlWriter.WriteStartElement("Letter");
            //    xmlWriter.WriteAttributes("Protocol"report.Protocol.Name);
            //    xmlWriter.WriteStartElement("user");
            //    xmlWriter.WriteAttributeString("age", "42");
            //    xmlWriter.WriteString("John Doe");
            //    xmlWriter.WriteEndElement();

            //    xmlWriter.WriteStartElement("user");
            //    xmlWriter.WriteAttributeString("age", "39");
            //    xmlWriter.WriteString("Jane Doe");

            //    xmlWriter.WriteEndDocument();
            //    xmlWriter.Close();
        }

    }
}