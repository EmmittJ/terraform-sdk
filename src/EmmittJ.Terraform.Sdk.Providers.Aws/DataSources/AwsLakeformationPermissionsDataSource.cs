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
    public TerraformProperty<string>? CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The catalog_resource attribute.
    /// </summary>
    public TerraformProperty<bool>? CatalogResource
    {
        get => GetProperty<TerraformProperty<bool>>("catalog_resource");
        set => this.WithProperty("catalog_resource", value);
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
    /// The principal attribute.
    /// </summary>
    public TerraformProperty<string>? Principal
    {
        get => GetProperty<TerraformProperty<string>>("principal");
        set => this.WithProperty("principal", value);
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
    /// The permissions attribute.
    /// </summary>
    public TerraformExpression Permissions => this["permissions"];

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public TerraformExpression PermissionsWithGrantOption => this["permissions_with_grant_option"];

}
