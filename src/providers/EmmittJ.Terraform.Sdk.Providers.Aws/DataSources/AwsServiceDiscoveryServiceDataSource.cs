using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service_discovery_service.
/// </summary>
public partial class AwsServiceDiscoveryServiceDataSource : TerraformDataSource
{
    public AwsServiceDiscoveryServiceDataSource(string name) : base("aws_service_discovery_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The namespace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceId is required")]
    [TerraformProperty("namespace_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> NamespaceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Description { get; }

    /// <summary>
    /// The dns_config attribute.
    /// </summary>
    [TerraformProperty("dns_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> DnsConfig { get; }

    /// <summary>
    /// The health_check_config attribute.
    /// </summary>
    [TerraformProperty("health_check_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthCheckConfig { get; }

    /// <summary>
    /// The health_check_custom_config attribute.
    /// </summary>
    [TerraformProperty("health_check_custom_config")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> HealthCheckCustomConfig { get; }

}
