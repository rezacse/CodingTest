#include <iostream>

using namespace std;

int main()
{
    int t, n, i, a[1001];
    cin >> t;
    while (t--)
    {
        cin >> n;
        for (i = 1; i < n; i++)
            cin >> a[i];

        cout << missingValueInArray(a, n) << endl;
    }

    return 0;
}