using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_authorization resource.
/// </summary>
public partial class AwsRedshiftEndpointAuthorization : TerraformResource
{
    public AwsRedshiftEndpointAuthorization(string name) : base("aws_redshift_endpoint_authorization", name)
    {
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    [TerraformProperty("account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Account { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformProperty("force_delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceDelete { get; set; }

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
    /// The vpc_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_ids")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? VpcIds { get; set; }

    /// <summary>
    /// The allowed_all_vpcs attribute.
    /// </summary>
    [TerraformProperty("allowed_all_vpcs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> AllowedAllVpcs { get; }

    /// <summary>
    /// The endpoint_count attribute.
    /// </summary>
    [TerraformProperty("endpoint_count")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EndpointCount { get; }

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformProperty("grantee")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Grantee { get; }

    /// <summary>
    /// The grantor attribute.
    /// </summary>
    [TerraformProperty("grantor")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Grantor { get; }

}
