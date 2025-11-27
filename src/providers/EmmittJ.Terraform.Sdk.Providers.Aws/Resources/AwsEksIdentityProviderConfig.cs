using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for oidc in AwsEksIdentityProviderConfig.
/// Nesting mode: list
/// </summary>
public class AwsEksIdentityProviderConfigOidcBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "oidc";

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }

    /// <summary>
    /// The groups_claim attribute.
    /// </summary>
    public TerraformValue<string>? GroupsClaim
    {
        get => new TerraformReference<string>(this, "groups_claim");
        set => SetArgument("groups_claim", value);
    }

    /// <summary>
    /// The groups_prefix attribute.
    /// </summary>
    public TerraformValue<string>? GroupsPrefix
    {
        get => new TerraformReference<string>(this, "groups_prefix");
        set => SetArgument("groups_prefix", value);
    }

    /// <summary>
    /// The identity_provider_config_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderConfigName is required")]
    public required TerraformValue<string> IdentityProviderConfigName
    {
        get => new TerraformReference<string>(this, "identity_provider_config_name");
        set => SetArgument("identity_provider_config_name", value);
    }

    /// <summary>
    /// The issuer_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IssuerUrl is required")]
    public required TerraformValue<string> IssuerUrl
    {
        get => new TerraformReference<string>(this, "issuer_url");
        set => SetArgument("issuer_url", value);
    }

    /// <summary>
    /// The required_claims attribute.
    /// </summary>
    public TerraformMap<string>? RequiredClaims
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "required_claims").ResolveNodes(ctx));
        set => SetArgument("required_claims", value);
    }

    /// <summary>
    /// The username_claim attribute.
    /// </summary>
    public TerraformValue<string>? UsernameClaim
    {
        get => new TerraformReference<string>(this, "username_claim");
        set => SetArgument("username_claim", value);
    }

    /// <summary>
    /// The username_prefix attribute.
    /// </summary>
    public TerraformValue<string>? UsernamePrefix
    {
        get => new TerraformReference<string>(this, "username_prefix");
        set => SetArgument("username_prefix", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEksIdentityProviderConfig.
/// Nesting mode: single
/// </summary>
public class AwsEksIdentityProviderConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_eks_identity_provider_config Terraform resource.
/// Manages a aws_eks_identity_provider_config resource.
/// </summary>
public partial class AwsEksIdentityProviderConfig(string name) : TerraformResource("aws_eks_identity_provider_config", name)
{
    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => new TerraformReference<string>(this, "cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// Oidc block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Oidc is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Oidc block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Oidc block(s) allowed")]
    public required TerraformList<AwsEksIdentityProviderConfigOidcBlock> Oidc
    {
        get => GetRequiredArgument<TerraformList<AwsEksIdentityProviderConfigOidcBlock>>("oidc");
        set => SetArgument("oidc", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEksIdentityProviderConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEksIdentityProviderConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
