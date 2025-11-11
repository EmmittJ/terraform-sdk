using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for role_mapping in .
/// Nesting mode: set
/// </summary>
public partial class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock : TerraformBlockBase
{
    /// <summary>
    /// The ambiguous_role_resolution attribute.
    /// </summary>
    [TerraformProperty("ambiguous_role_resolution")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? AmbiguousRoleResolution { get; set; }

    /// <summary>
    /// The identity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProvider is required")]
    [TerraformProperty("identity_provider")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityProvider { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public partial class AwsCognitoIdentityPoolRolesAttachment : TerraformResource
{
    public AwsCognitoIdentityPoolRolesAttachment(string name) : base("aws_cognito_identity_pool_roles_attachment", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [TerraformProperty("roles")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Roles { get; set; }

    /// <summary>
    /// Block for role_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("role_mapping")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>>? RoleMapping { get; set; }

}
