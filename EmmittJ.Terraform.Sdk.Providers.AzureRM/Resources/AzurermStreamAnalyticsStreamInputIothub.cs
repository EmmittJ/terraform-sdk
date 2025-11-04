using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_stream_input_iothub resource.
/// </summary>
public class AzurermStreamAnalyticsStreamInputIothub : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputIothub(string name) : base("azurerm_stream_analytics_stream_input_iothub", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public string? Endpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint")?.Value;
        set => this.WithProperty("endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public string? EventhubConsumerGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_consumer_group_name")?.Value;
        set => this.WithProperty("eventhub_consumer_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The iothub_namespace attribute.
    /// </summary>
    public string? IothubNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_namespace")?.Value;
        set => this.WithProperty("iothub_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}
