using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHealthcareFhirServiceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("access_policy_object_ids");
        this.WithOutput("authentication");
        this.WithOutput("configuration_export_storage_account_name");
        this.WithOutput("container_registry_login_server_url");
        this.WithOutput("cors");
        this.WithOutput("identity");
        this.WithOutput("kind");
        this.WithOutput("location");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformProperty<string> WorkspaceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("workspace_id");
        set => this.WithProperty("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHealthcareFhirServiceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHealthcareFhirServiceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
