using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;

namespace Task1
{
    class XsdValidator
    {
        public IEnumerable<string> Validate(string targetNamespace, string schemaUri, string inputUri)
        {
            var settings = new XmlReaderSettings();
            settings.Schemas.Add(targetNamespace, schemaUri);

            var validationErrors = new List<string>();
            settings.ValidationEventHandler += (sender, e) => validationErrors.Add(e.Message);

            settings.ValidationFlags = settings.ValidationFlags | XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationType = ValidationType.Schema;

            using (var reader = XmlReader.Create(inputUri, settings))
            {
                while (reader.Read()) ;
            }

            return validationErrors;
        }
    }
}
