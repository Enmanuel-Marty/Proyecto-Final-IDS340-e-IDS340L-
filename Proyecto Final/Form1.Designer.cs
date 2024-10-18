namespace Proyecto_Final
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.Codigo_producto = new System.Windows.Forms.TextBox();
            this.id_producto = new System.Windows.Forms.TextBox();
            this.Nom_Producto = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Proveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(5, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario de productos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enmanuel Marty(ID:1122526)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar producto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Eliminar producto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(170, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 32);
            this.button3.TabIndex = 4;
            this.button3.Text = "Editar producto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(761, 198);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(603, 428);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 32);
            this.button8.TabIndex = 11;
            this.button8.Text = "Salir";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Codigo_producto
            // 
            this.Codigo_producto.Location = new System.Drawing.Point(12, 136);
            this.Codigo_producto.Name = "Codigo_producto";
            this.Codigo_producto.Size = new System.Drawing.Size(228, 22);
            this.Codigo_producto.TabIndex = 12;
            this.Codigo_producto.TextChanged += new System.EventHandler(this.Codigo_producto_TextChanged);
            // 
            // id_producto
            // 
            this.id_producto.Location = new System.Drawing.Point(14, 59);
            this.id_producto.Name = "id_producto";
            this.id_producto.Size = new System.Drawing.Size(228, 22);
            this.id_producto.TabIndex = 13;
            // 
            // Nom_Producto
            // 
            this.Nom_Producto.Location = new System.Drawing.Point(12, 95);
            this.Nom_Producto.Name = "Nom_Producto";
            this.Nom_Producto.Size = new System.Drawing.Size(228, 22);
            this.Nom_Producto.TabIndex = 14;
            this.Nom_Producto.TextChanged += new System.EventHandler(this.Nom_Producto_TextChanged_1);
            // 
            // Categoria
            // 
            this.Categoria.Location = new System.Drawing.Point(10, 174);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(228, 22);
            this.Categoria.TabIndex = 17;
            // 
            // Precio
            // 
            this.Precio.Location = new System.Drawing.Point(401, 62);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(228, 22);
            this.Precio.TabIndex = 16;
            // 
            // Cantidad
            // 
            this.Cantidad.Location = new System.Drawing.Point(400, 93);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(228, 22);
            this.Cantidad.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(258, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nombre del producto";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(634, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cantidad del producto";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Id de Categoria del producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Precio del producto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(258, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Codigo del producto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "ID del producto";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(634, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Id del proveedor del producto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Proveedor
            // 
            this.Proveedor.Location = new System.Drawing.Point(400, 130);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(228, 22);
            this.Proveedor.TabIndex = 25;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(830, 487);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Proveedor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Nom_Producto);
            this.Controls.Add(this.id_producto);
            this.Controls.Add(this.Codigo_producto);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox Codigo_producto;
        private System.Windows.Forms.TextBox id_producto;
        private System.Windows.Forms.TextBox Nom_Producto;
        private System.Windows.Forms.TextBox Categoria;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Proveedor;
    }
}

