using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_appconfig_deployment_strategy Terraform resource.
/// Manages a aws_appconfig_deployment_strategy resource.
/// </summary>
public partial class AwsAppconfigDeploymentStrategy(string name) : TerraformResource("aws_appconfig_deployment_strategy", name)
{
    /// <summary>
    /// The deployment_duration_in_minutes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeploymentDurationInMinutes is required")]
    public required TerraformValue<double> DeploymentDurationInMinutes
    {
        get => new TerraformReference<double>(this, "deployment_duration_in_minutes");
        set => SetArgument("deployment_duration_in_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The final_bake_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? FinalBakeTimeInMinutes
    {
        get => new TerraformReference<double>(this, "final_bake_time_in_minutes");
        set => SetArgument("final_bake_time_in_minutes", value);
    }

    /// <summary>
    /// The growth_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    public required TerraformValue<double> GrowthFactor
    {
        get => new TerraformReference<double>(this, "growth_factor");
        set => SetArgument("growth_factor", value);
    }

    /// <summary>
    /// The growth_type attribute.
    /// </summary>
    public TerraformValue<string>? GrowthType
    {
        get => new TerraformReference<string>(this, "growth_type");
        set => SetArgument("growth_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The replicate_to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicateTo is required")]
    public required TerraformValue<string> ReplicateTo
    {
        get => new TerraformReference<string>(this, "replicate_to");
        set => SetArgument("replicate_to", value);
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

}
