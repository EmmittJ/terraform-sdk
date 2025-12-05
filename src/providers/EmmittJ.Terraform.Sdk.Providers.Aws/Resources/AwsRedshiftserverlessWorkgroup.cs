using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config_parameter in AwsRedshiftserverlessWorkgroup.
/// Nesting mode: set
/// </summary>
public class AwsRedshiftserverlessWorkgroupConfigParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_parameter";

    /// <summary>
    /// The parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterKey is required")]
    public required TerraformValue<string> ParameterKey
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_key");
        set => SetArgument("parameter_key", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("parameter_value");
        set => SetArgument("parameter_value", value);
    }

}


/// <summary>
/// Block type for price_performance_target in AwsRedshiftserverlessWorkgroup.
/// Nesting mode: list
/// </summary>
public class AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "price_performance_target";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<double>? Level
    {
        get => GetArgument<TerraformValue<double>>("level");
        set => SetArgument("level", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRedshiftserverlessWorkgroup.
/// Nesting mode: single
/// </summary>
public class AwsRedshiftserverlessWorkgroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_redshiftserverless_workgroup Terraform resource.
/// Manages a aws_redshiftserverless_workgroup resource.
/// </summary>
public partial class AwsRedshiftserverlessWorkgroup(string name) : TerraformResource("aws_redshiftserverless_workgroup", name)
{
    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformValue<double> BaseCapacity
    {
        get => GetArgument<TerraformValue<double>>("base_capacity") ?? CreateReference("base_capacity");
        set => SetArgument("base_capacity", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedVpcRouting
    {
        get => GetArgument<TerraformValue<bool>>("enhanced_vpc_routing");
        set => SetArgument("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? CreateReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => GetArgument<TerraformValue<bool>>("publicly_accessible");
        set => SetArgument("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => GetArgument<TerraformSet<string>>("security_group_ids") ?? CreateReference("security_group_ids");
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => GetArgument<TerraformSet<string>>("subnet_ids") ?? CreateReference("subnet_ids");
        set => SetArgument("subnet_ids", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    public TerraformValue<string> TrackName
    {
        get => GetArgument<TerraformValue<string>>("track_name") ?? CreateReference("track_name");
        set => SetArgument("track_name", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    public TerraformValue<string> WorkgroupId
        => CreateReference("workgroup_id");

    /// <summary>
    /// ConfigParameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock>? ConfigParameter
    {
        get => GetArgument<TerraformSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock>>("config_parameter");
        set => SetArgument("config_parameter", value);
    }

    /// <summary>
    /// PricePerformanceTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PricePerformanceTarget block(s) allowed")]
    public TerraformList<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>? PricePerformanceTarget
    {
        get => GetArgument<TerraformList<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>>("price_performance_target");
        set => SetArgument("price_performance_target", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRedshiftserverlessWorkgroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRedshiftserverlessWorkgroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
