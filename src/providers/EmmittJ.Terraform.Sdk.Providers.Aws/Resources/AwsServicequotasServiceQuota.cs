using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_service_quota resource.
/// </summary>
public partial class AwsServicequotasServiceQuota : TerraformResource
{
    public AwsServicequotasServiceQuota(string name) : base("aws_servicequotas_service_quota", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    [TerraformProperty("quota_code")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> QuotaCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
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
    /// The adjustable attribute.
    /// </summary>
    [TerraformProperty("adjustable")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Adjustable { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformProperty("default_value")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> DefaultValue { get; }

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformProperty("quota_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> QuotaName { get; }

    /// <summary>
    /// The request_id attribute.
    /// </summary>
    [TerraformProperty("request_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RequestId { get; }

    /// <summary>
    /// The request_status attribute.
    /// </summary>
    [TerraformProperty("request_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RequestStatus { get; }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformProperty("service_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceName { get; }

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    [TerraformProperty("usage_metric")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UsageMetric { get; }

}
