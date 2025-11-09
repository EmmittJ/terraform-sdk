using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stream_analytics_output_servicebus_topic resource.
/// </summary>
public class AzurermStreamAnalyticsOutputServicebusTopic : TerraformResource
{
    public AzurermStreamAnalyticsOutputServicebusTopic(string name) : base("azurerm_stream_analytics_output_servicebus_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string>? AuthenticationMode
    {
        get => GetProperty<TerraformProperty<string>>("authentication_mode");
        set => this.WithProperty("authentication_mode", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The property_columns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? PropertyColumns
    {
        get => GetProperty<TerraformProperty<List<string>>>("property_columns");
        set => this.WithProperty("property_columns", value);
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
    /// The servicebus_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? ServicebusNamespace
    {
        get => GetProperty<TerraformProperty<string>>("servicebus_namespace");
        set => this.WithProperty("servicebus_namespace", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    public TerraformProperty<string>? SharedAccessPolicyKey
    {
        get => GetProperty<TerraformProperty<string>>("shared_access_policy_key");
        set => this.WithProperty("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? SharedAccessPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("shared_access_policy_name");
        set => this.WithProperty("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    public TerraformProperty<string>? StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The system_property_columns attribute.
    /// </summary>
    public TerraformMapProperty<string>? SystemPropertyColumns
    {
        get => GetProperty<TerraformMapProperty<string>>("system_property_columns");
        set => this.WithProperty("system_property_columns", value);
    }

    /// <summary>
    /// The topic_name attribute.
    /// </summary>
    public TerraformProperty<string>? TopicName
    {
        get => GetProperty<TerraformProperty<string>>("topic_name");
        set => this.WithProperty("topic_name", value);
    }

}
