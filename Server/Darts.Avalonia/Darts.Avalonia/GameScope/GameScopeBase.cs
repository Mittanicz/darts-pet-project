﻿using Avalonia.Controls;
using Darts.Avalonia.Models;
using Darts.Avalonia.Views;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Darts.Avalonia.GameScope;

public abstract class GameScopeBase : IGameScope
{
    protected readonly IServiceProvider service;
    protected readonly TransitioningContentControl contentControl;

    public GameScopeBase(IServiceProvider serviceScope, TransitioningContentControl contentControl)
    {
        this.service = serviceScope;
        this.contentControl = contentControl;
    }

    public abstract void StartSetup();

    public abstract void StartGame();

    public void ExitGame()
    {
        contentControl.Content = service.GetRequiredService<MainMenuView>();
    }

    public abstract void ReturnToGame();

    public void ShowWinnersView(Player[] players)
    {
        GameWinnerView view = service.GetRequiredService<GameWinnerView>();
        contentControl.Content = view;

        foreach (Player player in players)
        {
            view.ViewModel.Players.Add(player);
        }
    }
}
