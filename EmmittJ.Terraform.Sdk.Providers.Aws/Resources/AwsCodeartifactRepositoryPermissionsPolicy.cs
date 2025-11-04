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
    public string? Domain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain")?.Value;
        set => this.WithProperty("domain", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public string? DomainOwner
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_owner")?.Value;
        set => this.WithProperty("domain_owner", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The policy_document attribute.
    /// </summary>
    public string? PolicyDocument
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_document")?.Value;
        set => this.WithProperty("policy_document", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The policy_revision attribute.
    /// </summary>
    public string? PolicyRevision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy_revision")?.Value;
        set => this.WithProperty("policy_revision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    public string? Repository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository")?.Value;
        set => this.WithProperty("repository", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

}
