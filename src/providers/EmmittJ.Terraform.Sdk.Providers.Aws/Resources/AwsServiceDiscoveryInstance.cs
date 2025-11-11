using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_service_discovery_instance resource.
/// </summary>
public partial class AwsServiceDiscoveryInstance : TerraformResource
{
    public AwsServiceDiscoveryInstance(string name) : base("aws_service_discovery_instance", name)
    {
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Attributes is required")]
    [TerraformProperty("attributes")]
    // Required argument - source generator will implement get/set
    public required TerraformMap<string> Attributes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    [TerraformProperty("instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> InstanceId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceId is required")]
    [TerraformProperty("service_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceId { get; set; }

}
