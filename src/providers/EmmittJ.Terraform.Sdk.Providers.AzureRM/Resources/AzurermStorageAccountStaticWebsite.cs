using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStorageAccountStaticWebsiteTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_account_static_website Terraform resource.
/// Manages a azurerm_storage_account_static_website resource.
/// </summary>
public partial class AzurermStorageAccountStaticWebsite(string name) : TerraformResource("azurerm_storage_account_static_website", name)
{
    /// <summary>
    /// The error_404_document attribute.
    /// </summary>
    public TerraformValue<string>? Error404Document
    {
        get => new TerraformReference<string>(this, "error_404_document");
        set => SetArgument("error_404_document", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index_document attribute.
    /// </summary>
    public TerraformValue<string>? IndexDocument
    {
        get => new TerraformReference<string>(this, "index_document");
        set => SetArgument("index_document", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageAccountStaticWebsiteTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageAccountStaticWebsiteTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
