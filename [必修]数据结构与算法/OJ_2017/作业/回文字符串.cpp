/*********************Copyright  1997-2017  Duke.Wang********************/
//【Homework-Chap3-5】回文字符串
//版本：1.0
//说明：第一版测试
/************************************************************************/
#include <iostream>
#include <cstring>
using namespace std;
//定义节点类型
int main(){
	char a[201],s[201];
	int i,len,mid,next,top;
	
	gets(a);
	len=strlen(a);
	mid=len/2-1;
	
	top=0;
	for(i=0;i<=mid;i++){
		s[++top]=a[i];
	}
	if(len%2==0) next=mid+1;
	else next=mid+2;
	
	for(i=next;i<=len-1;i++){
	if(a[i]!=s[top]) break;
	top--; 
	}
	if(top==0) cout<<"YES";
	else cout<<"NO";
	
	return 0;
}
