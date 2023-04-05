        Label[] nodes;
        TextBox[][] Weight;
        nodes = new Label[NumOfVertices];
         new Point(pnlGetGraph.Left + pnlGetGraph.Right / 4 - (i* 80), pnlGetGraph.Top + pnlGetGraph.Bottom / 2 - (i* 80))
        if (pnlGetGraph.Top<node[i].X || pnlGetGraph.Left<node[i].X) ;

        for (int i = 0; i<NumOfVertices; i++)
        {
    	    nodes[i] = new Label();
    	    pnlGetGraph.Controls.Add(nodes[i]);
    	    nodes[i].BackgroundImage = Properties.Resources.nodes;
    	    nodes[i].BackgroundImageLayout = ImageLayout.Stretch;
     	   nodes[i].Size = new Size(40, 40);
    	    nodes[i].Location = new Point(Location.X + (pnlGetGraph.Location.X* i) - 20, Location.X + (pnlGetGraph.Location.X* i) - 50);
   	     nodes[i].Text = (i + 1).ToString();
    	    nodes[i].TextAlign = ContentAlignment.MiddleCenter;

     	   Pen pen = new Pen(Color.Coral, 3);
     	   try { g.DrawLine(pen, nodes[i - 1].Location.X, nodes[i - 1].Location.Y, nodes[i].Location.X, nodes[i].Location.Y); } catch { }

     	   for (int j = 0; j<NumOfVertices; j++)
      	  {
    	        Weight[i][j] = new TextBox();
	        pnlGetGraph.Controls.Add(Weight[i][j]);
     	        Weight[i][j].Size = new Size(10, 10);
	        Weight[i][j].Location = new Point(nodes[i].Location.X, nodes[i].Location.Y);
       	  }            
        }



/// kruskal
            int i = 0, j = 0;
            for (i = 0; i < NumOfVertices; i++)
                for (j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] == E)
                        break;
            int[,] temp = new int[NumOfVertices, NumOfVertices];
            for (int k = 0; k < NumOfVertices; k++)
                if (Weight[i, k] != 0)
                    temp[i, k] = Weight[i, k];
            for (int k = 0; k < NumOfVertices; k++)
                if (Weight[j, k] != 0)
                    temp[j, k] = Weight[j, k];
            int u = 0, v = 0;
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (Weight[i, j] == Edge[i])
                    {
                        u = i;
                        v = j;
                        break;
                    }
            Point p = Vertices[u];
            Point q = Vertices[v];
            if (!Equals(p, q))
            {
                State[u, v] = true;
                n++;
            }


            for (int i = 0; i < NumOfVertices; i++)
                marked[i] = false;
            int c = 0;
            int[] temp = new int[Edge.Length];
            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++)
                    if (State[i, j])
                        temp[c++] = Weight[i, j];

            for (int i = 0; i < Edge.Length; i++)
                if (temp[i] == Edge[i])
                    temp[i] = -1;

            for (int k = 0; k < Edge.Length && NEdge < NumOfVertices - 1;)
                for (int i = 0; i < NumOfVertices; i++)
                    for (int j = 0; j < NumOfVertices; j++)
                        if (Weight[i, j] == temp[k] && !marked[i] && !State[i, j])
                        {
                            marked[i] = true;
                            State[i, j] = true;
                            NEdge++;
                            k++;
                        }






        private void Prim()
        {
            bool[] Know = new bool[NumOfVertices];
            int[] cost = new int[NumOfVertices];
            int[] path = new int[NumOfVertices];

            Know[0] = true;
            cost[0] = 0;

            for (int i = 0; i < NumOfVertices; i++)
                for (int j = 0; j < NumOfVertices; j++) ;
            //if (Weight[i,j])
        }


/// dijkstra

            int i, vnear = 0;
            int E;
            int n = 0;
            int[] touch = new int[NumOfVertices];
            int[] length = new int[NumOfVertices];

            for (i = 1; i < NumOfVertices; i++)
            {
                touch[i] = 1;
                length[i] = Weight[0, i];
            }

            while (n < NumOfVertices - 1)
            {
                int min = int.MaxValue;
                for (i = 1; i < NumOfVertices; i++)
                    if (0 <= length[i] && length[i] < min)
                    {
                        min = length[i];
                        vnear = i;
                    }
                E = Weight[touch[vnear], vnear];
                State[touch[vnear], vnear] = true;

                for (i = 1; i < NumOfVertices; i++)
                    if (length[vnear] + Weight[vnear, i] < length[i])
                    {
                        length[i] = length[vnear] + Weight[vnear, i];
                        touch[i] = vnear;
                    }
                length[vnear] = -1;
            }


