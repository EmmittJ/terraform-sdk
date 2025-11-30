using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermMssqlServerDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlServerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_mssql_server Terraform data source.
/// Retrieves information about a azurerm_mssql_server.
/// </summary>
public partial class AzurermMssqlServerDataSource(string name) : TerraformDataSource("azurerm_mssql_server", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The administrator_login attribute.
    /// </summary>
    public TerraformValue<string> AdministratorLogin
    {
        get => new TerraformReference<string>(this, "administrator_login");
    }

    /// <summary>
    /// The express_vulnerability_assessment_enabled attribute.
    /// </summary>
    public TerraformValue<bool> ExpressVulnerabilityAssessmentEnabled
    {
        get => new TerraformReference<bool>(this, "express_vulnerability_assessment_enabled");
    }

    /// <summary>
    /// The fully_qualified_domain_name attribute.
    /// </summary>
    public TerraformValue<string> FullyQualifiedDomainName
    {
        get => new TerraformReference<string>(this, "fully_qualified_domain_name");
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "identity").ResolveNodes(ctx));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The restorable_dropped_database_ids attribute.
    /// </summary>
    public TerraformList<string> RestorableDroppedDatabaseIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "restorable_dropped_database_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The transparent_data_encryption_key_vault_key_id attribute.
    /// </summary>
    public TerraformValue<string> TransparentDataEncryptionKeyVaultKeyId
    {
        get => new TerraformReference<string>(this, "transparent_data_encryption_key_vault_key_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlServerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlServerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
