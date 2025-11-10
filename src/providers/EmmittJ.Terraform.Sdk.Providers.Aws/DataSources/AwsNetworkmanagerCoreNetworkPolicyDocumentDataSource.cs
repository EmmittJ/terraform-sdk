using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment_policies in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// The condition_logic attribute.
    /// </summary>
    public TerraformProperty<string>? ConditionLogic
    {
        get => GetProperty<TerraformProperty<string>>("condition_logic");
        set => WithProperty("condition_logic", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        get => GetRequiredProperty<TerraformProperty<double>>("rule_number");
        set => WithProperty("rule_number", value);
    }

}

/// <summary>
/// Block type for core_network_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The asn_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AsnRanges is required")]
    public HashSet<TerraformProperty<string>>? AsnRanges
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("asn_ranges");
        set => WithProperty("asn_ranges", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsSupport
    {
        get => GetProperty<TerraformProperty<bool>>("dns_support");
        set => WithProperty("dns_support", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InsideCidrBlocks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("inside_cidr_blocks");
        set => WithProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<bool>? SecurityGroupReferencingSupport
    {
        get => GetProperty<TerraformProperty<bool>>("security_group_referencing_support");
        set => WithProperty("security_group_referencing_support", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformProperty<bool>? VpnEcmpSupport
    {
        get => GetProperty<TerraformProperty<bool>>("vpn_ecmp_support");
        set => WithProperty("vpn_ecmp_support", value);
    }

}

/// <summary>
/// Block type for network_function_groups in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock : TerraformBlock
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireAttachmentAcceptance is required")]
    public required TerraformProperty<bool> RequireAttachmentAcceptance
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("require_attachment_acceptance");
        set => WithProperty("require_attachment_acceptance", value);
    }

}

/// <summary>
/// Block type for segment_actions in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock : TerraformBlock
{
    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredProperty<TerraformProperty<string>>("action");
        set => WithProperty("action", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DestinationCidrBlocks
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destination_cidr_blocks");
        set => WithProperty("destination_cidr_blocks", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Destinations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("destinations");
        set => WithProperty("destinations", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    public required TerraformProperty<string> Segment
    {
        get => GetRequiredProperty<TerraformProperty<string>>("segment");
        set => WithProperty("segment", value);
    }

    /// <summary>
    /// The share_with attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ShareWith
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("share_with");
        set => WithProperty("share_with", value);
    }

    /// <summary>
    /// The share_with_except attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ShareWithExcept
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("share_with_except");
        set => WithProperty("share_with_except", value);
    }

}

/// <summary>
/// Block type for segments in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock : TerraformBlock
{
    /// <summary>
    /// The allow_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowFilter
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allow_filter");
        set => WithProperty("allow_filter", value);
    }

    /// <summary>
    /// The deny_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DenyFilter
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("deny_filter");
        set => WithProperty("deny_filter", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EdgeLocations
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("edge_locations");
        set => WithProperty("edge_locations", value);
    }

    /// <summary>
    /// The isolate_attachments attribute.
    /// </summary>
    public TerraformProperty<bool>? IsolateAttachments
    {
        get => GetProperty<TerraformProperty<bool>>("isolate_attachments");
        set => WithProperty("isolate_attachments", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireAttachmentAcceptance
    {
        get => GetProperty<TerraformProperty<bool>>("require_attachment_acceptance");
        set => WithProperty("require_attachment_acceptance", value);
    }

}

/// <summary>
/// Retrieves information about a aws_networkmanager_core_network_policy_document.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource : TerraformDataSource
{
    public AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource(string name) : base("aws_networkmanager_core_network_policy_document", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("json");
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for attachment_policies.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>? AttachmentPolicies
    {
        get => GetProperty<List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>>("attachment_policies");
        set => this.WithProperty("attachment_policies", value);
    }

    /// <summary>
    /// Block for core_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CoreNetworkConfiguration block(s) required")]
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>? CoreNetworkConfiguration
    {
        get => GetProperty<List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>>("core_network_configuration");
        set => this.WithProperty("core_network_configuration", value);
    }

    /// <summary>
    /// Block for network_function_groups.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>? NetworkFunctionGroups
    {
        get => GetProperty<List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>>("network_function_groups");
        set => this.WithProperty("network_function_groups", value);
    }

    /// <summary>
    /// Block for segment_actions.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>? SegmentActions
    {
        get => GetProperty<List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>>("segment_actions");
        set => this.WithProperty("segment_actions", value);
    }

    /// <summary>
    /// Block for segments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Segments block(s) required")]
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>? Segments
    {
        get => GetProperty<List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>>("segments");
        set => this.WithProperty("segments", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
