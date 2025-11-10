using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlock : ITerraformBlock
{
}

/// <summary>
/// Manages a aws_securitylake_custom_log_source resource.
/// </summary>
public class AwsSecuritylakeCustomLogSource : TerraformResource
{
    public AwsSecuritylakeCustomLogSource(string name) : base("aws_securitylake_custom_log_source", name)
    {
    }

    /// <summary>
    /// The event_classes attribute.
    /// </summary>
    [TerraformPropertyName("event_classes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EventClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformPropertyName("source_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceName { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformPropertyName("source_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SourceVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "source_version");

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsSecuritylakeCustomLogSourceConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Attributes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "attributes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [TerraformPropertyName("provider_details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ProviderDetails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "provider_details");

}
