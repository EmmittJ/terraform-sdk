using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_acmpca_permission resource.
/// </summary>
public partial class AwsAcmpcaPermission : TerraformResource
{
    public AwsAcmpcaPermission(string name) : base("aws_acmpca_permission", name)
    {
    }

    /// <summary>
    /// The actions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [TerraformProperty("actions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> Actions { get; set; }

    /// <summary>
    /// The certificate_authority_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateAuthorityArn is required")]
    [TerraformProperty("certificate_authority_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> CertificateAuthorityArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    [TerraformProperty("principal")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Principal { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The source_account attribute.
    /// </summary>
    [TerraformProperty("source_account")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SourceAccount { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Policy { get; }

}
