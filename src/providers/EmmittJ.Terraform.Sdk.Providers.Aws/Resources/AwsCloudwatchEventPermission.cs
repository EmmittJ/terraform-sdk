using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudwatchEventPermissionConditionBlock() : TerraformBlock("condition")
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Manages a aws_cloudwatch_event_permission resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudwatchEventPermission : TerraformResource
{
    public AwsCloudwatchEventPermission(string name) : base("aws_cloudwatch_event_permission", name)
    {
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Action { get; set; }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    [TerraformProperty("event_bus_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? EventBusName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

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
    /// The statement_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StatementId is required")]
    [TerraformProperty("statement_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StatementId { get; set; }

    /// <summary>
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    [TerraformProperty("condition")]
    public TerraformList<AwsCloudwatchEventPermissionConditionBlock> Condition { get; set; } = new();

}
