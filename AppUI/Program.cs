using System;
using EventDb.BLL;
using EventDb.DAL.Models;
using EventDb.DAL.Repositories;

namespace EventDb.AppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EventDbContext();

            var userService = new UserService(new UserRepository(dbContext));
            var eventService = new EventService(new EventRepository(dbContext));
            var sessionService = new SessionService(new SessionRepository(dbContext));

            while (true)
            {
                Console.WriteLine("\n==== MAIN MENU ====");
                Console.WriteLine("1. User Operations");
                Console.WriteLine("2. Event Operations");
                Console.WriteLine("3. Session Operations");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        UserMenu(userService);
                        break;
                    case "2":
                        EventMenu(eventService);
                        break;
                    case "3":
                        SessionMenu(sessionService);
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }
        }

        static void UserMenu(UserService userService)
        {
            while (true)
            {
                Console.WriteLine("\n-- User Operations --");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. View All Users");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var user = new UserInfo();
                        Console.Write("Email ID: ");
                        user.EmailID = Console.ReadLine();
                        Console.Write("User Name: ");
                        user.UserName = Console.ReadLine();
                        Console.Write("Role (Admin/Participant): ");
                        user.Role = Console.ReadLine();
                        Console.Write("Password: ");
                        user.Password = Console.ReadLine();

                        userService.AddUser(user);
                        Console.WriteLine("✅ User added successfully.");
                        break;

                    case "2":
                        var users = userService.GetAllUsers();
                        Console.WriteLine("\n-- Users List --");
                        foreach (var u in users)
                            Console.WriteLine($"{u.EmailID}| {u.UserName} | {u.Role}");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void EventMenu(EventService eventService)
        {
            while (true)
            {
                Console.WriteLine("\n-- Event Operations --");
                Console.WriteLine("1. Add Event");
                Console.WriteLine("2. View All Events");
                Console.WriteLine("3. Update Event");
                Console.WriteLine("4. Delete Event");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        var ev = new EventDetails();
                        Console.Write("Event Name: ");
                        ev.EventName = Console.ReadLine();
                        Console.Write("Event Category: ");
                        ev.EventCategory = Console.ReadLine();
                        Console.Write("Event Date (yyyy-mm-dd): ");
                        ev.EventDate = DateTime.Parse(Console.ReadLine());
                        Console.Write("Description: ");
                        ev.Description = Console.ReadLine();
                        Console.Write("Status (Active/In-Active): ");
                        ev.Status = Console.ReadLine();

                        eventService.AddEvent(ev);
                        Console.WriteLine("✅ Event added successfully.");
                        break;

                    case "2":
                        var events = eventService.GetAllEvents();
                        Console.WriteLine("\n-- Event List --");
                        foreach (var e in events)
                            Console.WriteLine($"{e.EventId} | {e.EventName} | {e.EventCategory} | {e.Status}");
                        break;

                    case "3":
                        Console.Write("Enter Event ID to update: ");
                        int updateId = int.Parse(Console.ReadLine());
                        var updateEv = eventService.GetEventById(updateId);
                        if (updateEv != null)
                        {
                            Console.Write("New Event Name: ");
                            updateEv.EventName = Console.ReadLine();
                            Console.Write("New Category: ");
                            updateEv.EventCategory = Console.ReadLine();
                            Console.Write("New Date (yyyy-mm-dd): ");
                            updateEv.EventDate = DateTime.Parse(Console.ReadLine());
                            Console.Write("New Description: ");
                            updateEv.Description = Console.ReadLine();
                            Console.Write("New Status: ");
                            updateEv.Status = Console.ReadLine();

                            eventService.UpdateEvent(updateEv);
                            Console.WriteLine("✅ Event updated successfully.");
                        }
                        else Console.WriteLine("❌ Event not found.");
                        break;

                    case "4":
                        Console.Write("Enter Event ID to delete: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        eventService.DeleteEvent(deleteId);
                        Console.WriteLine("✅ Event deleted successfully.");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }

        static void SessionMenu(SessionService sessionService)
        {
            while (true)
            {
                Console.WriteLine("\n-- Session Operations --");
                Console.WriteLine("1. View Sessions by Event ID");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");
                var input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter Event ID: ");
                        int eid = int.Parse(Console.ReadLine());
                        var sessions = sessionService.GetSessionsByEventId(eid);
                        Console.WriteLine("\n-- Sessions --");
                        foreach (var s in sessions)
                        {
                            Console.WriteLine($"{s.SessionId} | {s.SessionTitle} | {s.SessionStart} to {s.SessionEnd}");
                        }
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
