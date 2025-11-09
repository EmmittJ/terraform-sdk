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
    public TerraformProperty<string>? CalculatorName
    {
        get => GetProperty<TerraformProperty<string>>("calculator_name");
        set => this.WithProperty("calculator_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
