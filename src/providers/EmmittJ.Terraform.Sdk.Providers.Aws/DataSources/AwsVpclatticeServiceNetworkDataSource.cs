using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_vpclattice_service_network.
/// </summary>
public partial class AwsVpclatticeServiceNetworkDataSource : TerraformDataSource
{
    public AwsVpclatticeServiceNetworkDataSource(string name) : base("aws_vpclattice_service_network", name)
    {
    }

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
    /// The service_network_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceNetworkIdentifier is required")]
    [TerraformProperty("service_network_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceNetworkIdentifier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [TerraformProperty("auth_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AuthType { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformProperty("last_updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedAt { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The number_of_associated_services attribute.
    /// </summary>
    [TerraformProperty("number_of_associated_services")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfAssociatedServices { get; }

    /// <summary>
    /// The number_of_associated_vpcs attribute.
    /// </summary>
    [TerraformProperty("number_of_associated_vpcs")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> NumberOfAssociatedVpcs { get; }

}
