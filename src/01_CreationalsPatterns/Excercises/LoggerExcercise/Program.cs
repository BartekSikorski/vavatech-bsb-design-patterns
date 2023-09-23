using LoggerExcercise;

// TODO: Uruchom aplikację i napraw problem

MessageService messageService = new MessageService();
PrintService printService = new PrintService();

Thread thread1 = new Thread(() => messageService.Send("Hello World!"));
Thread thread2 = new Thread(() => printService.Print("Hello World!", 3));

thread1.Start();
thread2.Start();

Console.WriteLine("Press any key to exit.");
Console.ReadKey();


