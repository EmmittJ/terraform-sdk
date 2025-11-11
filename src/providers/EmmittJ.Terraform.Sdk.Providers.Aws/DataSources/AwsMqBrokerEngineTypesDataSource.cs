using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker_engine_types.
/// </summary>
public partial class AwsMqBrokerEngineTypesDataSource : TerraformDataSource
{
    public AwsMqBrokerEngineTypesDataSource(string name) : base("aws_mq_broker_engine_types", name)
    {
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformProperty("engine_type")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EngineType { get; set; }

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
    /// The broker_engine_types attribute.
    /// </summary>
    [TerraformProperty("broker_engine_types")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> BrokerEngineTypes { get; }

}
