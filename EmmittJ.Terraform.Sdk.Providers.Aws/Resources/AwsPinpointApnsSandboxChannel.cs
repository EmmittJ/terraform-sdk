using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_apns_sandbox_channel resource.
/// </summary>
public class AwsPinpointApnsSandboxChannel : TerraformResource
{
    public AwsPinpointApnsSandboxChannel(string name) : base("aws_pinpoint_apns_sandbox_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public string? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id")?.Value;
        set => this.WithProperty("bundle_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public string? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate")?.Value;
        set => this.WithProperty("certificate", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    public string? DefaultAuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_authentication_method")?.Value;
        set => this.WithProperty("default_authentication_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The private_key attribute.
    /// </summary>
    public string? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_key")?.Value;
        set => this.WithProperty("private_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The team_id attribute.
    /// </summary>
    public string? TeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("team_id")?.Value;
        set => this.WithProperty("team_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    public string? TokenKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_key")?.Value;
        set => this.WithProperty("token_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    public string? TokenKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_key_id")?.Value;
        set => this.WithProperty("token_key_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
