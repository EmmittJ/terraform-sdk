using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_termination resource.
/// </summary>
public class AwsChimeVoiceConnectorTermination : TerraformResource
{
    public AwsChimeVoiceConnectorTermination(string name) : base("aws_chime_voice_connector_termination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("calling_regions");
        SetOutput("cidr_allow_list");
        SetOutput("cps_limit");
        SetOutput("default_phone_number");
        SetOutput("disabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("voice_connector_id");
    }

    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallingRegions is required")]
    public HashSet<TerraformProperty<string>> CallingRegions
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("calling_regions");
        set => SetProperty("calling_regions", value);
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrAllowList is required")]
    public HashSet<TerraformProperty<string>> CidrAllowList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("cidr_allow_list");
        set => SetProperty("cidr_allow_list", value);
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public TerraformProperty<double> CpsLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("cps_limit");
        set => SetProperty("cps_limit", value);
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public TerraformProperty<string> DefaultPhoneNumber
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_phone_number");
        set => SetProperty("default_phone_number", value);
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

}
