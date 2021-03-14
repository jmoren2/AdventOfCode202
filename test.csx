int[] list = {1,2,3,4,2,5,1,4,5};
var test = new List<int>(list);

test.ForEach( l => Write(l + " "));

for(int i=0; i < list.Length; ++i)
{
    for(int j=i+1; j < list.Length; ++j)
    {
        if(list[i] == list[j])
        {
            list = RemoveAt(list, j);
        }
    }
}

public int[] RemoveAt(int[] IndicesArray, int index)
{
    int[] list2 = new int[list.Length - 1 ];
    
    for(int i =0; i < list.Length - 1; ++i){
        if(i != index)
        {
            list2[i] = list[i]; 
        }
    }
    return list2;
}


WriteLine();
var test2 = new List<int>(list);
test2.ForEach( l => Write(l + " "));

