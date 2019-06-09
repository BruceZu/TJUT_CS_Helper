/*********************Copyright  1997-2017  Duke.Wang********************/
//���Ա�---����
//�汾��1.0
//˵������ 
/************************************************************************/
#include <iostream>
#include <cstdlib>

using namespace std;
//����ڵ�����
typedef int ElemType;
typedef struct LNode{  
	ElemType data;
	struct LNode *next;
}LNode;
//����ͷָ��
typedef LNode *LinkList;
void ListDisplay(LinkList L);
//���嵥�����������
//1.ͷ�巨����������OK 
LinkList CreateList_head(LinkList L, ElemType num){
	ElemType x;
	LinkList p;
	L=(LinkList)malloc(sizeof(LNode));
	L->next=NULL;
	for(int i=0;i<num;i++){
		cin>>x;
		p=(LinkList)malloc(sizeof(LNode));
		p->data=x;
		p->next=L->next;
		L->next=p;
	}
	return L;
} 
//2. ɾ�����㣺ɾ��������������ֵ�ظ��Ľڵ�
ElemType ListFind_REP(LinkList L){
	ElemType num;
	LinkList p,q;
	p=L->next;
	while(p!=NULL){
		 q=p->next;
		 while(q!=NULL){
		 	if(p->data==q->data){
		 		num=p->data;
		 		return num;
		 	}
		 	q=q->next;
		 }
		 p=p->next;
	}
	return -1;
}
LinkList ListDelete_NUM(LinkList L, ElemType num){
	LinkList p,q;
	p=L;
	while(p->next!=NULL){
		if(p->next->data==num){
			q=p->next;
	        p->next=p->next->next;//ɾ��ָ�����ַ�
	        free(q);
	    }
		else p=p->next;
	} 
	return L;
}
LinkList ListDelete_REP(LinkList L){
	while(1){
		ElemType num;
		num=ListFind_REP(L);
		if(num==-1) return L;
		L=ListDelete_NUM(L,num);		
	}
} 
//3.�������OK
void ListDisplay(LinkList L){
    //�ж�������ͷ�ڵ�next��ǿգ�������ǿ�
	if(L->next!=NULL){
		LinkList p=L->next;
        //�ٽ�����������Ԫ��next��ǿգ�����һ�ڵ����
		while(p->next){
			cout<<p->data<<" ";
			p=p->next;
		}
		cout<<p->data<<endl;//�����ʽ��Ҫ��������һ��Ԫ��
	}
	else cout<<"-1"<<endl;
} 
//4.���õ�����OK 
LinkList Convert_List(LinkList L){
     LinkList p,q;
     p=L->next;
     L->next=NULL;
     while(p)
     {
         q=p;
         p=p->next;
         q->next=L->next;
         L->next=q;
     }
     return L;
}
//5.���ض�ֵǰ����ڵ㣺OK
LinkList Insert_num_Lnode(LinkList L, int Node, int num){
	LinkList p=L;
	LinkList q;
	if(p==NULL) return L;
	else{
		while(p->next){
			if(p->next->data==num){
				q=(LinkList)malloc(sizeof(LNode));
				q->data=Node;
				q->next=p->next;
				p->next=q;
				p=p->next;
			}
			p=p->next;
		}
	}
	return L;
}
//������ʵ��
int main(){
	int T;
	int n;
	int q; 
	int type;
	LinkList L;
	cin>>T;
	for(int i=0;i<T;i++){
		cin>>n;
		L=CreateList_head(L,n);	
		cin>>q;
		for(int i=0;i<q;i++){
			cin>>type;
			switch(type){
				case 1:{
					int x,y;
					cin>>x;
					cin>>y;
					Insert_num_Lnode(L,x,y);
					break;
				}
				case 2:{
					Convert_List(L);	
					break;
				}
				case 3:{
					ListDelete_REP(L);
					break;
				}
				case 4:{
					ListDisplay(L);
					break;
				}
				default:{
					break;
				}
			}
		}	
	}
	
	return 0;
}
