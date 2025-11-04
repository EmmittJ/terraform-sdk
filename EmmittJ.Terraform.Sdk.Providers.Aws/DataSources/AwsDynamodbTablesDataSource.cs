using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_dynamodb_tables.
/// </summary>
public class AwsDynamodbTablesDataSource : TerraformDataSource
{
    public AwsDynamodbTablesDataSource(string name) : base("aws_dynamodb_tables", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("names");
    }

    /// <summary>
    /// The names attribute.
    /// </summary>
    public TerraformExpression Names => this["names"];

}
