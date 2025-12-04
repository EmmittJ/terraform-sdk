using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_codebuild_fleet Terraform data source.
/// Retrieves information about a aws_codebuild_fleet.
/// </summary>
public partial class AwsCodebuildFleetDataSource(string name) : TerraformDataSource("aws_codebuild_fleet", name)
{
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformValue<double> BaseCapacity
        => AsReference("base_capacity");

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeConfiguration
        => AsReference("compute_configuration");

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformValue<string> ComputeType
        => AsReference("compute_type");

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<string> Created
        => AsReference("created");

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentType
        => AsReference("environment_type");

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformValue<string> FleetServiceRole
        => AsReference("fleet_service_role");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
        => AsReference("image_id");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
        => AsReference("last_modified");

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformValue<string> OverflowBehavior
        => AsReference("overflow_behavior");

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScalingConfiguration
        => AsReference("scaling_configuration");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
        => AsReference("vpc_config");

}
