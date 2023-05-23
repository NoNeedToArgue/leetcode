// Design a class to find the kth largest element in a stream. Note that it is the kth largest element in the sorted order, not the kth distinct element.

// Implement KthLargest class:

// KthLargest(int k, int[] nums) Initializes the object with the integer k and the stream of integers nums.
// int add(int val) Appends the integer val to the stream and returns the element representing the kth largest element in the stream.

public class KthLargest {

    int _k;
    PriorityQueue<int, int> _queue = new();

    public KthLargest(int k, int[] nums)
    {
        _k = k;
        
        foreach(int num in nums)
        {
            Add(num);
        }
    }
    
    public int Add(int val)
    {
        _queue.Enqueue(val, val);

        if (_queue.Count > _k)
        {
            _queue.Dequeue();
        }

        return _queue.Peek();
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */