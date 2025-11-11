using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for email_preferences in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDataTransferConfigEmailPreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, email notifications will be sent on transfer run failures.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableFailureEmail is required")]
    [TerraformProperty("enable_failure_email")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> EnableFailureEmail { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the KMS key used for encrypting BigQuery data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformProperty("kms_key_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for schedule_options in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDataTransferConfigScheduleOptionsBlock : TerraformBlockBase
{
    /// <summary>
    /// If true, automatic scheduling of data transfer runs for this
    /// configuration will be disabled. The runs can be started on ad-hoc
    /// basis using transferConfigs.startManualRuns API. When automatic
    /// scheduling is disabled, the TransferConfig.schedule field will
    /// be ignored.
    /// </summary>
    [TerraformProperty("disable_auto_scheduling")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DisableAutoScheduling { get; set; }

    /// <summary>
    /// Defines time to stop scheduling transfer runs. A transfer run cannot be
    /// scheduled at or after the end time. The end time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    [TerraformProperty("end_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndTime { get; set; }

    /// <summary>
    /// Specifies time to start scheduling transfer runs. The first run will be
    /// scheduled at or after the start time according to a recurrence pattern
    /// defined in the schedule string. The start time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    [TerraformProperty("start_time")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StartTime { get; set; }

}

/// <summary>
/// Block type for sensitive_params in .
/// Nesting mode: list
/// </summary>
public partial class GoogleBigqueryDataTransferConfigSensitiveParamsBlock : TerraformBlockBase
{
    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    [TerraformProperty("secret_access_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretAccessKey { get; set; }

    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    [TerraformProperty("secret_access_key_wo")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecretAccessKeyWo { get; set; }

    /// <summary>
    /// The version of the sensitive params - used to trigger updates of the write-only params. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformProperty("secret_access_key_wo_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? SecretAccessKeyWoVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleBigqueryDataTransferConfigTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_data_transfer_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleBigqueryDataTransferConfig : TerraformResource
{
    public GoogleBigqueryDataTransferConfig(string name) : base("google_bigquery_data_transfer_config", name)
    {
    }

    /// <summary>
    /// The number of days to look back to automatically refresh the data.
    /// For example, if dataRefreshWindowDays = 10, then every day BigQuery
    /// reingests data for [today-10, today-1], rather than ingesting data for
    /// just [today-1]. Only valid if the data source supports the feature.
    /// Set the value to 0 to use the default value.
    /// </summary>
    [TerraformProperty("data_refresh_window_days")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DataRefreshWindowDays { get; set; }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformProperty("data_source_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DataSourceId { get; set; }

    /// <summary>
    /// The BigQuery target dataset id.
    /// </summary>
    [TerraformProperty("destination_dataset_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DestinationDatasetId { get; set; }

    /// <summary>
    /// When set to true, no runs are scheduled for a given transfer.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The user specified display name for the transfer config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Location { get; set; }

    /// <summary>
    /// Pub/Sub topic where notifications will be sent after transfer runs
    /// associated with this transfer config finish.
    /// </summary>
    [TerraformProperty("notification_pubsub_topic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? NotificationPubsubTopic { get; set; }

    /// <summary>
    /// Parameters specific to each data source. For more information see the bq tab in the &#39;Setting up a data transfer&#39;
    /// section for each data source. For example the parameters for Cloud Storage transfers are listed here:
    /// https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
    /// 
    /// **NOTE** : If you are attempting to update a parameter that cannot be updated (due to api limitations) [please force recreation of the resource](https://www.terraform.io/cli/state/taint#forcing-re-creation-of-resources).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Params is required")]
    [TerraformProperty("params")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Params { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

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
    [TerraformProperty("schedule")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Schedule { get; set; }

    /// <summary>
    /// Service account email. If this field is set, transfer config will
    /// be created with this service account credentials. It requires that
    /// requesting user calling this API has permissions to act as this service account.
    /// </summary>
    [TerraformProperty("service_account_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceAccountName { get; set; }

    /// <summary>
    /// Block for email_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailPreferences block(s) allowed")]
    [TerraformProperty("email_preferences")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>>? EmailPreferences { get; set; }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformProperty("encryption_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; }

    /// <summary>
    /// Block for schedule_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleOptions block(s) allowed")]
    [TerraformProperty("schedule_options")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>>? ScheduleOptions { get; set; }

    /// <summary>
    /// Block for sensitive_params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveParams block(s) allowed")]
    [TerraformProperty("sensitive_params")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>>? SensitiveParams { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleBigqueryDataTransferConfigTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The resource name of the transfer config. Transfer config names have the
    /// form projects/{projectId}/locations/{location}/transferConfigs/{configId}
    /// or projects/{projectId}/transferConfigs/{configId},
    /// where configId is usually a uuid, but this is not required.
    /// The name is ignored when creating a transfer config.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

}
