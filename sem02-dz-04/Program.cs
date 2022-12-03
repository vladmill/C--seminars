string checkMultiple(int num){
	if(num % 3 == 0 && num % 5 == 0) return "FizzBuzz";
	else if(num % 3 == 0) return "Fizz";
	else if(num % 5 == 0) return "Buzz";
	else return "none";
}
for(int i = 1; i<=100; i++) {
	string result = checkMultiple(i);
	if(result == "none") Console.Write($"{i} ");
	else Console.Write($"{result} ");
}
