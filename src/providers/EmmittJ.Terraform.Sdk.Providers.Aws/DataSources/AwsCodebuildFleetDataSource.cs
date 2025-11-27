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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformValue<double> BaseCapacity
    {
        get => new TerraformReference<double>(this, "base_capacity");
    }

    /// <summary>
    /// The compute_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ComputeConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "compute_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    public TerraformValue<string> ComputeType
    {
        get => new TerraformReference<string>(this, "compute_type");
    }

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<string> Created
    {
        get => new TerraformReference<string>(this, "created");
    }

    /// <summary>
    /// The environment_type attribute.
    /// </summary>
    public TerraformValue<string> EnvironmentType
    {
        get => new TerraformReference<string>(this, "environment_type");
    }

    /// <summary>
    /// The fleet_service_role attribute.
    /// </summary>
    public TerraformValue<string> FleetServiceRole
    {
        get => new TerraformReference<string>(this, "fleet_service_role");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
    }

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformValue<string> LastModified
    {
        get => new TerraformReference<string>(this, "last_modified");
    }

    /// <summary>
    /// The overflow_behavior attribute.
    /// </summary>
    public TerraformValue<string> OverflowBehavior
    {
        get => new TerraformReference<string>(this, "overflow_behavior");
    }

    /// <summary>
    /// The scaling_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ScalingConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "scaling_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Status
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_config").ResolveNodes(ctx));
    }

}
