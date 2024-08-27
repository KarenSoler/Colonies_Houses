using Colonies.Models;
using Colonies.Servicesa;
using System;
using System.Windows.Forms;

namespace Colonies
{
    public partial class Form1 : Form
    {
        private readonly HouseService _houseService;

        // Constructor de la clase
        public Form1(HouseService houseService)
        {
            InitializeComponent();
            _houseService = houseService;
        }

        // Componentes de la interfaz
        private System.ComponentModel.IContainer components = null;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtPostalAddress;
        private TextBox txtPostalCode;
        private TextBox txtNameStreet;
        private TextBox txtCapacity;
        private TextBox txtRegiId;
        private Button btnAdd;
        private Button btnGet;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label lblId;
        private Label lblName;
        private Label lblPostalAddress;
        private Label lblPostalCode;
        private Label lblNameStreet;
        private Label lblCapacity;
        private Label lblRegiId;
        private Label lblTitle;

        // Inicializa los componentes de la interfaz
        private void InitializeComponent()
        {
            this.txtId = new TextBox();
            this.txtName = new TextBox();
            this.txtPostalAddress = new TextBox();
            this.txtPostalCode = new TextBox();
            this.txtNameStreet = new TextBox();
            this.txtCapacity = new TextBox();
            this.txtRegiId = new TextBox();
            this.btnAdd = new Button();
            this.btnGet = new Button();
            this.btnUpdate = new Button();
            this.btnDelete = new Button();
            this.btnClear = new Button();
            this.lblId = new Label();
            this.lblName = new Label();
            this.lblPostalAddress = new Label();
            this.lblPostalCode = new Label();
            this.lblNameStreet = new Label();
            this.lblCapacity = new Label();
            this.lblRegiId = new Label();
            this.lblTitle = new Label();
            this.SuspendLayout();

            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(150, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(150, 20);
            this.txtId.TabIndex = 0;

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 20);
            this.txtName.TabIndex = 1;

            // 
            // txtPostalAddress
            // 
            this.txtPostalAddress.Location = new System.Drawing.Point(150, 100);
            this.txtPostalAddress.Name = "txtPostalAddress";
            this.txtPostalAddress.Size = new System.Drawing.Size(250, 20);
            this.txtPostalAddress.TabIndex = 2;

            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Location = new System.Drawing.Point(150, 130);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(150, 20);
            this.txtPostalCode.TabIndex = 3;

            // 
            // txtNameStreet
            // 
            this.txtNameStreet.Location = new System.Drawing.Point(150, 160);
            this.txtNameStreet.Name = "txtNameStreet";
            this.txtNameStreet.Size = new System.Drawing.Size(250, 20);
            this.txtNameStreet.TabIndex = 4;

            // 
            // txtCapacity
            // 
            this.txtCapacity.Location = new System.Drawing.Point(150, 190);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(150, 20);
            this.txtCapacity.TabIndex = 5;

            // 
            // txtRegiId
            // 
            this.txtRegiId.Location = new System.Drawing.Point(150, 220);
            this.txtRegiId.Name = "txtRegiId";
            this.txtRegiId.Size = new System.Drawing.Size(150, 20);
            this.txtRegiId.TabIndex = 6;

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(30, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(110, 260);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 30);
            this.btnGet.TabIndex = 8;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(190, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(270, 260);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightGray;
            this.btnClear.Location = new System.Drawing.Point(350, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(30, 43);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 12;
            this.lblId.Text = "ID";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(30, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblPostalAddress
            // 
            this.lblPostalAddress.AutoSize = true;
            this.lblPostalAddress.Location = new System.Drawing.Point(30, 103);
            this.lblPostalAddress.Name = "lblPostalAddress";
            this.lblPostalAddress.Size = new System.Drawing.Size(85, 13);
            this.lblPostalAddress.TabIndex = 14;
            this.lblPostalAddress.Text = "Postal Address";
            this.lblPostalAddress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Location = new System.Drawing.Point(30, 133);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(68, 13);
            this.lblPostalCode.TabIndex = 15;
            this.lblPostalCode.Text = "Postal Code";
            this.lblPostalCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblNameStreet
            // 
            this.lblNameStreet.AutoSize = true;
            this.lblNameStreet.Location = new System.Drawing.Point(30, 163);
            this.lblNameStreet.Name = "lblNameStreet";
            this.lblNameStreet.Size = new System.Drawing.Size(73, 13);
            this.lblNameStreet.TabIndex = 16;
            this.lblNameStreet.Text = "Name Street";
            this.lblNameStreet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(30, 193);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 17;
            this.lblCapacity.Text = "Capacity";
            this.lblCapacity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblRegiId
            // 
            this.lblRegiId.AutoSize = true;
            this.lblRegiId.Location = new System.Drawing.Point(30, 223);
            this.lblRegiId.Name = "lblRegiId";
            this.lblRegiId.Size = new System.Drawing.Size(45, 13);
            this.lblRegiId.TabIndex = 18;
            this.lblRegiId.Text = "Regi ID";
            this.lblRegiId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(150, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 20);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "House Manager";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(450, 300);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblRegiId);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblNameStreet);
            this.Controls.Add(this.lblPostalCode);
            this.Controls.Add(this.lblPostalAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtRegiId);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtNameStreet);
            this.Controls.Add(this.txtPostalCode);
            this.Controls.Add(this.txtPostalAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Name = "Form1";
            this.Text = "House Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Método para agregar una casa
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPostalCode.Text.Trim(), out int postalCode) &&
                int.TryParse(txtCapacity.Text.Trim(), out int capacity) &&
                int.TryParse(txtRegiId.Text.Trim(), out int regiId))
            {
                var houseDTO = new HouseDTO
                {
                    //HouseId = int.Parse(txtId.Text.Trim()),
                    HouseName = txtName.Text.Trim(),
                    PostalAddress = txtPostalAddress.Text.Trim(),
                    PostalCode = postalCode,
                    NameStreet = txtNameStreet.Text.Trim(),
                    Capacity = capacity,
                    RegiId = regiId
                };
                try
                {
                    _houseService.AddHouse(houseDTO);
                    MessageBox.Show("House added successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding house: {ex.Message}");
                }                
            }
            else
            {
                MessageBox.Show("Please enter valid numbers for Postal Code, Capacity, and Regi ID.");
            }
        }

