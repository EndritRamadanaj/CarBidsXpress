using AuctionService.DTOs;
using AuctionService.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionService;

public interface IAuctionRepository
{
    Task<AuctionDTO> GetAuctionByIdAsync(Guid id);
    Task<Auction> GetAuctionEntityById(Guid id);
    Task<List<AuctionDTO>> GetAuctionsAsync(string date);
    void AddAuction(Auction auction);
    void RemoveAuction(Auction auction);
    Task<bool> SaveChangesAsync();
}
