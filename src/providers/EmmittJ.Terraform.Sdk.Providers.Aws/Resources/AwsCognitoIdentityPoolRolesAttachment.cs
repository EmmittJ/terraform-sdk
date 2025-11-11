using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for role_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock
{
    /// <summary>
    /// The ambiguous_role_resolution attribute.
    /// </summary>
    [TerraformPropertyName("ambiguous_role_resolution")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? AmbiguousRoleResolution { get; set; }

    /// <summary>
    /// The identity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProvider is required")]
    [TerraformPropertyName("identity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdentityProvider { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachment : TerraformResource
{
    public AwsCognitoIdentityPoolRolesAttachment(string name) : base("aws_cognito_identity_pool_roles_attachment", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformPropertyName("identity_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdentityPoolId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [TerraformPropertyName("roles")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformMap<string> Roles { get; set; }

    /// <summary>
    /// Block for role_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("role_mapping")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>>? RoleMapping { get; set; }

}
