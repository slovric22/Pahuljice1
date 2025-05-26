using Pahuljice1.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pahuljice1
{
    public partial class FrmKids : Form
    {
        public FrmKids()
        {
            InitializeComponent();
        }

        private void FrmKids_Load(object sender, EventArgs e)
        {
            List<Kid> kids = KidRepository.GetKids();
            DGVKids.DataSource = kids;

            DGVKids.Columns["Id"].DisplayIndex = 0;
            DGVKids.Columns["FirstName"].DisplayIndex = 1;
            DGVKids.Columns["LastName"].DisplayIndex = 2;
            DGVKids.Columns["OIB"].DisplayIndex = 3;
        }

        private void DGVKids_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
