using System;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using System.Collections.Generic;


namespace CableMangementSystem
{
    static public class GenReport
    {


        public static void CreateDocumentHistory(string main,string sub,List<string> data)
        {
            Document document = new Document();
            Section sec = document.AddSection();
            document.UseCmykColor = true;

            DefineStyles(document);

            const bool unicode = false;

            // creates main and sub heading 
            Heading(document, main, sub);

            // create main table of the customer
            CreateTableBilling(document, 8, data);

            // render document for pdf 
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            // save and start pdf file
            const string fileName = "BillingHistory.pdf";
            pdfRenderer.PdfDocument.Save(fileName);
            Process.Start(fileName);
        }
        private static void CreateTableBilling(Document doc, int col, List<string> data)
        {
            Table table = new Table();
            table.Borders.Width = 1.00;

            float colWidth = 2.00f;
            Column column = new Column();
            AddColumn(table, column, col, colWidth);

            string[] heading = { "HistoryId", "UserId", "Customer Name", "House No", "Payment", "Received By", "Month", "Status" };

            Row addRow = table.AddRow();
            FillRow(8, addRow, heading);

       
            Queue<string> dataUserStack = new Queue<string>(data);

            Row newRow;
            Cell newCell;
            string newData;

            int rowNo = 0;

            for (int i = 0; i < data.Count / heading.Length; i++)
            {
                newRow = table.AddRow();

                for (int j = 0; j < data.Count && (dataUserStack.Count != 0); j++)
                {
                    newCell = newRow.Cells[rowNo];
                    newData = dataUserStack.Dequeue();
                    newCell.AddParagraph(newData);
                    rowNo++;
                    if (rowNo == heading.Length)
                        rowNo = 0;

                    if (j == (heading.Length - 1))
                        break;
                }

            }


            table.SetEdge(0, 0, 0, 0, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);

            table.Format.Alignment = ParagraphAlignment.Center;
            doc.LastSection.Add(table);

        }


        public static void CreateDocumentInventory(string main, string sub, List<string> data)
        {
            Document document = new Document();
            Section sec = document.AddSection();

            document.UseCmykColor = true;

            DefineStyles(document);

            const bool unicode = false;

            // creates main and sub heading 
            Heading(document, main, sub);

            // create main table of the customer
            CreateInventoryReport(document, 3, data,sec);

            // render document for pdf 
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(unicode);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();

            // save and start pdf file
            const string fileName = "MonthlyInventoryReport.pdf";
            pdfRenderer.PdfDocument.Save(fileName);
            Process.Start(fileName);
        }
        private static void CreateInventoryReport(Document doc, int col, List<string> data,Section sec)
        {
            Table table = new Table();
            table.Borders.Width = 1.00;

            float colWidth = 2.00f;
            Column column = new Column();
            AddColumn(table, column, col, colWidth);

            string[] heading = { "Item Number", "Item Name", "Quantity" };

            Row addRow = table.AddRow();
            FillRow(3, addRow, heading);

            Queue<string> dataUserStack = new Queue<string>(data);

            Row newRow;
            Cell newCell;
            string newData;

            int rowNo = 0;

            for (int i = 0; i < data.Count / heading.Length; i++)
            {
                newRow = table.AddRow();

                for (int j = 0; j < data.Count && (dataUserStack.Count != 0); j++)
                {
                    newCell = newRow.Cells[rowNo];

                    newData = dataUserStack.Dequeue();
                    newCell.AddParagraph(newData);
                    rowNo++;

                    if (rowNo == heading.Length)
                        rowNo = 0;

                    if (j == (heading.Length - 1))
                        break;
                }

            }

            var tableW = Unit.FromCentimeter(2);
            var leftIndentToCenterTable = (sec.PageSetup.PageWidth.Centimeter -
                               sec.PageSetup.LeftMargin.Centimeter -
                               sec.PageSetup.RightMargin.Centimeter -
                               tableW.Centimeter) / 2;
            table.Rows.LeftIndent = Unit.FromCentimeter(leftIndentToCenterTable);

            table.SetEdge(0, 0, 0, 0, Edge.Box, MigraDoc.DocumentObjectModel.BorderStyle.Single, 1.5, Colors.Black);

            doc.LastSection.Add(table);

        }


        public static void Heading(Document document, string main, string sub)
        {
            Paragraph paragraph = document.LastSection.AddParagraph(main, "Heading1");
            paragraph.Format.Alignment = ParagraphAlignment.Center;
        }
        public static void DefineStyles(Document doc)
        {

            // main heading 
            Style style = doc.Styles["Normal"];
            style = doc.Styles["Heading1"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 24;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;

            // sub heading
            style = doc.Styles["Heading2"];
            style.Font.Name = "Tahoma";
            style.Font.Size = 14;
            style.Font.Bold = true;
            style.Font.Color = Colors.DarkBlue;
            style.ParagraphFormat.PageBreakBefore = true;
            style.ParagraphFormat.SpaceAfter = 6;
        }


        private static void AddColumn(Table table, Column column, int noOfcol,float colWidth)
        {
            for (int i = 0; i < noOfcol; i++)
            {
                column = table.AddColumn(Unit.FromCentimeter(colWidth));
                column.Format.Alignment = ParagraphAlignment.Center;
            }
        }
        private static void FillRow(int col, Row addRow, string[] heading)
        {

            Cell cell;
            for (int i = 0; i < col; i++)
            {
                cell = addRow.Cells[i];
                cell.AddParagraph(heading[i]);
            }
        }
     
    }
}
