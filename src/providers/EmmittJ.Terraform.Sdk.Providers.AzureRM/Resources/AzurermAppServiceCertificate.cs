using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_certificate resource.
/// </summary>
public class AzurermAppServiceCertificate : TerraformResource
{
    public AzurermAppServiceCertificate(string name) : base("azurerm_app_service_certificate", name)
    {
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    [TerraformArgument("app_service_plan_id")]
    public TerraformValue<string>? AppServicePlanId
    {
        get => new TerraformReference<string>(this, "app_service_plan_id");
        set => SetArgument("app_service_plan_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string>? KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string>? KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformArgument("password")]
    public TerraformValue<string>? Password
    {
        get => new TerraformReference<string>(this, "password");
        set => SetArgument("password", value);
    }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    [TerraformArgument("pfx_blob")]
    public TerraformValue<string>? PfxBlob
    {
        get => new TerraformReference<string>(this, "pfx_blob");
        set => SetArgument("pfx_blob", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceCertificateTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [TerraformArgument("expiration_date")]
    public TerraformValue<string> ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
    }

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    [TerraformArgument("friendly_name")]
    public TerraformValue<string> FriendlyName
    {
        get => new TerraformReference<string>(this, "friendly_name");
    }

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    [TerraformArgument("host_names")]
    public TerraformList<string> HostNames
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "host_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The hosting_environment_profile_id attribute.
    /// </summary>
    [TerraformArgument("hosting_environment_profile_id")]
    public TerraformValue<string> HostingEnvironmentProfileId
    {
        get => new TerraformReference<string>(this, "hosting_environment_profile_id");
    }

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    [TerraformArgument("issue_date")]
    public TerraformValue<string> IssueDate
    {
        get => new TerraformReference<string>(this, "issue_date");
    }

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    [TerraformArgument("issuer")]
    public TerraformValue<string> Issuer
    {
        get => new TerraformReference<string>(this, "issuer");
    }

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    [TerraformArgument("subject_name")]
    public TerraformValue<string> SubjectName
    {
        get => new TerraformReference<string>(this, "subject_name");
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    [TerraformArgument("thumbprint")]
    public TerraformValue<string> Thumbprint
    {
        get => new TerraformReference<string>(this, "thumbprint");
    }

}
