using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Serialization.Model;
namespace Serialization.Forms
{
    public partial class WorkForm : Form
    {
        List<Assembly> assemblies = new List<Assembly>();
        List<AssemblySimple> assembliesSimple = new List<AssemblySimple>();

        List<Type> types = new List<Type>();
        List<TypeSimple> typesSimple = new List<TypeSimple>();

        Type selectedType = null;
        public WorkForm()
        {
            InitializeComponent();
        }

        private void WorkForm_Load(object sender, EventArgs e)
        {
            this.AssembilesLoad();
        }

        /// <summary>
        /// Загрузить сборки решения.
        /// </summary>
        private void AssembilesLoad()
        {
            assemblies.Clear();
            assembliesSimple.Clear();
            foreach (var item in Assembly.GetExecutingAssembly().GetReferencedAssemblies())
            {
                Assembly loaded = Assembly.Load(item);
                assemblies.Add(loaded);
                assembliesSimple.Add(loaded);
            }
            this.TableInit(AssembliesTbl, assembliesSimple);
        }

        /// <summary>
        /// Заполнить таблицу начениями.
        /// </summary>
        /// <param name="tbl"></param>
        /// <param name="content"></param>
        private void TableInit(DataGridView tbl, object content)
        {
            tbl.DataSource = null;
            tbl.DataSource = content;
            //MessageBox.Show(tbl.RowCount.ToString());
        }

        /// <summary>
        /// Клик по строке таблицы сборок.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AssembliesTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            Assembly selectedAssembly = SelectItem<Assembly>(name);
            this.TypesLoad(selectedAssembly);
        }

        /// <summary>
        /// Загрузить
        /// </summary>
        /// <param name="assembly"></param>
        private void TypesLoad(Assembly assembly)
        {
            types.Clear();
            typesSimple.Clear();
            if (assembly == null)
            {
                MessageBox.Show(string.Format("Сборка не найдена."));
                return;
            }
            types = assembly.GetTypes().ToList();
            foreach (var item in types)
            {
                typesSimple.Add(item);
            }
            this.TableInit(TypesTbl, typesSimple);
        }

        /// <summary>
        /// Подобрать элемент из справочника.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name"></param>
        /// <returns></returns>
        private T SelectItem<T>(string name) where T : class
        {
            T result = null;
            if(typeof(T) == typeof(Assembly))
            {
                result = assemblies.Where(a => a.FullName == name).FirstOrDefault() as T;
            }

            if(typeof(T) == typeof(Type))
            {
                result = types.Where(t => t.FullName == name).FirstOrDefault() as T;
            }

            return result;
        }

        /// <summary>
        /// Клик по таблице с классами.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypesTbl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string name = (sender as DataGridView).Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedType = SelectItem<Type>(name);

            MessageBox.Show(string.Format("{0}", selectedType));
        }
    }
}
