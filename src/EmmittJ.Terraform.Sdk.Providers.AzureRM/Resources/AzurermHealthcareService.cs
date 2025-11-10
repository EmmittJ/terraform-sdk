using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authentication_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The audience attribute.
    /// </summary>
    public TerraformProperty<string>? Audience
    {
        get => GetProperty<TerraformProperty<string>>("audience");
        set => WithProperty("audience", value);
    }

    /// <summary>
    /// The authority attribute.
    /// </summary>
    public TerraformProperty<string>? Authority
    {
        get => GetProperty<TerraformProperty<string>>("authority");
        set => WithProperty("authority", value);
    }

    /// <summary>
    /// The smart_proxy_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SmartProxyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("smart_proxy_enabled");
        set => WithProperty("smart_proxy_enabled", value);
    }

}

/// <summary>
/// Block type for cors_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceCorsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The allow_credentials attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowCredentials
    {
        get => GetProperty<TerraformProperty<bool>>("allow_credentials");
        set => WithProperty("allow_credentials", value);
    }

    /// <summary>
    /// The allowed_headers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedHeaders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_headers");
        set => WithProperty("allowed_headers", value);
    }

    /// <summary>
    /// The allowed_methods attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AllowedMethods
    {
        get => GetProperty<List<TerraformProperty<string>>>("allowed_methods");
        set => WithProperty("allowed_methods", value);
    }

    /// <summary>
    /// The allowed_origins attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedOrigins
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_origins");
        set => WithProperty("allowed_origins", value);
    }

    /// <summary>
    /// The max_age_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? MaxAgeInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("max_age_in_seconds");
        set => WithProperty("max_age_in_seconds", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermHealthcareServiceIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_healthcare_service resource.
/// </summary>
public class AzurermHealthcareService : TerraformResource
{
    public AzurermHealthcareService(string name) : base("azurerm_healthcare_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AccessPolicyObjectIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("access_policy_object_ids");
        set => this.WithProperty("access_policy_object_ids", value);
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationExportStorageAccountName
    {
        get => GetProperty<TerraformProperty<string>>("configuration_export_storage_account_name");
        set => this.WithProperty("configuration_export_storage_account_name", value);
    }

    /// <summary>
    /// The cosmosdb_key_vault_key_versionless_id attribute.
    /// </summary>
    public TerraformProperty<string>? CosmosdbKeyVaultKeyVersionlessId
    {
        get => GetProperty<TerraformProperty<string>>("cosmosdb_key_vault_key_versionless_id");
        set => this.WithProperty("cosmosdb_key_vault_key_versionless_id", value);
    }

    /// <summary>
    /// The cosmosdb_throughput attribute.
    /// </summary>
    public TerraformProperty<double>? CosmosdbThroughput
    {
        get => GetProperty<TerraformProperty<double>>("cosmosdb_throughput");
        set => this.WithProperty("cosmosdb_throughput", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// Block for authentication_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public List<AzurermHealthcareServiceAuthenticationConfigurationBlock>? AuthenticationConfiguration
    {
        get => GetProperty<List<AzurermHealthcareServiceAuthenticationConfigurationBlock>>("authentication_configuration");
        set => this.WithProperty("authentication_configuration", value);
    }

    /// <summary>
    /// Block for cors_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CorsConfiguration block(s) allowed")]
    public List<AzurermHealthcareServiceCorsConfigurationBlock>? CorsConfiguration
    {
        get => GetProperty<List<AzurermHealthcareServiceCorsConfigurationBlock>>("cors_configuration");
        set => this.WithProperty("cors_configuration", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermHealthcareServiceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermHealthcareServiceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHealthcareServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHealthcareServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
