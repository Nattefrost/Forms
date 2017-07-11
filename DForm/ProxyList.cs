using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DForm
{
    public class ProxyList : List<QuestionBase>, IReadOnlyList<QuestionBase>
    {
        public new bool Contains( QuestionBase item )
        {
            foreach( QuestionBase q in this )
            {
                if( q == item ) return true;
                else return q.Children.Contains( item );
            }
            return false;
        }
    }
}
