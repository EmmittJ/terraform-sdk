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
    public string? CompatibilityLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatibility_level")?.Value;
        set => this.WithProperty("compatibility_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The content_storage_policy attribute.
    /// </summary>
    public string? ContentStoragePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_storage_policy")?.Value;
        set => this.WithProperty("content_storage_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The data_locale attribute.
    /// </summary>
    public string? DataLocale
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_locale")?.Value;
        set => this.WithProperty("data_locale", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The events_late_arrival_max_delay_in_seconds attribute.
    /// </summary>
    public double? EventsLateArrivalMaxDelayInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("events_late_arrival_max_delay_in_seconds")?.Value;
        set => this.WithProperty("events_late_arrival_max_delay_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The events_out_of_order_max_delay_in_seconds attribute.
    /// </summary>
    public double? EventsOutOfOrderMaxDelayInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("events_out_of_order_max_delay_in_seconds")?.Value;
        set => this.WithProperty("events_out_of_order_max_delay_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The events_out_of_order_policy attribute.
    /// </summary>
    public string? EventsOutOfOrderPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("events_out_of_order_policy")?.Value;
        set => this.WithProperty("events_out_of_order_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The output_error_policy attribute.
    /// </summary>
    public string? OutputErrorPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_error_policy")?.Value;
        set => this.WithProperty("output_error_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_cluster_id attribute.
    /// </summary>
    public string? StreamAnalyticsClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_cluster_id")?.Value;
        set => this.WithProperty("stream_analytics_cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The streaming_units attribute.
    /// </summary>
    public double? StreamingUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("streaming_units")?.Value;
        set => this.WithProperty("streaming_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transformation_query attribute.
    /// </summary>
    public string? TransformationQuery
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transformation_query")?.Value;
        set => this.WithProperty("transformation_query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_id attribute.
    /// </summary>
    public TerraformExpression JobId => this["job_id"];

}
