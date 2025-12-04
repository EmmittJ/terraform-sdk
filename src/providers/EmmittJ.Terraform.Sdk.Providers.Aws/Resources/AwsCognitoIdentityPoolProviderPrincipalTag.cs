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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityPoolId is required")]
    public required TerraformValue<string> IdentityPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_pool_id");
        set => SetArgument("identity_pool_id", value);
    }

    /// <summary>
    /// The identity_provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityProviderName is required")]
    public required TerraformValue<string> IdentityProviderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("identity_provider_name");
        set => SetArgument("identity_provider_name", value);
    }

    /// <summary>
    /// The principal_tags attribute.
    /// </summary>
    public TerraformMap<string>? PrincipalTags
    {
        get => GetArgument<TerraformMap<string>>("principal_tags");
        set => SetArgument("principal_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The use_defaults attribute.
    /// </summary>
    public TerraformValue<bool>? UseDefaults
    {
        get => GetArgument<TerraformValue<bool>>("use_defaults");
        set => SetArgument("use_defaults", value);
    }

}
