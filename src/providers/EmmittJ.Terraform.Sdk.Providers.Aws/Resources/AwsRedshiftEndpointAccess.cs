using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_access resource.
/// </summary>
public class AwsRedshiftEndpointAccess : TerraformResource
{
    public AwsRedshiftEndpointAccess(string name) : base("aws_redshift_endpoint_access", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformPropertyName("cluster_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterIdentifier { get; set; }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    [TerraformPropertyName("endpoint_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EndpointName { get; set; }

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
    /// The resource_owner attribute.
    /// </summary>
    [TerraformPropertyName("resource_owner")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceOwner { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_owner");

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetGroupName is required")]
    [TerraformPropertyName("subnet_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SubnetGroupName { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformPropertyName("vpc_security_group_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> VpcSecurityGroupIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "vpc_security_group_ids");

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformPropertyName("address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Address => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "address");

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformPropertyName("port")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Port => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "port");

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("vpc_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> VpcEndpoint => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "vpc_endpoint");

}
