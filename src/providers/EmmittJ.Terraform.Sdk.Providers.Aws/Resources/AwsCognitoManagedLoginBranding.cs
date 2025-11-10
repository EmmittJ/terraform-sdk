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
        get => GetProperty<TerraformProperty<string>>("bytes");
        set => WithProperty("bytes", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    public required TerraformProperty<string> Category
    {
        get => GetRequiredProperty<TerraformProperty<string>>("category");
        set => WithProperty("category", value);
    }

    /// <summary>
    /// The color_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColorMode is required")]
    public required TerraformProperty<string> ColorMode
    {
        get => GetRequiredProperty<TerraformProperty<string>>("color_mode");
        set => WithProperty("color_mode", value);
    }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    public required TerraformProperty<string> Extension
    {
        get => GetRequiredProperty<TerraformProperty<string>>("extension");
        set => WithProperty("extension", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceId
    {
        get => GetProperty<TerraformProperty<string>>("resource_id");
        set => WithProperty("resource_id", value);
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
        this.WithOutput("managed_login_branding_id");
        this.WithOutput("settings_all");
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    public required TerraformProperty<string> ClientId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        get => GetProperty<TerraformProperty<string>>("settings");
        set => this.WithProperty("settings", value);
    }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    public TerraformProperty<bool>? UseCognitoProvidedValues
    {
        get => GetProperty<TerraformProperty<bool>>("use_cognito_provided_values");
        set => this.WithProperty("use_cognito_provided_values", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// Block for asset.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsCognitoManagedLoginBrandingAssetBlock>? Asset
    {
        get => GetProperty<HashSet<AwsCognitoManagedLoginBrandingAssetBlock>>("asset");
        set => this.WithProperty("asset", value);
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
