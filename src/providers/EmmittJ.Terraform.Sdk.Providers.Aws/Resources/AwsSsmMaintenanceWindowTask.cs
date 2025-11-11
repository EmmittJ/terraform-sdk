using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for targets in .
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTargetsBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformPropertyName("values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Block type for task_invocation_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock
{
}

/// <summary>
/// Manages a aws_ssm_maintenance_window_task resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmMaintenanceWindowTask : TerraformResource
{
    public AwsSsmMaintenanceWindowTask(string name) : base("aws_ssm_maintenance_window_task", name)
    {
    }

    /// <summary>
    /// The cutoff_behavior attribute.
    /// </summary>
    [TerraformPropertyName("cutoff_behavior")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CutoffBehavior { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxConcurrency { get; set; } = default!;

    /// <summary>
    /// The max_errors attribute.
    /// </summary>
    [TerraformPropertyName("max_errors")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> MaxErrors { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [TerraformPropertyName("priority")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? Priority { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_role_arn")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ServiceRoleArn { get; set; } = default!;

    /// <summary>
    /// The task_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskArn is required")]
    [TerraformPropertyName("task_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskArn { get; set; }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    [TerraformPropertyName("task_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TaskType { get; set; }

    /// <summary>
    /// The window_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WindowId is required")]
    [TerraformPropertyName("window_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WindowId { get; set; }

    /// <summary>
    /// Block for targets.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(5, ErrorMessage = "Maximum 5 Targets block(s) allowed")]
    [TerraformPropertyName("targets")]
    public TerraformList<TerraformBlock<AwsSsmMaintenanceWindowTaskTargetsBlock>>? Targets { get; set; }

    /// <summary>
    /// Block for task_invocation_parameters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TaskInvocationParameters block(s) allowed")]
    [TerraformPropertyName("task_invocation_parameters")]
    public TerraformList<TerraformBlock<AwsSsmMaintenanceWindowTaskTaskInvocationParametersBlock>>? TaskInvocationParameters { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The window_task_id attribute.
    /// </summary>
    [TerraformPropertyName("window_task_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WindowTaskId => new TerraformReference(this, "window_task_id");

}
