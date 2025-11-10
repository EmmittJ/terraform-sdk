using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for provisioning_parameters in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductProvisioningParametersBlock : ITerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformPropertyName("key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Key { get; set; }

    /// <summary>
    /// The use_previous_value attribute.
    /// </summary>
    [TerraformPropertyName("use_previous_value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? UsePreviousValue { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for stack_set_provisioning_preferences in .
/// Nesting mode: list
/// </summary>
public class AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock : ITerraformBlock
{
    /// <summary>
    /// The accounts attribute.
    /// </summary>
    [TerraformPropertyName("accounts")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Accounts { get; set; }

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
    /// The max_concurrency_count attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency_count")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrencyCount { get; set; }

    /// <summary>
    /// The max_concurrency_percentage attribute.
    /// </summary>
    [TerraformPropertyName("max_concurrency_percentage")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxConcurrencyPercentage { get; set; }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    [TerraformPropertyName("regions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Regions { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogProvisionedProductTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

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
    public TerraformProperty<TerraformProperty<string>>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ignore_errors attribute.
    /// </summary>
    [TerraformPropertyName("ignore_errors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreErrors { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The notification_arns attribute.
    /// </summary>
    [TerraformPropertyName("notification_arns")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? NotificationArns { get; set; }

    /// <summary>
    /// The path_id attribute.
    /// </summary>
    [TerraformPropertyName("path_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> PathId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "path_id");

    /// <summary>
    /// The path_name attribute.
    /// </summary>
    [TerraformPropertyName("path_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PathName { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProductId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "product_id");

    /// <summary>
    /// The product_name attribute.
    /// </summary>
    [TerraformPropertyName("product_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProductName { get; set; }

    /// <summary>
    /// The provisioning_artifact_id attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_artifact_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ProvisioningArtifactId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "provisioning_artifact_id");

    /// <summary>
    /// The provisioning_artifact_name attribute.
    /// </summary>
    [TerraformPropertyName("provisioning_artifact_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProvisioningArtifactName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retain_physical_resources attribute.
    /// </summary>
    [TerraformPropertyName("retain_physical_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RetainPhysicalResources { get; set; }

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
    /// Block for provisioning_parameters.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("provisioning_parameters")]
    public TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductProvisioningParametersBlock>>? ProvisioningParameters { get; set; } = new();

    /// <summary>
    /// Block for stack_set_provisioning_preferences.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StackSetProvisioningPreferences block(s) allowed")]
    [TerraformPropertyName("stack_set_provisioning_preferences")]
    public TerraformList<TerraformBlock<AwsServicecatalogProvisionedProductStackSetProvisioningPreferencesBlock>>? StackSetProvisioningPreferences { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsServicecatalogProvisionedProductTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The cloudwatch_dashboard_names attribute.
    /// </summary>
    [TerraformPropertyName("cloudwatch_dashboard_names")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> CloudwatchDashboardNames => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "cloudwatch_dashboard_names");

    /// <summary>
    /// The created_time attribute.
    /// </summary>
    [TerraformPropertyName("created_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_time");

    /// <summary>
    /// The last_provisioning_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_provisioning_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastProvisioningRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_provisioning_record_id");

    /// <summary>
    /// The last_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_record_id");

    /// <summary>
    /// The last_successful_provisioning_record_id attribute.
    /// </summary>
    [TerraformPropertyName("last_successful_provisioning_record_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastSuccessfulProvisioningRecordId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_successful_provisioning_record_id");

    /// <summary>
    /// The launch_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("launch_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LaunchRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "launch_role_arn");

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformPropertyName("outputs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> Outputs => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "outputs");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The status_message attribute.
    /// </summary>
    [TerraformPropertyName("status_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StatusMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status_message");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
