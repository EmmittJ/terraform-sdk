using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmMaintenanceWindowTaskTargetsBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for task_invocation_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_ssm_maintenance_window_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmMaintenanceWindowTask : TerraformResource
{
    public AwsSsmMaintenanceWindowTask(string name) : base("aws_ssm_maintenance_window_task", name)
    {
    }

    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    [TerraformProperty("cutoff_behavior")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CutoffBehavior { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformProperty("max_concurrency")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxConcurrency { get; set; }

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    [TerraformProperty("max_errors")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> MaxErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformProperty("priority")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_role_arn")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ServiceRoleArn { get; set; }

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskArn is required")]
    [TerraformProperty("task_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskArn { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformProperty("task_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TaskType { get; set; }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    [TerraformProperty("window_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WindowId { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformProperty("targets")]
    public partial TerraformList<TerraformBlock<AwsSsmMaintenanceWindowTaskTargetsBlock>>? Targets { get; set; }

    /// <summary>
    /// Block for task_invocation_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskInvocationParameters block(s) allowed")]
    [TerraformProperty("task_invocation_parameters")]
    public partial TerraformList<TerraformBlock<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>>? TaskInvocationParameters { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The window_task_id attribute.
    /// </summary>
    [TerraformProperty("window_task_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WindowTaskId { get; }

}
