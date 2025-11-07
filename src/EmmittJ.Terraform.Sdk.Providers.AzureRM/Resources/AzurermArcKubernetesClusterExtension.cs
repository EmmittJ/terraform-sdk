using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_arc_kubernetes_cluster_extension resource.
/// </summary>
public class AzurermArcKubernetesClusterExtension : TerraformResource
{
    public AzurermArcKubernetesClusterExtension(string name) : base("azurerm_arc_kubernetes_cluster_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("current_version");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ConfigurationProtectedSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configuration_protected_settings");
        set => this.WithProperty("configuration_protected_settings", value);
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? ConfigurationSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configuration_settings");
        set => this.WithProperty("configuration_settings", value);
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ExtensionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extension_type");
        set => this.WithProperty("extension_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The release_namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_namespace");
        set => this.WithProperty("release_namespace", value);
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ReleaseTrain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_train");
        set => this.WithProperty("release_train", value);
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_namespace");
        set => this.WithProperty("target_namespace", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

}
