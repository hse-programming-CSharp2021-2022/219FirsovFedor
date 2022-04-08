#include <bits/stdc++.h>

int sol2() {
    std::vector<long long> count(10);
    int data = -1;

    size_t size = 0;
    while (data != 0) {
        std::cin >> data;
        int copy_data = data;
        int i = 0;
        while (copy_data != 0) {
            count[i] += copy_data % 3;
            count[i] %= 3;
            copy_data /= 3;
        }
        size++;
    }
    int res = 0;
    for (auto i = count.rbegin(); i != count.rend(); ++i) {
        res += *i;
        res *= 3;
    }
    if (size % 2 == 1)
        std::cout << res / 2 << std::endl;
    else
        std::cout << res << std::endl;
}