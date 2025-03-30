namespace lab2;

public class User{
	public string UserName { get; private set; }
	public string Email { get; private set; }
	private string _password;

	public User(string username, string email, string password){
		UserName = username;
		Email = email;
		_password = password;
	}
	
	public void SetPassword(string newPassword){
		_password = newPassword;
	}

	public bool Authenticate(string inputPassword){
		if(_password != inputPassword) return false;
		return true;
	}

	public virtual void DisplayInfo(){
		Console.WriteLine("Name: " + UserName);
		Console.WriteLine("Email: " + Email);
	}
}