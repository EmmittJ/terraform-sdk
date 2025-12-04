using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsNetworkfirewallRuleGroup.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "encryption_configuration";

    /// <summary>
    /// The key_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyId
    {
        get => GetArgument<TerraformValue<string>>("key_id");
        set => SetArgument("key_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for rule_group in AwsNetworkfirewallRuleGroup.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_group";

    /// <summary>
    /// ReferenceSets block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReferenceSets block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlock>? ReferenceSets
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlock>>("reference_sets");
        set => SetArgument("reference_sets", value);
    }

    /// <summary>
    /// RuleVariables block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleVariables block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlock>? RuleVariables
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlock>>("rule_variables");
        set => SetArgument("rule_variables", value);
    }

    /// <summary>
    /// RulesSource block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RulesSource is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RulesSource block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RulesSource block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock> RulesSource
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock>>("rules_source");
        set => SetArgument("rules_source", value);
    }

    /// <summary>
    /// StatefulRuleOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatefulRuleOptions block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockStatefulRuleOptionsBlock>? StatefulRuleOptions
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockStatefulRuleOptionsBlock>>("stateful_rule_options");
        set => SetArgument("stateful_rule_options", value);
    }

}

/// <summary>
/// Block type for reference_sets in AwsNetworkfirewallRuleGroupRuleGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reference_sets";

    /// <summary>
    /// IpSetReferences block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 IpSetReferences block(s) allowed")]
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlock>? IpSetReferences
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlock>>("ip_set_references");
        set => SetArgument("ip_set_references", value);
    }

}

/// <summary>
/// Block type for ip_set_references in AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_set_references";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// IpSetReference block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpSetReference is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpSetReference block(s) required")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlockIpSetReferenceBlock> IpSetReference
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlockIpSetReferenceBlock>>("ip_set_reference");
        set => SetArgument("ip_set_reference", value);
    }

}

/// <summary>
/// Block type for ip_set_reference in AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockReferenceSetsBlockIpSetReferencesBlockIpSetReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_set_reference";

    /// <summary>
    /// The reference_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReferenceArn is required")]
    public required TerraformValue<string> ReferenceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("reference_arn");
        set => SetArgument("reference_arn", value);
    }

}

/// <summary>
/// Block type for rule_variables in AwsNetworkfirewallRuleGroupRuleGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_variables";

    /// <summary>
    /// IpSets block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlock>? IpSets
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlock>>("ip_sets");
        set => SetArgument("ip_sets", value);
    }

    /// <summary>
    /// PortSets block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlock>? PortSets
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlock>>("port_sets");
        set => SetArgument("port_sets", value);
    }

}

/// <summary>
/// Block type for ip_sets in AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_sets";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// IpSet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IpSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IpSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IpSet block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlockIpSetBlock> IpSet
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlockIpSetBlock>>("ip_set");
        set => SetArgument("ip_set", value);
    }

}

/// <summary>
/// Block type for ip_set in AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockIpSetsBlockIpSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ip_set";

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    public required TerraformSet<string> Definition
    {
        get => GetRequiredArgument<TerraformSet<string>>("definition");
        set => SetArgument("definition", value);
    }

}

/// <summary>
/// Block type for port_sets in AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_sets";

    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformValue<string> Key
    {
        get => GetRequiredArgument<TerraformValue<string>>("key");
        set => SetArgument("key", value);
    }

    /// <summary>
    /// PortSet block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortSet is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PortSet block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PortSet block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlockPortSetBlock> PortSet
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlockPortSetBlock>>("port_set");
        set => SetArgument("port_set", value);
    }

}

/// <summary>
/// Block type for port_set in AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRuleVariablesBlockPortSetsBlockPortSetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_set";

    /// <summary>
    /// The definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Definition is required")]
    public required TerraformSet<string> Definition
    {
        get => GetRequiredArgument<TerraformSet<string>>("definition");
        set => SetArgument("definition", value);
    }

}

/// <summary>
/// Block type for rules_source in AwsNetworkfirewallRuleGroupRuleGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules_source";

    /// <summary>
    /// The rules_string attribute.
    /// </summary>
    public TerraformValue<string>? RulesString
    {
        get => GetArgument<TerraformValue<string>>("rules_string");
        set => SetArgument("rules_string", value);
    }

    /// <summary>
    /// RulesSourceList block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RulesSourceList block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockRulesSourceListBlock>? RulesSourceList
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockRulesSourceListBlock>>("rules_source_list");
        set => SetArgument("rules_source_list", value);
    }

    /// <summary>
    /// StatefulRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlock>? StatefulRule
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlock>>("stateful_rule");
        set => SetArgument("stateful_rule", value);
    }

    /// <summary>
    /// StatelessRulesAndCustomActions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatelessRulesAndCustomActions block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlock>? StatelessRulesAndCustomActions
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlock>>("stateless_rules_and_custom_actions");
        set => SetArgument("stateless_rules_and_custom_actions", value);
    }

}

