﻿using Darts.Avalonia.Enums;
using System;

namespace Darts.Avalonia;

public static class ConvertExtensions
{
    public static Models.Player ToModel(this DAL.Entities.Player data)
    {
        return new Models.Player()
        {
            ID = data.ID,
            Name = data.Name,
        };
    }

    public static DAL.Entities.Player ToDalPLayer(this Models.Player data)
    {
        return new DAL.Entities.Player()
        {
            ID = data.ID,
            Name = data.Name,
        };
    }

    public static Darts.Games.Models.Player ToDartPlayer(this Models.Player data, int count)
    {
        return new Games.Models.Player(data.Name, 0, count, false);
    }

    public static Models.Player ToModel(this Games.Models.Player data)
    {
        return new Models.Player()
        {
            Name = data.PlayerName,
        };
    }

    public static Games.TargetButtonType ToGameType(this DartsNumberModifier type)
    {
        return type switch
        {
            DartsNumberModifier.Triple => Games.TargetButtonType.Triple,
            DartsNumberModifier.Double => Games.TargetButtonType.Double,
            DartsNumberModifier.Single => Games.TargetButtonType.Single,

            _ => throw new NotSupportedException($"Type {type} cannot be converted"),
        };
    }

    public static Games.TargetButtonNum ToGameType(this DartNumbers number)
    {
        return number switch
        {
            DartNumbers.Miss => Games.TargetButtonNum.Miss,
            DartNumbers.One => Games.TargetButtonNum.One,
            DartNumbers.Two => Games.TargetButtonNum.Two,
            DartNumbers.Three => Games.TargetButtonNum.Three,
            DartNumbers.Four => Games.TargetButtonNum.Four,
            DartNumbers.Five => Games.TargetButtonNum.Five,
            DartNumbers.Six => Games.TargetButtonNum.Six,
            DartNumbers.Seven => Games.TargetButtonNum.Seven,
            DartNumbers.Eight => Games.TargetButtonNum.Eight,
            DartNumbers.Nine => Games.TargetButtonNum.Nine,
            DartNumbers.Ten => Games.TargetButtonNum.Ten,
            DartNumbers.Eleven => Games.TargetButtonNum.Eleven,
            DartNumbers.Twelve => Games.TargetButtonNum.Twelve,
            DartNumbers.Thirteen => Games.TargetButtonNum.Thirteen,
            DartNumbers.Fourteen => Games.TargetButtonNum.Fourteen,
            DartNumbers.Fifteen => Games.TargetButtonNum.Fifteen,
            DartNumbers.Sixteen => Games.TargetButtonNum.Sixteen,
            DartNumbers.Seventeen => Games.TargetButtonNum.Seventeen,
            DartNumbers.Eighteen => Games.TargetButtonNum.Eighteen,
            DartNumbers.Nineteen => Games.TargetButtonNum.Nineteen,
            DartNumbers.Twenty => Games.TargetButtonNum.Twenty,
            DartNumbers.BullsEye => Games.TargetButtonNum.BullsEye,

            _ => throw new NotSupportedException($"Number {number} cannot be converted"),
        };
    }
}
