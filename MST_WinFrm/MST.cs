namespace MST_WinFrm
{
    enum Visited
    {
        WHITE = -1,
        GRAY = 0,
        BLACK = 1
    }

    class MST
    {
        private int NumOfVertices;
        private int[,] Weight;

        public MST(int NumOfVertices, int[,] Weight)
        {
            this.NumOfVertices = NumOfVertices;
            this.Weight = new int[NumOfVertices, NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    this.Weight[i, j] = Weight[i, j];
        }

        #region Algorithms Help
        private int CountEdge()
        {
            int count = 0;
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] != 0)
                        count++;
            //count /= 2;
            return count;
        }

        private void Start(ref int[] Edge, ref bool[,] State)
        {
            for (int k = 0, i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                {
                    /// tolid majmoe tohi az ras ha
                    State[i, j] = false;
                    if (Weight[i, j] != 0)
                        Edge[k++] = Weight[i, j];
                }
        }

        private void Sort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
        }

        private int minArray(int[] array)
        {
            int min = int.MaxValue;
            foreach (int i in array)
                min = i < min && i != 0 ? i : min;
            return min;
        }

        private bool FindEdge(int E, out int u, out int v)
        {
            u = v = -1;
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] == E)
                    {
                        u = i;
                        v = j;
                        return true;
                    }
            return false;
        }

        private int FindMinimumWeight(int IndexVertics, out int v)
        {
            int min = int.MaxValue;
            v = -1;
            for (int j = 0; j < NumOfVertices; j++)
            {
                if (Weight[IndexVertics, j] < min && Weight[IndexVertics, j] != 0)// && !State[IndexVertics, j])
                {
                    v = j;
                    min = Weight[IndexVertics, j];
                }
                if (Weight[j, IndexVertics] < min && Weight[j, IndexVertics] != 0)// && !State[j, IndexVertics])
                {
                    v = j;
                    min = Weight[j, IndexVertics];
                }
            }
            return min;
        }

        private int[] FindEdgeCounctedUV(int u, int v, int[] min)
        {
            int nTemp = 0;
            int[] temp = new int[NumOfVertices * 2];
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] != 0 && (i == u || i == v || j == u || j == v))
                        temp[nTemp++] = Weight[i, j];
            temp = DeleteMinInArray(temp, min);
            return temp;
        }

        private int[] DeleteMinInArray(int[] array, int[] min)
        {
            int[] temp = new int[array.Length];
            bool flg = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < min.Length; j++)
                    if (array[i] == min[j] && min[j] != 0 && array[i] != 0)
                    {
                        flg = true;
                        break;
                    }
                    else
                        flg = false;
                if (!flg)
                    temp[i] = array[i];
                flg = false;
            }
            return temp;
        }

        private bool DetectCycle(int u, int v, ref bool[,] State)
        {
            if (u == v) return false;
            for (int i = 0; i < NumOfVertices; i++)
                if (State[u, i] || State[i, u])
                    if (State[i, v] || State[v, i])
                        return false;
                    else
                        for (int j = 0; j < NumOfVertices; j++)
                            if (State[j, v] || State[v, j])
                                if (State[j, u] || State[u, j])
                                    return false;
            return true;
        }

        private bool CycleDetect(Visited[] marked, int u, int v)
        {
            if (marked[u] == Visited.WHITE)
                if (Visit(marked, out marked[u], u))
                    return true;
            if (marked[v] == Visited.WHITE)
                if (Visit(marked, out marked[v], v))
                    return true;
            return false;
        }

        private bool Visit(Visited[] marked, out Visited mark, int Index)
        {
            mark = Visited.GRAY;
            for (int u = 0; u < NumOfVertices; u++)
                if (Weight[Index, u] != 0 || Weight[u, Index] != 0)
                    if (marked[u] == Visited.GRAY)
                        return true;
                    else if (marked[u] == Visited.WHITE)
                        if (Visit(marked, out marked[u], u))
                            return true;
            mark = Visited.BLACK;
            return false;
        }
        #endregion

        #region Kruskal
        public void Kruskal(ref bool[,] State)
        {
            int[] Edge = new int[CountEdge()];
            Start(ref Edge, ref State);
            Sort(Edge);
            int NumEdgeTree = 0, k = 0;
            Visited[] marked = new Visited[NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                marked[i] = Visited.WHITE;
            while (k < Edge.Length && NumEdgeTree < NumOfVertices - 1)
            {
                int u, v;
                FindEdge(Edge[k++], out u, out v);
                if (CycleDetect(marked, u, v) || Visit(marked, out marked[u], u))
                {
                    State[u, v] = true;
                    NumEdgeTree++;
                }
            }
            //bool[] marked = new bool[NumOfVertices];
            //for (int k = 0; k < Edge.Length && NUmEdgeTree < NumOfVertices - 1; k++)
            //    for (int i = 0; i < NumOfVertices; i++)
            //        for (int j = 0; j < NumOfVertices; j++)
            //            if (Weight[i, j] == Edge[k] && (!marked[i] || DetectCycle(i, j)))
            //            {
            //                marked[i] = true;
            //                State[i, j] = true;
            //                NUmEdgeTree++;
            //            }
        }
        #endregion

        #region Prim
        public void Prim(ref bool[,] State)
        {
            int[] Edge = new int[CountEdge()];
            Start(ref Edge, ref State);
            Visited[] marked = new Visited[NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                marked[i] = Visited.WHITE;
            int[] MIN = new int[CountEdge()];

            int v, u = 0;
            int min = FindMinimumWeight(u, out v);
            int NumEdgeTree = 0;

            while (NumEdgeTree < NumOfVertices - 1)
            {
                int[] temp = new int[CountEdge()];
                temp = FindEdgeCounctedUV(u, v, MIN);
                min = minArray(temp);
                MIN[NumEdgeTree] = min;
                if (CycleDetect(marked, u, v) || Visit(marked, out marked[u], u))
                {
                    FindEdge(min, out u, out v);
                    try
                    {
                        State[u, v] = Weight[u, v] == min ? true : false;
                        State[v, u] = Weight[v, u] == min ? true : false;
                    }
                    catch { }
                    NumEdgeTree++;
                }
            }
        }
        #endregion

        #region Sollin     
        public void Sollin(ref bool[,] State)
        {
            int[] Edge = new int[CountEdge()];
            Start(ref Edge, ref State);
            Visited[] marked = new Visited[NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                marked[i] = Visited.WHITE;

            int NumEdgeTree = 0;
            int min = int.MaxValue, IndexMin = -1;
            for (int i = 0; i < NumOfVertices && NumEdgeTree < NumOfVertices - 1; i++)
                if (CycleDetect(marked, i, IndexMin) || Visit(marked, out marked[i], i))
                {
                    min = FindMinimumWeight(i, out IndexMin);
                    try
                    {
                        State[i, IndexMin] = Weight[i, IndexMin] != 0 ? true : false;
                        State[IndexMin, i] = Weight[IndexMin, i] != 0 ? true : false;
                    }
                    catch { }
                    NumEdgeTree++;
                }
            int[] MIN = new int[CountEdge()];
            if (NumEdgeTree == NumOfVertices - 2)
                return;
            else
                while (NumEdgeTree < NumOfVertices - 1)
                {
                    int v, u = 0;
                    min = FindMinimumWeight(u, out v);
                    int[] temp = new int[CountEdge()];
                    temp = FindEdgeCounctedUV(u, v, MIN);
                    min = minArray(temp);
                    MIN[NumEdgeTree] = min;
                    if (CycleDetect(marked, u, v) || Visit(marked, out marked[u], u))
                    {
                        FindEdge(min, out u, out v);
                        try
                        {
                            State[u, v] = Weight[u, v] == min ? true : false;
                            State[v, u] = Weight[v, u] == min ? true : false;
                        }
                        catch { }
                        NumEdgeTree++;
                    }
                }
        }
        #endregion
    }
}
