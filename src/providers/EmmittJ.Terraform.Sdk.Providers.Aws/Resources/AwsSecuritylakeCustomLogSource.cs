using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSecuritylakeCustomLogSourceConfigurationBlock() : TerraformBlock("configuration")
{
}

/// <summary>
/// Manages a aws_securitylake_custom_log_source resource.
/// </summary>
public partial class AwsSecuritylakeCustomLogSource : TerraformResource
{
    public AwsSecuritylakeCustomLogSource(string name) : base("aws_securitylake_custom_log_source", name)
    {
    }

    /// <summary>
    /// The event_classes attribute.
    /// </summary>
    [TerraformProperty("event_classes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? EventClasses { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformProperty("source_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceName { get; set; }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    [TerraformProperty("source_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SourceVersion { get; set; }

    /// <summary>
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("configuration")]
    public TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlock> Configuration { get; set; } = new();

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformProperty("attributes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Attributes { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [TerraformProperty("provider_details")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ProviderDetails { get; }

}
