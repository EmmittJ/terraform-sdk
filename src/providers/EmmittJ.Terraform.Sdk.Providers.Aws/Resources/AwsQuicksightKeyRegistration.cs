using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for key_registration in AwsQuicksightKeyRegistration.
/// Nesting mode: set
/// </summary>
public class AwsQuicksightKeyRegistrationKeyRegistrationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "key_registration";

    /// <summary>
    /// The default_key attribute.
    /// </summary>
    public TerraformValue<bool> DefaultKey
    {
        get => GetArgument<TerraformValue<bool>>("default_key") ?? AsReference("default_key");
        set => SetArgument("default_key", value);
    }

    /// <summary>
    /// The key_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyArn is required")]
    public required TerraformValue<string> KeyArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_arn");
        set => SetArgument("key_arn", value);
    }

}


/// <summary>
/// Represents a aws_quicksight_key_registration Terraform resource.
/// Manages a aws_quicksight_key_registration resource.
/// </summary>
public partial class AwsQuicksightKeyRegistration(string name) : TerraformResource("aws_quicksight_key_registration", name)
{
    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformValue<string> AwsAccountId
    {
        get => GetArgument<TerraformValue<string>>("aws_account_id") ?? AsReference("aws_account_id");
        set => SetArgument("aws_account_id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// KeyRegistration block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsQuicksightKeyRegistrationKeyRegistrationBlock>? KeyRegistration
    {
        get => GetArgument<TerraformSet<AwsQuicksightKeyRegistrationKeyRegistrationBlock>>("key_registration");
        set => SetArgument("key_registration", value);
    }

}
