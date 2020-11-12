﻿using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System;
using GraphTraversals;
using sorting_algos;
using data_structures;
using PathFinding;

namespace practice_problems
{
    // type-aliasing for simplified typing
    using PriorityQueue = PriorityQueue<int>;
    using PQtup = PriorityQueue<(int[] point, int distance)>;

    class Program
    {
        static void p(object msg = null) => System.Console.WriteLine(msg);

        static void Main(string[] args)
        {
            p("");

            // Graph g = new Graph("graph.txt");
            // g.dfs(0);
            // g.bfs(0);

            // int[] array = new int[] { 68, 94, 63, 35, 23, 9, 65 };
            // int[] a = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};

            // unsafe
            // {
            //     int[] arr = {1, 2, 3, 4};
            //     fixed(int* p = arr)
            //     {
            //         int* k = p;
            //         p((*(k + 2) + 1[p] + *(0 + arr)));
            //     }
            // }

            // int n = ArrayDegree.FindShortestSubArray(new int[]{ 1,2,2,3,1 });
            // p(n);
            // SortingAlgos.PrintArray(array);


            // this object assumes the first line in the text file
            // is a single integer that represents the total number of vertices
            // DijkstraAlgo d = new DijkstraAlgo("dijkstra-graph.txt");
            // d.RunDijkstra(0);

            Trie t = new Trie();

            t.InsertWord("abc");
            p(t.Contains("abc"));
            t.InsertWord("abcd");
            p(t.Contains("abc"));

            p("");
            // Stopwatch timer = new Stopwatch();

            // timer.Start();
            // // SortingAlgos.MergeSort(array);
            // SortingAlgos.OptimizedBubbleSort(array);
            // timer.Stop();
            // TimeSpan ts = timer.Elapsed;

            // p(ts.TotalMilliseconds * 1e6);
            // // p(1e6);

            // SortingAlgos.PrintArray(array);

            // int[][] points = new int[][]
            // {
            //     new int[]{3,3},
            //     new int[]{5,-1},
            //     new int[]{-2, 4}
            // };
            // int k = 2;

            // [[3,3],[5,-1],[-2,4]]
            // 2


            // // maxheap
            // var pQ = new PQtup(points.Length, true);

            // // overwrite the default compare delegate
            // pQ.compare = (a, b) => a.distance.CompareTo(b.distance);




            #region point comparisons

            // foreach (int[] pt in points)
            // {
            //     // we avoid sqrt call to save runtime
            //     int distance = pt[0] * pt[0] + pt[1] * pt[1];
            //     // p(distance);
            //     pQ.Enqueue((pt, distance));

            //     if (pQ.size > k)
            //     {
            //         // remove the largest element
            //         pQ.Dequeue();
            //     }
            // }
            // p("");

            // int[][] res = new int[k][];

            // while (k-- > 0)
            // {
            //     res[k] = pQ.Dequeue().point;
            // }

            // foreach (var item in res)
            // {
            //     Array.ForEach<int>(item, System.Console.WriteLine);
            // }

            #endregion

            #region integers
            // PriorityQueue pq = new PriorityQueue(true);
            // for (int i = 1; i <= 10; i++)
            // {
            //     pq.Enqueue(i);
            // }

            // p("size: " + pq.size);

            // p("");
            // pq.Enqueue(0);
            // pq.PrintQueue();
            // p("size: " + pq.size);
            // p("");

            // p("");
            // pq.Dequeue();
            // pq.PrintQueue();
            // p("size: " + pq.size);
            // p("");

            // p("");
            // // pq.Dequeue();
            // // pq.PrintQueue();
            // // p("size: " + pq.size);
            // p("");

            // for (int i = 0; i < 9; i++)
            // {
            //     pq.Dequeue();
            //     pq.PrintQueue();
            //     p("size: " + pq.size);
            // }
            #endregion



        }
    }
}

