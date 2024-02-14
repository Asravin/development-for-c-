void SortSelection(int[] collection)
    {
    int size = collection.Lenght;
    for(int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for(int j = i + 1; j < size - 1; i++)
        {
            if(collection[j] < collection[pos])
            {
                pos = j;
            } 
        }
        int temp = collection[i];
        collection[i] = collection[pos];
        collection[pos] = temp
    }
}
