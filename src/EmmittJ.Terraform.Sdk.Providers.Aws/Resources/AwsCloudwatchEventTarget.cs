using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_target resource.
/// </summary>
public class AwsCloudwatchEventTarget : TerraformResource
{
    public AwsCloudwatchEventTarget(string name) : base("aws_cloudwatch_event_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public string? EventBusName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_bus_name")?.Value;
        set => this.WithProperty("event_bus_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The input attribute.
    /// </summary>
    public string? Input
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input")?.Value;
        set => this.WithProperty("input", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public string? InputPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input_path")?.Value;
        set => this.WithProperty("input_path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public string? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn")?.Value;
        set => this.WithProperty("role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public string? Rule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule")?.Value;
        set => this.WithProperty("rule", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public string? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id")?.Value;
        set => this.WithProperty("target_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
