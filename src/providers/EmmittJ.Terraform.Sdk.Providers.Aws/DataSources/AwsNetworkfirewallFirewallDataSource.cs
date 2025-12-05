using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_networkfirewall_firewall Terraform data source.
/// Retrieves information about a aws_networkfirewall_firewall.
/// </summary>
public partial class AwsNetworkfirewallFirewallDataSource(string name) : TerraformDataSource("aws_networkfirewall_firewall", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn") ?? CreateReference("arn");
        set => SetArgument("arn", value);
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
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? CreateReference("name");
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
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? CreateReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneChangeProtection
        => CreateReference("availability_zone_change_protection");

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AvailabilityZoneMapping
        => CreateReference("availability_zone_mapping");

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeleteProtection
        => CreateReference("delete_protection");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledAnalysisTypes
        => CreateReference("enabled_analysis_types");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EncryptionConfiguration
        => CreateReference("encryption_configuration");

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyArn
        => CreateReference("firewall_policy_arn");

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> FirewallPolicyChangeProtection
        => CreateReference("firewall_policy_change_protection");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FirewallStatus
        => CreateReference("firewall_status");

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> SubnetChangeProtection
        => CreateReference("subnet_change_protection");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SubnetMapping
        => CreateReference("subnet_mapping");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => CreateReference("transit_gateway_id");

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayOwnerAccountId
        => CreateReference("transit_gateway_owner_account_id");

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
        => CreateReference("update_token");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

}
