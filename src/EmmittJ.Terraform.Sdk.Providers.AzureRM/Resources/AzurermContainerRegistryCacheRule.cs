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
    public TerraformProperty<string>? ContainerRegistryId
    {
        get => GetProperty<TerraformProperty<string>>("container_registry_id");
        set => this.WithProperty("container_registry_id", value);
    }

    /// <summary>
    /// The ARM resource ID of the credential store which is associated with the cache rule.
    /// </summary>
    public TerraformProperty<string>? CredentialSetId
    {
        get => GetProperty<TerraformProperty<string>>("credential_set_id");
        set => this.WithProperty("credential_set_id", value);
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
    /// The name of the cache rule.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The full source repository path such as &#39;docker.io/library/ubuntu&#39;.
    /// </summary>
    public TerraformProperty<string>? SourceRepo
    {
        get => GetProperty<TerraformProperty<string>>("source_repo");
        set => this.WithProperty("source_repo", value);
    }

    /// <summary>
    /// The target repository namespace such as &#39;ubuntu&#39;.
    /// </summary>
    public TerraformProperty<string>? TargetRepo
    {
        get => GetProperty<TerraformProperty<string>>("target_repo");
        set => this.WithProperty("target_repo", value);
    }

}
