using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for single_sign_on in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatazoneDomainSingleSignOnBlock() : TerraformBlock("single_sign_on")
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The user_assignment attribute.
    /// </summary>
    [TerraformProperty("user_assignment")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignment { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneDomainTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_datazone_domain resource.
/// </summary>
public partial class AwsDatazoneDomain : TerraformResource
{
    public AwsDatazoneDomain(string name) : base("aws_datazone_domain", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_execution_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainExecutionRole is required")]
    [TerraformProperty("domain_execution_role")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainExecutionRole { get; set; }

    /// <summary>
    /// The domain_version attribute.
    /// </summary>
    [TerraformProperty("domain_version")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainVersion { get; set; }

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformProperty("kms_key_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [TerraformProperty("service_role")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceRole { get; set; }

    /// <summary>
    /// The skip_deletion_check attribute.
    /// </summary>
    [TerraformProperty("skip_deletion_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDeletionCheck { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for single_sign_on.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("single_sign_on")]
    public TerraformList<AwsDatazoneDomainSingleSignOnBlock> SingleSignOn { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDatazoneDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The portal_url attribute.
    /// </summary>
    [TerraformProperty("portal_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PortalUrl { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
