using System;
using System.Collections.Generic;
using System.Linq;

namespace TestList
{
    class Program
    {
        static void Main(string[] args)
        {

            var items = new List<ItemsModel>();
            var items2 = new List<ItemsModel>();

            items.Add(new ItemsModel { NP = "01", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "01", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "01", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "02", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "02", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "02", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "03", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "03", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "03", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "04", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "04", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "04", Status = "ACEITO", ColorStatus = "Verde" });

            items.Add(new ItemsModel { NP = "05", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "05", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "05", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "06", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "06", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "06", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "07", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "07", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "07", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "08", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "08", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "08", Status = "ACEITO", ColorStatus = "Verde" });

            items.Add(new ItemsModel { NP = "09", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "09", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "09", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "10", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "10", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "10", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "11", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "11", Status = "REJEITADO", ColorStatus = "Vermelho" });
            items.Add(new ItemsModel { NP = "11", Status = "ACEITO", ColorStatus = "Verde" });
            items.Add(new ItemsModel { NP = "12", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "12", Status = "PENDENTE", ColorStatus = "Amarelo" });
            items.Add(new ItemsModel { NP = "12", Status = "REJEITADO", ColorStatus = "Vermelho" });


            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------");


            foreach (var x in items)
            {
                if (x.Status == "REJEITADO")
                {
                    items2.Add(new ItemsModel { NP = x.NP, Status = x.Status, ColorStatus = x.ColorStatus });
                }
            }
            foreach (var x in items)
            {
                if (x.Status == "PENDENTE")
                {
                    items2.Add(new ItemsModel { NP = x.NP, Status = x.Status, ColorStatus = x.ColorStatus });
                }
            }
            foreach (var x in items)
            {
                if (x.Status == "ACEITO")
                {
                    items2.Add(new ItemsModel { NP = x.NP, Status = x.Status, ColorStatus = x.ColorStatus });
                }
            }

            var DistinctItems = items2.GroupBy(x => x.NP).Select(y => y.First()).OrderBy(x => x.NP);

            foreach (var x in DistinctItems)
            {
                Console.WriteLine("NP= {0}, status= {1}, color= {2}", x.NP, x.Status, x.ColorStatus);
            }

        }
    }
}