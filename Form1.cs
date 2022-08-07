using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void Main(string[] args)
        { 
        //make some sets
        Set A = new Set();
        Set B = new Set();
        Random r = new Random(); 
            for (int i = 0; i < 10; i++) { 
                A.addElement(r.Next(4)); B.addElement(r.Next(12)); 
            }           
            //display each set and the union
            Console.WriteLine("A: " + A);           
            Console.WriteLine("B: " + B);           
            Console.WriteLine("A union B: " + A.union(B));           
            //display original sets (should be unchanged)
            Console.WriteLine("After union operation");            
            Console.WriteLine("A: " + A);           
            Console.WriteLine("B: " + B);                   
        }

        class Set
        {
            private List<int> elements; public Set() { elements = new List<int>(); }
            public bool addElement(int val)
            {
                if (containsElement(val)) 
                    return false; 
                else { 
                    elements.Add(val); 
                    return true; 
                }
            }
            private bool containsElement(int val) { 
                for (int i = 0; i < elements.Count; i++) { 
                    if (val == elements[i])
                        return true; 
                    else 
                        return false;
                }
                return false; }

            public override string ToString() { 
                string str = ""; 
                foreach (int i in elements) { 
                    str += i + " "; 
                } 
                return str; 
            }
            public void clearSet() { 
                elements.Clear();
            }
            public Set union(Set rhs) { 
                for (int i = 0; i < rhs.elements.Count; i++) {
                    this.addElement(rhs.elements[i]); } 
                return rhs; }
        }
    


    private void StartButton_Click(object sender, EventArgs e)
        {

        }
    }
}
