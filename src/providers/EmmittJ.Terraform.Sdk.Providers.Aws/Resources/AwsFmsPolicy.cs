using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_map in AwsFmsPolicy.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyExcludeMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "exclude_map";

    /// <summary>
    /// The account attribute.
    /// </summary>
    public TerraformSet<string>? Account
    {
        get => GetArgument<TerraformSet<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public TerraformSet<string>? Orgunit
    {
        get => GetArgument<TerraformSet<string>>("orgunit");
        set => SetArgument("orgunit", value);
    }

}


/// <summary>
/// Block type for include_map in AwsFmsPolicy.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyIncludeMapBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_map";

    /// <summary>
    /// The account attribute.
    /// </summary>
    public TerraformSet<string>? Account
    {
        get => GetArgument<TerraformSet<string>>("account");
        set => SetArgument("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public TerraformSet<string>? Orgunit
    {
        get => GetArgument<TerraformSet<string>>("orgunit");
        set => SetArgument("orgunit", value);
    }

}


/// <summary>
/// Block type for security_service_policy_data in AwsFmsPolicy.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "security_service_policy_data";

    /// <summary>
    /// The managed_service_data attribute.
    /// </summary>
    public TerraformValue<string>? ManagedServiceData
    {
        get => GetArgument<TerraformValue<string>>("managed_service_data");
        set => SetArgument("managed_service_data", value);
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
    /// PolicyOption block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyOption block(s) allowed")]
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock>? PolicyOption
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock>>("policy_option");
        set => SetArgument("policy_option", value);
    }

}

/// <summary>
/// Block type for policy_option in AwsFmsPolicySecurityServicePolicyDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy_option";

    /// <summary>
    /// NetworkAclCommonPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAclCommonPolicy block(s) allowed")]
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlock>? NetworkAclCommonPolicy
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlock>>("network_acl_common_policy");
        set => SetArgument("network_acl_common_policy", value);
    }

    /// <summary>
    /// NetworkFirewallPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkFirewallPolicy block(s) allowed")]
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkFirewallPolicyBlock>? NetworkFirewallPolicy
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkFirewallPolicyBlock>>("network_firewall_policy");
        set => SetArgument("network_firewall_policy", value);
    }

    /// <summary>
    /// ThirdPartyFirewallPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ThirdPartyFirewallPolicy block(s) allowed")]
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockThirdPartyFirewallPolicyBlock>? ThirdPartyFirewallPolicy
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockThirdPartyFirewallPolicyBlock>>("third_party_firewall_policy");
        set => SetArgument("third_party_firewall_policy", value);
    }

}

/// <summary>
/// Block type for network_acl_common_policy in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_acl_common_policy";

    /// <summary>
    /// NetworkAclEntrySet block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkAclEntrySet block(s) allowed")]
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlock>? NetworkAclEntrySet
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlock>>("network_acl_entry_set");
        set => SetArgument("network_acl_entry_set", value);
    }

}

/// <summary>
/// Block type for network_acl_entry_set in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_acl_entry_set";

    /// <summary>
    /// The force_remediate_for_first_entries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceRemediateForFirstEntries is required")]
    public required TerraformValue<bool> ForceRemediateForFirstEntries
    {
        get => GetRequiredArgument<TerraformValue<bool>>("force_remediate_for_first_entries");
        set => SetArgument("force_remediate_for_first_entries", value);
    }

    /// <summary>
    /// The force_remediate_for_last_entries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ForceRemediateForLastEntries is required")]
    public required TerraformValue<bool> ForceRemediateForLastEntries
    {
        get => GetRequiredArgument<TerraformValue<bool>>("force_remediate_for_last_entries");
        set => SetArgument("force_remediate_for_last_entries", value);
    }

    /// <summary>
    /// FirstEntry block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlock>? FirstEntry
    {
        get => GetArgument<TerraformSet<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlock>>("first_entry");
        set => SetArgument("first_entry", value);
    }

    /// <summary>
    /// LastEntry block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlock>? LastEntry
    {
        get => GetArgument<TerraformSet<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlock>>("last_entry");
        set => SetArgument("last_entry", value);
    }

}

