using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace AmericaLittleLeaders.Models
{
    public class FileViewModel
    {
        public FileInfo[] fileList { get; set; }

        public static FileViewModel ListFiles()
        {
             FileViewModel docList = new FileViewModel()
             {
                  fileList = new System.IO.DirectoryInfo( HttpContext.Current.Server.MapPath("~/Content/Documents/")).GetFiles()
             };
             return docList;
        }
       
    }

    public class ContainerModel
    {
        public FileViewModel files = null;
        public ContentSliderViewModel images = null;

    }
    
}
