using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHealthcareServiceDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_healthcare_service Terraform data source.
/// Retrieves information about a azurerm_healthcare_service.
/// </summary>
public partial class AzurermHealthcareServiceDataSource(string name) : TerraformDataSource("azurerm_healthcare_service", name)
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformSet<string> AccessPolicyObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "access_policy_object_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "authentication_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cors_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> CosmosdbKeyVaultKeyVersionlessId
    {
        get => new TerraformReference<string>(this, "cosmosdb_key_vault_key_versionless_id");
    }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    public TerraformValue<double> CosmosdbThroughput
    {
        get => new TerraformReference<double>(this, "cosmosdb_throughput");
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
    {
        get => new TerraformReference<string>(this, "kind");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
