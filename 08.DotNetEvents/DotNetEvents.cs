namespace DotNetEvents
{
    using System;

    // Define a class to hold custom event info 
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(string eventInfo)
        {
            message = eventInfo;
        }
        private string message;

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }

    // Class that publishes an event 
    class Publisher
    {

        // Declare the event using EventHandler<T> 
        public event EventHandler<CustomEventArgs> RaiseCustomEvent;

        public void FillList()
        {
            int[] listToFill = new int[100];
            for (int i = 0; i < listToFill.Length; i++)
            {
                listToFill[i] = i * i + i;
            }
            FilledListEvent(new CustomEventArgs("The list has been filled!"));

            Console.WriteLine("The content of the list is:");
            foreach (var item in listToFill)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();

        }

        // Wrap event invocations inside a protected virtual method 
        // to allow derived classes to override the event invocation behavior 
        protected virtual void FilledListEvent(CustomEventArgs e)
        {
            // Make a temporary copy of the event to avoid possibility of 
            // a race condition if the last subscriber unsubscribes 
            // immediately after the null check and before the event is raised.
            EventHandler<CustomEventArgs> handler = RaiseCustomEvent;

            // Event will be null if there are no subscribers 
            if (handler != null)
            {
                // Format the string to send inside the CustomEventArgs parameter
                e.Message += String.Format(" at {0}", DateTime.Now.ToString());

                // Use the () operator to raise the event.
                handler(this, e);
            }
        }
    }

    //Class that subscribes to an event 
    class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            id = ID;
            // Subscribe to the event
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        // Define what actions to take when the event is raised. 
        void HandleCustomEvent(object sender, CustomEventArgs e)
        {
            Console.WriteLine(id + " received this message: {0}", e.Message);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Publisher publisherOne = new Publisher();
            Subscriber subscriberOne = new Subscriber("Subscriber one", publisherOne);
            Subscriber subscriberTwo = new Subscriber("Subscriber two", publisherOne);

            // Call the method that raises the event.
            publisherOne.FillList();
        }
    }
}
