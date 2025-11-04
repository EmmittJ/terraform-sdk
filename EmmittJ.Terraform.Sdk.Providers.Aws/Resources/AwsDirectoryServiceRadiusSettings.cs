using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AuthenticationProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_protocol")?.Value;
        set => this.WithProperty("authentication_protocol", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    public string? DisplayLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_label")?.Value;
        set => this.WithProperty("display_label", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    public double? RadiusPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_port")?.Value;
        set => this.WithProperty("radius_port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    public double? RadiusRetries
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_retries")?.Value;
        set => this.WithProperty("radius_retries", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    public HashSet<string>? RadiusServers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("radius_servers")?.Value;
        set => this.WithProperty("radius_servers", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    public double? RadiusTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_timeout")?.Value;
        set => this.WithProperty("radius_timeout", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The shared_secret attribute.
    /// </summary>
    public string? SharedSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_secret")?.Value;
        set => this.WithProperty("shared_secret", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    public bool? UseSameUsername
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_same_username")?.Value;
        set => this.WithProperty("use_same_username", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

}
