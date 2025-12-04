using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for serialization in AzurermStreamAnalyticsStreamInputEventhubV2.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "serialization";

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    public TerraformValue<string>? FieldDelimiter
    {
        get => GetArgument<TerraformValue<string>>("field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsStreamInputEventhubV2.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_stream_analytics_stream_input_eventhub_v2 Terraform resource.
/// Manages a azurerm_stream_analytics_stream_input_eventhub_v2 resource.
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputEventhubV2(string name) : TerraformResource("azurerm_stream_analytics_stream_input_eventhub_v2", name)
{
    /// <summary>
    /// The authentication_mode attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationMode
    {
        get => GetArgument<TerraformValue<string>>("authentication_mode");
        set => SetArgument("authentication_mode", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    public TerraformValue<string>? EventhubConsumerGroupName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubName is required")]
    public required TerraformValue<string> EventhubName
    {
        get => GetRequiredArgument<TerraformValue<string>>("eventhub_name");
        set => SetArgument("eventhub_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The partition_key attribute.
    /// </summary>
    public TerraformValue<string>? PartitionKey
    {
        get => GetArgument<TerraformValue<string>>("partition_key");
        set => SetArgument("partition_key", value);
    }

    /// <summary>
    /// The servicebus_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusNamespace is required")]
    public required TerraformValue<string> ServicebusNamespace
    {
        get => GetRequiredArgument<TerraformValue<string>>("servicebus_namespace");
        set => SetArgument("servicebus_namespace", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    public TerraformValue<string>? SharedAccessPolicyKey
    {
        get => GetArgument<TerraformValue<string>>("shared_access_policy_key");
        set => SetArgument("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? SharedAccessPolicyName
    {
        get => GetArgument<TerraformValue<string>>("shared_access_policy_name");
        set => SetArgument("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformValue<string> StreamAnalyticsJobId
    {
        get => GetRequiredArgument<TerraformValue<string>>("stream_analytics_job_id");
        set => SetArgument("stream_analytics_job_id", value);
    }

    /// <summary>
    /// Serialization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public required TerraformList<AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock> Serialization
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsStreamInputEventhubV2SerializationBlock>>("serialization");
        set => SetArgument("serialization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsStreamInputEventhubV2TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
