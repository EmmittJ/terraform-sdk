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
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    public TerraformValue<string>? Name
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneChangeProtection
        => AsReference("availability_zone_change_protection");

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AvailabilityZoneMapping
        => AsReference("availability_zone_mapping");

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeleteProtection
        => AsReference("delete_protection");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledAnalysisTypes
        => AsReference("enabled_analysis_types");

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EncryptionConfiguration
        => AsReference("encryption_configuration");

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyArn
        => AsReference("firewall_policy_arn");

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> FirewallPolicyChangeProtection
        => AsReference("firewall_policy_change_protection");

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FirewallStatus
        => AsReference("firewall_status");

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> SubnetChangeProtection
        => AsReference("subnet_change_protection");

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SubnetMapping
        => AsReference("subnet_mapping");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => AsReference("transit_gateway_id");

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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

}
