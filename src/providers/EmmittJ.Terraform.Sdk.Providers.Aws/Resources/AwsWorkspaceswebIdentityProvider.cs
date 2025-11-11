using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_identity_provider resource.
/// </summary>
public partial class AwsWorkspaceswebIdentityProvider : TerraformResource
{
    public AwsWorkspaceswebIdentityProvider(string name) : base("aws_workspacesweb_identity_provider", name)
    {
    }

    /// <summary>
    /// The identity_provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderDetails is required")]
    [TerraformProperty("identity_provider_details")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> IdentityProviderDetails { get; set; }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    [TerraformProperty("identity_provider_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityProviderName { get; set; }

    /// <summary>
    /// The identity_provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderType is required")]
    [TerraformProperty("identity_provider_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityProviderType { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The identity_provider_arn attribute.
    /// </summary>
    [TerraformProperty("identity_provider_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> IdentityProviderArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

}
