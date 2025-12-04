using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bandwidth_limit in GoogleStorageTransferAgentPool.
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferAgentPoolBandwidthLimitBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bandwidth_limit";

    /// <summary>
    /// Bandwidth rate in megabytes per second, distributed across all the agents in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitMbps is required")]
    public required TerraformValue<string> LimitMbps
    {
        get => GetRequiredArgument<TerraformValue<string>>("limit_mbps");
        set => SetArgument("limit_mbps", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleStorageTransferAgentPool.
/// Nesting mode: single
/// </summary>
public class GoogleStorageTransferAgentPoolTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_storage_transfer_agent_pool Terraform resource.
/// Manages a google_storage_transfer_agent_pool resource.
/// </summary>
public partial class GoogleStorageTransferAgentPool(string name) : TerraformResource("google_storage_transfer_agent_pool", name)
{
    /// <summary>
    /// Specifies the client-specified AgentPool description.
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
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
    /// The ID of the agent pool to create.
    /// 
    /// The agentPoolId must meet the following requirements:
    /// * Length of 128 characters or less.
    /// * Not start with the string goog.
    /// * Start with a lowercase ASCII character, followed by:
    ///   * Zero or more: lowercase Latin alphabet characters, numerals, hyphens (-), periods (.), underscores (_), or tildes (~).
    ///   * One or more numerals or lowercase ASCII characters.
    /// 
    /// As expressed by the regular expression: ^(?!goog)[a-z]([a-z0-9-._~]*[a-z0-9])?$.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Specifies the state of the AgentPool.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// BandwidthLimit block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BandwidthLimit block(s) allowed")]
    public TerraformList<GoogleStorageTransferAgentPoolBandwidthLimitBlock>? BandwidthLimit
    {
        get => GetArgument<TerraformList<GoogleStorageTransferAgentPoolBandwidthLimitBlock>>("bandwidth_limit");
        set => SetArgument("bandwidth_limit", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleStorageTransferAgentPoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleStorageTransferAgentPoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
