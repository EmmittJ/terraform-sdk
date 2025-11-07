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
    }

    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CallingRegions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("calling_regions");
        set => this.WithProperty("calling_regions", value);
    }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? CidrAllowList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("cidr_allow_list");
        set => this.WithProperty("cidr_allow_list", value);
    }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? CpsLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("cps_limit");
        set => this.WithProperty("cps_limit", value);
    }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultPhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_phone_number");
        set => this.WithProperty("default_phone_number", value);
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled");
        set => this.WithProperty("disabled", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id");
        set => this.WithProperty("voice_connector_id", value);
    }

}
