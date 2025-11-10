using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_serverlessapplicationrepository_application.
/// </summary>
public class AwsServerlessapplicationrepositoryApplicationDataSource : TerraformDataSource
{
    public AwsServerlessapplicationrepositoryApplicationDataSource(string name) : base("aws_serverlessapplicationrepository_application", name)
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    [TerraformPropertyName("application_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ApplicationId { get; set; }

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
    /// The semantic_version attribute.
    /// </summary>
    [TerraformPropertyName("semantic_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SemanticVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "semantic_version");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The required_capabilities attribute.
    /// </summary>
    [TerraformPropertyName("required_capabilities")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> RequiredCapabilities => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "required_capabilities");

    /// <summary>
    /// The source_code_url attribute.
    /// </summary>
    [TerraformPropertyName("source_code_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceCodeUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_code_url");

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformPropertyName("template_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TemplateUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_url");

}
