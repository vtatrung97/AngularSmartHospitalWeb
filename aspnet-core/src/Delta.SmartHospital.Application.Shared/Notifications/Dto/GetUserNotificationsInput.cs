﻿using System;
using Abp.Notifications;
using Delta.SmartHospital.Dto;

namespace Delta.SmartHospital.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}