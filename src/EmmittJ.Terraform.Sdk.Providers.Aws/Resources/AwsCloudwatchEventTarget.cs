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
    public TerraformLiteralProperty<string>? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EventBusName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("event_bus_name");
        set => this.WithProperty("event_bus_name", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The input attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Input
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input");
        set => this.WithProperty("input", value);
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InputPath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input_path");
        set => this.WithProperty("input_path", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Rule
    {
        get => GetProperty<TerraformLiteralProperty<string>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

}
