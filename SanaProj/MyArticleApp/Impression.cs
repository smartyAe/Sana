using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data;

namespace MyArticleApp
{
    class Impression
    {
        private static  DataTable CurrentLigneFactures = new DataTable();
        
        static string ExportDataTableToPdf(DataTable dtblTable, string Reff,string Date,string Mont)
        {

            string folderPath = Application.StartupPath+"\\Facture\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            //File Name
            int fileCount = Directory.GetFiles(folderPath).Length;
            string strFileName = "Facture" + (fileCount + 1) + ".pdf";
            System.IO.FileStream fs = new FileStream(folderPath + strFileName, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document(PageSize.A4, 55f, 30f, 45f, 0f);

            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

             //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 22, 1, BaseColor.BLACK);
            
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("Facture".ToUpper(), fntHead));
            document.Add(prgHeading);

            document.Add(new Chunk("\n", fntHead));
            document.Add(new Chunk("\n", fntHead));
            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 12, 2, BaseColor.BLACK);
            prgAuthor.Alignment = Element.ALIGN_LEFT;
            prgAuthor.IndentationLeft = 45f;
            prgAuthor.Add(new Chunk("Référence :" + Reff, fntAuthor));
            prgAuthor.Add(new Chunk("\nDate de Facturation :" + Date, fntAuthor));
            document.Add(prgAuthor);

             

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 12, 1, BaseColor.BLACK);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.PaddingLeft = 30f;
                cell.PaddingBottom = 10f;
                cell.BackgroundColor = BaseColor.WHITE;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {

                    PdfPCell cel = new PdfPCell();
                    cel.PaddingLeft = 50f;
                    cel.PaddingBottom = 5f;
                    cel.BackgroundColor = BaseColor.WHITE; 
                    cel.AddElement(new Chunk(dtblTable.Rows[i][j].ToString(), fntAuthor));
                    table.AddCell(cel);
                }
            }
            PdfPCell cell1 = new PdfPCell();
            cell1.PaddingLeft = 30f;
            cell1.PaddingBottom = 10f;
            cell1.BackgroundColor = BaseColor.WHITE;
            cell1.Border = 0;
            table.AddCell(cell1);
            PdfPCell cell2 = new PdfPCell();
            cell2.PaddingLeft = 30f;
            cell2.PaddingBottom = 10f;
            cell2.BackgroundColor = BaseColor.WHITE;
            cell2.Border = 0;
            table.AddCell(cell2);
            PdfPCell cell3 = new PdfPCell();
            cell3.PaddingLeft = 30f;
            cell3.PaddingBottom = 10f;
            cell3.BackgroundColor = BaseColor.WHITE;
            cell3.Border = 0;
            cell3.AddElement(new Chunk("Montant  :".ToUpper()+Mont , fntColumnHeader));
            table.AddCell(cell3);
             

            //End Of Footer Section

            document.Add(table);
            document.AddCreationDate();
             
            document.NewPage();
            document.Close();
            writer.Close();
            fs.Close();
            return folderPath + strFileName;
        }


        public static void FillReportFacture(string Ref )
        {
            CurrentLigneFactures = new DalFacture().GetLigneFacturesByFacture(Ref);
            string Date= CurrentLigneFactures.Rows[0][5].ToString(); 
            string Montant= CurrentLigneFactures.Rows[0][3].ToString();   
            CurrentLigneFactures = MiseEnforme.AdaptDataTableLigneFacture(CurrentLigneFactures); 
            System.Diagnostics.Process.Start(ExportDataTableToPdf(CurrentLigneFactures, Ref, Date,Montant ));

        }
    }
}
