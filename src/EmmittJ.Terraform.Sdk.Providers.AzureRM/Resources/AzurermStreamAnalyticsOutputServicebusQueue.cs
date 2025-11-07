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
    public TerraformLiteralProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The property_columns attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PropertyColumns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("property_columns");
        set => this.WithProperty("property_columns", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? QueueName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("queue_name");
        set => this.WithProperty("queue_name", value);
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
    /// The servicebus_namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServicebusNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("servicebus_namespace");
        set => this.WithProperty("servicebus_namespace", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedAccessPolicyKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_policy_key");
        set => this.WithProperty("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedAccessPolicyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_access_policy_name");
        set => this.WithProperty("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The system_property_columns attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? SystemPropertyColumns
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("system_property_columns");
        set => this.WithProperty("system_property_columns", value);
    }

}
