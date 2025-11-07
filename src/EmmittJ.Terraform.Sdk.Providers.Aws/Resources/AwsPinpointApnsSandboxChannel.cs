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
    public TerraformProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformProperty<string>? BundleId
    {
        get => GetProperty<TerraformProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string>? Certificate
    {
        get => GetProperty<TerraformProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAuthenticationMethod
    {
        get => GetProperty<TerraformProperty<string>>("default_authentication_method");
        set => this.WithProperty("default_authentication_method", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => this.WithProperty("private_key", value);
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
    /// The team_id attribute.
    /// </summary>
    public TerraformProperty<string>? TeamId
    {
        get => GetProperty<TerraformProperty<string>>("team_id");
        set => this.WithProperty("team_id", value);
    }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    public TerraformProperty<string>? TokenKey
    {
        get => GetProperty<TerraformProperty<string>>("token_key");
        set => this.WithProperty("token_key", value);
    }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? TokenKeyId
    {
        get => GetProperty<TerraformProperty<string>>("token_key_id");
        set => this.WithProperty("token_key_id", value);
    }

}
