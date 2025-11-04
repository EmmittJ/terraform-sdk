using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker_instance_type_offerings.
/// </summary>
public class AwsMqBrokerInstanceTypeOfferingsDataSource : TerraformDataSource
{
    public AwsMqBrokerInstanceTypeOfferingsDataSource(string name) : base("aws_mq_broker_instance_type_offerings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("broker_instance_options");
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public string? EngineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_type")?.Value;
        set => this.WithProperty("engine_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_instance_type attribute.
    /// </summary>
    public string? HostInstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_instance_type")?.Value;
        set => this.WithProperty("host_instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public string? StorageType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_type")?.Value;
        set => this.WithProperty("storage_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The broker_instance_options attribute.
    /// </summary>
    public TerraformExpression BrokerInstanceOptions => this["broker_instance_options"];

}
