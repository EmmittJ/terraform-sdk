using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_db_proxy_target resource.
/// </summary>
public class AwsDbProxyTarget : TerraformResource
{
    public AwsDbProxyTarget(string name) : base("aws_db_proxy_target", name)
    {
    }

    /// <summary>
    /// The db_cluster_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_cluster_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbClusterIdentifier { get; set; }

    /// <summary>
    /// The db_instance_identifier attribute.
    /// </summary>
    [TerraformPropertyName("db_instance_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DbInstanceIdentifier { get; set; }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    [TerraformPropertyName("db_proxy_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DbProxyName { get; set; }

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
    /// The target_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetGroupName is required")]
    [TerraformPropertyName("target_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TargetGroupName { get; set; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Endpoint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "endpoint");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The rds_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("rds_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RdsResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "rds_resource_id");

    /// <summary>
    /// The target_arn attribute.
    /// </summary>
    [TerraformPropertyName("target_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TargetArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "target_arn");

    /// <summary>
    /// The tracked_cluster_id attribute.
    /// </summary>
    [TerraformPropertyName("tracked_cluster_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TrackedClusterId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tracked_cluster_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
