using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;


namespace KSU.CIS300.TowersOfHanoi
{
    public partial class UserInterface : Form
    {
        public int Moves;
        public bool TestMode;
        public Stack<int> PegA;
        public Stack<int> PegB;
        public Stack<int> PegC;
        public int _discCount;

        
        

        public UserInterface()
        {
            InitializeComponent();
            decimal numd = uxNewNumeric.Value;
            int numdisc = Decimal.ToInt32(numd);

        }
        private void DrawDisc(int number, FlowLayoutPanel panel)
        {
            int myNum;
            Label label1 = new Label();
            label1.Width = (int)(panel.Width / (_discCount - number + 1.25));
            myNum = number;



            if (myNum % 2 == 0)
            {
                label1.BackColor = Color.Red;
            }
            else
            {
                label1.BackColor = Color.Gray;
            }

            label1.Text = Convert.ToString(number);
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            uxFlow1.Controls.Add(label1);
        }
        private void CleanPanel(FlowLayoutPanel panel)
        {

        }

        private void NewPuzzle(int count)
        {
            uxCount.Text = "0";
            ///CleanPanel();
            int amount = Convert.ToInt32(uxNewNumeric.Value);
            int i;
            
            for (i=0; i <= amount; i++)
            {
               DrawDisc(i,uxFlow1);
              
            }
            
        }

      /// private bool UpdatePanelHelper(FlowLayoutPanel source, Stack<int> sourceStack,FlowLayoutPanel dest, Stack<int> destStack, FlowLayoutPanel alt, Stack<int> altStack)
     ///  {
        ///    if (PegA = uxFlow1.Controls.Count)
          ///  {

           /// }
       }
       public bool MoveDisc(Stack<int> from, Stack<int> to)
       {
        

       }
       /// private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      ///  {
   
       /// }

       /// private void label1_Click(object sender, EventArgs e)
      ///  {

      ///  }

       /// private void uxNew_Click(object sender, EventArgs e)
      ///  {
         ///   NewPuzzle(3);
      ///  }
    }

