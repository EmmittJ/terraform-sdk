using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDirectoryServiceRadiusSettings.
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceRadiusSettingsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_directory_service_radius_settings Terraform resource.
/// Manages a aws_directory_service_radius_settings resource.
/// </summary>
public partial class AwsDirectoryServiceRadiusSettings(string name) : TerraformResource("aws_directory_service_radius_settings", name)
{
    /// <summary>
    /// The authentication_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProtocol is required")]
    public required TerraformValue<string> AuthenticationProtocol
    {
        get => GetRequiredArgument<TerraformValue<string>>("authentication_protocol");
        set => SetArgument("authentication_protocol", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformValue<string> DirectoryId
    {
        get => GetRequiredArgument<TerraformValue<string>>("directory_id");
        set => SetArgument("directory_id", value);
    }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayLabel is required")]
    public required TerraformValue<string> DisplayLabel
    {
        get => GetRequiredArgument<TerraformValue<string>>("display_label");
        set => SetArgument("display_label", value);
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
    /// The radius_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusPort is required")]
    public required TerraformValue<double> RadiusPort
    {
        get => GetRequiredArgument<TerraformValue<double>>("radius_port");
        set => SetArgument("radius_port", value);
    }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusRetries is required")]
    public required TerraformValue<double> RadiusRetries
    {
        get => GetRequiredArgument<TerraformValue<double>>("radius_retries");
        set => SetArgument("radius_retries", value);
    }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusServers is required")]
    public required TerraformSet<string> RadiusServers
    {
        get => GetRequiredArgument<TerraformSet<string>>("radius_servers");
        set => SetArgument("radius_servers", value);
    }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusTimeout is required")]
    public required TerraformValue<double> RadiusTimeout
    {
        get => GetRequiredArgument<TerraformValue<double>>("radius_timeout");
        set => SetArgument("radius_timeout", value);
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
    /// The shared_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedSecret is required")]
    public required TerraformValue<string> SharedSecret
    {
        get => GetRequiredArgument<TerraformValue<string>>("shared_secret");
        set => SetArgument("shared_secret", value);
    }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    public TerraformValue<bool>? UseSameUsername
    {
        get => GetArgument<TerraformValue<bool>>("use_same_username");
        set => SetArgument("use_same_username", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDirectoryServiceRadiusSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDirectoryServiceRadiusSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
