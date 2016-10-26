using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AWA_Partition
{
    public partial class Form1 : Form
    {
        List<Group> previousGroups;
        CheckState toggleCheckState = CheckState.Checked;

        public Form1()
        {
            InitializeComponent();
            foreach (var item in PartitionUtils.AllStudents)
            {
                checkedListBoxStudents.Items.Add(item, true);
            }
            if (toggleCheckState == CheckState.Checked)
                buttonCheckUncheck.Text = "Uncheck All";
            else
                buttonCheckUncheck.Text = "Check All";
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int peoplePerGroup;
            try
            {
                peoplePerGroup = int.Parse(textBoxNumPeople.Text);
                if (peoplePerGroup < 1)
                    throw new Exception("Du måste ha minst en person per grupp!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalid Data");
                return;
            }

            var selectedStudents = checkedListBoxStudents.CheckedItems.OfType<Person>().ToList();

            var Groups = PartitionUtils.GroupUp(selectedStudents, peoplePerGroup);
            listBoxGroups.Items.Clear();
            foreach (var group in Groups)
            {
                listBoxGroups.Items.Add(group.ToString());
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Todo: Save to disk.
        }

        private void buttonToggleCheckbox_Click(object sender, EventArgs e)
        {
            int count = checkedListBoxStudents.Items.Count;
            for (int i = 0; i < count; i++)
            {
                var state = checkedListBoxStudents.GetItemCheckState(i);
                if (state == CheckState.Unchecked)
                    checkedListBoxStudents.SetItemCheckState(i, CheckState.Checked);
                if (state == CheckState.Checked)
                    checkedListBoxStudents.SetItemCheckState(i, CheckState.Unchecked);
            }
        }

        private void buttonCheckUncheck_Click(object sender, EventArgs e)
        {
            if(toggleCheckState == CheckState.Checked)
            {
                for (int i = 0; i < checkedListBoxStudents.Items.Count; i++)
                {
                    checkedListBoxStudents.SetItemCheckState(i, CheckState.Unchecked);
                }
                buttonCheckUncheck.Text = "Check All";
                toggleCheckState = CheckState.Unchecked;
            }
            else
            {
                for (int i = 0; i < checkedListBoxStudents.Items.Count; i++)
                {
                    checkedListBoxStudents.SetItemCheckState(i, CheckState.Checked);
                }
                buttonCheckUncheck.Text = "Uncheck";
                toggleCheckState = CheckState.Checked;
            }
        }
    }
}
