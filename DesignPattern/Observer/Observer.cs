// In case you need some guidance: https://refactoring.guru/design-patterns/observer
        // Your code goes here... make sure to add this features:
        //1. Allow to hold the observer's name (e.g. when user Adam wants to observe the subject)
        //2. Creating the Observer
        //3. Registering the Observer with the Subject
        //4. Removing the Observer from the Subject
        //5. Observer will get a notification from the Subject using the following Method
        namespace DesignPattern.Observer
        {
            public class ConcreteObserver : IObserver
            {
                public string UserName { get; private set; }

                public ConcreteObserver(string userName)
                {
                    UserName = userName;
                }

                public void AddSubscriber(ISubject subject)
                {
                    subject.RegisterObserver(this);
                    Console.WriteLine(UserName + " has been subscribed for notifications."+ UserName +" will be notified!");
                }

                public void RemoveSubscriber(ISubject subject)
                {
                    subject.RemoveObserver(this);
                    Console.WriteLine(UserName + " has been unsubscribed from notifications,"+ UserName +" no longer will be notified!");
                }

                public void Update(string availability)
                {
                    Console.WriteLine("Dear " + UserName + ", the product is now " + availability + ", presented for your information");
                }
            }
        }

    
