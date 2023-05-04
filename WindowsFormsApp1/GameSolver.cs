using System.Collections.Generic;
using WindowsFormsApp1;
using static WindowsFormsApp1.DFS;

public class GameSolver
{
    private readonly Stack<State> stack = new Stack<State>();
    private readonly HashSet<State> visited = new HashSet<State>();
    private readonly Solution solution = new Solution();

    public class Solver
    {
        private readonly Stack<DFS.State> stack = new Stack<DFS.State>();
        private readonly HashSet<DFS.State> visited = new HashSet<DFS.State>();
        private readonly DFS.Solution solution = new DFS.Solution();

        internal bool Solve(DFS.State initialState)
        {
            stack.Push(initialState);
            visited.Add(initialState);

            while (stack.Count > 0)
            {
                var currentState = stack.Pop();

                if (solution.IsGoal(currentState))
                {
                    solution.AddStep(currentState);
                    return true;
                }

                foreach (var nextState in currentState.GetNextStates())
                {
                    if (!visited.Contains(nextState))
                    {
                        stack.Push(nextState);
                        visited.Add(nextState);
                    }
                }
            }

            return false;
        }

        internal DFS.Solution GetSolution()
        {
            return solution;
        }
    }
}
