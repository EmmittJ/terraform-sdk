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
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_protected_settings attribute.
    /// </summary>
    public Dictionary<string, string>? ConfigurationProtectedSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configuration_protected_settings")?.Value;
        set => this.WithProperty("configuration_protected_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The configuration_settings attribute.
    /// </summary>
    public Dictionary<string, string>? ConfigurationSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("configuration_settings")?.Value;
        set => this.WithProperty("configuration_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The extension_type attribute.
    /// </summary>
    public string? ExtensionType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("extension_type")?.Value;
        set => this.WithProperty("extension_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_namespace attribute.
    /// </summary>
    public string? ReleaseNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_namespace")?.Value;
        set => this.WithProperty("release_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_train attribute.
    /// </summary>
    public string? ReleaseTrain
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_train")?.Value;
        set => this.WithProperty("release_train", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_namespace attribute.
    /// </summary>
    public string? TargetNamespace
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_namespace")?.Value;
        set => this.WithProperty("target_namespace", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The current_version attribute.
    /// </summary>
    public TerraformExpression CurrentVersion => this["current_version"];

}
