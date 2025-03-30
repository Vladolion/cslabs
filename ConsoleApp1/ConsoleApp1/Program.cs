namespace lab2;

class Program{
	static void Main(){
		List<User> users = new List<User>();
		
		users.Add(new Admin("Adomin","sonoibarade@gira.gira","usseewa"));
		users.Add(new Moderator("Atarashii Gakko","pineapplecryptonite@nai.nai","otonaburu"));
		users.Add(new RegularUser("Adolf Gaga","paparazi@gaga.oohlala","abracadabra"));

		foreach (User user in users){
			user.DisplayInfo();
		}
	}
}

