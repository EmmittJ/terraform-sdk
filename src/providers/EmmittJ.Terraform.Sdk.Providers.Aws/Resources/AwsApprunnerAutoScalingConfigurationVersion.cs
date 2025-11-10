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
        SetOutput("arn");
        SetOutput("auto_scaling_configuration_revision");
        SetOutput("has_associated_service");
        SetOutput("is_default");
        SetOutput("latest");
        SetOutput("status");
        SetOutput("auto_scaling_configuration_name");
        SetOutput("id");
        SetOutput("max_concurrency");
        SetOutput("max_size");
        SetOutput("min_size");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The auto_scaling_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationName is required")]
    public required TerraformProperty<string> AutoScalingConfigurationName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_scaling_configuration_name");
        set => SetProperty("auto_scaling_configuration_name", value);
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
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformProperty<double> MaxConcurrency
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_concurrency");
        set => SetProperty("max_concurrency", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformProperty<double> MaxSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_size");
        set => SetProperty("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformProperty<double> MinSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("min_size");
        set => SetProperty("min_size", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
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
