using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for email_preferences in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEmailPreferencesBlock : TerraformBlock
{
    /// <summary>
    /// If true, email notifications will be sent on transfer run failures.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnableFailureEmail is required")]
    public required TerraformProperty<bool> EnableFailureEmail
    {
        get => GetProperty<TerraformProperty<bool>>("enable_failure_email");
        set => WithProperty("enable_failure_email", value);
    }

}

/// <summary>
/// Block type for encryption_configuration in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The name of the KMS key used for encrypting BigQuery data.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KmsKeyName is required")]
    public required TerraformProperty<string> KmsKeyName
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_name");
        set => WithProperty("kms_key_name", value);
    }

}

/// <summary>
/// Block type for schedule_options in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigScheduleOptionsBlock : TerraformBlock
{
    /// <summary>
    /// If true, automatic scheduling of data transfer runs for this
    /// configuration will be disabled. The runs can be started on ad-hoc
    /// basis using transferConfigs.startManualRuns API. When automatic
    /// scheduling is disabled, the TransferConfig.schedule field will
    /// be ignored.
    /// </summary>
    public TerraformProperty<bool>? DisableAutoScheduling
    {
        get => GetProperty<TerraformProperty<bool>>("disable_auto_scheduling");
        set => WithProperty("disable_auto_scheduling", value);
    }

    /// <summary>
    /// Defines time to stop scheduling transfer runs. A transfer run cannot be
    /// scheduled at or after the end time. The end time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    public TerraformProperty<string>? EndTime
    {
        get => GetProperty<TerraformProperty<string>>("end_time");
        set => WithProperty("end_time", value);
    }

    /// <summary>
    /// Specifies time to start scheduling transfer runs. The first run will be
    /// scheduled at or after the start time according to a recurrence pattern
    /// defined in the schedule string. The start time can be changed at any
    /// moment. The time when a data transfer can be triggered manually is not
    /// limited by this option.
    /// </summary>
    public TerraformProperty<string>? StartTime
    {
        get => GetProperty<TerraformProperty<string>>("start_time");
        set => WithProperty("start_time", value);
    }

}

