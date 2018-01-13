using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Distributed_Robotics_Simulator
{
    public partial class SwarmingSimulatorForm : Form
    {

        World ThisWorld;
        int numAgents;
        double AgentRadius;
        double SensorRange;
        double AvoidanceRange;
        double AgentVel;
        double w_homing_point;
        double w_homing_line;
        double w_aggregation;
        double w_avoidance;
        double dt;
        int numTimeSteps;
        int TimeElapsed;
        List<Point> Locations;
        Line target_line;
        Point target_point;

        string CentroidDistanceFromLine;
        string AverageDistanceFromCentroid;
        
        public SwarmingSimulatorForm()
        {
            InitializeComponent();
            RunTests(); //If any tests need to be run, they must be executed here
            SetInitialValues(); //Set the textboxes and buttons to their initial state                
        }

        /// <summary>
        /// Sets the initlail values in the text boxes and initializes some gobal variables
        /// </summary>
        private void SetInitialValues()
        {

            buttonStepSolution.Enabled = false;
            buttonSimulate.Enabled = false;
            groupBoxMap.Enabled = false;

            ThisWorld = new World();
            Locations = new List<Point>();
            CentroidDistanceFromLine = String.Empty;
            AverageDistanceFromCentroid = string.Empty;
            TimeElapsed = 0;

            textBoxNumAgents.Text = "50";
            textBoxMaxVel.Text = "20";
            textBoxRadius.Text = "0.2";
            textBoxSensorRange.Text = "50";
            textBoxAvoidanceRange.Text = "2";
            textBoxTimeStep.Text = "0.2";
            textBoxNumTimeSteps.Text = "550";

            checkBoxHoming.Checked = true;
            textBoxHomingPointWeight.Text = "1";
            checkBoxHomingLine.Checked = true;
            textBoxHomingLineWeight.Text = "0.2";
            checkBoxAggregation.Checked = true;
            textBoxAggregationWeight.Text = "2";
            checkBoxAvoidance.Checked = true;
            textBoxAvoidanceWeight.Text = "4";

            textBoxMap.Text = "(0,200),(200,200)\n(200,200),(200,0)";

            labelCurrentTimeStep.Text = TimeElapsed.ToString();
        }

        /// <summary>
        /// All tests for debugging are run using this function
        /// </summary>
        private void RunTests()
        {
            string debugString = string.Empty;
            // all tests go here and modify the debug string
            
            labelDebug.Text = debugString;
        }

        /// <summary>
        /// Initializes the agents with random initial locations
        /// </summary>
        private void AssignRandomAgentPositions()
        {
            Random random = new Random();
            Point firstpoint = ThisWorld.map[0].p1;

            for (int i = 0; i < numAgents; i++)
            {
                Point p = new Point(GetRandomNumber(firstpoint.X-50, firstpoint.X+50, random), GetRandomNumber(firstpoint.Y-50, firstpoint.Y+50, random));
                Locations.Add(p);
                Agent newAgent = new Agent(p, AgentRadius, AvoidanceRange, SensorRange, AgentVel, ref ThisWorld);
            }
        }

        /// <summary>
        /// Checkes the values input by the user in the textboxes
        /// </summary>
        /// <returns></returns>
        private bool CheckInputValues()
        {
            string errorstring = string.Empty;
            bool everythingisawesome = true;
            
            //check agent variables
            if (int.TryParse(textBoxNumAgents.Text, out int numberofagents))
            {
                if (numberofagents <= 0)
                {
                    errorstring = "not enough agents";
                    everythingisawesome = false;
                }
                else if(numberofagents > 200)
                {
                    errorstring = "Too many agents";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "The Number of agents must be an integer";
                everythingisawesome = false;
            }
            if(double.TryParse(textBoxMaxVel.Text, out double agentvelocity))
            {
                if(agentvelocity > 200)
                {
                    errorstring = "Your agents are too fast";
                    everythingisawesome = false;
                }
                else if (agentvelocity <= 0)
                {
                    errorstring = "your agents are too slow";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "Agent velocity must be a number";
                everythingisawesome = false;
            }
            if(double.TryParse(textBoxRadius.Text, out double radi))
            {
                if (radi <= 0)
                {
                    errorstring = "Your Agents are too small";
                    everythingisawesome = false;
                }
                else if (radi > 2)
                {
                    errorstring = "Your agents are too big";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "agent radius must be a number";
                everythingisawesome = false;
            }
            if(double.TryParse(textBoxSensorRange.Text, out double senserange))
            {
                if (senserange <= 0)
                {
                    errorstring = "Sensor Range must be a psoitive number";
                    everythingisawesome = false;
                }
                else if(senserange > 200)
                {
                    errorstring = "The sensor range is too large";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "Sensor Range must be a number";
                everythingisawesome = false;
            }
            if(double.TryParse(textBoxAvoidanceRange.Text, out double avoidrange))
            {
                if(avoidrange <=0)
                {
                    errorstring = "avoidance range must be a positive number";
                    everythingisawesome = false;
                }
                else if(avoidrange > 50)
                {
                    errorstring = "avoidance range is too large";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "Avodance range must e a number";
                everythingisawesome = false;
            }

            //check weights
            if (checkBoxHoming.Checked)
            {
                if(!double.TryParse(textBoxHomingPointWeight.Text, out double homing_point_weight))
                {
                    errorstring = "weight for homing towards point must be a number";
                    everythingisawesome = false;
                }
            }
            if (checkBoxHomingLine.Checked)
            {
                if (!double.TryParse(textBoxHomingLineWeight.Text, out double homing_line_weight))
                {
                    errorstring = "weight for homing towards line must be a number";
                    everythingisawesome = false;
                }
            }
            if (checkBoxAggregation.Checked)
            {
                if (!double.TryParse(textBoxAggregationWeight.Text, out double aggregation_weight))
                {
                    errorstring = "weight for aggregation must be a number";
                    everythingisawesome = false;
                }
            }
            if (checkBoxAvoidance.Checked)
            {
                if (!double.TryParse(textBoxAvoidanceWeight.Text, out double avoidance_weight))
                {
                    errorstring = "weight for avoidance must be a number";
                    everythingisawesome = false;
                }
            }

            //check timestep
            if(double.TryParse(textBoxTimeStep.Text, out double timestep))
            {
                if ((timestep <= 0) && (timestep >= 1))
                {
                    errorstring = "time step size must be a positive number between 0 and 1";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "time step size must be a positive number between 0 and 1";
                everythingisawesome = false;
            }

            if(int.TryParse(textBoxNumTimeSteps.Text, out int timesteps))
            {
                if(timesteps <= 0)
                {
                    errorstring = "Number of timesteps must be a positive number";
                    everythingisawesome = false;
                }
            }
            else
            {
                errorstring = "Number of timesteps must be a positive number";
                everythingisawesome = false;
            }

            //check map
            //check if input is valid

            //check if map is disjoint

            if (everythingisawesome == false)
            {
                MessageBox.Show(errorstring, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
            
        }

        /// <summary>
        /// Assigns Correct input values to the variables in the system
        /// </summary>
        private void AssignInputValues()
        {
            //assign agent variables
            numAgents = int.Parse(textBoxNumAgents.Text);
            AgentRadius = double.Parse(textBoxRadius.Text);
            AgentVel = double.Parse(textBoxMaxVel.Text);
            SensorRange = double.Parse(textBoxSensorRange.Text);
            AvoidanceRange = double.Parse(textBoxAvoidanceRange.Text);


            //assign behavior variable
            if (checkBoxHoming.Checked)
            {
                w_homing_point = double.Parse(textBoxHomingPointWeight.Text);
            }
            else
            {
                w_homing_point = 0;
            }
            if (checkBoxHomingLine.Checked)
            {
                w_homing_line = double.Parse(textBoxHomingLineWeight.Text);
            }
            else
            {
                w_homing_line = 0;
            }
            if (checkBoxAggregation.Checked)
            {
                w_aggregation = double.Parse(textBoxAggregationWeight.Text);
            }
            else
            {
                w_aggregation = 0;
            }
            if (checkBoxAvoidance.Checked)
            {
                w_avoidance = double.Parse(textBoxAvoidanceWeight.Text);
            }
            else
            {
                w_avoidance = 0;
            }

            //assign Time step
            dt = double.Parse(textBoxTimeStep.Text);
            numTimeSteps = int.Parse(textBoxNumTimeSteps.Text);

            //assign map
            ThisWorld.map.Clear();
            string[] linestrings = textBoxMap.Text.Split(new[] {"\n" }, StringSplitOptions.None);
            foreach(string s in linestrings)
            {
                string[] thesepoints = s.Split(new[] { "," }, StringSplitOptions.None);
                double x1 = double.Parse(thesepoints[0].Substring(1));
                double y1 = double.Parse(thesepoints[1].TrimEnd(')'));
                Point p1 = new Point(x1, y1);
                double x2 = double.Parse(thesepoints[2].Substring(1));
                double y2 = double.Parse(thesepoints[3].TrimEnd(')'));
                Point p2 = new Point(x2, y2);
                ThisWorld.map.Add(new Line(p1, p2));
            }

            target_line = ThisWorld.map[0];
            target_point = target_line.p2;
        }

        /// <summary>
        /// Plots the lines of the map on the chart
        /// </summary>
        private void PlotMap()
        {
            foreach (Line l in ThisWorld.map)
            {
                chartSimulation.Series["map"].Points.AddXY(l.p1.X, l.p1.Y);
                chartSimulation.Series["map"].Points.AddXY(l.p2.X, l.p2.Y);
            }
        }

        /// <summary>
        /// plots the location of the agents on the chart
        /// </summary>
        private void PlotAgents()
        {
            this.chartSimulation.Series["agents"].Points.Clear();
            

            foreach(Agent smith in ThisWorld.agents)
            {
                this.chartSimulation.Series["agents"].MarkerSize = ConvertAgentRadiustoMarkerSize(smith);
                this.chartSimulation.Series["agents"].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                this.chartSimulation.Series["agents"].Points.AddXY(smith.Location.X, smith.Location.Y);
            }

            CleanUpChart();
            
            Application.DoEvents();

        }

        /// <summary>
        /// Removes the gridlines from the chart and fixes the shape
        /// </summary>
        private void CleanUpChart()
        {
            this.chartSimulation.ChartAreas[0].AxisX.Minimum = -50;
            this.chartSimulation.ChartAreas[0].AxisX.Maximum = 250;
            this.chartSimulation.ChartAreas[0].AxisY.Minimum = -50;
            this.chartSimulation.ChartAreas[0].AxisY.Maximum = 250;

            this.chartSimulation.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            this.chartSimulation.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
        }

        /// <summary>
        /// Takes the radius of the agent and converts it to the appropriate marker size for the plot
        /// i.e. scales it by 10
        /// </summary>
        /// <param name="smith">the agent who's radius needs to be converted</param>
        /// <returns></returns>
        private int ConvertAgentRadiustoMarkerSize(Agent smith)
        {
            return (int)Math.Floor(smith.Radius * 10);
        }

        /// <summary>
        /// Executes the cumulative emergent behavior of the agents
        /// </summary>
        /// <param name="target_line">the line toward which the agents are homing</param>
        /// <param name="target_point">the point toward which the agents are homing</param>
        private void ExecuteBehavior(Line target_line, Point target_point)
        {
            foreach (Agent smith in ThisWorld.agents)
            {
                Point LinehomingVelocity = w_homing_line * smith.Homing(target_line);
                Point PointHomingVelocity = w_homing_point * smith.Homing(target_point);
                Point AggregationVelocity = w_aggregation * smith.Aggregation();
                Point AvoidanceVelocity = w_avoidance * smith.Avoidance();

                Point new_velocity = LinehomingVelocity + PointHomingVelocity + AggregationVelocity + AvoidanceVelocity;
                new_velocity = new_velocity.GetUnitVector();
                new_velocity = smith.MaxVel * new_velocity;
                smith.Velocity = new_velocity;
                smith.Location = smith.Location + dt * smith.Velocity;
            }
        }

        /// <summary>
        /// Gets a random number between the range (minimum, maximum)
        /// </summary>
        /// <param name="minimum">minimum value</param>
        /// <param name="maximum">maximum value</param>
        /// <param name="random">random seed</param>
        /// <returns></returns>
        double GetRandomNumber(double minimum, double maximum, Random random)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }
                
        private void buttonCheckValues_Click(object sender, EventArgs e)
        {
            bool everythingisawesome = CheckInputValues();

            if (everythingisawesome)
            {
                AssignInputValues();
                AssignRandomAgentPositions();
                buttonStepSolution.Enabled = true;
                buttonSimulate.Enabled = true;
                groupBoxAgent.Enabled = false;
                groupBoxBehaviors.Enabled = false;
                groupBoxTime.Enabled = false;
                PlotMap();
                PlotAgents();
            }
        }

        private void buttonStepSolution_Click(object sender, EventArgs e)
        {
            if(target_line == ThisWorld.map[0])
            {
                if (TargetReached(target_point))
                {
                    target_line = ThisWorld.map[1];
                    target_point = target_line.p2;
                }
            }
            ExecuteBehavior(target_line, target_point);
            PlotAgents();
            TimeElapsed += 1;
            Point Centroid = ThisWorld.GetCentroidLocation();
            double CDistFromLine = Centroid.GetDistanceFrom(target_line.PointOnPerpendicularFrom(Centroid));
            CentroidDistanceFromLine += String.Format("{0},{1}\n", TimeElapsed * dt, CDistFromLine);
            AverageDistanceFromCentroid += String.Format("{0},{1}\n", TimeElapsed * dt, ThisWorld.AverageDistanceFromCentroid());
            if(TimeElapsed == numTimeSteps)
            {
                WriteDataFiles();
            }
            labelCurrentTimeStep.Text = TimeElapsed.ToString();

        }

        /// <summary>
        /// check if flock has reached the target
        /// </summary>
        /// <param name="target_point">target that flock is trying to reach</param>
        /// <returns></returns>
        private bool TargetReached(Point target_point)
        {
            if(ThisWorld.GetCentroidLocation().GetDistanceFrom(target_point) <= AvoidanceRange)
            {
                return true;
            }

            return false;
        }

        private void buttonSimulate_Click(object sender, EventArgs e)
        {
            for (int i=TimeElapsed; i<numTimeSteps; i++)
            {
                buttonStepSolution_Click(null, null);
            }
            WriteDataFiles();
        }

        /// <summary>
        /// Writes the relevant metrics to file
        /// </summary>
        private void WriteDataFiles()
        {
            //Filename with agent properties
            String CDLfilename = String.Format("CDL-{0},{1},{2},{3},{4}.csv", numAgents, AgentRadius, AgentVel, SensorRange, AvoidanceRange);
            String ADCfilename = String.Format("ADC-{0},{1},{2},{3},{4}.csv", numAgents, AgentRadius, AgentVel, SensorRange, AvoidanceRange);


            FileStream CDLfs = new FileStream(CDLfilename, FileMode.Create);
            StreamWriter CDLsw = new StreamWriter(CDLfs);

            //call the Generate string function of the TypeValues 
            //class and write the generated string to the users chosen file 
            CDLsw.WriteLine(CentroidDistanceFromLine);

            //close the streams
            CDLsw.Close();
            CDLfs.Close();

            FileStream ADCfs = new FileStream(ADCfilename, FileMode.Create);
            StreamWriter ADCsw = new StreamWriter(ADCfs);

            //call the Generate string function of the TypeValues 
            //class and write the generated string to the users chosen file 
            ADCsw.WriteLine(AverageDistanceFromCentroid);

            //close the streams
            ADCsw.Close();
            ADCfs.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetInitialValues();
            groupBoxAgent.Enabled = true;
            groupBoxTime.Enabled = true;
            groupBoxBehaviors.Enabled = true;
        }
    }
}
