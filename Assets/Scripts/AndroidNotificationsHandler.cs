using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_ANDROID
using Unity.Notifications.Android;
#endif
using UnityEngine;

public class AndroidNotificationsHandler : MonoBehaviour
{
#if UNITY_ANDROID
    private const string Channel_Id = "Notification_channel";

    public void ScheduleNotification(DateTime datetime)
    {
        AndroidNotificationChannel notificationChannel = new AndroidNotificationChannel {

            Id = Channel_Id,
            Name = "notification channel",
            Description = "random description",
            Importance = Importance.Default
        };

        AndroidNotificationCenter.RegisterNotificationChannel(notificationChannel);

        AndroidNotification notification = new AndroidNotification {

            Title = "Energy Recharged",
            Text = "your Energy recharged , time to play",
            SmallIcon = "default",
            LargeIcon = "default",
            FireTime = datetime
        };

        AndroidNotificationCenter.SendNotification(notification, Channel_Id);
    }
#endif
}
