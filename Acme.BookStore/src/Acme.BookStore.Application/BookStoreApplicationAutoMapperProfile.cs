using Acme.BookStore.Authors;
using Acme.BookStore.Books;
using AutoMapper;

namespace Acme.BookStore;

public class BookStoreApplicationAutoMapperProfile : Profile
{
    public BookStoreApplicationAutoMapperProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<Author, AuthorDto>();

        CreateMap<CreateUpdateBookDto, Book>();
        CreateMap<Author, AuthorLookupDto>();

    }
}
