public class Solution {
    public int[] SortArray(int[] nums) {
        int n = nums.Length;

        // Step 1: Build the Max Heap
        for (int i = n / 2 - 1; i >= 0; i--) {
            MaxHeapify(nums, n, i);
        }

        // Step 2: Extract elements from the heap one by one
        for (int i = n - 1; i > 0; i--) {
            // Move current root to the end (swap nums[0] and nums[i])
            int temp = nums[0];
            nums[0] = nums[i];
            nums[i] = temp;

            // Call max heapify on the reduced heap
            MaxHeapify(nums, i, 0);
        }

        return nums;
    }

    private void MaxHeapify(int[] nums, int heapSize, int rootIndex) {
        int largest = rootIndex;
        int leftChild = 2 * rootIndex + 1;
        int rightChild = 2 * rootIndex + 2;

        // If left child is larger than root
        if (leftChild < heapSize && nums[leftChild] > nums[largest]) {
            largest = leftChild;
        }

        // If right child is larger than the largest so far
        if (rightChild < heapSize && nums[rightChild] > nums[largest]) {
            largest = rightChild;
        }

        // If largest is not root, swap and continue heapifying
        if (largest != rootIndex) {
            int swap = nums[rootIndex];
            nums[rootIndex] = nums[largest];
            nums[largest] = swap;

            // Recursively heapify the affected sub-tree
            MaxHeapify(nums, heapSize, largest);
        }
    }
}