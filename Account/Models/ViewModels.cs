using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Account.Models
{
    public class ViewModels
    {
        public int Number { get; set; }
        public string Type { get; set; }


        [RegularExpression(@"^[0-9]+$")]
        public int Money { get; set; }

        [Required(ErrorMessage ="請輸入正確時間")]
        public DateTime DateTime { get; set; }

        public string Remark { get; set; }


    }
}