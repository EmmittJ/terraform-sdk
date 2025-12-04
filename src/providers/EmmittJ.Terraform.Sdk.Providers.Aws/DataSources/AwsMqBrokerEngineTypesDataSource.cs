using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_mq_broker_engine_types Terraform data source.
/// Retrieves information about a aws_mq_broker_engine_types.
/// </summary>
public partial class AwsMqBrokerEngineTypesDataSource(string name) : TerraformDataSource("aws_mq_broker_engine_types", name)
{
    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformValue<string>? EngineType
    {
        get => GetArgument<TerraformValue<string>>("engine_type");
        set => SetArgument("engine_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The broker_engine_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BrokerEngineTypes
        => AsReference("broker_engine_types");

}
