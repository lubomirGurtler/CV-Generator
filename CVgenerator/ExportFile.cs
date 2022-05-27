using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using Spire.Pdf;
using Spire.Pdf.Graphics;

namespace CVgenerator
{
    class ExportFile
    {
        public static void MakePDF()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            PdfDocument doc = new PdfDocument();            
            PdfPageBase page1 = doc.Pages.Add(PdfPageSize.A4);
            PdfPageBase page2;
            PdfPageBase page = page1;
            bool page2WasCreated = false;            

            PdfFont fontBoldUnderline = new PdfFont(PdfFontFamily.Courier, 12f, PdfFontStyle.Bold | PdfFontStyle.Underline);
            PdfFont fontBold16 = new PdfFont(PdfFontFamily.Courier, 16f, PdfFontStyle.Bold);
            PdfFont fontBold = new PdfFont(PdfFontFamily.Courier, 12f, PdfFontStyle.Bold);
            PdfFont fontRegular = new PdfFont(PdfFontFamily.Courier, 12f, PdfFontStyle.Regular);
            PdfFont fontSmall = new PdfFont(PdfFontFamily.Courier, 6f, PdfFontStyle.Regular);

            PdfSolidBrush brush = new PdfSolidBrush(Color.Black);

            PdfStringFormat formatCenter = new PdfStringFormat(PdfTextAlignment.Center);
            PdfStringFormat formatLeft = new PdfStringFormat(PdfTextAlignment.Left);

            float pageWidth = page.Canvas.ClientSize.Width;
            float pageHeight = page.Canvas.ClientSize.Height;
            
            int rowHeight = 14; 
            int line = 0;
              
            string workString = ""; 
            int charaktersInLine = 71;    
            int actualCharakters = 0;
            string[] header = { Form1.name + " ", Form1.surname + ", ", Form1.address + ", ", Form1.zipcode + " ", Form1.city + ", ", Form1.email + ", ", Form1.phone, "" };
            for (int i = 0; i < header.Length - 1; i++)
            {                
                if (header[i] == " " || header[i] == ", " || header[i] == "")
                    continue;
                actualCharakters += header[i].Length;
                workString += header[i];
                if (actualCharakters + header[i+1].Length > charaktersInLine || i == header.Length - 2)
                {
                    page.Canvas.DrawString(workString, fontBoldUnderline, brush, pageWidth / 2, line * rowHeight, formatCenter);
                    workString = "";
                    actualCharakters = 0;
                    line++;
                }               
            }

            line += 2;
            page.Canvas.DrawString("CURRICULUM VITAE", fontBold16, brush, pageWidth / 2, line * rowHeight, formatCenter);
            line += 4;

            if (Form1.dateofbirth != "" || Form1.placeofbirth != "" || Form1.nationality != "" || Form1.marital != "")
                page.Canvas.DrawString("Personal Details", fontBold, brush, 0, line * rowHeight, formatLeft);

            if (Form1.file != "")
            {
                PdfImage image = PdfImage.FromFile(Form1.file);
                float coefficient = 125 / (float)image.Height;
                float height = 125;
                float width = image.Width * coefficient;
                page.Canvas.DrawImage(image, 375, line * rowHeight, width, height);
            }

            line += 2;
            if (Form1.dateofbirth != "")
            {
                page.Canvas.DrawString("Date of birth:", fontRegular, brush, 0, line * rowHeight, formatLeft);
                page.Canvas.DrawString(Form1.dateofbirth, fontRegular, brush, 150, line * rowHeight, formatLeft);
            }
            line++;            

            if (Form1.placeofbirth != "")
            {
                page.Canvas.DrawString("Place of birth:", fontRegular, brush, 0, line * rowHeight, formatLeft);
                page.Canvas.DrawString(Form1.placeofbirth, fontRegular, brush, 150, line * rowHeight, formatLeft);
            }
            line++;

            if (Form1.nationality != "")
            {
                page.Canvas.DrawString("Nationality:", fontRegular, brush, 0, line * rowHeight, formatLeft);
                page.Canvas.DrawString(Form1.nationality, fontRegular, brush, 150, line * rowHeight, formatLeft);
            }
            line++;
            
            if (Form1.marital != "")
            {
                page.Canvas.DrawString("Marital status:", fontRegular, brush, 0, line * rowHeight, formatLeft);
                page.Canvas.DrawString(Form1.marital, fontRegular, brush, 150, line * rowHeight, formatLeft);
            }
            line++;

