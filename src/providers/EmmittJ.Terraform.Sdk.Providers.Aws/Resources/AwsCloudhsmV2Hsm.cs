using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudhsmV2HsmTimeoutsBlock : ITerraformBlock
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

}

/// <summary>
/// Manages a aws_cloudhsm_v2_hsm resource.
/// </summary>
public class AwsCloudhsmV2Hsm : TerraformResource
{
    public AwsCloudhsmV2Hsm(string name) : base("aws_cloudhsm_v2_hsm", name)
    {
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [TerraformPropertyName("availability_zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AvailabilityZone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "availability_zone");

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformPropertyName("ip_address")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> IpAddress { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ip_address");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("subnet_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SubnetId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "subnet_id");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudhsmV2HsmTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The hsm_eni_id attribute.
    /// </summary>
    [TerraformPropertyName("hsm_eni_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HsmEniId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hsm_eni_id");

    /// <summary>
    /// The hsm_id attribute.
    /// </summary>
    [TerraformPropertyName("hsm_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HsmId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hsm_id");

    /// <summary>
    /// The hsm_state attribute.
    /// </summary>
    [TerraformPropertyName("hsm_state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> HsmState => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "hsm_state");

}
