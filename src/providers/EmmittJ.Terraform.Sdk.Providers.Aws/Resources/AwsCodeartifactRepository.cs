using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_connections in .
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryExternalConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// The external_connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalConnectionName is required")]
    public required TerraformProperty<string> ExternalConnectionName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("external_connection_name");
        set => WithProperty("external_connection_name", value);
    }

    /// <summary>
    /// The package_format attribute.
    /// </summary>
    public TerraformProperty<string>? PackageFormat
    {
        get => GetProperty<TerraformProperty<string>>("package_format");
        set => WithProperty("package_format", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

}

/// <summary>
/// Block type for upstream in .
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryUpstreamBlock : TerraformBlock
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

}

/// <summary>
/// Manages a aws_codeartifact_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodeartifactRepository : TerraformResource
{
    public AwsCodeartifactRepository(string name) : base("aws_codeartifact_repository", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("administrator_account");
        this.WithOutput("arn");
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
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredProperty<TerraformProperty<string>>("domain");
        set => this.WithProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformProperty<string>? DomainOwner
    {
        get => GetProperty<TerraformProperty<string>>("domain_owner");
        set => this.WithProperty("domain_owner", value);
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
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformProperty<string> Repository
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository");
        set => this.WithProperty("repository", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for external_connections.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalConnections block(s) allowed")]
    public List<AwsCodeartifactRepositoryExternalConnectionsBlock>? ExternalConnections
    {
        get => GetProperty<List<AwsCodeartifactRepositoryExternalConnectionsBlock>>("external_connections");
        set => this.WithProperty("external_connections", value);
    }

    /// <summary>
    /// Block for upstream.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodeartifactRepositoryUpstreamBlock>? Upstream
    {
        get => GetProperty<List<AwsCodeartifactRepositoryUpstreamBlock>>("upstream");
        set => this.WithProperty("upstream", value);
    }

    /// <summary>
    /// The administrator_account attribute.
    /// </summary>
    public TerraformExpression AdministratorAccount => this["administrator_account"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