/// <summary>
/// Block type for rules_source_list in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockRulesSourceListBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules_source_list";

    /// <summary>
    /// The generated_rules_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GeneratedRulesType is required")]
    public required TerraformValue<string> GeneratedRulesType
    {
        get => GetRequiredArgument<TerraformValue<string>>("generated_rules_type");
        set => SetArgument("generated_rules_type", value);
    }

    /// <summary>
    /// The target_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetTypes is required")]
    public required TerraformSet<string> TargetTypes
    {
        get => GetRequiredArgument<TerraformSet<string>>("target_types");
        set => SetArgument("target_types", value);
    }

    /// <summary>
    /// The targets attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Targets is required")]
    public required TerraformSet<string> Targets
    {
        get => GetRequiredArgument<TerraformSet<string>>("targets");
        set => SetArgument("targets", value);
    }

}

/// <summary>
/// Block type for stateful_rule in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_rule";

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformValue<string> Action
    {
        get => GetRequiredArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

    /// <summary>
    /// Header block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Header is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Header block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Header block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockHeaderBlock> Header
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockHeaderBlock>>("header");
        set => SetArgument("header", value);
    }

    /// <summary>
    /// RuleOption block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOption is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleOption block(s) required")]
    public required TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockRuleOptionBlock> RuleOption
    {
        get => GetRequiredArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockRuleOptionBlock>>("rule_option");
        set => SetArgument("rule_option", value);
    }

}

/// <summary>
/// Block type for header in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockHeaderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "header";

    /// <summary>
    /// The destination attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    public required TerraformValue<string> Destination
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// The destination_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationPort is required")]
    public required TerraformValue<string> DestinationPort
    {
        get => GetRequiredArgument<TerraformValue<string>>("destination_port");
        set => SetArgument("destination_port", value);
    }

    /// <summary>
    /// The direction attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Direction is required")]
    public required TerraformValue<string> Direction
    {
        get => GetRequiredArgument<TerraformValue<string>>("direction");
        set => SetArgument("direction", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformValue<string> Protocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetRequiredArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The source_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourcePort is required")]
    public required TerraformValue<string> SourcePort
    {
        get => GetRequiredArgument<TerraformValue<string>>("source_port");
        set => SetArgument("source_port", value);
    }

}

/// <summary>
/// Block type for rule_option in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatefulRuleBlockRuleOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_option";

    /// <summary>
    /// The keyword attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Keyword is required")]
    public required TerraformValue<string> Keyword
    {
        get => GetRequiredArgument<TerraformValue<string>>("keyword");
        set => SetArgument("keyword", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformSet<string>? Settings
    {
        get => GetArgument<TerraformSet<string>>("settings");
        set => SetArgument("settings", value);
    }

}

/// <summary>
/// Block type for stateless_rules_and_custom_actions in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateless_rules_and_custom_actions";

    /// <summary>
    /// CustomAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlock>? CustomAction
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlock>>("custom_action");
        set => SetArgument("custom_action", value);
    }

    /// <summary>
    /// StatelessRule block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessRule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 StatelessRule block(s) required")]
    public required TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlock> StatelessRule
    {
        get => GetRequiredArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlock>>("stateless_rule");
        set => SetArgument("stateless_rule", value);
    }

}

/// <summary>
/// Block type for custom_action in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_action";

    /// <summary>
    /// The action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionName is required")]
    public required TerraformValue<string> ActionName
    {
        get => GetRequiredArgument<TerraformValue<string>>("action_name");
        set => SetArgument("action_name", value);
    }

    /// <summary>
    /// ActionDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ActionDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ActionDefinition block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlock> ActionDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlock>>("action_definition");
        set => SetArgument("action_definition", value);
    }

}

/// <summary>
/// Block type for action_definition in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "action_definition";

    /// <summary>
    /// PublishMetricAction block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublishMetricAction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PublishMetricAction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishMetricAction block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlock> PublishMetricAction
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlock>>("publish_metric_action");
        set => SetArgument("publish_metric_action", value);
    }

}

