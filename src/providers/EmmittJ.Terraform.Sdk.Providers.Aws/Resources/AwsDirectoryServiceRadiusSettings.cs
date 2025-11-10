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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("authentication_protocol");
        SetOutput("directory_id");
        SetOutput("display_label");
        SetOutput("id");
        SetOutput("radius_port");
        SetOutput("radius_retries");
        SetOutput("radius_servers");
        SetOutput("radius_timeout");
        SetOutput("region");
        SetOutput("shared_secret");
        SetOutput("use_same_username");
    }

    /// <summary>
    /// The authentication_protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationProtocol is required")]
    public required TerraformProperty<string> AuthenticationProtocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_protocol");
        set => SetProperty("authentication_protocol", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DirectoryId is required")]
    public required TerraformProperty<string> DirectoryId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("directory_id");
        set => SetProperty("directory_id", value);
    }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayLabel is required")]
    public required TerraformProperty<string> DisplayLabel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_label");
        set => SetProperty("display_label", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusPort is required")]
    public required TerraformProperty<double> RadiusPort
    {
        get => GetRequiredOutput<TerraformProperty<double>>("radius_port");
        set => SetProperty("radius_port", value);
    }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusRetries is required")]
    public required TerraformProperty<double> RadiusRetries
    {
        get => GetRequiredOutput<TerraformProperty<double>>("radius_retries");
        set => SetProperty("radius_retries", value);
    }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusServers is required")]
    public HashSet<TerraformProperty<string>> RadiusServers
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("radius_servers");
        set => SetProperty("radius_servers", value);
    }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RadiusTimeout is required")]
    public required TerraformProperty<double> RadiusTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("radius_timeout");
        set => SetProperty("radius_timeout", value);
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
    /// The shared_secret attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedSecret is required")]
    public required TerraformProperty<string> SharedSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("shared_secret");
        set => SetProperty("shared_secret", value);
    }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    public TerraformProperty<bool> UseSameUsername
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_same_username");
        set => SetProperty("use_same_username", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDirectoryServiceRadiusSettingsTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
