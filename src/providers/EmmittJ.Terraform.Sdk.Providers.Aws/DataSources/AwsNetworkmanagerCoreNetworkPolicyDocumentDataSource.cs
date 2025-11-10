using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment_policies in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// The condition_logic attribute.
    /// </summary>
    [TerraformPropertyName("condition_logic")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ConditionLogic { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformPropertyName("rule_number")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> RuleNumber { get; set; }

}

/// <summary>
/// Block type for core_network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The asn_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AsnRanges is required")]
    [TerraformPropertyName("asn_ranges")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AsnRanges { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformPropertyName("dns_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DnsSupport { get; set; }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("inside_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? InsideCidrBlocks { get; set; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformPropertyName("security_group_referencing_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? SecurityGroupReferencingSupport { get; set; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformPropertyName("vpn_ecmp_support")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? VpnEcmpSupport { get; set; }

}

/// <summary>
/// Block type for network_function_groups in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock : ITerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireAttachmentAcceptance is required")]
    [TerraformPropertyName("require_attachment_acceptance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> RequireAttachmentAcceptance { get; set; }

}

/// <summary>
/// Block type for segment_actions in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock : ITerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformPropertyName("action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Action { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The destination_cidr_blocks attribute.
    /// </summary>
    [TerraformPropertyName("destination_cidr_blocks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DestinationCidrBlocks { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformPropertyName("destinations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Destinations { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Mode { get; set; }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    [TerraformPropertyName("segment")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Segment { get; set; }

    /// <summary>
    /// The share_with attribute.
    /// </summary>
    [TerraformPropertyName("share_with")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ShareWith { get; set; }

    /// <summary>
    /// The share_with_except attribute.
    /// </summary>
    [TerraformPropertyName("share_with_except")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? ShareWithExcept { get; set; }

}

/// <summary>
/// Block type for segments in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock : ITerraformBlock
{
    /// <summary>
    /// The allow_filter attribute.
    /// </summary>
    [TerraformPropertyName("allow_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? AllowFilter { get; set; }

    /// <summary>
    /// The deny_filter attribute.
    /// </summary>
    [TerraformPropertyName("deny_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DenyFilter { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [TerraformPropertyName("edge_locations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EdgeLocations { get; set; }

    /// <summary>
    /// The isolate_attachments attribute.
    /// </summary>
    [TerraformPropertyName("isolate_attachments")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsolateAttachments { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [TerraformPropertyName("require_attachment_acceptance")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequireAttachmentAcceptance { get; set; }

}

/// <summary>
/// Retrieves information about a aws_networkmanager_core_network_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource : TerraformDataSource
{
    public AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource(string name) : base("aws_networkmanager_core_network_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Version { get; set; }

    /// <summary>
    /// Block for attachment_policies.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("attachment_policies")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>>? AttachmentPolicies { get; set; } = new();

    /// <summary>
    /// Block for core_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CoreNetworkConfiguration block(s) required")]
    [TerraformPropertyName("core_network_configuration")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>>? CoreNetworkConfiguration { get; set; } = new();

    /// <summary>
    /// Block for network_function_groups.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("network_function_groups")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>>? NetworkFunctionGroups { get; set; } = new();

    /// <summary>
    /// Block for segment_actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("segment_actions")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>>? SegmentActions { get; set; } = new();

    /// <summary>
    /// Block for segments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Segments block(s) required")]
    [TerraformPropertyName("segments")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>>? Segments { get; set; } = new();

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformPropertyName("json")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Json => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "json");

}
