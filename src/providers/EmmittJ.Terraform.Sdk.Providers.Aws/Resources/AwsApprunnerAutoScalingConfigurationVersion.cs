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
        get => new TerraformReference<string>(this, "auto_scaling_configuration_name");
        set => SetArgument("auto_scaling_configuration_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_concurrency attribute.
    /// </summary>
    public TerraformValue<double>? MaxConcurrency
    {
        get => new TerraformReference<double>(this, "max_concurrency");
        set => SetArgument("max_concurrency", value);
    }

    /// <summary>
    /// The max_size attribute.
    /// </summary>
    public TerraformValue<double>? MaxSize
    {
        get => new TerraformReference<double>(this, "max_size");
        set => SetArgument("max_size", value);
    }

    /// <summary>
    /// The min_size attribute.
    /// </summary>
    public TerraformValue<double>? MinSize
    {
        get => new TerraformReference<double>(this, "min_size");
        set => SetArgument("min_size", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_scaling_configuration_revision attribute.
    /// </summary>
    public TerraformValue<double> AutoScalingConfigurationRevision
    {
        get => new TerraformReference<double>(this, "auto_scaling_configuration_revision");
    }

    /// <summary>
    /// The has_associated_service attribute.
    /// </summary>
    public TerraformValue<bool> HasAssociatedService
    {
        get => new TerraformReference<bool>(this, "has_associated_service");
    }

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool> IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
    }

    /// <summary>
    /// The latest attribute.
    /// </summary>
    public TerraformValue<bool> Latest
    {
        get => new TerraformReference<bool>(this, "latest");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}