            if (Form1.link != "")
            {
                line += 3;
                page.Canvas.DrawString("References", fontBold, brush, 0, line * rowHeight, formatLeft);
                line += 2;
                string[] splitted = Form1.link.Split('|');
                foreach (string link in splitted)
                {
                    page.Canvas.DrawString(link.Trim(), fontBoldUnderline, brush, 0, line * rowHeight, formatLeft);
                    line++;
                }
            }
            
            if (Form3.education.Count != 0)
            {
                line += 2;
                page.Canvas.DrawString("Education/Qualification", fontBold, brush, 0, line * rowHeight, formatLeft);
                line += 2;
                foreach (string edu in Form3.education)
                {
                    string[] splitted = edu.Split(':');
                    string[] description = splitted[1].Split('!');
                    page.Canvas.DrawString(splitted[0], fontRegular, brush, 0, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(description[0], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                    page.Canvas.DrawString(description[1], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                    page.Canvas.DrawString(description[2], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                }
            } 

            CheckFullPage(6);
            if (Form2.employments.Count != 0)
            {
                line += 2;                
                page.Canvas.DrawString("Work experience", fontBold, brush, 0, line * rowHeight, formatLeft);
                line += 2;
                foreach (string employment in Form2.employments)
                {
                    string[] splitted = employment.Split(':');
                    string[] date = splitted[0].Split('-');
                    string[] startDate = date[0].Split(' ');
                    string[] endDate = date[1].Split(' ');
                    string[] description = splitted[1].Split('!');
                    CheckFullPage(0);                    
                    page.Canvas.DrawString(startDate[0], fontRegular, brush, 0, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(startDate[1], fontRegular, brush, 75, line * rowHeight, formatLeft);
                    page.Canvas.DrawString("-", fontRegular, brush, 105, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(endDate[0], fontRegular, brush, 115, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(endDate[1], fontRegular, brush, 190, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(description[0], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                    page.Canvas.DrawString(description[1] + ", " + description[2], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                }
            }

            CheckFullPage(Form3.skills.Count + 4);
            if (Form3.skills.Count != 0)
            {
                line += 2;
                page.Canvas.DrawString("Skills", fontBold, brush, 0, line * rowHeight, formatLeft);
                line += 2;
                foreach (string skill in Form3.skills)
                {
                    string[] splitted = skill.Split(':');                    
                    page.Canvas.DrawString(splitted[0], fontRegular, brush, 0, line * rowHeight, formatLeft);
                    page.Canvas.DrawString(splitted[1], fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                    line++;
                }
            }

            CheckFullPage(2);
            if (Form3.driverLicence.Count != 0)
            {
                line += 2;
                string licence = "";
                for (int i = 0; i < Form3.driverLicence.Count; i++)
                {
                    licence += Form3.driverLicence[i];
                    if (i + 1 != Form3.driverLicence.Count)
                        licence += ", ";
                }
                page.Canvas.DrawString("Driver licence", fontBold, brush, 0, line * rowHeight, formatLeft);
                page.Canvas.DrawString(licence, fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);                
            }
            
            if (Form3.interests != "")
            {
                line += 2;
                CheckFullPage(5);
                page.Canvas.DrawString("Interests", fontBold, brush, 0, line * rowHeight, formatLeft);
                string[] interests = Form3.interests.Split(',');
                foreach (string interest in interests)
                {
                    if (interest != "")
                    {
                        page.Canvas.DrawString(interest.Trim(), fontRegular, brush, pageWidth / 2, line * rowHeight, formatLeft);
                        line++;
                    }
                }
            }

            page.Canvas.DrawString("Created with CV Maker by Lubomir Gurtler", fontSmall, brush, pageWidth / 2, 756, formatCenter);

            if (page2WasCreated)
            {
                page.Canvas.DrawString("2/2", fontRegular, brush, pageWidth / 2, 746, formatCenter);
                page = page1;
                page.Canvas.DrawString("1/2", fontRegular, brush, pageWidth / 2, 746, formatCenter);
                page.Canvas.DrawString("Created with CV Maker by Lubomir Gurtler", fontSmall, brush, pageWidth / 2, 756, formatCenter);
            }
            
            doc.SaveToFile(path + @"\CV.pdf", FileFormat.PDF);           
            doc.Close();

            void CheckFullPage(int x)
            {
                int y = line + x;
                if (!page2WasCreated && y > 52)
                {
                    page2 = doc.Pages.Add(PdfPageSize.A4);
                    page = page2;
                    line = 0;
                    page2WasCreated = true;
                }
            }
        }
    }
}
