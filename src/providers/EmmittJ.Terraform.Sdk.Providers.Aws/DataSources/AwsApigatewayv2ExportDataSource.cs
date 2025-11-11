using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_apigatewayv2_export.
/// </summary>
public partial class AwsApigatewayv2ExportDataSource : TerraformDataSource
{
    public AwsApigatewayv2ExportDataSource(string name) : base("aws_apigatewayv2_export", name)
    {
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiId is required")]
    [TerraformProperty("api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiId { get; set; }

    /// <summary>
    /// The export_version attribute.
    /// </summary>
    [TerraformProperty("export_version")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ExportVersion { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The include_extensions attribute.
    /// </summary>
    [TerraformProperty("include_extensions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IncludeExtensions { get; set; }

    /// <summary>
    /// The output_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OutputType is required")]
    [TerraformProperty("output_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OutputType { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The specification attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Specification is required")]
    [TerraformProperty("specification")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Specification { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [TerraformProperty("stage_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StageName { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Body { get; }

}
