#include <iostream>
#include <cstdlib>
#define MaxSize 100
using namespace std;
//定义顺序表数据类型 
typedef int Elemtype;
typedef struct SqList{
	Elemtype data[MaxSize];
	int length;
}SqList;
//初始化顺序表 
SqList *init_SqList(SqList *L, int num){
	Elemtype x;
	L=(SqList*)malloc(sizeof(SqList));
	if(!L)
		exit(1);
	for(int i=0;i<num;i++){
		cin>>x;
		L->data[i]=x;
	}
	L->length=num;
	
	return L; 
}
//插入到第i个位置 
SqList *Insert_SqList(SqList *L, int i, Elemtype x){
	if((i<1)||(i<L->length+1)){
		cout<<"插入位置i不合理！";
		exit(1); 
	}
	else if(L->length>=MaxSize-1){
		cout<<"顺序表已满，无法插入！";
		exit(1);
	}
	for(int m=L->length-1;m>=i-1;--m){
		L->data[m+1]=L->data[m];
	}
	L->data[i-1]=x; 
	L->length++;
	return L;
}
//删除第i元素 
SqList *Delete_Sq(SqList *L, int i){
	if((i<1)||(i>L->length)){
		cout<<"删除位置i不合理";
		exit(1); 
	}
	for(i;i<=L->length;++i){//边界条件：i执行到最长位置后，将后位NULL元素填充到原末尾元素为（下标length-1） 
		L->data[i-1]=L->data[i];
	}
	L->length=L->length-1;
	return L;
}
//按值(x)查找元素存储位置 
int LocateElem_Sq(SqList *L, Elemtype x){
	int i;
	for(i=1;i<=L->length&&L->data[i-1]!=x;i++){
	}
	if(i>L->length)
		return -1;//未找到，返回-1 
	else return i;//i为逻辑存储位置，下标为i-1 
}
//按存储位置(i)查找元素值 
Elemtype LocateNum_Sq(SqList *L, int i){
	if(i>L->length)
		return -1;//位置大于总长度，返回-1 
	else return L->data[i-1];
}
//实验用方法 
//1.输出线性表L
void Display_Sq(SqList *L){
	if(L->length==0) 
		cout<<"-1"<<endl;
	else{ 
		cout<<L->data[0];
		for(int i=1;i<L->length;i++){
			cout<<" "<<L->data[i]; 
		}
		cout<<endl; 
	}
} 
//2.删除值为(x)的第一个元素 
SqList *DeleteNum_Sq(SqList *L, int x){
	if(L->length==0)
		cout<<"-1"<<endl;	
	else {
		int i;
		for(i=0;i<L->length;i++){
			if(L->data[i]==x)
				break; 
		}
		if(i==L->length&&L->data[i]!=x){
			cout<<"-1"<<endl;
			return L;
		}
		L = Delete_Sq(L, i+1);
	}
	return L;
}
int main(){
	SqList *L;
	int T;
	cin>>T;
	int n,q,type;
	for(int i=0;i<T;i++){
		cin>>n;
		L=init_SqList(L,n);
		cin>>q;
		for(int j=0;j<q;j++){
			cin>>type;
			switch(type){
				case 0:{
					Display_Sq(L); 
					break;
				}
				case 1:{
					int x;
					cin>>x;
					DeleteNum_Sq(L,x);
					break;
				}
				default:break;
			}
		}
	}
	return 0;
}
