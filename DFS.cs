using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DFS
    {
        public class State
        {
            public Point Wolf { get; set; }
            public Point Goat { get; set; }
            public Point Cabbage { get; set; }
            public Point Farmer { get; set; }
            public bool IsLeft { get; set; }

            public State(Point wolf, Point goat, Point cabbage, Point farmer, bool isLeft)
            {
                Wolf = wolf;
                Goat = goat;
                Cabbage = cabbage;
                Farmer = farmer;
                IsLeft = isLeft;
            }

            public override bool Equals(object obj)
            {
                var other = obj as State;
                if (other == null)
                {
                    return false;
                }
                return Wolf.Equals(other.Wolf)
                    && Goat.Equals(other.Goat)
                    && Cabbage.Equals(other.Cabbage)
                    && Farmer.Equals(other.Farmer)
                    && IsLeft == other.IsLeft;
            }

            public override int GetHashCode()
            {
                int hash = 17;
                hash = hash * 31 + Wolf.GetHashCode();
                hash = hash * 31 + Goat.GetHashCode();
                hash = hash * 31 + Cabbage.GetHashCode();
                hash = hash * 31 + Farmer.GetHashCode();
                hash = hash * 31 + IsLeft.GetHashCode();
                return hash;
            }
        }

        public class Solution
        {
            private static readonly List<Point> PossibleMoves = new List<Point>
    {
        new Point(0, -1),  // Up
        new Point(1, 0),   // Right
        new Point(0, 1),   // Down
        new Point(-1, 0),  // Left
    };

            private HashSet<State> visited = new HashSet<State>();

            public bool IsSafe(State state)
            {
                bool wolfAndGoat = state.Wolf.Equals(state.Goat) && state.Farmer.Equals(state.Wolf);
                bool goatAndCabbage = state.Goat.Equals(state.Cabbage) && state.Farmer.Equals(state.Goat);
                return !wolfAndGoat && !goatAndCabbage;
            }

            public bool IsGoal(State state)
            {
                return state.Wolf.X == 2 && state.Goat.X == 2 && state.Cabbage.X == 2 && state.Farmer.X == 2;
            }

            public bool Solve(State currentState)
            {
                visited.Add(currentState);

                if (IsGoal(currentState))
                {
                    return true;
                }

                foreach (var move in PossibleMoves)
                {
                    var newState = new State(
                    new Point(currentState.Wolf.X + move.X, currentState.Wolf.Y + move.Y),
                    new Point(currentState.Goat.X + move.X, currentState.Goat.Y + move.Y),
                    new Point(currentState.Cabbage.X + move.X, currentState.Cabbage.Y + move.Y),
                    new Point(currentState.Farmer.X + move.X, currentState.Farmer.Y + move.Y),
                            !currentState.IsLeft);


                    if (!visited.Contains(newState) && IsSafe(newState))
                    {
                        if (Solve(newState))
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
        }


    }
}
