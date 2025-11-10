using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_firewall_policy.
/// </summary>
public class AwsNetworkfirewallFirewallPolicyDataSource : TerraformDataSource
{
    public AwsNetworkfirewallFirewallPolicyDataSource(string name) : base("aws_networkfirewall_firewall_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("firewall_policy");
        SetOutput("update_token");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The firewall_policy attribute.
    /// </summary>
    public TerraformExpression FirewallPolicy => this["firewall_policy"];

    /// <summary>
    /// The update_token attribute.
    /// </summary>
    public TerraformExpression UpdateToken => this["update_token"];

}
