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
        this.DeclareOutput("delete_protection");
        this.DeclareOutput("description");
        this.DeclareOutput("enabled_analysis_types");
        this.DeclareOutput("encryption_configuration");
        this.DeclareOutput("firewall_policy_arn");
        this.DeclareOutput("firewall_policy_change_protection");
        this.DeclareOutput("firewall_status");
        this.DeclareOutput("subnet_change_protection");
        this.DeclareOutput("subnet_mapping");
        this.DeclareOutput("update_token");
        this.DeclareOutput("vpc_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

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
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
