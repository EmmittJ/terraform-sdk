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
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
    }

    /// <summary>
    /// The event_bus_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventBusName
    {
        get => GetProperty<TerraformProperty<string>>("event_bus_name");
        set => this.WithProperty("event_bus_name", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The input attribute.
    /// </summary>
    public TerraformProperty<string>? Input
    {
        get => GetProperty<TerraformProperty<string>>("input");
        set => this.WithProperty("input", value);
    }

    /// <summary>
    /// The input_path attribute.
    /// </summary>
    public TerraformProperty<string>? InputPath
    {
        get => GetProperty<TerraformProperty<string>>("input_path");
        set => this.WithProperty("input_path", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The rule attribute.
    /// </summary>
    public TerraformProperty<string>? Rule
    {
        get => GetProperty<TerraformProperty<string>>("rule");
        set => this.WithProperty("rule", value);
    }

    /// <summary>
    /// The target_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetId
    {
        get => GetProperty<TerraformProperty<string>>("target_id");
        set => this.WithProperty("target_id", value);
    }

}
