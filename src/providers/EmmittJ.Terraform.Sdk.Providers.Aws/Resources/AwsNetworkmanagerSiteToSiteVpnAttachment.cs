using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerSiteToSiteVpnAttachmentTimeoutsBlock : ITerraformBlock
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
/// Manages a aws_networkmanager_site_to_site_vpn_attachment resource.
/// </summary>
public class AwsNetworkmanagerSiteToSiteVpnAttachment : TerraformResource
{
    public AwsNetworkmanagerSiteToSiteVpnAttachment(string name) : base("aws_networkmanager_site_to_site_vpn_attachment", name)
    {
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    [TerraformPropertyName("core_network_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CoreNetworkId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The vpn_connection_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpnConnectionArn is required")]
    [TerraformPropertyName("vpn_connection_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpnConnectionArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsNetworkmanagerSiteToSiteVpnAttachmentTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    [TerraformPropertyName("attachment_policy_rule_number")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> AttachmentPolicyRuleNumber => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "attachment_policy_rule_number");

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [TerraformPropertyName("attachment_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AttachmentType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "attachment_type");

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    [TerraformPropertyName("core_network_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CoreNetworkArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "core_network_arn");

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [TerraformPropertyName("edge_location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EdgeLocation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "edge_location");

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
