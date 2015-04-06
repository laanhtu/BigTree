using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace JQueryFileUploadMVC.Models
{
    public class ImageViewModel
    {
        public int Id { get; set; }
        [DisplayName("Image path")]
        public string ImagePath { get; set; }
        public byte Quantity { get; set; }
        [DisplayName("Meta data")]
        public string Metadata { get; set; }
    }
}
