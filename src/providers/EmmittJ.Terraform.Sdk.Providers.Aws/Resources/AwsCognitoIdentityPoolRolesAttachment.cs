using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for role_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock : ITerraformBlock
{
    /// <summary>
    /// The ambiguous_role_resolution attribute.
    /// </summary>
    [TerraformPropertyName("ambiguous_role_resolution")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AmbiguousRoleResolution { get; set; }

    /// <summary>
    /// The identity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProvider is required")]
    [TerraformPropertyName("identity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityProvider { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    [TerraformPropertyName("identity_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityPoolId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    [TerraformPropertyName("roles")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Roles { get; set; }

    /// <summary>
    /// Block for role_mapping.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("role_mapping")]
    public TerraformSet<TerraformBlock<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>>? RoleMapping { get; set; } = new();

}
