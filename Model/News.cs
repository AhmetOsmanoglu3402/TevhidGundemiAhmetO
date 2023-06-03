using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TevhidGundemiMobile.Model
{
    public class News
    {
        /// <summary>
        /// HABER URL'İ
        /// </summary>
        public string Link { get; set; }
        /// <summary>
        /// BAŞLIK
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// AÇIKLAMA
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// PAYLAŞIM TARİHİ
        /// </summary>
        public string PublishDate { get; set; }
        /// <summary>
        /// RESİM YOLU
        /// </summary>
        public string ImageURL { get; set; }
    }
}
