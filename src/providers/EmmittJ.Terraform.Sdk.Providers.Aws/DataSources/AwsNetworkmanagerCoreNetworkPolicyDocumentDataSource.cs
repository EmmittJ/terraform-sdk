using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attachment_policies in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "attachment_policies";

    /// <summary>
    /// The condition_logic attribute.
    /// </summary>
    public TerraformValue<string>? ConditionLogic
    {
        get => new TerraformReference<string>(this, "condition_logic");
        set => SetArgument("condition_logic", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The rule_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleNumber is required")]
    public required TerraformValue<double> RuleNumber
    {
        get => new TerraformReference<double>(this, "rule_number");
        set => SetArgument("rule_number", value);
    }

    /// <summary>
    /// Action block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Action block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    public required TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockActionBlock> Action
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockActionBlock>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Conditions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Conditions block(s) required")]
    public required TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockConditionsBlock> Conditions
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for action in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action";

    /// <summary>
    /// The add_to_network_function_group attribute.
    /// </summary>
    public TerraformValue<string>? AddToNetworkFunctionGroup
    {
        get => new TerraformReference<string>(this, "add_to_network_function_group");
        set => SetArgument("add_to_network_function_group", value);
    }

    /// <summary>
    /// The association_method attribute.
    /// </summary>
    public TerraformValue<string>? AssociationMethod
    {
        get => new TerraformReference<string>(this, "association_method");
        set => SetArgument("association_method", value);
    }

    /// <summary>
    /// The require_acceptance attribute.
    /// </summary>
    public TerraformValue<bool>? RequireAcceptance
    {
        get => new TerraformReference<bool>(this, "require_acceptance");
        set => SetArgument("require_acceptance", value);
    }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    public TerraformValue<string>? Segment
    {
        get => new TerraformReference<string>(this, "segment");
        set => SetArgument("segment", value);
    }

    /// <summary>
    /// The tag_value_of_key attribute.
    /// </summary>
    public TerraformValue<string>? TagValueOfKey
    {
        get => new TerraformReference<string>(this, "tag_value_of_key");
        set => SetArgument("tag_value_of_key", value);
    }

}

/// <summary>
/// Block type for conditions in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// The key attribute.
    /// </summary>
    public TerraformValue<string>? Key
    {
        get => new TerraformReference<string>(this, "key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    public TerraformValue<string>? OperatorAttribute
    {
        get => new TerraformReference<string>(this, "operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for core_network_configuration in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "core_network_configuration";

    /// <summary>
    /// The asn_ranges attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AsnRanges is required")]
    public required TerraformSet<string> AsnRanges
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "asn_ranges").ResolveNodes(ctx));
        set => SetArgument("asn_ranges", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformValue<bool>? DnsSupport
    {
        get => new TerraformReference<bool>(this, "dns_support");
        set => SetArgument("dns_support", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public TerraformSet<string>? InsideCidrBlocks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "inside_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformValue<bool>? SecurityGroupReferencingSupport
    {
        get => new TerraformReference<bool>(this, "security_group_referencing_support");
        set => SetArgument("security_group_referencing_support", value);
    }

    /// <summary>
    /// The vpn_ecmp_support attribute.
    /// </summary>
    public TerraformValue<bool>? VpnEcmpSupport
    {
        get => new TerraformReference<bool>(this, "vpn_ecmp_support");
        set => SetArgument("vpn_ecmp_support", value);
    }

    /// <summary>
    /// EdgeLocations block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeLocations is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EdgeLocations block(s) required")]
    public required TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlockEdgeLocationsBlock> EdgeLocations
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlockEdgeLocationsBlock>>("edge_locations");
        set => SetArgument("edge_locations", value);
    }

}

/// <summary>
/// Block type for edge_locations in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlockEdgeLocationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "edge_locations";

    /// <summary>
    /// The asn attribute.
    /// </summary>
    public TerraformValue<string>? Asn
    {
        get => new TerraformReference<string>(this, "asn");
        set => SetArgument("asn", value);
    }

    /// <summary>
    /// The inside_cidr_blocks attribute.
    /// </summary>
    public TerraformList<string>? InsideCidrBlocks
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "inside_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("inside_cidr_blocks", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

}


/// <summary>
/// Block type for network_function_groups in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_function_groups";

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireAttachmentAcceptance is required")]
    public required TerraformValue<bool> RequireAttachmentAcceptance
    {
        get => new TerraformReference<bool>(this, "require_attachment_acceptance");
        set => SetArgument("require_attachment_acceptance", value);
    }

}


/// <summary>
/// Block type for segment_actions in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segment_actions";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => new TerraformReference<string>(this, "action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The destination_cidr_blocks attribute.
    /// </summary>
    public TerraformSet<string>? DestinationCidrBlocks
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destination_cidr_blocks").ResolveNodes(ctx));
        set => SetArgument("destination_cidr_blocks", value);
    }

    /// <summary>
    /// The destinations attribute.
    /// </summary>
    public TerraformSet<string>? Destinations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "destinations").ResolveNodes(ctx));
        set => SetArgument("destinations", value);
    }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    public TerraformValue<string>? Mode
    {
        get => new TerraformReference<string>(this, "mode");
        set => SetArgument("mode", value);
    }

    /// <summary>
    /// The segment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segment is required")]
    public required TerraformValue<string> Segment
    {
        get => new TerraformReference<string>(this, "segment");
        set => SetArgument("segment", value);
    }

    /// <summary>
    /// The share_with attribute.
    /// </summary>
    public TerraformSet<string>? ShareWith
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "share_with").ResolveNodes(ctx));
        set => SetArgument("share_with", value);
    }

    /// <summary>
    /// The share_with_except attribute.
    /// </summary>
    public TerraformSet<string>? ShareWithExcept
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "share_with_except").ResolveNodes(ctx));
        set => SetArgument("share_with_except", value);
    }

    /// <summary>
    /// Via block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Via block(s) allowed")]
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlock>? Via
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlock>>("via");
        set => SetArgument("via", value);
    }

    /// <summary>
    /// WhenSentTo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WhenSentTo block(s) allowed")]
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockWhenSentToBlock>? WhenSentTo
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockWhenSentToBlock>>("when_sent_to");
        set => SetArgument("when_sent_to", value);
    }

}