/// <summary>
/// Block type for first_entry in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlock.
/// Nesting mode: set
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "first_entry";

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Egress is required")]
    public required TerraformValue<bool> Egress
    {
        get => GetRequiredArgument<TerraformValue<bool>>("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// IcmpTypeCode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockIcmpTypeCodeBlock>? IcmpTypeCode
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockIcmpTypeCodeBlock>>("icmp_type_code");
        set => SetArgument("icmp_type_code", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for icmp_type_code in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockIcmpTypeCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "icmp_type_code";

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformValue<double>? Code
    {
        get => GetArgument<TerraformValue<double>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<double>? Type
    {
        get => GetArgument<TerraformValue<double>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for port_range in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockFirstEntryBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from attribute.
    /// </summary>
    public TerraformValue<double>? From
    {
        get => GetArgument<TerraformValue<double>>("from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    public TerraformValue<double>? To
    {
        get => GetArgument<TerraformValue<double>>("to");
        set => SetArgument("to", value);
    }

}

/// <summary>
/// Block type for last_entry in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlock.
/// Nesting mode: set
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "last_entry";

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("cidr_block");
        set => SetArgument("cidr_block", value);
    }

    /// <summary>
    /// The egress attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Egress is required")]
    public required TerraformValue<bool> Egress
    {
        get => GetRequiredArgument<TerraformValue<bool>>("egress");
        set => SetArgument("egress", value);
    }

    /// <summary>
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformValue<string>? Ipv6CidrBlock
    {
        get => GetArgument<TerraformValue<string>>("ipv6_cidr_block");
        set => SetArgument("ipv6_cidr_block", value);
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
    /// The rule_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleAction is required")]
    public required TerraformValue<string> RuleAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("rule_action");
        set => SetArgument("rule_action", value);
    }

    /// <summary>
    /// IcmpTypeCode block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockIcmpTypeCodeBlock>? IcmpTypeCode
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockIcmpTypeCodeBlock>>("icmp_type_code");
        set => SetArgument("icmp_type_code", value);
    }

    /// <summary>
    /// PortRange block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockPortRangeBlock>? PortRange
    {
        get => GetArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockPortRangeBlock>>("port_range");
        set => SetArgument("port_range", value);
    }

}

/// <summary>
/// Block type for icmp_type_code in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockIcmpTypeCodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "icmp_type_code";

    /// <summary>
    /// The code attribute.
    /// </summary>
    public TerraformValue<double>? Code
    {
        get => GetArgument<TerraformValue<double>>("code");
        set => SetArgument("code", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<double>? Type
    {
        get => GetArgument<TerraformValue<double>>("type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for port_range in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkAclCommonPolicyBlockNetworkAclEntrySetBlockLastEntryBlockPortRangeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "port_range";

    /// <summary>
    /// The from attribute.
    /// </summary>
    public TerraformValue<double>? From
    {
        get => GetArgument<TerraformValue<double>>("from");
        set => SetArgument("from", value);
    }

    /// <summary>
    /// The to attribute.
    /// </summary>
    public TerraformValue<double>? To
    {
        get => GetArgument<TerraformValue<double>>("to");
        set => SetArgument("to", value);
    }

}

/// <summary>
/// Block type for network_firewall_policy in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockNetworkFirewallPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_firewall_policy";

    /// <summary>
    /// The firewall_deployment_model attribute.
    /// </summary>
    public TerraformValue<string>? FirewallDeploymentModel
    {
        get => GetArgument<TerraformValue<string>>("firewall_deployment_model");
        set => SetArgument("firewall_deployment_model", value);
    }

}

/// <summary>
/// Block type for third_party_firewall_policy in AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlock.
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlockPolicyOptionBlockThirdPartyFirewallPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "third_party_firewall_policy";

    /// <summary>
    /// The firewall_deployment_model attribute.
    /// </summary>
    public TerraformValue<string>? FirewallDeploymentModel
    {
        get => GetArgument<TerraformValue<string>>("firewall_deployment_model");
        set => SetArgument("firewall_deployment_model", value);
    }

}


/// <summary>
/// Represents a aws_fms_policy Terraform resource.
/// Manages a aws_fms_policy resource.
/// </summary>
public partial class AwsFmsPolicy(string name) : TerraformResource("aws_fms_policy", name)
{
    /// <summary>
    /// The delete_all_policy_resources attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteAllPolicyResources
    {
        get => GetArgument<TerraformValue<bool>>("delete_all_policy_resources");
        set => SetArgument("delete_all_policy_resources", value);
    }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteUnusedFmManagedResources
    {
        get => GetArgument<TerraformValue<bool>>("delete_unused_fm_managed_resources");
        set => SetArgument("delete_unused_fm_managed_resources", value);
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
    /// The exclude_resource_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExcludeResourceTags is required")]
    public required TerraformValue<bool> ExcludeResourceTags
    {
        get => GetRequiredArgument<TerraformValue<bool>>("exclude_resource_tags");
        set => SetArgument("exclude_resource_tags", value);
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
    /// The remediation_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? RemediationEnabled
    {
        get => GetArgument<TerraformValue<bool>>("remediation_enabled");
        set => SetArgument("remediation_enabled", value);
    }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    public TerraformSet<string> ResourceSetIds
    {
        get => GetArgument<TerraformSet<string>>("resource_set_ids") ?? CreateReference("resource_set_ids");
        set => SetArgument("resource_set_ids", value);
    }

    /// <summary>
    /// The resource_tag_logical_operator attribute.
    /// </summary>
    public TerraformValue<string> ResourceTagLogicalOperator
    {
        get => GetArgument<TerraformValue<string>>("resource_tag_logical_operator") ?? CreateReference("resource_tag_logical_operator");
        set => SetArgument("resource_tag_logical_operator", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public TerraformMap<string>? ResourceTags
    {
        get => GetArgument<TerraformMap<string>>("resource_tags");
        set => SetArgument("resource_tags", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type") ?? CreateReference("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    public TerraformSet<string> ResourceTypeList
    {
        get => GetArgument<TerraformSet<string>>("resource_type_list") ?? CreateReference("resource_type_list");
        set => SetArgument("resource_type_list", value);
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
    /// The policy_update_token attribute.
    /// </summary>
    public TerraformValue<string> PolicyUpdateToken
        => CreateReference("policy_update_token");

    /// <summary>
    /// ExcludeMap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeMap block(s) allowed")]
    public TerraformList<AwsFmsPolicyExcludeMapBlock>? ExcludeMap
    {
        get => GetArgument<TerraformList<AwsFmsPolicyExcludeMapBlock>>("exclude_map");
        set => SetArgument("exclude_map", value);
    }

    /// <summary>
    /// IncludeMap block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeMap block(s) allowed")]
    public TerraformList<AwsFmsPolicyIncludeMapBlock>? IncludeMap
    {
        get => GetArgument<TerraformList<AwsFmsPolicyIncludeMapBlock>>("include_map");
        set => SetArgument("include_map", value);
    }

    /// <summary>
    /// SecurityServicePolicyData block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityServicePolicyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityServicePolicyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityServicePolicyData block(s) allowed")]
    public required TerraformList<AwsFmsPolicySecurityServicePolicyDataBlock> SecurityServicePolicyData
    {
        get => GetRequiredArgument<TerraformList<AwsFmsPolicySecurityServicePolicyDataBlock>>("security_service_policy_data");
        set => SetArgument("security_service_policy_data", value);
    }

}
