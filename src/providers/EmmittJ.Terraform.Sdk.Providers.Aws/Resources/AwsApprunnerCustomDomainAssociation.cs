using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_custom_domain_association resource.
/// </summary>
public partial class AwsApprunnerCustomDomainAssociation : TerraformResource
{
    public AwsApprunnerCustomDomainAssociation(string name) : base("aws_apprunner_custom_domain_association", name)
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
    /// The enable_www_subdomain attribute.
    /// </summary>
    [TerraformProperty("enable_www_subdomain")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? EnableWwwSubdomain { get; set; }

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
    /// The service_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceArn is required")]
    [TerraformProperty("service_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceArn { get; set; }

    /// <summary>
    /// The certificate_validation_records attribute.
    /// </summary>
    [TerraformProperty("certificate_validation_records")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> CertificateValidationRecords { get; }

    /// <summary>
    /// The dns_target attribute.
    /// </summary>
    [TerraformProperty("dns_target")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DnsTarget { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

}
