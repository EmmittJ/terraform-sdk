using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_app_service_certificate resource.
/// </summary>
public class AzurermAppServiceCertificate : TerraformResource
{
    public AzurermAppServiceCertificate(string name) : base("azurerm_app_service_certificate", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("expiration_date");
        SetOutput("friendly_name");
        SetOutput("host_names");
        SetOutput("hosting_environment_profile_id");
        SetOutput("issue_date");
        SetOutput("issuer");
        SetOutput("subject_name");
        SetOutput("thumbprint");
        SetOutput("app_service_plan_id");
        SetOutput("id");
        SetOutput("key_vault_id");
        SetOutput("key_vault_secret_id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("password");
        SetOutput("pfx_blob");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string> AppServicePlanId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_plan_id");
        set => SetProperty("app_service_plan_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_id");
        set => SetProperty("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string> KeyVaultSecretId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_vault_secret_id");
        set => SetProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    public TerraformProperty<string> PfxBlob
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pfx_blob");
        set => SetProperty("pfx_blob", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceCertificateTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformExpression ExpirationDate => this["expiration_date"];

    /// <summary>
    /// The friendly_name attribute.
    /// </summary>
    public TerraformExpression FriendlyName => this["friendly_name"];

    /// <summary>
    /// The host_names attribute.
    /// </summary>
    public TerraformExpression HostNames => this["host_names"];

    /// <summary>
    /// The hosting_environment_profile_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentProfileId => this["hosting_environment_profile_id"];

    /// <summary>
    /// The issue_date attribute.
    /// </summary>
    public TerraformExpression IssueDate => this["issue_date"];

    /// <summary>
    /// The issuer attribute.
    /// </summary>
    public TerraformExpression Issuer => this["issuer"];

    /// <summary>
    /// The subject_name attribute.
    /// </summary>
    public TerraformExpression SubjectName => this["subject_name"];

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformExpression Thumbprint => this["thumbprint"];

}
