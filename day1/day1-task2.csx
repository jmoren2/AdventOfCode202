var list = System.IO.File.ReadAllLines("stuff.txt")
            .Select(x => Int32.Parse(x))
            .ToList();

if(list != null)
{
    for(int i=0; i < list.Count; ++i)
    {
        for(int j=1; j < list.Count; ++j)
        {
            for(int k=2; k < list.Count; ++k)
            {
                if( (list[i] + list[j] + list[k] ) == 2020)
                {
                    Console.WriteLine("{0} + {1} + {2} = {3}", list[i], list[j], list[k], list[i] + list[j] + list[k]);
                    Console.WriteLine("{0} * {1} * {2} = {3}", list[i], list[j], list[k], list[i] * list[j] * list[k] );
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
else{
    WriteLine("No List");
}