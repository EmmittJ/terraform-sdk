using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_hsm_configuration resource.
/// </summary>
public partial class AwsRedshiftHsmConfiguration : TerraformResource
{
    public AwsRedshiftHsmConfiguration(string name) : base("aws_redshift_hsm_configuration", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The hsm_configuration_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmConfigurationIdentifier is required")]
    [TerraformProperty("hsm_configuration_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HsmConfigurationIdentifier { get; set; }

    /// <summary>
    /// The hsm_ip_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmIpAddress is required")]
    [TerraformProperty("hsm_ip_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HsmIpAddress { get; set; }

    /// <summary>
    /// The hsm_partition_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionName is required")]
    [TerraformProperty("hsm_partition_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HsmPartitionName { get; set; }

    /// <summary>
    /// The hsm_partition_password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmPartitionPassword is required")]
    [TerraformProperty("hsm_partition_password")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HsmPartitionPassword { get; set; }

    /// <summary>
    /// The hsm_server_public_certificate attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HsmServerPublicCertificate is required")]
    [TerraformProperty("hsm_server_public_certificate")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> HsmServerPublicCertificate { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
