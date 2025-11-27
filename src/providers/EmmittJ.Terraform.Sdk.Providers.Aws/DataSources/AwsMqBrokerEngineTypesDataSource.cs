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
        get => new TerraformReference<string>(this, "engine_type");
        set => SetArgument("engine_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The broker_engine_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BrokerEngineTypes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "broker_engine_types").ResolveNodes(ctx));
    }

}
