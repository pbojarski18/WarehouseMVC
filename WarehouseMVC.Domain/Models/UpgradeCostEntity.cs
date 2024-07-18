using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseMVC.Domain.Enums;

namespace WarehouseMVC.Domain.Models;

public class UpgradeCostEntity
{
    public int Id { get; set; }
    public int PenyaPerCoinCost { get; set; }

    public double Pd4Cost { get; set; }

    public double Pd6Cost { get; set; }

    public double Pd8Cost { get; set; }

    public int MineralCost { get; set; }

    public int EronsCost { get; set;}

    public int LowSproCost {  get; set; }

    public UpgradeType UpgradeType { get; set; }

    public int CurrentLevel { get; set; }

    public int GoalLevel { get; set; }
}
