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
        get => GetArgument<TerraformValue<string>>("authorizer_function_arn");
        set => SetArgument("authorizer_function_arn", value);
    }

    /// <summary>
    /// The enable_caching_for_http attribute.
    /// </summary>
    public TerraformValue<bool>? EnableCachingForHttp
    {
        get => GetArgument<TerraformValue<bool>>("enable_caching_for_http");
        set => SetArgument("enable_caching_for_http", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The signing_disabled attribute.
    /// </summary>
    public TerraformValue<bool>? SigningDisabled
    {
        get => GetArgument<TerraformValue<bool>>("signing_disabled");
        set => SetArgument("signing_disabled", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The token_key_name attribute.
    /// </summary>
    public TerraformValue<string>? TokenKeyName
    {
        get => GetArgument<TerraformValue<string>>("token_key_name");
        set => SetArgument("token_key_name", value);
    }

    /// <summary>
    /// The token_signing_public_keys attribute.
    /// </summary>
    public TerraformMap<string>? TokenSigningPublicKeys
    {
        get => GetArgument<TerraformMap<string>>("token_signing_public_keys");
        set => SetArgument("token_signing_public_keys", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
