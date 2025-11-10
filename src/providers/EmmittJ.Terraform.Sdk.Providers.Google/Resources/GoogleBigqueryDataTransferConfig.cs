using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for email_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEmailPreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// If true, email notifications will be sent on transfer run failures.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableFailureEmail is required")]
    [TerraformPropertyName("enable_failure_email")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> EnableFailureEmail { get; set; }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the KMS key used for encrypting BigQuery data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    [TerraformPropertyName("kms_key_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> KmsKeyName { get; set; }

}

/// <summary>
/// Block type for schedule_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigScheduleOptionsBlock : ITerraformBlock
{
    /// <summary>
    /// If true, automatic scheduling of data transfer runs for this
    /// configuration will be disabled. The runs can be started on ad-hoc
    /// basis using transferConfigs.startManualRuns API. When automatic
    /// scheduling is disabled, the TransferConfig.schedule field will
    /// be ignored.
    /// </summary>
    [TerraformPropertyName("disable_auto_scheduling")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DisableAutoScheduling { get; set; }

    /// <summary>
    /// Defines time to stop scheduling transfer runs. A transfer run cannot be
    /// scheduled at or after the end time. The end time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    [TerraformPropertyName("end_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EndTime { get; set; }

    /// <summary>
    /// Specifies time to start scheduling transfer runs. The first run will be
    /// scheduled at or after the start time according to a recurrence pattern
    /// defined in the schedule string. The start time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StartTime { get; set; }

}

/// <summary>
/// Block type for sensitive_params in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigSensitiveParamsBlock : ITerraformBlock
{
    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    [TerraformPropertyName("secret_access_key")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretAccessKey { get; set; }

    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    [TerraformPropertyName("secret_access_key_wo")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SecretAccessKeyWo { get; set; }

    /// <summary>
    /// The version of the sensitive params - used to trigger updates of the write-only params. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    [TerraformPropertyName("secret_access_key_wo_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? SecretAccessKeyWoVersion { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDataTransferConfigTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_bigquery_data_transfer_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDataTransferConfig : TerraformResource
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
    [TerraformPropertyName("data_refresh_window_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? DataRefreshWindowDays { get; set; }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    [TerraformPropertyName("data_source_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DataSourceId { get; set; }

    /// <summary>
    /// The BigQuery target dataset id.
    /// </summary>
    [TerraformPropertyName("destination_dataset_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DestinationDatasetId { get; set; }

    /// <summary>
    /// When set to true, no runs are scheduled for a given transfer.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Disabled { get; set; }

    /// <summary>
    /// The user specified display name for the transfer config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Location { get; set; }

    /// <summary>
    /// Pub/Sub topic where notifications will be sent after transfer runs
    /// associated with this transfer config finish.
    /// </summary>
    [TerraformPropertyName("notification_pubsub_topic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? NotificationPubsubTopic { get; set; }

    /// <summary>
    /// Parameters specific to each data source. For more information see the bq tab in the &#39;Setting up a data transfer&#39;
    /// section for each data source. For example the parameters for Cloud Storage transfers are listed here:
    /// https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
    /// 
    /// **NOTE** : If you are attempting to update a parameter that cannot be updated (due to api limitations) [please force recreation of the resource](https://www.terraform.io/cli/state/taint#forcing-re-creation-of-resources).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Params is required")]
    [TerraformPropertyName("params")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Params { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

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
    [TerraformPropertyName("schedule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Schedule { get; set; }

    /// <summary>
    /// Service account email. If this field is set, transfer config will
    /// be created with this service account credentials. It requires that
    /// requesting user calling this API has permissions to act as this service account.
    /// </summary>
    [TerraformPropertyName("service_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccountName { get; set; }

    /// <summary>
    /// Block for email_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailPreferences block(s) allowed")]
    [TerraformPropertyName("email_preferences")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>>? EmailPreferences { get; set; } = new();

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    [TerraformPropertyName("encryption_configuration")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>>? EncryptionConfiguration { get; set; } = new();

    /// <summary>
    /// Block for schedule_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleOptions block(s) allowed")]
    [TerraformPropertyName("schedule_options")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>>? ScheduleOptions { get; set; } = new();

    /// <summary>
    /// Block for sensitive_params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveParams block(s) allowed")]
    [TerraformPropertyName("sensitive_params")]
    public TerraformList<TerraformBlock<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>>? SensitiveParams { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleBigqueryDataTransferConfigTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The resource name of the transfer config. Transfer config names have the
    /// form projects/{projectId}/locations/{location}/transferConfigs/{configId}
    /// or projects/{projectId}/transferConfigs/{configId},
    /// where configId is usually a uuid, but this is not required.
    /// The name is ignored when creating a transfer config.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
