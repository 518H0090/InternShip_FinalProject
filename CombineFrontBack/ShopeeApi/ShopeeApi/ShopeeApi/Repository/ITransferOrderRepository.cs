﻿using ShopeeApi.Dtos;
using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface ITransferOrderRepository
    {
        Task<TransferOrder> CreateTransferOrder(TransferOrder request, int restaurantId);

        Task<TransferOrder> UpdateTransferOrder(TransferOrder request);

        Task<IEnumerable<TransferOrder>> GetAllTransferOrder(string username);

        Task<bool> ExistUser(string username);


        Task<bool> DeleteTransferOrder(TransferOrder request);

        Task<bool> isTransferOrderPayment(TransferOrder request);

        Task<bool> isExistTransferOrder(TransferOrder request);
    }
}
