using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for serialization in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsOutputServicebusQueueSerializationBlock : TerraformBlock
{
    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => WithProperty("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        get => GetProperty<TerraformProperty<string>>("field_delimiter");
        set => WithProperty("field_delimiter", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformProperty<string>? Format
    {
        get => GetProperty<TerraformProperty<string>>("format");
        set => WithProperty("format", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputServicebusQueueTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The property_columns attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PropertyColumns
    {
        get => GetProperty<List<TerraformProperty<string>>>("property_columns");
        set => this.WithProperty("property_columns", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformProperty<string> QueueName
    {
        get => GetProperty<TerraformProperty<string>>("queue_name");
        set => this.WithProperty("queue_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The servicebus_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusNamespace is required")]
    public required TerraformProperty<string> ServicebusNamespace
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetProperty<TerraformProperty<string>>("stream_analytics_job_name");
        set => this.WithProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The system_property_columns attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? SystemPropertyColumns
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("system_property_columns");
        set => this.WithProperty("system_property_columns", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public List<AzurermStreamAnalyticsOutputServicebusQueueSerializationBlock>? Serialization
    {
        get => GetProperty<List<AzurermStreamAnalyticsOutputServicebusQueueSerializationBlock>>("serialization");
        set => this.WithProperty("serialization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputServicebusQueueTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermStreamAnalyticsOutputServicebusQueueTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
