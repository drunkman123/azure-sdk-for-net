// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraClusterBackupSchedule. </summary>
    public partial class CassandraClusterBackupSchedule
    {
        /// <summary> Initializes a new instance of CassandraClusterBackupSchedule. </summary>
        public CassandraClusterBackupSchedule()
        {
        }

        /// <summary> Initializes a new instance of CassandraClusterBackupSchedule. </summary>
        /// <param name="scheduleName"> The unique identifier of backup schedule. </param>
        /// <param name="cronExpression"> The cron expression that defines when you want to back up your data. </param>
        /// <param name="retentionInHours"> The retention period (hours) of the backups. If you want to retain data forever, set retention to 0. </param>
        internal CassandraClusterBackupSchedule(string scheduleName, string cronExpression, int? retentionInHours)
        {
            ScheduleName = scheduleName;
            CronExpression = cronExpression;
            RetentionInHours = retentionInHours;
        }

        /// <summary> The unique identifier of backup schedule. </summary>
        public string ScheduleName { get; set; }
        /// <summary> The cron expression that defines when you want to back up your data. </summary>
        public string CronExpression { get; set; }
        /// <summary> The retention period (hours) of the backups. If you want to retain data forever, set retention to 0. </summary>
        public int? RetentionInHours { get; set; }
    }
}
