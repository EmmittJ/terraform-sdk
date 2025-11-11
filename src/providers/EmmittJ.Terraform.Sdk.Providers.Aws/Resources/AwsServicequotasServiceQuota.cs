using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_service_quota resource.
/// </summary>
public class AwsServicequotasServiceQuota : TerraformResource
{
    public AwsServicequotasServiceQuota(string name) : base("aws_servicequotas_service_quota", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    [TerraformPropertyName("quota_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> QuotaCode { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    [TerraformPropertyName("service_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServiceCode { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Value { get; set; }

    /// <summary>
    /// The adjustable attribute.
    /// </summary>
    [TerraformPropertyName("adjustable")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> Adjustable => new TerraformReference(this, "adjustable");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformPropertyName("default_value")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> DefaultValue => new TerraformReference(this, "default_value");

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> QuotaName => new TerraformReference(this, "quota_name");

    /// <summary>
    /// The request_id attribute.
    /// </summary>
    [TerraformPropertyName("request_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RequestId => new TerraformReference(this, "request_id");

    /// <summary>
    /// The request_status attribute.
    /// </summary>
    [TerraformPropertyName("request_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> RequestStatus => new TerraformReference(this, "request_status");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceName => new TerraformReference(this, "service_name");

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    [TerraformPropertyName("usage_metric")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UsageMetric => new TerraformReference(this, "usage_metric");

}
