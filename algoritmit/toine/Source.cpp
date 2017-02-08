#include <iostream>
#include <stack>

using namespace std;

void menu() {
	cout << "1. Syota pinoon uusi alkio" << endl;
	cout << "2. Poista pinosta alkio" << endl;
	cout << "3. Tulosta pinon sisalto" << endl;
	cout << "4. Tulosta pinon koko" << endl;
	cout << "5. Poistu ohjelmasta" << endl;
}

int main() {
	int input;
	int input2;
	bool run = true;
	std::stack<int> stack;
	std::stack<int> temp;

	while (run == true) {
		menu();
		cin >> input;
		switch (input) {
		case 1:
			cout << "Anna luku > ";
			cin >> input2;
			stack.push(input2);
			continue;
		case 2:
			cout << "Poistetaan paallimmainen alkio pinosta";
			stack.pop();
			continue;
		case 3:
			temp = stack;
			cout << "Pinon alkiot: ";
			while (!stack.empty()) {
				cout << stack.top() << " ";
				stack.pop();
			}
			cout << endl;
			stack = temp;
			continue;
		case 4:
			cout << "Pinon koko on " << stack.size() << endl;
			continue;
		case 5:
			cout << "Suljetaan ohjelma" << endl;
			run = false;
			break;
		}
	}
}