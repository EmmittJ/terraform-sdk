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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> AvailabilityZoneChangeProtection
    {
        get => new TerraformReference<bool>(this, "availability_zone_change_protection");
    }

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> AvailabilityZoneMapping
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "availability_zone_mapping").ResolveNodes(ctx));
    }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformValue<bool> DeleteProtection
    {
        get => new TerraformReference<bool>(this, "delete_protection");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformSet<string> EnabledAnalysisTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "enabled_analysis_types").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EncryptionConfiguration
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "encryption_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    public TerraformValue<string> FirewallPolicyArn
    {
        get => new TerraformReference<string>(this, "firewall_policy_arn");
    }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> FirewallPolicyChangeProtection
    {
        get => new TerraformReference<bool>(this, "firewall_policy_change_protection");
    }

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FirewallStatus
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "firewall_status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformValue<bool> SubnetChangeProtection
    {
        get => new TerraformReference<bool>(this, "subnet_change_protection");
    }

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> SubnetMapping
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "subnet_mapping").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
    {
        get => new TerraformReference<string>(this, "transit_gateway_id");
    }

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayOwnerAccountId
    {
        get => new TerraformReference<string>(this, "transit_gateway_owner_account_id");
    }

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformValue<string> UpdateToken
    {
        get => new TerraformReference<string>(this, "update_token");
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
    {
        get => new TerraformReference<string>(this, "vpc_id");
    }

}
