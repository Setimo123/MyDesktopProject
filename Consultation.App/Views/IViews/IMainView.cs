﻿using System;
using System.Windows.Forms;

namespace Consultation.App.Views.IViews
{
    public interface IMainView
    {
        Panel MainPanel { get; }
        Button CurrentActiveButton { get; set; }

        // Events for nav clicks
        event EventHandler DashboardEvent;
        event EventHandler ConsultationEvent;
        event EventHandler BulletinEvent;
        event EventHandler SFManagementEvent;
        event EventHandler PreferenceEvent;
        //event EventHandler NotificationEvent;

        void LoadControl(UserControl control);
        // Actions for styling
        void HighlightButton(Button button);
        void ResetButton(Button button);

        //void Header(string header);
        void SetMessage(string message);

        void ShowForm();
    }
}
