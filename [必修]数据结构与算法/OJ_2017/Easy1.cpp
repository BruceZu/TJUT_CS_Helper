#include <iostream>
using namespace std;
long long int power(long long int a, long long int N){
    int result = 1;
    a = a % 1000000007;
    while(N > 0){
        if(N % 2 == 1) 
			result = (result * a) % 1000000007;
        a = (a * a) % 1000000007;
        N /= 2;
    }
    return result;
}
int main(){
	long long int a;
	long long int b;
	cin>>a>>b;
	long long int q=1;
	q=power(a,b);
	cout<<q;	
	return 0;
} 
