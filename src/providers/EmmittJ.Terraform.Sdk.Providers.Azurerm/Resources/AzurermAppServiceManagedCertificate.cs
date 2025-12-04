using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceManagedCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceManagedCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_service_managed_certificate Terraform resource.
/// Manages a azurerm_app_service_managed_certificate resource.
/// </summary>
public partial class AzurermAppServiceManagedCertificate(string name) : TerraformResource("azurerm_app_service_managed_certificate", name)
{
    /// <summary>
    /// The custom_hostname_binding_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CustomHostnameBindingId is required")]
    public required TerraformValue<string> CustomHostnameBindingId
    {
        get => GetRequiredArgument<TerraformValue<string>>("custom_hostname_binding_id");
        set => SetArgument("custom_hostname_binding_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The canonical_name attribute.
    /// </summary>
    public TerraformValue<string> CanonicalName
        => AsReference("canonical_name");

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
        => AsReference("expiration_date");

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string> FriendlyName
        => AsReference("friendly_name");

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public TerraformList<string> HostNames
        => AsReference("host_names");

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    public TerraformValue<string> IssueDate
        => AsReference("issue_date");

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string> Issuer
        => AsReference("issuer");

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    public TerraformValue<string> SubjectName
        => AsReference("subject_name");

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
        => AsReference("thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceManagedCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceManagedCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
