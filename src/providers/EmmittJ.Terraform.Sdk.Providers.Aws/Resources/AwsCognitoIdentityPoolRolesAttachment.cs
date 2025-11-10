using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for role_mapping in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock : TerraformBlock
{
    /// <summary>
    /// The ambiguous_role_resolution attribute.
    /// </summary>
    public TerraformProperty<string>? AmbiguousRoleResolution
    {
        set => SetProperty("ambiguous_role_resolution", value);
    }

    /// <summary>
    /// The identity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProvider is required")]
    public required TerraformProperty<string> IdentityProvider
    {
        set => SetProperty("identity_provider", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachment : TerraformResource
{
    public AwsCognitoIdentityPoolRolesAttachment(string name) : base("aws_cognito_identity_pool_roles_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("identity_pool_id");
        SetOutput("region");
        SetOutput("roles");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformProperty<string> IdentityPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_pool_id");
        set => SetProperty("identity_pool_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    public Dictionary<string, TerraformProperty<string>> Roles
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("roles");
        set => SetProperty("roles", value);
    }

    /// <summary>
    /// Block for role_mapping.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>? RoleMapping
    {
        set => SetProperty("role_mapping", value);
    }

}
