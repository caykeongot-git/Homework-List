using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_3
{
    public class ListViewItemComparer : IComparer
    {
        private int col;

        public ListViewItemComparer (int col)
        {
            this.col = col;
        }

        public int Compare (object x, object y)
        {
            return String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);


        }
    }
}
