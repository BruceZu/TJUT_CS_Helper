#include <iostream>
using namespace std;
int chai(int a[],int x)//������x��ֵ��Ŵ�������  ����123->a[0]=3,a[2]=1;
{
    int i=0;
    while(x>=10)
    {
        a[i++]=x%10;
        x/=10;
    }
    a[i]=x;
    return i;//������Ч���ֳ���
}
void jia(int num[],int num_i,int b[],int b_i)//num�����������b�������,num_i����num�ĳ���
{
    //Ĭ��mun_i>=b_i
    int i=0;
    for(i;i<=num_i;i++)//��num_i�ɺ���chai()��������Ϊi<=num_i
        num[i]+=b[i];//һһ���
    if(num[i]>=10) //��λ����
    {
        num[i+1]+=num[i]/10;
        num[i]%=10;
    }
}
void jian(int num[],int num_i,int b[],int b_i)//num���������ȥb�������
{
    //Ĭ��mun_i>=b_i
    int i=0;
    for(i;i<num_i;i++)
        num[i]-=b[i];//һһ���
    if(num[i]<0) //��λ����
    {
        num[i]+=10;
        num[i+1]-=1;
    }
}
void cheng(int a[],int a_i,int b[],int b_i,int num[])//a[],b[]��˴浽num[]
{
    //Ĭ��a_i>=b_i  ��ʵ����ν
    int i,j;
    for(i=0;i<=a_i;i++)
    {
        for(j=0;j<=b_i;j++)
        {
            num[i+j]+=a[i]*b[j];//num[]��ʼ��Ϊ0
        }
    }
}//num[]������Ϻ�Ҫ���н�λ����ſ���������ʮ����չʾ���
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
