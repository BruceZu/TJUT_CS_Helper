/*********************Copyright  1997-2017  Duke.Wang********************/
//线性表---链表
//版本：1.0
//说明：无 
/************************************************************************/
#include <iostream>
#include <cstdlib>

using namespace std;
//定义节点类型
typedef int ElemType;
typedef struct LNode{  
	ElemType data;
	struct LNode *next;
}LNode;
//定义头指针
typedef LNode *LinkList;
void ListDisplay(LinkList L);
//定义单链表基本操作
//1.头插法建立单链表：OK 
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
//2. 删除运算：删除单链表中数据值重复的节点
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
	        p->next=p->next->next;//删除指定的字符
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
//3.输出链表：OK
void ListDisplay(LinkList L){
    //判断条件：头节点next域非空，即链表非空
	if(L->next!=NULL){
		LinkList p=L->next;
        //临界条件：数据元素next域非空，即下一节点存在
		while(p->next){
			cout<<p->data<<" ";
			p=p->next;
		}
		cout<<p->data<<endl;//满足格式化要求，输出最后一个元素
	}
	else cout<<"-1"<<endl;
} 
//4.倒置单链表：OK 
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
//5.在特定值前插入节点：OK
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
//主函数实现
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
