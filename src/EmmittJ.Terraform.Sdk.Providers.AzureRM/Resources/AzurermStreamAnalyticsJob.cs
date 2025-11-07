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
    public TerraformLiteralProperty<string>? CompatibilityLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatibility_level");
        set => this.WithProperty("compatibility_level", value);
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContentStoragePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_storage_policy");
        set => this.WithProperty("content_storage_policy", value);
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DataLocale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_locale");
        set => this.WithProperty("data_locale", value);
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? EventsLateArrivalMaxDelayInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("events_late_arrival_max_delay_in_seconds");
        set => this.WithProperty("events_late_arrival_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? EventsOutOfOrderMaxDelayInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("events_out_of_order_max_delay_in_seconds");
        set => this.WithProperty("events_out_of_order_max_delay_in_seconds", value);
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventsOutOfOrderPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("events_out_of_order_policy");
        set => this.WithProperty("events_out_of_order_policy", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OutputErrorPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_error_policy");
        set => this.WithProperty("output_error_policy", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_cluster_id");
        set => this.WithProperty("stream_analytics_cluster_id", value);
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? StreamingUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("streaming_units");
        set => this.WithProperty("streaming_units", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransformationQuery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transformation_query");
        set => this.WithProperty("transformation_query", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

}
