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
    public TerraformProperty<string>? ApiKey
    {
        get => GetProperty<TerraformProperty<string>>("api_key");
        set => this.WithProperty("api_key", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetProperty<TerraformProperty<string>>("application_id");
        set => this.WithProperty("application_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The service_json attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceJson
    {
        get => GetProperty<TerraformProperty<string>>("service_json");
        set => this.WithProperty("service_json", value);
    }

}
