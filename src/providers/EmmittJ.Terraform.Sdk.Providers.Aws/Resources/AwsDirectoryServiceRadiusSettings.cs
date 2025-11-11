using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDirectoryServiceRadiusSettingsTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_radius_settings resource.
/// </summary>
public partial class AwsDirectoryServiceRadiusSettings : TerraformResource
{
    public AwsDirectoryServiceRadiusSettings(string name) : base("aws_directory_service_radius_settings", name)
    {
    }

    /// <summary>
    /// The authentication_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProtocol is required")]
    [TerraformProperty("authentication_protocol")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthenticationProtocol { get; set; }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    [TerraformProperty("directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DirectoryId { get; set; }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayLabel is required")]
    [TerraformProperty("display_label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayLabel { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusPort is required")]
    [TerraformProperty("radius_port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RadiusPort { get; set; }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusRetries is required")]
    [TerraformProperty("radius_retries")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RadiusRetries { get; set; }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusServers is required")]
    [TerraformProperty("radius_servers")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> RadiusServers { get; set; }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusTimeout is required")]
    [TerraformProperty("radius_timeout")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> RadiusTimeout { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The shared_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedSecret is required")]
    [TerraformProperty("shared_secret")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SharedSecret { get; set; }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    [TerraformProperty("use_same_username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? UseSameUsername { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDirectoryServiceRadiusSettingsTimeoutsBlock>? Timeouts { get; set; }

}
