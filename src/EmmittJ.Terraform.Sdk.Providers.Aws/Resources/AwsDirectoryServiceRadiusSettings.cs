using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceRadiusSettingsTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_directory_service_radius_settings resource.
/// </summary>
public class AwsDirectoryServiceRadiusSettings : TerraformResource
{
    public AwsDirectoryServiceRadiusSettings(string name) : base("aws_directory_service_radius_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProtocol is required")]
    public required TerraformProperty<string> AuthenticationProtocol
    {
        get => GetProperty<TerraformProperty<string>>("authentication_protocol");
        set => this.WithProperty("authentication_protocol", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetProperty<TerraformProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayLabel is required")]
    public required TerraformProperty<string> DisplayLabel
    {
        get => GetProperty<TerraformProperty<string>>("display_label");
        set => this.WithProperty("display_label", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusPort is required")]
    public required TerraformProperty<double> RadiusPort
    {
        get => GetProperty<TerraformProperty<double>>("radius_port");
        set => this.WithProperty("radius_port", value);
    }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusRetries is required")]
    public required TerraformProperty<double> RadiusRetries
    {
        get => GetProperty<TerraformProperty<double>>("radius_retries");
        set => this.WithProperty("radius_retries", value);
    }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusServers is required")]
    public HashSet<TerraformProperty<string>>? RadiusServers
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("radius_servers");
        set => this.WithProperty("radius_servers", value);
    }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusTimeout is required")]
    public required TerraformProperty<double> RadiusTimeout
    {
        get => GetProperty<TerraformProperty<double>>("radius_timeout");
        set => this.WithProperty("radius_timeout", value);
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
    /// The shared_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedSecret is required")]
    public required TerraformProperty<string> SharedSecret
    {
        get => GetProperty<TerraformProperty<string>>("shared_secret");
        set => this.WithProperty("shared_secret", value);
    }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    public TerraformProperty<bool>? UseSameUsername
    {
        get => GetProperty<TerraformProperty<bool>>("use_same_username");
        set => this.WithProperty("use_same_username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDirectoryServiceRadiusSettingsTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDirectoryServiceRadiusSettingsTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
