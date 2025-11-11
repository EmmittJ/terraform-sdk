using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_deployment in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackSetAutoDeploymentBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The retain_stacks_on_account_removal attribute.
    /// </summary>
    [TerraformProperty("retain_stacks_on_account_removal")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetainStacksOnAccountRemoval { get; set; }

}

/// <summary>
/// Block type for managed_execution in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackSetManagedExecutionBlock : TerraformBlockBase
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformProperty("active")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Active { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudformationStackSetOperationPreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformProperty("failure_tolerance_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformProperty("max_concurrent_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformProperty("region_concurrency_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformProperty("region_order")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudformationStackSetTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCloudformationStackSet : TerraformResource
{
    public AwsCloudformationStackSet(string name) : base("aws_cloudformation_stack_set", name)
    {
    }

    /// <summary>
    /// The administration_role_arn attribute.
    /// </summary>
    [TerraformProperty("administration_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AdministrationRoleArn { get; set; }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformProperty("call_as")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CallAs { get; set; }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformProperty("capabilities")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Capabilities { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    [TerraformProperty("execution_role_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ExecutionRoleName { get; set; }

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
    /// The parameters attribute.
    /// </summary>
    [TerraformProperty("parameters")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Parameters { get; set; }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    [TerraformProperty("permission_model")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PermissionModel { get; set; }

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
    /// The template_body attribute.
    /// </summary>
    [TerraformProperty("template_body")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TemplateBody { get; set; }

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformProperty("template_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TemplateUrl { get; set; }

    /// <summary>
    /// Block for auto_deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoDeployment block(s) allowed")]
    [TerraformProperty("auto_deployment")]
    public partial TerraformList<TerraformBlock<AwsCloudformationStackSetAutoDeploymentBlock>>? AutoDeployment { get; set; }

    /// <summary>
    /// Block for managed_execution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedExecution block(s) allowed")]
    [TerraformProperty("managed_execution")]
    public partial TerraformList<TerraformBlock<AwsCloudformationStackSetManagedExecutionBlock>>? ManagedExecution { get; set; }

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformProperty("operation_preferences")]
    public partial TerraformList<TerraformBlock<AwsCloudformationStackSetOperationPreferencesBlock>>? OperationPreferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsCloudformationStackSetTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    [TerraformProperty("stack_set_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StackSetId { get; }

}
