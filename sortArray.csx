
int[] data = {2,1,3,1};
var list = new List<int>(data);

list.ForEach( x => Write(x + " "));

var newdata = sortArray(data);

WriteLine();
var newList = new List<int>(newdata);
newList.ForEach( x => Write(x + " "));

public int[] sortArray(int[] toSort)
{
    for(int i=0; i < toSort.Length - 1; ++i)
    {
        for(int j=i+1; j < toSort.Length; ++j){
            if(toSort[i] > toSort[j])
            {
                int temp = toSort[i];
                toSort[i] = toSort[j];
                toSort[j] = temp;
            }
        }
    }
    return toSort;
}