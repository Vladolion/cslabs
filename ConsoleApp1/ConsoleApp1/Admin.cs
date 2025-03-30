namespace lab2;

public class Admin: User{
	public void BlockUser(User user){
		Console.WriteLine("User " + user.UserName + " is blocked");
	}

	public Admin(string username, string email, string password) : base(username, email, password){}
	
	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Role: Administrator");
	}
}