/// <summary>
/// Block type for sensitive_params in .
/// Nesting mode: list
/// </summary>
public class GoogleBigqueryDataTransferConfigSensitiveParamsBlock : TerraformBlock
{
    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    public TerraformProperty<string>? SecretAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("secret_access_key");
        set => WithProperty("secret_access_key", value);
    }

    /// <summary>
    /// The Secret Access Key of the AWS account transferring data from.
    /// </summary>
    public TerraformProperty<string>? SecretAccessKeyWo
    {
        get => GetProperty<TerraformProperty<string>>("secret_access_key_wo");
        set => WithProperty("secret_access_key_wo", value);
    }

    /// <summary>
    /// The version of the sensitive params - used to trigger updates of the write-only params. For more info see [updating write-only attributes](/docs/providers/google/guides/using_write_only_attributes.html#updating-write-only-attributes)
    /// </summary>
    public TerraformProperty<double>? SecretAccessKeyWoVersion
    {
        get => GetProperty<TerraformProperty<double>>("secret_access_key_wo_version");
        set => WithProperty("secret_access_key_wo_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleBigqueryDataTransferConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_bigquery_data_transfer_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleBigqueryDataTransferConfig : TerraformResource
{
    public GoogleBigqueryDataTransferConfig(string name) : base("google_bigquery_data_transfer_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The number of days to look back to automatically refresh the data.
    /// For example, if dataRefreshWindowDays = 10, then every day BigQuery
    /// reingests data for [today-10, today-1], rather than ingesting data for
    /// just [today-1]. Only valid if the data source supports the feature.
    /// Set the value to 0 to use the default value.
    /// </summary>
    public TerraformProperty<double>? DataRefreshWindowDays
    {
        get => GetProperty<TerraformProperty<double>>("data_refresh_window_days");
        set => this.WithProperty("data_refresh_window_days", value);
    }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceId is required")]
    public required TerraformProperty<string> DataSourceId
    {
        get => GetProperty<TerraformProperty<string>>("data_source_id");
        set => this.WithProperty("data_source_id", value);
    }

    /// <summary>
    /// The BigQuery target dataset id.
    /// </summary>
    public TerraformProperty<string>? DestinationDatasetId
    {
        get => GetProperty<TerraformProperty<string>>("destination_dataset_id");
        set => this.WithProperty("destination_dataset_id", value);
    }

    /// <summary>
    /// When set to true, no runs are scheduled for a given transfer.
    /// </summary>
    public TerraformProperty<bool>? Disabled
    {
        get => GetProperty<TerraformProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
    }

    /// <summary>
    /// The user specified display name for the transfer config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Pub/Sub topic where notifications will be sent after transfer runs
    /// associated with this transfer config finish.
    /// </summary>
    public TerraformProperty<string>? NotificationPubsubTopic
    {
        get => GetProperty<TerraformProperty<string>>("notification_pubsub_topic");
        set => this.WithProperty("notification_pubsub_topic", value);
    }

    /// <summary>
    /// Parameters specific to each data source. For more information see the bq tab in the &#39;Setting up a data transfer&#39;
    /// section for each data source. For example the parameters for Cloud Storage transfers are listed here:
    /// https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
    /// 
    /// **NOTE** : If you are attempting to update a parameter that cannot be updated (due to api limitations) [please force recreation of the resource](https://www.terraform.io/cli/state/taint#forcing-re-creation-of-resources).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Params is required")]
    public Dictionary<string, TerraformProperty<string>>? Params
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("params");
        set => this.WithProperty("params", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
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
    public TerraformProperty<string>? Schedule
    {
        get => GetProperty<TerraformProperty<string>>("schedule");
        set => this.WithProperty("schedule", value);
    }

    /// <summary>
    /// Service account email. If this field is set, transfer config will
    /// be created with this service account credentials. It requires that
    /// requesting user calling this API has permissions to act as this service account.
    /// </summary>
    public TerraformProperty<string>? ServiceAccountName
    {
        get => GetProperty<TerraformProperty<string>>("service_account_name");
        set => this.WithProperty("service_account_name", value);
    }

    /// <summary>
    /// Block for email_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailPreferences block(s) allowed")]
    public List<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>? EmailPreferences
    {
        get => GetProperty<List<GoogleBigqueryDataTransferConfigEmailPreferencesBlock>>("email_preferences");
        set => this.WithProperty("email_preferences", value);
    }

    /// <summary>
    /// Block for encryption_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public List<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetProperty<List<GoogleBigqueryDataTransferConfigEncryptionConfigurationBlock>>("encryption_configuration");
        set => this.WithProperty("encryption_configuration", value);
    }

    /// <summary>
    /// Block for schedule_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ScheduleOptions block(s) allowed")]
    public List<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>? ScheduleOptions
    {
        get => GetProperty<List<GoogleBigqueryDataTransferConfigScheduleOptionsBlock>>("schedule_options");
        set => this.WithProperty("schedule_options", value);
    }

    /// <summary>
    /// Block for sensitive_params.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitiveParams block(s) allowed")]
    public List<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>? SensitiveParams
    {
        get => GetProperty<List<GoogleBigqueryDataTransferConfigSensitiveParamsBlock>>("sensitive_params");
        set => this.WithProperty("sensitive_params", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleBigqueryDataTransferConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleBigqueryDataTransferConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The resource name of the transfer config. Transfer config names have the
    /// form projects/{projectId}/locations/{location}/transferConfigs/{configId}
    /// or projects/{projectId}/transferConfigs/{configId},
    /// where configId is usually a uuid, but this is not required.
    /// The name is ignored when creating a transfer config.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
