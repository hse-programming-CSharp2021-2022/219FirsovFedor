#include <bits/stdc++.h>;

const unsigned int MIN = 200'000'000;
const unsigned int MAX = 400'000'000;

const unsigned int log_2 = log2(MAX);
const unsigned int log_3 = log(MAX) / log(3);

int task_dop() {
    int n;
    std::set<unsigned int> ans;

    for (int i = 0; i <= log_2; i++) {
        for (int j = 0; j <= log_3; j++) {
            n = pow(2, i) * pow(3, j);
            if (n > MIN && n <= MAX) {
                ans.insert(n);
            }
        }
    }

    for (auto it = ans.begin(); it != ans.end(); ++it) {
        std::cout << *it << std::endl;
    }
}