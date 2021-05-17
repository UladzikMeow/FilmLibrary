using FilmLibrary.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmLibrary.Data
{
    public class DBObjects
    {
        public static void Initial(FilmContext content)
        {
            if (!content.Films.Any())
                content.Films.AddRange(Films.Select(c => c.Value));
            if (!content.Actors.Any())
                content.Actors.AddRange(Actors.Select(c => c.Value));
            if (!content.Genres.Any())
                content.Genres.AddRange(Genres.Select(c => c.Value));
           /* if (!content.Users.Any())
                content.Users.AddRange(Users.Select(c => c.Value));
            if (!content.Roles.Any())
                content.Roles.AddRange(Roles.Select(c => c.Value));*/
            content.SaveChanges();
        }

        private static Dictionary<string, Film> films;
        public static Dictionary<string, Film> Films
        {
            get
            {
                if (films == null)
                {
                    var list = new Film[]
                    {
                        new Film {
                        
                        Title = "Матрица",
                        Description = "Жизнь Томаса Андерсона разделена на две части: днём он — самый обычный офисный работник, получающий нагоняи от начальства, а ночью превращается в хакера по имени Нео, и нет места в сети, куда он бы не смог проникнуть. Но однажды всё меняется. Томас узнаёт ужасающую правду о реальности.",
                        MovieImg = "/imgFilms/matrix_01.png",
                        
                        },
                        new Film {

                        Title = "Матрица 2",
                        Description = "Борцы за свободу Нео, Тринити и Морфеус продолжают руководить восстанием людей против Армии Машин. Для уничтожения системы репрессий и эксплуатации они вынуждены прибегнуть не только к арсеналу превосходного оружия, но и к своим выдающимся навыкам.",
                        MovieImg = "/imgFilms/matrix_02.png",
                       
                        },
                        new Film {
                      
                        Title = "Астрал",
                        Description = "Джош и Рене переезжают с детьми в новый дом, но не успевают толком распаковать вещи, как начинаются странные события. Необъяснимо перемещаются предметы, в детской звучат странные звуки… Но настоящий кошмар начинается для родителей, когда их десятилетний сын Далтон впадает в кому. Все усилия врачей в больнице помочь мальчику безуспешны.",
                        MovieImg = "/imgFilms/astral_01.png",
                        
                        },
                        new Film {
                        
                        Title = "Джентельмены",
                        Description = "Один ушлый американец ещё со студенческих лет приторговывал наркотиками, а теперь придумал схему нелегального обогащения с использованием поместий обедневшей английской аристократии и очень неплохо на этом разбогател. Другой пронырливый журналист приходит к Рэю, правой руке американца, и предлагает тому купить киносценарий, в котором подробно описаны преступления его босса при участии других представителей лондонского криминального мира — партнёра-еврея, китайской диаспоры, чернокожих спортсменов и даже русского олигарха.",
                        MovieImg = "/imgFilms/gentelmen_01.png",
                       
                        },
                        new Film {
                    
                        Title = "Риддик",
                        Description = "Преданный своими и брошенный умирать на пустынной планете, Риддик сражается с хищниками за жизнь и становится сильнее и опаснее себя прежнего. Открывшие на него охоту галактические наемники оказываются пешками в грандиозном плане отмщения. С врагами, возникающими на его пути тогда, когда это нужно самому Риддику, он начинает поход во имя мести.",
                        MovieImg = "/imgFilms/riddik_01.png",
                        
                        },
                    };
                    films = new Dictionary<string, Film>();
                    foreach (Film el in list)
                        films.Add(el.Title, el);
                }
                return films;
            }
        }

        private static Dictionary<string, Actor> actors;
        public static Dictionary<string, Actor> Actors
        {
            get
            {
                if (actors == null)
                {
                    var list = new Actor[]
                    {
                        new Actor
                        {
                            Name = "Киану Ривз",
                            Films = new List<Film>(){ Films["Матрица"], Films["Матрица 2"] }
                        },
                        new Actor
                        {
                            Name = "Вин Дизель",
                            Films = new List<Film>(){ Films["Риддик"] }
                        },
                        new Actor
                        {
                            Name = "Патрик Уилсон",
                            Films = new List<Film>(){ Films["Астрал"] }
                        },
                        new Actor
                        {
                         
                            Name = "Мэттью МакКонахи",
                            Films = new List<Film>(){ Films["Джентельмены"] }

                        },
                    };
                    actors = new Dictionary<string, Actor>();
                    foreach (Actor el in list)
                        actors.Add(el.Name, el);
                }
                return actors;
            }
        }

        private static Dictionary<string, Genre> genres;
        public static Dictionary<string, Genre> Genres
        {
            get
            {
                if (genres == null)
                {
                    var list = new Genre[]
                    {
                        new Genre{
                            Gener = "Боевик",
                            Films = new List<Film>(){Films["Матрица"], Films["Матрица 2"], Films["Риддик"], Films["Джентельмены"] }
                        },
                        new Genre
                        {
                            Gener = "Хоррор",
                            Films = new List<Film>(){Films["Астрал"]}
                        },
                        new Genre{
                            Gener = "Фантастика",
                            Films = new List<Film>(){Films["Матрица"], Films["Матрица 2"], Films["Риддик"], Films["Астрал"] }
                        },
                    };
                    genres = new Dictionary<string, Genre>();
                    foreach (Genre el in list)
                        genres.Add(el.Gener, el);
                }
                return genres;
            }
        }


        /*private static Dictionary<string, User> users;
        public static Dictionary<string, User> Users
        {
            get
            {
                if (users == null)
                {
                    var list = new User[]
                    {
                        new User{

                            UserName = "Uladzislau",
                            Password = "1234",
                            Email = "ulad@ulad.ru",
                            RoleId = Roles["admin"].Id,
                            Role = Roles["admin"]
                        },
                        new User{

                            UserName = "Sasha",
                            Password = "1234",
                            RoleId = Roles["user"].Id,
                            Role = Roles["user"],
                            Email = "sasha@ulad.ru"
                        },
                        new User
                        {

                            UserName = "Dima",
                            Password = "1234",
                            RoleId = Roles["user"].Id,
                            Role = Roles["user"],
                            Email = "dima@ulad.ru"
                        },
                    };
                    users = new Dictionary<string, User>();
                    foreach (User el in list)
                        users.Add(el.UserName, el);
                }
                return users;
            }
        }
        private static Dictionary<string, Role> roles;
        public static Dictionary<string, Role> Roles
        {
            get
            {
                if (roles == null)
                {
                    var list = new Role[]
                    {
                        new Role{
                            Name = "admin",
                        },
                        new Role{
                            Name = "user",
                        }
                    };
                    roles = new Dictionary<string, Role>();
                    foreach (Role el in list)
                        roles.Add(el.Name, el);
                }
                return roles;
            }
        }*/
    }
}