        // Método para obtener una casa
        private void btnGet_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text.Trim(), out int id))
            {
                var house = _houseService.GetHouseById(id);
                if (house != null)
                {
                    txtName.Text = house.HouseName;
                    txtPostalAddress.Text = house.PostalAddress;
                    txtPostalCode.Text = house.PostalCode.ToString();
                    txtNameStreet.Text = house.NameStreet;
                    txtCapacity.Text = house.Capacity.ToString();
                    txtRegiId.Text = house.RegiId.ToString();
                }
                else
                {
                    MessageBox.Show("House not found.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }

        // Método para actualizar una casa
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de datos de entrada
                if (string.IsNullOrWhiteSpace(txtPostalCode.Text) ||
                    string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                    string.IsNullOrWhiteSpace(txtRegiId.Text) ||
                    !int.TryParse(txtPostalCode.Text.Trim(), out int postalCode) ||
                    !int.TryParse(txtCapacity.Text.Trim(), out int capacity) ||
                    !int.TryParse(txtRegiId.Text.Trim(), out int regiId))
                {
                    MessageBox.Show("Please enter valid numbers for Postal Code, Capacity, and Regi ID.");
                    return;
                }

                // Continúa con el procesamiento si los datos son válidos
                var houseDTO = new HouseDTO
                {
                    HouseId = int.Parse(txtId.Text.Trim()),
                    HouseName = txtName.Text.Trim(),
                    PostalAddress = txtPostalAddress.Text.Trim(),
                    PostalCode = postalCode,
                    NameStreet = txtNameStreet.Text.Trim(),
                    Capacity = capacity,
                    RegiId = regiId
                };

                _houseService.UpdateHouse(houseDTO);
                MessageBox.Show("House updated successfully.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Format exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        // Método para eliminar una casa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtId.Text.Trim(), out int id))
            {
                try
                {
                    _houseService.DeleteHouse(id);
                    MessageBox.Show("House deleted successfully.");
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show($"Error deleting house: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }


        // Método para limpiar los campos de texto
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPostalAddress.Clear();
            txtPostalCode.Clear();
            txtNameStreet.Clear();
            txtCapacity.Clear();
            txtRegiId.Clear();
        }
    }
}
