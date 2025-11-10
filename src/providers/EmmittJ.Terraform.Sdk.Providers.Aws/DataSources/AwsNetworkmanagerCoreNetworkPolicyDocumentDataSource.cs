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
        set => SetProperty("condition_logic", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformProperty<double> RuleNumber
    {
        set => SetProperty("rule_number", value);
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
        set => SetProperty("asn_ranges", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsSupport
    {
        set => SetProperty("dns_support", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InsideCidrBlocks
    {
        set => SetProperty("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<bool>? SecurityGroupReferencingSupport
    {
        set => SetProperty("security_group_referencing_support", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformProperty<bool>? VpnEcmpSupport
    {
        set => SetProperty("vpn_ecmp_support", value);
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
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireAttachmentAcceptance is required")]
    public required TerraformProperty<bool> RequireAttachmentAcceptance
    {
        set => SetProperty("require_attachment_acceptance", value);
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
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The destination_cidr_blocks attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DestinationCidrBlocks
    {
        set => SetProperty("destination_cidr_blocks", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Destinations
    {
        set => SetProperty("destinations", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    public required TerraformProperty<string> Segment
    {
        set => SetProperty("segment", value);
    }

    /// <summary>
    /// The share_with attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ShareWith
    {
        set => SetProperty("share_with", value);
    }

    /// <summary>
    /// The share_with_except attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ShareWithExcept
    {
        set => SetProperty("share_with_except", value);
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
        set => SetProperty("allow_filter", value);
    }

    /// <summary>
    /// The deny_filter attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DenyFilter
    {
        set => SetProperty("deny_filter", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? EdgeLocations
    {
        set => SetProperty("edge_locations", value);
    }

    /// <summary>
    /// The isolate_attachments attribute.
    /// </summary>
    public TerraformProperty<bool>? IsolateAttachments
    {
        set => SetProperty("isolate_attachments", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireAttachmentAcceptance
    {
        set => SetProperty("require_attachment_acceptance", value);
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
        SetOutput("json");
        SetOutput("id");
        SetOutput("version");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for attachment_policies.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>? AttachmentPolicies
    {
        set => SetProperty("attachment_policies", value);
    }

    /// <summary>
    /// Block for core_network_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CoreNetworkConfiguration block(s) required")]
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>? CoreNetworkConfiguration
    {
        set => SetProperty("core_network_configuration", value);
    }

    /// <summary>
    /// Block for network_function_groups.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>? NetworkFunctionGroups
    {
        set => SetProperty("network_function_groups", value);
    }

    /// <summary>
    /// Block for segment_actions.
    /// Nesting mode: list
    /// </summary>
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>? SegmentActions
    {
        set => SetProperty("segment_actions", value);
    }

    /// <summary>
    /// Block for segments.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Segments block(s) required")]
    public List<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>? Segments
    {
        set => SetProperty("segments", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformExpression Json => this["json"];

}
