using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for serialization in .
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
    [TerraformArgument("encoding")]
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The field_delimiter attribute.
    /// </summary>
    [TerraformArgument("field_delimiter")]
    public TerraformValue<string>? FieldDelimiter
    {
        get => new TerraformReference<string>(this, "field_delimiter");
        set => SetArgument("field_delimiter", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_stream_input_iothub resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermStreamAnalyticsStreamInputIothub : TerraformResource
{
    public AzurermStreamAnalyticsStreamInputIothub(string name) : base("azurerm_stream_analytics_stream_input_iothub", name)
    {
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Endpoint is required")]
    [TerraformArgument("endpoint")]
    public required TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
        set => SetArgument("endpoint", value);
    }

    /// <summary>
    /// The eventhub_consumer_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubConsumerGroupName is required")]
    [TerraformArgument("eventhub_consumer_group_name")]
    public required TerraformValue<string> EventhubConsumerGroupName
    {
        get => new TerraformReference<string>(this, "eventhub_consumer_group_name");
        set => SetArgument("eventhub_consumer_group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The iothub_namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubNamespace is required")]
    [TerraformArgument("iothub_namespace")]
    public required TerraformValue<string> IothubNamespace
    {
        get => new TerraformReference<string>(this, "iothub_namespace");
        set => SetArgument("iothub_namespace", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The shared_access_policy_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyKey is required")]
    [TerraformArgument("shared_access_policy_key")]
    public required TerraformValue<string> SharedAccessPolicyKey
    {
        get => new TerraformReference<string>(this, "shared_access_policy_key");
        set => SetArgument("shared_access_policy_key", value);
    }

    /// <summary>
    /// The shared_access_policy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedAccessPolicyName is required")]
    [TerraformArgument("shared_access_policy_name")]
    public required TerraformValue<string> SharedAccessPolicyName
    {
        get => new TerraformReference<string>(this, "shared_access_policy_name");
        set => SetArgument("shared_access_policy_name", value);
    }

    /// <summary>
    /// The stream_analytics_job_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobName is required")]
    [TerraformArgument("stream_analytics_job_name")]
    public required TerraformValue<string> StreamAnalyticsJobName
    {
        get => new TerraformReference<string>(this, "stream_analytics_job_name");
        set => SetArgument("stream_analytics_job_name", value);
    }

    /// <summary>
    /// Block for serialization.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Serialization is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Serialization block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Serialization block(s) allowed")]
    [TerraformArgument("serialization")]
    public required TerraformList<AzurermStreamAnalyticsStreamInputIothubSerializationBlock> Serialization { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStreamAnalyticsStreamInputIothubTimeoutsBlock Timeouts { get; set; } = new();

}
