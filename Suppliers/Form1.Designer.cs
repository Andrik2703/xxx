using System.Drawing;
using System.Windows.Forms;

namespace Suppliers
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            TXT_FAX = new TextBox();
            TXT_TEL = new TextBox();
            TXT_PAIS = new TextBox();
            TXT_CP = new TextBox();
            TXT_REGION = new TextBox();
            TXT_CIUDAD = new TextBox();
            TXT_DIRECCION = new TextBox();
            TXT_TITULO = new TextBox();
            TXT_CONTACTO = new TextBox();
            TXT_COMPAÑIA = new TextBox();
            TXT_IDSUPPLIER = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            LBL_1 = new Label();
            label4 = new Label();
            label2 = new Label();

            // Inicialización de botones
            BTN_INSERTAR = new Button();
            BTN_CARGAR = new Button();
            BTN_ACTUALIZAR = new Button();
            BTN_ELIMINAR = new Button();
            BTN_LIMPIAR = new Button();

            groupBox1.SuspendLayout();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(65, 61);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.Text = "ID supplier :";

            // groupBox1
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.AddRange(new Control[] {
                TXT_FAX, TXT_TEL, TXT_PAIS, TXT_CP, TXT_REGION, TXT_CIUDAD,
                TXT_DIRECCION, TXT_TITULO, TXT_CONTACTO, TXT_COMPAÑIA, TXT_IDSUPPLIER,
                label11, label10, label9, label8, label7, label6, label5,
                LBL_1, label4, label2, label1
            });
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(55, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(748, 519);
            groupBox1.Text = "DATOS DEL CLIENTE ";

            // Campos de texto
            TXT_IDSUPPLIER.Location = new Point(162, 58); TXT_IDSUPPLIER.Size = new Size(131, 27);
            TXT_COMPAÑIA.Location = new Point(162, 91); TXT_COMPAÑIA.Size = new Size(432, 27);
            TXT_CONTACTO.Location = new Point(162, 126); TXT_CONTACTO.Size = new Size(432, 27);
            TXT_TITULO.Location = new Point(162, 163); TXT_TITULO.Size = new Size(432, 27);
            TXT_DIRECCION.Location = new Point(162, 197); TXT_DIRECCION.Size = new Size(432, 27);
            TXT_CIUDAD.Location = new Point(162, 237); TXT_CIUDAD.Size = new Size(432, 27);
            TXT_REGION.Location = new Point(162, 278); TXT_REGION.Size = new Size(432, 27);
            TXT_CP.Location = new Point(162, 313); TXT_CP.Size = new Size(131, 27);
            TXT_PAIS.Location = new Point(162, 350); TXT_PAIS.Size = new Size(432, 27);
            TXT_TEL.Location = new Point(162, 388); TXT_TEL.Size = new Size(432, 27);
            TXT_FAX.Location = new Point(162, 424); TXT_FAX.Size = new Size(432, 27);

            // Labels
            label2.Location = new Point(65, 97); label2.Text = "Compañia:";
            label4.Location = new Point(65, 134); label4.Text = "Contacto:";
            LBL_1.Location = new Point(65, 170); LBL_1.Text = "Titulo:";
            label5.Location = new Point(65, 204); label5.Text = "Direccion:";
            label6.Location = new Point(65, 247); label6.Text = "Ciudad:";
            label7.Location = new Point(65, 280); label7.Text = "Region:";
            label8.Location = new Point(41, 319); label8.Text = "Codigo Postal:";
            label9.Location = new Point(65, 357); label9.Text = "Pais:";
            label10.Location = new Point(65, 390); label10.Text = "Telefono:";
            label11.Location = new Point(65, 427); label11.Text = "Fax:";

            // Botones
            BTN_INSERTAR.BackColor = SystemColors.ActiveBorder;
            BTN_INSERTAR.Location = new Point(64, 577);
            BTN_INSERTAR.Size = new Size(160, 40);
            BTN_INSERTAR.Text = "INSERTAR";

            BTN_CARGAR.BackColor = SystemColors.ActiveBorder;
            BTN_CARGAR.Location = new Point(255, 577);
            BTN_CARGAR.Size = new Size(160, 40);
            BTN_CARGAR.Text = "CARGAR";

            BTN_ACTUALIZAR.BackColor = SystemColors.ActiveBorder;
            BTN_ACTUALIZAR.Location = new Point(439, 577);
            BTN_ACTUALIZAR.Size = new Size(160, 40);
            BTN_ACTUALIZAR.Text = "ACTUALIZAR";

            BTN_ELIMINAR.BackColor = SystemColors.ActiveBorder;
            BTN_ELIMINAR.Location = new Point(617, 577);
            BTN_ELIMINAR.Size = new Size(160, 40);
            BTN_ELIMINAR.Text = "ELIMINAR";

            BTN_LIMPIAR.BackColor = SystemColors.ActiveBorder;
            BTN_LIMPIAR.Location = new Point(350, 626);
            BTN_LIMPIAR.Size = new Size(160, 40);
            BTN_LIMPIAR.Text = "LIMPIAR";

            // Asignar eventos
            BTN_INSERTAR.Click += new System.EventHandler(this.BTN_INSERTAR_Click);
            BTN_CARGAR.Click += new System.EventHandler(this.BTN_CARGAR_Click);
            BTN_ACTUALIZAR.Click += new System.EventHandler(this.BTN_ACTUALIZAR_Click);
            BTN_ELIMINAR.Click += new System.EventHandler(this.BTN_ELIMINAR_Click);
            BTN_LIMPIAR.Click += new System.EventHandler(this.BTN_LIMPIAR_Click);

            // Form1
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(866, 678);
            Controls.AddRange(new Control[] {
                BTN_ELIMINAR, BTN_LIMPIAR, BTN_ACTUALIZAR, BTN_CARGAR, BTN_INSERTAR, groupBox1
            });
            Name = "Form1";
            Text = "GESTION DE CLIENTES - SISTEMA CRM";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        // Componentes
        private Label label1, label2, label4, LBL_1, label5, label6, label7, label8, label9, label10, label11;
        private GroupBox groupBox1;
        private TextBox TXT_IDSUPPLIER, TXT_COMPAÑIA, TXT_CONTACTO, TXT_TITULO, TXT_DIRECCION, TXT_CIUDAD;
        private TextBox TXT_REGION, TXT_CP, TXT_PAIS, TXT_TEL, TXT_FAX;
        private Button BTN_INSERTAR, BTN_CARGAR, BTN_ACTUALIZAR, BTN_ELIMINAR, BTN_LIMPIAR;
    }
}

