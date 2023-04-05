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
