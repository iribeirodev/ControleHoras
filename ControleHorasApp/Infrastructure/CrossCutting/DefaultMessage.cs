using System.Windows.Forms;
using ControleHorasApp.Infrastructure.Enums;

namespace ControleHorasApp.Infrastructure.CrossCutting
{
    public static class DefaultMessage
    {
        public static void ShowAlert(string text, string title = "")
        {
            if (string.IsNullOrEmpty(title)) title = "Atenção";

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void ShowInformation(string text, string title = "")
        {
            if (string.IsNullOrEmpty(title)) title = "Atenção";

            MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static EnumMessageAnswers ShowQuestion(string text, string title = "")
        {
            if (string.IsNullOrEmpty(title)) title = "Atenção";

            return (MessageBox.Show(text, title, 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.Yes 
                    ? EnumMessageAnswers.Yes 
                    : EnumMessageAnswers.No);
        }
    }
}
