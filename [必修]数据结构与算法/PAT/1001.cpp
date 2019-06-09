#include <iostream>
using namespace std;

bool is_odd(int num){
	return num%2==1?true:false;
}
int main(){
	int n;
	int step=0;
	cin>>n;
	while(n!=1){
		if(is_odd(n)){
			n=(3*n+1)/2;
		}
		else{
			n=n/2;
		}
		step++;
	}
	cout<<step;
	return 0;	
}

