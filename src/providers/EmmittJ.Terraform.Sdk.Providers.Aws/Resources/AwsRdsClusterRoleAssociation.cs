using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsRdsClusterRoleAssociationTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a aws_rds_cluster_role_association resource.
/// </summary>
public partial class AwsRdsClusterRoleAssociation : TerraformResource
{
    public AwsRdsClusterRoleAssociation(string name) : base("aws_rds_cluster_role_association", name)
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbClusterIdentifier is required")]
    [TerraformProperty("db_cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DbClusterIdentifier { get; set; }

    /// <summary>
    /// The feature_name attribute.
    /// </summary>
    [TerraformProperty("feature_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? FeatureName { get; set; }

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
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsRdsClusterRoleAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
