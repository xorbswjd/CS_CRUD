using System.Drawing;

namespace CS_Form
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cclass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Read_btn = new System.Windows.Forms.Button();
            this.Ceate_btn = new System.Windows.Forms.Button();
            this.Update_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grade,
            this.cclass,
            this.no,
            this.name,
            this.score});
            this.dataGridView1.Location = new System.Drawing.Point(0, 10);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 20;
            this.dataGridView1.Size = new System.Drawing.Size(590, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // grade
            // 
            this.grade.HeaderText = "grade";
            this.grade.MinimumWidth = 8;
            this.grade.Name = "grade";
            this.grade.Width = 60;
            // 
            // cclass
            // 
            this.cclass.HeaderText = "cclass";
            this.cclass.MinimumWidth = 8;
            this.cclass.Name = "cclass";
            this.cclass.Width = 60;
            // 
            // no
            // 
            this.no.HeaderText = "no";
            this.no.MinimumWidth = 8;
            this.no.Name = "no";
            this.no.Width = 60;
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 60;
            // 
            // score
            // 
            this.score.HeaderText = "score";
            this.score.MinimumWidth = 8;
            this.score.Name = "score";
            this.score.Width = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.Read_btn);
            this.panel2.Controls.Add(this.Ceate_btn);
            this.panel2.Controls.Add(this.Update_btn);
            this.panel2.Controls.Add(this.Remove_btn);
            this.panel2.Location = new System.Drawing.Point(600, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 430);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.Read_btn.Location = new System.Drawing.Point(25, 60);
            this.Read_btn.Name = "button1";
            this.Read_btn.Size = new System.Drawing.Size(140, 40);
            this.Read_btn.TabIndex = 0;
            this.Read_btn.Text = "Read";
            this.Read_btn.UseVisualStyleBackColor = true;
            this.Read_btn.Click += new System.EventHandler(this.Read_Click);
            // 
            // button2
            // 
            this.Ceate_btn.Location = new System.Drawing.Point(25, 140);
            this.Ceate_btn.Name = "button2";
            this.Ceate_btn.Size = new System.Drawing.Size(140, 40);
            this.Ceate_btn.TabIndex = 1;
            this.Ceate_btn.Text = "Create";
            this.Ceate_btn.UseVisualStyleBackColor = true;
            this.Ceate_btn.Click += new System.EventHandler(this.Create_Click);
            // 
            // button3
            // 
            this.Update_btn.Location = new System.Drawing.Point(25, 220);
            this.Update_btn.Name = "button3";
            this.Update_btn.Size = new System.Drawing.Size(140, 40);
            this.Update_btn.TabIndex = 2;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_Click);
            // 
            // button4
            // 
            this.Remove_btn.Location = new System.Drawing.Point(25, 300);
            this.Remove_btn.Name = "button4";
            this.Remove_btn.Size = new System.Drawing.Size(140, 40);
            this.Remove_btn.TabIndex = 3;
            this.Remove_btn.Text = "Remove";
            this.Remove_btn.UseVisualStyleBackColor = true;
            this.Remove_btn.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Read_btn;
        private System.Windows.Forms.Button Ceate_btn;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn cclass;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
    }
}

