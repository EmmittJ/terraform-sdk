using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_trust_store_association resource.
/// </summary>
public partial class AwsWorkspaceswebTrustStoreAssociation : TerraformResource
{
    public AwsWorkspaceswebTrustStoreAssociation(string name) : base("aws_workspacesweb_trust_store_association", name)
    {
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortalArn is required")]
    [TerraformProperty("portal_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PortalArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The trust_store_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrustStoreArn is required")]
    [TerraformProperty("trust_store_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TrustStoreArn { get; set; }

}
