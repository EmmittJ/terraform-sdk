using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_athena_named_query resource.
/// </summary>
public class AwsAthenaNamedQuery : TerraformResource
{
    public AwsAthenaNamedQuery(string name) : base("aws_athena_named_query", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The database attribute.
    /// </summary>
    public string? Database
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database")?.Value;
        set => this.WithProperty("database", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The query attribute.
    /// </summary>
    public string? Query
    {
        get => GetProperty<TerraformLiteralProperty<string>>("query")?.Value;
        set => this.WithProperty("query", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The workgroup attribute.
    /// </summary>
    public string? Workgroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workgroup")?.Value;
        set => this.WithProperty("workgroup", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
