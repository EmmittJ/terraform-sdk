using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceRadiusSettingsTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_radius_settings resource.
/// </summary>
public class AwsDirectoryServiceRadiusSettings : TerraformResource
{
    public AwsDirectoryServiceRadiusSettings(string name) : base("aws_directory_service_radius_settings", name)
    {
    }

    /// <summary>
    /// The authentication_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProtocol is required")]
    [TerraformPropertyName("authentication_protocol")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AuthenticationProtocol { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformPropertyName("directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayLabel is required")]
    [TerraformPropertyName("display_label")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayLabel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusPort is required")]
    [TerraformPropertyName("radius_port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RadiusPort { get; set; }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusRetries is required")]
    [TerraformPropertyName("radius_retries")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RadiusRetries { get; set; }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusServers is required")]
    [TerraformPropertyName("radius_servers")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> RadiusServers { get; set; }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusTimeout is required")]
    [TerraformPropertyName("radius_timeout")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> RadiusTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The shared_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedSecret is required")]
    [TerraformPropertyName("shared_secret")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SharedSecret { get; set; }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    [TerraformPropertyName("use_same_username")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? UseSameUsername { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDirectoryServiceRadiusSettingsTimeoutsBlock>? Timeouts { get; set; }

}
