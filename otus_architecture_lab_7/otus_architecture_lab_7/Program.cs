using System.IO;


namespace otus_architecture_lab_7
{
    class Program
    {
        static void Main(string[] args)
        {
            CmdParser cmds = new CmdParser().Init(args);

            int start = cmds.GetIntValue("-start");
            int end = cmds.GetIntValue("-end");
            string outPath = cmds.GetValue("-op");

            var iterator = CreateFibonachiIterator(start, end);

            WriteToFile(outPath, iterator);
        }


        static IIterable<int> CreateFibonachiIterator(int start, int end)
        {
            IFibonachiIteratorMaker maker = null;

            if (start < end)
            {
                maker = new FibonachiIteratorUpMaker();
            }
            else
            {
                maker = new FibonachiIteratorDownMaker();
            }

            return maker.Make(start, end);
        }


        static void WriteToFile(string path, IIterable<int> iterator)
        {
            using (StreamWriter file = new StreamWriter(path))
            {
                while (iterator.HasNext())
                {
                    file.WriteLine(iterator.Next().ToString());
                }
            }
        }
    }
}
