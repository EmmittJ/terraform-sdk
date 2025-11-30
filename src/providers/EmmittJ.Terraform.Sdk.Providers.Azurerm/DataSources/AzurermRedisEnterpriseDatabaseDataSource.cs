using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermRedisEnterpriseDatabaseDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_redis_enterprise_database Terraform data source.
/// Retrieves information about a azurerm_redis_enterprise_database.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermRedisEnterpriseDatabaseDataSource(string name) : TerraformDataSource("azurerm_redis_enterprise_database", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public TerraformValue<string> LinkedDatabaseGroupNickname
    {
        get => new TerraformReference<string>(this, "linked_database_group_nickname");
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public TerraformList<string> LinkedDatabaseId
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "linked_database_id").ResolveNodes(ctx));
    }

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformValue<string> PrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "primary_access_key");
    }

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformValue<string> SecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "secondary_access_key");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisEnterpriseDatabaseDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
