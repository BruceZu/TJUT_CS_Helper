#include <iostream>
using namespace std;

int main(){
	int a[11];
	for(int i=0;i<10;i++){
		a[i]=0;
	}
	for(int t, i=1;i<=05;i++){
		cin>>t;
		a[t]++;
	}
	for(int i=0;i<10;i++){
		for(int j=1;j<=a[i];j++)
			cout<<i<<" ";
	} 
	return 0;
} 
