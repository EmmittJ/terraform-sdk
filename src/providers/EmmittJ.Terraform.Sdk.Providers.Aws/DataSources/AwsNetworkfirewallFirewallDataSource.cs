using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_firewall.
/// </summary>
public class AwsNetworkfirewallFirewallDataSource : TerraformDataSource
{
    public AwsNetworkfirewallFirewallDataSource(string name) : base("aws_networkfirewall_firewall", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("availability_zone_change_protection");
        this.DeclareOutput("availability_zone_mapping");
        this.DeclareOutput("delete_protection");
        this.DeclareOutput("description");
        this.DeclareOutput("enabled_analysis_types");
        this.DeclareOutput("encryption_configuration");
        this.DeclareOutput("firewall_policy_arn");
        this.DeclareOutput("firewall_policy_change_protection");
        this.DeclareOutput("firewall_status");
        this.DeclareOutput("subnet_change_protection");
        this.DeclareOutput("subnet_mapping");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("transit_gateway_owner_account_id");
        this.DeclareOutput("update_token");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The availability_zone_change_protection attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneChangeProtection => this["availability_zone_change_protection"];

    /// <summary>
    /// The availability_zone_mapping attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneMapping => this["availability_zone_mapping"];

    /// <summary>
    /// The delete_protection attribute.
    /// </summary>
    public TerraformExpression DeleteProtection => this["delete_protection"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The enabled_analysis_types attribute.
    /// </summary>
    public TerraformExpression EnabledAnalysisTypes => this["enabled_analysis_types"];

    /// <summary>
    /// The encryption_configuration attribute.
    /// </summary>
    public TerraformExpression EncryptionConfiguration => this["encryption_configuration"];

    /// <summary>
    /// The firewall_policy_arn attribute.
    /// </summary>
    public TerraformExpression FirewallPolicyArn => this["firewall_policy_arn"];

    /// <summary>
    /// The firewall_policy_change_protection attribute.
    /// </summary>
    public TerraformExpression FirewallPolicyChangeProtection => this["firewall_policy_change_protection"];

    /// <summary>
    /// The firewall_status attribute.
    /// </summary>
    public TerraformExpression FirewallStatus => this["firewall_status"];

    /// <summary>
    /// The subnet_change_protection attribute.
    /// </summary>
    public TerraformExpression SubnetChangeProtection => this["subnet_change_protection"];

    /// <summary>
    /// The subnet_mapping attribute.
    /// </summary>
    public TerraformExpression SubnetMapping => this["subnet_mapping"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The transit_gateway_owner_account_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayOwnerAccountId => this["transit_gateway_owner_account_id"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
