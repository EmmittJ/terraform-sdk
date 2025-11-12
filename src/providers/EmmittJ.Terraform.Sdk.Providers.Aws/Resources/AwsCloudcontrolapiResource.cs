using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudcontrolapiResourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudcontrolapi_resource resource.
/// </summary>
public partial class AwsCloudcontrolapiResource : TerraformResource
{
    public AwsCloudcontrolapiResource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    [TerraformProperty("desired_state")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DesiredState { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformProperty("role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformProperty("schema")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Schema { get; set; }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    [TerraformProperty("type_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TypeName { get; set; }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    [TerraformProperty("type_version_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TypeVersionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsCloudcontrolapiResourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformProperty("properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Properties { get; }

}
