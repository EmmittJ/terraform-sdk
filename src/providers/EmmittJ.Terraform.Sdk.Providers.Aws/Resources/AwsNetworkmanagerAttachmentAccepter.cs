using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerAttachmentAccepterTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_networkmanager_attachment_accepter resource.
/// </summary>
public class AwsNetworkmanagerAttachmentAccepter : TerraformResource
{
    public AwsNetworkmanagerAttachmentAccepter(string name) : base("aws_networkmanager_attachment_accepter", name)
    {
    }

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentId is required")]
    [TerraformPropertyName("attachment_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AttachmentId { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformPropertyName("attachment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AttachmentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkmanagerAttachmentAccepterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    [TerraformPropertyName("attachment_policy_rule_number")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> AttachmentPolicyRuleNumber => new TerraformReference(this, "attachment_policy_rule_number");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkArn => new TerraformReference(this, "core_network_arn");

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [TerraformPropertyName("core_network_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CoreNetworkId => new TerraformReference(this, "core_network_id");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformPropertyName("edge_location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EdgeLocation => new TerraformReference(this, "edge_location");

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [TerraformPropertyName("edge_locations")]
    // Output-only attribute - read-only reference
    public TerraformList<string> EdgeLocations => new TerraformReference(this, "edge_locations");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAccountId => new TerraformReference(this, "owner_account_id");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceArn => new TerraformReference(this, "resource_arn");

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    [TerraformPropertyName("segment_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SegmentName => new TerraformReference(this, "segment_name");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> State => new TerraformReference(this, "state");

}
