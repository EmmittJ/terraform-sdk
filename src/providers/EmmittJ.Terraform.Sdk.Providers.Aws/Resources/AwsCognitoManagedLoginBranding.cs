using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in AwsCognitoManagedLoginBranding.
/// Nesting mode: set
/// </summary>
public class AwsCognitoManagedLoginBrandingAssetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "asset";

    /// <summary>
    /// The bytes attribute.
    /// </summary>
    public TerraformValue<string>? Bytes
    {
        get => GetArgument<TerraformValue<string>>("bytes");
        set => SetArgument("bytes", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformValue<string> Category
    {
        get => GetRequiredArgument<TerraformValue<string>>("category");
        set => SetArgument("category", value);
    }

    /// <summary>
    /// The color_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColorMode is required")]
    public required TerraformValue<string> ColorMode
    {
        get => GetRequiredArgument<TerraformValue<string>>("color_mode");
        set => SetArgument("color_mode", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    public required TerraformValue<string> Extension
    {
        get => GetRequiredArgument<TerraformValue<string>>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => GetArgument<TerraformValue<string>>("resource_id");
        set => SetArgument("resource_id", value);
    }

}


/// <summary>
/// Represents a aws_cognito_managed_login_branding Terraform resource.
/// Manages a aws_cognito_managed_login_branding resource.
/// </summary>
public partial class AwsCognitoManagedLoginBranding(string name) : TerraformResource("aws_cognito_managed_login_branding", name)
{
    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformValue<string> ClientId
    {
        get => GetRequiredArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
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
    /// The settings attribute.
    /// </summary>
    public TerraformValue<string>? Settings
    {
        get => GetArgument<TerraformValue<string>>("settings");
        set => SetArgument("settings", value);
    }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    public TerraformValue<bool> UseCognitoProvidedValues
    {
        get => GetArgument<TerraformValue<bool>>("use_cognito_provided_values") ?? CreateReference("use_cognito_provided_values");
        set => SetArgument("use_cognito_provided_values", value);
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

    /// <summary>
    /// The managed_login_branding_id attribute.
    /// </summary>
    public TerraformValue<string> ManagedLoginBrandingId
        => CreateReference("managed_login_branding_id");

    /// <summary>
    /// The settings_all attribute.
    /// </summary>
    public TerraformValue<string> SettingsAll
        => CreateReference("settings_all");

    /// <summary>
    /// Asset block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsCognitoManagedLoginBrandingAssetBlock>? Asset
    {
        get => GetArgument<TerraformSet<AwsCognitoManagedLoginBrandingAssetBlock>>("asset");
        set => SetArgument("asset", value);
    }

}
