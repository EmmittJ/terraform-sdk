using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for external_connections in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodeartifactRepositoryExternalConnectionsBlock() : TerraformBlock("external_connections")
{
    /// <summary>
    /// The external_connection_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalConnectionName is required")]
    [TerraformProperty("external_connection_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ExternalConnectionName { get; set; }



}

/// <summary>
/// Block type for upstream in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodeartifactRepositoryUpstreamBlock() : TerraformBlock("upstream")
{
    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

}

/// <summary>
/// Manages a aws_codeartifact_repository resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodeartifactRepository : TerraformResource
{
    public AwsCodeartifactRepository(string name) : base("aws_codeartifact_repository", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    [TerraformProperty("domain")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Domain { get; set; }

    /// <summary>
    /// The domain_owner attribute.
    /// </summary>
    [TerraformProperty("domain_owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainOwner { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Repository is required")]
    [TerraformProperty("repository")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Repository { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for external_connections.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExternalConnections block(s) allowed")]
    [TerraformProperty("external_connections")]
    public TerraformList<AwsCodeartifactRepositoryExternalConnectionsBlock> ExternalConnections { get; set; } = new();

    /// <summary>
    /// Block for upstream.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("upstream")]
    public TerraformList<AwsCodeartifactRepositoryUpstreamBlock> Upstream { get; set; } = new();

    /// <summary>
    /// The administrator_account attribute.
    /// </summary>
    [TerraformProperty("administrator_account")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AdministratorAccount { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