private void Kruskal(int[] Edge)
        {
            int[] marked = new int[NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
                marked[i] = -1;

            for (int n = 0; n < NumOfVertices - 1;)
            {
                for (int i = 0; i < NumOfVertices; i++)
                    for (int j = 0; j < NumOfVertices; j++)
                        if (Weight[i, j] == Edge[n])
                        {
                            if (marked[i] > 0)
                                marked[i] = marked[marked[i]];
                            else if (marked[j] > 0)
                                marked[j] = marked[marked[j]];

                            if (Equals(marked[i], marked[j]) && marked[i] != -1 && marked[j] != -1)
                                continue;

                            if (marked[i] < 0 && marked[j] < 0)
                            {
                                marked[j] = marked[i] + marked[j];
                                //marked[i] = j;
                            }

                            State[i, j] = true;
                            n++;
                        }
            }
        }




        private int minKey(int[] key, bool[] Set)
        {
            int min = int.MaxValue, min_index = -1;
            for (int v = 0; v < NumOfVertices; v++)
                if (Set[v] == false && key[v] < min)
                {
                    min = key[v];
                    min_index = v;
                }
            return min_index;
        }
        private void prim()
        {
            int[] parent = new int[NumOfVertices];
            int[] key = new int[NumOfVertices];
            bool[] Set = new bool[NumOfVertices];
            for (int i = 0; i < NumOfVertices; i++)
            {
                key[i] = int.MaxValue;
                Set[i] = false;
            }
            key[0] = 0;
            parent[0] = -1;

            for (int i = 0; i < NumOfVertices - 1; i++)
            {
                int u = minKey(key, Set);
                Set[u] = true;

                for (int v = 0; v < NumOfVertices; v++)
                    if (Weight[u, v] >= 0 && Set[v] == false && Weight[u, v] < key[v])
                    {
                        parent[v] = u;
                        key[v] = Weight[u, v];
                        if (Weight[v, parent[v]] != 0)
                            State[v, parent[v]] = true;
                        else if (Weight[parent[v], v] != 0)
                            State[parent[v], v] = true;
                    }
            }
        }





/////kruskal
            //int[] help = new int[NumOfVertices];
            //int c = 0;
            //bool flag = false;
            //for (int n = 0; n < NumOfVertices; n++)
            //    if (help[n] == i)
            //        flag = true;
            //if (!flag) help[c++] = i;
            //for (int n = 0; n < NumOfVertices; n++)
            //    if (help[n] == j)
            //        flag = true;
            //if (!flag) help[c++] = j;
            //flag = false;
            //bool flg = false;
            //for (int m = 0; m < NumOfVertices; m++)
            //{
            //    if (help[m] == i) flag = true;
            //    if (help[m] == j) flg = true;
            //}
            //if (flag && flg)
            //    continue;



        private void Prim()
        {
            bool[] marked = new bool[NumOfVertices];
            marked[0] = true;
            int v, u;
            int min = FindMinimumWeight(0, out v);
            try
            {
                State[0, v] = Weight[0, v] == min ? true : false;
                State[v, 0] = Weight[v, 0] == min ? true : false;
            }
            catch { }

            for (int i = 1; i < NumOfVertices; i++)
                for (int j = v; j < NumOfVertices; j++)
                    if (!State[i, j] && !marked[i])
                    {
                        int[] temp = FindMinimumWeights(i, j);
                        Sort(temp);
                        FindEdge(temp[0], out u, out v);
                        State[u, v] = true;
                        marked[i] = true;
                    }
        }
        private void prim(int[] Edge)
        {
            int v;
            int min = FindMinimumWeight(0, out v);
            try
            {
                State[0, v] = Weight[0, v] == min ? true : false;
                State[v, 0] = Weight[v, 0] == min ? true : false;
            }
            catch { }

            int[] Near = new int[NumOfVertices];

            for (int i = 1; i < NumOfVertices; i++)
                Near[i] = 1;
            Near[0] = 0;
            for (int n = 0; n < NumOfVertices - 1; n++)
            {
                int j;
                for (j = 0; j < NumOfVertices; j++)
                    if (Near[j] != 0 && Weight[j, Near[j]] < Edge[n] && Weight[j, Near[j]] != 0)
                        break;
                State[j, Near[j]] = true;
                Near[j] = 0;
                for (int k = 1; k < NumOfVertices; k++)
                    if (Near[k] != 0 && Weight[k, Near[k]] > Weight[k, j] && Weight[j, Near[j]] != 0)
                        Near[k] = j;
            }
        }
		
		
		
		
		        private void Sollin()
        {
            int min = int.MaxValue, IndexMin = -1;
            bool[] marked = new bool[NumOfVertices];
            int[] help = new int[NumOfVertices];
            int[] temp = new int[NumOfVertices];
            int u, v;
            for (int i = 0; i < NumOfVertices; i++)
            {
                if (!marked[i])
                {
                    min = FindMinimumWeight(i, out IndexMin);
                    try
                    {
                        State[i, IndexMin] = Weight[i, IndexMin] != 0 ? true : false;
                        State[IndexMin, i] = Weight[IndexMin, i] != 0 ? true : false;
                    }
                    catch { }
                    marked[i] = true;
                }

                else if (marked[i])
                {
                    for (int j = 0; j < NumOfVertices; j++)
                        if (State[i, j])
                            temp = FindMinimumWeights(i, j);

                    Sort(temp);
                    FindEdge(temp[0], out u, out v);
                    State[u, v] = true;
                }


                for (int j = 0; j < NumOfVertices; j++)
                {
                    int mini = FindMinimumWeight(i, out v);
                    int minj = FindMinimumWeight(j, out u);
                    if (mini < minj)
                    {
                        try
                        {
                            State[i, v] = Weight[i, v] != 0 ? true : false;
                            State[v, i] = Weight[v, i] != 0 ? true : false;
                        }
                        catch { }
                    }
                    else if (mini > minj)
                    {
                        try
                        {
                            State[i, u] = Weight[i, u] != 0 ? true : false;
                            State[u, i] = Weight[u, i] != 0 ? true : false;
                        }
                        catch { }
                    }
                }
            }
        }
		
		
		
		private int[] FindMinimumWeights(int i, int j)
        {
            int co = 0;
            int[] WEdge = new int[NumOfVertices];
            for (int m = 0; m < NumOfVertices; m++)
            {
                int u = -1, v = -1;
                int minu = 0, minv = 0;
                if (!State[m, i] || !State[i, m])
                    minu = FindMinimumWeight(m, out u);
                if (!State[m, j] || !State[j, m])
                    minv = FindMinimumWeight(m, out v);
                if (minu != 0)
                    WEdge[co++] = minu;
                if(minv != 0)
                    WEdge[co++] = minv;
            }
            return WEdge;
        }