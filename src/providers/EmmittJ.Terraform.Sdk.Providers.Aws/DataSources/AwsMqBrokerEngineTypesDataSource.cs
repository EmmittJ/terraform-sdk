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
        SetOutput("broker_engine_types");
        SetOutput("engine_type");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The engine_type attribute.
    /// </summary>
    public TerraformProperty<string> EngineType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_type");
        set => SetProperty("engine_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The broker_engine_types attribute.
    /// </summary>
    public TerraformExpression BrokerEngineTypes => this["broker_engine_types"];

}
