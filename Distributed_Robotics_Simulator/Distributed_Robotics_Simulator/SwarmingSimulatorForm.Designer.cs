namespace Distributed_Robotics_Simulator
{
    partial class SwarmingSimulatorForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSimulation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxAgent = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAvoidanceRange = new System.Windows.Forms.Label();
            this.textBoxAvoidanceRange = new System.Windows.Forms.TextBox();
            this.textBoxSensorRange = new System.Windows.Forms.TextBox();
            this.labelSensorRange = new System.Windows.Forms.Label();
            this.labelMaxVel = new System.Windows.Forms.Label();
            this.textBoxMaxVel = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.labelAgentRadius = new System.Windows.Forms.Label();
            this.labelNumAgents = new System.Windows.Forms.Label();
            this.textBoxNumAgents = new System.Windows.Forms.TextBox();
            this.groupBoxBehaviors = new System.Windows.Forms.GroupBox();
            this.labelAvoidanceWeight = new System.Windows.Forms.Label();
            this.textBoxAvoidanceWeight = new System.Windows.Forms.TextBox();
            this.labelAggregationWeight = new System.Windows.Forms.Label();
            this.textBoxAggregationWeight = new System.Windows.Forms.TextBox();
            this.labelHomingLineWeight = new System.Windows.Forms.Label();
            this.textBoxHomingLineWeight = new System.Windows.Forms.TextBox();
            this.labelHomePointWeight = new System.Windows.Forms.Label();
            this.textBoxHomingPointWeight = new System.Windows.Forms.TextBox();
            this.checkBoxAvoidance = new System.Windows.Forms.CheckBox();
            this.checkBoxAggregation = new System.Windows.Forms.CheckBox();
            this.checkBoxHomingLine = new System.Windows.Forms.CheckBox();
            this.checkBoxHoming = new System.Windows.Forms.CheckBox();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.labelMap = new System.Windows.Forms.Label();
            this.textBoxMap = new System.Windows.Forms.TextBox();
            this.buttonStepSolution = new System.Windows.Forms.Button();
            this.buttonSimulate = new System.Windows.Forms.Button();
            this.textBoxTimeStep = new System.Windows.Forms.TextBox();
            this.labelTimeStep = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCheckValues = new System.Windows.Forms.Button();
            this.labelDebug = new System.Windows.Forms.Label();
            this.labelNumTimeSteps = new System.Windows.Forms.Label();
            this.textBoxNumTimeSteps = new System.Windows.Forms.TextBox();
            this.labelTimeElapsed = new System.Windows.Forms.Label();
            this.labelCurrentTimeStep = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartSimulation)).BeginInit();
            this.groupBoxAgent.SuspendLayout();
            this.groupBoxBehaviors.SuspendLayout();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartSimulation
            // 
            chartArea1.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartSimulation.ChartAreas.Add(chartArea1);
            this.chartSimulation.Location = new System.Drawing.Point(12, 587);
            this.chartSimulation.Name = "chartSimulation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "map";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Name = "agents";
            this.chartSimulation.Series.Add(series1);
            this.chartSimulation.Series.Add(series2);
            this.chartSimulation.Size = new System.Drawing.Size(1114, 609);
            this.chartSimulation.TabIndex = 0;
            this.chartSimulation.Text = "chart1";
            // 
            // groupBoxAgent
            // 
            this.groupBoxAgent.Controls.Add(this.label4);
            this.groupBoxAgent.Controls.Add(this.label3);
            this.groupBoxAgent.Controls.Add(this.label2);
            this.groupBoxAgent.Controls.Add(this.label1);
            this.groupBoxAgent.Controls.Add(this.labelAvoidanceRange);
            this.groupBoxAgent.Controls.Add(this.textBoxAvoidanceRange);
            this.groupBoxAgent.Controls.Add(this.textBoxSensorRange);
            this.groupBoxAgent.Controls.Add(this.labelSensorRange);
            this.groupBoxAgent.Controls.Add(this.labelMaxVel);
            this.groupBoxAgent.Controls.Add(this.textBoxMaxVel);
            this.groupBoxAgent.Controls.Add(this.textBoxRadius);
            this.groupBoxAgent.Controls.Add(this.labelAgentRadius);
            this.groupBoxAgent.Controls.Add(this.labelNumAgents);
            this.groupBoxAgent.Controls.Add(this.textBoxNumAgents);
            this.groupBoxAgent.Location = new System.Drawing.Point(12, 17);
            this.groupBoxAgent.Name = "groupBoxAgent";
            this.groupBoxAgent.Size = new System.Drawing.Size(285, 377);
            this.groupBoxAgent.TabIndex = 1;
            this.groupBoxAgent.TabStop = false;
            this.groupBoxAgent.Text = "Agent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "(m)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "(m)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "(m)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "(m/s)";
            // 
            // labelAvoidanceRange
            // 
            this.labelAvoidanceRange.AutoSize = true;
            this.labelAvoidanceRange.Location = new System.Drawing.Point(11, 294);
            this.labelAvoidanceRange.Name = "labelAvoidanceRange";
            this.labelAvoidanceRange.Size = new System.Drawing.Size(259, 25);
            this.labelAvoidanceRange.TabIndex = 7;
            this.labelAvoidanceRange.Text = "Agent\'s Avoidance Range";
            // 
            // textBoxAvoidanceRange
            // 
            this.textBoxAvoidanceRange.Location = new System.Drawing.Point(16, 322);
            this.textBoxAvoidanceRange.Name = "textBoxAvoidanceRange";
            this.textBoxAvoidanceRange.Size = new System.Drawing.Size(124, 31);
            this.textBoxAvoidanceRange.TabIndex = 6;
            // 
            // textBoxSensorRange
            // 
            this.textBoxSensorRange.Location = new System.Drawing.Point(16, 259);
            this.textBoxSensorRange.Name = "textBoxSensorRange";
            this.textBoxSensorRange.Size = new System.Drawing.Size(124, 31);
            this.textBoxSensorRange.TabIndex = 5;
            // 
            // labelSensorRange
            // 
            this.labelSensorRange.AutoSize = true;
            this.labelSensorRange.Location = new System.Drawing.Point(11, 230);
            this.labelSensorRange.Name = "labelSensorRange";
            this.labelSensorRange.Size = new System.Drawing.Size(226, 25);
            this.labelSensorRange.TabIndex = 2;
            this.labelSensorRange.Text = "Agent\'s Sensor Range";
            // 
            // labelMaxVel
            // 
            this.labelMaxVel.AutoSize = true;
            this.labelMaxVel.Location = new System.Drawing.Point(11, 167);
            this.labelMaxVel.Name = "labelMaxVel";
            this.labelMaxVel.Size = new System.Drawing.Size(198, 25);
            this.labelMaxVel.TabIndex = 2;
            this.labelMaxVel.Text = "Maxiumum Velocity";
            // 
            // textBoxMaxVel
            // 
            this.textBoxMaxVel.Location = new System.Drawing.Point(16, 195);
            this.textBoxMaxVel.Name = "textBoxMaxVel";
            this.textBoxMaxVel.Size = new System.Drawing.Size(124, 31);
            this.textBoxMaxVel.TabIndex = 4;
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Location = new System.Drawing.Point(16, 132);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(124, 31);
            this.textBoxRadius.TabIndex = 3;
            // 
            // labelAgentRadius
            // 
            this.labelAgentRadius.AutoSize = true;
            this.labelAgentRadius.Location = new System.Drawing.Point(11, 104);
            this.labelAgentRadius.Name = "labelAgentRadius";
            this.labelAgentRadius.Size = new System.Drawing.Size(141, 25);
            this.labelAgentRadius.TabIndex = 2;
            this.labelAgentRadius.Text = "Agent Radius";
            // 
            // labelNumAgents
            // 
            this.labelNumAgents.AutoSize = true;
            this.labelNumAgents.Location = new System.Drawing.Point(11, 42);
            this.labelNumAgents.Name = "labelNumAgents";
            this.labelNumAgents.Size = new System.Drawing.Size(184, 25);
            this.labelNumAgents.TabIndex = 1;
            this.labelNumAgents.Text = "Number of Agents";
            // 
            // textBoxNumAgents
            // 
            this.textBoxNumAgents.Location = new System.Drawing.Point(16, 70);
            this.textBoxNumAgents.Name = "textBoxNumAgents";
            this.textBoxNumAgents.Size = new System.Drawing.Size(124, 31);
            this.textBoxNumAgents.TabIndex = 0;
            // 
            // groupBoxBehaviors
            // 
            this.groupBoxBehaviors.Controls.Add(this.labelAvoidanceWeight);
            this.groupBoxBehaviors.Controls.Add(this.textBoxAvoidanceWeight);
            this.groupBoxBehaviors.Controls.Add(this.labelAggregationWeight);
            this.groupBoxBehaviors.Controls.Add(this.textBoxAggregationWeight);
            this.groupBoxBehaviors.Controls.Add(this.labelHomingLineWeight);
            this.groupBoxBehaviors.Controls.Add(this.textBoxHomingLineWeight);
            this.groupBoxBehaviors.Controls.Add(this.labelHomePointWeight);
            this.groupBoxBehaviors.Controls.Add(this.textBoxHomingPointWeight);
            this.groupBoxBehaviors.Controls.Add(this.checkBoxAvoidance);
            this.groupBoxBehaviors.Controls.Add(this.checkBoxAggregation);
            this.groupBoxBehaviors.Controls.Add(this.checkBoxHomingLine);
            this.groupBoxBehaviors.Controls.Add(this.checkBoxHoming);
            this.groupBoxBehaviors.Location = new System.Drawing.Point(309, 18);
            this.groupBoxBehaviors.Name = "groupBoxBehaviors";
            this.groupBoxBehaviors.Size = new System.Drawing.Size(283, 563);
            this.groupBoxBehaviors.TabIndex = 2;
            this.groupBoxBehaviors.TabStop = false;
            this.groupBoxBehaviors.Text = "Behaviors";
            // 
            // labelAvoidanceWeight
            // 
            this.labelAvoidanceWeight.AutoSize = true;
            this.labelAvoidanceWeight.Location = new System.Drawing.Point(51, 397);
            this.labelAvoidanceWeight.Name = "labelAvoidanceWeight";
            this.labelAvoidanceWeight.Size = new System.Drawing.Size(79, 25);
            this.labelAvoidanceWeight.TabIndex = 7;
            this.labelAvoidanceWeight.Text = "Weight";
            // 
            // textBoxAvoidanceWeight
            // 
            this.textBoxAvoidanceWeight.Location = new System.Drawing.Point(51, 428);
            this.textBoxAvoidanceWeight.Name = "textBoxAvoidanceWeight";
            this.textBoxAvoidanceWeight.Size = new System.Drawing.Size(209, 31);
            this.textBoxAvoidanceWeight.TabIndex = 6;
            // 
            // labelAggregationWeight
            // 
            this.labelAggregationWeight.AutoSize = true;
            this.labelAggregationWeight.Location = new System.Drawing.Point(51, 290);
            this.labelAggregationWeight.Name = "labelAggregationWeight";
            this.labelAggregationWeight.Size = new System.Drawing.Size(79, 25);
            this.labelAggregationWeight.TabIndex = 7;
            this.labelAggregationWeight.Text = "Weight";
            // 
            // textBoxAggregationWeight
            // 
            this.textBoxAggregationWeight.Location = new System.Drawing.Point(51, 321);
            this.textBoxAggregationWeight.Name = "textBoxAggregationWeight";
            this.textBoxAggregationWeight.Size = new System.Drawing.Size(209, 31);
            this.textBoxAggregationWeight.TabIndex = 6;
            // 
            // labelHomingLineWeight
            // 
            this.labelHomingLineWeight.AutoSize = true;
            this.labelHomingLineWeight.Location = new System.Drawing.Point(51, 180);
            this.labelHomingLineWeight.Name = "labelHomingLineWeight";
            this.labelHomingLineWeight.Size = new System.Drawing.Size(79, 25);
            this.labelHomingLineWeight.TabIndex = 7;
            this.labelHomingLineWeight.Text = "Weight";
            // 
            // textBoxHomingLineWeight
            // 
            this.textBoxHomingLineWeight.Location = new System.Drawing.Point(51, 211);
            this.textBoxHomingLineWeight.Name = "textBoxHomingLineWeight";
            this.textBoxHomingLineWeight.Size = new System.Drawing.Size(209, 31);
            this.textBoxHomingLineWeight.TabIndex = 6;
            // 
            // labelHomePointWeight
            // 
            this.labelHomePointWeight.AutoSize = true;
            this.labelHomePointWeight.Location = new System.Drawing.Point(51, 66);
            this.labelHomePointWeight.Name = "labelHomePointWeight";
            this.labelHomePointWeight.Size = new System.Drawing.Size(79, 25);
            this.labelHomePointWeight.TabIndex = 5;
            this.labelHomePointWeight.Text = "Weight";
            // 
            // textBoxHomingPointWeight
            // 
            this.textBoxHomingPointWeight.Location = new System.Drawing.Point(51, 97);
            this.textBoxHomingPointWeight.Name = "textBoxHomingPointWeight";
            this.textBoxHomingPointWeight.Size = new System.Drawing.Size(209, 31);
            this.textBoxHomingPointWeight.TabIndex = 4;
            // 
            // checkBoxAvoidance
            // 
            this.checkBoxAvoidance.AutoSize = true;
            this.checkBoxAvoidance.Location = new System.Drawing.Point(6, 365);
            this.checkBoxAvoidance.Name = "checkBoxAvoidance";
            this.checkBoxAvoidance.Size = new System.Drawing.Size(145, 29);
            this.checkBoxAvoidance.TabIndex = 3;
            this.checkBoxAvoidance.Text = "Avoidance";
            this.checkBoxAvoidance.UseVisualStyleBackColor = true;
            // 
            // checkBoxAggregation
            // 
            this.checkBoxAggregation.AutoSize = true;
            this.checkBoxAggregation.Location = new System.Drawing.Point(6, 257);
            this.checkBoxAggregation.Name = "checkBoxAggregation";
            this.checkBoxAggregation.Size = new System.Drawing.Size(160, 29);
            this.checkBoxAggregation.TabIndex = 2;
            this.checkBoxAggregation.Text = "Aggregation";
            this.checkBoxAggregation.UseVisualStyleBackColor = true;
            // 
            // checkBoxHomingLine
            // 
            this.checkBoxHomingLine.AutoSize = true;
            this.checkBoxHomingLine.Location = new System.Drawing.Point(6, 146);
            this.checkBoxHomingLine.Name = "checkBoxHomingLine";
            this.checkBoxHomingLine.Size = new System.Drawing.Size(246, 29);
            this.checkBoxHomingLine.TabIndex = 1;
            this.checkBoxHomingLine.Text = "Home Towards Lines";
            this.checkBoxHomingLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxHoming
            // 
            this.checkBoxHoming.AutoSize = true;
            this.checkBoxHoming.Location = new System.Drawing.Point(6, 30);
            this.checkBoxHoming.Name = "checkBoxHoming";
            this.checkBoxHoming.Size = new System.Drawing.Size(254, 29);
            this.checkBoxHoming.TabIndex = 0;
            this.checkBoxHoming.Text = "Home Towards Points";
            this.checkBoxHoming.UseVisualStyleBackColor = true;
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.Controls.Add(this.labelMap);
            this.groupBoxMap.Controls.Add(this.textBoxMap);
            this.groupBoxMap.Location = new System.Drawing.Point(618, 18);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Size = new System.Drawing.Size(243, 563);
            this.groupBoxMap.TabIndex = 3;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // labelMap
            // 
            this.labelMap.AutoSize = true;
            this.labelMap.Location = new System.Drawing.Point(6, 30);
            this.labelMap.Name = "labelMap";
            this.labelMap.Size = new System.Drawing.Size(243, 125);
            this.labelMap.TabIndex = 1;
            this.labelMap.Text = "Define the map by lines \r\ndefined as such\r\n(no spaces):\r\n(0,200),(200,200)\r\n(200," +
    "200),(200,0)";
            // 
            // textBoxMap
            // 
            this.textBoxMap.Location = new System.Drawing.Point(6, 163);
            this.textBoxMap.Multiline = true;
            this.textBoxMap.Name = "textBoxMap";
            this.textBoxMap.Size = new System.Drawing.Size(226, 391);
            this.textBoxMap.TabIndex = 0;
            // 
            // buttonStepSolution
            // 
            this.buttonStepSolution.Location = new System.Drawing.Point(927, 138);
            this.buttonStepSolution.Name = "buttonStepSolution";
            this.buttonStepSolution.Size = new System.Drawing.Size(188, 55);
            this.buttonStepSolution.TabIndex = 4;
            this.buttonStepSolution.Text = "Simulate Step";
            this.buttonStepSolution.UseVisualStyleBackColor = true;
            this.buttonStepSolution.Click += new System.EventHandler(this.buttonStepSolution_Click);
            // 
            // buttonSimulate
            // 
            this.buttonSimulate.Location = new System.Drawing.Point(927, 209);
            this.buttonSimulate.Name = "buttonSimulate";
            this.buttonSimulate.Size = new System.Drawing.Size(188, 55);
            this.buttonSimulate.TabIndex = 5;
            this.buttonSimulate.Text = "Simulate";
            this.buttonSimulate.UseVisualStyleBackColor = true;
            this.buttonSimulate.Click += new System.EventHandler(this.buttonSimulate_Click);
            // 
            // textBoxTimeStep
            // 
            this.textBoxTimeStep.Location = new System.Drawing.Point(6, 62);
            this.textBoxTimeStep.Name = "textBoxTimeStep";
            this.textBoxTimeStep.Size = new System.Drawing.Size(124, 31);
            this.textBoxTimeStep.TabIndex = 6;
            // 
            // labelTimeStep
            // 
            this.labelTimeStep.AutoSize = true;
            this.labelTimeStep.Location = new System.Drawing.Point(6, 31);
            this.labelTimeStep.Name = "labelTimeStep";
            this.labelTimeStep.Size = new System.Drawing.Size(157, 25);
            this.labelTimeStep.TabIndex = 7;
            this.labelTimeStep.Text = "Time Step Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "(s)";
            // 
            // buttonCheckValues
            // 
            this.buttonCheckValues.Location = new System.Drawing.Point(927, 67);
            this.buttonCheckValues.Name = "buttonCheckValues";
            this.buttonCheckValues.Size = new System.Drawing.Size(188, 57);
            this.buttonCheckValues.TabIndex = 9;
            this.buttonCheckValues.Text = "Check Values";
            this.buttonCheckValues.UseVisualStyleBackColor = true;
            this.buttonCheckValues.Click += new System.EventHandler(this.buttonCheckValues_Click);
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(933, 282);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(0, 25);
            this.labelDebug.TabIndex = 10;
            // 
            // labelNumTimeSteps
            // 
            this.labelNumTimeSteps.AutoSize = true;
            this.labelNumTimeSteps.Location = new System.Drawing.Point(6, 110);
            this.labelNumTimeSteps.Name = "labelNumTimeSteps";
            this.labelNumTimeSteps.Size = new System.Drawing.Size(279, 25);
            this.labelNumTimeSteps.TabIndex = 11;
            this.labelNumTimeSteps.Text = "Total Number of Time Steps";
            // 
            // textBoxNumTimeSteps
            // 
            this.textBoxNumTimeSteps.Location = new System.Drawing.Point(6, 138);
            this.textBoxNumTimeSteps.Name = "textBoxNumTimeSteps";
            this.textBoxNumTimeSteps.Size = new System.Drawing.Size(124, 31);
            this.textBoxNumTimeSteps.TabIndex = 12;
            // 
            // labelTimeElapsed
            // 
            this.labelTimeElapsed.AutoSize = true;
            this.labelTimeElapsed.Location = new System.Drawing.Point(880, 351);
            this.labelTimeElapsed.Name = "labelTimeElapsed";
            this.labelTimeElapsed.Size = new System.Drawing.Size(190, 25);
            this.labelTimeElapsed.TabIndex = 13;
            this.labelTimeElapsed.Text = "Current Time-step:";
            // 
            // labelCurrentTimeStep
            // 
            this.labelCurrentTimeStep.AutoSize = true;
            this.labelCurrentTimeStep.Location = new System.Drawing.Point(1000, 383);
            this.labelCurrentTimeStep.Name = "labelCurrentTimeStep";
            this.labelCurrentTimeStep.Size = new System.Drawing.Size(0, 25);
            this.labelCurrentTimeStep.TabIndex = 14;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(927, 512);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(188, 56);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.labelTimeStep);
            this.groupBoxTime.Controls.Add(this.label5);
            this.groupBoxTime.Controls.Add(this.textBoxNumTimeSteps);
            this.groupBoxTime.Controls.Add(this.labelNumTimeSteps);
            this.groupBoxTime.Controls.Add(this.textBoxTimeStep);
            this.groupBoxTime.Location = new System.Drawing.Point(12, 401);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(291, 180);
            this.groupBoxTime.TabIndex = 16;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Simulation";
            // 
            // SwarmingSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 1208);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelCurrentTimeStep);
            this.Controls.Add(this.labelTimeElapsed);
            this.Controls.Add(this.labelDebug);
            this.Controls.Add(this.buttonCheckValues);
            this.Controls.Add(this.buttonSimulate);
            this.Controls.Add(this.buttonStepSolution);
            this.Controls.Add(this.groupBoxMap);
            this.Controls.Add(this.groupBoxBehaviors);
            this.Controls.Add(this.groupBoxAgent);
            this.Controls.Add(this.chartSimulation);
            this.Name = "SwarmingSimulatorForm";
            this.Text = "Swarming Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.chartSimulation)).EndInit();
            this.groupBoxAgent.ResumeLayout(false);
            this.groupBoxAgent.PerformLayout();
            this.groupBoxBehaviors.ResumeLayout(false);
            this.groupBoxBehaviors.PerformLayout();
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxMap.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSimulation;
        private System.Windows.Forms.GroupBox groupBoxAgent;
        private System.Windows.Forms.Label labelMaxVel;
        private System.Windows.Forms.TextBox textBoxMaxVel;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Label labelAgentRadius;
        private System.Windows.Forms.Label labelNumAgents;
        private System.Windows.Forms.TextBox textBoxNumAgents;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAvoidanceRange;
        private System.Windows.Forms.TextBox textBoxAvoidanceRange;
        private System.Windows.Forms.TextBox textBoxSensorRange;
        private System.Windows.Forms.Label labelSensorRange;
        private System.Windows.Forms.GroupBox groupBoxBehaviors;
        private System.Windows.Forms.Label labelAvoidanceWeight;
        private System.Windows.Forms.TextBox textBoxAvoidanceWeight;
        private System.Windows.Forms.Label labelAggregationWeight;
        private System.Windows.Forms.TextBox textBoxAggregationWeight;
        private System.Windows.Forms.Label labelHomingLineWeight;
        private System.Windows.Forms.TextBox textBoxHomingLineWeight;
        private System.Windows.Forms.Label labelHomePointWeight;
        private System.Windows.Forms.TextBox textBoxHomingPointWeight;
        private System.Windows.Forms.CheckBox checkBoxAvoidance;
        private System.Windows.Forms.CheckBox checkBoxAggregation;
        private System.Windows.Forms.CheckBox checkBoxHomingLine;
        private System.Windows.Forms.CheckBox checkBoxHoming;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.Label labelMap;
        private System.Windows.Forms.TextBox textBoxMap;
        private System.Windows.Forms.Button buttonStepSolution;
        private System.Windows.Forms.Button buttonSimulate;
        private System.Windows.Forms.TextBox textBoxTimeStep;
        private System.Windows.Forms.Label labelTimeStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCheckValues;
        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Label labelNumTimeSteps;
        private System.Windows.Forms.TextBox textBoxNumTimeSteps;
        private System.Windows.Forms.Label labelTimeElapsed;
        private System.Windows.Forms.Label labelCurrentTimeStep;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxTime;
    }
}

