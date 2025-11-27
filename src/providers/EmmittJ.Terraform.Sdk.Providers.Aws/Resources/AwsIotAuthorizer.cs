using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_iot_authorizer Terraform resource.
/// Manages a aws_iot_authorizer resource.
/// </summary>
public partial class AwsIotAuthorizer(string name) : TerraformResource("aws_iot_authorizer", name)
{
    /// <summary>
    /// The authorizer_function_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthorizerFunctionArn is required")]
    public required TerraformValue<string> AuthorizerFunctionArn
    {
        get => new TerraformReference<string>(this, "authorizer_function_arn");
        set => SetArgument("authorizer_function_arn", value);
    }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    public TerraformValue<bool>? EnableCachingForHttp
    {
        get => new TerraformReference<bool>(this, "enable_caching_for_http");
        set => SetArgument("enable_caching_for_http", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The signing_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? SigningDisabled
    {
        get => new TerraformReference<bool>(this, "signing_disabled");
        set => SetArgument("signing_disabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
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
    /// The token_key_name attribute.
    /// </summary>
    public TerraformValue<string>? TokenKeyName
    {
        get => new TerraformReference<string>(this, "token_key_name");
        set => SetArgument("token_key_name", value);
    }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    public TerraformMap<string>? TokenSigningPublicKeys
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "token_signing_public_keys").ResolveNodes(ctx));
        set => SetArgument("token_signing_public_keys", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

}
