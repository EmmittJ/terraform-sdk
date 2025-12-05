using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for encryption_configuration in AwsNetworkfirewallFirewallPolicy.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock : TerraformBlock
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
/// Block type for firewall_policy in AwsNetworkfirewallFirewallPolicy.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "firewall_policy";

    /// <summary>
    /// The stateful_default_actions attribute.
    /// </summary>
    public TerraformSet<string>? StatefulDefaultActions
    {
        get => GetArgument<TerraformSet<string>>("stateful_default_actions");
        set => SetArgument("stateful_default_actions", value);
    }

    /// <summary>
    /// The stateless_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessDefaultActions is required")]
    public required TerraformSet<string> StatelessDefaultActions
    {
        get => GetRequiredArgument<TerraformSet<string>>("stateless_default_actions");
        set => SetArgument("stateless_default_actions", value);
    }

    /// <summary>
    /// The stateless_fragment_default_actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatelessFragmentDefaultActions is required")]
    public required TerraformSet<string> StatelessFragmentDefaultActions
    {
        get => GetRequiredArgument<TerraformSet<string>>("stateless_fragment_default_actions");
        set => SetArgument("stateless_fragment_default_actions", value);
    }

    /// <summary>
    /// The tls_inspection_configuration_arn attribute.
    /// </summary>
    public TerraformValue<string>? TlsInspectionConfigurationArn
    {
        get => GetArgument<TerraformValue<string>>("tls_inspection_configuration_arn");
        set => SetArgument("tls_inspection_configuration_arn", value);
    }

    /// <summary>
    /// PolicyVariables block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyVariables block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlock>? PolicyVariables
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlock>>("policy_variables");
        set => SetArgument("policy_variables", value);
    }

    /// <summary>
    /// StatefulEngineOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StatefulEngineOptions block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlock>? StatefulEngineOptions
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlock>>("stateful_engine_options");
        set => SetArgument("stateful_engine_options", value);
    }

    /// <summary>
    /// StatefulRuleGroupReference block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlock>? StatefulRuleGroupReference
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlock>>("stateful_rule_group_reference");
        set => SetArgument("stateful_rule_group_reference", value);
    }

    /// <summary>
    /// StatelessCustomAction block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlock>? StatelessCustomAction
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlock>>("stateless_custom_action");
        set => SetArgument("stateless_custom_action", value);
    }

    /// <summary>
    /// StatelessRuleGroupReference block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessRuleGroupReferenceBlock>? StatelessRuleGroupReference
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessRuleGroupReferenceBlock>>("stateless_rule_group_reference");
        set => SetArgument("stateless_rule_group_reference", value);
    }

}

/// <summary>
/// Block type for policy_variables in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_variables";

    /// <summary>
    /// RuleVariables block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlock>? RuleVariables
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlock>>("rule_variables");
        set => SetArgument("rule_variables", value);
    }

}

/// <summary>
/// Block type for rule_variables in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule_variables";

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
    public required TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlockIpSetBlock> IpSet
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlockIpSetBlock>>("ip_set");
        set => SetArgument("ip_set", value);
    }

}

/// <summary>
/// Block type for ip_set in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockPolicyVariablesBlockRuleVariablesBlockIpSetBlock : TerraformBlock
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
/// Block type for stateful_engine_options in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_engine_options";

    /// <summary>
    /// The rule_order attribute.
    /// </summary>
    public TerraformValue<string>? RuleOrder
    {
        get => GetArgument<TerraformValue<string>>("rule_order");
        set => SetArgument("rule_order", value);
    }

    /// <summary>
    /// The stream_exception_policy attribute.
    /// </summary>
    public TerraformValue<string>? StreamExceptionPolicy
    {
        get => GetArgument<TerraformValue<string>>("stream_exception_policy");
        set => SetArgument("stream_exception_policy", value);
    }

    /// <summary>
    /// FlowTimeouts block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FlowTimeouts block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlockFlowTimeoutsBlock>? FlowTimeouts
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlockFlowTimeoutsBlock>>("flow_timeouts");
        set => SetArgument("flow_timeouts", value);
    }

}

/// <summary>
/// Block type for flow_timeouts in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulEngineOptionsBlockFlowTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "flow_timeouts";

    /// <summary>
    /// The tcp_idle_timeout_seconds attribute.
    /// </summary>
    public TerraformValue<double>? TcpIdleTimeoutSeconds
    {
        get => GetArgument<TerraformValue<double>>("tcp_idle_timeout_seconds");
        set => SetArgument("tcp_idle_timeout_seconds", value);
    }

}

/// <summary>
/// Block type for stateful_rule_group_reference in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_rule_group_reference";

    /// <summary>
    /// The deep_threat_inspection attribute.
    /// </summary>
    public TerraformValue<string> DeepThreatInspection
    {
        get => GetArgument<TerraformValue<string>>("deep_threat_inspection") ?? CreateReference("deep_threat_inspection");
        set => SetArgument("deep_threat_inspection", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    public TerraformValue<double>? Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// OverrideAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OverrideAttribute block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlockOverrideAttributeBlock>? OverrideAttribute
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlockOverrideAttributeBlock>>("override");
        set => SetArgument("override", value);
    }

}

/// <summary>
/// Block type for override in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatefulRuleGroupReferenceBlockOverrideAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "override";

    /// <summary>
    /// The action attribute.
    /// </summary>
    public TerraformValue<string>? Action
    {
        get => GetArgument<TerraformValue<string>>("action");
        set => SetArgument("action", value);
    }

}

/// <summary>
/// Block type for stateless_custom_action in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateless_custom_action";

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
    public required TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlock> ActionDefinition
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlock>>("action_definition");
        set => SetArgument("action_definition", value);
    }

}

/// <summary>
/// Block type for action_definition in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlock : TerraformBlock
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
    public required TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlock> PublishMetricAction
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlock>>("publish_metric_action");
        set => SetArgument("publish_metric_action", value);
    }

}

/// <summary>
/// Block type for publish_metric_action in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlock.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlock : TerraformBlock
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
    public required TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock> Dimension
    {
        get => GetRequiredArgument<TerraformSet<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock>>("dimension");
        set => SetArgument("dimension", value);
    }

}

/// <summary>
/// Block type for dimension in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessCustomActionBlockActionDefinitionBlockPublishMetricActionBlockDimensionBlock : TerraformBlock
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
/// Block type for stateless_rule_group_reference in AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallPolicyFirewallPolicyBlockStatelessRuleGroupReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateless_rule_group_reference";

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
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformValue<string> ResourceArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_firewall_policy Terraform resource.
/// Manages a aws_networkfirewall_firewall_policy resource.
/// </summary>
public partial class AwsNetworkfirewallFirewallPolicy(string name) : TerraformResource("aws_networkfirewall_firewall_policy", name)
{
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
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
        => CreateReference("update_token");

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallPolicyEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// FirewallPolicy block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FirewallPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FirewallPolicy block(s) allowed")]
    public required TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock> FirewallPolicy
    {
        get => GetRequiredArgument<TerraformList<AwsNetworkfirewallFirewallPolicyFirewallPolicyBlock>>("firewall_policy");
        set => SetArgument("firewall_policy", value);
    }

}
