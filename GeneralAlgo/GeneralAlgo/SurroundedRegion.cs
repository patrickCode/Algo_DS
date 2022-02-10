//using System;
//using System.Collections.Generic;
//using System.Text;

//// Reference: https://www.youtube.com/watch?v=9z2BunfoZ5Y
//namespace GeneralAlgo
//{
//    public class SurroundedRegion
//    {
//        private readonly int[,] _graph;

//        public SurroundedRegion(int[,] graph)
//        {
//            _graph = graph;
//        }

//        // Concept: Any 0 on the broder are not part of the surrounded region. So mark them first.
//        public void CaptureSurrounded()
//        {
//            int row = _graph.GetLength(0);
//            int col = _graph.GetLength(1);

//            HashSet<string> borderNodes = new();

//            for(int index = 0; index < row; index++)
//            {
//                if (_graph[0, index] == 0)
//                {

//                }
//            }
//        }

//        private void MarkBorderGraphs(int row, int col)
//        {

//        }
//    }
//}
