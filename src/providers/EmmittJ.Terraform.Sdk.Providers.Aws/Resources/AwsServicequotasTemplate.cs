using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_template resource.
/// </summary>
public partial class AwsServicequotasTemplate : TerraformResource
{
    public AwsServicequotasTemplate(string name) : base("aws_servicequotas_template", name)
    {
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformProperty("aws_region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AwsRegion { get; set; }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    [TerraformProperty("quota_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> QuotaCode { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    [TerraformProperty("service_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceCode { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Value { get; set; }

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    [TerraformProperty("global_quota")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> GlobalQuota { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformProperty("quota_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QuotaName { get; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceName { get; }

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformProperty("unit")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Unit { get; }

}
