/*********************Copyright  1997-2017  Duke.Wang********************/
//��Homework-Chap3-4������ƥ��
//�汾��1.0
//˵������һ�����
/************************************************************************/
#include <iostream>
#include <cstdlib>
using namespace std;
//����ڵ�����
typedef char ElemType;
typedef struct LNode{  
	ElemType ch;
	struct LNode *next;
}LNode;
typedef LNode *Linkstack; 
//1.��������ջ 
Linkstack Createstack(){
	Linkstack S;
	S=(Linkstack)malloc(sizeof(LNode));
	S->next=NULL;
	return S;
}
//2.��ջ
Linkstack Pushstack(Linkstack S,ElemType c){
	Linkstack p;
	p=(Linkstack)malloc(sizeof(LNode));
	p->ch=c;
	p->next=S->next;
	S->next=p;
	return S;
}
//3.��ջ
Linkstack Popstack(Linkstack S){
	Linkstack p;
	p=S->next;
	S->next=p->next;
	free(p);
	return S;
}
ElemType Gettop(Linkstack S){
	if(S->next!=NULL)
		return S->next->ch;
	else return ' '; 
}
int Judge_Pair(){
	Linkstack p;
	ElemType c;
	int sign=1;
	p=Createstack();
	c=getchar();
	while(c!='\n'){
		switch(c){
			case '(':{
				p=Pushstack(p,c);
				break;
			}
			case ')':{
				if(Gettop(p)=='(')
					p=Popstack(p);
				else sign=0;
				break;
			}
		}
		if(sign==0) break;
		else c=getchar();
	}
	if(p->next!=NULL) sign=0;
	return sign;
}
void Judge_out(int a){
	if(a==1)
		cout<<"YES";
	else if(a==0) cout<<"NO";
}
int main(){
	Judge_out(Judge_Pair());
	return 0;
}
