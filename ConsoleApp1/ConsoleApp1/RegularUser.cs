namespace lab2;

public class RegularUser: User{
	public void PostComment(){
		Console.WriteLine("Comment posted");
	}
	
	public RegularUser(string username, string email, string password) : base(username, email, password){}
	
	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Role: Regular user");
	}
}