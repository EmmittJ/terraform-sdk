using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_project_default_service_accounts resource.
/// </summary>
public class GoogleProjectDefaultServiceAccounts : TerraformResource
{
    public GoogleProjectDefaultServiceAccounts(string name) : base("google_project_default_service_accounts", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("service_accounts");
    }

    /// <summary>
    /// The action to be performed in the default service accounts. Valid values are: DEPRIVILEGE, DELETE, DISABLE.
    /// 				Note that DEPRIVILEGE action will ignore the REVERT configuration in the restore_policy.
    /// </summary>
    public string? Action
    {
        get => GetProperty<TerraformLiteralProperty<string>>("action")?.Value;
        set => this.WithProperty("action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The project ID where service accounts are created.
    /// </summary>
    public string? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project")?.Value;
        set => this.WithProperty("project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The action to be performed in the default service accounts on the resource destroy.
    /// 				Valid values are NONE, REVERT and REVERT_AND_IGNORE_FAILURE. It is applied for any action but in the DEPRIVILEGE.
    /// </summary>
    public string? RestorePolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("restore_policy")?.Value;
        set => this.WithProperty("restore_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The Service Accounts changed by this resource. It is used for revert the action on the destroy.
    /// </summary>
    public TerraformExpression ServiceAccounts => this["service_accounts"];

}
