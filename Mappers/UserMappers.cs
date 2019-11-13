using AutoMapper;

namespace AutoMapperDemo.Mappers
{
    public static class UserMappers
    {
        static UserMappers()
        {
            Mapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<UserMapperProfile>();
            }).CreateMapper();
        }
        internal static IMapper Mapper { get; }

        public static Dtos.User ToDto(this Entities.User entity)
        {
            return entity == null ? null : Mapper.Map<Dtos.User>(entity);
        }

        public static Entities.User ToEntity(this Dtos.User dto)
        {
            return dto == null ? null : Mapper.Map<Entities.User>(dto);
        }
    }
}
