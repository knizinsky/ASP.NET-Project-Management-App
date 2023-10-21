using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekty.Models;

namespace Projekty.Controllers
{
    public class ProjectController : Controller
    {
        private static IList<Project> projects = new List<Project>
        {
            new Project(){Id = 1, Name = "Rozwój nowej strony internetowej", Description = "Projekt ten koncentruje się na opracowaniu i wdrożeniu nowej strony internetowej dla naszej firmy. Celem jest stworzenie nowoczesnej, atrakcyjnej wizualnie i funkcjonalnej strony, która pomoże w zwiększeniu widoczności naszej marki online i przyciągnięciu nowych klientów. Projekt obejmuje etapy analizy wymagań, projektowania, programowania, testów i wdrożenia.", Person="Jan Kowalski"},
            new Project(){Id = 2, Name = "Wdrożenie systemu zarządzania relacjami z klientami", Description = "Ten projekt ma na celu wdrożenie nowego systemu zarządzania relacjami z klientami (CRM) w naszej firmie. CRM pomoże nam lepiej śledzić interakcje z klientami, zautomatyzować procesy marketingowe i sprzedażowe, a także zwiększyć efektywność obsługi klienta. Etapy projektu obejmują analizę potrzeb, wybór odpowiedniego oprogramowania CRM, dostosowanie do naszych procesów biznesowych oraz szkolenie pracowników.", Person="Jan Nowak"},
            new Project(){Id = 3, Name = "Optymalizacja procesów logistycznych w magazynie", Description = "Ten projekt ma na celu poprawę efektywności i optymalizację procesów logistycznych w naszym magazynie. Chcemy zoptymalizować zarządzanie zapasami, procesy kompletacji zamówień, oraz śledzenie dostaw. Poprzez wprowadzenie bardziej zaawansowanych systemów monitorowania i automatyzacji, oczekujemy znaczącego skrócenia czasu realizacji zamówień, obniżenia kosztów i zwiększenia satysfakcji klientów.", Person="Jan Kowalski"},
            new Project(){Id = 4, Name = "Rozwój strategii marketingowej na platformach społecznościowych", Description = "Ten projekt skupia się na opracowaniu i wdrożeniu nowej strategii marketingowej dla naszej firmy na platformach społecznościowych, takich jak Facebook, Instagram i Twitter. Celem jest zwiększenie zaangażowania klientów, zwiększenie widoczności marki oraz generowanie większej liczby leadów i konwersji. Projekt obejmuje analizę rynku, określenie grup docelowych, planowanie kampanii, tworzenie treści i monitorowanie wyników.", Person="Natalia Stanowska"},
            new Project(){Id = 5, Name = "Wprowadzenie programu szkoleń i rozwoju pracowników", Description = "Ten projekt ma na celu wprowadzenie programu szkoleń i rozwoju pracowników w naszej firmie. Chcemy zainwestować w rozwój naszych pracowników, poprawiając ich umiejętności i kompetencje, co przyczyni się do zwiększenia produktywności i satysfakcji pracowników. Projekt obejmuje identyfikację potrzeb szkoleniowych, opracowanie planu szkoleń, organizację sesji szkoleniowych oraz monitorowanie postępów i wyników rozwoju pracowników.", Person="Juliusz Dubiel"},
        };

        // GET: ProjectController
        public ActionResult Index()
        {
            return View(projects);
        }

        // GET: ProjectController/Details/5
        public ActionResult Details(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));
        }

        // GET: ProjectController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProjectController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Project project)
        {
            project.Id = projects.Count + 1;
            projects.Add(project);
            return RedirectToAction("Index");
           
        }

        // GET: ProjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProjectController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Project project)
        {
            Project project1 = projects.FirstOrDefault(x => x.Id == id);
            project1.Name = project.Name;
            project1.Description = project.Description;
            project1.Person = project.Person;

            return RedirectToAction("Index");
        }

        // GET: ProjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(projects.FirstOrDefault(x => x.Id == id));
        }

        // POST: ProjectController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Project project)
        {
            Project project1 = projects.FirstOrDefault(x => x.Id == id);
            projects.Remove(project1);

            return RedirectToAction("Index");

        }
    }
}
