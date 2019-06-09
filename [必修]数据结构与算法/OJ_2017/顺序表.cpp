#include <iostream>
#include <cstdlib>
#define MaxSize 100
using namespace std;
//����˳����������� 
typedef int Elemtype;
typedef struct SqList{
	Elemtype data[MaxSize];
	int length;
}SqList;
//��ʼ��˳��� 
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
//���뵽��i��λ�� 
SqList *Insert_SqList(SqList *L, int i, Elemtype x){
	if((i<1)||(i<L->length+1)){
		cout<<"����λ��i������";
		exit(1); 
	}
	else if(L->length>=MaxSize-1){
		cout<<"˳����������޷����룡";
		exit(1);
	}
	for(int m=L->length-1;m>=i-1;--m){
		L->data[m+1]=L->data[m];
	}
	L->data[i-1]=x; 
	L->length++;
	return L;
}
//ɾ����iԪ�� 
SqList *Delete_Sq(SqList *L, int i){
	if((i<1)||(i>L->length)){
		cout<<"ɾ��λ��i������";
		exit(1); 
	}
	for(i;i<=L->length;++i){//�߽�������iִ�е��λ�ú󣬽���λNULLԪ����䵽ԭĩβԪ��Ϊ���±�length-1�� 
		L->data[i-1]=L->data[i];
	}
	L->length=L->length-1;
	return L;
}
//��ֵ(x)����Ԫ�ش洢λ�� 
int LocateElem_Sq(SqList *L, Elemtype x){
	int i;
	for(i=1;i<=L->length&&L->data[i-1]!=x;i++){
	}
	if(i>L->length)
		return -1;//δ�ҵ�������-1 
	else return i;//iΪ�߼��洢λ�ã��±�Ϊi-1 
}
//���洢λ��(i)����Ԫ��ֵ 
Elemtype LocateNum_Sq(SqList *L, int i){
	if(i>L->length)
		return -1;//λ�ô����ܳ��ȣ�����-1 
	else return L->data[i-1];
}
//ʵ���÷��� 
//1.������Ա�L
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
//2.ɾ��ֵΪ(x)�ĵ�һ��Ԫ�� 
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
