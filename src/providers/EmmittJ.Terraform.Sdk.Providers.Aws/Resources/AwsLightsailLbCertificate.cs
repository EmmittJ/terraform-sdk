using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lightsail_lb_certificate resource.
/// </summary>
public partial class AwsLightsailLbCertificate : TerraformResource
{
    public AwsLightsailLbCertificate(string name) : base("aws_lightsail_lb_certificate", name)
    {
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DomainName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The lb_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LbName is required")]
    [TerraformProperty("lb_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LbName { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The subject_alternative_names attribute.
    /// </summary>
    [TerraformProperty("subject_alternative_names")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubjectAlternativeNames { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The domain_validation_records attribute.
    /// </summary>
    [TerraformProperty("domain_validation_records")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> DomainValidationRecords { get; }

    /// <summary>
    /// The support_code attribute.
    /// </summary>
    [TerraformProperty("support_code")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SupportCode { get; }

}
