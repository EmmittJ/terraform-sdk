using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_codeartifact_repository_endpoint.
/// </summary>
public class AwsCodeartifactRepositoryEndpointDataSource : TerraformDataSource
{
    public AwsCodeartifactRepositoryEndpointDataSource(string name) : base("aws_codeartifact_repository_endpoint", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("repository_endpoint");
        SetOutput("domain");
        SetOutput("domain_owner");
        SetOutput("format");
        SetOutput("id");
        SetOutput("region");
        SetOutput("repository");
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
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformProperty<string> Format
    {
        get => GetRequiredOutput<TerraformProperty<string>>("format");
        set => SetProperty("format", value);
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
    /// The repository_endpoint attribute.
    /// </summary>
    public TerraformExpression RepositoryEndpoint => this["repository_endpoint"];

}
