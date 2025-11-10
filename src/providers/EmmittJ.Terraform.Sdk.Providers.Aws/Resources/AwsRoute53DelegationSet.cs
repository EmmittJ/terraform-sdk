using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53_delegation_set resource.
/// </summary>
public class AwsRoute53DelegationSet : TerraformResource
{
    public AwsRoute53DelegationSet(string name) : base("aws_route53_delegation_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("name_servers");
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
    /// The reference_name attribute.
    /// </summary>
    public TerraformProperty<string>? ReferenceName
    {
        get => GetProperty<TerraformProperty<string>>("reference_name");
        set => this.WithProperty("reference_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformExpression NameServers => this["name_servers"];

}
