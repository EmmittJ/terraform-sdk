using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for route in .
/// Nesting mode: set
/// </summary>
public class AwsChimeVoiceConnectorOriginationRouteBlock : TerraformBlock
{
    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformProperty<double> Priority
    {
        set => SetProperty("priority", value);
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Protocol is required")]
    public required TerraformProperty<string> Protocol
    {
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Weight is required")]
    public required TerraformProperty<double> Weight
    {
        set => SetProperty("weight", value);
    }

}

/// <summary>
/// Manages a aws_chime_voice_connector_origination resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimeVoiceConnectorOrigination : TerraformResource
{
    public AwsChimeVoiceConnectorOrigination(string name) : base("aws_chime_voice_connector_origination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("voice_connector_id");
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformProperty<bool> Disabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disabled");
        set => SetProperty("disabled", value);
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
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformProperty<string> VoiceConnectorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("voice_connector_id");
        set => SetProperty("voice_connector_id", value);
    }

    /// <summary>
    /// Block for route.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Route is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Route block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(20, ErrorMessage = "Maximum 20 Route block(s) allowed")]
    public HashSet<AwsChimeVoiceConnectorOriginationRouteBlock>? Route
    {
        set => SetProperty("route", value);
    }

}
