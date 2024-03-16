using System; 

class GFG { 
	static string generateOTP(int len) 
	{ 
		string str = "abcdefghijklmnopqrstuvwxyzABCD"
					+ "EFGHIJKLMNOPQRSTUVWXYZ1234567890"; 
		int n = str.Length; 
		Random rand = new Random(); 
		string OTP = ""; 
		for (int i = 1; i <= len; i++) 
			OTP += (str[((int)((rand.Next() * 10) % n))]); 
		return (OTP); 
	} 

	public static void Main(string[] args) 
	{ 
		int len = 6; // OTP is 6 digits long
		Console.WriteLine("Your OTP: "
						+ generateOTP(len)); 
	} 
} 
