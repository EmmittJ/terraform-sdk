using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_parameters in .
/// Nesting mode: list
/// </summary>
public partial class AwsServicecatalogProvisionedProductProvisioningParametersBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    [TerraformProperty("use_previous_value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UsePreviousValue { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for stack_set_provisioning_preferences in .
/// Nesting mode: list
/// </summary>
public partial class AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock : TerraformBlockBase
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformProperty("accounts")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Accounts { get; set; }

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
    /// The max_concurrency_count attribute.
    /// </summary>
    [TerraformProperty("max_concurrency_count")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrencyCount { get; set; }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    [TerraformProperty("max_concurrency_percentage")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxConcurrencyPercentage { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformProperty("regions")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Regions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsServicecatalogProvisionedProductTimeoutsBlock : TerraformBlockBase
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
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_servicecatalog_provisioned_product resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsServicecatalogProvisionedProduct : TerraformResource
{
    public AwsServicecatalogProvisionedProduct(string name) : base("aws_servicecatalog_provisioned_product", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformProperty("accept_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    [TerraformProperty("ignore_errors")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnoreErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformProperty("notification_arns")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? NotificationArns { get; set; }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    [TerraformProperty("path_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> PathId { get; set; }

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    [TerraformProperty("path_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PathName { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformProperty("product_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProductId { get; set; }

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformProperty("product_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProductName { get; set; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformProperty("provisioning_artifact_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ProvisioningArtifactId { get; set; }

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    [TerraformProperty("provisioning_artifact_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProvisioningArtifactName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    [TerraformProperty("retain_physical_resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RetainPhysicalResources { get; set; }

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
    /// Block for provisioning_parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("provisioning_parameters")]
    public partial TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductProvisioningParametersBlock>>? ProvisioningParameters { get; set; }

    /// <summary>
    /// Block for stack_set_provisioning_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    [TerraformProperty("stack_set_provisioning_preferences")]
    public partial TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>>? StackSetProvisioningPreferences { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsServicecatalogProvisionedProductTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    [TerraformProperty("cloudwatch_dashboard_names")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> CloudwatchDashboardNames { get; }

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformProperty("created_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedTime { get; }

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    [TerraformProperty("last_provisioning_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastProvisioningRecordId { get; }

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    [TerraformProperty("last_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastRecordId { get; }

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    [TerraformProperty("last_successful_provisioning_record_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastSuccessfulProvisioningRecordId { get; }

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    [TerraformProperty("launch_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LaunchRoleArn { get; }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformProperty("outputs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> Outputs { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformProperty("status_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StatusMessage { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
