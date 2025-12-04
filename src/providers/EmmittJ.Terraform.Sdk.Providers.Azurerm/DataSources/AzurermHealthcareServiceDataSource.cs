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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformSet<string> AccessPolicyObjectIds
        => AsReference("access_policy_object_ids");

    /// <summary>
    /// The authentication_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AuthenticationConfiguration
        => AsReference("authentication_configuration");

    /// <summary>
    /// The cors_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CorsConfiguration
        => AsReference("cors_configuration");

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> CosmosdbKeyVaultKeyVersionlessId
        => AsReference("cosmosdb_key_vault_key_versionless_id");

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    public TerraformValue<double> CosmosdbThroughput
        => AsReference("cosmosdb_throughput");

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformValue<string> Kind
        => AsReference("kind");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHealthcareServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHealthcareServiceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
