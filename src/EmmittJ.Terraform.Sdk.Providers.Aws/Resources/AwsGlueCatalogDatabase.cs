using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_table_default_permission in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock : TerraformBlock
{
    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Permissions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("permissions");
        set => WithProperty("permissions", value);
    }

}

/// <summary>
/// Block type for federated_database in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseFederatedDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionName
    {
        get => GetProperty<TerraformProperty<string>>("connection_name");
        set => WithProperty("connection_name", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        get => GetProperty<TerraformProperty<string>>("identifier");
        set => WithProperty("identifier", value);
    }

}

/// <summary>
/// Block type for target_database in .
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseTargetDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformProperty<string> CatalogId
    {
        get => GetProperty<TerraformProperty<string>>("catalog_id");
        set => WithProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetProperty<TerraformProperty<string>>("database_name");
        set => WithProperty("database_name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => WithProperty("region", value);
    }

}

/// <summary>
/// Manages a aws_glue_catalog_database resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlueCatalogDatabase : TerraformResource
{
    public AwsGlueCatalogDatabase(string name) : base("aws_glue_catalog_database", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location_uri attribute.
    /// </summary>
    public TerraformProperty<string>? LocationUri
    {
        get => GetProperty<TerraformProperty<string>>("location_uri");
        set => this.WithProperty("location_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Parameters
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => this.WithProperty("parameters", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for create_table_default_permission.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>? CreateTableDefaultPermission
    {
        get => GetProperty<List<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>>("create_table_default_permission");
        set => this.WithProperty("create_table_default_permission", value);
    }

    /// <summary>
    /// Block for federated_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FederatedDatabase block(s) allowed")]
    public List<AwsGlueCatalogDatabaseFederatedDatabaseBlock>? FederatedDatabase
    {
        get => GetProperty<List<AwsGlueCatalogDatabaseFederatedDatabaseBlock>>("federated_database");
        set => this.WithProperty("federated_database", value);
    }

    /// <summary>
    /// Block for target_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetDatabase block(s) allowed")]
    public List<AwsGlueCatalogDatabaseTargetDatabaseBlock>? TargetDatabase
    {
        get => GetProperty<List<AwsGlueCatalogDatabaseTargetDatabaseBlock>>("target_database");
        set => this.WithProperty("target_database", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
