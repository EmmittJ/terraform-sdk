using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_location_route_calculator.
/// </summary>
public class AwsLocationRouteCalculatorDataSource : TerraformDataSource
{
    public AwsLocationRouteCalculatorDataSource(string name) : base("aws_location_route_calculator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("calculator_arn");
        this.DeclareOutput("create_time");
        this.DeclareOutput("data_source");
        this.DeclareOutput("description");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The calculator_name attribute.
    /// </summary>
    public string? CalculatorName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("calculator_name")?.Value;
        set => this.WithProperty("calculator_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The calculator_arn attribute.
    /// </summary>
    public TerraformExpression CalculatorArn => this["calculator_arn"];

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformExpression DataSource => this["data_source"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
