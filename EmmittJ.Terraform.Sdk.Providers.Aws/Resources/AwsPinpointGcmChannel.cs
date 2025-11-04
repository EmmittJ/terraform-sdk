using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_pinpoint_gcm_channel resource.
/// </summary>
public class AwsPinpointGcmChannel : TerraformResource
{
    public AwsPinpointGcmChannel(string name) : base("aws_pinpoint_gcm_channel", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public string? ApiKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_key")?.Value;
        set => this.WithProperty("api_key", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The service_json attribute.
    /// </summary>
    public string? ServiceJson
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_json")?.Value;
        set => this.WithProperty("service_json", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
