using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLib
{
    class Dictionary_Condictionary
    {

        public static void Print()
        {

        }

        public static void ExampleA()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            TaskFactory taskFactory = new TaskFactory(TaskCreationOptions.None, TaskContinuationOptions.None);
            taskFactory.StartNew(() =>
            {
                try
                {
                    dic.Add("1", "1");
                }
                catch (Exception ex)
                {
                }
            });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
            taskFactory.StartNew(() => { dic.Add("1", "1"); });
        }
    }
}
