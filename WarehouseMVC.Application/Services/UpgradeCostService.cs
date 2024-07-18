using WarehouseMVC.Application.Interfaces;
using WarehouseMVC.Domain.Enums;
using WarehouseMVC.Domain.Models;

namespace WarehouseMVC.Application.Services;

public class UpgradeCostService : IUpgradeCostService
{
    private Dictionary<int, (double, int, int, double)> upgradeGearChanceDictionary = new Dictionary<int, (double, int, int, double)>()
    {
        {0, (90, 10, 10, 2)},
        {1, (85, 14, 14, 4)},
        {2, (80, 20, 20, 8)},
        {3, (54, 27, 27, 15)},
        {4, (40.5, 38, 38, 30)},
        {5, (27, 54, 54, 60)},
        {6, (18, 75, 75, 75)},
        {7, (9, 105, 105, 125)},
        {8, (4.5, 148, 148, 250)},
        {9, (1.8, 207, 207, 300)}
    };

    public UpgradeSummaryEntity GetUpgradeSummary(UpgradeCostEntity upgradeCostEntity)
    {
        UpgradeSummaryEntity upgradeSummary = new UpgradeSummaryEntity();
        switch (upgradeCostEntity.UpgradeType)
        {
            case UpgradeType.Gear:
                for (int i = upgradeCostEntity.CurrentLevel; i <= upgradeCostEntity.GoalLevel; i++)
                {
                    var currentUpgradeGearChance = upgradeGearChanceDictionary[i];
                    var averageAttempts = (int)(100 / currentUpgradeGearChance.Item1);
                    if (i < 6)
                    {
                        upgradeSummary.LowSproAmount += averageAttempts * i;
                        upgradeSummary.MineralsAmount += averageAttempts * i * currentUpgradeGearChance.Item2;
                        upgradeSummary.EronsAmount += averageAttempts * i * currentUpgradeGearChance.Item3;
                        upgradeSummary.PenyaAmount += averageAttempts * i * (currentUpgradeGearChance.Item4 * 1000);
                    }
                    else
                    {
                        upgradeSummary.SproAmount += averageAttempts;
                        upgradeSummary.MineralsAmount += averageAttempts * currentUpgradeGearChance.Item2;
                        upgradeSummary.EronsAmount += averageAttempts * currentUpgradeGearChance.Item3;
                        upgradeSummary.PenyaAmount += averageAttempts * (currentUpgradeGearChance.Item4 * 1000);
                    }
                }
                return upgradeSummary;
                break;
            default:
                return upgradeSummary;
                break;
        }
    }


}
