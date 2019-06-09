#include <iostream>
#include <sstream>
#include <string>
using namespace std;


int main(){
    int n=0;
    string temp;
    string num;
    stringstream ss;
    
    cin>>num;
    for(string::size_type index = 0; index!=num.size(); ++index){
        temp=num[index];
        n+=atoi(temp.c_str());
    }
}