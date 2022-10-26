﻿using ShopeeApi.Models;

namespace ShopeeApi.Repository
{
    public interface IRecordRepository
    {
        Task<SelectFoodRecord> NewRecord(SelectFoodRecord request, string username);

        Task<IEnumerable<SelectFoodRecord>> GetAllRecordFollowUsername(string username);

        Task<IEnumerable<SelectFoodRecord>> GetTop6RecordFollowUsername(string username);

        Task<bool> DeleteRecord(int recordId, string username);

        Task<float> TotalPriceRecord(string username);

        Task<int> CountNumberRecord(string username);
    }
}