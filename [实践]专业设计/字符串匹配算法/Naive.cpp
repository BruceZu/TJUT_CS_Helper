#include <iostream>
#include <string>
using namespace std;

int getGreater(int a, int b){
	return a>b?a:b;
}
int main(){
	string a="";
	string b="农业技术与应用";
	
	int flag_a, flag_b;
	int count=0;
	int MAX=getGreater(a.length(),b.length()); 
	for(flag_a=0;flag_a<a.length();flag_a++){
		cout<<flag_a<<endl; 
		for(flag_b=flag_a;flag_b<b.length();flag_b++){
			if(b.at(flag_b)==a.at(flag_a)){
				flag_a=flag_b;
				count++;
				break;
			}
		}
	}
	double per = (double)count/MAX;
	
	cout<<per;
	return 0;
}
