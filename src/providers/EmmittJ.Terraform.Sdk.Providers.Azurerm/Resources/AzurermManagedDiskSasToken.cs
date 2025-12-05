using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagedDiskSasToken.
/// Nesting mode: single
/// </summary>
public class AzurermManagedDiskSasTokenTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_managed_disk_sas_token Terraform resource.
/// Manages a azurerm_managed_disk_sas_token resource.
/// </summary>
public partial class AzurermManagedDiskSasToken(string name) : TerraformResource("azurerm_managed_disk_sas_token", name)
{
    /// <summary>
    /// The access_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessLevel is required")]
    public required TerraformValue<string> AccessLevel
    {
        get => GetRequiredArgument<TerraformValue<string>>("access_level");
        set => SetArgument("access_level", value);
    }

    /// <summary>
    /// The duration_in_seconds attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DurationInSeconds is required")]
    public required TerraformValue<double> DurationInSeconds
    {
        get => GetRequiredArgument<TerraformValue<double>>("duration_in_seconds");
        set => SetArgument("duration_in_seconds", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The managed_disk_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedDiskId is required")]
    public required TerraformValue<string> ManagedDiskId
    {
        get => GetRequiredArgument<TerraformValue<string>>("managed_disk_id");
        set => SetArgument("managed_disk_id", value);
    }

    /// <summary>
    /// The sas_url attribute.
    /// </summary>
    public TerraformValue<string> SasUrl
        => CreateReference("sas_url");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedDiskSasTokenTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedDiskSasTokenTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
