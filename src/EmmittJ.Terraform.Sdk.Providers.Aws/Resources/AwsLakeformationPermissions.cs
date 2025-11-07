using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_lakeformation_permissions resource.
/// </summary>
public class AwsLakeformationPermissions : TerraformResource
{
    public AwsLakeformationPermissions(string name) : base("aws_lakeformation_permissions", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CatalogId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("catalog_id");
        set => this.WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The catalog_resource attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CatalogResource
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("catalog_resource");
        set => this.WithProperty("catalog_resource", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? PermissionsWithGrantOption
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions_with_grant_option");
        set => this.WithProperty("permissions_with_grant_option", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Principal
    {
        get => GetProperty<TerraformLiteralProperty<string>>("principal");
        set => this.WithProperty("principal", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

}
