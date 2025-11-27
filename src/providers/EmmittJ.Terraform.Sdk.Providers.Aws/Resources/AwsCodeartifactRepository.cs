using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_connections in AwsCodeartifactRepository.
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryExternalConnectionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "external_connections";

    /// <summary>
    /// The external_connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalConnectionName is required")]
    public required TerraformValue<string> ExternalConnectionName
    {
        get => new TerraformReference<string>(this, "external_connection_name");
        set => SetArgument("external_connection_name", value);
    }

    /// <summary>
    /// The package_format attribute.
    /// </summary>
    public TerraformValue<string> PackageFormat
    {
        get => new TerraformReference<string>(this, "package_format");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}


/// <summary>
/// Block type for upstream in AwsCodeartifactRepository.
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryUpstreamBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upstream";

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

}


/// <summary>
/// Represents a aws_codeartifact_repository Terraform resource.
/// Manages a aws_codeartifact_repository resource.
/// </summary>
public partial class AwsCodeartifactRepository(string name) : TerraformResource("aws_codeartifact_repository", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The administrator_account attribute.
    /// </summary>
    public TerraformValue<string> AdministratorAccount
    {
        get => new TerraformReference<string>(this, "administrator_account");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// ExternalConnections block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalConnections block(s) allowed")]
    public TerraformList<AwsCodeartifactRepositoryExternalConnectionsBlock>? ExternalConnections
    {
        get => GetArgument<TerraformList<AwsCodeartifactRepositoryExternalConnectionsBlock>>("external_connections");
        set => SetArgument("external_connections", value);
    }

    /// <summary>
    /// Upstream block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsCodeartifactRepositoryUpstreamBlock>? Upstream
    {
        get => GetArgument<TerraformList<AwsCodeartifactRepositoryUpstreamBlock>>("upstream");
        set => SetArgument("upstream", value);
    }

}
