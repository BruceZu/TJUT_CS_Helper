//00_A+B
#include <iostream>
#include <list>
#include <exception>
using namespace std;


int input_INT_NUM(){
    int temp;
    cin >> temp;
    if (temp - (int)temp != 0){
        throw "Error: The type of input words is not Interger Number";
    }
    return temp;
}
int main(){
    
    int num;
    cin>>num;
    
    int A, B;
    list<int> count;
    list<int>::iterator flag;  
    for(int i=0;i<num;i++){
        try{
            A=input_INT_NUM();
            B=input_INT_NUM();
            count.push_back(A+B);
        }catch(const char* msg){
            cerr << msg << endl;
        }
    }
    for(flag=count.begin();flag!=count.end();++flag){
            cout<<*flag<<endl;
    }

    return 0;

}