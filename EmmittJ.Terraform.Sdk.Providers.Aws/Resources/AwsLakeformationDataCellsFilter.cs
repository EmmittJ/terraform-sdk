using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_data_cells_filter resource.
/// </summary>
public class AwsLakeformationDataCellsFilter : TerraformResource
{
    public AwsLakeformationDataCellsFilter(string name) : base("aws_lakeformation_data_cells_filter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
