using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_servicebus_queue resource.
/// </summary>
public class AzurermStreamAnalyticsOutputServicebusQueue : TerraformResource
{
    public AzurermStreamAnalyticsOutputServicebusQueue(string name) : base("azurerm_stream_analytics_output_servicebus_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public string? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode")?.Value;
        set => this.WithProperty("authentication_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The property_columns attribute.
    /// </summary>
    public List<string>? PropertyColumns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("property_columns")?.Value;
        set => this.WithProperty("property_columns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public string? QueueName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_name")?.Value;
        set => this.WithProperty("queue_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The servicebus_namespace attribute.
    /// </summary>
    public string? ServicebusNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("servicebus_namespace")?.Value;
        set => this.WithProperty("servicebus_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    public string? SharedAccessPolicyKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_policy_key")?.Value;
        set => this.WithProperty("shared_access_policy_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    public string? SharedAccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_policy_name")?.Value;
        set => this.WithProperty("shared_access_policy_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public string? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name")?.Value;
        set => this.WithProperty("stream_analytics_job_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The system_property_columns attribute.
    /// </summary>
    public Dictionary<string, string>? SystemPropertyColumns
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("system_property_columns")?.Value;
        set => this.WithProperty("system_property_columns", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
