#include <iostream>
#include <vector>
using namespace std;

int binarySearch(vector<int> v, int t) {
    int l = 0, h = v.size() - 1, i = -1;
    while (l <= h) {
        int m = (l + h) / 2;
        if (v[m] == t) {
            i = m;
            break;
        }
        if (t < v[m]) h = m - 1;
        else l = m + 1;
    }
    return i;
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
        cout << binarySearch(v, t);
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
