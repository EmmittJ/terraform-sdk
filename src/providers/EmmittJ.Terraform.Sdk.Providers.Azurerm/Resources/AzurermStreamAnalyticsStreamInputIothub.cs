using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for serialization in AzurermStreamAnalyticsStreamInputIothub.
/// Nesting mode: list
/// </summary>
public class AzurermStreamAnalyticsStreamInputIothubSerializationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsStreamInputIothub.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_stream_input_iothub Terraform resource.
/// Manages a azurerm_stream_analytics_stream_input_iothub resource.
/// </summary>
public partial class AzurermStreamAnalyticsStreamInputIothub(string name) : TerraformResource("azurerm_stream_analytics_stream_input_iothub", name)
{
    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    public required TerraformValue<string> Endpoint
    {
        get => GetArgument<TerraformValue<string>>("endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    public required TerraformValue<string> EventhubConsumerGroupName
    {
        get => GetArgument<TerraformValue<string>>("eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubNamespace is required")]
    public required TerraformValue<string> IothubNamespace
    {
        get => GetArgument<TerraformValue<string>>("iothub_namespace");
        set => SetArgument("iothub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyKey is required")]
    public required TerraformValue<string> SharedAccessPolicyKey
    {
        get => GetArgument<TerraformValue<string>>("shared_access_policy_key");
        set => SetArgument("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyName is required")]
    public required TerraformValue<string> SharedAccessPolicyName
    {
        get => GetArgument<TerraformValue<string>>("shared_access_policy_name");
        set => SetArgument("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => GetArgument<TerraformValue<string>>("stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Serialization block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    public required TerraformList<AzurermStreamAnalyticsStreamInputIothubSerializationBlock> Serialization
    {
        get => GetRequiredArgument<TerraformList<AzurermStreamAnalyticsStreamInputIothubSerializationBlock>>("serialization");
        set => SetArgument("serialization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
