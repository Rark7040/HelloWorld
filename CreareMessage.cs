using System;

namespace helloworld{

	class CreareMessage{

		public string getMessage(){
			string[] txts = new string[3]{
				"Hello World",
				"HELLO WORLD",
				"hello world"
			}; 
			Random ramdom = new Random();
			return txts[ramdom.Next(0, 2)];
		}
	}
}