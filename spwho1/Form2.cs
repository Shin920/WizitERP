using Google.Protobuf.WellKnownTypes;
using MetroFramework.Controls;
using spwho1.DAC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spwho1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {

        public List<int> SelectedW011List { get; private set; }
        public Form2(List<PshdmItem> list)
        {
            InitializeComponent();

            foreach (PshdmItem item in list)
            {
                checkedListBox1.Items.Add(item.W011);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SelectedW011List = new List<int>();

            foreach (object item in checkedListBox1.CheckedItems)
            {
                SelectedW011List.Add(Convert.ToInt32(item));
            }

            if (SelectedW011List.Count == 0)
            {
                MessageBox.Show("하나 이상 선택하세요.");
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //전체 선택
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            //전체 해제
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
