// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
public class Solution {
    public int LastStoneWeight(int[] stones) {
        if(stones.Length == 0)
            return 0;
        while(stones.Length > 1){
            Array.Sort(stones);
            var remain = stones[stones.Length-1] - stones[stones.Length-2];
            stones[stones.Length-2] = remain;
            Array.Resize(ref stones, stones.Length-1);
        }
        return stones[stones.Length-1];
    }
}