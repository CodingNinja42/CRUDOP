using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FileUpload.Models
{
    public class employee
    {
        [Key]
        public int eid { get; set; }

        public string ename { get; set; }
        public string email { get; set; }
        public string epass { get; set; }
        public string ecpass { get; set; }
        public string eimage { get; set; }
        [NotMapped]
        public HttpPostedFileBase orimage { get; set; }
    }
}