using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config_parameter in .
/// Nesting mode: set
/// </summary>
public class AwsRedshiftserverlessWorkgroupConfigParameterBlock : TerraformBlock
{
    /// <summary>
    /// The parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterKey is required")]
    public required TerraformProperty<string> ParameterKey
    {
        get => GetProperty<TerraformProperty<string>>("parameter_key");
        set => WithProperty("parameter_key", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformProperty<string> ParameterValue
    {
        get => GetProperty<TerraformProperty<string>>("parameter_value");
        set => WithProperty("parameter_value", value);
    }

}

/// <summary>
/// Block type for price_performance_target in .
/// Nesting mode: list
/// </summary>
public class AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<double>? Level
    {
        get => GetProperty<TerraformProperty<double>>("level");
        set => WithProperty("level", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftserverlessWorkgroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_redshiftserverless_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRedshiftserverlessWorkgroup : TerraformResource
{
    public AwsRedshiftserverlessWorkgroup(string name) : base("aws_redshiftserverless_workgroup", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("workgroup_id");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? BaseCapacity
    {
        get => GetProperty<TerraformProperty<double>>("base_capacity");
        set => this.WithProperty("base_capacity", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformProperty<bool>? EnhancedVpcRouting
    {
        get => GetProperty<TerraformProperty<bool>>("enhanced_vpc_routing");
        set => this.WithProperty("enhanced_vpc_routing", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? MaxCapacity
    {
        get => GetProperty<TerraformProperty<double>>("max_capacity");
        set => this.WithProperty("max_capacity", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformProperty<string> NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool>? PubliclyAccessible
    {
        get => GetProperty<TerraformProperty<bool>>("publicly_accessible");
        set => this.WithProperty("publicly_accessible", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => this.WithProperty("subnet_ids", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    public TerraformProperty<string>? TrackName
    {
        get => GetProperty<TerraformProperty<string>>("track_name");
        set => this.WithProperty("track_name", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetProperty<TerraformProperty<string>>("workgroup_name");
        set => this.WithProperty("workgroup_name", value);
    }

    /// <summary>
    /// Block for config_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock>? ConfigParameter
    {
        get => GetProperty<HashSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock>>("config_parameter");
        set => this.WithProperty("config_parameter", value);
    }

    /// <summary>
    /// Block for price_performance_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PricePerformanceTarget block(s) allowed")]
    public List<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>? PricePerformanceTarget
    {
        get => GetProperty<List<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>>("price_performance_target");
        set => this.WithProperty("price_performance_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftserverlessWorkgroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRedshiftserverlessWorkgroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    public TerraformExpression WorkgroupId => this["workgroup_id"];

}
