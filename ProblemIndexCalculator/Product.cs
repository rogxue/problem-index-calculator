using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ProblemIndexCalculator
{
    public class Product
    {
        public String name
        {
            get;
            set;
        }
        public int target
        {
            get;
            set;
        }
        public List<DateIndexPair> dipList
        {
            get;
            set;
        }

        public int rtyWeight
        {
            get;
            set;
        }
        public int obaWeight
        {
            get;
            set;
        }
        public int hotWeight
        {
            get;
            set;
        }
        public int agrrWeight
        {
            get;
            set;
        }
        public int rtyCutoff1
        {
            get;
            set;
        }
        public int rtyCutoff2
        {
            get;
            set;
        }
        public int obaCutoff1
        {
            get;
            set;
        }
        public int obaCutoff2
        {
            get;
            set;
        }
        public int agrrCutoff1
        {
            get;
            set;
        }
        public int agrrCutoff2
        {
            get;
            set;
        }

        public Product()
        {
            name = "";
            target = 30;
            dipList = new List<DateIndexPair>();
        }

        public Product(String name, int target)
        {
            this.name = name;
            this.target = target;
        }

        public void WriteToXml(String file)
        {
            File.Delete(file);
            using (XmlWriter writer = XmlWriter.Create(file))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Product");

                writer.WriteElementString("Name", name);

                writer.WriteStartElement("Variables");
                writer.WriteElementString("Target", target.ToString());
                writer.WriteElementString("RtyWeight", rtyWeight.ToString());
                writer.WriteElementString("ObaWeight", obaWeight.ToString());
                writer.WriteElementString("HotWeight", hotWeight.ToString());
                writer.WriteElementString("AgrrWeight", agrrWeight.ToString());
                writer.WriteElementString("RtyCutoff1", rtyCutoff1.ToString());
                writer.WriteElementString("RtyCutoff2", rtyCutoff2.ToString());
                writer.WriteElementString("ObaCutoff1", obaCutoff1.ToString());
                writer.WriteElementString("ObaCutoff2", obaCutoff2.ToString());
                writer.WriteElementString("AgrrCutoff1", agrrCutoff1.ToString());
                writer.WriteElementString("AgrrCutoff2", agrrCutoff2.ToString());

                writer.WriteEndElement();


                foreach (DateIndexPair dip in dipList)
                {
                    writer.WriteStartElement("Data");

                    writer.WriteElementString("Date", dip.GetDateDirtyText());
                    writer.WriteElementString("Index", dip.probIndex.ToString());
                    writer.WriteElementString("Rty", dip.rty.ToString());
                    writer.WriteElementString("Oba", dip.oba.ToString());
                    writer.WriteElementString("Hot", dip.hot.ToString());
                    writer.WriteElementString("Agrr", dip.agrr.ToString());
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
