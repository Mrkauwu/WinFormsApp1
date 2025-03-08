namespace WinFormsApp1.Views
{
    partial class PetView
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
            tabControl1 = new TabControl();
            tabPagePetList = new TabPage();
            btnClose = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dataGridView = new DataGridView();
            tabPagePetDetail = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            txtPetName = new TextBox();
            txtPetColor = new TextBox();
            txtPetType = new TextBox();
            txtPetId = new TextBox();
            tabControl1.SuspendLayout();
            tabPagePetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePetList);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPagePetList
            // 
            tabPagePetList.Controls.Add(btnClose);
            tabPagePetList.Controls.Add(btnDelete);
            tabPagePetList.Controls.Add(btnEdit);
            tabPagePetList.Controls.Add(btnAdd);
            tabPagePetList.Controls.Add(btnSearch);
            tabPagePetList.Controls.Add(txtSearch);
            tabPagePetList.Controls.Add(dataGridView);
            tabPagePetList.Location = new Point(4, 24);
            tabPagePetList.Name = "tabPagePetList";
            tabPagePetList.Padding = new Padding(3);
            tabPagePetList.Size = new Size(792, 422);
            tabPagePetList.TabIndex = 0;
            tabPagePetList.Text = "Pet List";
            tabPagePetList.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Location = new Point(630, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(39, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(594, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(594, 63);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(594, 34);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(513, 5);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(6, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(501, 23);
            txtSearch.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(6, 34);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(582, 380);
            dataGridView.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Controls.Add(label2);
            tabPagePetDetail.Controls.Add(label1);
            tabPagePetDetail.Controls.Add(btnCancel);
            tabPagePetDetail.Controls.Add(btnSave);
            tabPagePetDetail.Controls.Add(txtPetName);
            tabPagePetDetail.Controls.Add(txtPetColor);
            tabPagePetDetail.Controls.Add(txtPetType);
            tabPagePetDetail.Controls.Add(txtPetId);
            tabPagePetDetail.Location = new Point(4, 24);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(792, 422);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet Detail";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 118);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 2;
            label4.Text = "Pet Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 164);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Pet Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 118);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Pet Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 70);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "Pet ID";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(410, 259);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            
            // 
            // btnSave
            // 
            btnSave.Location = new Point(256, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(256, 136);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 0;
            // 
            // txtPetColor
            // 
            txtPetColor.Location = new Point(256, 182);
            txtPetColor.Name = "txtPetColor";
            txtPetColor.Size = new Size(100, 23);
            txtPetColor.TabIndex = 0;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(398, 136);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 0;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(256, 88);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(100, 23);
            txtPetId.TabIndex = 0;
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "PetView";
            Text = "PetView";
            tabControl1.ResumeLayout(false);
            tabPagePetList.ResumeLayout(false);
            tabPagePetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPagePetList;
        private TabPage tabPagePetDetail;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dataGridView;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtPetName;
        private TextBox txtPetColor;
        private TextBox txtPetType;
        private TextBox txtPetId;
        private Button btnClose;
    }
}