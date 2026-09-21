using System.Diagnostics;
using System.Globalization;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pdf_generator_devis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeneratePDF();
        }

        public void GeneratePDF()
        {
            // Get the current directory and create the output file path
            string outfile = Path.Combine(Environment.CurrentDirectory, "Estimate.pdf");

            // Create a new PDF document using iTextSharp (A4 with margins)
            Document document = new Document(PageSize.A4, 36, 36, 54, 54);
            using (var stream = new FileStream(outfile, FileMode.Create))
            {
                PdfWriter.GetInstance(document, stream);
                document.Open();

                // Colors and fonts
                BaseColor blue = new BaseColor(0, 75, 155);
                BaseColor gris = new BaseColor(240, 240, 240);

                var titleFont = FontFactory.GetFont("Helvetica", 18, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));
                var headerFont = FontFactory.GetFont("Helvetica", 12, iTextSharp.text.Font.BOLD, new BaseColor(255, 255, 255));
                var normalFont = FontFactory.GetFont("Helvetica", 11, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

                // Title (use estimate textbox as title if provided)
                var titleText = string.IsNullOrWhiteSpace(estimate?.Text) ? "Estimate" : estimate.Text;
                var title = new Paragraph(titleText, titleFont) { Alignment = Element.ALIGN_CENTER };
                document.Add(title);
                document.Add(new Paragraph(" "));

                // Information / Client two-column
                var infoTable = new PdfPTable(2) { WidthPercentage = 100 };
                infoTable.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
                var left = new PdfPCell(new Phrase("Company information:\n" + (Information?.Text ?? string.Empty), normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                var right = new PdfPCell(new Phrase("Client information:\n" + (client?.Text ?? string.Empty), normalFont)) { Border = iTextSharp.text.Rectangle.NO_BORDER };
                infoTable.AddCell(left);
                infoTable.AddCell(right);
                document.Add(infoTable);
                document.Add(new Paragraph(" "));

                // Products table header
                var table = new PdfPTable(4) { WidthPercentage = 100 };
                table.SetWidths(new float[] { 5f, 2f, 1f, 2f });

                PdfPCell MakeHeader(string text)
                {
                    var c = new PdfPCell(new Phrase(text, headerFont)) { BackgroundColor = blue, HorizontalAlignment = Element.ALIGN_CENTER };
                    return c;
                }

                table.AddCell(MakeHeader("Product"));
                table.AddCell(MakeHeader("Price"));
                table.AddCell(MakeHeader("Qty"));
                table.AddCell(MakeHeader("Total"));

                // Single item from the form (textBox1, prix, qtys)
                string productName = textBox1?.Text ?? string.Empty;
                decimal priceVal = 0m;
                int qtyVal = 0;
                decimal.TryParse(prix?.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out priceVal);
                int.TryParse(qty?.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out qtyVal);
                decimal lineTotal = priceVal * qtyVal;

                table.AddCell(new PdfPCell(new Phrase(productName, normalFont)));
                table.AddCell(new PdfPCell(new Phrase(priceVal != 0m ? priceVal.ToString("C", CultureInfo.CurrentCulture) : string.Empty, normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });
                table.AddCell(new PdfPCell(new Phrase(qtyVal != 0 ? qtyVal.ToString() : string.Empty, normalFont)) { HorizontalAlignment = Element.ALIGN_CENTER });
                table.AddCell(new PdfPCell(new Phrase(lineTotal != 0m ? lineTotal.ToString("C", CultureInfo.CurrentCulture) : string.Empty, normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT });

                // Grand total row
                var totalCell = new PdfPCell(new Phrase("Total", headerFont)) { Colspan = 3, HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = gris };
                table.AddCell(totalCell);
                table.AddCell(new PdfPCell(new Phrase(lineTotal.ToString("C", CultureInfo.CurrentCulture), normalFont)) { HorizontalAlignment = Element.ALIGN_RIGHT, BackgroundColor = gris });

                document.Add(table);

                document.Close();
            }

            // Open the generated PDF using default application
            try
            {
                Process.Start(new ProcessStartInfo(outfile) { UseShellExecute = true });
            }
            catch
            {
                // ignore errors launching the file
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
