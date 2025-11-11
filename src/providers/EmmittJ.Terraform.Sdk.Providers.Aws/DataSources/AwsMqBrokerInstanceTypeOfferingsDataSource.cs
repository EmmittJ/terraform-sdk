using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker_instance_type_offerings.
/// </summary>
public partial class AwsMqBrokerInstanceTypeOfferingsDataSource : TerraformDataSource
{
    public AwsMqBrokerInstanceTypeOfferingsDataSource(string name) : base("aws_mq_broker_instance_type_offerings", name)
    {
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformProperty("engine_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EngineType { get; set; }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    [TerraformProperty("host_instance_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? HostInstanceType { get; set; }

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
    /// The storage_type attribute.
    /// </summary>
    [TerraformProperty("storage_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? StorageType { get; set; }

    /// <summary>
    /// The broker_instance_options attribute.
    /// </summary>
    [TerraformProperty("broker_instance_options")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BrokerInstanceOptions { get; }

}
