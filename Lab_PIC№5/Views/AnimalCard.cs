using Lab_PIC_5.Controllers;
using Lab_PIC_5.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_PIC_5.Views
{
    public partial class AnimalCardForm : Form
    {
        private int actId;
        public string[] returnAnime;
        public AnimalCardForm(string act)
        {
            InitializeComponent();
            GITLER.Text = act;
            actId = (ActRepository.acts.Max(x => x.ActNumber));
            InicilisateAll();
        }

        private void InicilisateAll()
        {
            God.Text = "Акт:" + actId;
            comboBoxLocation.DataSource = new BindingSource(
                                    LocationCostReposiroty.locationCosts, null);
            comboBoxLocation.DisplayMember = "City";
            comboBoxLocation.ValueMember = "IdLocation";
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if (ChekOtvet())
            {
                var otp = new string[] { textBoxKategori.Text, textBoxGender.Text,
                                        textBoxPoroda.Text, numericUpDownSize.Value.ToString(),
                                        textBoxFurType.Text, textBoxColor.Text, textBoxEars.Text,
                                        textBoxTail.Text, textBoxSpicialSigns.Text, textBoxIdentificationLabel.Text,
                                        comboBoxLocation.SelectedValue.ToString(), actId.ToString(),null};
                returnAnime = otp;
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool ChekOtvet()
        {
            if (textBoxPoroda.Text == "")
            {
                MessageBox.Show("Вы не ввели породу ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
