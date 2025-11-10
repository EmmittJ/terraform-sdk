using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for config_parameter in .
/// Nesting mode: set
/// </summary>
public class AwsRedshiftserverlessWorkgroupConfigParameterBlock : ITerraformBlock
{
    /// <summary>
    /// The parameter_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterKey is required")]
    [TerraformPropertyName("parameter_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParameterKey { get; set; }

    /// <summary>
    /// The parameter_value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParameterValue is required")]
    [TerraformPropertyName("parameter_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ParameterValue { get; set; }

}

/// <summary>
/// Block type for price_performance_target in .
/// Nesting mode: list
/// </summary>
public class AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock : ITerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// The level attribute.
    /// </summary>
    [TerraformPropertyName("level")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Level { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRedshiftserverlessWorkgroupTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_redshiftserverless_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsRedshiftserverlessWorkgroup : TerraformResource
{
    public AwsRedshiftserverlessWorkgroup(string name) : base("aws_redshiftserverless_workgroup", name)
    {
    }

    /// <summary>
    /// The base_capacity attribute.
    /// </summary>
    [TerraformPropertyName("base_capacity")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> BaseCapacity { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "base_capacity");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnhancedVpcRouting { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [TerraformPropertyName("max_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxCapacity { get; set; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceName is required")]
    [TerraformPropertyName("namespace_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> NamespaceName { get; set; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> Port { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PubliclyAccessible { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    [TerraformPropertyName("track_name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> TrackName { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "track_name");

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformPropertyName("workgroup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkgroupName { get; set; }

    /// <summary>
    /// Block for config_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("config_parameter")]
    public TerraformSet<TerraformBlock<AwsRedshiftserverlessWorkgroupConfigParameterBlock>>? ConfigParameter { get; set; } = new();

    /// <summary>
    /// Block for price_performance_target.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PricePerformanceTarget block(s) allowed")]
    [TerraformPropertyName("price_performance_target")]
    public TerraformList<TerraformBlock<AwsRedshiftserverlessWorkgroupPricePerformanceTargetBlock>>? PricePerformanceTarget { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsRedshiftserverlessWorkgroupTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Endpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    [TerraformPropertyName("workgroup_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkgroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workgroup_id");

}
