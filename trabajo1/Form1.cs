using System.Diagnostics;
using System.Text.RegularExpressions;

namespace trabajo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {

            string nombre1,nombre2,apellido1,apellido2;

            nombre1 = txtNombre1.Text;
            nombre2=txtNombre2.Text;
            apellido1 = txtNombre1.Text;
            apellido2 = txtApellido2.Text;

                dataGridView1.Rows.Add(nombre1,nombre2,apellido1,apellido2);
          

            }
            catch (Exception)
            {
                if (txtNombre1.Text=="" && txtNombre2.Text==""&& txtApellidoP.Text==""&&txtApellido2.Text=="")
                {
                    MessageBox.Show("debe llenar los datos");
                }
                throw;
            }


        }

        private void txtNombre1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex exp = new Regex("^[^.]*[A-Za-z]+[^.]*$");
            if (exp.IsMatch(e.KeyChar.ToString())||e.KeyChar == (char)Keys.Back

                || e.KeyChar == (char)Keys.Delete)
            {
                Debug.Print("valido");

            }
            else
            {
                Debug.Print("N valido");
                e.Handled = true;

            }
        }

        private void txtNombre2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex exp = new Regex(@"^[a-zA-Z-]*$");
            if (exp.IsMatch(e.KeyChar.ToString()) || e.KeyChar == (char)Keys.Back

                || e.KeyChar == (char)Keys.Delete)
            {
                Debug.Print("valido");
            }
            else
            {
                toolStripStatusLabel1.Text = "Lo◘s numeros nos son validos en este campo";

                Debug.Print("N valido");
                e.Handled = true;

            }

        }

        private void txtApellidoP_KeyPress(object sender, KeyPressEventArgs e)
        {
         //   e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        
        }

        private void txtNombre2_Leave(object sender, EventArgs e)
        {

            Regex exp = new Regex("[-]");
            if (exp.IsMatch(txtNombre2.Text))
            {
                Debug.Print("N valido");
                if (txtNombre2.Text == "-")
                {

                    Debug.Print("dato valido .- en el texto");
                }
                 else MessageBox.Show("datos no validos en el texto");

            }
            else
            {
                Debug.Print("valido");
            }
        }
        ErrorProvider errorProvider1 = new ErrorProvider();
        
        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre1.Tag = "Escriba el nombre";
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            txtNombre2.Tag = "debe escribir el segundo nombre";
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;


        }

        private void txtNombre1_Validated(object sender, EventArgs e)
        {
            //btnAdd.Enabled = errorControls.Count == 0;

        }
        private void validateTextCharacter(object sender, EventArgs e)
        {
            
        }

        private bool textContainsUnallowedCharacter(string T, char[] UnallowedCharacters)
        {
            for (int i = 0; i < UnallowedCharacters.Length; i++)
                if (T.Contains(UnallowedCharacters[i]))
                    return true;

            return false;
        }

        private void txtApellido2_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtApellido2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex exp = new Regex("[-]");
            if (string.IsNullOrEmpty( txtApellido2.Text))
            {
                errorProvider1.SetError(txtApellido2, "El nombre no puede servacio");
                e.Cancel = true;
                return;
            }
            else
            {
               if (exp.IsMatch(txtApellido2.Text))
                    {
                    if (txtApellido2.Text == "-")
                    {
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                errorProvider1.SetError(txtApellido2, "El nombre no puede contener - y texto");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void txtNombre2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex exp = new Regex("[-]");
            if (string.IsNullOrEmpty(txtNombre2.Text))
            {
                errorProvider1.SetError(txtNombre2, "El nombre no puede servacio");
                e.Cancel = true;
                return;
            }
            else
            {
                if (exp.IsMatch(txtNombre2.Text))
                {
                    if (txtNombre2.Text == "-")
                    {
                        e.Cancel = false;
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(txtNombre2, "El nombre no puede contener - y texto");
                        e.Cancel = true;
                    }
                }
            }
        }

        private void txtNombre1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text)) 
            {
                textBox.Tag = "No puede ser vacio";
                errorProvider1.SetError(textBox, (string)textBox.Tag);
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox, null);
            }

        }
    }
}