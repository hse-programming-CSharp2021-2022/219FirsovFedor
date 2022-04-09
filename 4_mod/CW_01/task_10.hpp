#include <bits/stdc++.h>

int task_10() {
    long long n;
    std::cin >> n;
    std::vector<int> ans;

    for (long long i = 1; i * i <= n; ++i) {
        if (n % i == 0) {
            ans.push_back(i);
        }
    }

    for (int i : ans) {
        std::cout << i << ' ';
    }

    // тут магия с кастом -1 у unsigned int
    for (size_t i = ans.size() - 1; i != -1; --i) {
        if (ans[i] * ans[i] != n)
            std::cout << n / ans[i] << ' ';
    }
}