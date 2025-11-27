using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for role_mapping in AwsCognitoIdentityPoolRolesAttachment.
/// Nesting mode: set
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "role_mapping";

    /// <summary>
    /// The ambiguous_role_resolution attribute.
    /// </summary>
    public TerraformValue<string>? AmbiguousRoleResolution
    {
        get => new TerraformReference<string>(this, "ambiguous_role_resolution");
        set => SetArgument("ambiguous_role_resolution", value);
    }

    /// <summary>
    /// The identity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProvider is required")]
    public required TerraformValue<string> IdentityProvider
    {
        get => new TerraformReference<string>(this, "identity_provider");
        set => SetArgument("identity_provider", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// MappingRule block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 MappingRule block(s) allowed")]
    public TerraformList<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlockMappingRuleBlock>? MappingRule
    {
        get => GetArgument<TerraformList<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlockMappingRuleBlock>>("mapping_rule");
        set => SetArgument("mapping_rule", value);
    }

}

/// <summary>
/// Block type for mapping_rule in AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlockMappingRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mapping_rule";

    /// <summary>
    /// The claim attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Claim is required")]
    public required TerraformValue<string> Claim
    {
        get => new TerraformReference<string>(this, "claim");
        set => SetArgument("claim", value);
    }

    /// <summary>
    /// The match_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchType is required")]
    public required TerraformValue<string> MatchType
    {
        get => new TerraformReference<string>(this, "match_type");
        set => SetArgument("match_type", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_cognito_identity_pool_roles_attachment Terraform resource.
/// Manages a aws_cognito_identity_pool_roles_attachment resource.
/// </summary>
public partial class AwsCognitoIdentityPoolRolesAttachment(string name) : TerraformResource("aws_cognito_identity_pool_roles_attachment", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformValue<string> IdentityPoolId
    {
        get => new TerraformReference<string>(this, "identity_pool_id");
        set => SetArgument("identity_pool_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The roles attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Roles is required")]
    public required TerraformMap<string> Roles
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "roles").ResolveNodes(ctx));
        set => SetArgument("roles", value);
    }

    /// <summary>
    /// RoleMapping block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>? RoleMapping
    {
        get => GetArgument<TerraformSet<AwsCognitoIdentityPoolRolesAttachmentRoleMappingBlock>>("role_mapping");
        set => SetArgument("role_mapping", value);
    }

}
