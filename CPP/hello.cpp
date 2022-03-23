#include <iostream>
#include <vector>
using namespace std;

void swap(int* a, int* b) {
    int t = *a;
    *a = *b;
    *b = t;
}

int partition(vector<int>& v, int l, int h) {
    int pivot = v[h];
    int i = l;

    for (int j = l; j < h; j++)
    {
        if (v[j] < pivot) swap(&v[i++], &v[j]);
    }

    swap(&v[i], &v[h]);

    return i;
}

void sort(vector<int>& v, int l, int h) {
    if (l < h) {
        int p = partition(v, l, h);
        sort(v, l, p - 1);
        sort(v, p + 1, h);
    }
}

void print(vector<int> v) {
    for (int i = 0; i < v.size(); i++)
        cout << v[i] << " ";
}


int abs(int a, int b) {
    return a > b ? a - b : b - a;
}

// int minimumAbsoluteDifference(vector<int> arr) {
//     int p1 = arr[0], p2 = arr[1], a13, a23;
//     int d = abs(p1, p2);
//     for (int i = 1; i < arr.size(); i++)
//     {
//         a13 = abs(p1, arr[i]);
//         a23 = abs(p2, arr[i]);
//         if (a13 < a23) {
//             if (a13 < d) {
//                 p2 = arr[i];
//                 d = abs(p1, p2);
//             }
//         }
//         else if (d < a23) {
//             p1 = arr[i];
//             d = abs(p1, p2);
//         }
//     }
//     return abs(p1, p2);
// }

int minimumAbsoluteDifference(vector<int> arr) {
    sort(arr, 0, arr.size() - 1);

    int gd = 2000000001, ld = 0;
    for (int i = 1; i < arr.size(); i++)
    {
        ld = abs(arr[i - 1], arr[i]);
        if (ld < gd) gd = ld;
    }
    return gd;
}

int main()
{
    string s;
    int n, ts;

    vector<int> v;
    v.push_back(5);
    v.push_back(2);
    v.push_back(3);
    v.push_back(6);
    v.push_back(1);
    v.push_back(2);
    v.push_back(4);

    do
    {
        sort(v, 0, v.size() - 1);
        print(v);
        cin >> ts;
    } while (ts > 0);

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
