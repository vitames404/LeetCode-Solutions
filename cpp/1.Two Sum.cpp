class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) 
    {
        // First define a vector of pair to store the values
        // and the previous indexes

        vector<pair<int, int>> sortedVec;

        // Build the new vector
        for(int i = 0; i < nums.size(); i++)
        {
            sortedVec.push_back({nums[i], i});
        }

        vector<int> result;

        sort(sortedVec.begin(), sortedVec.end());
        int i = 0, j = nums.size() - 1;
        while(i < j)
        {
            if(sortedVec[i].first + sortedVec[j].first == target)
            {
                result.push_back(sortedVec[i].second);
                result.push_back(sortedVec[j].second);
                return result;
            }
            else if(sortedVec[i].first + sortedVec[j].first < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }
        
        return result;
    }
};