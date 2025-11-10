using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rotation_rules in .
/// Nesting mode: list
/// </summary>
public class AwsSecretsmanagerSecretRotationRotationRulesBlock : TerraformBlock
{
    /// <summary>
    /// The automatically_after_days attribute.
    /// </summary>
    public TerraformProperty<double>? AutomaticallyAfterDays
    {
        set => SetProperty("automatically_after_days", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        set => SetProperty("duration", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpression
    {
        set => SetProperty("schedule_expression", value);
    }

}

/// <summary>
/// Manages a aws_secretsmanager_secret_rotation resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSecretsmanagerSecretRotation : TerraformResource
{
    public AwsSecretsmanagerSecretRotation(string name) : base("aws_secretsmanager_secret_rotation", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("rotation_enabled");
        SetOutput("id");
        SetOutput("region");
        SetOutput("rotate_immediately");
        SetOutput("rotation_lambda_arn");
        SetOutput("secret_id");
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
    /// The rotate_immediately attribute.
    /// </summary>
    public TerraformProperty<bool> RotateImmediately
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("rotate_immediately");
        set => SetProperty("rotate_immediately", value);
    }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformProperty<string> RotationLambdaArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("rotation_lambda_arn");
        set => SetProperty("rotation_lambda_arn", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secret_id");
        set => SetProperty("secret_id", value);
    }

    /// <summary>
    /// Block for rotation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RotationRules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RotationRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationRules block(s) allowed")]
    public List<AwsSecretsmanagerSecretRotationRotationRulesBlock>? RotationRules
    {
        set => SetProperty("rotation_rules", value);
    }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformExpression RotationEnabled => this["rotation_enabled"];

}
