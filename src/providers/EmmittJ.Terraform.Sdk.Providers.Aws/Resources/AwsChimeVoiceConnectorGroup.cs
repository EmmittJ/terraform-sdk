using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connector in AwsChimeVoiceConnectorGroup.
/// Nesting mode: set
/// </summary>
public class AwsChimeVoiceConnectorGroupConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connector";

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => GetArgument<TerraformValue<string>>("voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

}


/// <summary>
/// Represents a aws_chime_voice_connector_group Terraform resource.
/// Manages a aws_chime_voice_connector_group resource.
/// </summary>
public partial class AwsChimeVoiceConnectorGroup(string name) : TerraformResource("aws_chime_voice_connector_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Connector block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(3, ErrorMessage = "Maximum 3 Connector block(s) allowed")]
    public TerraformSet<AwsChimeVoiceConnectorGroupConnectorBlock>? Connector
    {
        get => GetArgument<TerraformSet<AwsChimeVoiceConnectorGroupConnectorBlock>>("connector");
        set => SetArgument("connector", value);
    }

}
