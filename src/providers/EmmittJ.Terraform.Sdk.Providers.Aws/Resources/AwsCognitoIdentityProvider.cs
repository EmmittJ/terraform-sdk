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
        get => GetArgument<TerraformMap<string>>("attribute_mapping") ?? CreateReference("attribute_mapping");
        set => SetArgument("attribute_mapping", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idp_identifiers attribute.
    /// </summary>
    public TerraformList<string>? IdpIdentifiers
    {
        get => GetArgument<TerraformList<string>>("idp_identifiers");
        set => SetArgument("idp_identifiers", value);
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderDetails is required")]
    public required TerraformMap<string> ProviderDetails
    {
        get => GetRequiredArgument<TerraformMap<string>>("provider_details");
        set => SetArgument("provider_details", value);
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderName is required")]
    public required TerraformValue<string> ProviderName
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_name");
        set => SetArgument("provider_name", value);
    }

    /// <summary>
    /// The provider_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProviderType is required")]
    public required TerraformValue<string> ProviderType
    {
        get => GetRequiredArgument<TerraformValue<string>>("provider_type");
        set => SetArgument("provider_type", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

}
