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
        get => GetProperty<TerraformProperty<double>>("automatically_after_days");
        set => WithProperty("automatically_after_days", value);
    }

    /// <summary>
    /// The duration attribute.
    /// </summary>
    public TerraformProperty<string>? Duration
    {
        get => GetProperty<TerraformProperty<string>>("duration");
        set => WithProperty("duration", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    public TerraformProperty<string>? ScheduleExpression
    {
        get => GetProperty<TerraformProperty<string>>("schedule_expression");
        set => WithProperty("schedule_expression", value);
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
        this.WithOutput("rotation_enabled");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The rotate_immediately attribute.
    /// </summary>
    public TerraformProperty<bool>? RotateImmediately
    {
        get => GetProperty<TerraformProperty<bool>>("rotate_immediately");
        set => this.WithProperty("rotate_immediately", value);
    }

    /// <summary>
    /// The rotation_lambda_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RotationLambdaArn
    {
        get => GetProperty<TerraformProperty<string>>("rotation_lambda_arn");
        set => this.WithProperty("rotation_lambda_arn", value);
    }

    /// <summary>
    /// The secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretId is required")]
    public required TerraformProperty<string> SecretId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("secret_id");
        set => this.WithProperty("secret_id", value);
    }

    /// <summary>
    /// Block for rotation_rules.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RotationRules block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RotationRules block(s) allowed")]
    public List<AwsSecretsmanagerSecretRotationRotationRulesBlock>? RotationRules
    {
        get => GetProperty<List<AwsSecretsmanagerSecretRotationRotationRulesBlock>>("rotation_rules");
        set => this.WithProperty("rotation_rules", value);
    }

    /// <summary>
    /// The rotation_enabled attribute.
    /// </summary>
    public TerraformExpression RotationEnabled => this["rotation_enabled"];

}
