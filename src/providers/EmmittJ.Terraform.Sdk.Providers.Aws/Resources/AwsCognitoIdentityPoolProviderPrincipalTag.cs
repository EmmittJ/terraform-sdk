using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_identity_pool_provider_principal_tag Terraform resource.
/// Manages a aws_cognito_identity_pool_provider_principal_tag resource.
/// </summary>
public partial class AwsCognitoIdentityPoolProviderPrincipalTag(string name) : TerraformResource("aws_cognito_identity_pool_provider_principal_tag", name)
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
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    public required TerraformValue<string> IdentityProviderName
    {
        get => new TerraformReference<string>(this, "identity_provider_name");
        set => SetArgument("identity_provider_name", value);
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public TerraformMap<string>? PrincipalTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "principal_tags").ResolveNodes(ctx));
        set => SetArgument("principal_tags", value);
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
    /// The use_defaults attribute.
    /// </summary>
    public TerraformValue<bool>? UseDefaults
    {
        get => new TerraformReference<bool>(this, "use_defaults");
        set => SetArgument("use_defaults", value);
    }

}
