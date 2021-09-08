// Allow easy reference to the System namespace classes.
using System;

// This class exists only to house the entry point.
class MainApp {
   // The static method, Main, is the application's entry point.
   public static void Main() {
      // Write text to the console.
      Console.WriteLine("Hello World using C#!");
	  
	  String inject = "";
	  Console.WriteLine("Hello World using C#!" + inject );
	  
	  
	  RSACryptoServiceProvider RSA1 = new RSACryptoServiceProvider();
	  encryptedData = RSA1.Encrypt(dataToEncrypt, false);
   }
}
