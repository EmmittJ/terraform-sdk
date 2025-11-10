using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_connections in .
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryExternalConnectionsBlock : ITerraformBlock
{
    /// <summary>
    /// The external_connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalConnectionName is required")]
    [TerraformPropertyName("external_connection_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ExternalConnectionName { get; set; }

    /// <summary>
    /// The package_format attribute.
    /// </summary>
    [TerraformPropertyName("package_format")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PackageFormat => new TerraformReferenceProperty<TerraformProperty<string>>("", "package_format");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>("", "status");

}

/// <summary>
/// Block type for upstream in .
/// Nesting mode: list
/// </summary>
public class AwsCodeartifactRepositoryUpstreamBlock : ITerraformBlock
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RepositoryName { get; set; }

}

/// <summary>
/// Manages a aws_codeartifact_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodeartifactRepository : TerraformResource
{
    public AwsCodeartifactRepository(string name) : base("aws_codeartifact_repository", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformPropertyName("domain")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformPropertyName("domain_owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> DomainOwner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_owner");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformPropertyName("repository")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Repository { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for external_connections.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalConnections block(s) allowed")]
    [TerraformPropertyName("external_connections")]
    public TerraformList<TerraformBlock<AwsCodeartifactRepositoryExternalConnectionsBlock>>? ExternalConnections { get; set; } = new();

    /// <summary>
    /// Block for upstream.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("upstream")]
    public TerraformList<TerraformBlock<AwsCodeartifactRepositoryUpstreamBlock>>? Upstream { get; set; } = new();

    /// <summary>
    /// The administrator_account attribute.
    /// </summary>
    [TerraformPropertyName("administrator_account")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AdministratorAccount => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "administrator_account");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
