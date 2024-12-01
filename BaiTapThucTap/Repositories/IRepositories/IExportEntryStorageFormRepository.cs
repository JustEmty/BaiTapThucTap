﻿using BaiTapThucTap.Models;

namespace BaiTapThucTap.Repositories.IRepositories
{
    public interface IExportEntryStorageFormRepository
    {
        public Task<List<ExportEntryStorageForm>> GetAllAsync();
        public Task<ExportEntryStorageForm> GetAsync(string entryStorageFormId);
        public Task CreateAsync(ExportEntryStorageForm entryStorageForm);
        public Task UpdateAsync(ExportEntryStorageForm exportEntryStorageForm);
    }
}