/// <summary>
/// Block type for via in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "via";

    /// <summary>
    /// The network_function_groups attribute.
    /// </summary>
    public TerraformSet<string>? NetworkFunctionGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "network_function_groups").ResolveNodes(ctx));
        set => SetArgument("network_function_groups", value);
    }

    /// <summary>
    /// WithEdgeOverride block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlockWithEdgeOverrideBlock>? WithEdgeOverride
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlockWithEdgeOverrideBlock>>("with_edge_override");
        set => SetArgument("with_edge_override", value);
    }

}

/// <summary>
/// Block type for with_edge_override in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockViaBlockWithEdgeOverrideBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "with_edge_override";

    /// <summary>
    /// The edge_sets attribute.
    /// </summary>
    public TerraformSet<TerraformSet<string>>? EdgeSets
    {
        get => TerraformSet<TerraformSet<string>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformSet<string>>>(this, "edge_sets").ResolveNodes(ctx));
        set => SetArgument("edge_sets", value);
    }

    /// <summary>
    /// The use_edge attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? UseEdge
    {
        get => new TerraformReference<string>(this, "use_edge");
        set => SetArgument("use_edge", value);
    }

    /// <summary>
    /// The use_edge_location attribute.
    /// </summary>
    public TerraformValue<string>? UseEdgeLocation
    {
        get => new TerraformReference<string>(this, "use_edge_location");
        set => SetArgument("use_edge_location", value);
    }

}

/// <summary>
/// Block type for when_sent_to in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlockWhenSentToBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "when_sent_to";

    /// <summary>
    /// The segments attribute.
    /// </summary>
    public TerraformSet<string>? Segments
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "segments").ResolveNodes(ctx));
        set => SetArgument("segments", value);
    }

}


/// <summary>
/// Block type for segments in AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "segments";

    /// <summary>
    /// The allow_filter attribute.
    /// </summary>
    public TerraformSet<string>? AllowFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allow_filter").ResolveNodes(ctx));
        set => SetArgument("allow_filter", value);
    }

    /// <summary>
    /// The deny_filter attribute.
    /// </summary>
    public TerraformSet<string>? DenyFilter
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "deny_filter").ResolveNodes(ctx));
        set => SetArgument("deny_filter", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public TerraformSet<string>? EdgeLocations
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "edge_locations").ResolveNodes(ctx));
        set => SetArgument("edge_locations", value);
    }

    /// <summary>
    /// The isolate_attachments attribute.
    /// </summary>
    public TerraformValue<bool>? IsolateAttachments
    {
        get => new TerraformReference<bool>(this, "isolate_attachments");
        set => SetArgument("isolate_attachments", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The require_attachment_acceptance attribute.
    /// </summary>
    public TerraformValue<bool>? RequireAttachmentAcceptance
    {
        get => new TerraformReference<bool>(this, "require_attachment_acceptance");
        set => SetArgument("require_attachment_acceptance", value);
    }

}


/// <summary>
/// Represents a aws_networkmanager_core_network_policy_document Terraform data source.
/// Retrieves information about a aws_networkmanager_core_network_policy_document.
/// </summary>
public partial class AwsNetworkmanagerCoreNetworkPolicyDocumentDataSource(string name) : TerraformDataSource("aws_networkmanager_core_network_policy_document", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string>? Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The json attribute.
    /// </summary>
    public TerraformValue<string> Json
    {
        get => new TerraformReference<string>(this, "json");
    }

    /// <summary>
    /// AttachmentPolicies block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>? AttachmentPolicies
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceAttachmentPoliciesBlock>>("attachment_policies");
        set => SetArgument("attachment_policies", value);
    }

    /// <summary>
    /// CoreNetworkConfiguration block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkConfiguration is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 CoreNetworkConfiguration block(s) required")]
    public required TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock> CoreNetworkConfiguration
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceCoreNetworkConfigurationBlock>>("core_network_configuration");
        set => SetArgument("core_network_configuration", value);
    }

    /// <summary>
    /// NetworkFunctionGroups block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>? NetworkFunctionGroups
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceNetworkFunctionGroupsBlock>>("network_function_groups");
        set => SetArgument("network_function_groups", value);
    }

    /// <summary>
    /// SegmentActions block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>? SegmentActions
    {
        get => GetArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentActionsBlock>>("segment_actions");
        set => SetArgument("segment_actions", value);
    }

    /// <summary>
    /// Segments block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Segments is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Segments block(s) required")]
    public required TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock> Segments
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkmanagerCoreNetworkPolicyDocumentDataSourceSegmentsBlock>>("segments");
        set => SetArgument("segments", value);
    }

}
