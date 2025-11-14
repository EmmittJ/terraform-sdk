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
/// Block type for authentication_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_configuration";

    /// <summary>
    /// The audience attribute.
    /// </summary>
    [TerraformArgument("audience")]
    public TerraformValue<string>? Audience
    {
        get => new TerraformReference<string>(this, "audience");
        set => SetArgument("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    [TerraformArgument("authority")]
    public TerraformValue<string>? Authority
    {
        get => new TerraformReference<string>(this, "authority");
        set => SetArgument("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    [TerraformArgument("smart_proxy_enabled")]
    public TerraformValue<bool>? SmartProxyEnabled
    {
        get => new TerraformReference<bool>(this, "smart_proxy_enabled");
        set => SetArgument("smart_proxy_enabled", value);
    }

}

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceCorsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cors_configuration";

    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    [TerraformArgument("allow_credentials")]
    public TerraformValue<bool>? AllowCredentials
    {
        get => new TerraformReference<bool>(this, "allow_credentials");
        set => SetArgument("allow_credentials", value);
    }

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    [TerraformArgument("allowed_headers")]
    public TerraformSet<string>? AllowedHeaders
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_headers").ResolveNodes(ctx));
        set => SetArgument("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    [TerraformArgument("allowed_methods")]
    public TerraformList<string>? AllowedMethods
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "allowed_methods").ResolveNodes(ctx));
        set => SetArgument("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    [TerraformArgument("allowed_origins")]
    public TerraformSet<string>? AllowedOrigins
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_origins").ResolveNodes(ctx));
        set => SetArgument("allowed_origins", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    [TerraformArgument("max_age_in_seconds")]
    public TerraformValue<double>? MaxAgeInSeconds
    {
        get => new TerraformReference<double>(this, "max_age_in_seconds");
        set => SetArgument("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_healthcare_service resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHealthcareService : TerraformResource
{
    public AzurermHealthcareService(string name) : base("azurerm_healthcare_service", name)
    {
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    [TerraformArgument("access_policy_object_ids")]
    public TerraformSet<string>? AccessPolicyObjectIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "access_policy_object_ids").ResolveNodes(ctx));
        set => SetArgument("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    [TerraformArgument("configuration_export_storage_account_name")]
    public TerraformValue<string>? ConfigurationExportStorageAccountName
    {
        get => new TerraformReference<string>(this, "configuration_export_storage_account_name");
        set => SetArgument("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_key_vault_key_versionless_id")]
    public TerraformValue<string>? CosmosdbKeyVaultKeyVersionlessId
    {
        get => new TerraformReference<string>(this, "cosmosdb_key_vault_key_versionless_id");
        set => SetArgument("cosmosdb_key_vault_key_versionless_id", value);
    }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    [TerraformArgument("cosmosdb_throughput")]
    public TerraformValue<double>? CosmosdbThroughput
    {
        get => new TerraformReference<double>(this, "cosmosdb_throughput");
        set => SetArgument("cosmosdb_throughput", value);
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
    /// The kind attribute.
    /// </summary>
    [TerraformArgument("kind")]
    public TerraformValue<string>? Kind
    {
        get => new TerraformReference<string>(this, "kind");
        set => SetArgument("kind", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for authentication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    [TerraformArgument("authentication_configuration")]
    public TerraformList<AzurermHealthcareServiceAuthenticationConfigurationBlock> AuthenticationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    [TerraformArgument("cors_configuration")]
    public TerraformList<AzurermHealthcareServiceCorsConfigurationBlock> CorsConfiguration { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermHealthcareServiceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHealthcareServiceTimeoutsBlock Timeouts { get; set; } = new();

}
