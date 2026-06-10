#include <iostream>

using namespace::std;

int main(int argc, char** argv) 
{
	int numero = 0, suma = 0;
	
	while(suma < 60)
	{
		cout << "Ingrese un numero\n"; cin >> numero;
		
		if(numero%2 == 0)
			suma += numero * numero;
		else
			suma += numero + numero;		
	}	
	
	cout << "La suma total es " << suma;
	
	return 0;
}



