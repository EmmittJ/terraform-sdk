using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lambda_layer_version_permission resource.
/// </summary>
public partial class AwsLambdaLayerVersionPermission : TerraformResource
{
    public AwsLambdaLayerVersionPermission(string name) : base("aws_lambda_layer_version_permission", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    [TerraformProperty("action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Action { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    [TerraformProperty("layer_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LayerName { get; set; }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [TerraformProperty("organization_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationId { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The skip_destroy attribute.
    /// </summary>
    [TerraformProperty("skip_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDestroy { get; set; }

    /// <summary>
    /// The statement_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatementId is required")]
    [TerraformProperty("statement_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StatementId { get; set; }

    /// <summary>
    /// The version_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VersionNumber is required")]
    [TerraformProperty("version_number")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> VersionNumber { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Policy { get; }

    /// <summary>
    /// The revision_id attribute.
    /// </summary>
    [TerraformProperty("revision_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RevisionId { get; }

}
