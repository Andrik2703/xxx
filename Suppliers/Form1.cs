using System;
using System.Windows.Forms;

using ApplicationLogic;

namespace Suppliers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_INSERTAR_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = ObtenerDatosDesdeFormulario();
                supplier.Insert();
                MessageBox.Show("Proveedor insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void BTN_CARGAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TXT_IDSUPPLIER.Text, out int supplierID))
                {
                    SupplierManager supplier = new SupplierManager(supplierID);
                    if (supplier.Find())
                    {
                        TXT_COMPAÑIA.Text = supplier.CompanyName;
                        TXT_CONTACTO.Text = supplier.ContactName;
                        TXT_TITULO.Text = supplier.ContactTitle;
                        TXT_DIRECCION.Text = supplier.Address;
                        TXT_CIUDAD.Text = supplier.City;
                        TXT_REGION.Text = supplier.Region;
                        TXT_CP.Text = supplier.PostalCode;
                        TXT_PAIS.Text = supplier.Country;
                        TXT_TEL.Text = supplier.Phone;
                        TXT_FAX.Text = supplier.Fax;
                    }
                    else
                    {
                        MessageBox.Show("Proveedor no encontrado.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un ID válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }


        private void BTN_ACTUALIZAR_Click(object sender, EventArgs e)
        {
            try
            {
                var supplier = ObtenerDatosDesdeFormulario();
                if (supplier.Update())
                {
                    MessageBox.Show("Proveedor actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Debe ingresar un ID válido para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void BTN_ELIMINAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(TXT_IDSUPPLIER.Text, out int id))
                {
                    var supplier = new SupplierManager(id);
                    supplier.Delete();
                    MessageBox.Show("Proveedor eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ingrese un ID válido para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private SupplierManager ObtenerDatosDesdeFormulario()
        {
            return new SupplierManager
            (
                int.TryParse(TXT_IDSUPPLIER.Text, out int id) ? id : 0,
                TXT_COMPAÑIA.Text,
                TXT_CONTACTO.Text,
                TXT_TITULO.Text,
                TXT_DIRECCION.Text,
                TXT_CIUDAD.Text,
                TXT_REGION.Text,
                TXT_CP.Text,
                TXT_PAIS.Text,
                TXT_TEL.Text,
                TXT_FAX.Text,
                "" // o agrega un campo si usas HomePage
            );
        }

        private void MostrarDatosEnFormulario(SupplierManager s)
        {
            TXT_IDSUPPLIER.Text = s.Id.ToString();
            TXT_COMPAÑIA.Text = s.CompanyName;
            TXT_CONTACTO.Text = s.ContactName;
            TXT_TITULO.Text = s.ContactTitle;
            TXT_DIRECCION.Text = s.Address;
            TXT_CIUDAD.Text = s.City;
            TXT_REGION.Text = s.Region;
            TXT_CP.Text = s.PostalCode;
            TXT_PAIS.Text = s.Country;
            TXT_TEL.Text = s.Phone;
            TXT_FAX.Text = s.Fax;
        }

        private void BTN_LIMPIAR_Click(object sender, EventArgs e)
        {
            TXT_IDSUPPLIER.Clear();
            TXT_COMPAÑIA.Clear();
            TXT_CONTACTO.Clear();
            TXT_TITULO.Clear();
            TXT_DIRECCION.Clear();
            TXT_CIUDAD.Clear();
            TXT_REGION.Clear();
            TXT_CP.Clear();
            TXT_PAIS.Clear();
            TXT_TEL.Clear();
            TXT_FAX.Clear();
        }
    }
}
