using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_apns_voip_channel resource.
/// </summary>
public class AwsPinpointApnsVoipChannel : TerraformResource
{
    public AwsPinpointApnsVoipChannel(string name) : base("aws_pinpoint_apns_voip_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BundleId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bundle_id");
        set => this.WithProperty("bundle_id", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Certificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate");
        set => this.WithProperty("certificate", value);
    }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultAuthenticationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_authentication_method");
        set => this.WithProperty("default_authentication_method", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The private_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_key");
        set => this.WithProperty("private_key", value);
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
    /// The team_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TeamId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("team_id");
        set => this.WithProperty("team_id", value);
    }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TokenKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_key");
        set => this.WithProperty("token_key", value);
    }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TokenKeyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("token_key_id");
        set => this.WithProperty("token_key_id", value);
    }

}
