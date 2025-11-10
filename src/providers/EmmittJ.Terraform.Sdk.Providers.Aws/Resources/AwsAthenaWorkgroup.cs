using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsAthenaWorkgroupConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The bytes_scanned_cutoff_per_query attribute.
    /// </summary>
    [TerraformPropertyName("bytes_scanned_cutoff_per_query")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? BytesScannedCutoffPerQuery { get; set; }

    /// <summary>
    /// The enforce_workgroup_configuration attribute.
    /// </summary>
    [TerraformPropertyName("enforce_workgroup_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? EnforceWorkgroupConfiguration { get; set; }

    /// <summary>
    /// The execution_role attribute.
    /// </summary>
    [TerraformPropertyName("execution_role")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExecutionRole { get; set; }

    /// <summary>
    /// The publish_cloudwatch_metrics_enabled attribute.
    /// </summary>
    [TerraformPropertyName("publish_cloudwatch_metrics_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? PublishCloudwatchMetricsEnabled { get; set; }

    /// <summary>
    /// The requester_pays_enabled attribute.
    /// </summary>
    [TerraformPropertyName("requester_pays_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RequesterPaysEnabled { get; set; }

}

/// <summary>
/// Manages a aws_athena_workgroup resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsAthenaWorkgroup : TerraformResource
{
    public AwsAthenaWorkgroup(string name) : base("aws_athena_workgroup", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    [TerraformPropertyName("force_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDestroy { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformPropertyName("state")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? State { get; set; }

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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    [TerraformPropertyName("configuration")]
    public TerraformList<TerraformBlock<AwsAthenaWorkgroupConfigurationBlock>>? Configuration { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
