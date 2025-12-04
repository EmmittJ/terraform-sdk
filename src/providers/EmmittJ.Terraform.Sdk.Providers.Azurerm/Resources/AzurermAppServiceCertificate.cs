using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermAppServiceCertificate.
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_app_service_certificate Terraform resource.
/// Manages a azurerm_app_service_certificate resource.
/// </summary>
public partial class AzurermAppServiceCertificate(string name) : TerraformResource("azurerm_app_service_certificate", name)
{
    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformValue<string>? AppServicePlanId
    {
        get => GetArgument<TerraformValue<string>>("app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformValue<string>? Password
    {
        get => GetArgument<TerraformValue<string>>("password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    public TerraformValue<string>? PfxBlob
    {
        get => GetArgument<TerraformValue<string>>("pfx_blob");
        set => SetArgument("pfx_blob", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
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
    /// The hosting_environment_profile_id attribute.
    /// </summary>
    public TerraformValue<string> HostingEnvironmentProfileId
        => AsReference("hosting_environment_profile_id");

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
    public AzurermAppServiceCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
