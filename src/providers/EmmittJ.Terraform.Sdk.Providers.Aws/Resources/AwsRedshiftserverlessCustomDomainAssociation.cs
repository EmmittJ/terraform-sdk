using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshiftserverless_custom_domain_association resource.
/// </summary>
public class AwsRedshiftserverlessCustomDomainAssociation : TerraformResource
{
    public AwsRedshiftserverlessCustomDomainAssociation(string name) : base("aws_redshiftserverless_custom_domain_association", name)
    {
    }

    /// <summary>
    /// The custom_domain_certificate_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainCertificateArn is required")]
    [TerraformPropertyName("custom_domain_certificate_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomDomainCertificateArn { get; set; }

    /// <summary>
    /// The custom_domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomDomainName is required")]
    [TerraformPropertyName("custom_domain_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> CustomDomainName { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformPropertyName("workgroup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The custom_domain_certificate_expiry_time attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain_certificate_expiry_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomainCertificateExpiryTime => new TerraformReference(this, "custom_domain_certificate_expiry_time");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}
