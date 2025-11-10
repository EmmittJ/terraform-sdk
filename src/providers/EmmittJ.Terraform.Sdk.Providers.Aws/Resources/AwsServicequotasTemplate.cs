using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_servicequotas_template resource.
/// </summary>
public class AwsServicequotasTemplate : TerraformResource
{
    public AwsServicequotasTemplate(string name) : base("aws_servicequotas_template", name)
    {
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    [TerraformPropertyName("aws_region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsRegion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_region");

    /// <summary>
    /// The quota_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaCode is required")]
    [TerraformPropertyName("quota_code")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> QuotaCode { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
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
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Value { get; set; }

    /// <summary>
    /// The global_quota attribute.
    /// </summary>
    [TerraformPropertyName("global_quota")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> GlobalQuota => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "global_quota");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The quota_name attribute.
    /// </summary>
    [TerraformPropertyName("quota_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> QuotaName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_name");

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [TerraformPropertyName("service_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_name");

    /// <summary>
    /// The unit attribute.
    /// </summary>
    [TerraformPropertyName("unit")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Unit => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "unit");

}
