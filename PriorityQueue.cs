using System;
using System.Collections.Generic;

public class PriorityQueue<T>
{
    private List<T> heap;
    private readonly IComparer<T> comparer;

    public int Count => heap.Count;

    public PriorityQueue() : this(Comparer<T>.Default)
    {
    }

    public PriorityQueue(IComparer<T> comparer)
    {
        heap = new List<T>();
        this.comparer = comparer;
    }

    public void Enqueue(T item)
    {
        heap.Add(item);
        HeapifyUp(heap.Count - 1);
    }

    public T Dequeue()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Priority queue is empty.");

        T firstItem = heap[0];
        int lastIndex = heap.Count - 1;
        heap[0] = heap[lastIndex];
        heap.RemoveAt(lastIndex);

        if (heap.Count > 1)
            HeapifyDown(0);

        return firstItem;
    }

    public T Peek()
    {
        if (heap.Count == 0)
            throw new InvalidOperationException("Priority queue is empty.");

        return heap[0];
    }

    private void HeapifyUp(int index)
    {
        while (index > 0)
        {
            int parentIndex = (index - 1) / 2;
            if (comparer.Compare(heap[index], heap[parentIndex]) >= 0)
                break;

            SwapElements(index, parentIndex);
            index = parentIndex;
        }
    }

    private void HeapifyDown(int index)
    {
        int leftChildIndex = 2 * index + 1;
        int rightChildIndex = 2 * index + 2;
        int smallestChildIndex = index;

        if (leftChildIndex < heap.Count && comparer.Compare(heap[leftChildIndex], heap[smallestChildIndex]) < 0)
            smallestChildIndex = leftChildIndex;

        if (rightChildIndex < heap.Count && comparer.Compare(heap[rightChildIndex], heap[smallestChildIndex]) < 0)
            smallestChildIndex = rightChildIndex;

        if (smallestChildIndex != index)
        {
            SwapElements(index, smallestChildIndex);
            HeapifyDown(smallestChildIndex);
        }
    }

    private void SwapElements(int i, int j)
    {
        T temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }
}

