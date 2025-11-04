using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_data_transfer_config resource.
/// </summary>
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
    public double? DataRefreshWindowDays
    {
        get => GetProperty<TerraformLiteralProperty<double>>("data_refresh_window_days")?.Value;
        set => this.WithProperty("data_refresh_window_days", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    public string? DataSourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_source_id")?.Value;
        set => this.WithProperty("data_source_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The BigQuery target dataset id.
    /// </summary>
    public string? DestinationDatasetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_dataset_id")?.Value;
        set => this.WithProperty("destination_dataset_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// When set to true, no runs are scheduled for a given transfer.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The user specified display name for the transfer config.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The geographic location where the transfer config should reside.
    /// Examples: US, EU, asia-northeast1. The default value is US.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Pub/Sub topic where notifications will be sent after transfer runs
    /// associated with this transfer config finish.
    /// </summary>
    public string? NotificationPubsubTopic
    {
        get => GetProperty<TerraformLiteralProperty<string>>("notification_pubsub_topic")?.Value;
        set => this.WithProperty("notification_pubsub_topic", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Parameters specific to each data source. For more information see the bq tab in the &#39;Setting up a data transfer&#39;
    /// section for each data source. For example the parameters for Cloud Storage transfers are listed here:
    /// https://cloud.google.com/bigquery-transfer/docs/cloud-storage-transfer#bq
    /// 
    /// **NOTE** : If you are attempting to update a parameter that cannot be updated (due to api limitations) [please force recreation of the resource](https://www.terraform.io/cli/state/taint#forcing-re-creation-of-resources).
    /// </summary>
    public Dictionary<string, string>? Params
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("params")?.Value;
        set => this.WithProperty("params", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    public string? Schedule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schedule")?.Value;
        set => this.WithProperty("schedule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Service account email. If this field is set, transfer config will
    /// be created with this service account credentials. It requires that
    /// requesting user calling this API has permissions to act as this service account.
    /// </summary>
    public string? ServiceAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_account_name")?.Value;
        set => this.WithProperty("service_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
