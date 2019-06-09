#include <stdio.h>
#define MAXINT 1000
int compare(int a[],int b[]);
int bigplus(int a[],int b[],int c[]);
int bigsub(int a[],int b[],int c[]);
int bigmult(int a[],unsigned int b,int c[]);
int bigmult2(int a[],int b[],int c[]);
int bigdiv(int a[],unsigned int b,int c[],int *d);
//int bigdiv2(int a[],int b[],int c[],int d[]);
int main(int argc, char *argv[])
{
  int a[MAXINT]={10,5,4,6,5,4,3,2,1,1,1};     //���������
  int b[MAXINT]={7,7,6,5,4,3,2,1};             //���������
  int c[MAXINT],d[MAXINT];                    //c[]�����d[]�������
  int div=1234;                               //���������
  int k=0;
  int *res=&k;                                //��������ָ��
  bigplus(a,b,c);
  bigsub(a,b,c);  
  bigmult2(a,b,c);  
//  bigdiv2(a,b,c,d);
  getchar();
  return 0;
}
 
int bigplus(int a[],int b[],int c[])  //������
{
    int i,len;
    len=(a[0]>b[0]?a[0]:b[0]);  //a[0] b[0]���������len��
    for(i=0;i<MAXINT;i++)       //������0
        c[i]=0;
    for (i=1;i<=len;i++)        //����ÿλֵ
    {
        c[i]+=(a[i]+b[i]);
        if (c[i]>=10)
        {
           c[i]-=10;            //��10ȡλ
           c[i+1]++;            //��λ��1
        }
    }
    if (c[i+1]>0) len++;
        c[0]=len;                //c[0]���������ʵ�ʶ�
    printf("Big integers add: ");
    for (i=len;i>=1;i--)
                printf("%d",c[i]); //��ӡ��
        printf("\n");
    return 0;
}
int bigsub(int a[],int b[],int c[]) //������
{
    int i,len;
    len=(a[0]>b[0]?a[0]:b[0]);  //a[0]�������ֶ�len��
    for(i=0;i<MAXINT;i++)       //������0
        c[i]=0;
    if (compare(a,b)==0)        //�Ƚ�a,b
    {
       printf("Result:0");
       return 0;
    }
    else if (compare(a,b)>0)
    for (i=1;i<=len;i++)        //����ÿλֵ
    {
        c[i]+=(a[i]-b[i]);
        if (c[i]<0)
        {
           c[i]+=10;            //��0ԭλ��10
           c[i+1]--;            //��λ��1
        }
    }
    else
        for (i=1;i<=len;i++)        //����ÿλֵ
        {
        c[i]+=(b[i]-a[i]);
        if (c[i]<0)
        {
           c[i]+=10;            //��0ԭλ��10
           c[i+1]--;            //��λ��1
        }
        }
    while (len>1 && c[len]==0)  //����λ0
        len--;
    c[0]=len;
    printf("Big integers sub= ");
    if (a[0]<b[0]) printf("-");
    for(i=len;i>=1;i--)         //��ӡ��
        printf("%d",c[i]);
    printf("\n");
    return 0;
}
 
int bigmult2(int a[],int b[],int c[])      //�߾��ȳ˸߾���
{
    int i,j,len;
    for (i=0;i<MAXINT;i++)                  //������0
        c[i]=0;
    for (i=1;i<=a[0];i++)                  //����ѭ��
      for (j=1;j<=b[0];j++)                //����ѭ��
      {
         c[i+j-1]+=a[i]*b[j];              //ÿλ�����ۼ�
         c[i+j]+=c[i+j-1]/10;              //ÿ���ۼӸ�λ
         c[i+j-1]%=10;                     //����ÿλ
      }
   len=a[0]+b[0];                          //ȡ��
   while (len>1 && c[len]==0)              //����λ0
      len--;
   c[0]=len;
   printf("Big integers multi: ");
   for (i=len;i>=1;i--)                    //��ӡ��
      printf("%d",c[i]);
   printf("\n"); 
}
 
//int bigdiv2(int a[],int b[],int c[],int d[])  //�߾��ȳ��߾���
//{
//   int i,j,len;
//   if (compare(a,b)<0)                        //������ֱ�Ӵ�ӡ��
//   {
//     printf("Result:0";
//     printf("Arithmetic compliment:";
//     for (i=a[0];i>=1;i--) printf("%d",a[i]);
//     printf("\n";
//     return -1;           
//   }
//   for (i=0;i<MAXINT;i++)                     //��������0
//   {
//      c[i]=0;
//      d[i]=0;
//   }
//   len=a[0];d[0]=0;
//   for (i=len;i>=1;i--)                       //��λ���
//   {
//      for (j=d[0];j>=1;j--)
//        d[j+1]=d[j];
//      d[1]=a[i];                              //��λ*10+��λ
//      d[0]++;                                 //����d����1
//      while (compare(d,b)>=0)                 //�Ƚ�d,b
//      {
//            for (j=1;j<=d[0];j++)              //����d-b
//            {
//                d[j]-=b[j];
//                if (d[j]<0)
//                {
//                   d[j]+=10;
//                   d[j+1]--;
//                }
//            }
//                while (j>0 && d[j]==0)        //����λ0
//                      j--;
//                d[0]=j;
//            c[i]++;                           //����λֵ��1
//      }
//   }
//   j=b[0];
//   while (c[j]==0 && j>0) j--;                //��������c��
//     c[0]=j;
//   printf("Big integers div result: ";
//   for (i=c[0];i>=1;i--)                      //��ӡ��
//     printf("%d",c[i]);
//   printf("\tArithmetic compliment: ";       //��ӡ����
//   for (i=d[0];i>=1;i--)
//     printf("%d",d[i]);
//   printf("\n");
//}
