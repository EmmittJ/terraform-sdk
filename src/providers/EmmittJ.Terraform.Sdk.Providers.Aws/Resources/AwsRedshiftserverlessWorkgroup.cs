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
        set => SetProperty("parameter_key", value);
    }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    public required TerraformProperty<string> ParameterValue
    {
        set => SetProperty("parameter_value", value);
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
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The level attribute.
    /// </summary>
    public TerraformProperty<double>? Level
    {
        set => SetProperty("level", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("workgroup_id");
        SetOutput("base_capacity");
        SetOutput("enhanced_vpc_routing");
        SetOutput("id");
        SetOutput("max_capacity");
        SetOutput("namespace_name");
        SetOutput("port");
        SetOutput("publicly_accessible");
        SetOutput("region");
        SetOutput("security_group_ids");
        SetOutput("subnet_ids");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("track_name");
        SetOutput("workgroup_name");
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    public TerraformProperty<double> BaseCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("base_capacity");
        set => SetProperty("base_capacity", value);
    }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    public TerraformProperty<bool> EnhancedVpcRouting
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enhanced_vpc_routing");
        set => SetProperty("enhanced_vpc_routing", value);
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
    /// The max_capacity attribute.
    /// </summary>
    public TerraformProperty<double> MaxCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_capacity");
        set => SetProperty("max_capacity", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    public required TerraformProperty<string> NamespaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_name");
        set => SetProperty("namespace_name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    public TerraformProperty<bool> PubliclyAccessible
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("publicly_accessible");
        set => SetProperty("publicly_accessible", value);
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
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_ids");
        set => SetProperty("subnet_ids", value);
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
    /// The track_name attribute.
    /// </summary>
    public TerraformProperty<string> TrackName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("track_name");
        set => SetProperty("track_name", value);
    }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    public required TerraformProperty<string> WorkgroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("workgroup_name");
        set => SetProperty("workgroup_name", value);
    }

    /// <summary>
    /// Block for config_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock>? ConfigParameter
    {
        set => SetProperty("config_parameter", value);
    }

    /// <summary>
    /// Block for price_performance_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PricePerformanceTarget block(s) allowed")]
    public List<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>? PricePerformanceTarget
    {
        set => SetProperty("price_performance_target", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRedshiftserverlessWorkgroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
