using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerAttachmentAccepterTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AttachmentId { get; set; }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    [TerraformPropertyName("attachment_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AttachmentType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkmanagerAttachmentAccepterTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    [TerraformPropertyName("attachment_policy_rule_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AttachmentPolicyRuleNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "attachment_policy_rule_number");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_arn");

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [TerraformPropertyName("core_network_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_id");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformPropertyName("edge_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_location");

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [TerraformPropertyName("edge_locations")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> EdgeLocations => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "edge_locations");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnerAccountId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "owner_account_id");

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformPropertyName("resource_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_arn");

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    [TerraformPropertyName("segment_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SegmentName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "segment_name");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

}
