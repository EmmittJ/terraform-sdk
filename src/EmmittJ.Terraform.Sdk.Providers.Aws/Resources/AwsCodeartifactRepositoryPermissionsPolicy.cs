using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_codeartifact_repository_permissions_policy resource.
/// </summary>
public class AwsCodeartifactRepositoryPermissionsPolicy : TerraformResource
{
    public AwsCodeartifactRepositoryPermissionsPolicy(string name) : base("aws_codeartifact_repository_permissions_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_arn");
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_owner");
        set => this.WithProperty("domain_owner", value);
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
    /// The policy_document attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document");
        set => this.WithProperty("policy_document", value);
    }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PolicyRevision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_revision");
        set => this.WithProperty("policy_revision", value);
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
    /// The repository attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Repository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository");
        set => this.WithProperty("repository", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
