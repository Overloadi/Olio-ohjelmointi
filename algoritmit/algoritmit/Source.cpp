#include <iostream>
#include <stack>

using namespace std;

char kirjaimet[5] = { 'a','b','c','d','e' };

// Funktio t�h�n
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
// P��ohjelma
int main()
{	
	pino();
	// T�h�n funktion kutsu
}