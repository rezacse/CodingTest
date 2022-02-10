#include <iostream>
#include <vector>
using namespace std;

vector<int> missingNumbers(vector<int> arr, vector<int> brr)
{
    vector<int> rest;

    rest.push_back(4);

    return rest;
}

int main()
{
    vector<int> arr{1, 2, 3};
    vector<int> brr{1, 2, 3, 4};
    int n = 5;

    cin >> n;

    vector<int> result = missingNumbers(arr, brr);

    for (size_t i = 0; i < result.size(); i++)
    {
        cout << result[i];

        if (i != result.size() - 1)
        {
            cout << " ";
        }
    }

    cout << "\n";

    return 0;
}
