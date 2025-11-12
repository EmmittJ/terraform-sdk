using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for authentication_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCodepipelineWebhookAuthenticationConfigurationBlock() : TerraformBlock("authentication_configuration")
{
    /// <summary>
    /// The allowed_ip_range attribute.
    /// </summary>
    [TerraformProperty("allowed_ip_range")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AllowedIpRange { get; set; }

    /// <summary>
    /// The secret_token attribute.
    /// </summary>
    [TerraformProperty("secret_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecretToken { get; set; }

}

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsCodepipelineWebhookFilterBlock() : TerraformBlock("filter")
{
    /// <summary>
    /// The json_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "JsonPath is required")]
    [TerraformProperty("json_path")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> JsonPath { get; set; }

    /// <summary>
    /// The match_equals attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchEquals is required")]
    [TerraformProperty("match_equals")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MatchEquals { get; set; }

}

/// <summary>
/// Manages a aws_codepipeline_webhook resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCodepipelineWebhook : TerraformResource
{
    public AwsCodepipelineWebhook(string name) : base("aws_codepipeline_webhook", name)
    {
    }

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Authentication is required")]
    [TerraformProperty("authentication")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Authentication { get; set; }

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
    /// The target_action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetAction is required")]
    [TerraformProperty("target_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetAction { get; set; }

    /// <summary>
    /// The target_pipeline attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetPipeline is required")]
    [TerraformProperty("target_pipeline")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetPipeline { get; set; }

    /// <summary>
    /// Block for authentication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    [TerraformProperty("authentication_configuration")]
    public TerraformList<AwsCodepipelineWebhookAuthenticationConfigurationBlock> AuthenticationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Filter block(s) allowed")]
    [TerraformProperty("filter")]
    public required TerraformSet<AwsCodepipelineWebhookFilterBlock> Filter { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Url { get; }

}
