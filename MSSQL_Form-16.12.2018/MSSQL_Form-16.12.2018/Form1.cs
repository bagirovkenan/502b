using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MSSQL_Form_16._12._2018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var webClient = new WebClient();

            var xmlDataByte = webClient.DownloadData("https://www.cbar.az/currencies/14.12.2018.xml");
            var xmlData = Encoding.UTF8.GetString(xmlDataByte);


            StringReader xmlStreamData = new StringReader(xmlData);

            XmlSerializer xmlser = new XmlSerializer(typeof(ValCurs));
            var myValCurs = (ValCurs)xmlser.Deserialize(xmlStreamData);

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            SqlConnection coon = new SqlConnection(@"data source=192.168.19.35\SQLEXPRESS;User id=sa;Password=123456;Initial Catalog=p504");
            coon.Open();

            string comText = "";
            var nDate = (myValCurs.Date).ToString();


            //foreach (var i in myValCurs.ValType)
            //  {
            var ig = myValCurs.ValType[1];
            var nValueType = ig.Type;

            foreach (var y in ig.Valute)
            {

                var ncode = (y.Code).ToString();
                var nNominal = (y.Nominal);
                var nName = (y.Name).ToString();
                var nValue = (y.Value);



                comText += "Insert Into Currency(Code,Nominal,Name,Value,ValueType,ValDateTime,[User])" + $" VALUES('{ncode}',{nNominal}, N'{ nName}',{ nValue} ,'{ nValueType }','{ nDate }', 'kenan');";

            }


            //}
            SqlCommand cm = new SqlCommand(comText, coon);
            cm.ExecuteNonQuery();
            coon.Close();



        }
    }

    public class Valute
    {
        [XmlElement(ElementName = "Nominal")]
        public string Nominal { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Value")]
        public string Value { get; set; }
        [XmlAttribute(AttributeName = "Code")]
        public string Code { get; set; }
    }

    [XmlRoot(ElementName = "ValType")]
    public class ValType
    {
        [XmlElement(ElementName = "Valute")]
        public List<Valute> Valute { get; set; }
        [XmlAttribute(AttributeName = "Type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "ValCurs")]
    public class ValCurs
    {
        [XmlElement(ElementName = "ValType")]
        public List<ValType> ValType { get; set; } = new List<ValType>();
        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "Description")]
        public string Description { get; set; }
    }


}
