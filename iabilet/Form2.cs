using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace iabilet
{
    public partial class Form2 : Form
    {
        private DataSet _dataSet;
        private SqlDataAdapter _childAdapter;
        private SqlDataAdapter _parentAdapter;
        private readonly string _parentTable = ConfigurationManager.AppSettings["ParentTable"];
        private readonly string _childTable = ConfigurationManager.AppSettings["ChildTable"];
        private static string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];
        private string parentPKColumn = ConfigurationManager.AppSettings["ParentPK"];
        private BindingSource parentBS = new BindingSource();
        private BindingSource childBS = new BindingSource();
        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            parentLabel.Text = _parentTable;
            childLabel.Text = _childTable;

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();

                    _dataSet = new DataSet();

                    _parentAdapter = new SqlDataAdapter("SELECT * FROM " + _parentTable,
                        connection);
                    _childAdapter = new SqlDataAdapter("SELECT * FROM " + _childTable,
                        connection);

                    _parentAdapter.Fill(_dataSet, _parentTable);
                    _childAdapter.Fill(_dataSet, _childTable);

                    parentBS.DataSource = _dataSet.Tables[_parentTable];
                    parentDataGridView.DataSource = parentBS;
                    
                    DataColumn parentPK = _dataSet.Tables[_parentTable].Columns[parentPKColumn];

                    string childFKColumn = ConfigurationManager.AppSettings["ChildFK"];
                    DataColumn childFK = _dataSet.Tables[_childTable].Columns[childFKColumn];

                    DataRelation relation = new DataRelation("fk_parent_child", parentPK, childFK);
                    _dataSet.Relations.Add(relation);
                    
                    childBS.DataSource = parentBS;
                    childBS.DataMember = "fk_parent_child";
                    childDataGridView.DataSource = childBS;
                
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            _dataSet.Clear();
            _parentAdapter.Fill(_dataSet.Tables[_parentTable]);
            _childAdapter.Fill(_dataSet.Tables[_childTable]);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder parentCommandBuilder = new SqlCommandBuilder(_parentAdapter);
                SqlCommandBuilder childCommandBuilder = new SqlCommandBuilder(_childAdapter);
                
                _childAdapter.Update(_dataSet.Tables[_childTable]);
                _parentAdapter.Update(_dataSet.Tables[_parentTable]);
                
                _dataSet.Clear();
                _parentAdapter.Fill(_dataSet.Tables[_parentTable]);
                _childAdapter.Fill(_dataSet.Tables[_childTable]);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}