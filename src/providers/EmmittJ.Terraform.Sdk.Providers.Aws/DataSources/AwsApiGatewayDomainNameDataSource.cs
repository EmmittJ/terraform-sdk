using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_domain_name.
/// </summary>
public partial class AwsApiGatewayDomainNameDataSource : TerraformDataSource
{
    public AwsApiGatewayDomainNameDataSource(string name) : base("aws_api_gateway_domain_name", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    [TerraformProperty("domain_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The domain_name_id attribute.
    /// </summary>
    [TerraformProperty("domain_name_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> DomainNameId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    [TerraformProperty("certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateArn { get; }

    /// <summary>
    /// The certificate_name attribute.
    /// </summary>
    [TerraformProperty("certificate_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateName { get; }

    /// <summary>
    /// The certificate_upload_date attribute.
    /// </summary>
    [TerraformProperty("certificate_upload_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CertificateUploadDate { get; }

    /// <summary>
    /// The cloudfront_domain_name attribute.
    /// </summary>
    [TerraformProperty("cloudfront_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudfrontDomainName { get; }

    /// <summary>
    /// The cloudfront_zone_id attribute.
    /// </summary>
    [TerraformProperty("cloudfront_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CloudfrontZoneId { get; }

    /// <summary>
    /// The endpoint_configuration attribute.
    /// </summary>
    [TerraformProperty("endpoint_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EndpointConfiguration { get; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Policy { get; }

    /// <summary>
    /// The regional_certificate_arn attribute.
    /// </summary>
    [TerraformProperty("regional_certificate_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegionalCertificateArn { get; }

    /// <summary>
    /// The regional_certificate_name attribute.
    /// </summary>
    [TerraformProperty("regional_certificate_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegionalCertificateName { get; }

    /// <summary>
    /// The regional_domain_name attribute.
    /// </summary>
    [TerraformProperty("regional_domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegionalDomainName { get; }

    /// <summary>
    /// The regional_zone_id attribute.
    /// </summary>
    [TerraformProperty("regional_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> RegionalZoneId { get; }

    /// <summary>
    /// The security_policy attribute.
    /// </summary>
    [TerraformProperty("security_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecurityPolicy { get; }

}
