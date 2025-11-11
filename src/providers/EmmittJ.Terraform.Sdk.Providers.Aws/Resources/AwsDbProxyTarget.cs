using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_proxy_target resource.
/// </summary>
public partial class AwsDbProxyTarget : TerraformResource
{
    public AwsDbProxyTarget(string name) : base("aws_db_proxy_target", name)
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformProperty("db_cluster_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DbClusterIdentifier { get; set; }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [TerraformProperty("db_instance_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    [TerraformProperty("db_proxy_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbProxyName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The target_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupName is required")]
    [TerraformProperty("target_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetGroupName { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The rds_resource_id attribute.
    /// </summary>
    [TerraformProperty("rds_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> RdsResourceId { get; }

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformProperty("target_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetArn { get; }

    /// <summary>
    /// The tracked_cluster_id attribute.
    /// </summary>
    [TerraformProperty("tracked_cluster_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TrackedClusterId { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Type { get; }

}
