using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_export.
/// </summary>
public class AwsApigatewayv2ExportDataSource : TerraformDataSource
{
    public AwsApigatewayv2ExportDataSource(string name) : base("aws_apigatewayv2_export", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformPropertyName("api_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    [TerraformPropertyName("export_version")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ExportVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The include_extensions attribute.
    /// </summary>
    [TerraformPropertyName("include_extensions")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IncludeExtensions { get; set; }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    [TerraformPropertyName("output_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OutputType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    [TerraformPropertyName("specification")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Specification { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [TerraformPropertyName("stage_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StageName { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformPropertyName("body")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Body => new TerraformReference(this, "body");

}
