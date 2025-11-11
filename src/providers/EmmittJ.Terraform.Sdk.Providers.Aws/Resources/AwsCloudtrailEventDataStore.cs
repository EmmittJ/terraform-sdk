using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for advanced_event_selector in .
/// Nesting mode: list
/// </summary>
public partial class AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsCloudtrailEventDataStoreTimeoutsBlock : TerraformBlockBase
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
/// Manages a aws_cloudtrail_event_data_store resource.
/// </summary>
public partial class AwsCloudtrailEventDataStore : TerraformResource
{
    public AwsCloudtrailEventDataStore(string name) : base("aws_cloudtrail_event_data_store", name)
    {
    }

    /// <summary>
    /// The billing_mode attribute.
    /// </summary>
    [TerraformProperty("billing_mode")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BillingMode { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The multi_region_enabled attribute.
    /// </summary>
    [TerraformProperty("multi_region_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? MultiRegionEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The organization_enabled attribute.
    /// </summary>
    [TerraformProperty("organization_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? OrganizationEnabled { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The retention_period attribute.
    /// </summary>
    [TerraformProperty("retention_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RetentionPeriod { get; set; }

    /// <summary>
    /// The suspend attribute.
    /// </summary>
    [TerraformProperty("suspend")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Suspend { get; set; }

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
    /// The termination_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("termination_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? TerminationProtectionEnabled { get; set; }

    /// <summary>
    /// Block for advanced_event_selector.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("advanced_event_selector")]
    public partial TerraformList<TerraformBlock<AwsCloudtrailEventDataStoreAdvancedEventSelectorBlock>>? AdvancedEventSelector { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsCloudtrailEventDataStoreTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}
