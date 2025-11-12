using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for certificate in .
/// Nesting mode: set
/// </summary>
public partial class AwsWorkspaceswebTrustStoreCertificateBlock() : TerraformBlock("certificate")
{
    /// <summary>
    /// The body attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Body is required")]
    [TerraformProperty("body")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Body { get; set; }






}

/// <summary>
/// Manages a aws_workspacesweb_trust_store resource.
/// </summary>
public partial class AwsWorkspaceswebTrustStore : TerraformResource
{
    public AwsWorkspaceswebTrustStore(string name) : base("aws_workspacesweb_trust_store", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for certificate.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("certificate")]
    public TerraformSet<AwsWorkspaceswebTrustStoreCertificateBlock> Certificate { get; set; } = new();

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    [TerraformProperty("associated_portal_arns")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> AssociatedPortalArns { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [TerraformProperty("trust_store_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrustStoreArn { get; }

}
