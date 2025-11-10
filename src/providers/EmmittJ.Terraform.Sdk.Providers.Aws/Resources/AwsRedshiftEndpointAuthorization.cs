using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_authorization resource.
/// </summary>
public class AwsRedshiftEndpointAuthorization : TerraformResource
{
    public AwsRedshiftEndpointAuthorization(string name) : base("aws_redshift_endpoint_authorization", name)
    {
    }

    /// <summary>
    /// The account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Account is required")]
    [TerraformPropertyName("account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Account { get; set; }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The force_delete attribute.
    /// </summary>
    [TerraformPropertyName("force_delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceDelete { get; set; }

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
    /// The vpc_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_ids")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? VpcIds { get; set; }

    /// <summary>
    /// The allowed_all_vpcs attribute.
    /// </summary>
    [TerraformPropertyName("allowed_all_vpcs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> AllowedAllVpcs => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "allowed_all_vpcs");

    /// <summary>
    /// The endpoint_count attribute.
    /// </summary>
    [TerraformPropertyName("endpoint_count")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EndpointCount => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "endpoint_count");

    /// <summary>
    /// The grantee attribute.
    /// </summary>
    [TerraformPropertyName("grantee")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Grantee => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grantee");

    /// <summary>
    /// The grantor attribute.
    /// </summary>
    [TerraformPropertyName("grantor")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Grantor => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grantor");

}
