using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkfirewall_firewall resource.
/// </summary>
public class AwsNetworkfirewallFirewall : TerraformResource
{
    public AwsNetworkfirewallFirewall(string name) : base("aws_networkfirewall_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("firewall_status");
        this.DeclareOutput("transit_gateway_owner_account_id");
        this.DeclareOutput("update_token");
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? AvailabilityZoneChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("availability_zone_change_protection");
        set => this.WithProperty("availability_zone_change_protection", value);
    }

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteProtection
    {
        get => GetProperty<TerraformProperty<bool>>("delete_protection");
        set => this.WithProperty("delete_protection", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? EnabledAnalysisTypes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("enabled_analysis_types");
        set => this.WithProperty("enabled_analysis_types", value);
    }

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallPolicyArn
    {
        get => GetProperty<TerraformProperty<string>>("firewall_policy_arn");
        set => this.WithProperty("firewall_policy_arn", value);
    }

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? FirewallPolicyChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("firewall_policy_change_protection");
        set => this.WithProperty("firewall_policy_change_protection", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? SubnetChangeProtection
    {
        get => GetProperty<TerraformProperty<bool>>("subnet_change_protection");
        set => this.WithProperty("subnet_change_protection", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_id");
        set => this.WithProperty("transit_gateway_id", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformExpression FirewallStatus => this["firewall_status"];

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayOwnerAccountId => this["transit_gateway_owner_account_id"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

}
