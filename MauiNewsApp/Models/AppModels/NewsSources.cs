using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiNewsApp.Models.AppModels
{
    public class NewsSources
    {
        public string SourceParameter { get; set; }
        public string SourceTitle { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string name { get; set; }
        public bool IsSelected { get; set; } = false;
    }
}
