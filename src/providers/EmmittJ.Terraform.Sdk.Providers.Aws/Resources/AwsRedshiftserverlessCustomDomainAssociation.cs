using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_custom_domain_association resource.
/// </summary>
public partial class AwsRedshiftserverlessCustomDomainAssociation : TerraformResource
{
    public AwsRedshiftserverlessCustomDomainAssociation(string name) : base("aws_redshiftserverless_custom_domain_association", name)
    {
    }

    /// <summary>
    /// The custom_domain_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainCertificateArn is required")]
    [TerraformProperty("custom_domain_certificate_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomDomainCertificateArn { get; set; }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainName is required")]
    [TerraformProperty("custom_domain_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CustomDomainName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformProperty("workgroup_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The custom_domain_certificate_expiry_time attribute.
    /// </summary>
    [TerraformProperty("custom_domain_certificate_expiry_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CustomDomainCertificateExpiryTime { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
