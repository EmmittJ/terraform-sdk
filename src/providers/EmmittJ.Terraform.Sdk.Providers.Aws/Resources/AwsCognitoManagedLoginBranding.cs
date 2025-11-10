using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoManagedLoginBrandingAssetBlock : TerraformBlock
{
    /// <summary>
    /// The bytes attribute.
    /// </summary>
    public TerraformProperty<string>? Bytes
    {
        set => SetProperty("bytes", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        set => SetProperty("category", value);
    }

    /// <summary>
    /// The color_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColorMode is required")]
    public required TerraformProperty<string> ColorMode
    {
        set => SetProperty("color_mode", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    public required TerraformProperty<string> Extension
    {
        set => SetProperty("extension", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        set => SetProperty("resource_id", value);
    }

}

/// <summary>
/// Manages a aws_cognito_managed_login_branding resource.
/// </summary>
public class AwsCognitoManagedLoginBranding : TerraformResource
{
    public AwsCognitoManagedLoginBranding(string name) : base("aws_cognito_managed_login_branding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("managed_login_branding_id");
        SetOutput("settings_all");
        SetOutput("client_id");
        SetOutput("region");
        SetOutput("settings");
        SetOutput("use_cognito_provided_values");
        SetOutput("user_pool_id");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
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
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string> Settings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("settings");
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    public TerraformProperty<bool> UseCognitoProvidedValues
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_cognito_provided_values");
        set => SetProperty("use_cognito_provided_values", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for asset.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCognitoManagedLoginBrandingAssetBlock>? Asset
    {
        set => SetProperty("asset", value);
    }

    /// <summary>
    /// The managed_login_branding_id attribute.
    /// </summary>
    public TerraformExpression ManagedLoginBrandingId => this["managed_login_branding_id"];

    /// <summary>
    /// The settings_all attribute.
    /// </summary>
    public TerraformExpression SettingsAll => this["settings_all"];

}
