using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker_engine_types.
/// </summary>
public class AwsMqBrokerEngineTypesDataSource : TerraformDataSource
{
    public AwsMqBrokerEngineTypesDataSource(string name) : base("aws_mq_broker_engine_types", name)
    {
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    [TerraformPropertyName("engine_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EngineType { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The broker_engine_types attribute.
    /// </summary>
    [TerraformPropertyName("broker_engine_types")]
    // Output-only attribute - read-only reference
    public TerraformList<object> BrokerEngineTypes => new TerraformReference(this, "broker_engine_types");

}
