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
        get => GetArgument<TerraformValue<double>>("deployment_duration_in_minutes");
        set => SetArgument("deployment_duration_in_minutes", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The final_bake_time_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? FinalBakeTimeInMinutes
    {
        get => GetArgument<TerraformValue<double>>("final_bake_time_in_minutes");
        set => SetArgument("final_bake_time_in_minutes", value);
    }

    /// <summary>
    /// The growth_factor attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GrowthFactor is required")]
    public required TerraformValue<double> GrowthFactor
    {
        get => GetArgument<TerraformValue<double>>("growth_factor");
        set => SetArgument("growth_factor", value);
    }

    /// <summary>
    /// The growth_type attribute.
    /// </summary>
    public TerraformValue<string>? GrowthType
    {
        get => GetArgument<TerraformValue<string>>("growth_type");
        set => SetArgument("growth_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The replicate_to attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReplicateTo is required")]
    public required TerraformValue<string> ReplicateTo
    {
        get => GetArgument<TerraformValue<string>>("replicate_to");
        set => SetArgument("replicate_to", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

}
