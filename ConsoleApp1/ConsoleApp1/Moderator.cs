namespace lab2;

public class Moderator: User{
	public void ModerateContent(){
		Console.WriteLine("Content moderated");
	}
	
	public Moderator(string username, string email, string password) : base(username, email, password){}
	
	public override void DisplayInfo(){
		base.DisplayInfo();
		Console.WriteLine("Role: Moderator");
	}
}