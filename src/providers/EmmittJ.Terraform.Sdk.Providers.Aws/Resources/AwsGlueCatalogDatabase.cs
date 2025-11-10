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
        set => SetProperty("permissions", value);
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
        set => SetProperty("connection_name", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformProperty<string>? Identifier
    {
        set => SetProperty("identifier", value);
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
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        set => SetProperty("region", value);
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
        SetOutput("arn");
        SetOutput("catalog_id");
        SetOutput("description");
        SetOutput("id");
        SetOutput("location_uri");
        SetOutput("name");
        SetOutput("parameters");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformProperty<string> CatalogId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("catalog_id");
        set => SetProperty("catalog_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    public TerraformProperty<string> LocationUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location_uri");
        set => SetProperty("location_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for create_table_default_permission.
    /// Nesting mode: list
    /// </summary>
    public List<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>? CreateTableDefaultPermission
    {
        set => SetProperty("create_table_default_permission", value);
    }

    /// <summary>
    /// Block for federated_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FederatedDatabase block(s) allowed")]
    public List<AwsGlueCatalogDatabaseFederatedDatabaseBlock>? FederatedDatabase
    {
        set => SetProperty("federated_database", value);
    }

    /// <summary>
    /// Block for target_database.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetDatabase block(s) allowed")]
    public List<AwsGlueCatalogDatabaseTargetDatabaseBlock>? TargetDatabase
    {
        set => SetProperty("target_database", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
