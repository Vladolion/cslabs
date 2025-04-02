namespace lab2;

class Program{
	static void Main(){
		List<User> users = new List<User>();
		
		users.Add(new Admin("Adomin","sonoibarade@gira.gira","usseewa"));
		users.Add(new Moderator("Atarashii Gakko","pineapplecryptonite@nai.nai","otonaburu"));
		users.Add(new RegularUser("Adolf Gaga","paparazi@gaga.oohlala","abracadabra"));

		foreach (User user in users){
			user.DisplayInfo();
            Console.WriteLine("---------------");
        }

		foreach (User user in users)
		{
			if (user is Admin) {
				(user as Admin).BlockUser(users[2]);
			}
			if (user is Moderator)
			{
				(user as Moderator).ModerateContent();
			}
			if (user is RegularUser) {
				(user as RegularUser).PostComment();
			}
		}

		List<string> passwords = new List<string> { "usseewa", "NAI", "abracadabra" };

        Console.WriteLine("---------------");
        for (int i = 0; i < users.Count; i++) {
            Console.WriteLine(users[i].UserName + ": "+users[i].Authenticate(passwords[i]));
		}
	}
}

