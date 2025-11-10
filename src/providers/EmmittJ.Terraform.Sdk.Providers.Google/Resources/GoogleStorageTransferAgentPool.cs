using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for bandwidth_limit in .
/// Nesting mode: list
/// </summary>
public class GoogleStorageTransferAgentPoolBandwidthLimitBlock : ITerraformBlock
{
    /// <summary>
    /// Bandwidth rate in megabytes per second, distributed across all the agents in the pool.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LimitMbps is required")]
    [TerraformPropertyName("limit_mbps")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> LimitMbps { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleStorageTransferAgentPoolTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_storage_transfer_agent_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleStorageTransferAgentPool : TerraformResource
{
    public GoogleStorageTransferAgentPool(string name) : base("google_storage_transfer_agent_pool", name)
    {
    }

    /// <summary>
    /// Specifies the client-specified AgentPool description.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

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
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for bandwidth_limit.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BandwidthLimit block(s) allowed")]
    [TerraformPropertyName("bandwidth_limit")]
    public TerraformList<TerraformBlock<GoogleStorageTransferAgentPoolBandwidthLimitBlock>>? BandwidthLimit { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleStorageTransferAgentPoolTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Specifies the state of the AgentPool.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
