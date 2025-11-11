using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductProvisioningParametersBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    [TerraformPropertyName("use_previous_value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UsePreviousValue { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for stack_set_provisioning_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Accounts { get; set; }

    /// <summary>
    /// The failure_tolerance_count attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FailureToleranceCount { get; set; }

    /// <summary>
    /// The failure_tolerance_percentage attribute.
    /// </summary>
    [TerraformPropertyName("failure_tolerance_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? FailureTolerancePercentage { get; set; }

    /// <summary>
    /// The max_concurrency_count attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency_count")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrencyCount { get; set; }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MaxConcurrencyPercentage { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? Regions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisionedProductTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_provisioned_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsServicecatalogProvisionedProduct : TerraformResource
{
    public AwsServicecatalogProvisionedProduct(string name) : base("aws_servicecatalog_provisioned_product", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformPropertyName("accept_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    [TerraformPropertyName("ignore_errors")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnoreErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformPropertyName("notification_arns")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? NotificationArns { get; set; }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    [TerraformPropertyName("path_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PathId { get; set; } = default!;

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    [TerraformPropertyName("path_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PathName { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProductId { get; set; } = default!;

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformPropertyName("product_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProductName { get; set; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_artifact_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ProvisioningArtifactId { get; set; } = default!;

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_artifact_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProvisioningArtifactName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    [TerraformPropertyName("retain_physical_resources")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RetainPhysicalResources { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for provisioning_parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("provisioning_parameters")]
    public TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductProvisioningParametersBlock>>? ProvisioningParameters { get; set; }

    /// <summary>
    /// Block for stack_set_provisioning_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    [TerraformPropertyName("stack_set_provisioning_preferences")]
    public TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>>? StackSetProvisioningPreferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsServicecatalogProvisionedProductTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_dashboard_names")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> CloudwatchDashboardNames => new TerraformReference(this, "cloudwatch_dashboard_names");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedTime => new TerraformReference(this, "created_time");

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_provisioning_record_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastProvisioningRecordId => new TerraformReference(this, "last_provisioning_record_id");

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_record_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastRecordId => new TerraformReference(this, "last_record_id");

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_successful_provisioning_record_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastSuccessfulProvisioningRecordId => new TerraformReference(this, "last_successful_provisioning_record_id");

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("launch_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LaunchRoleArn => new TerraformReference(this, "launch_role_arn");

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformPropertyName("outputs")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> Outputs => new TerraformReference(this, "outputs");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StatusMessage => new TerraformReference(this, "status_message");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Type => new TerraformReference(this, "type");

}
