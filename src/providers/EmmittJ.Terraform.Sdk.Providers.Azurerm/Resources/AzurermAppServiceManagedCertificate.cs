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
        get => new TerraformReference<string>(this, "custom_hostname_binding_id");
        set => SetArgument("custom_hostname_binding_id", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The canonical_name attribute.
    /// </summary>
    public TerraformValue<string> CanonicalName
    {
        get => new TerraformReference<string>(this, "canonical_name");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public TerraformList<string> HostNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "host_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    public TerraformValue<string> IssueDate
    {
        get => new TerraformReference<string>(this, "issue_date");
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
    }

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    public TerraformValue<string> SubjectName
    {
        get => new TerraformReference<string>(this, "subject_name");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceManagedCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceManagedCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
