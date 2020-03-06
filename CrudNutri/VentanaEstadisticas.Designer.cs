namespace CrudNutri {
    partial class VentanaEstadisticas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.chartSexo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizarGrafico = new System.Windows.Forms.Button();
            this.chartEdad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnActualizarGrafico1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEdad)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estadísticas";
            // 
            // chartSexo
            // 
            chartArea3.Name = "ChartArea1";
            this.chartSexo.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSexo.Legends.Add(legend3);
            this.chartSexo.Location = new System.Drawing.Point(20, 7);
            this.chartSexo.Margin = new System.Windows.Forms.Padding(4);
            this.chartSexo.Name = "chartSexo";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Mujeres";
            series6.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Hombres";
            this.chartSexo.Series.Add(series6);
            this.chartSexo.Series.Add(series7);
            this.chartSexo.Size = new System.Drawing.Size(741, 440);
            this.chartSexo.TabIndex = 1;
            this.chartSexo.Text = "chart1";
            // 
            // btnActualizarGrafico
            // 
            this.btnActualizarGrafico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrafico.Location = new System.Drawing.Point(654, 402);
            this.btnActualizarGrafico.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarGrafico.Name = "btnActualizarGrafico";
            this.btnActualizarGrafico.Size = new System.Drawing.Size(110, 42);
            this.btnActualizarGrafico.TabIndex = 2;
            this.btnActualizarGrafico.Text = "Actualizar";
            this.btnActualizarGrafico.UseVisualStyleBackColor = true;
            this.btnActualizarGrafico.Click += new System.EventHandler(this.btnActualizarGrafico_Click);
            // 
            // chartEdad
            // 
            chartArea4.Name = "ChartArea1";
            this.chartEdad.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartEdad.Legends.Add(legend4);
            this.chartEdad.Location = new System.Drawing.Point(7, 7);
            this.chartEdad.Margin = new System.Windows.Forms.Padding(4);
            this.chartEdad.Name = "chartEdad";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Menores de 18";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Entre 18 y 29";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Mayores de 30";
            this.chartEdad.Series.Add(series8);
            this.chartEdad.Series.Add(series9);
            this.chartEdad.Series.Add(series10);
            this.chartEdad.Size = new System.Drawing.Size(754, 437);
            this.chartEdad.TabIndex = 3;
            this.chartEdad.Text = "chart1";
            // 
            // btnActualizarGrafico1
            // 
            this.btnActualizarGrafico1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrafico1.Location = new System.Drawing.Point(654, 402);
            this.btnActualizarGrafico1.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizarGrafico1.Name = "btnActualizarGrafico1";
            this.btnActualizarGrafico1.Size = new System.Drawing.Size(110, 42);
            this.btnActualizarGrafico1.TabIndex = 4;
            this.btnActualizarGrafico1.Text = "Actualizar";
            this.btnActualizarGrafico1.UseVisualStyleBackColor = true;
            this.btnActualizarGrafico1.Click += new System.EventHandler(this.btnActualizarGrafico1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 480);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnActualizarGrafico);
            this.tabPage1.Controls.Add(this.chartSexo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sexo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnActualizarGrafico1);
            this.tabPage2.Controls.Add(this.chartEdad);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // VentanaEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentanaEstadisticas";
            this.Text = "VentanaEstadisticas";
            ((System.ComponentModel.ISupportInitialize)(this.chartSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartEdad)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSexo;
        private System.Windows.Forms.Button btnActualizarGrafico;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEdad;
        private System.Windows.Forms.Button btnActualizarGrafico1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}