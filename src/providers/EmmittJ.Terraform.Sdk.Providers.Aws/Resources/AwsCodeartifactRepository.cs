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
        set => SetProperty("external_connection_name", value);
    }

    /// <summary>
    /// The package_format attribute.
    /// </summary>
    public TerraformProperty<string>? PackageFormat
    {
        set => SetProperty("package_format", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        set => SetProperty("status", value);
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
        set => SetProperty("repository_name", value);
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
        SetOutput("administrator_account");
        SetOutput("arn");
        SetOutput("description");
        SetOutput("domain");
        SetOutput("domain_owner");
        SetOutput("id");
        SetOutput("region");
        SetOutput("repository");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformProperty<string> DomainOwner
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain_owner");
        set => SetProperty("domain_owner", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformProperty<string> Repository
    {
        get => GetRequiredOutput<TerraformProperty<string>>("repository");
        set => SetProperty("repository", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for external_connections.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalConnections block(s) allowed")]
    public List<AwsCodeartifactRepositoryExternalConnectionsBlock>? ExternalConnections
    {
        set => SetProperty("external_connections", value);
    }

    /// <summary>
    /// Block for upstream.
    /// Nesting mode: list
    /// </summary>
    public List<AwsCodeartifactRepositoryUpstreamBlock>? Upstream
    {
        set => SetProperty("upstream", value);
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
