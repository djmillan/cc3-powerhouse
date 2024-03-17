using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    /// <summary>
    /// Represents a world in the game.
    /// </summary>
    public class World
    {
        private List<Location> _locations = new List<Location>();

        /// <summary>
        /// Gets the list of locations in the world.
        /// </summary>
        public IEnumerable<Location> Locations => _locations;

        /// <summary>
        /// Adds a location to the world.
        /// </summary>
        /// <param name="location">The location to add.</param>
        public void AddLocation(Location location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            _locations.Add(location);
        }

        /// <summary>
        /// Gets the location at the specified coordinates.
        /// </summary>
        /// <param name="xCoordinate">The x-coordinate of the location.</param>
        /// <param name="yCoordinate">The y-coordinate of the location.</param>
        /// <returns>The location at the specified coordinates, or null if no such location exists.</returns>
        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            if (xCoordinate < 0 || yCoordinate < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(xCoordinate), "X coordinate must be non-negative.");
            }

            return _locations.FirstOrDefault(loc => loc.XCoordinate == xCoordinate && loc.YCoordinate == yCoordinate);

