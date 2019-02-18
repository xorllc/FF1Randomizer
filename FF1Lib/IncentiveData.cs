﻿using System;
using System.Collections.Generic;
using System.Linq;
using RomUtilities;

namespace FF1Lib
{
	public class IncentiveData
	{
		public IncentiveData(MT19337 rng, IIncentiveFlags flags, OverworldMap map, ItemShopSlot shopSlot)
		{
			Dictionary<MapLocation, Tuple<List<MapChange>, AccessRequirement>> fullLocationRequirements = map.FullLocationRequirements;
			var forcedItemPlacements = ItemLocations.AllOtherItemLocations.ToList();
			if (!flags.NPCItems)
			{
				forcedItemPlacements.AddRange(ItemLocations.AllNPCFreeItemLocationsExcludingVendor);
				forcedItemPlacements.Add(shopSlot);
			}
			if (!flags.NPCFetchItems) forcedItemPlacements.AddRange(ItemLocations.AllNPCFetchItemLocations);
			if (!flags.Treasures) forcedItemPlacements.AddRange(ItemLocations.AllTreasures);
			var incentivePool = new List<Item>();
			if (flags.IncentivizeBridge)
			{
				incentivePool.Add(Item.Bridge);
			}
			if (flags.IncentivizeShip)
			{
				incentivePool.Add(Item.Ship);
			}
			if (flags.IncentivizeCanal)
			{
				incentivePool.Add(Item.Canal);
			}
			if (flags.IncentivizeLute)
			{
				incentivePool.Add(Item.Lute);
			}
			if (flags.IncentivizeCrown)
			{
				incentivePool.Add(Item.Crown);
			}
			if (flags.IncentivizeCrystal)
			{
				incentivePool.Add(Item.Crystal);
			}
			if (flags.IncentivizeHerb)
			{
				incentivePool.Add(Item.Herb);
			}
			if (flags.IncentivizeKey)
			{
				incentivePool.Add(Item.Key);
			}
			if (flags.IncentivizeTnt)
			{
				incentivePool.Add(Item.Tnt);
			}
			if (flags.IncentivizeAdamant)
			{
				incentivePool.Add(Item.Adamant);
			}
			if (flags.IncentivizeSlab)
			{
				incentivePool.Add(Item.Slab);
			}
			if (flags.IncentivizeRuby)
			{
				incentivePool.Add(Item.Ruby);
			}
			if (flags.IncentivizeRod)
			{
				incentivePool.Add(Item.Rod);
			}
			if (flags.IncentivizeFloater)
			{
				incentivePool.Add(Item.Floater);
			}
			if (flags.IncentivizeChime)
			{
				incentivePool.Add(Item.Chime);
			}
			if (flags.IncentivizeTail)
			{
				incentivePool.Add(Item.Tail);
			}
			if (flags.IncentivizeCube)
			{
				incentivePool.Add(Item.Cube);
			}
			if (flags.IncentivizeBottle)
			{
				incentivePool.Add(Item.Bottle);
			}
			if (flags.IncentivizeOxyale)
			{
				incentivePool.Add(Item.Oxyale);
			}
			if (flags.IncentivizeCanoe)
			{
				incentivePool.Add(Item.Canoe);
			}

			if (flags.IncentivizeXcalber)
			{
				incentivePool.Add(Item.Xcalber);
			}
			if (flags.IncentivizeMasamune)
			{
				incentivePool.Add(Item.Masamune);
			}
			if (flags.IncentivizeRibbon)
			{
				incentivePool.Add(Item.Ribbon);
			}
			if (flags.IncentivizeRibbon2)
			{
				incentivePool.Add(Item.Ribbon);
			}
			if (flags.IncentivizeOpal)
			{
				incentivePool.Add(Item.Opal);
			}
			if (flags.Incentivize65K)
			{
				incentivePool.Add(Item.Gold65000);
			}
			if (flags.IncentivizeBad)
			{
				incentivePool.Add(Item.Cloth);
			}
			if (flags.IncentivizeDefCastArmor)
			{
				incentivePool.Add(Item.WhiteShirt);
			}
			if (flags.IncentivizeOffCastArmor)
			{
				incentivePool.Add(Item.BlackShirt);
			}
			if (flags.IncentivizeOtherCastArmor)
			{
				incentivePool.Add(Item.PowerGauntlets);
			}
			if (flags.IncentivizeDefCastWeapon)
			{
				incentivePool.Add(Item.Defense);
			}
			if (flags.IncentivizeOffCastWeapon)
			{
				incentivePool.Add(Item.ThorHammer);
			}
			if (flags.IncentivizeOtherCastWeapon)
			{
				incentivePool.Add(Item.BaneSword);
			}

			var incentiveLocationPool = new List<IRewardSource>();
			if (flags.IncentivizeKingConeria)
			{
				incentiveLocationPool.Add(ItemLocations.KingConeria);
			}
			if (flags.IncentivizePrincess)
			{
				incentiveLocationPool.Add(ItemLocations.Princess);
			}
			if (flags.IncentivizeMatoya)
			{
				incentiveLocationPool.Add(ItemLocations.Matoya);
			}
			if (flags.IncentivizeBikke)
			{
				incentiveLocationPool.Add(ItemLocations.Bikke);
			}
			if (flags.IncentivizeElfPrince)
			{
				incentiveLocationPool.Add(ItemLocations.ElfPrince);
			}
			if (flags.IncentivizeAstos)
			{
				incentiveLocationPool.Add(ItemLocations.Astos);
			}
			if (flags.IncentivizeNerrick)
			{
				incentiveLocationPool.Add(ItemLocations.Nerrick);
			}
			if (flags.IncentivizeSmith)
			{
				incentiveLocationPool.Add(ItemLocations.Smith);
			}
			if (flags.IncentivizeSarda)
			{
				incentiveLocationPool.Add(ItemLocations.Sarda);
			}
			if (flags.IncentivizeCanoeSage)
			{
				incentiveLocationPool.Add(ItemLocations.CanoeSage);
			}
			if (flags.IncentivizeCubeBot)
			{
				incentiveLocationPool.Add(ItemLocations.CubeBot);
			}
			if (flags.IncentivizeFairy)
			{
				incentiveLocationPool.Add(ItemLocations.Fairy);
			}
			if (flags.IncentivizeLefein)
			{
				incentiveLocationPool.Add(ItemLocations.Lefein);
			}
			if (flags.IncentivizeVolcano)
			{
				incentiveLocationPool.Add(ItemLocations.VolcanoMajor);
			}
			if (flags.IncentivizeEarth)
			{
				incentiveLocationPool.Add(ItemLocations.EarthCaveMajor);
			}
			if (flags.IncentivizeMarsh)
			{
				incentiveLocationPool.Add(ItemLocations.MarshCaveMajor);
			}
			if (flags.IncentivizeMarshKeyLocked)
			{
				incentiveLocationPool.Add(ItemLocations.MarshCave13);
			}
			if (flags.IncentivizeSkyPalace)
			{
				incentiveLocationPool.Add(ItemLocations.SkyPalaceMajor);
			}
			if (flags.IncentivizeSeaShrine)
			{
				incentiveLocationPool.Add(ItemLocations.SeaShrineMajor);
			}
			if (flags.IncentivizeConeria)
			{
				incentiveLocationPool.Add(ItemLocations.ConeriaMajor);
			}
			if (flags.IncentivizeIceCave)
			{
				incentiveLocationPool.Add(ItemLocations.IceCaveMajor);
			}
			if (flags.IncentivizeOrdeals)
			{
				incentiveLocationPool.Add(ItemLocations.OrdealsMajor);
			}
			if (flags.IncentivizeCaravan)
			{
				incentiveLocationPool.Add(ItemLocations.CaravanItemShop1);
			}
			if (flags.IncentivizeTitansTrove)
			{
				incentiveLocationPool.Add(ItemLocations.TitansTunnel1);
			}
			var itemLocationPool =
				ItemLocations.AllTreasures.Concat(ItemLocations.AllNPCItemLocations)
						  .Where(x => !x.IsUnused && !forcedItemPlacements.Any(y => y.Address == x.Address))
						  .ToList();
			if (flags.EarlyOrdeals)
			{
				forcedItemPlacements =
					forcedItemPlacements
						.Select(x => ((x as TreasureChest)?.AccessRequirement.HasFlag(AccessRequirement.Crown) ?? false)
								? new TreasureChest(x, x.Item, x.AccessRequirement & ~AccessRequirement.Crown)
								: x).ToList();
				itemLocationPool =
					itemLocationPool
						.Select(x => ((x as TreasureChest)?.AccessRequirement.HasFlag(AccessRequirement.Crown) ?? false)
								? new TreasureChest(x, x.Item, x.AccessRequirement & ~AccessRequirement.Crown)
								: x).ToList();
				incentiveLocationPool =
					incentiveLocationPool
						.Select(x => ((x as TreasureChest)?.AccessRequirement.HasFlag(AccessRequirement.Crown) ?? false)
							? new TreasureChest(x, x.Item, x.AccessRequirement & ~AccessRequirement.Crown)
							: x).ToList();
			}
			if (flags.EarlySage)
			{
				forcedItemPlacements =
						forcedItemPlacements
							.Select(x => x.Address == ItemLocations.CanoeSage.Address
									? new MapObject(ObjectId.CanoeSage, MapLocation.CrescentLake, x.Item)
									: x).ToList();
				itemLocationPool =
						itemLocationPool
							.Select(x => x.Address == ItemLocations.CanoeSage.Address
									? new MapObject(ObjectId.CanoeSage, MapLocation.CrescentLake, x.Item)
									: x).ToList();
				incentiveLocationPool =
						incentiveLocationPool
							.Select(x => x.Address == ItemLocations.CanoeSage.Address
									? new MapObject(ObjectId.CanoeSage, MapLocation.CrescentLake, x.Item)
									: x).ToList();
			}
			if (flags.EarlySarda)
			{
				forcedItemPlacements =
					forcedItemPlacements
						.Select(x => x.Address == ItemLocations.Sarda.Address
								? new MapObject(ObjectId.Sarda, MapLocation.SardasCave, x.Item)
								: x).ToList();
				itemLocationPool =
					itemLocationPool
						.Select(x => x.Address == ItemLocations.Sarda.Address
								? new MapObject(ObjectId.Sarda, MapLocation.SardasCave, x.Item)
								: x).ToList();
				incentiveLocationPool =
					incentiveLocationPool
						.Select(x => x.Address == ItemLocations.Sarda.Address
								? new MapObject(ObjectId.Sarda, MapLocation.SardasCave, x.Item)
								: x).ToList();
			}

			MapLocation elfDoctorLocation = map.ObjectiveNPCs[ObjectId.ElfDoc];
			if (elfDoctorLocation != MapLocation.ElflandCastle)
			{
				forcedItemPlacements =
					forcedItemPlacements
						.Select(x => x.Address == ItemLocations.ElfPrince.Address
								? new MapObject(ObjectId.ElfPrince, MapLocation.ElflandCastle, x.Item, AccessRequirement.Herb, ObjectId.ElfDoc, requiredSecondLocation: elfDoctorLocation)
								: x).ToList();
				itemLocationPool =
					itemLocationPool
						.Select(x => x.Address == ItemLocations.ElfPrince.Address
								? new MapObject(ObjectId.ElfPrince, MapLocation.ElflandCastle, x.Item, AccessRequirement.Herb, ObjectId.ElfDoc, requiredSecondLocation: elfDoctorLocation)
								: x).ToList();
				incentiveLocationPool =
					incentiveLocationPool
						.Select(x => x.Address == ItemLocations.ElfPrince.Address
								? new MapObject(ObjectId.ElfPrince, MapLocation.ElflandCastle, x.Item, AccessRequirement.Herb, ObjectId.ElfDoc, requiredSecondLocation: elfDoctorLocation)
								: x).ToList();
			}

			MapLocation unneLocation = map.ObjectiveNPCs[ObjectId.Unne];
			if (unneLocation != MapLocation.Melmond)
			{
				forcedItemPlacements =
					forcedItemPlacements
						.Select(x => x.Address == ItemLocations.Lefein.Address
								? new MapObject(ObjectId.Lefein, MapLocation.Lefein, x.Item, AccessRequirement.Slab, ObjectId.Unne, requiredSecondLocation: unneLocation)
								: x).ToList();
				itemLocationPool =
					itemLocationPool
						.Select(x => x.Address == ItemLocations.Lefein.Address
								? new MapObject(ObjectId.Lefein, MapLocation.Lefein, x.Item, AccessRequirement.Slab, ObjectId.Unne, requiredSecondLocation: unneLocation)
								: x).ToList();
				incentiveLocationPool =
					incentiveLocationPool
						.Select(x => x.Address == ItemLocations.Lefein.Address
								? new MapObject(ObjectId.Lefein, MapLocation.Lefein, x.Item, AccessRequirement.Slab, ObjectId.Unne, requiredSecondLocation: unneLocation)
								: x).ToList();
			}

			foreach (var item in forcedItemPlacements.Select(x => x.Item))
			{
				incentivePool.Remove(item);
			}

			var validKeyLocations = new List<IRewardSource> { ItemLocations.ElfPrince };
			var validBridgeLocations = new List<IRewardSource> { ItemLocations.KingConeria };
			var validShipLocations = new List<IRewardSource> { ItemLocations.Bikke };
			var validCanoeLocations = new List<IRewardSource> { ItemLocations.CanoeSage };
			var everythingButOrbs = ~AccessRequirement.BlackOrb;

			if (flags.NPCFetchItems)
			{
				var validKeyMapLocations = ItemPlacement.AccessibleMapLocations(~(AccessRequirement.BlackOrb | AccessRequirement.Key), MapChange.All, fullLocationRequirements);
				validKeyLocations = itemLocationPool.Where(x => validKeyMapLocations.Contains(x.MapLocation) &&
					validKeyMapLocations.Contains((x as MapObject)?.SecondLocation ?? MapLocation.StartingLocation)).ToList();
				var keyPlacementRank = rng.Between(1, incentivePool.Count);
				if (incentivePool.Contains(Item.Key) && incentiveLocationPool.Any(x => validKeyLocations.Any(y => y.Address == x.Address)) && keyPlacementRank <= incentiveLocationPool.Count)
				{
					validKeyLocations = validKeyLocations.Where(x => incentiveLocationPool.Any(y => y.Address == x.Address)).ToList();
				}
				else if (!flags.IncentivizeKey && incentivePool.Count >= incentiveLocationPool.Count)
				{
					validKeyLocations = validKeyLocations.Where(x => !incentiveLocationPool.Any(y => y.Address == x.Address)).ToList();
				}
			}

			if (flags.NPCItems)
			{
				var everythingButCanoe = ~MapChange.Canoe;
				var startingPotentialAccess = map.StartingPotentialAccess;
				var startingMapLocations = ItemPlacement.AccessibleMapLocations(startingPotentialAccess, MapChange.None, fullLocationRequirements);
				var validShipMapLocations = ItemPlacement.AccessibleMapLocations(startingPotentialAccess | AccessRequirement.Crystal, MapChange.Bridge, fullLocationRequirements);
				var validCanoeMapLocations = ItemPlacement.AccessibleMapLocations(everythingButOrbs, everythingButCanoe, fullLocationRequirements);

				validBridgeLocations =
					itemLocationPool.Where(x => startingMapLocations.Contains(x.MapLocation) &&
						startingMapLocations.Contains((x as MapObject)?.SecondLocation ?? MapLocation.StartingLocation)).ToList();
				validShipLocations =
					itemLocationPool.Where(x => validShipMapLocations.Contains(x.MapLocation) &&
						validShipMapLocations.Contains((x as MapObject)?.SecondLocation ?? MapLocation.StartingLocation)).ToList();
				validCanoeLocations =
					itemLocationPool.Where(x => validCanoeMapLocations.Contains(x.MapLocation) &&
						validCanoeMapLocations.Contains((x as MapObject)?.SecondLocation ?? MapLocation.StartingLocation)).ToList();

				var canoePlacementRank = rng.Between(1, incentivePool.Count);
				var validCanoeIncentives = validCanoeLocations.Where(x => incentiveLocationPool.Any(y => y.Address == x.Address)).ToList();
				if (incentivePool.Contains(Item.Canoe) && canoePlacementRank <= incentiveLocationPool.Count &&
					validKeyLocations.Union(validCanoeIncentives).Count() > 1) // The Key can be placed in at least one place more than than the Canoe
				{
					validCanoeLocations = validCanoeIncentives;
				}
				else if (!flags.IncentivizeBridge && incentivePool.Count >= incentiveLocationPool.Count)
				{
					validCanoeLocations = validCanoeLocations.Where(x => !incentiveLocationPool.Any(y => y.Address == x.Address)).ToList();
				}
			}

			var nonEndgameMapLocations = ItemPlacement.AccessibleMapLocations(~AccessRequirement.BlackOrb, MapChange.All, fullLocationRequirements);

			ForcedItemPlacements = forcedItemPlacements.ToList();
			IncentiveItems = incentivePool.ToList();

			BridgeLocations = validBridgeLocations
							 .Where(x => !forcedItemPlacements.Any(y => y.Address == x.Address))
							 .ToList();
			ShipLocations = validShipLocations
							 .Where(x => !forcedItemPlacements.Any(y => y.Address == x.Address))
							 .ToList();
			KeyLocations = validKeyLocations
							 .Where(x => !forcedItemPlacements.Any(y => y.Address == x.Address))
							 .ToList();
			CanoeLocations = validCanoeLocations
							 .Where(x => !forcedItemPlacements.Any(y => y.Address == x.Address))
							 .ToList();
			IncentiveLocations = incentiveLocationPool
							 .Where(x => !forcedItemPlacements.Any(y => y.Address == x.Address))
							 .ToList();

			AllValidItemLocations = itemLocationPool.ToList();
			AllValidPreBlackOrbItemLocations = AllValidItemLocations
							 .Where(x => nonEndgameMapLocations.Contains(x.MapLocation) && nonEndgameMapLocations.Contains((x as MapObject)?.SecondLocation ?? MapLocation.StartingLocation))
							 .ToList();
		}

		public IEnumerable<IRewardSource> BridgeLocations { get; }
		public IEnumerable<IRewardSource> ShipLocations { get; }
		public IEnumerable<IRewardSource> KeyLocations { get; }
		public IEnumerable<IRewardSource> CanoeLocations { get; }
		public IEnumerable<IRewardSource> ForcedItemPlacements { get; }
		public IEnumerable<IRewardSource> AllValidItemLocations { get; }
		public IEnumerable<IRewardSource> AllValidPreBlackOrbItemLocations { get; }
		public IEnumerable<IRewardSource> IncentiveLocations { get; }
		public IEnumerable<Item> IncentiveItems { get; }

	}
}
