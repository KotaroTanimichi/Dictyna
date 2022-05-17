using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace Dictyna
{
    public class DictynaInfo : GH_AssemblyInfo
    {
        public override string Name => "Dictyna";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("E67AE632-DDB5-4B0A-AB72-7A0AAAFE001E");

        //Return a string identifying you or your company.
        public override string AuthorName => "KotaroTanimichi";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}