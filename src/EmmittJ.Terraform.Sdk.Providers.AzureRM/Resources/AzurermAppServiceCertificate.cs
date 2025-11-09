using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("expiration_date");
        this.DeclareOutput("friendly_name");
        this.DeclareOutput("host_names");
        this.DeclareOutput("hosting_environment_profile_id");
        this.DeclareOutput("issue_date");
        this.DeclareOutput("issuer");
        this.DeclareOutput("subject_name");
        this.DeclareOutput("thumbprint");
    }

    /// <summary>
    /// The app_service_plan_id attribute.
    /// </summary>
    public TerraformProperty<string>? AppServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_plan_id");
        set => this.WithProperty("app_service_plan_id", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_id");
        set => this.WithProperty("key_vault_id", value);
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultSecretId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_secret_id");
        set => this.WithProperty("key_vault_secret_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
    }

    /// <summary>
    /// The pfx_blob attribute.
    /// </summary>
    public TerraformProperty<string>? PfxBlob
    {
        get => GetProperty<TerraformProperty<string>>("pfx_blob");
        set => this.WithProperty("pfx_blob", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
