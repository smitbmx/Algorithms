using System;
using System.Collections.Generic;

namespace NotesStore
{
    public class NotesStore
    {
        Dictionary<string, string> notes = new Dictionary<string, string>();

        public NotesStore() { }

        public void AddNote(String state, String name)
        {
            if (name == string.Empty)
            {
                throw new Exception("Name cannot be empty");
            }

            if (IsValidState(state))
            {
                notes.Add(name, state);
            }
            else
            {
                throw new Exception(string.Format("Invalid state {0}", state));
            }

        }

        public List<String> GetNotes(String state)
        {
            List<string> res = new List<string>();

            if (IsValidState(state))
            {
                foreach (var item in this.notes)
                {
                    if (item.Value == state)
                    {
                        res.Add(item.Key);
                    }
                }
            }
            else
            {
                throw new Exception(string.Format("Invalid state {0}", state));
            }

            return res;
        }

        private bool IsValidState(string state)
        {
            if (state == "completed" || state == "active" || state == "others")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
