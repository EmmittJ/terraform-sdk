using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_msk_configuration.
/// </summary>
public partial class AwsMskConfigurationDataSource : TerraformDataSource
{
    public AwsMskConfigurationDataSource(string name) : base("aws_msk_configuration", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The kafka_versions attribute.
    /// </summary>
    [TerraformProperty("kafka_versions")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> KafkaVersions { get; }

    /// <summary>
    /// The latest_revision attribute.
    /// </summary>
    [TerraformProperty("latest_revision")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> LatestRevision { get; }

    /// <summary>
    /// The server_properties attribute.
    /// </summary>
    [TerraformProperty("server_properties")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServerProperties { get; }

}
