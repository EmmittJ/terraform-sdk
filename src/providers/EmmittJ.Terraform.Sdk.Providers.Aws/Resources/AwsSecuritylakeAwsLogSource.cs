using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeAwsLogSourceSourceBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformSet<string> Accounts { get; set; } = default!;

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Regions is required")]
    [TerraformPropertyName("regions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> Regions { get; set; }

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

}

/// <summary>
/// Manages a aws_securitylake_aws_log_source resource.
/// </summary>
public class AwsSecuritylakeAwsLogSource : TerraformResource
{
    public AwsSecuritylakeAwsLogSource(string name) : base("aws_securitylake_aws_log_source", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("source")]
    public TerraformList<TerraformBlock<AwsSecuritylakeAwsLogSourceSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
