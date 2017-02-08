#include <iostream>
#include <stack>

using namespace std;

char kirjaimet[5] = { 'a','b','c','d','e' };

// Funktio tähän
void pino() {
	std::stack<char> stack;
	std::stack<char> temp;
	int x = 0;

	for (int i = 0; i < 5; i++) {
		cout << endl << "Lisataan kirjain pinoon: " << kirjaimet[i] << endl;
		stack.push(kirjaimet[i]);
		cout << "Pinon koko: " << stack.size() <<  " Pinossa kirjaimia: ";
		temp = stack;
		while (!stack.empty()) {
			cout << stack.top() << " ";
			stack.pop();
		}
		stack = temp;
	}

}
// Pääohjelma
int main()
{	
	pino();
	// Tähän funktion kutsu
}