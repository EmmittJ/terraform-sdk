using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lakeformation_permissions.
/// </summary>
public class AwsLakeformationPermissionsDataSource : TerraformDataSource
{
    public AwsLakeformationPermissionsDataSource(string name) : base("aws_lakeformation_permissions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("permissions");
        this.DeclareOutput("permissions_with_grant_option");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public string? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id")?.Value;
        set => this.WithProperty("catalog_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The catalog_resource attribute.
    /// </summary>
    public bool? CatalogResource
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("catalog_resource")?.Value;
        set => this.WithProperty("catalog_resource", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The principal attribute.
    /// </summary>
    public string? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal")?.Value;
        set => this.WithProperty("principal", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public TerraformExpression PermissionsWithGrantOption => this["permissions_with_grant_option"];

}
