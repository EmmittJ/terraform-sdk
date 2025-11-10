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
        SetOutput("application_id");
        SetOutput("bundle_id");
        SetOutput("certificate");
        SetOutput("default_authentication_method");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("private_key");
        SetOutput("region");
        SetOutput("team_id");
        SetOutput("token_key");
        SetOutput("token_key_id");
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
    /// The bundle_id attribute.
    /// </summary>
    public TerraformProperty<string> BundleId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bundle_id");
        set => SetProperty("bundle_id", value);
    }

    /// <summary>
    /// The certificate attribute.
    /// </summary>
    public TerraformProperty<string> Certificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("certificate");
        set => SetProperty("certificate", value);
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
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string> PrivateKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_key");
        set => SetProperty("private_key", value);
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
    /// The team_id attribute.
    /// </summary>
    public TerraformProperty<string> TeamId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("team_id");
        set => SetProperty("team_id", value);
    }

    /// <summary>
    /// The token_key attribute.
    /// </summary>
    public TerraformProperty<string> TokenKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_key");
        set => SetProperty("token_key", value);
    }

    /// <summary>
    /// The token_key_id attribute.
    /// </summary>
    public TerraformProperty<string> TokenKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_key_id");
        set => SetProperty("token_key_id", value);
    }

}
