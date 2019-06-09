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
  int a[MAXINT]={10,5,4,6,5,4,3,2,1,1,1};     //乘数或除数
  int b[MAXINT]={7,7,6,5,4,3,2,1};             //乘数或除数
  int c[MAXINT],d[MAXINT];                    //c[]存放商d[]存放余数
  int div=1234;                               //乘数或除数
  int k=0;
  int *res=&k;                                //余数整数指针
  bigplus(a,b,c);
  bigsub(a,b,c);  
  bigmult2(a,b,c);  
//  bigdiv2(a,b,c,d);
  getchar();
  return 0;
}
 
int bigplus(int a[],int b[],int c[])  //整数加
{
    int i,len;
    len=(a[0]>b[0]?a[0]:b[0]);  //a[0] b[0]保存数组度len较
    for(i=0;i<MAXINT;i++)       //数组清0
        c[i]=0;
    for (i=1;i<=len;i++)        //计算每位值
    {
        c[i]+=(a[i]+b[i]);
        if (c[i]>=10)
        {
           c[i]-=10;            //于10取位
           c[i+1]++;            //高位加1
        }
    }
    if (c[i+1]>0) len++;
        c[0]=len;                //c[0]保存结数组实际度
    printf("Big integers add: ");
    for (i=len;i>=1;i--)
                printf("%d",c[i]); //打印结
        printf("\n");
    return 0;
}
int bigsub(int a[],int b[],int c[]) //整数减
{
    int i,len;
    len=(a[0]>b[0]?a[0]:b[0]);  //a[0]保存数字度len较
    for(i=0;i<MAXINT;i++)       //数组清0
        c[i]=0;
    if (compare(a,b)==0)        //比较a,b
    {
       printf("Result:0");
       return 0;
    }
    else if (compare(a,b)>0)
    for (i=1;i<=len;i++)        //计算每位值
    {
        c[i]+=(a[i]-b[i]);
        if (c[i]<0)
        {
           c[i]+=10;            //于0原位加10
           c[i+1]--;            //高位减1
        }
    }
    else
        for (i=1;i<=len;i++)        //计算每位值
        {
        c[i]+=(b[i]-a[i]);
        if (c[i]<0)
        {
           c[i]+=10;            //于0原位加10
           c[i+1]--;            //高位减1
        }
        }
    while (len>1 && c[len]==0)  //掉高位0
        len--;
    c[0]=len;
    printf("Big integers sub= ");
    if (a[0]<b[0]) printf("-");
    for(i=len;i>=1;i--)         //打印结
        printf("%d",c[i]);
    printf("\n");
    return 0;
}
 
int bigmult2(int a[],int b[],int c[])      //高精度乘高精度
{
    int i,j,len;
    for (i=0;i<MAXINT;i++)                  //数组清0
        c[i]=0;
    for (i=1;i<=a[0];i++)                  //乘数循环
      for (j=1;j<=b[0];j++)                //乘数循环
      {
         c[i+j-1]+=a[i]*b[j];              //每位计算累加
         c[i+j]+=c[i+j-1]/10;              //每结累加高位
         c[i+j-1]%=10;                     //计算每位
      }
   len=a[0]+b[0];                          //取度
   while (len>1 && c[len]==0)              //掉高位0
      len--;
   c[0]=len;
   printf("Big integers multi: ");
   for (i=len;i>=1;i--)                    //打印结
      printf("%d",c[i]);
   printf("\n"); 
}
 
//int bigdiv2(int a[],int b[],int c[],int d[])  //高精度除高精度
//{
//   int i,j,len;
//   if (compare(a,b)<0)                        //除数较直接打印结
//   {
//     printf("Result:0";
//     printf("Arithmetic compliment:";
//     for (i=a[0];i>=1;i--) printf("%d",a[i]);
//     printf("\n";
//     return -1;           
//   }
//   for (i=0;i<MAXINT;i++)                     //商余数清0
//   {
//      c[i]=0;
//      d[i]=0;
//   }
//   len=a[0];d[0]=0;
//   for (i=len;i>=1;i--)                       //逐位相除
//   {
//      for (j=d[0];j>=1;j--)
//        d[j+1]=d[j];
//      d[1]=a[i];                              //高位*10+各位
//      d[0]++;                                 //数组d度增1
//      while (compare(d,b)>=0)                 //比较d,b
//      {
//            for (j=1;j<=d[0];j++)              //做减d-b
//            {
//                d[j]-=b[j];
//                if (d[j]<0)
//                {
//                   d[j]+=10;
//                   d[j+1]--;
//                }
//            }
//                while (j>0 && d[j]==0)        //掉高位0
//                      j--;
//                d[0]=j;
//            c[i]++;                           //商所位值加1
//      }
//   }
//   j=b[0];
//   while (c[j]==0 && j>0) j--;                //求商数组c度
//     c[0]=j;
//   printf("Big integers div result: ";
//   for (i=c[0];i>=1;i--)                      //打印商
//     printf("%d",c[i]);
//   printf("\tArithmetic compliment: ";       //打印余数
//   for (i=d[0];i>=1;i--)
//     printf("%d",d[i]);
//   printf("\n");
//}
