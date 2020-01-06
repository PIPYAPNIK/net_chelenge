using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace Lib
{
    class Program
    {
        static void Main(string[] args)
        {
            Region reg1 = new Region("Center");
            Region reg2 = new Region("North");
            Region reg3 = new Region("Zavodskoy");
            Region reg4 = new Region("Old");
            Region reg5 = new Region("Null");

            List<Region> regions = new List<Region>
            {
                reg1,
                reg2,
                reg3,
                reg4,
                reg5
            };

            Library lib1 = new Library("City Lib", reg1.Id);
            Library lib2 = new Library("School Lib", reg1.Id);
            Library lib3 = new Library("Lib №3", reg2.Id);
            Library lib4 = new Library("Lib №4", reg2.Id);
            Library lib5 = new Library("Lib №5", reg2.Id);
            Library lib6 = new Library("Lib №6", reg4.Id);

            List<Library> libs = new List<Library>
            {
                lib1,
                lib2,
                lib3,
                lib4,
                lib5,
                lib6
            };

            Genre it = new Genre("IT");
            Genre fantasy = new Genre("Fantasy");
            Genre detective = new Genre("Detective");

            List<Genre> genres = new List<Genre>
            {
                it,
                fantasy,
                detective
            };

            Book languageCSharp = new Book("Programming language C#", "Troelsen", it.Id);
            Book clrViaCSharp = new Book("CLR via C#", "Rihter", it.Id);
            Book witcher = new Book("Witcher", "Sapkowski", fantasy.Id);
            Book philosopherStone = new Book("Harry Potter and the philosopher's stone", "J.K.Rowling", fantasy.Id);
            Book sherlock = new Book("The hound of the Baskervilles", "Arthur Conan Doyle", detective.Id);
            Book tenNiggers = new Book("Ten little niggers", "Agatha Christie", detective.Id);

            List<Book> books = new List<Book>
            {
                languageCSharp,
                clrViaCSharp,
                witcher,
                philosopherStone,
                sherlock,
                tenNiggers
            };

            Edition edition1 = new Edition(languageCSharp.Id, 1320);
            Edition edition2 = new Edition(languageCSharp.Id, 1234);
            Edition edition3 = new Edition(clrViaCSharp.Id, 896);
            Edition edition4 = new Edition(clrViaCSharp.Id, 823);
            Edition edition5 = new Edition(witcher.Id, 643);
            Edition edition6 = new Edition(philosopherStone.Id, 695);
            Edition edition7 = new Edition(sherlock.Id, 723);
            Edition edition8 = new Edition(sherlock.Id, 769);
            Edition edition9 = new Edition(tenNiggers.Id, 543);
            Edition edition10 = new Edition(tenNiggers.Id, 622);

            List<Edition> editions = new List<Edition>
            {
                edition1,
                edition2,
                edition3,
                edition4,
                edition5,
                edition6,
                edition7,
                edition8,
                edition9,
                edition10
            };

            BookExemplar bookExemplar1 = new BookExemplar("Solid", languageCSharp.Id, edition1.Id, lib1.Id);
            BookExemplar bookExemplar2 = new BookExemplar("Soft", languageCSharp.Id, edition2.Id, lib2.Id);
            BookExemplar bookExemplar3 = new BookExemplar("Solid", clrViaCSharp.Id, edition3.Id, lib3.Id);
            BookExemplar bookExemplar4 = new BookExemplar("Soft", clrViaCSharp.Id, edition4.Id, lib5.Id);
            BookExemplar bookExemplar5 = new BookExemplar("Solid", witcher.Id, edition5.Id, lib6.Id);
            BookExemplar bookExemplar6 = new BookExemplar("Soft", witcher.Id, edition5.Id, lib4.Id);
            BookExemplar bookExemplar7 = new BookExemplar("Solid", philosopherStone.Id, edition6.Id, lib4.Id);
            BookExemplar bookExemplar8 = new BookExemplar("Soft", philosopherStone.Id, edition6.Id, lib2.Id);
            BookExemplar bookExemplar9 = new BookExemplar("Solid", sherlock.Id, edition7.Id, lib1.Id);
            BookExemplar bookExemplar10 = new BookExemplar("Solid", sherlock.Id, edition7.Id, lib2.Id);
            BookExemplar bookExemplar11 = new BookExemplar("Soft", sherlock.Id, edition8.Id, lib3.Id);
            BookExemplar bookExemplar12 = new BookExemplar("Solid", tenNiggers.Id, edition9.Id, lib6.Id);
            BookExemplar bookExemplar13 = new BookExemplar("Soft", tenNiggers.Id, edition9.Id, lib6.Id);
            BookExemplar bookExemplar14 = new BookExemplar("Solid", tenNiggers.Id, edition10.Id, lib4.Id);
            BookExemplar bookExemplar15 = new BookExemplar("Soft", tenNiggers.Id, edition9.Id, lib2.Id);

            List<BookExemplar> bookExemplars = new List<BookExemplar>
            {
                bookExemplar1,
                bookExemplar2,
                bookExemplar3,
                bookExemplar4,
                bookExemplar5,
                bookExemplar6,
                bookExemplar7,
                bookExemplar8,
                bookExemplar9,
                bookExemplar10,
                bookExemplar11,
                bookExemplar12,
                bookExemplar13,
                bookExemplar14,
                bookExemplar15
            };

            Reader reader1 = new Reader("Nik");
            Reader reader2 = new Reader("Tom");
            Reader reader3 = new Reader("Adam");
            Reader reader4 = new Reader("Gregor");
            Reader reader5 = new Reader("Rik");
            Reader reader6 = new Reader("Null");

            List<Reader> readers = new List<Reader>
            {
                reader1,
                reader2,
                reader3,
                reader4,
                reader5,
                reader6
            };

            VisitToLibrary visitToLibrary1 = new VisitToLibrary(reader1.Id, bookExemplar1.libraryId, bookExemplar1.Id);
            VisitToLibrary visitToLibrary2 = new VisitToLibrary(reader1.Id, bookExemplar12.libraryId, bookExemplar12.Id);
            VisitToLibrary visitToLibrary3 = new VisitToLibrary(reader2.Id, bookExemplar3.libraryId, bookExemplar3.Id);
            VisitToLibrary visitToLibrary4 = new VisitToLibrary(reader3.Id, bookExemplar6.libraryId, bookExemplar6.Id);
            VisitToLibrary visitToLibrary5 = new VisitToLibrary(reader3.Id, bookExemplar11.libraryId, bookExemplar11.Id);
            VisitToLibrary visitToLibrary6 = new VisitToLibrary(reader3.Id, bookExemplar9.libraryId, bookExemplar9.Id);
            VisitToLibrary visitToLibrary7 = new VisitToLibrary(reader4.Id, bookExemplar2.libraryId, bookExemplar2.Id);
            VisitToLibrary visitToLibrary8 = new VisitToLibrary(reader5.Id, bookExemplar7.libraryId, bookExemplar7.Id);
            VisitToLibrary visitToLibrary9 = new VisitToLibrary(reader5.Id, bookExemplar8.libraryId, bookExemplar8.Id);
            VisitToLibrary visitToLibrary10 = new VisitToLibrary(reader6.Id, bookExemplar8.libraryId, bookExemplar8.Id);

            List<VisitToLibrary> visitToLibraries = new List<VisitToLibrary>
            {
                visitToLibrary1,
                visitToLibrary2,
                visitToLibrary3,
                visitToLibrary4,
                visitToLibrary5,
                visitToLibrary6,
                visitToLibrary7,
                visitToLibrary8,
                visitToLibrary9,
                //visitToLibrary10
            };

            Console.WriteLine("Вывести список названий библиотек");
            foreach(var lib in libs)
            {
                Console.WriteLine(lib.title);
            }

            Console.WriteLine("\nСгруппировать библиотеки по районам и вывести");
            var libsInRegions = regions.GroupJoin(
                libs,
                reg => reg.Id,
                lib => lib.regionId,
                (region, libr) => new
                {
                    Rigion = region.name,
                    CountLibs = libr.Count(),
                    Libs = libr.Select(p => p.title)
            });

            foreach (var group in libsInRegions)
            {
                Console.WriteLine($"{group.Rigion} количество: { group.CountLibs} ");
                foreach (var lib in group.Libs)
                {
                    Console.WriteLine(lib);
                }
            }

            Console.WriteLine("\nВывести список районов, где нет ни одной библиотеки");
            var ldError = from r in regions
                          join l in libs on r.Id equals l.regionId into q
                          where q.Count() == 0
                          select r.name;

            foreach (var r in ldError)
            {
                Console.WriteLine(r);
            }

            Console.WriteLine("\nВывести всех посетителей всех библиотек");
            var allReaders = from r in readers
                             join v in visitToLibraries.Distinct() on r.Id equals v.readerId
                             group r by r.name into g
                             select new
                             {
                                rez = g.Key
                             };
            foreach(var r in allReaders)
            {
                Console.WriteLine(r.rez);
            }

            Console.WriteLine("\nВывести всех посетителей с группировкой по библиотеке");
            //var allReadersInLibs = from v in visitToLibraries
            //                       join l in libs on v.libraryId equals l.Id
            //                       join r in readers on v.readerId equals r.Id
            //                       group new {r, l} by new {l.title, r.name} into g
            //                       select new
            //                       {
            //                           libName = g.
            //                       }


            Console.ReadKey();
        }
    }
}
