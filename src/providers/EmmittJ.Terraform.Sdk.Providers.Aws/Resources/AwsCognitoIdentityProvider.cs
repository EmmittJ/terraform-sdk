using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_identity_provider Terraform resource.
/// Manages a aws_cognito_identity_provider resource.
/// </summary>
public partial class AwsCognitoIdentityProvider(string name) : TerraformResource("aws_cognito_identity_provider", name)
{
    /// <summary>
    /// The attribute_mapping attribute.
    /// </summary>
    public TerraformMap<string> AttributeMapping
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "attribute_mapping").ResolveNodes(ctx));
        set => SetArgument("attribute_mapping", value);
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
    /// The idp_identifiers attribute.
    /// </summary>
    public TerraformList<string>? IdpIdentifiers
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "idp_identifiers").ResolveNodes(ctx));
        set => SetArgument("idp_identifiers", value);
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderDetails is required")]
    public required TerraformMap<string> ProviderDetails
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "provider_details").ResolveNodes(ctx));
        set => SetArgument("provider_details", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    public required TerraformValue<string> ProviderType
    {
        get => new TerraformReference<string>(this, "provider_type");
        set => SetArgument("provider_type", value);
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}
