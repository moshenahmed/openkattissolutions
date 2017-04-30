import java.util.Scanner;

class FizzBuzz {
	
	public static void main (String[] args) {
		Scanner read = new Scanner(System.in);
		
		int x = read.nextInt();
		
		int y = read.nextInt();
		
		
		int N = read.nextInt();
		while (N<=100){
		for (int i = 1; i<=N; i++){
			 if (((i % x) == 0) && ((i % y) == 0))   {
			System.out.println("FizzBuzz");
			}
			else if (i%x==0){
				System.out.println("Fizz");
		    }else if (i%y==0){
				System.out.println("Buzz");
			}
			
			
			
		
			
			else {
				System.out.println(i);
			}
			
		}
		break;	
		}	
			
		read.close();
			
			
		
}
}
