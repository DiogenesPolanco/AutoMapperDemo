using System;
using AutoMapper;
using AutoMapperDemo.Mappers;

namespace AutoMapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var entityUser = new Entities.User()
            {
                Name = "userEntity",
                Age = 18,
                //Birthdate = new DateTime(1991, 1, 1)
            };

            ////  AutoMapper  
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Dtos.User, Entities.User>().ReverseMap();
            });
            var mapper = configuration.CreateMapper();
            var dtoUser2 = mapper.Map<Dtos.User>(entityUser);
            var entityUser2 = mapper.Map<Entities.User>(dtoUser2);


            ////  AutoMapper  
             var dtoUser3 = entityUser.ToDto();
            var entityUser3 = dtoUser3.ToEntity();

            Console.WriteLine("Hello World!");
        }
    }
}
