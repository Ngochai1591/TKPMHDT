using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Food_Order_Manager.StatePattern
{
    class Error:State
    {
        public void handleRequest()
        {
            MessageBox.Show("Không thành công \n Vui lòng thực hiện lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
