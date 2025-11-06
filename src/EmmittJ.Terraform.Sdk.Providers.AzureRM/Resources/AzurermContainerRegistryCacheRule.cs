using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_container_registry_cache_rule resource.
/// </summary>
public class AzurermContainerRegistryCacheRule : TerraformResource
{
    public AzurermContainerRegistryCacheRule(string name) : base("azurerm_container_registry_cache_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    public string? ContainerRegistryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_registry_id")?.Value;
        set => this.WithProperty("container_registry_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ARM resource ID of the credential store which is associated with the cache rule.
    /// </summary>
    public string? CredentialSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("credential_set_id")?.Value;
        set => this.WithProperty("credential_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name of the cache rule.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The full source repository path such as &#39;docker.io/library/ubuntu&#39;.
    /// </summary>
    public string? SourceRepo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_repo")?.Value;
        set => this.WithProperty("source_repo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target repository namespace such as &#39;ubuntu&#39;.
    /// </summary>
    public string? TargetRepo
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_repo")?.Value;
        set => this.WithProperty("target_repo", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
