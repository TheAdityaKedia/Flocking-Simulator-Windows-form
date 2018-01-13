using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributed_Robotics_Simulator
{
    class World
    {

        /// <summary>
        /// List of agents in the world
        /// </summary>
        public List<Agent> agents;

        /// <summary>
        /// List of lines that form the map
        /// </summary>
        public List<Line> map;

        /// <summary>
        /// Matrix containing the distance of each agent from the other
        /// </summary>
        double[,] distances;

        int numAgents;// number of agents in the world

        public World()
        {
            agents = new List<Agent>();
            map = new List<Line>();
            
        }

        /// <summary>
        /// Adds agent to the world
        /// </summary>
        /// <param name="Smith">Agent to be added</param>
        /// <returns>the index of the agent in the world</returns>
        public int AddAgent(Agent Smith)
        {
            agents.Add(Smith);

            numAgents = agents.Count; //update number of agents

            return numAgents-1;
        }

        /// <summary>
        /// Updates the matrix containing all the distances from each agent to the other
        /// </summary>
        public void UpdateDistanceMatrix()
        {
            distances = new double[numAgents, numAgents]; //initialize new matrix
                      
            foreach(Agent smith in agents)
            {
                foreach(Agent john in agents)
                {
                    // add the distance of the jth agent from the ith agent
                    distances[smith.AgentID, john.AgentID] = smith.Location.GetDistanceFrom(john.Location);
                }
            }
            
        }

        /// <summary>
        /// Get the list of agents who are within a certain distance of a particular agent
        /// </summary>
        /// <param name="agentID">The index of the agent</param>
        /// <param name="range">the range within which we are checking</param>
        /// <returns></returns>
        public List<Agent> GetAgentsInRange(int agentID, double range)
        {
            UpdateDistanceMatrix();

            List<Agent> inRange = new List<Agent>();
            
            foreach (Agent john in agents)
            {
                if (distances[agentID, john.AgentID] <= range)
                {
                    inRange.Add(john);
                }
            }

            return inRange;
        }

        /// <summary>
        /// Get the centroid of the entire system of agents
        /// </summary>
        /// <returns>the centroid as a point</returns>
        public Point GetCentroidLocation()
        {
            Point centroid = new Point(0, 0);
            foreach (Agent smith in agents)
            {
                centroid = centroid + smith.Location;
            }

            centroid = centroid / agents.Count;

            return centroid;
        }

        /// <summary>
        /// Get the average of the distances of each agetn from the centroid
        /// </summary>
        /// <returns>the average distance from the centroid as a double value</returns>
        public double AverageDistanceFromCentroid()
        {
            double averageDistance = 0;

            Point Centroid = GetCentroidLocation();

            foreach (Agent smith in agents)
            {
                averageDistance = averageDistance + smith.Location.GetDistanceFrom(Centroid);
            }

            averageDistance = averageDistance / agents.Count;

            return averageDistance;
        }
    }
}
