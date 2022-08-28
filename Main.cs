using BTD_Mod_Helper;
using MelonLoader;
using BTD6AllBuffsStack;

[assembly: MelonInfo(typeof(BTD6AllBuffsStack.Main), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
[assembly: MelonGame("Ninja Kiwi", "BloonsTD6")]

namespace BTD6AllBuffsStack
{
    using Assets.Scripts.Models;
    using Assets.Scripts.Models.Towers.Behaviors;
    using BTD_Mod_Helper.Extensions;

    public class Main : BloonsTD6Mod
    {
        public override void OnApplicationStart()
        {
            base.OnApplicationStart();
            MelonLogger.Msg("BTD6AllBuffsStack Has Loaded");
        }
        public override void OnGameModelLoaded(GameModel model)
        {
            base.OnGameModelLoaded(model);
            //Only way i could figure out how to do this
            foreach (var tower in model.towers)
            {
                try
                {
                    tower.GetBehavior<SupportModel>().maxStackSize = int.MaxValue; 
                    tower.GetBehavior<SupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<SupportModel>().showBuffIcon = true;
                } catch {}
                
                try
                {
                    tower.GetBehavior<AbilityCooldownScaleSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<AbilityCooldownScaleSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<AbilityCooldownScaleSupportModel>().isUnique = false;
                    tower.GetBehavior<AbilityCooldownScaleSupportModel>().showBuffIcon = true;
                    tower.GetBehavior<AbilityCooldownScaleSupportModel>().affectsOnlyWater = false;
                } catch{}
                try
                {
                    tower.GetBehavior<VisibilitySupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<VisibilitySupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<VisibilitySupportModel>().isUnique = false;
                    tower.GetBehavior<VisibilitySupportModel>().showBuffIcon = true;
                }catch{}

                try
                {
                    tower.GetBehavior<DamageModifierSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<DamageModifierSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<DamageModifierSupportModel>().isUnique = false;
                    tower.GetBehavior<DamageModifierSupportModel>().showBuffIcon = true;
                }catch {}
                try
                {
                    tower.GetBehavior<HeroXpScaleSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<HeroXpScaleSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<HeroXpScaleSupportModel>().isUnique = false;
                    tower.GetBehavior<HeroXpScaleSupportModel>().showBuffIcon = true;
                }catch {}

                try
                {
                    tower.GetBehavior<SupportTowerPlacementZoneModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<SupportTowerPlacementZoneModel>().appliesToOwningTower = true;
                    tower.GetBehavior<SupportTowerPlacementZoneModel>().showBuffIcon = true;
                }catch {}

                try
                {
                    tower.GetBehavior<PoplustSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<PoplustSupportModel>().maxStackSize = int.MaxValue;
                }catch {}

                try
                {
                    tower.GetBehavior<SubCommanderSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<SubCommanderSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<SubCommanderSupportModel>().isUnique = false;
                    tower.GetBehavior<SubCommanderSupportModel>().showBuffIcon = true;
                }catch {}

                try
                {
                    tower.GetBehavior<ProjectileRadiusSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<ProjectileRadiusSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<ProjectileRadiusSupportModel>().isUnique = false;
                    tower.GetBehavior<ProjectileRadiusSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<ProjectileSpeedSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<ProjectileSpeedSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<ProjectileSpeedSupportModel>().isUnique = false;
                    tower.GetBehavior<ProjectileSpeedSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<SupportRemoveFilterOutTagModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<SupportRemoveFilterOutTagModel>().appliesToOwningTower = true;
                    tower.GetBehavior<SupportRemoveFilterOutTagModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<BananaCashIncreaseSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<BananaCashIncreaseSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<BananaCashIncreaseSupportModel>().isUnique = false;
                    tower.GetBehavior<BananaCashIncreaseSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<RateSupportBombExpertModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<RateSupportBombExpertModel>().appliesToOwningTower = true;
                    tower.GetBehavior<RateSupportBombExpertModel>().isUnique = false;
                    tower.GetBehavior<RateSupportBombExpertModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<MonkeyCityIncomeSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<MonkeyCityIncomeSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<MonkeyCityIncomeSupportModel>().isUnique = false;
                    tower.GetBehavior<MonkeyCityIncomeSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<AddBehaviorToTowerSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<AddBehaviorToTowerSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<AddBehaviorToTowerSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<FreeUpgradeSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<FreeUpgradeSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<FreeUpgradeSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<TargetSupplierSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<TargetSupplierSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<TargetSupplierSupportModel>().showBuffIcon = true;
                }
                catch {}
                try
                {
                    tower.GetBehavior<SelfStackingSupportCompoundingModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<SelfStackingSupportCompoundingModel>().maxStacks = int.MaxValue;
                }
                catch {}
                try
                {
                    tower.GetBehavior<RateSupportExplosiveModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<RateSupportExplosiveModel>().appliesToOwningTower = true;
                    tower.GetBehavior<RateSupportExplosiveModel>().isUnique = false;
                    tower.GetBehavior<RateSupportExplosiveModel>().showBuffIcon = true;
                }catch {}
                try
                {
                    tower.GetBehavior<RateSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<RateSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<RateSupportModel>().isUnique = false;
                    tower.GetBehavior<RateSupportModel>().showBuffIcon = true;
                }catch {}

                try
                {
                    tower.GetBehavior<SupportShinobiTacticsModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<SupportShinobiTacticsModel>().maxStacks = int.MaxValue;
                    //tower.GetBehavior<SupportShinobiTacticsModel>().filters = null;
                }catch {}

                try
                {
                    tower.GetBehavior<DamageSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<DamageSupportModel>().isUnique = false;
                    tower.GetBehavior<DamageSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<DamageSupportModel>().showBuffIcon = true;
                }catch {}

                try
                {
                    tower.GetBehavior<PierceSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<PierceSupportModel>().isUnique = false;
                    tower.GetBehavior<PierceSupportModel>().appliesToOwningTower = true;
                    tower.GetBehavior<PierceSupportModel>().showBuffIcon = true;
                }catch {} 
                
                try
                {
                    tower.GetBehavior<RangeSupportModel>().maxStackSize = int.MaxValue;
                    tower.GetBehavior<RangeSupportModel>().isUnique = false;
                    tower.GetBehavior<RangeSupportModel>().appliesToOwningTower = false;
                    tower.GetBehavior<RangeSupportModel>().showBuffIcon = true;
                }catch {}
            }
        }
    }
}
