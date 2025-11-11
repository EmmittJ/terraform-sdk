using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment_policies in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock : TerraformBlockBase
{
    /// <summary>
    /// The condition_logic attribute.
    /// </summary>
    [TerraformProperty("condition_logic")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConditionLogic { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    [TerraformProperty("rule_number")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> RuleNumber { get; set; }

}

/// <summary>
/// Block type for core_network_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The asn_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AsnRanges is required")]
    [TerraformProperty("asn_ranges")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AsnRanges { get; set; }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    [TerraformProperty("dns_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DnsSupport { get; set; }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("inside_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? InsideCidrBlocks { get; set; }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    [TerraformProperty("security_group_referencing_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? SecurityGroupReferencingSupport { get; set; }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    [TerraformProperty("vpn_ecmp_support")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? VpnEcmpSupport { get; set; }

}

/// <summary>
/// Block type for network_function_groups in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock : TerraformBlockBase
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireAttachmentAcceptance is required")]
    [TerraformProperty("require_attachment_acceptance")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> RequireAttachmentAcceptance { get; set; }

}

/// <summary>
/// Block type for segment_actions in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock : TerraformBlockBase
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The destination_cidr_blocks attribute.
    /// </summary>
    [TerraformProperty("destination_cidr_blocks")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DestinationCidrBlocks { get; set; }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    [TerraformProperty("destinations")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Destinations { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Mode { get; set; }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    [TerraformProperty("segment")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Segment { get; set; }

    /// <summary>
    /// The share_with attribute.
    /// </summary>
    [TerraformProperty("share_with")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ShareWith { get; set; }

    /// <summary>
    /// The share_with_except attribute.
    /// </summary>
    [TerraformProperty("share_with_except")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ShareWithExcept { get; set; }

}

/// <summary>
/// Block type for segments in .
/// Nesting mode: list
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_filter attribute.
    /// </summary>
    [TerraformProperty("allow_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowFilter { get; set; }

    /// <summary>
    /// The deny_filter attribute.
    /// </summary>
    [TerraformProperty("deny_filter")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DenyFilter { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    [TerraformProperty("edge_locations")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? EdgeLocations { get; set; }

    /// <summary>
    /// The isolate_attachments attribute.
    /// </summary>
    [TerraformProperty("isolate_attachments")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IsolateAttachments { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [TerraformProperty("require_attachment_acceptance")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireAttachmentAcceptance { get; set; }

}

/// <summary>
/// Retrieves information about a aws_networkmanager_core_network_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource : TerraformDataSource
{
    public AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource(string name) : base("aws_networkmanager_core_network_policy_document", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Version { get; set; }

    /// <summary>
    /// Block for attachment_policies.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("attachment_policies")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>>? AttachmentPolicies { get; set; }

    /// <summary>
    /// Block for core_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CoreNetworkConfiguration block(s) required")]
    [TerraformProperty("core_network_configuration")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>>? CoreNetworkConfiguration { get; set; }

    /// <summary>
    /// Block for network_function_groups.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("network_function_groups")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>>? NetworkFunctionGroups { get; set; }

    /// <summary>
    /// Block for segment_actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("segment_actions")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>>? SegmentActions { get; set; }

    /// <summary>
    /// Block for segments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Segments block(s) required")]
    [TerraformProperty("segments")]
    public TerraformList<TerraformBlock<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>>? Segments { get; set; }

    /// <summary>
    /// The json attribute.
    /// </summary>
    [TerraformProperty("json")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Json { get; }

}
