using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_export.
/// </summary>
public partial class AwsApiGatewayExportDataSource : TerraformDataSource
{
    public AwsApiGatewayExportDataSource(string name) : base("aws_api_gateway_export", name)
    {
    }

    /// <summary>
    /// The accepts attribute.
    /// </summary>
    [TerraformProperty("accepts")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Accepts { get; set; }

    /// <summary>
    /// The export_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExportType is required")]
    [TerraformProperty("export_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExportType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The rest_api_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RestApiId is required")]
    [TerraformProperty("rest_api_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RestApiId { get; set; }

    /// <summary>
    /// The stage_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StageName is required")]
    [TerraformProperty("stage_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> StageName { get; set; }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Body { get; }

    /// <summary>
    /// The content_disposition attribute.
    /// </summary>
    [TerraformProperty("content_disposition")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentDisposition { get; }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    [TerraformProperty("content_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContentType { get; }

}
