using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector resource.
/// </summary>
public class AwsChimeVoiceConnector : TerraformResource
{
    public AwsChimeVoiceConnector(string name) : base("aws_chime_voice_connector", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("outbound_host_name");
        SetOutput("aws_region");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("require_encryption");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformProperty<string> AwsRegion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_region");
        set => SetProperty("aws_region", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The require_encryption attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RequireEncryption is required")]
    public required TerraformProperty<bool> RequireEncryption
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_encryption");
        set => SetProperty("require_encryption", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The outbound_host_name attribute.
    /// </summary>
    public TerraformExpression OutboundHostName => this["outbound_host_name"];

}
