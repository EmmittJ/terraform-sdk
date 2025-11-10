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
        SetOutput("api_key");
        SetOutput("application_id");
        SetOutput("default_authentication_method");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("service_json");
    }

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    public TerraformProperty<string> ApiKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("api_key");
        set => SetProperty("api_key", value);
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The default_authentication_method attribute.
    /// </summary>
    public TerraformProperty<string> DefaultAuthenticationMethod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_authentication_method");
        set => SetProperty("default_authentication_method", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The service_json attribute.
    /// </summary>
    public TerraformProperty<string> ServiceJson
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_json");
        set => SetProperty("service_json", value);
    }

}
