using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quick_sort_dom_2
{
    /// <summary>
    /// implement a recursive sort algo
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int n = 10, min = 0, max = 20;

        
        /// <summary>
        /// get random input and sort by algo
        /// and show output
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            int[] a = Quicksort.FillArrayRandom(n, min, max);
            for (int i = 0; i < a.Length; i++) listBox1.Items.Add(a[i]);
            int[] final = Quicksort.SortArray(a);
            for (int i = 0; i < final.Length; i++) listBox2.Items.Add(final[i]);

        }
    }
}
