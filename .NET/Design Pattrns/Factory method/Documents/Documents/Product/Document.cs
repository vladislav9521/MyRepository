using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    abstract class Document
    {
        public abstract void Open();
        public abstract void Close();
        public abstract void SaveAs();
        public abstract void Clear();
    }
}
