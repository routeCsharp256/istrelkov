﻿namespace Ozon.MerchApi.Domain.Infrastructure.Repositories.Models
{
    public class ItemPack
    {
        public long Id { get; set; }

        public long MerchPackId { get; set; }

        public long StockItemId { get; set; }

        public int Quantity { get; set; }
    }
}