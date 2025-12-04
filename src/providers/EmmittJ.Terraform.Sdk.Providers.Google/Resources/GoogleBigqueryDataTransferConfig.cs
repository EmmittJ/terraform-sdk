using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for email_preferences in GoogleBigqueryDataTransferConfig.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEmailPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email_preferences";

    /// <summary>
    /// If true, email notifications will be sent on transfer run failures.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableFailureEmail is required")]
    public required TerraformValue<bool> EnableFailureEmail
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enable_failure_email");
        set => SetArgument("enable_failure_email", value);
    }

}


/// <summary>
/// Block type for encryption_configuration in GoogleBigqueryDataTransferConfig.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The name of the KMS key used for encrypting BigQuery data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformValue<string> KmsKeyName
    {
        get => GetRequiredArgument<TerraformValue<string>>("kms_key_name");
        set => SetArgument("kms_key_name", value);
    }

}


/// <summary>
/// Block type for schedule_options in GoogleBigqueryDataTransferConfig.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigScheduleOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schedule_options";

    /// <summary>
    /// If true, automatic scheduling of data transfer runs for this
    /// configuration will be disabled. The runs can be started on ad-hoc
    /// basis using transferConfigs.startManualRuns API. When automatic
    /// scheduling is disabled, the TransferConfig.schedule field will
    /// be ignored.
    /// </summary>
    public TerraformValue<bool>? DisableAutoScheduling
    {
        get => GetArgument<TerraformValue<bool>>("disable_auto_scheduling");
        set => SetArgument("disable_auto_scheduling", value);
    }

    /// <summary>
    /// Defines time to stop scheduling transfer runs. A transfer run cannot be
    /// scheduled at or after the end time. The end time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    public TerraformValue<string>? EndTime
    {
        get => GetArgument<TerraformValue<string>>("end_time");
        set => SetArgument("end_time", value);
    }

    /// <summary>
    /// Specifies time to start scheduling transfer runs. The first run will be
    /// scheduled at or after the start time according to a recurrence pattern
    /// defined in the schedule string. The start time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    public TerraformValue<string>? StartTime
    {
        get => GetArgument<TerraformValue<string>>("start_time");
        set => SetArgument("start_time", value);
    }

}


/// <summary>
/// Block type for sensitive_params in GoogleBigqueryDataTransferConfig.
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigSensitiveParamsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitive_params";

    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    public TerraformValue<string>? SecretAccessKey
    {
        get => GetArgument<TerraformValue<string>>("secret_access_key");
        set => SetArgument("secret_access_key", value);
    }

    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    public TerraformValue<string>? SecretAccessKeyWo
    {
        get => GetArgument<TerraformValue<string>>("secret_access_key_wo");
        set => SetArgument("secret_access_key_wo", value);
    }

    /// <summary>
    /// The version of the sensitive params - used to trigger updates of the write-only params. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformValue<double>? SecretAccessKeyWoVersion
    {
        get => GetArgument<TerraformValue<double>>("secret_access_key_wo_version");
        set => SetArgument("secret_access_key_wo_version", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleBigqueryDataTransferConfig.
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDataTransferConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_bigquery_data_transfer_config Terraform resource.
/// Manages a google_bigquery_data_transfer_config resource.
/// </summary>
public partial class GoogleBigqueryDataTransferConfig(string name) : TerraformResource("google_bigquery_data_transfer_config", name)
{
    /// <summary>
    /// The number of days to look back to automatically refresh the data.
    /// For example, if dataRefreshWindowDays = 10, then every day BigQuery
    /// reingests data for [today-10, today-1], rather than ingesting data for
    /// just [today-1]. Only valid if the data source supports the feature.
    /// Set the value to 0 to use the default value.
    /// </summary>
    public TerraformValue<double>? DataRefreshWindowDays
    {
        get => GetArgument<TerraformValue<double>>("data_refresh_window_days");
        set => SetArgument("data_refresh_window_days", value);
    }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformValue<string> DataSourceId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_source_id");
        set => SetArgument("data_source_id", value);
    }

    /// <summary>
    /// The BigQuery target dataset id.
    /// </summary>
    public TerraformValue<string>? DestinationDatasetId
    {
        get => GetArgument<TerraformValue<string>>("destination_dataset_id");
        set => SetArgument("destination_dataset_id", value);
    }

    /// <summary>
    /// When set to true, no runs are scheduled for a given transfer.
    /// </summary>
    public TerraformValue<bool>? Disabled
    {
        get => GetArgument<TerraformValue<bool>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// The user specified display name for the transfer config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Pub/Sub topic where notifications will be sent after transfer runs
    /// associated with this transfer config finish.
    /// </summary>
    public TerraformValue<string>? NotificationPubsubTopic
    {
        get => GetArgument<TerraformValue<string>>("notification_pubsub_topic");
        set => SetArgument("notification_pubsub_topic", value);
    }

    /// <summary>
    /// Parameters specific to each data source. For more information see the bq tab in the &#39;Setting up a data transfer&#39;
    /// section for each data source. For example the parameters for Cloud Storage transfers are listed here:
    /// https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
    /// 
    /// **NOTE** : If you are attempting to update a parameter that cannot be updated (due to api limitations) [please force recreation of the resource](https://www.terraform.io/cli/state/taint#forcing-re-creation-of-resources).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParamsAttribute is required")]
    public required TerraformMap<string> ParamsAttribute
    {
        get => GetRequiredArgument<TerraformMap<string>>("params");
        set => SetArgument("params", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Data transfer schedule. If the data source does not support a custom
    /// schedule, this should be empty. If it is empty, the default value for
    /// the data source will be used. The specified times are in UTC. Examples
    /// of valid format: 1st,3rd monday of month 15:30, every wed,fri of jan,
    /// jun 13:15, and first sunday of quarter 00:00. See more explanation
    /// about the format here:
    /// https://cloud.google.com/appengine/docs/flexible/python/scheduling-jobs-with-cron-yaml#the_schedule_format
    /// NOTE: The minimum interval time between recurring transfers depends
    /// on the data source; refer to the documentation for your data source.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// Service account email. If this field is set, transfer config will
    /// be created with this service account credentials. It requires that
    /// requesting user calling this API has permissions to act as this service account.
    /// </summary>
    public TerraformValue<string>? ServiceAccountName
    {
        get => GetArgument<TerraformValue<string>>("service_account_name");
        set => SetArgument("service_account_name", value);
    }

    /// <summary>
    /// The resource name of the transfer config. Transfer config names have the
    /// form projects/{projectId}/locations/{location}/transferConfigs/{configId}
    /// or projects/{projectId}/transferConfigs/{configId},
    /// where configId is usually a uuid, but this is not required.
    /// The name is ignored when creating a transfer config.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// EmailPreferences block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailPreferences block(s) allowed")]
    public TerraformList<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>? EmailPreferences
    {
        get => GetArgument<TerraformList<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>>("email_preferences");
        set => SetArgument("email_preferences", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// ScheduleOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleOptions block(s) allowed")]
    public TerraformList<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>? ScheduleOptions
    {
        get => GetArgument<TerraformList<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>>("schedule_options");
        set => SetArgument("schedule_options", value);
    }

    /// <summary>
    /// SensitiveParams block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveParams block(s) allowed")]
    public TerraformList<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>? SensitiveParams
    {
        get => GetArgument<TerraformList<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>>("sensitive_params");
        set => SetArgument("sensitive_params", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleBigqueryDataTransferConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleBigqueryDataTransferConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
