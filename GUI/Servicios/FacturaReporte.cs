using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Servicios
{
    public class FacturaReporte
    {
        public static void Reporte(BeReserva pReserva)
        {
            float widthInCM = 6f; // ancho en centímetros
            float heightInCM = 12f; // alto en centímetros

            float widthInPoints = widthInCM * 28.35f; // ancho en puntos
            float heightInPoints = heightInCM * 28.35f; // alto en punto

            SaveFileDialog path = new SaveFileDialog();
            path.Filter = "PDF Files|*.pdf";
            path.FileName = "";
            path.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";
            if (path.ShowDialog() == DialogResult.OK)
            {
                path.ShowDialog();
                var document = new Document(new iTextSharp.text.Rectangle(widthInPoints, heightInPoints), 15, 15, 15, 15);
                PdfWriter.GetInstance(document, new FileStream(path.FileName, FileMode.Create));
                document.Open();
                //string pathImg = "GUI.Resourses.logo.png";
                //Stream streamImg = Assembly.GetExecutingAssembly().GetManifestResourceStream(pathImg);
                //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(streamImg), System.Drawing.Imaging.ImageFormat.Png);
                //logo.ScalePercent(10);
                //document.Add(logo);
                document.Add(new Paragraph($"Id: {pReserva.id}"));
                document.Add(new Paragraph($"Cancha: {pReserva.Cancha.Nombre}"));
                document.Add(new Paragraph($"Cliente: {pReserva.Cliente.Nombre}"));
                document.Add(new Paragraph($"Fecha y hora: {pReserva.Fecha.ToString("dd/MM/yyyy")}, {pReserva.Hora}"));
                document.Add(new Paragraph($"Total por hora: ${pReserva.Cancha.Precio}"));
                document.Add(new Paragraph("\n\nNo te olvides de cancelar antes de las 24hs"));
                document.Close();
                Process.Start(path.FileName);
            }
        }
    }
}
