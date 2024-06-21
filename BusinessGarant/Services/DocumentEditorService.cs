using BusinessGarant.Models;
using GemBox.Document;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGarant.Services
{
    public class DocumentEditorService : IDocumentEditorService
    {
        public  byte [] EditRequestDocument(Request model)
        {
            string path = Path.Combine(Environment.CurrentDirectory, @"files\", "zayavka.docx");
            var document = DocumentModel.Load(path);

            // The easiest way how you can find and replace text is with "Replace" method.
            document.Content.Replace(nameof(model.NumberOfRequest), model.NumberOfRequest);
            document.Content.Replace(nameof(model.Transtype), model.Transtype);
            document.Content.Replace(nameof(model.Rejim), model.Rejim);
            document.Content.Replace(nameof(model.FullNameOfFirm), model.FullNameOfFirm);
            document.Content.Replace(nameof(model.AddressOfRequestor), model.AddressOfRequestor);
            document.Content.Replace(nameof(model.PerevName), model.PerevName);
            document.Content.Replace(nameof(model.PerevAddress), model.PerevAddress);
            document.Content.Replace(nameof(model.NumberOfVagon), !string.IsNullOrEmpty(model.NumberOfVagon) ? model.NumberOfVagon : model.NumberOfContainer);
            document.Content.Replace(nameof(model.PerevBoss), model.PerevBoss);
            document.Content.Replace(nameof(model.Cmr), model.Cmr);
            document.Content.Replace(nameof(model.NameOfGruz), model.NameOfGruz);
            document.Content.Replace(nameof(model.NumberOfVantag), model.NumberOfVantag);
            document.Content.Replace(nameof(model.CODUkrZed), model.CODUkrZed);
            document.Content.Replace(nameof(model.FaktCostTransport), model.FaktCostTransport);
            document.Content.Replace(nameof(model.EndPointOfArrival), model.EndPointOfArrival);
            document.Content.Replace(nameof(model.StartPoint), model.StartPoint);
            document.Content.Replace(nameof(model.Dolg), model.Dolg);
            document.Content.Replace(nameof(model.More), model.More);
            document.Content.Replace(nameof(model.Tel), model.Tel);
            document.Content.Replace(nameof(model.Fio), model.Fio);
            document.Content.Replace(nameof(model.ReceiverName), model.ReceiverName);
            document.Content.Replace(nameof(model.ReceiverAddress), model.ReceiverAddress);
            document.Content.Replace(nameof(model.RecieverCod), model.RecieverCod);
            document.Content.Replace("Data", DateTime.Now.ToString("dd/MM/yyyy"));
            byte[] fileContents;

            var options = SaveOptions.DocxDefault;

            // Save document to DOCX format in byte array.
            using (var stream = new MemoryStream())
            {
                document.Save(stream, options);

                fileContents = stream.ToArray();
            }
            return fileContents;

        }
    }
}
