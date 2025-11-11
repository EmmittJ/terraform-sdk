using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_workgroup.
/// </summary>
public partial class AwsRedshiftserverlessWorkgroupDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessWorkgroupDataSource(string name) : base("aws_redshiftserverless_workgroup", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformProperty("workgroup_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Endpoint { get; }

    /// <summary>
    /// The enhanced_vpc_routing attribute.
    /// </summary>
    [TerraformProperty("enhanced_vpc_routing")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> EnhancedVpcRouting { get; }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformProperty("namespace_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NamespaceName { get; }

    /// <summary>
    /// The publicly_accessible attribute.
    /// </summary>
    [TerraformProperty("publicly_accessible")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> PubliclyAccessible { get; }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    [TerraformProperty("security_group_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SecurityGroupIds { get; }

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    [TerraformProperty("subnet_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> SubnetIds { get; }

    /// <summary>
    /// The track_name attribute.
    /// </summary>
    [TerraformProperty("track_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TrackName { get; }

    /// <summary>
    /// The workgroup_id attribute.
    /// </summary>
    [TerraformProperty("workgroup_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkgroupId { get; }

}
