using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoManagedLoginBrandingAssetBlock
{
    /// <summary>
    /// The bytes attribute.
    /// </summary>
    [TerraformPropertyName("bytes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Bytes { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformPropertyName("category")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The color_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColorMode is required")]
    [TerraformPropertyName("color_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ColorMode { get; set; }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    [TerraformPropertyName("extension")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Extension { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ResourceId { get; set; }

}

/// <summary>
/// Manages a aws_cognito_managed_login_branding resource.
/// </summary>
public class AwsCognitoManagedLoginBranding : TerraformResource
{
    public AwsCognitoManagedLoginBranding(string name) : base("aws_cognito_managed_login_branding", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformPropertyName("client_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformPropertyName("settings")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    [TerraformPropertyName("use_cognito_provided_values")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> UseCognitoProvidedValues { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// Block for asset.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("asset")]
    public TerraformSet<TerraformBlock<AwsCognitoManagedLoginBrandingAssetBlock>>? Asset { get; set; }

    /// <summary>
    /// The managed_login_branding_id attribute.
    /// </summary>
    [TerraformPropertyName("managed_login_branding_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedLoginBrandingId => new TerraformReference(this, "managed_login_branding_id");

    /// <summary>
    /// The settings_all attribute.
    /// </summary>
    [TerraformPropertyName("settings_all")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SettingsAll => new TerraformReference(this, "settings_all");

}
