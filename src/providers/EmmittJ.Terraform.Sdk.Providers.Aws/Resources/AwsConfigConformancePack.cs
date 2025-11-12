using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for input_parameter in .
/// Nesting mode: set
/// </summary>
public partial class AwsConfigConformancePackInputParameterBlock() : TerraformBlock("input_parameter")
{
    /// <summary>
    /// The parameter_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterName is required")]
    [TerraformProperty("parameter_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterName { get; set; }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    [TerraformProperty("parameter_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterValue { get; set; }

}

/// <summary>
/// Manages a aws_config_conformance_pack resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsConfigConformancePack : TerraformResource
{
    public AwsConfigConformancePack(string name) : base("aws_config_conformance_pack", name)
    {
    }

    /// <summary>
    /// The delivery_s3_bucket attribute.
    /// </summary>
    [TerraformProperty("delivery_s3_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryS3Bucket { get; set; }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    [TerraformProperty("delivery_s3_key_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeliveryS3KeyPrefix { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformProperty("template_body")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateBody { get; set; }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    [TerraformProperty("template_s3_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateS3Uri { get; set; }

    /// <summary>
    /// Block for input_parameter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(60, ErrorMessage = "Maximum 60 InputParameter block(s) allowed")]
    [TerraformProperty("input_parameter")]
    public TerraformSet<AwsConfigConformancePackInputParameterBlock> InputParameter { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
