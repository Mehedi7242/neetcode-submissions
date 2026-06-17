public class DynamicArray
{
    int[] arr;
    int capacity;
    int size;

    public DynamicArray(int capacity)
    {
        this.capacity = capacity;
        this.arr = new int[capacity];
        this.size = 0;

    }

    public int Get(int i)
    {
        if (i < 0 || i >= size)
        {
            throw new IndexOutOfRangeException();
        }

        return arr[i];
    }
    public void Set(int i, int n)
    {
        if (i < 0 || i > size) 
        {
            throw new IndexOutOfRangeException();
        }
        arr[i] = n;
    }

    public void PushBack(int n)
    {
        if(size == capacity)
        {
            Resize();
        }
        arr[size] = n;
        size++;

    }

    public int PopBack()
    {
    if(size == 0)
        {
            throw new InvalidOperationException();
        }
        size--;
        return arr[size];

    }

    private void Resize()
    {
        capacity = capacity * 2;
        int[] newArr = new int[capacity];
        for (int i = 0; i < size; i++)
        {
            newArr[i] = arr[i];
        }
        arr = newArr;
    }

    public int GetSize()
    {
        Console.WriteLine($"size: {size}");
        return size;
    }

    public int GetCapacity()
    {
        return capacity;
    }
}
