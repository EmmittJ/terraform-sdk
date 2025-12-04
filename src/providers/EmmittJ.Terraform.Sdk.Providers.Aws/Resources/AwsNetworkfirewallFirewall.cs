using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for availability_zone_mapping in AwsNetworkfirewallFirewall.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "availability_zone_mapping";

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZoneId is required")]
    public required TerraformValue<string> AvailabilityZoneId
    {
        get => GetArgument<TerraformValue<string>>("availability_zone_id");
        set => SetArgument("availability_zone_id", value);
    }

}


/// <summary>
/// Block type for encryption_configuration in AwsNetworkfirewallFirewall.
/// Nesting mode: list
/// </summary>
public class AwsNetworkfirewallFirewallEncryptionConfigurationBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for subnet_mapping in AwsNetworkfirewallFirewall.
/// Nesting mode: set
/// </summary>
public class AwsNetworkfirewallFirewallSubnetMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "subnet_mapping";

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string>? IpAddressType
    {
        get => GetArgument<TerraformValue<string>>("ip_address_type");
        set => SetArgument("ip_address_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsNetworkfirewallFirewall.
/// Nesting mode: single
/// </summary>
public class AwsNetworkfirewallFirewallTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_networkfirewall_firewall Terraform resource.
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
public partial class AwsNetworkfirewallFirewall(string name) : TerraformResource("aws_networkfirewall_firewall", name)
{
    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformValue<bool>? AvailabilityZoneChangeProtection
    {
        get => GetArgument<TerraformValue<bool>>("availability_zone_change_protection");
        set => SetArgument("availability_zone_change_protection", value);
    }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteProtection
    {
        get => GetArgument<TerraformValue<bool>>("delete_protection");
        set => SetArgument("delete_protection", value);
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
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformSet<string>? EnabledAnalysisTypes
    {
        get => GetArgument<TerraformSet<string>>("enabled_analysis_types");
        set => SetArgument("enabled_analysis_types", value);
    }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FirewallPolicyArn is required")]
    public required TerraformValue<string> FirewallPolicyArn
    {
        get => GetArgument<TerraformValue<string>>("firewall_policy_arn");
        set => SetArgument("firewall_policy_arn", value);
    }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformValue<bool>? FirewallPolicyChangeProtection
    {
        get => GetArgument<TerraformValue<bool>>("firewall_policy_change_protection");
        set => SetArgument("firewall_policy_change_protection", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformValue<bool>? SubnetChangeProtection
    {
        get => GetArgument<TerraformValue<bool>>("subnet_change_protection");
        set => SetArgument("subnet_change_protection", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcId
    {
        get => GetArgument<TerraformValue<string>>("vpc_id");
        set => SetArgument("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FirewallStatus
        => AsReference("firewall_status");

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayOwnerAccountId
        => AsReference("transit_gateway_owner_account_id");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
        => AsReference("update_token");

    /// <summary>
    /// AvailabilityZoneMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>? AvailabilityZoneMapping
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallAvailabilityZoneMappingBlock>>("availability_zone_mapping");
        set => SetArgument("availability_zone_mapping", value);
    }

    /// <summary>
    /// EncryptionConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EncryptionConfiguration block(s) allowed")]
    public TerraformList<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>? EncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsNetworkfirewallFirewallEncryptionConfigurationBlock>>("encryption_configuration");
        set => SetArgument("encryption_configuration", value);
    }

    /// <summary>
    /// SubnetMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsNetworkfirewallFirewallSubnetMappingBlock>? SubnetMapping
    {
        get => GetArgument<TerraformSet<AwsNetworkfirewallFirewallSubnetMappingBlock>>("subnet_mapping");
        set => SetArgument("subnet_mapping", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsNetworkfirewallFirewallTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsNetworkfirewallFirewallTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
