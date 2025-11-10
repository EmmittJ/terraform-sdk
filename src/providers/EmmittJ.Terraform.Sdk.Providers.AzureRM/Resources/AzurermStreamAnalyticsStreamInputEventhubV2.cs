using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for serialization in .
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock : TerraformBlock
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
public class AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_stream_analytics_stream_input_eventhub_v2 resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsStreamInputEventhubV2 : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputEventhubV2(string name) : base("azurerm_stream_analytics_stream_input_eventhub_v2", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("authentication_mode");
        SetOutput("eventhub_consumer_group_name");
        SetOutput("eventhub_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("partition_key");
        SetOutput("servicebus_namespace");
        SetOutput("shared_access_policy_key");
        SetOutput("shared_access_policy_name");
        SetOutput("stream_analytics_job_id");
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
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformProperty<string> EventhubConsumerGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_consumer_group_name");
        set => SetProperty("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformProperty<string> EventhubName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("eventhub_name");
        set => SetProperty("eventhub_name", value);
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
    /// The partition_key attribute.
    /// </summary>
    public TerraformProperty<string> PartitionKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key");
        set => SetProperty("partition_key", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_id");
        set => SetProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public List<AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock>? Serialization
    {
        set => SetProperty("serialization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
