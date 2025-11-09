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
    public TerraformProperty<HashSet<string>>? AccessPolicyObjectIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("access_policy_object_ids");
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
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ContainerRegistryLoginServerUrl
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("container_registry_login_server_url");
        set => this.WithProperty("container_registry_login_server_url", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformProperty<string>? WorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformExpression PublicNetworkAccessEnabled => this["public_network_access_enabled"];

}
