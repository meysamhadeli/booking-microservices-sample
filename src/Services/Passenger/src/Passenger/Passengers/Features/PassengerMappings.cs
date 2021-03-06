using AutoMapper;
using BuildingBlocks.Contracts.EventBus.Messages;
using BuildingBlocks.IdsGenerator;
using Mapster;
using Passenger.Passengers.Dtos;
using Passenger.Passengers.Features.CompleteRegisterPassenger.Reads;
using Passenger.Passengers.Models.Reads;

namespace Passenger.Passengers.Features;

public class PassengerMappings : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CompleteRegisterPassengerMongoCommand, PassengerReadModel>()
            .Map(d => d.Id, s => SnowFlakIdGenerator.NewId())
            .Map(d => d.PassengerId, s => s.Id);
    }
}
