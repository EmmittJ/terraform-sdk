using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_workgroup.
/// </summary>
public class AwsRedshiftserverlessWorkgroupDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessWorkgroupDataSource(string name) : base("aws_redshiftserverless_workgroup", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformPropertyName("workgroup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> WorkgroupName { get; set; }

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
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> EnhancedVpcRouting => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "enhanced_vpc_routing");

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NamespaceName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "namespace_name");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> PubliclyAccessible => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "publicly_accessible");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SecurityGroupIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> SubnetIds => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "subnet_ids");

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    [TerraformPropertyName("track_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrackName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "track_name");

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    [TerraformPropertyName("workgroup_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkgroupId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workgroup_id");

}
