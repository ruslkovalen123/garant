using BusinessGarant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessGarant.Services
{
    public interface IDocumentEditorService
    {
        byte[] EditRequestDocument(Request model);
    }
}
