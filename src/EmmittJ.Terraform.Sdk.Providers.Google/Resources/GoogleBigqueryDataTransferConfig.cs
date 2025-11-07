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
    public TerraformProperty<double>? DataRefreshWindowDays
    {
        get => GetProperty<TerraformProperty<double>>("data_refresh_window_days");
        set => this.WithProperty("data_refresh_window_days", value);
    }

    /// <summary>
    /// The data source id. Cannot be changed once the transfer config is created.
    /// </summary>
    public TerraformProperty<string>? DataSourceId
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
    public TerraformProperty<string>? DisplayName
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
    public TerraformProperty<Dictionary<string, string>>? Params
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("params");
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
    /// The resource name of the transfer config. Transfer config names have the
    /// form projects/{projectId}/locations/{location}/transferConfigs/{configId}
    /// or projects/{projectId}/transferConfigs/{configId},
    /// where configId is usually a uuid, but this is not required.
    /// The name is ignored when creating a transfer config.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
