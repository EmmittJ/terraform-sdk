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
    public TerraformLiteralProperty<string>? AuthenticationProtocol
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_protocol");
        set => this.WithProperty("authentication_protocol", value);
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id");
        set => this.WithProperty("directory_id", value);
    }

    /// <summary>
    /// The display_label attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayLabel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_label");
        set => this.WithProperty("display_label", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The radius_port attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RadiusPort
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_port");
        set => this.WithProperty("radius_port", value);
    }

    /// <summary>
    /// The radius_retries attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RadiusRetries
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_retries");
        set => this.WithProperty("radius_retries", value);
    }

    /// <summary>
    /// The radius_servers attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? RadiusServers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("radius_servers");
        set => this.WithProperty("radius_servers", value);
    }

    /// <summary>
    /// The radius_timeout attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? RadiusTimeout
    {
        get => GetProperty<TerraformLiteralProperty<double>>("radius_timeout");
        set => this.WithProperty("radius_timeout", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The shared_secret attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SharedSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("shared_secret");
        set => this.WithProperty("shared_secret", value);
    }

    /// <summary>
    /// The use_same_username attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UseSameUsername
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_same_username");
        set => this.WithProperty("use_same_username", value);
    }

}
