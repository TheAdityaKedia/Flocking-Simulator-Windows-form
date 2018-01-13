using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributed_Robotics_Simulator
{
    /// <summary>
    /// The agent that executes the intended actions and behaviors
    /// Every system consists of several independednt but identical agents
    /// </summary>
    class Agent
    {
        /// <summary>
        /// radius of the circular agent
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// 360 degree sensor range of the agent
        /// </summary>
        public double Range;

        /// <summary>
        /// maximum velocity an agent can achieve
        /// </summary>
        public double MaxVel;

        /// <summary>
        /// an agent's location expressed as a point
        /// </summary>
        public Point Location;

        /// <summary>
        /// an agents velocity vector
        /// </summary>
        public Point Velocity;

        /// <summary>
        /// an agents ID number. its index amongst all agents in the world
        /// </summary>
        public int AgentID;

        /// <summary>
        /// the world that the agent exists in
        /// Since this needs to be shared by all agents, it is importnat to pass this to the constructor by refernce
        /// </summary>
        public World myWorld;

        /// <summary>
        /// distance at which avoidence behavior will be triggered
        /// </summary>
        public double AvoidanceRange;

        /// <summary>
        /// constructor for the agent
        /// </summary>
        /// <param name="Location">the agent's initial location as apoint</param>
        /// <param name="Radius">the agents radius. Note that all agents are circular</param>
        /// <param name="avoidanceRange">distance at which this agent should avoid other agents</param>
        /// <param name="Range">the range of this agent's sensor</param>
        /// <param name="MaxVel">The maximum velocity that this robot is capale of obtaining</param>
        /// <param name="myWorld">the world in which the agent exists. Must be passed by reference</param>
        public Agent(Point Location, double Radius, double avoidanceRange, double Range, double MaxVel, ref World myWorld)
        {
            this.Location = Location;
            this.Radius = Radius;
            this.AvoidanceRange = avoidanceRange;
            this.Range = Range;
            this.MaxVel = MaxVel;
            this.myWorld = myWorld;
            this.AgentID = myWorld.AddAgent(this);
            this.Velocity = new Point(0, 0);
            
        }

#region primitive_behaviors

        public Point Homing(Line l)
        {
            Point pointonline = l.PointOnPerpendicularFrom(this.Location);
            return Homing(pointonline);
        }

        /// <summary>
        /// primitive behavior to home toward a point
        /// </summary>
        /// <param name="p">point that the agent must homw toward</param>
        /// <returns>the unit vector for the velocity to home towards this point</returns>
        public Point Homing(Point p)
        {
            Point homing_vector = p - Location;

            return homing_vector.GetUnitVector();
        }

        /// <summary>
        /// primitive behavior to home towards an agent
        /// </summary>
        /// <param name="a">takes an agent handel</param>
        /// <returns>the unit vector for velocity home towards that agent</returns>
        public Point Aggregate(Agent a)
        {
            if(Location.GetDistanceFrom(a.Location)<=Radius + a.Radius)
            {
                return new Point(0, 0);
            }
            return Homing(a.Location);
        }

        public Point Aggregation()
        {
            Point aggregation_vector = new Point(0, 0);

            List<Agent> AgentsInMyRange = myWorld.GetAgentsInRange(this.AgentID, this.Range);

            foreach(Agent john in AgentsInMyRange)
            {
                aggregation_vector = aggregation_vector + Aggregate(john);
            }

            return aggregation_vector.GetUnitVector();
        }

        public Point Avoid(Agent a)
        {
            Line distance_vector = new Line(a.Location, this.Location);
            Point distance_unit_vector = distance_vector.vector.GetUnitVector();
            Point avodance_vector = distance_unit_vector;

            return avodance_vector;
        }

        public Point Avoidance()
        {
            Point avoidance_vector = new Point(0, 0);

            List<Agent> AgentsInAvoidRange = myWorld.GetAgentsInRange(this.AgentID, this.AvoidanceRange);

            foreach (Agent john in AgentsInAvoidRange)
            {
                avoidance_vector = avoidance_vector + Avoid(john);
            }

            return avoidance_vector;
        }



#endregion


    }
}
