using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for module in AzurermRedisEnterpriseDatabase.
/// Nesting mode: list
/// </summary>
public class AzurermRedisEnterpriseDatabaseModuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "module";

    /// <summary>
    /// The args attribute.
    /// </summary>
    public TerraformValue<string>? Args
    {
        get => new TerraformReference<string>(this, "args");
        set => SetArgument("args", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

}


/// <summary>
/// Block type for timeouts in AzurermRedisEnterpriseDatabase.
/// Nesting mode: single
/// </summary>
public class AzurermRedisEnterpriseDatabaseTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_redis_enterprise_database Terraform resource.
/// Manages a azurerm_redis_enterprise_database resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermRedisEnterpriseDatabase(string name) : TerraformResource("azurerm_redis_enterprise_database", name)
{
    /// <summary>
    /// The client_protocol attribute.
    /// </summary>
    public TerraformValue<string>? ClientProtocol
    {
        get => new TerraformReference<string>(this, "client_protocol");
        set => SetArgument("client_protocol", value);
    }

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
    /// The clustering_policy attribute.
    /// </summary>
    public TerraformValue<string>? ClusteringPolicy
    {
        get => new TerraformReference<string>(this, "clustering_policy");
        set => SetArgument("clustering_policy", value);
    }

    /// <summary>
    /// The eviction_policy attribute.
    /// </summary>
    public TerraformValue<string>? EvictionPolicy
    {
        get => new TerraformReference<string>(this, "eviction_policy");
        set => SetArgument("eviction_policy", value);
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
    /// The linked_database_group_nickname attribute.
    /// </summary>
    public TerraformValue<string>? LinkedDatabaseGroupNickname
    {
        get => new TerraformReference<string>(this, "linked_database_group_nickname");
        set => SetArgument("linked_database_group_nickname", value);
    }

    /// <summary>
    /// The linked_database_id attribute.
    /// </summary>
    public TerraformSet<string>? LinkedDatabaseId
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "linked_database_id").ResolveNodes(ctx));
        set => SetArgument("linked_database_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double>? Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// Module block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(4, ErrorMessage = "Maximum 4 Module block(s) allowed")]
    public TerraformList<AzurermRedisEnterpriseDatabaseModuleBlock>? Module
    {
        get => GetArgument<TerraformList<AzurermRedisEnterpriseDatabaseModuleBlock>>("module");
        set => SetArgument("module", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermRedisEnterpriseDatabaseTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermRedisEnterpriseDatabaseTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
