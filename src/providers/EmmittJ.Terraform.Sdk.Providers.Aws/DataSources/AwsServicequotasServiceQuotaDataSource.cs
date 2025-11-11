using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_servicequotas_service_quota.
/// </summary>
public class AwsServicequotasServiceQuotaDataSource : TerraformDataSource
{
    public AwsServicequotasServiceQuotaDataSource(string name) : base("aws_servicequotas_service_quota", name)
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
    [TerraformPropertyName("quota_code")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> QuotaCode { get; set; } = default!;

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> QuotaName { get; set; } = default!;

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
    /// The global_quota attribute.
    /// </summary>
    [TerraformPropertyName("global_quota")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> GlobalQuota => new TerraformReference(this, "global_quota");

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

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Value => new TerraformReference(this, "value");

}
