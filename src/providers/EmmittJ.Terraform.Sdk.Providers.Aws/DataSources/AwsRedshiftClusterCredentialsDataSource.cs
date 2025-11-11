using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshift_cluster_credentials.
/// </summary>
public partial class AwsRedshiftClusterCredentialsDataSource : TerraformDataSource
{
    public AwsRedshiftClusterCredentialsDataSource(string name) : base("aws_redshift_cluster_credentials", name)
    {
    }

    /// <summary>
    /// The auto_create attribute.
    /// </summary>
    [TerraformProperty("auto_create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AutoCreate { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The db_groups attribute.
    /// </summary>
    [TerraformProperty("db_groups")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DbGroups { get; set; }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DbName { get; set; }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbUser is required")]
    [TerraformProperty("db_user")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DbUser { get; set; }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformProperty("duration_seconds")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? DurationSeconds { get; set; }

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
    /// The db_password attribute.
    /// </summary>
    [TerraformProperty("db_password")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DbPassword { get; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Expiration { get; }

}
