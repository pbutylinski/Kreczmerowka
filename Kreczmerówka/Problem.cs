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
    public class Problem
    {
        public Problem()
        {
            Code = String.Empty;
            Description = "";
        }

        [XmlElement(ElementName = "Kod")]
        public string Code { get; set; }

        [XmlElement(ElementName = "Opis")]
        public string Description { get; set; }

        [XmlArray(ElementName = "Pytania")]
        [XmlArrayItem(ElementName = "Pytanie")]
        public Question[] Questions { get; set; }
    }
}
