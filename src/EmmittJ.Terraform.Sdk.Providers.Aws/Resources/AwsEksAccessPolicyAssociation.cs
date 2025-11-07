using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eks_access_policy_association resource.
/// </summary>
public class AwsEksAccessPolicyAssociation : TerraformResource
{
    public AwsEksAccessPolicyAssociation(string name) : base("aws_eks_access_policy_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_at");
        this.DeclareOutput("modified_at");
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn");
        set => this.WithProperty("policy_arn", value);
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrincipalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_arn");
        set => this.WithProperty("principal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The associated_at attribute.
    /// </summary>
    public TerraformExpression AssociatedAt => this["associated_at"];

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    public TerraformExpression ModifiedAt => this["modified_at"];

}
