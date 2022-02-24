using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsContacts
{
    public partial class ContactDetails : Form
    {
        private BusinessLogicLayer _businessLogicLayer; // le pongo _ a la variable porque es global y por convencion va asi
        private Contact _contact;
        public ContactDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer(); //creo un objeto de la capa de negocio para poder acceder a sus metodos
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveContact();
            this.Close();
            ((Main)this.Owner).PopulateContacts();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveContact()
        {
            Contact contact = new Contact();
            contact.FirstName = textFirstName.Text;
            contact.LastName = textLastName.Text;
            contact.Phone = textPhone.Text;
            contact.Address = textAddress.Text;

            contact.Id = _contact != null ? _contact.Id : 0;

            _businessLogicLayer.SaveContact(contact);
        }

        public void LoadContact(Contact contact)
        {
            _contact = contact;
            if(contact != null)
            {
                ClearForm();
                textFirstName.Text = contact.FirstName;
                textLastName.Text = contact.LastName;
                textPhone.Text = contact.Phone;
                textAddress.Text = contact.Address;
            }
        }
        private void ClearForm()
        {
            textFirstName.Text = string.Empty;
            textLastName.Text = string.Empty;
            textPhone.Text = string.Empty;
            textAddress.Text = string.Empty;
        }
    }
}
