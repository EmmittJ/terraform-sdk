using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_healthcare_fhir_service resource.
/// </summary>
public class AzurermHealthcareFhirService : TerraformResource
{
    public AzurermHealthcareFhirService(string name) : base("azurerm_healthcare_fhir_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("public_network_access_enabled");
    }

    /// <summary>
    /// The access_policy_object_ids attribute.
    /// </summary>
    public HashSet<string>? AccessPolicyObjectIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("access_policy_object_ids")?.Value;
        set => this.WithProperty("access_policy_object_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public string? ConfigurationExportStorageAccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_export_storage_account_name")?.Value;
        set => this.WithProperty("configuration_export_storage_account_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public HashSet<string>? ContainerRegistryLoginServerUrl
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("container_registry_login_server_url")?.Value;
        set => this.WithProperty("container_registry_login_server_url", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public string? WorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("workspace_id")?.Value;
        set => this.WithProperty("workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

}
