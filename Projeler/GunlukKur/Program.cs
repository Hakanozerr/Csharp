using System;
using System.Xml;
using System.Xml.Linq;

namespace GunlukKur
{
    class Program
    {
        static void Main(string[] args)
        {
            string ParaDeger = "";
            String DonusturulecekPara = "";
            int GirilenParaDeger = 0;

            var XmlDoc = new XmlDocument();
            XmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");

            Console.WriteLine("ABD DOLARI : USD \nAVUSTRALYA DOLARI : AUD \nDANİMARKA KRONU : DKK \nEURO : EUR \nİNGİLİZ STERLİNİ : GBP \nİŞVİÇRE FRANGI : CHF \nİŞVEÇ KRONU : SEK \nKANADA DOLARI : CAD \nKUVEYT DOLARI : KWD \nNORÇEV KRONU : NOK \nSUUDİ ARABİSTAN RİYALI : SAR \nJAPON YENİ : JPY \n");
            while (true)
            {
            Console.Write("Parayı Dönüştürmek İstediğiniz Döviz Kodunu Giriniz = ");
            DonusturulecekPara = Console.ReadLine();

            Console.Write("Para Miktarını Gİriniz.");
            GirilenParaDeger = Convert.ToInt32(Console.ReadLine());

            switch (DonusturulecekPara)
            {
                case "USD": ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='USD']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " ABD Doları.");break;
                case "AUD":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='AUD']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Avustralya Doları."); break;
                case "DKK":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='DKK']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Danimarka Kronu."); break;
                case "EUR":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='EUR']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Euro."); break;
                case "GBP":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " İngiliz Sterlini."); break;
                case "CHF":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CHF']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " İşviçre Frangı."); break;
                case "SEK":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SEK']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " İşveç Kronu."); break;
                case "CAD":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='CAD']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Kanada Doları."); break;
                case "KWD":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='KWD']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Kuveyt Dinarı."); break;
                case "NOK":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='NOK']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Norveç Kronu."); break;
                case "SAR":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='SAR']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Suudi Arabistan Riyali."); break;
                case "JPY":
                    ParaDeger = XmlDoc.SelectSingleNode("Tarih_Date/Currency [@Kod='JPY']/ForexSelling").InnerXml;
                    Console.WriteLine(GirilenParaDeger + " Türk Lirası " + (GirilenParaDeger / Convert.ToDouble(ParaDeger)) + " Japon Yeni  ."); break;
            }
            }

        }
    }
}
