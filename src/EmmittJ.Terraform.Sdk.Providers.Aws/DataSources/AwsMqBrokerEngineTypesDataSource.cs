using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_mq_broker_engine_types.
/// </summary>
public class AwsMqBrokerEngineTypesDataSource : TerraformDataSource
{
    public AwsMqBrokerEngineTypesDataSource(string name) : base("aws_mq_broker_engine_types", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("broker_engine_types");
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EngineType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("engine_type");
        set => this.WithProperty("engine_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The broker_engine_types attribute.
    /// </summary>
    public TerraformExpression BrokerEngineTypes => this["broker_engine_types"];

}
