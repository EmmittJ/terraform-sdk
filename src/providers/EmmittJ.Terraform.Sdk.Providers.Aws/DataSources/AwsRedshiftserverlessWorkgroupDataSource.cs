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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformPropertyName("workgroup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_vpc_routing")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> EnhancedVpcRouting => new TerraformReference(this, "enhanced_vpc_routing");

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformPropertyName("namespace_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NamespaceName => new TerraformReference(this, "namespace_name");

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformPropertyName("publicly_accessible")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> PubliclyAccessible => new TerraformReference(this, "publicly_accessible");

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("security_group_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SecurityGroupIds => new TerraformReference(this, "security_group_ids");

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformPropertyName("subnet_ids")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> SubnetIds => new TerraformReference(this, "subnet_ids");

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    [TerraformPropertyName("track_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TrackName => new TerraformReference(this, "track_name");

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    [TerraformPropertyName("workgroup_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkgroupId => new TerraformReference(this, "workgroup_id");

}
