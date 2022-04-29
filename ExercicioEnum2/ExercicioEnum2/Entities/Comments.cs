using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnum2.Entities
{
    internal class Comments
    {
        public string Text { get; set; }

        public Comments()
        {
        }

        public Comments(string text)
        {
            Text = text;
        }
    }
}
