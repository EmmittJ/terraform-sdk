using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlock
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
    public TerraformSet<string>? EventClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformPropertyName("source_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SourceName { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformPropertyName("source_version")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SourceVersion { get; set; } = default!;

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsSecuritylakeCustomLogSourceConfigurationBlock>>? Configuration { get; set; }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Attributes => new TerraformReference(this, "attributes");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [TerraformPropertyName("provider_details")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ProviderDetails => new TerraformReference(this, "provider_details");

}
