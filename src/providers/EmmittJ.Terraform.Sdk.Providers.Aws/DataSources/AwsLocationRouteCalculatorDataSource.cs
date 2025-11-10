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
        SetOutput("calculator_arn");
        SetOutput("create_time");
        SetOutput("data_source");
        SetOutput("description");
        SetOutput("update_time");
        SetOutput("calculator_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The calculator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CalculatorName is required")]
    public required TerraformProperty<string> CalculatorName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("calculator_name");
        set => SetProperty("calculator_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
