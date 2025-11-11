using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for asset in .
/// Nesting mode: set
/// </summary>
public partial class AwsCognitoManagedLoginBrandingAssetBlock : TerraformBlockBase
{
    /// <summary>
    /// The bytes attribute.
    /// </summary>
    [TerraformProperty("bytes")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Bytes { get; set; }

    /// <summary>
    /// The category attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Category is required")]
    [TerraformProperty("category")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Category { get; set; }

    /// <summary>
    /// The color_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ColorMode is required")]
    [TerraformProperty("color_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ColorMode { get; set; }

    /// <summary>
    /// The extension attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Extension is required")]
    [TerraformProperty("extension")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Extension { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceId { get; set; }

}

/// <summary>
/// Manages a aws_cognito_managed_login_branding resource.
/// </summary>
public partial class AwsCognitoManagedLoginBranding : TerraformResource
{
    public AwsCognitoManagedLoginBranding(string name) : base("aws_cognito_managed_login_branding", name)
    {
    }

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClientId is required")]
    [TerraformProperty("client_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClientId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    [TerraformProperty("settings")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Settings { get; set; }

    /// <summary>
    /// The use_cognito_provided_values attribute.
    /// </summary>
    [TerraformProperty("use_cognito_provided_values")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> UseCognitoProvidedValues { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// Block for asset.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("asset")]
    public TerraformSet<TerraformBlock<AwsCognitoManagedLoginBrandingAssetBlock>>? Asset { get; set; }

    /// <summary>
    /// The managed_login_branding_id attribute.
    /// </summary>
    [TerraformProperty("managed_login_branding_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ManagedLoginBrandingId { get; }

    /// <summary>
    /// The settings_all attribute.
    /// </summary>
    [TerraformProperty("settings_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SettingsAll { get; }

}
