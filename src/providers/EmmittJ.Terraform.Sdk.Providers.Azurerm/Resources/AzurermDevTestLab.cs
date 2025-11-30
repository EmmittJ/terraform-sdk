using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevTestLab.
/// Nesting mode: single
/// </summary>
public class AzurermDevTestLabTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_test_lab Terraform resource.
/// Manages a azurerm_dev_test_lab resource.
/// </summary>
public partial class AzurermDevTestLab(string name) : TerraformResource("azurerm_dev_test_lab", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> ArtifactsStorageAccountId
    {
        get => new TerraformReference<string>(this, "artifacts_storage_account_id");
    }

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultPremiumStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_premium_storage_account_id");
    }

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_storage_account_id");
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
    }

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> PremiumDataDiskStorageAccountId
    {
        get => new TerraformReference<string>(this, "premium_data_disk_storage_account_id");
    }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
    {
        get => new TerraformReference<string>(this, "unique_identifier");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestLabTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestLabTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
