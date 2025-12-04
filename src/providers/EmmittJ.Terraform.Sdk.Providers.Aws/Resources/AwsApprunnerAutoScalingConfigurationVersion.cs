using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_apprunner_auto_scaling_configuration_version Terraform resource.
/// Manages a aws_apprunner_auto_scaling_configuration_version resource.
/// </summary>
public partial class AwsApprunnerAutoScalingConfigurationVersion(string name) : TerraformResource("aws_apprunner_auto_scaling_configuration_version", name)
{
    /// <summary>
    /// The auto_scaling_configuration_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoScalingConfigurationName is required")]
    public required TerraformValue<string> AutoScalingConfigurationName
    {
        get => GetRequiredArgument<TerraformValue<string>>("auto_scaling_configuration_name");
        set => SetArgument("auto_scaling_configuration_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrency
    {
        get => GetArgument<TerraformValue<double>>("max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxSize
    {
        get => GetArgument<TerraformValue<double>>("max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double>? MinSize
    {
        get => GetArgument<TerraformValue<double>>("min_size");
        set => SetArgument("min_size", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    public TerraformValue<double> AutoScalingConfigurationRevision
        => AsReference("auto_scaling_configuration_revision");

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    public TerraformValue<bool> HasAssociatedService
        => AsReference("has_associated_service");

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool> IsDefault
        => AsReference("is_default");

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool> Latest
        => AsReference("latest");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}
