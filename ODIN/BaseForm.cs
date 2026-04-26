using System.Windows.Forms;

namespace ODIN
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(245, 245, 245);
        }
    }
}
