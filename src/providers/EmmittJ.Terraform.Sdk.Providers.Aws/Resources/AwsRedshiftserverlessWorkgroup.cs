using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config_parameter in .
/// Nesting mode: set
/// </summary>
public partial class AwsRedshiftserverlessWorkgroupConfigParameterBlock() : TerraformBlock("config_parameter")
{
    /// <summary>
    /// The parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterKey is required")]
    [TerraformProperty("parameter_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterKey { get; set; }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    [TerraformProperty("parameter_value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ParameterValue { get; set; }

}

/// <summary>
/// Block type for price_performance_target in .
/// Nesting mode: list
/// </summary>
public partial class AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock() : TerraformBlock("price_performance_target")
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformProperty("level")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Level { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRedshiftserverlessWorkgroupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_redshiftserverless_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRedshiftserverlessWorkgroup : TerraformResource
{
    public AwsRedshiftserverlessWorkgroup(string name) : base("aws_redshiftserverless_workgroup", name)
    {
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [TerraformProperty("base_capacity")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> BaseCapacity { get; set; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformProperty("enhanced_vpc_routing")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? EnhancedVpcRouting { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformProperty("max_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxCapacity { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformProperty("namespace_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Port { get; set; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SecurityGroupIds { get; set; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> SubnetIds { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    [TerraformProperty("track_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TrackName { get; set; }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformProperty("workgroup_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// Block for config_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("config_parameter")]
    public TerraformSet<AwsRedshiftserverlessWorkgroupConfigParameterBlock> ConfigParameter { get; set; } = new();

    /// <summary>
    /// Block for price_performance_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PricePerformanceTarget block(s) allowed")]
    [TerraformProperty("price_performance_target")]
    public TerraformList<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock> PricePerformanceTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRedshiftserverlessWorkgroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Endpoint { get; }

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    [TerraformProperty("workgroup_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkgroupId { get; }

}
