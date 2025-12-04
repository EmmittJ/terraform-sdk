using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_location_route_calculator Terraform data source.
/// Retrieves information about a aws_location_route_calculator.
/// </summary>
public partial class AwsLocationRouteCalculatorDataSource(string name) : TerraformDataSource("aws_location_route_calculator", name)
{
    /// <summary>
    /// The calculator_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CalculatorName is required")]
    public required TerraformValue<string> CalculatorName
    {
        get => GetArgument<TerraformValue<string>>("calculator_name");
        set => SetArgument("calculator_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The calculator_arn attribute.
    /// </summary>
    public TerraformValue<string> CalculatorArn
        => AsReference("calculator_arn");

    /// <summary>
    /// The create_time attribute.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformValue<string> DataSource
        => AsReference("data_source");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The update_time attribute.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

}
