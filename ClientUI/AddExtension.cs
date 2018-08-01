using System.Windows.Forms;

namespace ClientUI
{
    public partial class AddExtension : Form
    {
        private AddExtension()
        {
            InitializeComponent();
        }

        public static string Execute()
        {
            using (var inputBox = new AddExtension())
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                    return inputBox.tbExtension.Text;

                return null;
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}