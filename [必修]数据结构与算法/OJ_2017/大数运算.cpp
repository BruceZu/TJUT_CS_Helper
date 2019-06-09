#include <iostream>
using namespace std;
int chai(int a[],int x)//将大数x拆分倒着存入数组  例如123->a[0]=3,a[2]=1;
{
    int i=0;
    while(x>=10)
    {
        a[i++]=x%10;
        x/=10;
    }
    a[i]=x;
    return i;//返回有效数字长度
}
void jia(int num[],int num_i,int b[],int b_i)//num代表的数加上b代表的数,num_i代表num的长度
{
    //默认mun_i>=b_i
    int i=0;
    for(i;i<=num_i;i++)//若num_i由函数chai()得来，则为i<=num_i
        num[i]+=b[i];//一一相加
    if(num[i]>=10) //进位运算
    {
        num[i+1]+=num[i]/10;
        num[i]%=10;
    }
}
void jian(int num[],int num_i,int b[],int b_i)//num代表的数减去b代表的数
{
    //默认mun_i>=b_i
    int i=0;
    for(i;i<num_i;i++)
        num[i]-=b[i];//一一相减
    if(num[i]<0) //补位运算
    {
        num[i]+=10;
        num[i+1]-=1;
    }
}
void cheng(int a[],int a_i,int b[],int b_i,int num[])//a[],b[]相乘存到num[]
{
    //默认a_i>=b_i  其实无所谓
    int i,j;
    for(i=0;i<=a_i;i++)
    {
        for(j=0;j<=b_i;j++)
        {
            num[i+j]+=a[i]*b[j];//num[]初始化为0
        }
    }
}//num[]计算完毕后要进行进位运算才可以正常以十进制展示结果
int main(){
	int *a, *b, *num,i=0;
	char ch;
	while(1){
		ch=getchar();
		if(ch!='+'||ch!='-'||ch!='*'){
			a[i]=(int)(ch-'0');
			i++;
		}
		else break;
	}
	switch(ch){
		case '+':{
			big_plus(a,i);
			break;
		}
		case '-':{
			big_sub(a,i);
			break;
		}
		case '*':{
			big_multi(a,i);
			break;
		}
		default: break;
	}
	return 0;
} 
