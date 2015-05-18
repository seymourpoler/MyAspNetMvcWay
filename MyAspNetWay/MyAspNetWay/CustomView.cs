using System.IO;
using System.Web.Mvc;

namespace MyAspNetWay
{
    public class CustomView : IView
    {
        private readonly string physicalPath;

        public CustomView(string physicalPath)
        {
            this.physicalPath = physicalPath;
        }

        public void Render(ViewContext viewContext, TextWriter writer)
        {
            var rawcontents = File.ReadAllText(physicalPath);
            writer.Write(rawcontents);
        }
    }
}