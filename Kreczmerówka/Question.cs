using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Kreczmerowka
{
    [Serializable]
    public class Question
    {
        public Question()
        {
            Content = String.Empty;
            CorrectAnswer = false;
            Notes = String.Empty;
        }

        [XmlElement(ElementName = "Tresc")]
        public string Content { get; set; }

        [XmlElement(ElementName = "Odpowiedz")]
        public bool CorrectAnswer { get; set; }

        [XmlElement(ElementName = "Notatka")]
        public string Notes { get; set; }
    }
}
