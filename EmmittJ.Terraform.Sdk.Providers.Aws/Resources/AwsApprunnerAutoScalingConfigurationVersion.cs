using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_apprunner_auto_scaling_configuration_version resource.
/// </summary>
public class AwsApprunnerAutoScalingConfigurationVersion : TerraformResource
{
    public AwsApprunnerAutoScalingConfigurationVersion(string name) : base("aws_apprunner_auto_scaling_configuration_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_scaling_configuration_revision");
        this.DeclareOutput("has_associated_service");
        this.DeclareOutput("is_default");
        this.DeclareOutput("latest");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The auto_scaling_configuration_name attribute.
    /// </summary>
    public string? AutoScalingConfigurationName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_scaling_configuration_name")?.Value;
        set => this.WithProperty("auto_scaling_configuration_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_concurrency attribute.
    /// </summary>
    public double? MaxConcurrency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_concurrency")?.Value;
        set => this.WithProperty("max_concurrency", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public double? MaxSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_size")?.Value;
        set => this.WithProperty("max_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public double? MinSize
    {
        get => GetProperty<TerraformLiteralProperty<double>>("min_size")?.Value;
        set => this.WithProperty("min_size", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    public TerraformExpression AutoScalingConfigurationRevision => this["auto_scaling_configuration_revision"];

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    public TerraformExpression HasAssociatedService => this["has_associated_service"];

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformExpression IsDefault => this["is_default"];

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformExpression Latest => this["latest"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
