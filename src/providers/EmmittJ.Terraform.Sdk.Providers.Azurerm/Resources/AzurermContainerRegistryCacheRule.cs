using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermContainerRegistryCacheRule.
/// Nesting mode: single
/// </summary>
public class AzurermContainerRegistryCacheRuleTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_container_registry_cache_rule Terraform resource.
/// Manages a azurerm_container_registry_cache_rule resource.
/// </summary>
public partial class AzurermContainerRegistryCacheRule(string name) : TerraformResource("azurerm_container_registry_cache_rule", name)
{
    /// <summary>
    /// The container_registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerRegistryId is required")]
    public required TerraformValue<string> ContainerRegistryId
    {
        get => GetArgument<TerraformValue<string>>("container_registry_id");
        set => SetArgument("container_registry_id", value);
    }

    /// <summary>
    /// The ARM resource ID of the credential store which is associated with the cache rule.
    /// </summary>
    public TerraformValue<string>? CredentialSetId
    {
        get => GetArgument<TerraformValue<string>>("credential_set_id");
        set => SetArgument("credential_set_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the cache rule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The full source repository path such as &#39;docker.io/library/ubuntu&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceRepo is required")]
    public required TerraformValue<string> SourceRepo
    {
        get => GetArgument<TerraformValue<string>>("source_repo");
        set => SetArgument("source_repo", value);
    }

    /// <summary>
    /// The target repository namespace such as &#39;ubuntu&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetRepo is required")]
    public required TerraformValue<string> TargetRepo
    {
        get => GetArgument<TerraformValue<string>>("target_repo");
        set => SetArgument("target_repo", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermContainerRegistryCacheRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermContainerRegistryCacheRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
