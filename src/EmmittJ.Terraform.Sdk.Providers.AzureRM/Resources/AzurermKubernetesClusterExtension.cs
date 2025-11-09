using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_kubernetes_cluster_extension resource.
/// </summary>
public class AzurermKubernetesClusterExtension : TerraformResource
{
    public AzurermKubernetesClusterExtension(string name) : base("azurerm_kubernetes_cluster_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aks_assigned_identity");
        this.DeclareOutput("current_version");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public TerraformMapProperty<string>? ConfigurationProtectedSettings
    {
        get => GetProperty<TerraformMapProperty<string>>("configuration_protected_settings");
        set => this.WithProperty("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public TerraformMapProperty<string>? ConfigurationSettings
    {
        get => GetProperty<TerraformMapProperty<string>>("configuration_settings");
        set => this.WithProperty("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    public TerraformProperty<string>? ExtensionType
    {
        get => GetProperty<TerraformProperty<string>>("extension_type");
        set => this.WithProperty("extension_type", value);
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
    /// The release_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseNamespace
    {
        get => GetProperty<TerraformProperty<string>>("release_namespace");
        set => this.WithProperty("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseTrain
    {
        get => GetProperty<TerraformProperty<string>>("release_train");
        set => this.WithProperty("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformProperty<string>? TargetNamespace
    {
        get => GetProperty<TerraformProperty<string>>("target_namespace");
        set => this.WithProperty("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The aks_assigned_identity attribute.
    /// </summary>
    public TerraformExpression AksAssignedIdentity => this["aks_assigned_identity"];

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

}
