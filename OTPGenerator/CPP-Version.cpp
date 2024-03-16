#include<bits/stdc++.h> 
using namespace std; 

string generateOTP(int len) 
{  
	string str = "abcdefghijklmnopqrstuvwxyzABCD"
			"EFGHIJKLMNOPQRSTUVWXYZ1234567890"; 
	int n = str.length(); 
	string OTP; 
	for (int i=1; i<=len; i++) 
		OTP.push_back(str[rand() % n]); 
	return(OTP); 
} 

int main() 
{ 
	srand(time(NULL)); 
	int len = 6; // OTP is 6 digits long
	printf("Your OTP: %s", generateOTP(len).c_str()); 
	return(0); 
} 
