#include <iostream>
#include <vector>
using namespace std;

// [-4,-1,0,3,10]
vector<int> sortedSquares(vector<int>& nums) {
    int e = nums.size() - 1, ns = 0, ne = 0, s = 0;
    while (s < e) {
        ns = nums[s] >= 0 ? nums[s] : -1 * nums[s];
        ne = nums[e] >= 0 ? nums[e] : -1 * nums[e];
        // if (ns == 0) s++;
        if (ns == ne) s++;
        else if (ns > ne) {
            nums[e] = ns;
            nums[s] = ne;
            s = 0;
        }
        else if (ne > ns) {
            nums[e] = ne * ne;
            e--;
        }
    }
    //nums[s] = nums[s]* nums[s];

    return nums;
}

int main()
{
    int t, tc;

    vector<int> v;
    v.push_back(-5);
    v.push_back(-5);
    v.push_back(-1);
    v.push_back(0);
    v.push_back(4);
    v.push_back(4);
    v.push_back(11);

    do
    {
        cin >> t;
        sortedSquares(v);
        //print(v);
        cin >> tc;
    } while (t > 0);

    // vector<int> arr{1, 2, 3};
    // vector<int> brr{1, 2, 3, 4};
    // int n = 5;

    // cin >> n;

    // vector<int> result = missingNumbers(arr, brr);

    // for (size_t i = 0; i < result.size(); i++)
    // {
    //     cout << result[i];

    //     if (i != result.size() - 1)
    //     {
    //         cout << " ";
    //     }
    // }

    // cout << "\n";

    return 0;
}
