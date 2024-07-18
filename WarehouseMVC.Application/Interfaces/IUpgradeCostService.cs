using WarehouseMVC.Domain.Models;

namespace WarehouseMVC.Application.Interfaces;

public interface IUpgradeCostService
{
    UpgradeSummaryEntity GetUpgradeSummary(UpgradeCostEntity upgradeCostEntity);
}
