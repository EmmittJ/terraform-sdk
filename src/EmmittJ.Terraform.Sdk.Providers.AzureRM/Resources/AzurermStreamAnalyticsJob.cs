using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_job resource.
/// </summary>
public class AzurermStreamAnalyticsJob : TerraformResource
{
    public AzurermStreamAnalyticsJob(string name) : base("azurerm_stream_analytics_job", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("job_id");
    }

    /// <summary>
    /// The compatibility_level attribute.
    /// </summary>
    public TerraformProperty<string>? CompatibilityLevel
    {
        get => GetProperty<TerraformProperty<string>>("compatibility_level");
        set => this.WithProperty("compatibility_level", value);
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ContentStoragePolicy
    {
        get => GetProperty<TerraformProperty<string>>("content_storage_policy");
        set => this.WithProperty("content_storage_policy", value);
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformProperty<string>? DataLocale
    {
        get => GetProperty<TerraformProperty<string>>("data_locale");
        set => this.WithProperty("data_locale", value);
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? EventsLateArrivalMaxDelayInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("events_late_arrival_max_delay_in_seconds");
        set => this.WithProperty("events_late_arrival_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? EventsOutOfOrderMaxDelayInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("events_out_of_order_max_delay_in_seconds");
        set => this.WithProperty("events_out_of_order_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformProperty<string>? EventsOutOfOrderPolicy
    {
        get => GetProperty<TerraformProperty<string>>("events_out_of_order_policy");
        set => this.WithProperty("events_out_of_order_policy", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformProperty<string>? OutputErrorPolicy
    {
        get => GetProperty<TerraformProperty<string>>("output_error_policy");
        set => this.WithProperty("output_error_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsClusterId
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_cluster_id");
        set => this.WithProperty("stream_analytics_cluster_id", value);
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformProperty<double>? StreamingUnits
    {
        get => GetProperty<TerraformProperty<double>>("streaming_units");
        set => this.WithProperty("streaming_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    public TerraformProperty<string>? TransformationQuery
    {
        get => GetProperty<TerraformProperty<string>>("transformation_query");
        set => this.WithProperty("transformation_query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

}
