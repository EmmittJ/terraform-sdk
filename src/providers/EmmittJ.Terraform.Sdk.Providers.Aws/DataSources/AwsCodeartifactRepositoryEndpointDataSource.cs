using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codeartifact_repository_endpoint Terraform data source.
/// Retrieves information about a aws_codeartifact_repository_endpoint.
/// </summary>
public partial class AwsCodeartifactRepositoryEndpointDataSource(string name) : TerraformDataSource("aws_codeartifact_repository_endpoint", name)
{
    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    public TerraformValue<string> DomainOwner
    {
        get => new TerraformReference<string>(this, "domain_owner");
        set => SetArgument("domain_owner", value);
    }

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    public required TerraformValue<string> Repository
    {
        get => new TerraformReference<string>(this, "repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The repository_endpoint attribute.
    /// </summary>
    public TerraformValue<string> RepositoryEndpoint
    {
        get => new TerraformReference<string>(this, "repository_endpoint");
    }

}
