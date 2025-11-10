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
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? FieldDelimiter
    {
        set => SetProperty("field_delimiter", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    public TerraformProperty<string>? Format
    {
        set => SetProperty("format", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_output_servicebus_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsOutputServicebusQueue : TerraformResource
{
    public AzurermStreamAnalyticsOutputServicebusQueue(string name) : base("azurerm_stream_analytics_output_servicebus_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication_mode");
        SetOutput("id");
        SetOutput("name");
        SetOutput("property_columns");
        SetOutput("queue_name");
        SetOutput("resource_group_name");
        SetOutput("servicebus_namespace");
        SetOutput("shared_access_policy_key");
        SetOutput("shared_access_policy_name");
        SetOutput("stream_analytics_job_name");
        SetOutput("system_property_columns");
    }

    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationMode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_mode");
        set => SetProperty("authentication_mode", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The property_columns attribute.
    /// </summary>
    public List<TerraformProperty<string>> PropertyColumns
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("property_columns");
        set => SetProperty("property_columns", value);
    }

    /// <summary>
    /// The queue_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QueueName is required")]
    public required TerraformProperty<string> QueueName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_name");
        set => SetProperty("queue_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The servicebus_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusNamespace is required")]
    public required TerraformProperty<string> ServicebusNamespace
    {
        get => GetRequiredOutput<TerraformProperty<string>>("servicebus_namespace");
        set => SetProperty("servicebus_namespace", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    public TerraformProperty<string> SharedAccessPolicyKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_access_policy_key");
        set => SetProperty("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string> SharedAccessPolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_access_policy_name");
        set => SetProperty("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformProperty<string> StreamAnalyticsJobName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_name");
        set => SetProperty("stream_analytics_job_name", value);
    }

    /// <summary>
    /// The system_property_columns attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> SystemPropertyColumns
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("system_property_columns");
        set => SetProperty("system_property_columns", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public List<AzurermStreamAnalyticsOutputServicebusQueueSerializationBlock>? Serialization
    {
        set => SetProperty("serialization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputServicebusQueueTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
