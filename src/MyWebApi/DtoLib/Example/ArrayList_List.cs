using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib.Example
{
    public class ArrayList_List
    {
        private class Node
        {
            public string Name { get; set; }
            public int Index { get; set; }
        }

        public static void Copy()
        {
            int[] arr1 = new int[2] { 1, 2 };

            int[] arr2 = new int[arr1.Length];
            arr1.CopyTo(arr2, 0);
            foreach (var item in arr2)
            {
                Console.WriteLine("第{0}个元素 = {1} ", Array.IndexOf(arr2, item), item);
            }

            Node[] nodeArr = new Node[2] {
                new Node{ Name="node1",Index=1},
                new Node{ Name="node2",Index=2}
            };

            Node[] nodeArr2 = new Node[nodeArr.Length];
            Array.Copy(nodeArr, nodeArr2, nodeArr.Length);

            foreach (var item in nodeArr2)
            {
                Console.WriteLine("第{0}个元素 = {1} ", Array.IndexOf(nodeArr2, item), item.Name);
            }
        }
    }
}
