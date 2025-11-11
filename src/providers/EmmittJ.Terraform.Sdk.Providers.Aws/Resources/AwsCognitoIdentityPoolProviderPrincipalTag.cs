using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_identity_pool_provider_principal_tag resource.
/// </summary>
public partial class AwsCognitoIdentityPoolProviderPrincipalTag : TerraformResource
{
    public AwsCognitoIdentityPoolProviderPrincipalTag(string name) : base("aws_cognito_identity_pool_provider_principal_tag", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformProperty("identity_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityPoolId { get; set; }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    [TerraformProperty("identity_provider_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityProviderName { get; set; }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    [TerraformProperty("principal_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? PrincipalTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The use_defaults attribute.
    /// </summary>
    [TerraformProperty("use_defaults")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? UseDefaults { get; set; }

}
