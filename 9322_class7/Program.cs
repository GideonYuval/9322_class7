using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9322_class7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = Arr2Q(new int[] { 8, 8, 12, 12, 1, 1 });
            Console.WriteLine(ArePair(q1)); //T
            q1 = Arr2Q(new int[] { 2, 2, 1, 7, 7 });
            Console.WriteLine(ArePair(q1)); //F
            q1 = Arr2Q(new int[] { 2, 2, 4, 4, 2, 2, 3, 3 });
            Console.WriteLine(ArePair(q1)); //F

            q1 = Arr2Q(new int[] { 8, 8, 2, 2, 1, 1 });
            Queue<int> q2 = Arr2Q(new int[] { 2, 2, 8, 8, 1, 1 });
            Console.WriteLine(AreTwinQ(q1, q2)); //T

            q1 = Arr2Q(new int[] { 8, 8, 2, 2, 1, 1 });
            q2 = Arr2Q(new int[] { 2, 2, 8, 8, 3, 3 });
            Console.WriteLine(AreTwinQ(q1, q2)); //F

            q1 = Arr2Q(new int[] { 8, 8, 12, 12 });
            q2 = Arr2Q(new int[] { 8, 8, 12, 12, 5, 5 });
            Console.WriteLine(AreTwinQ(q1, q2)); //F
        }

        static Queue<int> Arr2Q(int[] arr)
        {
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < arr.Length; i++)
                q.Insert(arr[i]);
            return q;
        }

        public static Queue<int> Clone(Queue<int> original)
        {
            Queue<int> copy = new Queue<int>();
            Queue<int> temp = new Queue<int>();

            // Step 1: Drain original into temp and copy
            while (!original.IsEmpty())
            {
                int val = original.Remove();
                temp.Insert(val);
                copy.Insert(val);
            }

            // Step 2: Restore the original queue
            while (!temp.IsEmpty())
            {
                original.Insert(temp.Remove());
            }

            return copy;
        }



        static bool AreTwinQ(Queue<int> q1, Queue<int> q2)
        {
            if (!ArePair(q1) || !ArePair(q2)) return false; //if one of the pairs isn't "Pair", return false

            Queue<int> clone1 = Clone(q1); //Clone so we don't destroy
            //if there's a number in q1 which isn't in q2, return false
            while (!clone1.IsEmpty())
                if (!NumInQ(q2, clone1.Remove())) return false;
            Queue<int> clone2 = Clone(q2);
            //if there's a number in q2 which isn't in q1, return false
            while (!clone2.IsEmpty())
                if (!NumInQ(q1, clone2.Remove())) return false;

            //note - this also verifies that a number in q1 doesn't appear more times in q2, e.g.
            //q1 = 88, q2=8888, will still return false, because after we remove 88 from q1, q2 will still have 88
            return true;

        }

        //return true if q is:
        //composed of consecutive doubles, which don't repeat elsewhere
        static bool ArePair(Queue<int> q)
        {
            Queue<int> clone = Clone(q); //clone so don't destroy q
            while (!clone.IsEmpty())
            {
                int num = clone.Remove(); //remove head
                if (clone.IsEmpty()) return false; //if q is empty, head doesn't have a pair
                if (num != clone.Remove()) return false; //if head doesn't match the next number, return false
                if (NumInQ(clone, num)) return false; //OK, it's a couple. but if appears again, return false
            }
            return true; //didn't find an issue, so true

        }

        //helper - return if num exists in q
        static bool NumInQ(Queue<int> q, int num)
        {
            Queue<int> tmp = new Queue<int>();
            bool numinq = false;
            while (!q.IsEmpty())
            {
                if (q.Head() == num) numinq = true;
                tmp.Insert(q.Remove());
            }
            while (!tmp.IsEmpty())
                q.Insert(tmp.Remove());
            return numinq;
        }


    }
}
