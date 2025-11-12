using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_attributes in .
/// Nesting mode: list
/// </summary>
public partial class AwsPaymentcryptographyKeyKeyAttributesBlock() : TerraformBlock("key_attributes")
{
    /// <summary>
    /// The key_algorithm attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyAlgorithm is required")]
    [TerraformProperty("key_algorithm")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyAlgorithm { get; set; }

    /// <summary>
    /// The key_class attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyClass is required")]
    [TerraformProperty("key_class")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyClass { get; set; }

    /// <summary>
    /// The key_usage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyUsage is required")]
    [TerraformProperty("key_usage")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyUsage { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsPaymentcryptographyKeyTimeoutsBlock() : TerraformBlock("timeouts")
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

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_paymentcryptography_key resource.
/// </summary>
public partial class AwsPaymentcryptographyKey : TerraformResource
{
    public AwsPaymentcryptographyKey(string name) : base("aws_paymentcryptography_key", name)
    {
    }

    /// <summary>
    /// The deletion_window_in_days attribute.
    /// </summary>
    [TerraformProperty("deletion_window_in_days")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> DeletionWindowInDays { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The exportable attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Exportable is required")]
    [TerraformProperty("exportable")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Exportable { get; set; }

    /// <summary>
    /// The key_check_value_algorithm attribute.
    /// </summary>
    [TerraformProperty("key_check_value_algorithm")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> KeyCheckValueAlgorithm { get; set; }

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
    /// Block for key_attributes.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("key_attributes")]
    public TerraformList<AwsPaymentcryptographyKeyKeyAttributesBlock> KeyAttributes { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsPaymentcryptographyKeyTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The key_check_value attribute.
    /// </summary>
    [TerraformProperty("key_check_value")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyCheckValue { get; }

    /// <summary>
    /// The key_origin attribute.
    /// </summary>
    [TerraformProperty("key_origin")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyOrigin { get; }

    /// <summary>
    /// The key_state attribute.
    /// </summary>
    [TerraformProperty("key_state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> KeyState { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
