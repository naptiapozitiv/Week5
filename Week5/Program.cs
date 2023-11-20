using Week5;

Person person1 = new Person("John Doe", "john@example.com");
person1.SayHello();
person1.CheckIn();

Student student1 = new Student { Name = "Alice", Email = "alice@example.com", StudentId = 123 };
student1.SayHello();
student1.CheckIn();
student1.DoHomework();

Mentor mentor1 = new Mentor { Name = "Bob", Email = "bob@example.com", Specialization = "Programming" };
mentor1.SayHello();
mentor1.CheckIn();
mentor1.CheckHomework();
