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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [TerraformPropertyName("quota_code")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> QuotaCode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_code");

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> QuotaName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_name");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    [TerraformPropertyName("service_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceCode { get; set; }

    /// <summary>
    /// The adjustable attribute.
    /// </summary>
    [TerraformPropertyName("adjustable")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Adjustable => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "adjustable");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The default_value attribute.
    /// </summary>
    [TerraformPropertyName("default_value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> DefaultValue => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "default_value");

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    [TerraformPropertyName("global_quota")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> GlobalQuota => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "global_quota");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_name");

    /// <summary>
    /// The usage_metric attribute.
    /// </summary>
    [TerraformPropertyName("usage_metric")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UsageMetric => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "usage_metric");

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Value => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "value");

}
