using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for credentials in AwsChimeVoiceConnectorTerminationCredentials.
/// Nesting mode: set
/// </summary>
public class AwsChimeVoiceConnectorTerminationCredentialsCredentialsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "credentials";

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    public required TerraformValue<string> Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformValue<string> Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Represents a aws_chime_voice_connector_termination_credentials Terraform resource.
/// Manages a aws_chime_voice_connector_termination_credentials resource.
/// </summary>
public partial class AwsChimeVoiceConnectorTerminationCredentials(string name) : TerraformResource("aws_chime_voice_connector_termination_credentials", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    public required TerraformValue<string> VoiceConnectorId
    {
        get => new TerraformReference<string>(this, "voice_connector_id");
        set => SetArgument("voice_connector_id", value);
    }

    /// <summary>
    /// Credentials block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credentials is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Credentials block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Credentials block(s) allowed")]
    public required TerraformSet<AwsChimeVoiceConnectorTerminationCredentialsCredentialsBlock> Credentials
    {
        get => GetRequiredArgument<TerraformSet<AwsChimeVoiceConnectorTerminationCredentialsCredentialsBlock>>("credentials");
        set => SetArgument("credentials", value);
    }

}
