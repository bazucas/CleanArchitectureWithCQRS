using Bookify.Application.Abstractions.Messaging;

namespace Bookify.Application.Apartments.Search.Apartments;

public sealed record SearchApartmentsQuery(
    DateOnly StartDate,
    DateOnly EndDate) : IQuery<IReadOnlyList<ApartmentResponse>>;
