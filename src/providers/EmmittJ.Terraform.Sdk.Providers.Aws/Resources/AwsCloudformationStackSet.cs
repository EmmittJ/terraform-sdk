using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_deployment in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetAutoDeploymentBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The retain_stacks_on_account_removal attribute.
    /// </summary>
    [TerraformPropertyName("retain_stacks_on_account_removal")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RetainStacksOnAccountRemoval { get; set; }

}

/// <summary>
/// Block type for managed_execution in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetManagedExecutionBlock : ITerraformBlock
{
    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Active { get; set; }

}

/// <summary>
/// Block type for operation_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationStackSetOperationPreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrent_count attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentCount { get; set; }

    /// <summary>
    /// The max_concurrent_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrent_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrentPercentage { get; set; }

    /// <summary>
    /// The region_concurrency_type attribute.
    /// </summary>
    [TerraformPropertyName("region_concurrency_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? RegionConcurrencyType { get; set; }

    /// <summary>
    /// The region_order attribute.
    /// </summary>
    [TerraformPropertyName("region_order")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? RegionOrder { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudformationStackSetTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudformation_stack_set resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationStackSet : TerraformResource
{
    public AwsCloudformationStackSet(string name) : base("aws_cloudformation_stack_set", name)
    {
    }

    /// <summary>
    /// The administration_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("administration_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AdministrationRoleArn { get; set; }

    /// <summary>
    /// The call_as attribute.
    /// </summary>
    [TerraformPropertyName("call_as")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CallAs { get; set; }

    /// <summary>
    /// The capabilities attribute.
    /// </summary>
    [TerraformPropertyName("capabilities")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Capabilities { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The execution_role_name attribute.
    /// </summary>
    [TerraformPropertyName("execution_role_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ExecutionRoleName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "execution_role_name");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    [TerraformPropertyName("parameters")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Parameters { get; set; }

    /// <summary>
    /// The permission_model attribute.
    /// </summary>
    [TerraformPropertyName("permission_model")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PermissionModel { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    [TerraformPropertyName("template_body")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TemplateBody { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "template_body");

    /// <summary>
    /// The template_url attribute.
    /// </summary>
    [TerraformPropertyName("template_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemplateUrl { get; set; }

    /// <summary>
    /// Block for auto_deployment.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoDeployment block(s) allowed")]
    [TerraformPropertyName("auto_deployment")]
    public TerraformList<TerraformBlock<AwsCloudformationStackSetAutoDeploymentBlock>>? AutoDeployment { get; set; } = new();

    /// <summary>
    /// Block for managed_execution.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ManagedExecution block(s) allowed")]
    [TerraformPropertyName("managed_execution")]
    public TerraformList<TerraformBlock<AwsCloudformationStackSetManagedExecutionBlock>>? ManagedExecution { get; set; } = new();

    /// <summary>
    /// Block for operation_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OperationPreferences block(s) allowed")]
    [TerraformPropertyName("operation_preferences")]
    public TerraformList<TerraformBlock<AwsCloudformationStackSetOperationPreferencesBlock>>? OperationPreferences { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudformationStackSetTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The stack_set_id attribute.
    /// </summary>
    [TerraformPropertyName("stack_set_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StackSetId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "stack_set_id");

}