/// <summary>
/// Block type for publish_metric_action in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_metric_action";

    /// <summary>
    /// Dimension block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dimension is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Dimension block(s) required")]
    public required TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock> Dimension
    {
        get => GetRequiredArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dimension";

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for stateless_rule in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateless_rule";

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetRequiredArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// RuleDefinition block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleDefinition is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RuleDefinition block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleDefinition block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlock> RuleDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlock>>("rule_definition");
        set => SetArgument("rule_definition", value);
    }

}

/// <summary>
/// Block type for rule_definition in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_definition";

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    public required TerraformSet<string> Actions
    {
        get => GetRequiredArgument<TerraformSet<string>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// MatchAttributes block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchAttributes is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 MatchAttributes block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MatchAttributes block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock> MatchAttributes
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock>>("match_attributes");
        set => SetArgument("match_attributes", value);
    }

}

/// <summary>
/// Block type for match_attributes in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_attributes";

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformSet<double>? Protocols
    {
        get => GetArgument<TerraformSet<double>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// Destination block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationBlock>? Destination
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// DestinationPort block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationPortBlock>? DestinationPort
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationPortBlock>>("destination_port");
        set => SetArgument("destination_port", value);
    }

    /// <summary>
    /// Source block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourceBlock>? Source
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourceBlock>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// SourcePort block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourcePortBlock>? SourcePort
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourcePortBlock>>("source_port");
        set => SetArgument("source_port", value);
    }

    /// <summary>
    /// TcpFlag block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockTcpFlagBlock>? TcpFlag
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockTcpFlagBlock>>("tcp_flag");
        set => SetArgument("tcp_flag", value);
    }

}

/// <summary>
/// Block type for destination in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The address_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressDefinition is required")]
    public required TerraformValue<string> AddressDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("address_definition");
        set => SetArgument("address_definition", value);
    }

}

/// <summary>
/// Block type for destination_port in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockDestinationPortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_port";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for source in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source";

    /// <summary>
    /// The address_definition attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddressDefinition is required")]
    public required TerraformValue<string> AddressDefinition
    {
        get => GetRequiredArgument<TerraformValue<string>>("address_definition");
        set => SetArgument("address_definition", value);
    }

}

/// <summary>
/// Block type for source_port in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockSourcePortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_port";

    /// <summary>
    /// The from_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FromPort is required")]
    public required TerraformValue<double> FromPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("from_port");
        set => SetArgument("from_port", value);
    }

    /// <summary>
    /// The to_port attribute.
    /// </summary>
    public TerraformValue<double>? ToPort
    {
        get => GetArgument<TerraformValue<double>>("to_port");
        set => SetArgument("to_port", value);
    }

}

/// <summary>
/// Block type for tcp_flag in AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockRulesSourceBlockStatelessRulesAndCustomActionsBlockStatelessRuleBlockRuleDefinitionBlockMatchAttributesBlockTcpFlagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tcp_flag";

    /// <summary>
    /// The flags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Flags is required")]
    public required TerraformSet<string> Flags
    {
        get => GetRequiredArgument<TerraformSet<string>>("flags");
        set => SetArgument("flags", value);
    }

    /// <summary>
    /// The masks attribute.
    /// </summary>
    public TerraformSet<string>? Masks
    {
        get => GetArgument<TerraformSet<string>>("masks");
        set => SetArgument("masks", value);
    }

}

/// <summary>
/// Block type for stateful_rule_options in AwsNetworkfirewallRuleGroupRuleGroupBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallRuleGroupRuleGroupBlockStatefulRuleOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_rule_options";

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleOrder is required")]
    public required TerraformValue<string> RuleOrder
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_order");
        set => SetArgument("rule_order", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_rule_group Terraform resource.
/// Manages a aws_networkfirewall_rule_group resource.
/// </summary>
public partial class AwsNetworkfirewallRuleGroup(string name) : TerraformResource("aws_networkfirewall_rule_group", name)
{
    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => GetRequiredArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rules attribute.
    /// </summary>
    public TerraformValue<string>? Rules
    {
        get => GetArgument<TerraformValue<string>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
        => AsReference("update_token");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// RuleGroup block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RuleGroup block(s) allowed")]
    public TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlock>? RuleGroup
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallRuleGroupRuleGroupBlock>>("rule_group");
        set => SetArgument("rule_group", value);
    }

}
