#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> v, int l, int h, int t) {
    if (l <= h) {
        int m = (l + h) / 2;
        if (v[m] == t) return m;
        if (t < v[m]) return binarySearch(v, l, m - 1, t);
        else return binarySearch(v, m + 1, h, t);
    }
}

int main()
{
    int t, tc;

    vector<int> v;
    v.push_back(1);
    v.push_back(2);
    v.push_back(3);
    v.push_back(4);
    v.push_back(5);
    v.push_back(6);

    do
    {
        cin >> t;
        cout << binarySearch(v, 0, v.size(), t);
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
