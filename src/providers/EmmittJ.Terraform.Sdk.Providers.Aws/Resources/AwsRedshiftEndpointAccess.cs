using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_endpoint_access resource.
/// </summary>
public partial class AwsRedshiftEndpointAccess : TerraformResource
{
    public AwsRedshiftEndpointAccess(string name) : base("aws_redshift_endpoint_access", name)
    {
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    [TerraformProperty("cluster_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterIdentifier { get; set; }

    /// <summary>
    /// The endpoint_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointName is required")]
    [TerraformProperty("endpoint_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EndpointName { get; set; }

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
    /// The resource_owner attribute.
    /// </summary>
    [TerraformProperty("resource_owner")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceOwner { get; set; }

    /// <summary>
    /// The subnet_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetGroupName is required")]
    [TerraformProperty("subnet_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SubnetGroupName { get; set; }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    [TerraformProperty("vpc_security_group_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> VpcSecurityGroupIds { get; set; }

    /// <summary>
    /// The address attribute.
    /// </summary>
    [TerraformProperty("address")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Address { get; }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [TerraformProperty("port")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Port { get; }

    /// <summary>
    /// The vpc_endpoint attribute.
    /// </summary>
    [TerraformProperty("vpc_endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> VpcEndpoint { get; }

}
