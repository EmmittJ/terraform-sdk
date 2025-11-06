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
    /// The permissions attribute.
    /// </summary>
    public HashSet<string>? Permissions
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions")?.Value;
        set => this.WithProperty("permissions", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The permissions_with_grant_option attribute.
    /// </summary>
    public HashSet<string>? PermissionsWithGrantOption
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("permissions_with_grant_option")?.Value;
        set => this.WithProperty("permissions_with_grant_option", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
