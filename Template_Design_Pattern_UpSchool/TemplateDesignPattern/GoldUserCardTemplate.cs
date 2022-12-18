using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Design_Pattern_UpSchool.TemplateDesignPattern
{
    public class GoldUserCardTemplate : UserCardTemplate
    {
        protected override string SetFooter()
        {
            var sb = new StringBuilder();
            sb.Append("<a href='#' class='card-link'>Profili Gör</a>");
            sb.Append("<a href='#' class='card-link'>Mesaj Gönder</a>");
            return sb.ToString();
        }

        protected override string SetImage()
        {
            return $"<img class='car-img-top' src='{AppUser.Image}' style='width:50px; height:50px;'>";
        }
    }
}
