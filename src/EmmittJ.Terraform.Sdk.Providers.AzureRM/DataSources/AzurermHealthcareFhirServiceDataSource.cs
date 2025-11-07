using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_healthcare_fhir_service.
/// </summary>
public class AzurermHealthcareFhirServiceDataSource : TerraformDataSource
{
    public AzurermHealthcareFhirServiceDataSource(string name) : base("azurerm_healthcare_fhir_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policy_object_ids");
        this.DeclareOutput("authentication");
        this.DeclareOutput("configuration_export_storage_account_name");
        this.DeclareOutput("container_registry_login_server_url");
        this.DeclareOutput("cors");
        this.DeclareOutput("identity");
        this.DeclareOutput("kind");
        this.DeclareOutput("location");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
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
    /// The access_policy_object_ids attribute.
    /// </summary>
    public TerraformExpression AccessPolicyObjectIds => this["access_policy_object_ids"];

    /// <summary>
    /// The authentication attribute.
    /// </summary>
    public TerraformExpression Authentication => this["authentication"];

    /// <summary>
    /// The configuration_export_storage_account_name attribute.
    /// </summary>
    public TerraformExpression ConfigurationExportStorageAccountName => this["configuration_export_storage_account_name"];

    /// <summary>
    /// The container_registry_login_server_url attribute.
    /// </summary>
    public TerraformExpression ContainerRegistryLoginServerUrl => this["container_registry_login_server_url"];

    /// <summary>
    /// The cors attribute.
    /// </summary>
    public TerraformExpression Cors => this["cors"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

}
