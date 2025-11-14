using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_healthcare_service.
/// </summary>
public class AzurermHealthcareServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareServiceDataSource(string name) : base("azurerm_healthcare_service", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareServiceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformArgument("access_policy_object_ids")]
    public TerraformSet<string> AccessPolicyObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "access_policy_object_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    [TerraformArgument("authentication_configuration")]
    public TerraformList<object> AuthenticationConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "authentication_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    [TerraformArgument("cors_configuration")]
    public TerraformList<object> CorsConfiguration
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "cors_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_key_vault_key_versionless_id")]
    public TerraformValue<string> CosmosdbKeyVaultKeyVersionlessId
    {
        get => new TerraformReference<string>(this, "cosmosdb_key_vault_key_versionless_id");
    }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_throughput")]
    public TerraformValue<double> CosmosdbThroughput
    {
        get => new TerraformReference<double>(this, "cosmosdb_throughput");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}
