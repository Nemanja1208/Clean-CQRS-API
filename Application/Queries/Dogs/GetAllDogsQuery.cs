using Domain.Models;
using MediatR;

namespace Application.Queries.Dogs
{
    public class GetAllDogsQuery : IRequest<List<Dog>>
    {
    }
}
