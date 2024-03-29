using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modles
{
    public class Voiture
    {
        private string _plaque;
        public string Plaque
        {
            get { return _plaque; }
        }
        public Voiture(string plaque)
        { 
            _plaque = plaque;
        }
    }
}
