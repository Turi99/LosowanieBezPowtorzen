#include <iostream>
#include <vector>

bool numberIsExists(int val, std::vector<int>& vec);

int main() {
	srand(time(NULL));
	std::vector<int> tab(6);

	for (int i = 0; i < tab.size(); ++i) {
		int los = rand() % 49 + 1;
		do {
			los = rand() % 49 + 1;
		} while (numberIsExists(los,tab));
		tab[i] = los;
	}
	for (int i = 0; i < tab.size(); ++i) {
		std::cout << tab[i] << ' ';
	}
	std::cout << '\n';
}

bool numberIsExists(int val, std::vector<int> &vec) {
	int ileLiczb = 0;
	for (int i = 0; i < vec.size(); ++i) {
		if (val == vec[i]) ileLiczb++;
	}
	return ileLiczb > 0 ? true : false;
}