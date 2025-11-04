using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_athena_named_query.
/// </summary>
public class AwsAthenaNamedQueryDataSource : TerraformDataSource
{
    public AwsAthenaNamedQueryDataSource(string name) : base("aws_athena_named_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("database");
        this.DeclareOutput("description");
        this.DeclareOutput("querystring");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workgroup attribute.
    /// </summary>
    public string? Workgroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup")?.Value;
        set => this.WithProperty("workgroup", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public TerraformExpression Database => this["database"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The querystring attribute.
    /// </summary>
    public TerraformExpression Querystring => this["querystring"];

}
