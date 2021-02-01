var list = System.IO.File.ReadAllLines("stuff.txt")
            .Select(x => Int32.Parse(x))
            .ToList();

if(list != null)
{
    for(int i=0; i < list.Count; ++i)
    {
        for(int j=1; j < list.Count; ++j)
        {
            if(list[i] + list[j] == 2020)
            {
                Console.WriteLine("{0} + {1} = {2}", list[i], list[j], list[i] + list[j]);
                Console.WriteLine("{0} * {1} = {2}", list[i], list[j], list[i] * list[j] );
                Console.WriteLine("\n");
            }
        }
    }
}
else{
    WriteLine("No List");
}