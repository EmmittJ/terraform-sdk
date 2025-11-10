using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bandwidth_limit in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferAgentPoolBandwidthLimitBlock : TerraformBlock
{
    /// <summary>
    /// Bandwidth rate in megabytes per second, distributed across all the agents in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitMbps is required")]
    public required TerraformProperty<string> LimitMbps
    {
        get => GetProperty<TerraformProperty<string>>("limit_mbps");
        set => WithProperty("limit_mbps", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageTransferAgentPoolTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_storage_transfer_agent_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageTransferAgentPool : TerraformResource
{
    public GoogleStorageTransferAgentPool(string name) : base("google_storage_transfer_agent_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("state");
    }

    /// <summary>
    /// Specifies the client-specified AgentPool description.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Block for bandwidth_limit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BandwidthLimit block(s) allowed")]
    public List<GoogleStorageTransferAgentPoolBandwidthLimitBlock>? BandwidthLimit
    {
        get => GetProperty<List<GoogleStorageTransferAgentPoolBandwidthLimitBlock>>("bandwidth_limit");
        set => this.WithProperty("bandwidth_limit", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleStorageTransferAgentPoolTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleStorageTransferAgentPoolTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Specifies the state of the AgentPool.
    /// </summary>
    public TerraformExpression State => this["state"];

}
