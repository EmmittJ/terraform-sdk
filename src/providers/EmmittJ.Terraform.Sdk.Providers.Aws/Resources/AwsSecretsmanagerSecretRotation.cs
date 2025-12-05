using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rotation_rules in AwsSecretsmanagerSecretRotation.
/// Nesting mode: list
/// </summary>
public class AwsSecretsmanagerSecretRotationRotationRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rotation_rules";

    /// <summary>
    /// The automatically_after_days attribute.
    /// </summary>
    public TerraformValue<double>? AutomaticallyAfterDays
    {
        get => GetArgument<TerraformValue<double>>("automatically_after_days");
        set => SetArgument("automatically_after_days", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformValue<string>? Duration
    {
        get => GetArgument<TerraformValue<string>>("duration");
        set => SetArgument("duration", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleExpression
    {
        get => GetArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

}


/// <summary>
/// Represents a aws_secretsmanager_secret_rotation Terraform resource.
/// Manages a aws_secretsmanager_secret_rotation resource.
/// </summary>
public partial class AwsSecretsmanagerSecretRotation(string name) : TerraformResource("aws_secretsmanager_secret_rotation", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The rotate_immediately attribute.
    /// </summary>
    public TerraformValue<bool>? RotateImmediately
    {
        get => GetArgument<TerraformValue<bool>>("rotate_immediately");
        set => SetArgument("rotate_immediately", value);
    }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformValue<string>? RotationLambdaArn
    {
        get => GetArgument<TerraformValue<string>>("rotation_lambda_arn");
        set => SetArgument("rotation_lambda_arn", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformValue<string> SecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("secret_id");
        set => SetArgument("secret_id", value);
    }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformValue<bool> RotationEnabled
        => CreateReference("rotation_enabled");

    /// <summary>
    /// RotationRules block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RotationRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationRules block(s) allowed")]
    public required TerraformList<AwsSecretsmanagerSecretRotationRotationRulesBlock> RotationRules
    {
        get => GetRequiredArgument<TerraformList<AwsSecretsmanagerSecretRotationRotationRulesBlock>>("rotation_rules");
        set => SetArgument("rotation_rules", value);
    }

}
