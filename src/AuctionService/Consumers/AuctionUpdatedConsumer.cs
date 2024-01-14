﻿using Contracts;
using MassTransit;

namespace AuctionService;

public class AuctionUpdatedConsumer : IConsumer<Fault<AuctionUpdated>>
{
    public async Task Consume(ConsumeContext<Fault<AuctionUpdated>> context)
    {
        Console.WriteLine("--> Consuming faulty updating");

        var exception = context.Message.Exceptions.First();

        if (exception.ExceptionType == "System.ArgumentException")
        {
            context.Message.Message.Model = "FooBar";
            await context.Publish(context.Message.Message);
        }
        else 
        {
            Console.WriteLine("Not an argument exception - update error dashboard somewhere");
        }
    }
}
