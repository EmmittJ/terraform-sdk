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
    public string? ClusterName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_name")?.Value;
        set => this.WithProperty("cluster_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_arn attribute.
    /// </summary>
    public string? PolicyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_arn")?.Value;
        set => this.WithProperty("policy_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    public string? PrincipalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal_arn")?.Value;
        set => this.WithProperty("principal_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
