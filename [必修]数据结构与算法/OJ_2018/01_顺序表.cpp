//01_顺序表
#include <iostream>
#define MAX_SIZE 100
using namespace std;

class Seqlist{
    private:
        int data[MAX_SIZE]={0};
        int length=0;
    public:
        Seqlist();
        Seqlist(int num);
        bool Out();
        bool Delete(int x);
};
Seqlist::Seqlist(){
    cin>>this->length;
    try{
        for(int i=0; i<this->length; i++){
            cin>>this->data[i];
        }       
    }catch(const std::exception&){
        
    }
}
Seqlist::Seqlist(int num){
    try{
        this->length=num;
        for(int i=0; i<num; i++){
            cin>>this->data[i];
        }
    }catch (const std::exception&){
        
    }
}
//输出顺序表
bool Seqlist::Out(){
    //空串状态：输出-1
    if(this->length==0){
        cout<<"-1"<<endl;
    }
    //
    else{
        cout<<this->data[0];
        for(int i=1;i<this->length;i++){
            cout<<" "<<this->data[i];
        }
        cout<<endl;
    }
}
bool Seqlist::Delete(int x){
    int temp_length=this->length;
    bool flag = true;
    for(int i=0; i<this->length; i++){
        if((this->data[i])==x){
            for(int j=i; j<this->length; j++){
                if(j!=this->length){
                	this->data[j]=this->data[j+1];
                }
                else{
                	break;
                }
            }
            this->length-=1;
            break;
        }
    }
    //未找到该元素，输出-1
    if(this->length == temp_length){
        flag = false;
        cout<<"-1"<<endl;
    }
    return flag;
}

class tool{
    private:
        int op_Num;
        Seqlist ls;
    public:
        tool();
        bool menu();
};

tool::tool(){
    cin>>this->op_Num;
}

bool tool::menu(){
    try{
        int type;
        for(int i=0; i<this->op_Num; i++){
            cin>>type;
            switch(type){
                case 0:{
                    this->ls.Out();
                    break;
                }
                case 1:{
                    int x;
                    cin>>x;
                    this->ls.Delete(x);
                    break;
                }

            }
        }
        
    }catch (const std::exception&){
        
    }

}

int main(){
    int T;
    cin>>T;
    for(int i=0; i<T; i++){
        tool t;
        t.menu();
    }
    return 0;
}
