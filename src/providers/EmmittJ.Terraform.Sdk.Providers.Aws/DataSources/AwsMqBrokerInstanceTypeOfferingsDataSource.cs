using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_mq_broker_instance_type_offerings Terraform data source.
/// Retrieves information about a aws_mq_broker_instance_type_offerings.
/// </summary>
public partial class AwsMqBrokerInstanceTypeOfferingsDataSource(string name) : TerraformDataSource("aws_mq_broker_instance_type_offerings", name)
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
    /// The host_instance_type attribute.
    /// </summary>
    public TerraformValue<string>? HostInstanceType
    {
        get => new TerraformReference<string>(this, "host_instance_type");
        set => SetArgument("host_instance_type", value);
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
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string>? StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
        set => SetArgument("storage_type", value);
    }

    /// <summary>
    /// The broker_instance_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> BrokerInstanceOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "broker_instance_options").ResolveNodes(ctx));
    }

}
