using LINQMultipleFilter.Factory;
using LINQMultipleFilter.Filters;
using LINQMultipleFilter.Models;

namespace LINQMultipleFilter
{
    public partial class Form1 : Form
    {


        public UserFilter UserFilter { get; set; }
        public IEnumerable<User> UserList { get; set; }
        protected BindingSource GridBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            LoadData();     
          
        }

        protected void LoadData()
        {
            UserList = UserFactory.CreateUsersList();
            GridBindingSource.DataSource = UserList;
            dgvUsers.DataSource = GridBindingSource;

            UserFilter = new UserFilter();
            numMinAge.Value = UserFilter.Filter_MinAge;
            numMaxAge.Value = UserFilter.Filter_MaxAge;
            txtGeneralSearch.Text = UserFilter.Filter_GeneralTextSeach;
            chkBoxActive.Checked = UserFilter.Filter_OnlyActive;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            UserFilter.Filter_MinAge = (int)numMinAge.Value;
            UserFilter.Filter_MaxAge = (int)numMaxAge.Value;
            UserFilter.Filter_GeneralTextSeach = txtGeneralSearch.Text;
            UserFilter.Filter_OnlyActive = chkBoxActive.Checked;


            UserList = UserFilter.ApplyFilters(UserList);
            GridBindingSource.DataSource = UserList;
        
            dgvUsers.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}