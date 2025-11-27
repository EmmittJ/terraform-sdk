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
        get => new TerraformReference<string>(this, "parameter_key");
        set => SetArgument("parameter_key", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformValue<string> ParameterValue
    {
        get => new TerraformReference<string>(this, "parameter_value");
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
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformValue<double>? Level
    {
        get => new TerraformReference<double>(this, "level");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<double>(this, "base_capacity");
        set => SetArgument("base_capacity", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformValue<bool>? EnhancedVpcRouting
    {
        get => new TerraformReference<bool>(this, "enhanced_vpc_routing");
        set => SetArgument("enhanced_vpc_routing", value);
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
    /// The max_capacity attribute.
    /// </summary>
    public TerraformValue<double>? MaxCapacity
    {
        get => new TerraformReference<double>(this, "max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
        set => SetArgument("namespace_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformValue<bool>? PubliclyAccessible
    {
        get => new TerraformReference<bool>(this, "publicly_accessible");
        set => SetArgument("publicly_accessible", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_ids").ResolveNodes(ctx));
        set => SetArgument("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> SubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_ids").ResolveNodes(ctx));
        set => SetArgument("subnet_ids", value);
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
    /// The track_name attribute.
    /// </summary>
    public TerraformValue<string> TrackName
    {
        get => new TerraformReference<string>(this, "track_name");
        set => SetArgument("track_name", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformValue<string> WorkgroupName
    {
        get => new TerraformReference<string>(this, "workgroup_name");
        set => SetArgument("workgroup_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Endpoint
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "endpoint").ResolveNodes(ctx));
    }

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    public TerraformValue<string> WorkgroupId
    {
        get => new TerraformReference<string>(this, "workgroup_id");
    }

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
