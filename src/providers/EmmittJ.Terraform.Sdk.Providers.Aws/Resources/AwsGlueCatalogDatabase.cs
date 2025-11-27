using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for create_table_default_permission in AwsGlueCatalogDatabase.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "create_table_default_permission";

    /// <summary>
    /// The permissions attribute.
    /// </summary>
    public TerraformSet<string>? Permissions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "permissions").ResolveNodes(ctx));
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Principal block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Principal block(s) allowed")]
    public TerraformList<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlockPrincipalBlock>? Principal
    {
        get => GetArgument<TerraformList<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlockPrincipalBlock>>("principal");
        set => SetArgument("principal", value);
    }

}

/// <summary>
/// Block type for principal in AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlockPrincipalBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "principal";

    /// <summary>
    /// The data_lake_principal_identifier attribute.
    /// </summary>
    public TerraformValue<string>? DataLakePrincipalIdentifier
    {
        get => new TerraformReference<string>(this, "data_lake_principal_identifier");
        set => SetArgument("data_lake_principal_identifier", value);
    }

}


/// <summary>
/// Block type for federated_database in AwsGlueCatalogDatabase.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseFederatedDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "federated_database";

    /// <summary>
    /// The connection_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionName
    {
        get => new TerraformReference<string>(this, "connection_name");
        set => SetArgument("connection_name", value);
    }

    /// <summary>
    /// The identifier attribute.
    /// </summary>
    public TerraformValue<string>? Identifier
    {
        get => new TerraformReference<string>(this, "identifier");
        set => SetArgument("identifier", value);
    }

}


/// <summary>
/// Block type for target_database in AwsGlueCatalogDatabase.
/// Nesting mode: list
/// </summary>
public class AwsGlueCatalogDatabaseTargetDatabaseBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_database";

    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CatalogId is required")]
    public required TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => new TerraformReference<string>(this, "database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

}


/// <summary>
/// Represents a aws_glue_catalog_database Terraform resource.
/// Manages a aws_glue_catalog_database resource.
/// </summary>
public partial class AwsGlueCatalogDatabase(string name) : TerraformResource("aws_glue_catalog_database", name)
{
    /// <summary>
    /// The catalog_id attribute.
    /// </summary>
    public TerraformValue<string> CatalogId
    {
        get => new TerraformReference<string>(this, "catalog_id");
        set => SetArgument("catalog_id", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    public TerraformValue<string> LocationUri
    {
        get => new TerraformReference<string>(this, "location_uri");
        set => SetArgument("location_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public TerraformMap<string>? Parameters
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "parameters").ResolveNodes(ctx));
        set => SetArgument("parameters", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// CreateTableDefaultPermission block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>? CreateTableDefaultPermission
    {
        get => GetArgument<TerraformList<AwsGlueCatalogDatabaseCreateTableDefaultPermissionBlock>>("create_table_default_permission");
        set => SetArgument("create_table_default_permission", value);
    }

    /// <summary>
    /// FederatedDatabase block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FederatedDatabase block(s) allowed")]
    public TerraformList<AwsGlueCatalogDatabaseFederatedDatabaseBlock>? FederatedDatabase
    {
        get => GetArgument<TerraformList<AwsGlueCatalogDatabaseFederatedDatabaseBlock>>("federated_database");
        set => SetArgument("federated_database", value);
    }

    /// <summary>
    /// TargetDatabase block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetDatabase block(s) allowed")]
    public TerraformList<AwsGlueCatalogDatabaseTargetDatabaseBlock>? TargetDatabase
    {
        get => GetArgument<TerraformList<AwsGlueCatalogDatabaseTargetDatabaseBlock>>("target_database");
        set => SetArgument("target_database", value);
    }

}
