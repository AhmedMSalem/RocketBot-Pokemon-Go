﻿using System.Threading;
using System.Threading.Tasks;
using PoGo.NecroBot.Logic.Common;
using PoGo.NecroBot.Logic.Logging;
using PoGo.NecroBot.Logic.State;
using POGOProtos.Inventory.Item;
using POGOProtos.Networking.Responses;

namespace NecroBot2.Logic.Tasks
{
    internal class UseLuckyEggConstantlyTask
    {
        public static async Task Execute(ISession session, CancellationToken cancellationToken)
        {
            if (!session.LogicSettings.UseLuckyEggConstantly)
                return;

            var currentAmountOfLuckyEggs = await session.Inventory.GetItemAmountByType(ItemId.ItemLuckyEgg);
            if (currentAmountOfLuckyEggs == 0)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.NoEggsAvailable));
                return;
            }
            Logger.Write(session.Translation.GetTranslation(TranslationString.UseLuckyEggAmount,
                currentAmountOfLuckyEggs));

            var UseEgg = await session.Inventory.UseLuckyEggConstantly();

            if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.Success)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.UsedLuckyEgg));
            }
            else if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.ErrorNoItemsRemaining)
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.NoEggsAvailable));
            }
            else if (UseEgg.Result == UseItemXpBoostResponse.Types.Result.ErrorXpBoostAlreadyActive ||
                     (UseEgg.AppliedItems == null))
            {
                Logger.Write(session.Translation.GetTranslation(TranslationString.UseLuckyEggActive));
            }
        }
    }
}