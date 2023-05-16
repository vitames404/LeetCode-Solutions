class Solution {
public:
    bool containsDuplicate(vector<int>& nums) {    
    
        // This can be solved using a set and comparing
        // the size of the First array and the set

        set<int> set(nums.begin(), nums.end());

        return set.size() == nums.size() ? false : true;
 
    }
};