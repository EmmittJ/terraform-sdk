using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_networkfirewall_resource_policy.
/// </summary>
public class AwsNetworkfirewallResourcePolicyDataSource : TerraformDataSource
{
    public AwsNetworkfirewallResourcePolicyDataSource(string name) : base("aws_networkfirewall_resource_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("policy");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetProperty<TerraformProperty<string>>("resource_arn");
        set => this.WithProperty("resource_arn", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformExpression Policy => this["policy"];

}
