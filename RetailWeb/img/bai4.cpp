#include<stdio.h>
#include<math.h>

bool KTNgTo(long x)
{
	if(x < 2)
	{
		return false;
	}
	
	for(int i=2; i<=sqrt(x); i++){
		if(x % i == 0){
			return false;
		}
	}
	
	return true;
}

int main(){
	FILE *f;
	int m=0,n=0;
	long a;
	int dem = 0;
	f = fopen("SNT.INP","r"); 
	fscanf(f,"%ld%ld",&m,&n);
	for (int i = 0; i< m*n; i++){
		fscanf(f,"%ld",&a);
		if(KTNgTo(a))
			dem++;
	}
	printf("%d",dem);
}
