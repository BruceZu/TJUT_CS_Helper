/*********************************ATM��ģ�����*********************************/ 
/***************Copyright 1997-2016 Tony Wang. All Rights Reserved.*************/ 
/**********************���������BUG��������ʦָ��o(^��^)o**********************/
/*Ŀǰ��֪BUG��
1.���˵��л�ʱ���ܴ��ڴ��� 
2.��ȡ��ʱ�����ݿ��ܻ���� 
3.������ͬ���裬�����������־��ܽ���
4.�������ʼ�趨���Ϊ10000Ԫ������ȡ��ʱ���ܴ���С��10000ԪҲ��ʾ�������� 
/*******************************************************************************/
#include <stdio.h>
#include <stdlib.h>
void show_choice()
	{	system("pause");
		system("cls"); 
		printf("��ӭʹ��TJUT��ATM������Ա��\n");
		printf("a.���\tb.ȡ��\n");
		printf("c.��ѯ\tq.�˳�\n");
	}
char get_first() 
	{
		char ch;
		ch = getchar();
/*		while(getchar()!='\n')
			continue;
*/
		return ch;	
	}
char get_choice()//��ȡ��ȷ����ѡ���BUG�� 
	{
		char ch;
		ch = get_first();
		getchar();
		if(ch!='a'&&ch!='b'&&ch!='c'&&ch!='q')
			{
				printf("������ѡ��a, b, c, �˿�������q\n");
				get_choice();
			}
		return ch;	
	}
int get_int()//��ȡ100���������� 
	{
		int input;
		scanf("%d",&input);
		if(input%100!=0)
			{
				printf("�������ܲ���100ԪΪ��׼�Ľ�����������:");
				get_int();
			}
		return input;	
	}
	
int get_key()//�����ȡ����BUG������keyֵ��û�м���main�� 
	{
		int key;
		printf("��ӭʹ��TJUT��ATM��Ա��\n");
		printf("������������п������������룬��ɺ��밴ȷ�ϣ�");
		printf("\n������6λ����:");
		scanf("%d",&key);
		return key; 
	}
int main()
	{
		int input, key, error; 
		int money = 10000;//��ʼ0Ԫ 
		get_key();
		for(error=0; error<2; error++)
		{	
		if(key!=123456)
			{
			printf("����������������룡\n");
			get_key();
			}
		else break;
		}
		if(error==2) exit(1);
		show_choice();
		getchar();
		char choice;
		while((choice=get_choice())!='q')
			{
				switch(choice)
					{
						case'a':
								printf("����������ֵ:\n");
								get_int();
								money = money + input; 
								printf("���ɹ���\n");
								show_choice();
								break;
						case'b':
								printf("������ȡ����ֵ:");
								get_int();
								while(input > money)
								{
									printf("�������㣬���������룡\n");																	
									input = get_int();									
								}
								money -= input;
								printf("ȡ��ɹ���\n");
								show_choice();
								break;
						case'c':
								printf("����ǰ�˻����Ϊ%dԪ\n", money);
								show_choice();
								break;
					}
					getchar();
			}
		printf("���պ����Ŀ�Ƭ\n��лʹ�ã��ټ�!");
		
		return 0;	 
	}

